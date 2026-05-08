using Microsoft.VisualBasic;
using SimpleList;
using System.ComponentModel.Design;

var list = new SinglyLinkedList<string>();
var option = string.Empty;
var value = string.Empty;
do
{
    option = Menu();
    switch(option)
    {
        case "1":
            Console.WriteLine("Enter a value: ");
            value = Console.ReadLine() ?? String.Empty;
            list.InsertAtBegginning(value);
            break;
        case "2":
            Console.WriteLine("Enter a value: ");
            value = Console.ReadLine() ?? String.Empty;
            list.InsertAtEndinning(value);
            break;
        case "3":
            Console.WriteLine("Enter a value: ");
            value = Console.ReadLine() ?? String.Empty;
            var exist = list.Contains(value);
            if (exist)
            {
                Console.WriteLine($"Value {value} found in the list.");
            }
            else
            {
                Console.WriteLine($"Value {value} not found in the list.");
            }
            break;
        case "4":
            Console.WriteLine("Enter a value: ");
            value = Console.ReadLine() ?? String.Empty;
            list.Remove(value);
            break;
        case "5":
            list.Reverse();
            break;
        case "6":
            Console.WriteLine(list);
            break;
        case"0":
            Console.WriteLine("Exiting.....");
            break; 
        default:
            Console.WriteLine("Invalid option. Please try again. ");
            break;
    }
} while (option != "0");

string Menu()
{
    Console.WriteLine("Enter your option: ");
    Console.WriteLine("1. Insert at the beginning");
    Console.WriteLine("2. Insert at the Endinning");
    Console.WriteLine("3. Search for a value");
    Console.WriteLine("4. Remove a value");
    Console.WriteLine("5. reverse list");
    Console.WriteLine("6. Show list");
    Console.WriteLine("0. Exit");
    return Console.ReadLine()??String.Empty;
}