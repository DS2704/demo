using System;

namespace call_by_value
{
    class Program

    {
        public void show(int val)
        {
            val *= val;
            Console.WriteLine("val inside calling function" + val);

        }
        static void Main(string[] args)

        {
           int  Val = 50;
            Program p = new Program();
            Console.WriteLine("Value before calling the function " + val);
            Program.show(val);
            Console.WriteLine("value after calling function" + val);

        }
            
        
    }
}
