using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RussianWeb.Models
{
    public class Ax
    {
         public  Guid id { get; set; }
        public byte[] ax { get; set; }
    }
}
