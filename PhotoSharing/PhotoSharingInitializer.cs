using System.Data.Entity;
using PhotoSharing.Models;

namespace PhotoSharing
{
    public class PhotoSharingInitializer :  DropCreateDatabaseAlways<PhotoSharingContext>
        {
        protected override void Seed(PhotoSharingContext context)
        {
            base.Seed(context);

            Photo a1 =  new Photo
            {
                Title = "1",
                CreateDate = System.DateTime.Now
            };
            context.Photos.Add(a1);
            context.SaveChanges();
        }

    }
}