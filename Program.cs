using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Q: Can you store different types in an array
             */
             //Method 1: Object Array
            object[] array = new object[3];
            array[0] = 1;
            array[1] = "string";
            array[2] = new Customer { ID = 1, Name = "Murat Şeşen" };
            foreach (var obj in array)
            {
                Console.WriteLine(obj);
            }
            //Method 2: Collections
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("string");
            list.Add(new Customer { ID = 1, Name = "Murat Çeçen" });
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        //"override" metodu base class'tan türetilen bir metodu yeniden tanımlamamıza yarar
        public override string ToString()
        {
            return this.Name;
        }
    }
}
