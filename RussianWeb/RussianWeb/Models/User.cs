using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RussianWeb.Models
{
    public class User
    {
         public  Guid id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
