using ConsoleApp1.Models;
using System;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            using var context = new BloggingContext();
            var blogs = context.Blogs
                .Where(b => b.Url.Contains("dotnet"))
                .ToList();



        }
    }
}
