using Microsoft.Extensions.Caching.Memory;
using TestApp.Data.Models;
using TestApp.Data.Services;

namespace TestApp;

public partial class Register : Form
{

    private UserService userService { get; }
    private readonly IMemoryCache cache;
    private ProductService productService { get; }

    public Register()
    {
        InitializeComponent();
    }
    public Register(UserService userService)
    {
        InitializeComponent();
        this.userService = userService;
    }
    public Register(UserService userService, IMemoryCache cache)
    {
        InitializeComponent();
        this.cache = cache;
        this.userService = userService;
    }

    public Register(UserService userService, ProductService productService, IMemoryCache cache)
    {
        InitializeComponent();
        this.cache = cache;
        this.userService = userService;
        this.productService = productService;
    }

    private void closeBtn_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void textBox2_Click(object sender, EventArgs e)
    {
        textBox2.BackColor = Color.White;
        panel4.BackColor = Color.White;
        textBox1.BackColor = SystemColors.Control;
        panel3.BackColor = SystemColors.Control;
        textBox3.BackColor = SystemColors.Control;
        panel5.BackColor = SystemColors.Control;
    }

    private void textBox1_Click(object sender, EventArgs e)
    {
        textBox1.BackColor = Color.White;
        panel3.BackColor = Color.White;
        textBox2.BackColor = SystemColors.Control;
        panel4.BackColor = SystemColors.Control;
        textBox3.BackColor = SystemColors.Control;
        panel5.BackColor = SystemColors.Control;
    }

    private void textBox3_Click(object sender, EventArgs e)
    {
        textBox3.BackColor = Color.White;
        panel5.BackColor = Color.White;
        textBox1.BackColor = SystemColors.Control;
        panel3.BackColor = SystemColors.Control;
        textBox2.BackColor = SystemColors.Control;
        panel4.BackColor = SystemColors.Control;
    }

    private void pictureBox4_Click(object sender, EventArgs e)
    {
        textBox2.UseSystemPasswordChar = !textBox2.UseSystemPasswordChar;
        pictureBox4.Image = textBox2.UseSystemPasswordChar ?
            Properties.Resources.eye_sawn_t_icon
            : Properties.Resources.eye_saw_icon;
    }

    private void pictureBox5_Click(object sender, EventArgs e)
    {
        textBox3.UseSystemPasswordChar = !textBox3.UseSystemPasswordChar;
        pictureBox5.Image = textBox3.UseSystemPasswordChar ?
            Properties.Resources.eye_sawn_t_icon
            : Properties.Resources.eye_saw_icon;
    }

    private void button2_Click(object sender, EventArgs e)
    {
        this.Hide();
        var login = new Login();
        login.ShowDialog();
        this.Close();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (textBox1.Text == string.Empty)
        {
            ErrorLabel.Text = "Username cannot be empty";
            return;
        }

        if (!ValidPassword(textBox2.Text)) return;

        if (textBox2.Text != textBox3.Text)
        {
            ErrorLabel.Text = "The password and the retyped password are not the same";
            return;
        }

        var createdUser = userService.Register(new User { Username = textBox1.Text, Password = textBox2.Text });

        if (createdUser.IsAuth)
        {
            this.Hide();
            var login = new Login(createdUser, userService, cache, productService);
            login.ShowDialog();
            this.Close();
        }
        else
        {
            ErrorLabel.Text = "This user already exists!";
            return;
        }
    }

    private bool ValidPassword(string password)
    {
        if (string.IsNullOrEmpty(password))
        {
            ErrorLabel.Text = "Please enter your password";
            return false;
        }

        if (password.Length < 8)
        {
            ErrorLabel.Text = "Your password length is less than 8";
            return false;
        }

        if (!password.Any(char.IsUpper))
        {
            ErrorLabel.Text = "The password does not contain capital letters";
            return false;
        }

        if (!password.Any(char.IsDigit))
        {
            ErrorLabel.Text = "The password does not contain a number";
            return false;
        }

        ErrorLabel.Text = string.Empty;

        return true;
    }
}