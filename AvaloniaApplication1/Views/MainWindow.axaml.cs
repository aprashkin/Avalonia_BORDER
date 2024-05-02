using System.Collections.Generic;
using System.Linq;
using Avalonia.Controls;
using Avalonia.Interactivity;
using AvaloniaApplication1.Models;

namespace AvaloniaApplication1.Views;

public partial class MainWindow : Window
{   List<Products> ListPr = new List<Products>();
    public MainWindow()
    {
        InitializeComponent();
    }
    public MainWindow(List<Products> productsList)
    {
        InitializeComponent();
        ProductListBox.ItemsSource = ListPr.ToList();
        foreach (Products product in productsList)
        {
            
            ListPr.Add(product);

        }
        
        
        
        ProductListBox.ItemsSource = ListPr.ToList();
    }

    


    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        add_prod_window prodWindow = new add_prod_window();
        prodWindow.Show();
        this.Close();
    }
}