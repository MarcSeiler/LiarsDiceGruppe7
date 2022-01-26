using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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

namespace LiarsDice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static Account myAccount = new Account();
        static List<bool> myShopList = new List<bool>();
        static List<string> myShopItem = new List<string>();

        public MainWindow()
        {
            InitializeComponent(); 
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            MyYears.Text = "";
            MyYears.Text = Convert.ToString(myAccount.GetYears());
        }

        //=========== Player Input ====================================================================================================

        private void Rules_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Regeln und Ablauf:\n" +
                            "I.Spielstart / Rundenstart:\n" +
                            "\t a. Spiel für mindestens zwei Spieler, von denen jeder\n\t     einen Würfelbecher mit je fünf Würfeln bekommt.\n" +
                            "\t b. Die Spieler würfeln verdeckt und schauen unter ihren\n\t     jeweiligen Würfelbecher.\n" +
                            "\t c. Der Spieler muss nun als erstes einen Tipp abgeben.\n" +
                            "\t d. Wenn er z.B. „vier Dreien“ sagt, meint er damit, dass\n\t     sich unter allen gefallenen Würfeln (seine eigenen +\n\t     die seiner Mitspieler, die er nicht kennt)\n\t     mindestens vier Dreien befinden.\n" +
                            "\t e. Die Aussage gilt beim späteren Aufdecken auch dann als\n\t     zutreffend, wenn mehr als vier Dreien gewürfelt wurden.\n" +
                            "\t f. Der nächste Spieler hat nun die Möglichkeit, den vorherigen\n\t     Tipp zu erhöhen oder ihn als Lüge abzustempeln.\n" +
                            "\t g. Um eine Lüge handelt es sich, wenn der Tipp des Spielers\n\t     höher ist als der eigentliche Wert auf dem Tisch\n" +
                            "II.Erhöhen kann man auf zwei Arten:\n" +
                            "\t a. Man tippt, dass mehr Würfel des gleichen Wertes auf\n\t     dem Tisch liegen (statt vier Dreien also etwa fünf Dreien).\n" +
                            "\t b. Man setzt auf höhere Werte als der Spieler zuvor,\n\t     dabei muss die Würfelanzahl aber trotzdem mindestens so\n\t     groß wie vom vorherigen Tipp sein\n" +
                            "III.Spielende/Rundenende:\n" +
                            "\t a. Wenn ein Spieler von einem anderen einer Lüge bezichtigt\n\t     wird, müssen alle Spieler ihre Würfel aufdecken.\n" +
                            "\t\t i. Hat der Beschuldigte tatsächlich gelogen,\n\t\t    hat er verloren.\n" +
                            "\t\t ii. Ist der Tipp des Beschuldigten allerdings\n\t\t    zutreffend, hat stattdessen der Ankläger verloren.\n");
        }

        private void CloseGame_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void PlayGame_Click(object sender, RoutedEventArgs e)
        {
            Playground _myPlayground = new Playground();
            _myPlayground.ShowDialog();
        }

        private void Shop_Click(object sender, RoutedEventArgs e)
        {
            Shop _myShop = new Shop();
            _myShop.ShowDialog();
        }

        private void SaveGame_Click(object sender, RoutedEventArgs e)
        {
            if (myShopList.Count() > 0 && myShopItem.Count() > 0)
            {
                string dateiname = "LiarsDiceData.txt";
                StreamWriter sw;
                sw = new StreamWriter(dateiname, false);

                //Writes all different Lists into one String/Textdata

                sw.Write(Convert.ToString(myAccount.GetYears()) + ",");

                sw.Flush();
                for (int i = 0; i < myShopList.Count(); i++)
                {
                    sw.Write(myShopList.ElementAt(i) + ",");
                }
                sw.Flush();
                for (int i = 0; i < myShopItem.Count(); i++)
                {
                    sw.Write(myShopItem.ElementAt(i) + ",");
                }

                sw.Flush();
                sw.Close();
                MessageBox.Show("Saved as: " + dateiname);
            }
            else
            {
                MessageBox.Show("Saving not possible!\n Open Shop and try again");
            }
        }

        private void LoadGames_Click(object sender, RoutedEventArgs e)
        {
            StreamReader sr;
            string dateiname = "LiarsDiceData.txt";
            sr = new StreamReader(dateiname);
            try
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    System.Console.WriteLine("\n Bearbeite:" + line);
                    Console.WriteLine("ich splitte nun..");
                    Char delimiter = ',';
                    String[] substring = line.Split(delimiter);

                    myShopList.Clear();
                    myShopItem.Clear();

                    //inserts different substrings where they belong
                    myAccount.SetYears(Convert.ToInt32(substring[0]));

                    myShopList.Add(Convert.ToBoolean(substring[1]));
                    myShopList.Add(Convert.ToBoolean(substring[2]));
                    myShopList.Add(Convert.ToBoolean(substring[3]));
                    myShopList.Add(Convert.ToBoolean(substring[4]));
                    myShopList.Add(Convert.ToBoolean(substring[5]));
                    myShopList.Add(Convert.ToBoolean(substring[6]));
                    myShopList.Add(Convert.ToBoolean(substring[7]));
                    myShopList.Add(Convert.ToBoolean(substring[8]));
                    myShopList.Add(Convert.ToBoolean(substring[9]));
                    myShopList.Add(Convert.ToBoolean(substring[10]));
                    myShopList.Add(Convert.ToBoolean(substring[11]));
                    myShopList.Add(Convert.ToBoolean(substring[12]));
                    myShopList.Add(Convert.ToBoolean(substring[13]));
                    myShopList.Add(Convert.ToBoolean(substring[14]));
                    myShopList.Add(Convert.ToBoolean(substring[15]));
                    myShopList.Add(Convert.ToBoolean(substring[16]));
                    myShopList.Add(Convert.ToBoolean(substring[17]));
                    myShopList.Add(Convert.ToBoolean(substring[18]));
                    myShopList.Add(Convert.ToBoolean(substring[19]));
                    myShopList.Add(Convert.ToBoolean(substring[20]));

                    myShopItem.Add(Convert.ToString(substring[21]));
                    myShopItem.Add(Convert.ToString(substring[22]));
                }
                Console.WriteLine(dateiname + " loaded");
                MessageBox.Show(dateiname + " loaded");
            }
            catch (Exception)
            {
                Console.WriteLine("Cannot load..");
                MessageBox.Show("Cannot load..");
            }
            finally
            {
                sr.Close();
            }
        }

        //===============================================================================================================

        //**************** Accountency **********************
        public int GetAccount()
        {
            return myAccount.GetYears();
        }

        public void DeductAccountYears()
        {
            myAccount.DeductYears();
        }

        public void AddAccountYears()
        {
            myAccount.AddYears();
        }

        /// <summary>
        /// Checks wether Years value is <= 0 or > 100
        /// </summary>
        /// <returns>
        /// -1 if Years > 100
        ///  1 if Years <=  0
        ///  else 0
        /// </returns>
        public int CheckAccountYears()
        {
            return myAccount.Check();
        }

        public void AddAccountYearsShop(int amount)
        {
            myAccount.AddYearsShop(amount);
        }

        //***************************************************

        public void RefreshShopLists(List<bool> ShopList, List<string> ShopItem)
        {
            myShopList = ShopList;
            myShopItem = ShopItem;
        }

        public List<bool> ReturnShopList()
        {
            return myShopList;
        }

        public List<string> ReturnShopItem()
        {
            return myShopItem;
        }     
    }
}
