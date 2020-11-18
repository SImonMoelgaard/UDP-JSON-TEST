using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using UDP_Test;

namespace UDP_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static List<Movie> movies;
        private GetData getData = new GetData();

        public MainWindow()
        {
            movies = new List<Movie>();
            InitializeComponent();
            Thread.CurrentThread.Name = "main";
            Forever();


        }

        private Thread worker;
        public void Forever()
        {
            worker = new Thread(Go);
            worker.Name = "worker";
            // worker.Start();



        }

        public void GetdataOnTime()
        {
            worker.Start();
            //Go();

        }

        void Go()
        {
            while (true)
            {

                System.Diagnostics.Debug.WriteLine("Hello from " + Thread.CurrentThread.Name);
                //Movie movie = new Movie { Name = Thread.CurrentThread.Name, Year = movies.Count };
                Movie movie = getData.LoadData();
                movies.Add(movie);
                this.Dispatcher.BeginInvoke(DispatcherPriority.Normal,
                    (ThreadStart)delegate ()
                    {
                        TestListBox.Items.Add(movie);


                    });
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!worker.IsAlive)
            {
                Forever();
                GetdataOnTime();
            }
            else
            {
                GetdataOnTime();
            }
        }


    }
}
