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
            UsersPanel.Children.Add(new UserCardComponent(user));
        }
    }
}
