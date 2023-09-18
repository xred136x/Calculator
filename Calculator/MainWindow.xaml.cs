using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
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


namespace Calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void btnNumeric_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string textButton = ((Button)e.OriginalSource).Content.ToString();
                if(textButton == "C")
                {
                    texbBoxInput.Clear();
                }
                else if(textButton == "X")
                {
                    texbBoxInput.Text = texbBoxInput.Text.Remove(texbBoxInput.Text.Length - 1);
                }
                else if (textButton == "=")
                {
                    texbBoxInput.Text = new DataTable().Compute(texbBoxInput.Text, null).ToString();
                }
                else
                {
                    texbBoxInput.Text += textButton;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
