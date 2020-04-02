using DatingApp.API.Models;

namespace DatingApp.API.Data
{
    public class Like
    {
        public int LikerId { get; set; }

        public int LikeeId { get; set; }

        public virtual User Liker { get; set; }

        public virtual User Likee { get; set; }
    }
}