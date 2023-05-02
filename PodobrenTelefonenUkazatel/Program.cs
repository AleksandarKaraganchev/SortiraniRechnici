using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodobrenTelefonenUkazatel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            var sortedPhonebook = new SortedDictionary<string, string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                string[] separator = input.Split();
                if (separator[0] == "A")
                {
                    string name = separator[1];
                    string phoneNum = separator[2];

                    phonebook[name] = phoneNum;
                    sortedPhonebook[name] = phoneNum;
                }
                if (separator[0] == "S")
                {
                    string name = separator[1];
                    if (phonebook.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {phonebook[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }
                if (separator[0] == "ListAll")
                {
                    Console.WriteLine($"В указателя има {sortedPhonebook.Count} записани.");
                    Console.WriteLine("Списък по азбучен ред:");
                    foreach (var contact in sortedPhonebook)
                    {
                        Console.WriteLine($"{contact.Key} -> {contact.Value}");
                    }
                }
            }
        }
    }
}
