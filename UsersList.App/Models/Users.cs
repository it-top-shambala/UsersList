using System.Collections.Generic;

namespace UsersList.App.Models;

public static class Users
{
    public static IEnumerable<User> GetUsers()
    {
        return new List<User>();
    }
}
