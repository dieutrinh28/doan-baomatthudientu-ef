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
        public static bool addMail(string sub, string context, string sender, string receiver, DateTime time, int numen)
        {
            return MailDAL.addMail(sub, context, sender, receiver, time, numen);
        }
        public static List<MailDTO> getMail(string email)
        {
            return MailDAL.getMail(email);
        }
        public static bool changeStatus(int id)
        {
            return MailDAL.changeStatus(id);
        }
        public static List<MailDTO> getAll(string email)
        {
            return MailDAL.getAll(email);
        }
        public static List<MailDTO> getDistinctMail(string email)
        {
            return MailDAL.getDistinctMail(email);
        }
        public static int getNumEn(int id)
        {
            return MailDAL.getNumEn(id);
        }
        public static bool deleteMail(int id)
        {
            return MailDAL.deleteMail(id);
        }
    }
}
