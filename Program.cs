using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mobile samsung = new Mobile(8);
            Mobile iphone = new Mobile(128);

            samsung.GetVideo();
            samsung.GetVideo(5);
            samsung.GetVideo(3, 5);
            samsung.GetPicture();
            

            Console.Read();
        }
    }
}
