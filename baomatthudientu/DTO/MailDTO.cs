﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baomatthudientu.DTO
{
    internal class MailDTO
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Context { get; set; }
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public DateTime Time { get; set; }
        public string State { get; set; }
        public MailDTO(int Id, string Subject, string Context, string Sender, string Receiver, DateTime Time, string State)
        {
            this.Id = Id;
            this.Subject = Subject;
            this.Context = Context;
            this.Sender = Sender;
            this.Receiver = Receiver;
            this.Time = Time;
            this.State = State;
        }
    }
}