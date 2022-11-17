﻿using baomatthudientu.DAL;
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
        public static List<UserDTO> GetAll()
        {
            return UserDAL.GetAll();
        }
        public static UserDTO getUser(string username)
        {
            return UserDAL.getUser(username);
        }
    }
}
