using Microsoft.Win32;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;



using MdXaml;
using System.Windows.Documents;



namespace NoteTakingApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

            Console.Write(e.Changes);


            //!+ todo figure out how to spawn thread to monitor changes in the text box
            // Thread t1 = new Thread();

            

            Console.Write("value to write to output stream");

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("New");


        }

        private void MenuItem_Click_New(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("New");

            OpenFileDialog diag = new OpenFileDialog();


            var fileResult = diag.ShowDialog();

            if (fileResult  == true)
            {

               
                Console.Write("file name is:{} ", diag.FileName);
                LoadConfiguration(diag.FileName);
            }


        }

        private void LoadConfiguration(string fileName)
        {
            throw new NotImplementedException("mesage test");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            
            Markdown engine = new Markdown();

           
            
            string markdownTxt = """ 
        
            ```py
            nums = 10

            print("test in pythonm")

            for n in range(nums):
                print(n)
            ```

            """;
            string text = NotesTextBoxt.Text;

            
            string mdtop = $"""
            ```py
            {text}
            ```
            """;
            //System.IO.File.ReadAllText("");

            

            

             MDViewer.Markdown =(mdtop);
        }

        private void NotesTextBoxt_TextChanged(object sender, TextChangedEventArgs e)
        {
            string text = NotesTextBoxt.Text;


            string mdtop = $"""
            ```py
            {text}
            ```
            """;
            //System.IO.File.ReadAllText("");





            MDViewer.Markdown = (mdtop);

        }
    }
}


