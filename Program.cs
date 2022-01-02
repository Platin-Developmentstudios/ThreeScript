using System;
using System.IO;
using System.Text;

namespace ThreeScript {
    public static class Program {
        public static void Main(string[] args) {
            Console.Clear();
            Console.WriteLine("-------------------------------------------", ConsoleColor.Cyan);
            Console.WriteLine("| ThreeScript Shell for Linux | v.1.0.0.0 |", ConsoleColor.Cyan);
            Console.WriteLine("|                                         |", ConsoleColor.Cyan);
            Console.WriteLine("|     Use help to get all Commands        |", ConsoleColor.Cyan);
            Console.WriteLine("-------------------------------------------", ConsoleColor.Cyan);
            while(true) {
                Console.Write("ThreeScript > ");
                var input = Console.ReadLine();
                if(input.StartsWith("help")) {
                    Console.WriteLine("All Commands:");
                    Console.WriteLine("help       | This list")
                    Console.WriteLine("run <path> | Execute an ThreeScript")
                } else {
                    Console.WriteLine("[ ERROR ] Command not found.");
                }
            }
        }
    }
}
