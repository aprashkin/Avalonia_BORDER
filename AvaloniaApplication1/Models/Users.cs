using System.Collections.Generic;

namespace AvaloniaApplication1.Models;

public class Users
{
    public string UserName { get; set; }
    public string UserSurname { get; set; }
    
    public bool IsAdmin { get; set; }



    public static class UserList
    {
        public static List<Users> UsersList = new()
        {
            new Users { UserName = "IVAN", UserSurname = "IVANOV", IsAdmin = false}
        };

    }
}