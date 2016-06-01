using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Calculations;

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    
    public partial class MainWindow : Window
    {
        private Calculations.Expression myExpression;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void num_click(object sender, RoutedEventArgs e)
        {
            Button btnClicked = (Button)sender;
            if (Output.Content.ToString() == "0")
            {
                Output.Content = btnClicked.Content;
            }
            else
            {
                Output.Content += btnClicked.Content.ToString();
            }

        }

        private void dec_click(object sender, RoutedEventArgs e)
        {
            if (Output.Content.ToString().Contains("."))
            {
                //do nothing
            } else{
                Output.Content += ".";
            }
        }

        private void Del_click(object sender, RoutedEventArgs e)
        {
            if(Output.Content.ToString().Length > 1)
            {

            Output.Content = Output.Content.ToString().Remove(Output.Content.ToString().Length - 1);
            }
            else
            {
                Output.Content = "0";
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Opperator_click(object sender, RoutedEventArgs e)
        {
            Button btnClicked = (Button)sender;
            switch (btnClicked.Content.ToString())
            {
                case "+":
                    myExpression = new Calculations.Expression(Double.Parse(Output.Content.ToString()), "add");
                    Output.Content = "0";
                    break;
                case "-":
                    myExpression = new Calculations.Expression(Double.Parse(Output.Content.ToString()), "subtract");
                    Output.Content = "0";
                    break;
                case "/":
                    myExpression = new Calculations.Expression(Double.Parse(Output.Content.ToString()), "divide");
                    Output.Content = "0";
                    break;
                case "*":
                    myExpression = new Calculations.Expression(Double.Parse(Output.Content.ToString()), "multiply");
                    Output.Content = "0";
                    break;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

       
   

        private void equal_click(object sender, RoutedEventArgs e)
        {
            myExpression.Val2 = double.Parse(Output.Content.ToString());
            Output.Content = myExpression.calc();
        }

      

     
       

        






    }
}
