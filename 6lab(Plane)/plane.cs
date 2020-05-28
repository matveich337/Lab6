using System;
using System.Collections.Generic; //Обовязково добавити!!!

namespace Ex5
{
    public class plane
    {
        string purpose;
        string mark;
        int speed;
        int height;
        public plane(string pp, string mk, int sd, int hg)
        {
            purpose = pp;
            mark = mk;
            speed = sd;
            height = hg;
        }
        public override string ToString()
        {
            return string.Format("Plane Purpose={0}, Mark={1}, Max.Speed={2}, Max.height={2}", purpose, mark, speed, height);
        }
    }
}