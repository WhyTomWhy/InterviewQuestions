using System;
using System.Collections.Generic;
using System.Linq;

namespace InterviewQuestions
{
    internal static class Question2
    {
        internal static void CreateAndReadData()
        {
            var taco1 = new Taco {Cheese = "1", Meat = 2, shell = false, EverythingElse = new List<string>()};
            var dct = new Order();
            dct.Name = "test";
            dct.Id = 1;
            dct.Description = "Description";
            dct.Taco = taco1;

            Console.WriteLine("==> Order");
            Console.WriteLine(dct.Name.ToUpper());
            Console.WriteLine(dct.Id);
            Console.WriteLine(dct.Description.ToUpper());
            Console.WriteLine("====> Taco");
            Console.WriteLine("== " + dct.Taco.Cheese.ToUpper());
            Console.WriteLine("== " + dct.Taco.Meat);
            Console.WriteLine("== " + dct.Taco.shell);
            Console.WriteLine("== " + dct.Taco.EverythingElse.First().ToUpper());

        }
    }
    internal class Order
    {
        public string? Name { get; set; }
        public int? Id { get; set; }
        public string? Description { get; set; }
        public Taco? Taco { get; set; }
    }
    internal class Taco
    {
        public string? Cheese { get; set; }
        public int? Meat { get; set; }
        public bool? shell { get; set; }
        public List<string>? EverythingElse { get; set; }
    }
}
