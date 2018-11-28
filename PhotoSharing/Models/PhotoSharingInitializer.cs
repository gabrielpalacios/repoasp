using System.Data.Entity;
using PhotoSharing.Models;
using System.Collections.Generic;
using System.IO;
using System.Web;

namespace PhotoSharing.Models
{
    public class PhotoSharingInitializer :  DropCreateDatabaseAlways<PhotoSharingContext>
        {
        protected override void Seed(PhotoSharingContext context)
        {
            base.Seed(context);

            //Create some photos
            List<Photo> photos = new List<Photo>
            {
                new Photo {
                    Title = "Me standing on top of a mountain",
                    Description = "I was very impressed with myself",
                    Username = "Fred",
                    File = GetFileBytes("\\Images\\flower.jpg"),
                    MimeType = "image/jpeg",
                    CreateDate =System.DateTime.Now
                },
                new Photo {
                    Title = "My New Adventure Works Bike",
                    Description = "It's the bees knees!",
                    Username = "Fred",
                    File = GetFileBytes("\\Images\\orchard.jpg"),
                    MimeType = "image/jpeg",
                    CreateDate = System.DateTime.Now
                },
                new Photo {
                    Title = "View from the start line",
                    Description = "I took this photo just before we started over my handle bars.",
                    Username = "Sue",
                    File = GetFileBytes("\\Images\\path.jpg"),
                    MimeType = "image/jpeg",
                    CreateDate = System.DateTime.Now
                }
            };
            photos.ForEach(photo => context.Photos.Add(photo));
            context.SaveChanges();

            //Create some comments
            var comments = new List<Comment>
            {
                new Comment {
                    Username = "Bert",
                    Subject = "A Big Mountain",
                    Body = "That looks like a very high mountain you have climbed",
                    Photo = photos[0]
                },
                new Comment {
                    Username = "Sue",
                    Subject = "So?",
                    Body = "I climbed a mountain that high before breakfast everyday",
                    Photo = photos[0]
                },
                new Comment {
                    Username = "Fred",
                    Subject = "Jealous",
                    Body = "Wow, that new bike looks great!",
                    Photo = photos[1]
                }
            };
            comments.ForEach(comment => context.Comments.Add(comment));
            context.SaveChanges();
        }

        /// <summary>
        /// Gets the file bytes.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns></returns>
        private byte[] GetFileBytes(string path)
        {
            FileStream fileStream = new FileStream(HttpRuntime.AppDomainAppPath + path, FileMode.Open);
            byte[] bytes;
            using (BinaryReader reader = new BinaryReader(fileStream))
            {
                bytes = reader.ReadBytes((int)fileStream.Length);
            }
            return bytes;
        }

    }
}