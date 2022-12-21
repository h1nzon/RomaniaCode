using System.IO;
using System.Windows;

namespace RomaniaCode
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            string[] readText = null;
            InitializeComponent();
            string path = "Roman.csv";
            if (File.Exists(path))
            {
                readText = File.ReadAllLines(path);
            }

            foreach (string item in readText)
            {
                string[] line = item.Split(';');
                string coutryName = line[2].Trim();
            }
        }

        private void GenerationButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
