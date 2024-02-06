using System;
using System.Collections.Generic;
using System.Linq;

namespace InterviewQuestions
{
    internal static class Question2
    {
        internal static void CreateAndReadData()
        {
            var taco1 = BuildTaco();
            var dct = new Order();
            dct.Name = "test".ToUpper();
            dct.Id = 1;
            dct.Description = "Description".ToUpper();
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
        internal static Taco BuildTaco()
        {
            var taco = new Taco();
            taco.Cheese = "1";
            taco.Meat = 2;
            taco.shell = false;
            return taco;
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
        public string Cheese { get; set; }
        public int? Meat { get; set; }
        public bool? shell { get; set; }
        public List<string> EverythingElse { get; set; }
    }
}
