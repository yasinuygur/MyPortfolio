﻿namespace MyPortfolio.DAL.Entities
{
    public class Message
    {
        public int MessageID { get; set; }
        public string NameSurname { get; set; }
        public string Subject { get; set; }
        public string Email { get; set; }
        public string MessageDetail { get; set; }
        public string SendDate { get; set; }
        public bool IsRead { get; set; }
    }
}
