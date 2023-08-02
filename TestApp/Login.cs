using Microsoft.Extensions.Caching.Memory;
using TestApp.Data.DTOs;
using TestApp.Data.Models;
using TestApp.Data.Services;

namespace TestApp;

public partial class Login : Form
{
    private UserService userService { get; }
    private UserAuth defaultUser;
    private readonly IMemoryCache _cache;
    private ProductService productService { get; }


    private const string CacheKey = "RememberMeData";

    public Login()
    {
        InitializeComponent();
    }

    public Login(IMemoryCache memoryCache)
    {
        InitializeComponent();

        _cache = memoryCache;
    }
    public Login(UserService userService, IMemoryCache memoryCache, ProductService productService)
    {
        InitializeComponent();
        this.userService = userService;
        _cache = memoryCache;
        this.productService = productService;
    }

    public Login(UserAuth userAuth, UserService userService, IMemoryCache _cache)
    {
        InitializeComponent();
        defaultUser = userAuth;
        this.userService = userService;
        this._cache = _cache;
        textBox1.Text = defaultUser.Username;
        textBox2.Text = defaultUser.Password;
    }
    public Login(UserAuth userAuth, UserService userService, IMemoryCache _cache, ProductService productService)
    {
        InitializeComponent();
        defaultUser = userAuth;
        this.userService = userService;
        this._cache = _cache;
        this.productService = productService;
        textBox1.Text = defaultUser.Username;
        textBox2.Text = defaultUser.Password;
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
    }

    private void textBox1_Click(object sender, EventArgs e)
    {
        textBox1.BackColor = Color.White;
        panel3.BackColor = Color.White;
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

    private void button2_Click(object sender, EventArgs e)
    {
        this.Hide();
        Register register = new Register(userService, productService, _cache);
        register.ShowDialog();
        this.Close();
    }

    private async void button1_Click(object sender, EventArgs e)
    {
        if (textBox1.Text == string.Empty)
        {
            ErrorLabel.Text = "Username cannot be empty";
            return;
        }

        if (!ValidPassword(textBox2.Text)) return;

        var existingUser = await userService.Login(new User { Username = textBox1.Text, Password = textBox2.Text});

        if (existingUser.IsAuth)
        {
            if(checkBox1.Checked)
            {
                var rememberMeData = new RememberMeData
                {
                    Login = existingUser.Username,
                    Password = textBox2.Text,
                    UserId = existingUser.Id.ToString(),
                    RememberMe = true
                };

                var cacheEntryOptions = new MemoryCacheEntryOptions
                {
                    AbsoluteExpirationRelativeToNow = TimeSpan.FromDays(7) // 7 kun gacha kesh saqlanadi
                };

                //_cache.Set(CacheKey, rememberMeData, cacheEntryOptions);
            }
            else
            {
                //_cache.Remove(CacheKey);
            }

            this.Hide();
            Home home = new Home(productService, existingUser, userService);
            home.ShowDialog();
            this.Close();
        }
        else
        {
            ErrorLabel.Text = "This user not found!";
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