using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using baomatthudientu.DTO;

namespace baomatthudientu.DAL
{
    internal class MailDAL
    {
        public static bool addMail(string sub, string context, string sender, string receiver, DateTime time)
        {
            BAOMATTHUDIENTUEntities db = new BAOMATTHUDIENTUEntities();

            MailDTO mail = new MailDTO(db.Mails.Count()+1, sub, context, sender, receiver, time, "chưa đọc");
            Mail m = new Mail()
            {
                Id = mail.Id,
                Subject = mail.Subject,
                Context = mail.Context,
                Sender = mail.Sender,
                Receiver = mail.Receiver,
                Time = mail.Time,
                Status = mail.Status
            };
            db.Mails.Add(m);
            db.SaveChanges();
            return true;
        }
        public static List<MailDTO> getMail(string email)
        {
            BAOMATTHUDIENTUEntities db = new BAOMATTHUDIENTUEntities();
            List<MailDTO> result = new List<MailDTO>();
            var v = from c in db.Mails where c.Receiver == email select c;
            foreach(Mail item in v)
            {
                MailDTO dto = new MailDTO(item.Id, item.Subject, item.Context, item.Sender, item.Receiver, item.Time, item.Status);
                result.Add(dto);
            }
            return result;
        }
        public static bool changeStatus(int id)
        {
            BAOMATTHUDIENTUEntities db = new BAOMATTHUDIENTUEntities();
            Mail mail = db.Mails.Find(id);
            mail.Status = "Đã đọc";
            db.SaveChanges();
            return true;
        }
    }
}
