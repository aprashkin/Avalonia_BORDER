using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using AvaloniaApplication1.Models;

namespace AvaloniaApplication1.Views;

public partial class login_page : Window
{
    public login_page()
    {
        InitializeComponent();
    }

    private void how_guest(object? sender, RoutedEventArgs e)
    {
        MainWindow mainWindow = new MainWindow(false);
        mainWindow.Show();
        Close();
    }

    private void how_admin_or_user(object? sender, RoutedEventArgs e)
    {
        if (LoginTextBox.Text != "admin" && PasswordTextBox.Text != "admin") return;
        var NewUser = new Users
        {
            UserName = "ADMIN",
            UserSurname = "ADMINOVICH",
            IsAdmin = true
        };
        Users.UserList.UsersList.Add(NewUser);
            
        MainWindow mainWindow = new MainWindow(true);
        mainWindow.Show();
        Close();

    }
}