using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public abstract class Camera  //abstraction
    {
        public abstract void GetPicture();
        public abstract void GetVideo();
    }

    internal class Mobile : Camera  //inheritance
    {
        public Mobile(int memory)
        {
            Memory = memory;
        }
        int Memory;
        private int data = 0;
        private int Data   //encapsulation
        {
            get { return data; }
            set { data = value; }
        }
        public override void GetPicture()
        {

            if (data < Memory)
            {
                Console.WriteLine("I have get a Pic");
                Data++;
            }
            else
            {
                Console.WriteLine("Memory is full");
            }
        }

        public override void GetVideo()
        {
            Console.WriteLine("I have get a Video");
            Data += 2;
        }
        public void GetVideo(int maxminute)   //polymorphizm
        {
            if (maxminute > 10)
            {
                Console.WriteLine("STOPED");
            }
            else
            {
                Data += 2;
                Console.WriteLine("Have Registered");
            }
        }
        public void GetVideo(int maxminute, int gb)   //polymorphizm overload
        {
            if (maxminute > 10 || (gb + data) > Memory)
            {
                Console.WriteLine("stoped");
            }
            else
            {
                Data += gb;
                Console.WriteLine("Have Registered");
            }
        }
    }
}
