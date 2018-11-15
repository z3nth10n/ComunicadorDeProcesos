using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace ComunicadorDeProcesos
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Gracias a: https://www.codeproject.com/Articles/790966/Hosting-And-Changing-Controls-In-Other-Application

            Win32Window control = Win32Window.FromProcessName("Login");

            control.Children[2].Text = "HELLO WORLD";

            Console.Read();
        }
    }
}