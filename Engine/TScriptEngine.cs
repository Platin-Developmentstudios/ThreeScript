using System;
using System.IO;
using System.Text;
using ThreeScript.Engine.CmdManager;

namespace ThreeScript.Engine {
    internal class TScriptEngine {
        public static void Execute(string filename) {
            try {
                if((filename.EndsWith(".ths")) || (filename.EndsWith(".threescript"))) {
                    string[] lines = File.ReadAllLines(filename);
                    foreach(string line in lines) {
                        
                        if(!(line.StartsWith("|"))) {
                            
                            if(line.StartsWith("echo")) {
                                string echoString = line.Remove(0, 5);
                                CmdHandler.EchoCMD(echoString);
                            } else if(line.StartsWith("run")) {
                                string runPath = line.Remove(0, 4);
                                if(runPath == "" || runPath == " ") {
                                    Console.WriteLine("[ TScriptEngine | ERROR ] No Path given");
                                } else {
                                    CmdHandler.RunCMD(runPath);
                                }
                            } else {
                                //ConsoleForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("> INT <");
                                //ConsoleForegroundColor = ConsoleColor.White;
                            }
                        }
                    }
                } else {
                    //Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("[ ERROR ] Invalid ThreeScript File");
                    //ConsoleForegroundColor = ConsoleColor.White;
                }
            } catch(Exception e) {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
