using System;

namespace Distionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDistionary<string,string> myDistionary = new MyDistionary<string, string>();
            myDistionary.Add("İstanbul","34");
            myDistionary.Add("Samsun","55");
            myDistionary.Add("Adana","01");
            myDistionary.Add("Ankara","06");
        }
    }
}
