using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using baomatthudientu.DAL;
using baomatthudientu.DTO;

namespace baomatthudientu.BLL
{
    internal class MailBLL
    {
        public static bool addMail(string sub, string context, string sender, string receiver, DateTime time)
        {
            return MailDAL.addMail(sub, context, sender, receiver, time);
        }
        public static List<MailDTO> getMail(string email)
        {
            return MailDAL.getMail(email);
        }
    }
}
