using SocialMedia.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia
{
    internal class Program
    {
        static void Main(string[] args)
        {   Follower Follower1 = new Follower("Mobeen");
       
            CreatePost Post1 = new CreatePost();
            Post1.SetLike(10000);
            Post1.SetComment("Ok");

            Follower1.AddPost(Post1);

            Console.WriteLine("Follower of Follower1");
            Follower1.ViewFollowing();

            Console.WriteLine("Posts of Follower1");
            Follower1.ViewPost();

            Console.WriteLine("Followers of Follower1");
            Follower1.ViewFollower();

            Console.ReadLine();
        }
    }
}
  