using System;
using System.Collections.Generic;
using System.Linq;

namespace core_record
{
    //https://www.youtube.com/watch?v=oSQDZ7GpKwg
    //Read only
    //Generate extra code in assembly that implements:
    //ToString
    //{ get; init; }
    //implement comperison
    //override GetHashCode
    //Copy
    //Clone
    //Deconstruct to Tupple.
    public class Record1
	{
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public record Record(string FirstName, string LastName);
    public class Program
    {
        public static void Main(string[] args)
        {
            var data = new Record("Moshe", "Cohen");
            var data2 = data with { LastName = "Levy" };
            Console.WriteLine(data.ToString());
        }
    }
}