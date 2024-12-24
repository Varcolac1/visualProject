using System.Data.SQLite;
using System.Security.Cryptography;
using System.Text;

namespace VisualProject
{
    public partial class Form1 : Form
    {
        //private string connectionString = @"C:\Users\mhmta\visualProjectDb.db";
        string connectionString =
            "Data Source=C:\\Users\\mhmta\\Desktop\\visualProjectDb.db;Version=3;";

        public Form1()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string emailOrUsername = loginUsernameTxt.Text.Trim();
            string password = LoginPasswordTxt.Text;

            if (string.IsNullOrWhiteSpace(emailOrUsername) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username/email and password.");
                return;
            }

            if (LoginUser(emailOrUsername, password))
            {
                MessageBox.Show("Login successful!");
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username/email or password.");
            }
        }

        private void usernameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void regsiterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loginBox.Visible = false;
            registerBox.Visible = true;
        }

        private void loginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loginBox.Visible = true;
            registerBox.Visible = false;
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            string email = registerEmailTxt.Text.Trim();
            string username = registerUsernameTxt.Text.Trim();
            string password = registerPasswordTxt.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            RegisterUser(email, username, password);
        }
        private bool LoginUser(string emailOrUsername, string password)
        {
            string hashedPassword = HashPassword(password);

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"
                    SELECT COUNT(*) 
                    FROM Users 
                    WHERE (Email = @EmailOrUsername OR Username = @EmailOrUsername) 
                      AND Password = @Password";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmailOrUsername", emailOrUsername);
                        command.Parameters.AddWithValue("@Password", hashedPassword);

                        int count = Convert.ToInt32(command.ExecuteScalar());
                        return count > 0; // If count > 0, user exists and password matches.
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                    return false;
                }
            }
        }
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
        private void RegisterUser(string email, string username, string password)
        {
            string hashedPassword = HashPassword(password);

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Users (Email, Username, Password) VALUES (@Email, @Username, @Password)";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", hashedPassword);

                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("User registered successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Registration failed. Try again.");
                        }
                    }
                }
                catch (SQLiteException ex) when (ex.ErrorCode == (int)SQLiteErrorCode.Constraint)
                {
                    MessageBox.Show("Email or Username already exists. Please use a different one.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void loginBox_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loginBox.Visible = true;
            registerBox.Visible = false;
        }
    }
}
