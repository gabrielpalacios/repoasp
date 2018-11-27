using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PhotoSharing.Models
{
    public class PhotoSharingContext : DbContext

    {
        public DbSet<Photo> Photos { set; get; }
        public DbSet<Comment> Comments { set; get; }
        public PhotoSharingContext(): base(
            "name=PhotoSharingDb")
        {
                
        }

    }
}