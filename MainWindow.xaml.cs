using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;

namespace review2
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

        private void textbox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            char[] chs = { ' ', ',', '.' };
            string text =textbox1.Text;
            string textstring= textbox1.Text;
            string[] result;
            int[] count = new int[26];
            const int ascii_a = 97, ascii_z = 122;
            result = text.Split(chs, StringSplitOptions.RemoveEmptyEntries);
            foreach(string s in result)
            {
                if(s.Length ==1)
                {
                    char c = s[0];
                    int ascii=Convert.ToInt32(c);
                    if(ascii >= ascii_a && ascii<=ascii_z)
                    count[ascii - ascii_a]++;        
                }
                string output=" ";
                for(int i= 0; i < count.Length; i++)
                {
                    if (count[i] != 0)
                    {
                        char c = Convert.ToChar(i+ascii_a);
                        string alphabet = Convert.ToString(c);
                        output +=$"{alphabet}:{count[i]}\n";
                    }   
                }
                label1.Content = output;
            }
        }
    }
}
