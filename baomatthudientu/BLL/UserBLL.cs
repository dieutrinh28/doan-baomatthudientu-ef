using baomatthudientu.DAL;
using baomatthudientu.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baomatthudientu.BLL
{
    internal class UserBLL
    {
        public static List<UserDTO> getAll()
        {
            return UserDAL.getAll();
        }
        public static string getEmail(string username)
        {
            return UserDAL.getEmail(username);
        }
    }
}
