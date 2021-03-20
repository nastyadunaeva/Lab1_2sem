using System;

namespace Lab3
{
    class Program
    {
        public static void data_change(object sourse, DataChangedEventArgs args)
        {
            Console.WriteLine();
            Console.WriteLine(args.ToString());
        }
        static void Main(string[] args)
        {
            
        }
    }
}
