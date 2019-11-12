using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAuthTest.Models.Data
{
    public class Post
    {
        // ADDED attributes to do the auto validation

        public int PostId { get; set; }
        [Required]
        [MinLength(5, ErrorMessage = "Too short dude")]
        [MaxLength(100, ErrorMessage = "Too long dude")]
        public string Topic { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(1000)]
        public string Text { get; set; }
        public int? ParentPostId { get; set; }
        [ForeignKey("ParentPostId")]
        public Post ParentPost { get; set; }
        public List<Post> Replies { get; set; } = new List<Post>();
    }
}
