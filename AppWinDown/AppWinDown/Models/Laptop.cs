using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWinDown.Models
{
    internal class Laptop : IProduct
    {
        public string GiamGia { get; set; }

        public static List<Laptop> laptop = new List<Laptop>(){
            new Laptop(){
                Id = 1 , CreatedAt = DateTime.Now,
                Description = "free" , GiamGia = "10000" ,
                Image = "https://cdn.tgdd.vn/Products/Images/44/281483/asus-vivobook-15-x1502za-i5-ej120w-600x600.jpg" ,
                Name = "zenbook" , Price = "1000000" ,Quantity = 199
            },
            new Laptop(){
                Id = 1 , CreatedAt = DateTime.Now,
                Description = "free" , GiamGia = "20000" ,
                Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTeP8a7PFUx5h6A9XVM1Ry0xiqVcE0F0lTLlMrSJCpm2BgTq8dSoEGZTYINI8zEG-lctsY&usqp=CAU" ,
                Name = "zenbook 2" , Price = "2000000" ,Quantity = 100
            },
        };

    }
}
