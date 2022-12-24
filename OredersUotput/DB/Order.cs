using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OredersUotput.DB
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        public string Structure { get; set; }
        public int Price { get; set; }
        public int CookingTime { get; set; }
        public string Client { get; set; }
    }
}
