using System;
using System.IO;
using System.Text;
using ThreeScript.Engine;
using ThreeScript.Engine.CmdManager;

namespace ThreeScript {
    public static class Program {
        public static void Main(string[] args) {
            
            // Create the Workstation
            if(!Directory.Exists("/ThreeScript")) {
                Directory.CreateDirectory("/ThreeScript");
            }
            
            Console.Clear();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("| ThreeScript Shell for Linux | v.1.0.0.0 |");
            Console.WriteLine("|                                         |");
            Console.WriteLine("|     Use help to get all Commands        |");
            Console.WriteLine("-------------------------------------------");
            while(true) {
                
                Console.Write("ThreeScript > ");
                var input = Console.ReadLine();
                if(input.StartsWith("help")) {
                    
                    Console.WriteLine("All Commands:");
                    Console.WriteLine("help       | Print this list");
                    Console.WriteLine("run <path> | Execute an ThreeScript");
                    Console.WriteLine("exit       | Exit the ThreeScript Shell");
                    
                } else if(input.StartsWith("run")) {
                    
                    var runPath = input.Remove(0, 4);
                    if(runPath == "" || runPath == " ") {
                        Console.WriteLine("[ ERROR ] Please enter an Path");
                    } else {
                        TScriptEngine.Execute(runPath);
                    }
                    
                } else if(input.StartsWith("exit")) {
                    break;
                } else {
                    
                    Console.WriteLine("[ ERROR ] Command not found.");
                    
                }
            }
        }
    }
}
