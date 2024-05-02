using System.Collections.Generic;

namespace AvaloniaApplication1.Models;

public class Products
{
    public string ProdName { get; set; }
    public double ProdPrice { get; set; }
    public string ProdDescription { get; set; }
}

public class ProductList
{
    public List<Products> _productsList = new List<Products>();
}