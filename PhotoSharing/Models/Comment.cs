using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhotoSharing.Models
{
    public class Comment
    {
        public int Id { set; get; }
        //public string  Title { set; get; }
        //public byte [] File { set; get; }
        public string Body { set; get; }
        public string Subject { set; get; }
        public string Username { set; get; }
        public virtual Photo Photo { set; get; }
    }
}