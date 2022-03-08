using System;

namespace Genric
{
    public class Genius
    {
        
       
        public void get<T>(T[] arr)
        {
         foreach(T x in arr)
            {
                Console.WriteLine(x);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Genius obj = new Genius();
            int[] value = new int[3];
            value[0] = 34;
            value[1] = 43;
            value[2] = 78;
            obj.get(value);
            string[] name = new string[3];
            name[0] = "Mona";
            name[1] = "Harshit";
            name[2] = "Yash";
            obj.get(name);
           
        }
    }
}
