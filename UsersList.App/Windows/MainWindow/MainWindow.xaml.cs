using System.Collections.Generic;
using System.Windows;
using UsersList.App.Components.UserCardComponent;
using UsersList.App.Models;

namespace UsersList.App.Windows.MainWindow;

public partial class MainWindow : Window
{
    private readonly IEnumerable<User> _users;

    public MainWindow()
    {
        _users = Users.GetUsers();
        InitializeComponent();
        InitUserPanel();
    }

    private void InitUserPanel()
    {
        foreach (var user in _users)
        {
            var userCard = new UserCardComponent(user)
            {
                Margin = new Thickness(10.0)
            };
            userCard.MouseDoubleClick += (sender, args) =>
            {
                new UserWindow.UserWindow(user).Show();
            };
            UsersPanel.Children.Add(userCard);
        }
    }
}
