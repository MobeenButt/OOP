using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.BL
{
    internal class CreatePost
    {
        private List<string> comments = new List<string>();
        private int like;

        public CreatePost()
        {
        }

        public CreatePost(List<string> comments, int like)
        {
            this.comments = comments;
            this.like = like;
        }

        public int GetLike()
        {
            return like;
        }

        public string GetComment(string comment)
        {
            string com = "";
            foreach (string c in comments)
            {
                com = com + c;
            }
            return com;
        }

        public void SetComment(string comment)
        {
            if (comments != null)
                comments.Add(comment);
        }

        public void SetLike(int like)
        {
            this.like = like;
        }
    }
}