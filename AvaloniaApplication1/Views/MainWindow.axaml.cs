using System.Collections.Generic;
using System.Linq;
using Avalonia.Controls;
using Avalonia.Interactivity;
using AvaloniaApplication1.Models;

namespace AvaloniaApplication1.Views;

public partial class MainWindow : Window
{   List<Products> ListPr = new ();
    private List<Users> ListUs = new();
    
    public MainWindow(bool isAdmin)
    {
        InitializeComponent();
        if (isAdmin)
            AddButton.IsVisible = true;
        
        
        foreach (Products pr in ProductList.productsList)
            ListPr.Add(pr);
        
        ProductListBox.ItemsSource = ListPr.ToList();

        foreach (Users users in ListUs)
        {
            ListUs.Add(users);
        }

        
    }

    public void GetCount()
    {
        foreach (Products products in ProductList.productsList)
        {
            if (products.InStock = false)
            {
                
            }
                
        }
    }
    public MainWindow()
    {
        InitializeComponent();
        
        foreach (Products pr in ProductList.productsList)
            ListPr.Add(pr);
        ProductListBox.ItemsSource = ListPr.ToList();
        foreach (Users users in ListUs)
        {
            ListUs.Add(users);
        }

        /*UserListBox.ItemsSource = ListUs.ToList();*/
    }
    
    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        add_prod_window prodWindow = new add_prod_window();
        prodWindow.Show();
        this.Close();
    }

    private void escape(object? sender, RoutedEventArgs e)
    {
        login_page loginPage = new login_page();
        loginPage.Show();
        this.Close();
    }
}