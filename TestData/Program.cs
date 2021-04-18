using System;

namespace TestData
{
    class Program
    {
        static void Main(string[] args)
        {
            var generator = new Generate(int.Parse(args[0]), args[1].ToString());

            
            generator.Start();

            
        }
        
    }
}
