using baomatthudientu.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baomatthudientu.DAL
{
    internal class UserDAL
    {
        public static List<UserDTO> GetAll()
        {
            BAOMATTHUDIENTUEntities data = new BAOMATTHUDIENTUEntities();
            var truyvan = from user in data.Users
                          select user;
            List<UserDTO> listUser = new List<UserDTO>();
            foreach (User user in truyvan)
            {
                //Chuyển đổi từ NhanVien sang NhanVienDTO
                UserDTO dto = new UserDTO();
                dto.Id = user.Id;
                dto.UserName = user.Username;
                dto.Password = user.Password;
                dto.Email = user.Email;

                listUser.Add(dto);
            }
            return listUser;
        }
    }
}
