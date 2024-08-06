using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftCaisse.Utils.Global
{
    public class ConnectedUser
    {
        public static int UserId;
        public static string UserName;
        public static RoleUser roles;
    }
    public enum RoleUser
    {
        Admin,
        User
    }
}
