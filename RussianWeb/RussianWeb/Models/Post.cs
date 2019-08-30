using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RussianWeb.Models
{
    public class Post
    {
        [Key]
        public string Onvan { get; set; }
        public DateTime TarikheEnteshar { get; set; }
        public string KholaseyePost { get; set; }
        public string MatneKamelePost { get; set; }
    }
}
