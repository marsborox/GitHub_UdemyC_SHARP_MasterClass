using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _4_some_other_stuff
{
    internal class Post
    {
        private static int currentPostId;
        //properties
        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string SendByUsername { get; set; }
        protected bool IsPublic { get; set; }

        public Post()
        {
            ID = 0;
            Title = "MyFirst Post";
            IsPublic = true;
            SendByUsername = "Maros";
        }
        //instance constructor
        public Post(string title, bool isPublic, string sendByUsername)
        {
            this.ID = 0;
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
        }
        protected int GetNextID()
        {
            return ++currentPostId;
        }
        public void Update(string title, bool isPublic)
        {
            this.Title= title;
            this.IsPublic = isPublic;
        }
        //c# function System.Object class from this one we can inherit
        //here we override one of its methods

        public override string ToString()
        {//we format string which will have certain information
            //will return in this format
            return String.Format("{0} - {1} - by {2}", this.ID,this.Title, this.SendByUsername);
        }
    }
}
