using System.Collections.Generic;

namespace AvaloniaApplication1.Models;

public class Products
{
    public string ProdName { get; set; }
    public double ProdPrice { get; set; }
    public string ProdDescription { get; set; }
    public int ProdCount { get; set; }
    
    public string ProdManufacturer { get; set; }
    
}


public static class ProductList
{
    public static List <Products> productsList = new ()
    {
        new Products {ProdName = "ProdName", ProdPrice = 350, ProdCount = 10, ProdDescription = "CoolDescriptionCoolDescriptionCoolDescriptionCoolDescription", ProdManufacturer = "ZaVod"},
        /*new Products {ProdName = "ProdName", ProdPrice = 350, ProdCount = 10, ProdDescription = "CoolDescriptionCoolDescriptionCoolDescriptionCoolDescription", ProdManufacturer = "ZaVod"},
        new Products {ProdName = "ProdName", ProdPrice = 350, ProdCount = 10, ProdDescription = "CoolDescriptionCoolDescriptionCoolDescriptionCoolDescription", ProdManufacturer = "ZaVod"},
        new Products {ProdName = "ProdName", ProdPrice = 350, ProdCount = 10, ProdDescription = "CoolDescriptionCoolDescriptionCoolDescriptionCoolDescription", ProdManufacturer = "ZaVod"},
        new Products {ProdName = "ProdName", ProdPrice = 350, ProdCount = 10, ProdDescription = "CoolDescriptionCoolDescriptionCoolDescriptionCoolDescription", ProdManufacturer = "ZaVod"},
        new Products {ProdName = "ProdName", ProdPrice = 350, ProdCount = 10, ProdDescription = "CoolDescriptionCoolDescriptionCoolDescriptionCoolDescription", ProdManufacturer = "ZaVod"},
        new Products {ProdName = "ProdName", ProdPrice = 350, ProdCount = 10, ProdDescription = "CoolDescriptionCoolDescriptionCoolDescriptionCoolDescription CoolDescriptionCoolDescriptionCoolDescriptionCoo lDescription", ProdManufacturer = "ZaVod"},
        new Products {ProdName = "ProdName", ProdPrice = 350, ProdCount = 10, ProdDescription = "CoolDescriptionCoolDescriptionCoolDescriptionCoolDescription", ProdManufacturer = "ZaVod"},
        new Products {ProdName = "ProdName", ProdPrice = 350, ProdCount = 10, ProdDescription = "CoolDescriptionCoolDescriptionCoolDescriptionCoolDescription", ProdManufacturer = "ZaVod"},
        new Products {ProdName = "ProdName", ProdPrice = 350, ProdCount = 10, ProdDescription = "CoolDescriptionCoolDescriptionCoolDescriptionCoolDescription", ProdManufacturer = "ZaVod"},
        new Products {ProdName = "ProdName", ProdPrice = 350, ProdCount = 10, ProdDescription = "CoolDescriptionCoolDescriptionCoolDescriptionCoolDescription", ProdManufacturer = "ZaVod"}*/
        
    };
}