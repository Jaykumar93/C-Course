public class Product
{
    public int productID;
    public string productName;
    public double cost;
    public int quantityInStock;
}

public class DomesticProduct : Product
{
    public void Method1()
    {
        productID = 1;
        productName = "abc"; 
        cost = 1000; 
        quantityInStock = 10; 
    }
}

public class OtherClass
{
    public void Method1()
    {
        Product product = new Product();
        product.productID = 1;
        product.productName = "abc"; 
        product.cost = 2000; 
        product.quantityInStock = 10; 
    }
}
