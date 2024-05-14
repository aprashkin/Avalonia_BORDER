using System.Collections.Generic;
using System.Linq;
using Avalonia.Controls;
using Avalonia.Interactivity;
using AvaloniaApplication1.Models;

namespace AvaloniaApplication1.Views;

public partial class MainWindow : Window
{   List<Products> ListPr = new ();
    public MainWindow(bool isAdmin)
    {
        InitializeComponent();
        if (isAdmin)
            AddButton.IsVisible = true;
        
        foreach (Products pr in ProductList.productsList)
            ListPr.Add(pr);
        
        ProductListBox.ItemsSource = ListPr.ToList();
    }

    public MainWindow()
    {
        InitializeComponent();
    }
    
    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        add_prod_window prodWindow = new add_prod_window();
        prodWindow.Show();
        this.Close();
    }
}