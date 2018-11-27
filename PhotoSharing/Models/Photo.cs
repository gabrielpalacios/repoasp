using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhotoSharing.Models
{
    public class Photo
    {
        public int Id { set; get; }
        public string  Title { set; get; }
        public byte [] File { set; get; }
        public string MimeType { set; get; }
        public string Description { set; get; }
        public string Username { set; get; }
        public DateTime CreateDate { set; get; }
        public virtual List<Comment> Comments { set; get; }
    }
}