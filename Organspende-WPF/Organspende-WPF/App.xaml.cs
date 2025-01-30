using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Organspende_WPF
{
    /// <summary>
    /// Interaktionslogik für "App.xaml"
    /// </summary>
    public partial class App : Application
    {
        public static int FrgR = 0; //Wie viele Fragen richtig 
        public static int FrgF = 0; //wie viele falsch
        public static bool Antwort = false; //wurde die Frage richtig beantwortet

        //Hinweis, nutze Radiobuttons, wenn nur eine Antwort richtig sein kann.
        //Hinweis: Damit alle Fenster sich auf der gleichen Position öffnen, nutze:
        //WindowStartupLocation="CenterScreen" 
    }
}
