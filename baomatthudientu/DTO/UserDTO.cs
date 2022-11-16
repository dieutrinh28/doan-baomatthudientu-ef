using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baomatthudientu.DTO
{
    internal class UserDTO
    {
        private int _Id;
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        private string _UserName;
        public string UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
        }
        private string _Password;
        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }
        private string _Email;
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        public UserDTO(int Id_, string UserName_, string Password_, string Email_)
        {
            this.Id = Id_;
            this.UserName = UserName_;
            this.Password = Password_;
            this.Email = Email_;
        }
        public UserDTO()
        {
            this.Id = 0;
            this.UserName = "";
            this.Password = "";
            this.Email = "";
        }
    }
}
