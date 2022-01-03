using System;
using System.IO;
using System.Text;
using ThreeScript.Engine;

namespace ThreeScript.Engine.CmdManager {
    
    internal class CmdHandler {
        
        public static void EchoCMD(string echoInput) {
            Console.WriteLine(echoInput);
        }
        
        public static void RunCMD(string pathString) {
            TScriptEngine.Execute(pathString);
        }
    }
}
