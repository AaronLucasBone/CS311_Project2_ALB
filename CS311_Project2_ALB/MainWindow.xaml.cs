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

namespace CS311_Project2_ALB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public static int die1 = 0;
        public static int die2 = 0;
        public static int bankBal = 100;
        public static int bet = 15;
        public static Boolean flag = true;
        public static int point = 0;
        public static String die1S = "";
        public static String die2S = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private static void pointWinReset()
        {
            bankBal = bankBal + bet;
            point = 0;
            flag = false;
        }//end pR

        private static void calculate_score()
        {
            //calculated the bet on the roll button cause it made sense to me

            Random rng = new Random();
            die1 = rng.Next(1, 6);
            die2 = rng.Next(1, 6);
            int dieSum = die1 + die2;

            String die1S = die1.ToString();
            String die2S = die2.ToString();

            MainWindow.die1Lbl.Content = die1;


            switch (dieSum)
                {
                    case 2:
                        if(point == 0)
                        {
                            bankBal = bankBal - bet;
                            flag = false;
                        }//end if
                        
                        break;
                    case 3:
                        if (point == 0)
                        {
                            bankBal = bankBal - bet;
                            flag = false;
                        }//end if
                        break;
                    case 4:
                        if (point == 0)
                        {
                            point = 4;
                        }//end if
                        if (point == 4)
                        {
                            pointWinReset();
                        }//win if

                        break;
                    case 5:
                        if (point == 0)
                        {
                            point = 5;
                        }//end if
                        if (point == 5)
                        {
                            pointWinReset();
                        }//win if
                        break;
                    case 6:
                        if (point == 0)
                        {
                            point = 6;
                        }//end if
                        if (point == 6)
                        {
                            pointWinReset();
                        }//win if
                        break;
                    case 7:
                        if(point == 0)
                        {
                            bankBal = bankBal + bet;
                            flag = false;
                        }//end if
                        else if (point != 0)
                        {
                            bankBal = bankBal - bet;
                            point = 0;
                            flag = false;
                        }// end else if
                            
                        break;
                    case 8:
                        if (point == 0)
                        {
                            point = 8;
                        }//end if
                        if (point == 8)
                        {
                            pointWinReset();
                        }//win if
                        break;
                    case 9:
                        if (point == 0)
                        {
                            point = 4;
                        }//end if
                        if (point == 9)
                        {
                            pointWinReset();
                        }//win if
                        break;
                    case 10:
                        if (point == 0)
                        {
                            point = 10;
                        }//end if
                        if (point == 10)
                        {
                            pointWinReset();
                        }//win if
                        break;
                    case 11:
                        if (point == 0)
                        {
                            bankBal = bankBal + bet;
                            flag = false;
                        }//end if
                        break;
                    case 12:
                        if (point == 0)
                        {
                            bankBal = bankBal - bet;
                            flag = false;
                        }//end if
                        break;

                }//end switch 


            /*
             * You roll two dice. The sum of the dots on the two dice facing upward is calculated.  
             * If the sum is 7 or 11 on the first throw, you win.  
             * If the sum is 2,3, or 12 on the first throw (called "craps"), you lose (the house wins).  
             * If the sum is 4, 5, 6, 8, 9, 10 on the first throw that sum becomes your "point".  
             * To win, you must continue rolling the dice until you "make your point" (roll the same value).  
             * You lose by rolling a 7 before making your point.
             */

        }//end calculate score

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void RollButton_Click(object sender, RoutedEventArgs e)
        {
            if (bet > bankBal)
            {
                string brokeass = "Gonna need to find a loan shark for that bet bub.";
                MessageBox.Show("HEY", brokeass);
                //might not work
            }//end if
            else
            {
                MessageBox.Show("I made it dad");
                calculate_score();
            }//end else
           
        }//end roll
    }
}
