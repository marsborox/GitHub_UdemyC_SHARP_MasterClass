using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_some_other_stuff
{// will derive from Post and add property (ImageURL) and two constructors
    internal class ImagePost:Post
    {
        public string ImageUrl {  get; set; }
        public ImagePost() { } //this calls default constructor
        public ImagePost(string title, string sendByUsername, string imageUrl,bool isPublic) 
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;

            this.ImageUrl = imageUrl;
        }
        public override string ToString()
        {
                return String.Format("{0} - {1} - {2} by - {3}", this.ID, this.Title,this.ImageUrl ,this.SendByUsername);
            
        }
    }
}
