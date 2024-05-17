using System.Collections.Generic;
using Avalonia.Media.Imaging;

namespace AvaloniaApplication1.Models;

public class Products
{
    public string ProdName { get; set; }
    public double ProdPrice { get; set; }
    public string ProdDescription { get; set; }
    public int ProdCount { get; set; }
    public Bitmap ImagePath { get; set;  } 
    public string ProdManufacturer { get; set; }
    public bool InStock { get; set; }

    

}


public static class ProductList
{
    public static List <Products> productsList = new ()
    {
        new Products
        {
            ProdName = "ProdName", ProdPrice = 350, ProdCount = 10, ProdDescription = "CoolDescriptionCoolDescriptionCoolDescriptionCoolDescription", ProdManufacturer = "ZaVod", ImagePath = new Bitmap("C:\\Users\\prdb\\RiderProjects\\Avalonia_BORDER\\AvaloniaApplication1\\Assets\\images.png")
        },
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