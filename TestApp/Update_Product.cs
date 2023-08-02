using TestApp.Data.Models;
using TestApp.Data.Services;

namespace TestApp;

public partial class Update_Product : Form
{
    public ProductService ProductService { get; }
    public ListItem UpdatedProduct { get; }

    public Update_Product()
    {
        InitializeComponent();
    }


    public Update_Product(ProductService productService, ListItem updatedProduct)
    {
        InitializeComponent();

        ProductService = productService;
        UpdatedProduct = updatedProduct;
    }

    private bool ValidTextBoxesForUpdate()
    {
        if (string.IsNullOrEmpty(textBox2.Text))
        {
            label6.Text = "Product name cannot be empty.";
            return false;
        }

        if (string.IsNullOrEmpty(textBox1.Text))
        {
            label5.Text = "Product price cannot be empty.";
            return false;
        }

        if (!IsNumeric(textBox1.Text))
        {
            label5.Text = "Product price must contain only numeric characters.";
            return false;
        }

        label6.Text = label5.Text = string.Empty;

        return true;
    }

    private bool IsNumeric(string text)
    {
        return int.TryParse(text, out _);
    }

    private void updateButton_Click(object sender, EventArgs e)
    {
        if (!ValidTextBoxesForUpdate()) return;

        var updateProduct = new Product
        {
            Id = UpdatedProduct.ProductId,
            Name = textBox2.Text,
            Price = Convert.ToDecimal(textBox1.Text)
        };

        ProductService.UpdateProduct(updateProduct);

        textBox2.Text = textBox1.Text = string.Empty;

        this.Close();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
