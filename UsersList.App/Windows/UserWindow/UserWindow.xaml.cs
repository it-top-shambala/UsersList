using System.Windows;
using UsersList.App.Models;

namespace UsersList.App.Windows.UserWindow;

public partial class UserWindow : Window
{
    public User User { get; }

    public UserWindow(User user)
    {
        User = user;
        InitializeComponent();
    }
}

