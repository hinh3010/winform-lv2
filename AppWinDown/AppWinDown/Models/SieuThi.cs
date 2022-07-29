using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWinDown.Models
{
    internal class SieuThi
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string NameProduct { get; set; }
        public string PriceProduct { get; set; }
        public string QuantityProduct { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
