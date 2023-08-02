using TestApp.Data.Services;

namespace TestApp;

public partial class ListItem : UserControl
{

    private string name;
    private string price;
    private string date;

    public int ProductId { get; set; }
    public ProductService productService { get; set; }


    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
            label4.Text = value;
        }
    }
    public string Price
    {
        get
        {
            return price;
        }
        set
        {
            price = value.ToString();
            label5.Text = price;
        }
    }
    public string Date
    {
        get
        {
            return date;
        }
        set
        {
            date = value;
            label6.Text = date;
        }
    }

    public ListItem()
    {
        InitializeComponent();
    }

    private void pictureBox3_Click(object sender, EventArgs e)
    {
        productService.DeleteProduct(ProductId);
        this.Visible = false;
    }

    private void pictureBox2_Click(object sender, EventArgs e)
    {
        Update_Product updatePage = new Update_Product(productService, this);
        updatePage.Show();
    }
}
