using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualProject
{
    public partial class Form2 : Form
    {
        GroupBox items;
        private ListBox listBoxCart;
        private Button btnCheckout;
        private List<string> cart = new List<string>();
        private string connectionString = 
            "Data Source=C:\\Users\\mhmta\\Desktop\\visualProjectDb.db;Version=3;";

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadMenuItems();
        }
        public Form2()
        {
            InitializeComponent();
            // Initialize the form and controls
            this.Text = "Menu Items";
            this.Size = new Size(1200, 1000);

            // GroupBox for menu items
            items = new GroupBox
            {
                Text = "Menu",
                Font = new Font("Arial", 14, FontStyle.Bold),
                Location = new Point(10, 10),
                Size = new Size(600, 900),
            };

            // ListBox for the cart
            listBoxCart = new ListBox
            {
                Location = new Point( 625, 50),
                Size = new Size(250, 400),
            };

            // Button to checkout
            btnCheckout = new Button
            {
                Text = "Checkout",
                Location = new Point(625, 460),
                Size = new Size(250, 40),
            };
            btnCheckout.Click += BtnCheckout_Click;

            this.Controls.Add(items);
            this.Controls.Add(listBoxCart);
            this.Controls.Add(btnCheckout);

            LoadMenuItems();
        }

        private void LoadMenuItems()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Name, Description, Price, Category FROM MenuItems WHERE IsAvailable = 1";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    int yPosition = 30; // ilk y pozisyonu
                    while (reader.Read())
                    { 
                        string name = reader["Name"].ToString();
                        string description = reader["Description"].ToString();
                        string category = reader["Category"].ToString();
                        double price = Convert.ToDouble(reader["Price"]);

                        // Create a Label for the item name
                        Label lblName = new Label
                        {
                            Text = $"{name} - {category} (${price:F2})",
                            Font = new Font("Arial", 10, FontStyle.Bold),
                            AutoSize = true,
                            Location = new Point(20, yPosition),
                        };
                        items.Controls.Add(lblName);

                        // Create a Label for the item description
                        Label lblDescription = new Label
                        {
                            Text = description,
                            Font = new Font("Arial", 8, FontStyle.Italic),
                            AutoSize = true,
                            Location = new Point(40, yPosition + 25), // açıklama y pozisyonunun altında
                        };
                        items.Controls.Add(lblDescription);

                        // Create a button to add to cart
                        Button btnAddToCart = new Button
                        {
                            Text = "Add",
                            Font = new Font("Arial", 8),
                            Location = new Point(500, yPosition),
                            Size = new Size(90, 25),
                            Tag = name+" : "+price, // Store the name of the item in the Tag property
                        };
                        btnAddToCart.Click += BtnAddToCart_Click;
                        items.Controls.Add(btnAddToCart);

                        // Add spacing for the next item
                        yPosition += 60;
                    }
                }
            }
        }

        private void BtnAddToCart_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null && button.Tag != null)
            {
                string item = button.Tag.ToString();
                cart.Add(item);
                listBoxCart.Items.Add(item);
            }
        }

        private void BtnCheckout_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(cart);
            form3.Show();
            this.Hide();
        }

    }
}
