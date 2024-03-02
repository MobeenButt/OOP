using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.BL
{
    internal class Follower
    {
        private string name;
        private List<Follower> followerList = new List<Follower>();
        private List<Follower> following = new List<Follower>();
        private List<CreatePost> posts = new List<CreatePost>();

        public Follower(string name)
        {
            this.name = name;
        }

        public void ViewPost()
        {
            foreach (CreatePost p in posts)
            {
                Console.WriteLine($"Likes: {p.GetLike()}");
            }
        }

        public void AddPost(CreatePost p)
        {
            if (p != null)
                posts.Add(p);
        }

        public void ViewFollower()
        {
            foreach (Follower f in followerList)
            {
                Console.WriteLine(f.name);
            }
        }

        public void ViewFollowing()
        {
            foreach (Follower follows in following)
            {
                Console.WriteLine(follows.name);
            }
        }
    }
}
