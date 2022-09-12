using System.Windows.Controls;
using UsersList.App.Models;

namespace UsersList.App.Components.UserCardComponent;

public partial class UserCardComponent : UserControl
{
    public User User { get; }

    public UserCardComponent(User user)
    {
        User = user;
        InitializeComponent();
    }
}

