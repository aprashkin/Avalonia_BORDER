using System.Collections.Generic;
using System.Threading.Tasks;
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

    

    private async void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        if (string.IsNullOrWhiteSpace(prodName.Text) || string.IsNullOrWhiteSpace(prodDecsription.Text))

        {
            EBlock.Text = "Заполните все поля!";
            await Task.Delay(3000);
            EBlock.Text = string.Empty;
            return;
        }

        if (!int.TryParse(prodPrice.Text, out var price))
        {
            EBlock.Text = "Введите корректную цену!";
            await Task.Delay(3000);
            EBlock.Text = string.Empty;
            return;
        }
        
        if (!int.TryParse(prodCount.Text, out var count))
        {
            EBlock.Text = "Введите корректное количество!";
            await Task.Delay(3000);
            EBlock.Text = string.Empty;
            return;
        }
        
        {
            var newProd = new Products
            {
                ProdDescription = prodDecsription.Text,
                ProdName = prodName.Text,
                ProdManufacturer = (string)((ComboBoxItem)ManufacturerBox.SelectedItem).Content,
                ProdPrice = price,
                ProdCount = count
            };
          
           ProductList.productsList.Add(newProd);
            
        }
        MainWindow mainWindow = new MainWindow();
        mainWindow.Show();
        this.Close();
    }

    private void back_add_main(object? sender, RoutedEventArgs e)
    {
        MainWindow mainWindow = new MainWindow();
        mainWindow.Show();
        Close();
    }
}