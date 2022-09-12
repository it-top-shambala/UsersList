using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace UsersList.App.Models;

public static class Users
{
    public static IEnumerable<User> GetUsers()
    {
        var file = File.ReadAllText("Models/users.json");
        var users = JsonSerializer.Deserialize<IEnumerable<User>>(file);
        return users;
    }
}
