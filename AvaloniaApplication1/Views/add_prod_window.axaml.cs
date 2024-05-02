using System.Collections.Generic;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using AvaloniaApplication1.Models;

namespace AvaloniaApplication1.Views;

public partial class add_prod_window : Window
{
    public add_prod_window()
    {
        InitializeComponent();
    }

    public List<Products> ProductsList2 = new List<Products>();
    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        {
            var newProd = new Products
            {
                ProdDescription = prodDecsription.Text,
                ProdName = prodName.Text,
                ProdPrice = int.Parse(prodPrice.Text)
            };
            ProductsList2.Add(newProd);
        }
        MainWindow mainWindow = new MainWindow(ProductsList2);
        mainWindow.Show();
        this.Close();
    }
}