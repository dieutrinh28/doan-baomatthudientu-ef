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
        public static bool addMail(string sub, string context, string sender, string receiver, DateTime time, int numen)
        {
            BAOMATTHUDIENTUEntities db = new BAOMATTHUDIENTUEntities();

            MailDTO mail = new MailDTO(db.Mails.Count() + 1, sub, context, sender, receiver, time, "chưa đọc", 1, numen);
            Mail m = new Mail()
            {
                Id = mail.Id,
                Subject = mail.Subject,
                Context = mail.Context,
                Sender = mail.Sender,
                Receiver = mail.Receiver,
                Time = mail.Time,
                Status = mail.Status,
                Delete = mail.Delete,
                NumEn = mail.NumEn
            };
            db.Mails.Add(m);
            db.SaveChanges();
            return true;
        }
        public static List<MailDTO> getAll(string email)
        {
            BAOMATTHUDIENTUEntities data = new BAOMATTHUDIENTUEntities();
            var truyvan = from mail in data.Mails
                          where mail.Sender == email
                          select mail ;
            List<MailDTO> listMail = new List<MailDTO>();
            

            foreach (Mail mail in truyvan)
            {
                MailDTO dto = new MailDTO();
                dto.Id = mail.Id;
                dto.Sender = mail.Sender;
                dto.Receiver = mail.Receiver;
                dto.Subject = mail.Subject;
                dto.Time = mail.Time;
                dto.Context = mail.Context;
                dto.Delete = mail.Delete;
                dto.Status = mail.Status;
                dto.NumEn = (int)mail.NumEn;

                listMail.Add(dto);
            }
            return listMail;
        }
        public static List<MailDTO> getMail(string email)
        {
            BAOMATTHUDIENTUEntities db = new BAOMATTHUDIENTUEntities();
            List<MailDTO> result = new List<MailDTO>();
            var v = from c in db.Mails where c.Receiver == email select c;
            foreach (Mail item in v)
            {
                MailDTO dto = new MailDTO(item.Id, item.Subject, item.Context, item.Sender, item.Receiver, item.Time, item.Status, item.Delete, (int)item.NumEn);
                result.Add(dto);
            }
            return result;
        }
        public static List<MailDTO> getDistinctMail(string email)
        {
            BAOMATTHUDIENTUEntities db = new BAOMATTHUDIENTUEntities();
            List<MailDTO> result = new List<MailDTO>();
            var v = from c in db.Mails where c.Sender == email select (c.Receiver).Distinct();
            foreach (Mail item in v)
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
        public static int getNumEn(int id)
        {
            BAOMATTHUDIENTUEntities db = new BAOMATTHUDIENTUEntities();
            var v = (from c in db.Mails where c.Id == id select c.NumEn).SingleOrDefault();
            return (int)v;
        }
    }
}
