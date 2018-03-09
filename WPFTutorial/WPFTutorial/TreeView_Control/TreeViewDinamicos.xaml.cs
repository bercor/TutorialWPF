using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFTutorial.TreeView_Control
{
    /// <summary>
    /// Lógica de interacción para TreeViewDinamicos.xaml
    /// </summary>
    public partial class TreeViewDinamicos : Window
    {
        public TreeViewDinamicos()
        {
            InitializeComponent();
            DataContext = Process.GetProcesses();
            //DataContext = Process.GetProcesses().Where(p => CanAccess(p)).
              //              Select(p => new ProcessViewModel(p));
        }
        private bool CanAccess(Process p)
        {

            try
            {

                var handle = p.Handle;

                var main = p.MainModule;

                return true;

            }

            catch
            {

                return false;

            }

        }
    }
class ProcessViewModel 
{

       public Process Process { get; private set; }

       public ProcessViewModel(Process process) {

              Process = process;

       }

 

       public IEnumerable<object> Children {

              get {

                     yield return new ThreadsViewModel {

                           Name = "Threads",

                           Threads = Process.Threads.Cast<ProcessThread>()

                     };

                     yield return new ModulesViewModel {

                           Name = "Modules",

                           Modules = Process.Modules.Cast<ProcessModule>()

                     };

              }

       }

}
class ThreadsViewModel
{

    public string Name { get; set; }

    public IEnumerable<ProcessThread> Threads { get; set; }

}

class ModulesViewModel
{

    public string Name { get; set; }

    public IEnumerable<ProcessModule> Modules { get; set; }

}
}
