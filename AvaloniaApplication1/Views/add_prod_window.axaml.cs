using System.Collections.Generic;
using System.Threading.Tasks;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.Media.Imaging;
using AvaloniaApplication1.Models;

namespace AvaloniaApplication1.Views;

public partial class add_prod_window : Window
{
    private Bitmap _imagePath;
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
                ProdCount = count,
                ImagePath = _imagePath
            };
          
            ProductList.productsList.Add(newProd);
            
        }
        
        MainWindow mainWindow = new MainWindow(true);
        mainWindow.Show();
        this.Close();
    }

    private void back_add_main(object? sender, RoutedEventArgs e)
    {
        MainWindow mainWindow = new MainWindow(true);
        mainWindow.Show();
        Close();
    }

    private async void add_image(object? sender, RoutedEventArgs e)
    {
        var fileDialog = new OpenFileDialog
        {
            AllowMultiple = false,
            Title = "Выберите изображение",
            Directory = "C:\\Users\\prdb\\RiderProjects\\Avalonia_BORDER\\AvaloniaApplication1\\Assets",
            Filters = new List<FileDialogFilter>
            {
                new FileDialogFilter { Name = "Images", Extensions = { "jpg", "png", "jpeg", "ico" } }
            }
        };

        var result = await fileDialog.ShowAsync(this);

        if (result != null && result.Length > 0)
        {
            var imagePath= result[0];
            var bitmap = new Bitmap(imagePath);
            _imagePath = bitmap;
        }
        
    }
    
    
}