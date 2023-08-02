using TestApp.Data.Models;

namespace TestApp.Data.Services;

public class ProductService
{
    private readonly AppDbContext dbContext;
    public ProductService(AppDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    //Create product

    public bool CreateProduct(Product product)
    {;
        dbContext.Products.Add(product);
        dbContext.SaveChanges();
        return true;
    }

    //Read product

    public List<Product> GetProducts()
    {
        var products = dbContext.Products.ToList();
        return products;
    }

    //Update product

    public void UpdateProduct(Product product)
    {
        var pro = dbContext.Products.FirstOrDefault(p => p.Id == product.Id);

        pro.Name = product.Name;
        pro.Price = product.Price;

        dbContext.Products.Update(pro);
        dbContext.SaveChanges();
    }

    //Delete product

    public void DeleteProduct(int id)
    {
        var product = dbContext.Products.FirstOrDefault(p => p.Id == id);
        dbContext.Products.Remove(product);
        dbContext.SaveChanges();
    }
}
