using System;
namespace Prop
{
    class Prop_EX
    {
        int data;
        public int kata
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }
    }
    class MAIN
    {
        public static void Main(string[]args)
        {
            Prop_EX obj = new ();
            obj.kata=10;
            Console.WriteLine(obj.kata);
          //  Console.WriteLine(obj.data);
            Console.ReadKey();

        }
    }
}