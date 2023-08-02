using Microsoft.Extensions.Caching.Memory;
using TestApp.Data.DTOs;
using TestApp.Data.Models;
using TestApp.Data.Services;

namespace TestApp;

public partial class Home : Form
{
    private bool sidebarExpand;
    private UserAuth user;
    private ProductService productService { get; }
    private UserService userService { get; }
    private IMemoryCache cache { get; set; }



    public Home()
    {
        InitializeComponent();
        flowLayoutPanel1.Controls.Clear();
    }

    public Home(UserAuth user)
    {
        this.user = user;
        InitializeComponent();
        flowLayoutPanel1.Controls.Clear();
    }

    public Home(ProductService productService, UserAuth user)
    {
        this.productService = productService;
        this.user = user;
        InitializeComponent();
        flowLayoutPanel1.Controls.Clear();
    }

    public Home(ProductService productService, UserAuth user, UserService userService)
    {
        this.productService = productService;
        this.user = user;
        this.userService = userService;
        InitializeComponent();
        flowLayoutPanel1.Controls.Clear();
    }


    private void sidebarTimer_Tick(object sender, EventArgs e)
    {
        if (sidebarExpand)
        {
            sidebar.Width -= 10;
            if (sidebar.Width == sidebar.MinimumSize.Width)
            {
                sidebarExpand = false;
                sidebarTimer.Stop();
            }
        }
        else
        {
            sidebar.Width += 10;
            if (sidebar.Width == sidebar.MaximumSize.Width)
            {
                sidebarExpand = true;
                sidebarTimer.Stop();
            }
        }
    }

    private void menuButton_Click(object sender, EventArgs e)
    {
        sidebarTimer.Start();
    }

    private void logoutButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        var login = new Login(userService, cache, productService);
        login.ShowDialog();
        this.Close();
    }

    private void myStoreButton_Click(object sender, EventArgs e)
    {
        var products = productService.GetProducts();

        if (flowLayoutPanel1.Controls.Count > 0)
            flowLayoutPanel1.Controls.Clear();

        foreach (var product in products)
        {
            flowLayoutPanel1.Controls.Add(new ListItem
            {
                ProductId = (int)product.Id,
                Name = product.Name,
                Price = product.Price.ToString(),
                Date = product.DateAdded.ToString("dd/MM/yyyy"),
                productService = productService
            });
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        flowLayoutPanel1.Controls.Clear();
        flowLayoutPanel1.Controls.Add(panel6);
    }

    private void button4_Click(object sender, EventArgs e)
    {
        flowLayoutPanel1.Controls.Clear();
    }

    private void CreateButton_Click(object sender, EventArgs e)
    {
        if (!ValidTextBoxes()) return;

        var newProduct = new Product
        {
            Name = ProductName.Text,
            Price = Convert.ToDecimal(Price.Text),
            DateAdded = DateTime.Now,
            AddedUser = user.Username
        };

        productService.CreateProduct(newProduct);

        ProductName.Text = Price.Text = string.Empty;
    }

    private bool ValidTextBoxes()
    {
        if (string.IsNullOrEmpty(ProductName.Text))
        {
            errorName.Text = "Product name cannot be empty.";
            return false;
        }

        if (string.IsNullOrEmpty(Price.Text))
        {
            errorPrice.Text = "Product price cannot be empty.";
            return false;
        }

        if (!IsNumeric(Price.Text))
        {
            errorPrice.Text = "Product price must contain only numeric characters.";
            return false;
        }

        errorName.Text = errorPrice.Text = string.Empty;

        return true;
    }
    private bool IsNumeric(string text)
    {
        return int.TryParse(text, out _);
    }

    private void button3_Click(object sender, EventArgs e)
    {
        MessageBox.Show("This application was developed by Orzibek Salohiddinov. For questions and suggestions, contact the following email:\r\norzibeksalohiddinov@gmail.com",
            "Copyright",
            MessageBoxButtons.OK
            );
    }
}
