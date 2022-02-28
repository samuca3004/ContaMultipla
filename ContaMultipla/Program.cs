using System;
using ContaMultipla.Entities;

namespace ContaMultipla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010, "Samuel Ribeiro", 100.0, 500.0);

            Console.WriteLine(account.Balance);

            
        }
    }
}
