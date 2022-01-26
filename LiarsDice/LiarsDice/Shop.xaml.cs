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
using System.Windows.Shapes;

namespace LiarsDice
{
    /// <summary>
    /// Interaction logic for Shop.xaml
    /// </summary>
    public partial class Shop : Window
    {
        MainWindow wndMain = Application.Current.MainWindow as MainWindow;


        private string DiceName = "White";
        private string BGName = "PlaygroundBG";

        bool UseWhiteClick = false;

        bool BuyWoodClick = false;
        bool UseWoodClick = false;
        bool WoodBought = false;

        bool BuyLeatherClick = false;
        bool UseLeatherClick = false;
        bool LeatherBought = false;

        bool BuyRainbowClick = false;
        bool UseRainbowClick = false;
        bool RainbowBought = false;

        bool BuyJackClick = false;
        bool UseJackClick = false;
        bool JackBought = false;

        bool UseDefaultBGClick = false;

        bool BuyBarBGClick = false;
        bool UseBarBGClick = false;
        bool BarBGBought = false;

        bool BuyQuatersBGClick = false;
        bool UseQuatersBGClick = false;
        bool QuatersBGBought = false;

        //TODO: Liste aus Bool an Mainwindow übergeben/holen
        //TODO: Auswerten der Liste in Init
        //TODO: Strings BG und Dicename an Mainwindow und dann an Playground übegenben

        private List<bool> ToList()
        {
            List<bool> ShopList = new List<bool>();
            ShopList.Clear();

            ShopList.Add(UseWhiteClick);
            ShopList.Add(BuyWoodClick);
            ShopList.Add(UseWoodClick);
            ShopList.Add(WoodBought);
            ShopList.Add(BuyLeatherClick);
            ShopList.Add(UseLeatherClick);
            ShopList.Add(LeatherBought);
            ShopList.Add(BuyRainbowClick);
            ShopList.Add(UseRainbowClick);
            ShopList.Add(RainbowBought);
            ShopList.Add(BuyJackClick);
            ShopList.Add(UseJackClick);
            ShopList.Add(JackBought);
            ShopList.Add(UseDefaultBGClick);
            ShopList.Add(BuyBarBGClick);
            ShopList.Add(UseBarBGClick);
            ShopList.Add(BarBGBought);
            ShopList.Add(BuyQuatersBGClick);
            ShopList.Add(UseQuatersBGClick);
            ShopList.Add(QuatersBGBought);
            return ShopList;
        }

        private List<string> ToListItem()
        {
            List<string> ShopItem = new List<string>();
            ShopItem.Clear();

            ShopItem.Add(DiceName);
            ShopItem.Add(BGName);

            return ShopItem;
        }


        public Shop()
        {
            InitializeComponent();
            //Init funktion für use buttons / buy... weil spielladen
            //Funktion für speicherdaten laden dies das
            //Vergisst was gekauft wurde beim fensterschließen
            //ggf. static oder ins mainwindow übergeben (als liste beim fensterschließen)


            InitShop();

            RefreshBuyButtonsBG();
            RefreshUseButtonsBG();
            RefreshBuyButtonsDice();
            RefreshUseButtonsDice();
            RefreshUseButton();
            ChangeYears();
        }

        private void InitShop()
        {
            List<bool> ShopList = new List<bool>();
            List<string> ShopItem = new List<string>();

            if (wndMain != null)
            {

                ShopList = wndMain.ReturnShopList();
                ShopItem = wndMain.ReturnShopItem();
            }
            if (ShopList.Count != 0 && ShopItem.Count != 0)
            {
                UseWhiteClick = ShopList.ElementAt(0);

                BuyWoodClick = ShopList.ElementAt(1);
                UseWoodClick = ShopList.ElementAt(2);
                WoodBought = ShopList.ElementAt(3);

                BuyLeatherClick = ShopList.ElementAt(4);
                UseLeatherClick = ShopList.ElementAt(5);
                LeatherBought = ShopList.ElementAt(6);

                BuyRainbowClick = ShopList.ElementAt(7);
                UseRainbowClick = ShopList.ElementAt(8);
                RainbowBought = ShopList.ElementAt(9);

                BuyJackClick = ShopList.ElementAt(10);
                UseJackClick = ShopList.ElementAt(11);
                JackBought = ShopList.ElementAt(12);

                UseDefaultBGClick = ShopList.ElementAt(13);

                BuyBarBGClick = ShopList.ElementAt(14);
                UseBarBGClick = ShopList.ElementAt(15);
                BarBGBought = ShopList.ElementAt(16);

                BuyQuatersBGClick = ShopList.ElementAt(17);
                UseQuatersBGClick = ShopList.ElementAt(18);
                QuatersBGBought = ShopList.ElementAt(19);

                DiceName = ShopItem.ElementAt(0);
                BGName = ShopItem.ElementAt(1);
            }
        }

        private void RefreshUseButton()
        {
            if(DiceName == "White")
            {
                BGUseWhite.Source = new BitmapImage(new Uri(@"Stuff/ChoosenButton.png", UriKind.Relative));
            }
            else if (DiceName == "Wood")
            {
                BGUseWood.Source = new BitmapImage(new Uri(@"Stuff/ChoosenButton.png", UriKind.Relative));
            }
            else if (DiceName == "Leather")
            {
                BGUseLeather.Source = new BitmapImage(new Uri(@"Stuff/ChoosenButton.png", UriKind.Relative));
            }
            else if (DiceName == "Rainbow")
            {
                BGUseRainbow.Source = new BitmapImage(new Uri(@"Stuff/ChoosenButton.png", UriKind.Relative));
            }
            else if (DiceName == "Jack")
            {
                BGUseJack.Source = new BitmapImage(new Uri(@"Stuff/ChoosenButton.png", UriKind.Relative));
            }

            if(BGName == "PlaygroundBG")
            {
                BGUseDefault.Source = new BitmapImage(new Uri(@"Stuff/ChoosenButton.png", UriKind.Relative));
            }
            else if (BGName == "BarPlayground")
            {
                BGUseBar.Source = new BitmapImage(new Uri(@"Stuff/ChoosenButton.png", UriKind.Relative));
            }
            else if (BGName == "KajutePlayground")
            {
                BGUseKajute.Source = new BitmapImage(new Uri(@"Stuff/ChoosenButton.png", UriKind.Relative));
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            //Variablen an MainWindow übergeben
            //Dicename und BackgroundName
            //Bool Variablen als liste

            if (wndMain != null)
            {
                wndMain.RefreshShopLists(ToList(), ToListItem());
            }
        }

        //**************** Accountency **********************
        public int getAccount()
        {
            if (wndMain != null)
            {
                return wndMain.GetAccount();
            }
            return -1;
        }

        public int CheckAccount()
        {
            if (wndMain != null)
            {
                return wndMain.CheckAccountYears();
            }
            return -2;
        }

        public void deductYears()
        {
            if (wndMain != null)
            {
                wndMain.DeductAccountYears();
            }
        }

        public void addYears()
        {
            if (wndMain != null)
            {
                wndMain.AddAccountYears();
            }
        }

        public void addYearsShop(int amount)
        {
            if (wndMain != null)
            {
                wndMain.AddAccountYearsShop(amount);
            }
        }

        //***************************************************

        private void ChangeYears()
        {
            MyYears.Text = "";
            MyYears.Text = Convert.ToString(getAccount());
        }

        private void RefreshBuyButtonsDice()
        {
            if(WoodBought)
            {
                BuyWoodClick = true;
                BGBuyWood.Source = new BitmapImage(new Uri(@"Stuff/ButtonDisabled.png", UriKind.Relative));
            }
            if(LeatherBought)
            {
                BuyLeatherClick = true;
                BGBuyLeather.Source = new BitmapImage(new Uri(@"Stuff/ButtonDisabled.png", UriKind.Relative));
            }
            if (RainbowBought)
            {
                BuyRainbowClick = true;
                BGBuyRainbow.Source = new BitmapImage(new Uri(@"Stuff/ButtonDisabled.png", UriKind.Relative));
            }
            if (JackBought)
            {
                BuyJackClick = true;
                BGBuyJack.Source = new BitmapImage(new Uri(@"Stuff/ButtonDisabled.png", UriKind.Relative));
            }
        }

        private void RefreshBuyButtonsBG()
        {
            if (BarBGBought)
            {
                BuyBarBGClick = true;
                BGBuyBar.Source = new BitmapImage(new Uri(@"Stuff/ButtonDisabled.png", UriKind.Relative));
            }
            if (QuatersBGBought)
            {
                BuyQuatersBGClick = true;
                BGBuyKajute.Source = new BitmapImage(new Uri(@"Stuff/ButtonDisabled.png", UriKind.Relative));
            }
        }
        private void RefreshUseButtonsBG()
        {
            BGUseDefault.Source = new BitmapImage(new Uri(@"Stuff/ChatButton.png", UriKind.Relative));

            if (BarBGBought)
            {
                BGUseBar.Source = new BitmapImage(new Uri(@"Stuff/ChatButton.png", UriKind.Relative));
            }
            else
            {
                BGUseBar.Source = new BitmapImage(new Uri(@"Stuff/ButtonDisabled.png", UriKind.Relative));
            }

            if (QuatersBGBought)
            {
                BGUseKajute.Source = new BitmapImage(new Uri(@"Stuff/ChatButton.png", UriKind.Relative));
            }
            else
            {
                BGUseKajute.Source = new BitmapImage(new Uri(@"Stuff/ButtonDisabled.png", UriKind.Relative));
            }
            UseDefaultBGClick = false;
            UseBarBGClick = false;
            UseQuatersBGClick = false;
        }

        private void RefreshUseButtonsDice()
        {
            BGUseWhite.Source = new BitmapImage(new Uri(@"Stuff/ChatButton.png", UriKind.Relative));

            if(WoodBought)
            {
                BGUseWood.Source = new BitmapImage(new Uri(@"Stuff/ChatButton.png", UriKind.Relative));
            }
            else
            {
                BGUseWood.Source = new BitmapImage(new Uri(@"Stuff/ButtonDisabled.png", UriKind.Relative));
            }

            if (LeatherBought)
            {
                BGUseLeather.Source = new BitmapImage(new Uri(@"Stuff/ChatButton.png", UriKind.Relative));
            }
            else
            {
                BGUseLeather.Source = new BitmapImage(new Uri(@"Stuff/ButtonDisabled.png", UriKind.Relative));
            }

            if (RainbowBought)
            {
                BGUseRainbow.Source = new BitmapImage(new Uri(@"Stuff/ChatButton.png", UriKind.Relative));
            }
            else
            {
                BGUseRainbow.Source = new BitmapImage(new Uri(@"Stuff/ButtonDisabled.png", UriKind.Relative));
            }

            if (JackBought)
            {
                BGUseJack.Source = new BitmapImage(new Uri(@"Stuff/ChatButton.png", UriKind.Relative));
            }
            else
            {
                BGUseJack.Source = new BitmapImage(new Uri(@"Stuff/ButtonDisabled.png", UriKind.Relative));
            }
            UseWhiteClick = false;
            UseWoodClick = false;
            UseLeatherClick = false;
            UseRainbowClick = false;
            UseJackClick = false;
        }

        //========== User Buttons =========================================

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void UseWhite_Click(object sender, RoutedEventArgs e)
        {
            if (!UseWhiteClick)
            {
                DiceName = "White";
                RefreshUseButtonsDice();
                UseWhiteClick = true;
                BGUseWhite.Source = new BitmapImage(new Uri(@"Stuff/ChoosenButton.png", UriKind.Relative));
            }
        }

        private void BuyWood_Click(object sender, RoutedEventArgs e)
        {
            if (!BuyWoodClick)
            {
                if (getAccount() + 10 < 101)
                {
                    BuyWoodClick = true;
                    WoodBought = true;
                    BGBuyWood.Source = new BitmapImage(new Uri(@"Stuff/ButtonDisabled.png", UriKind.Relative));
                    BGUseWood.Source = new BitmapImage(new Uri(@"Stuff/ChatButton.png", UriKind.Relative));
                    addYearsShop(10);
                    ChangeYears();
                }
                else
                {
                    MessageBox.Show("You cannot afford this!\nIt costs 10 Years\n You would be bound to the ship forever!\n\n \"I saved you, be gratefull!\"");
                }
            }
        }

        private void UseWood_Click(object sender, RoutedEventArgs e)
        {
            if (!UseWoodClick && WoodBought)
            {
                DiceName = "Wood";
                RefreshUseButtonsDice();
                UseWoodClick = true;
                BGUseWood.Source = new BitmapImage(new Uri(@"Stuff/ChoosenButton.png", UriKind.Relative));
            }
        }

        private void BuyLeather_Click(object sender, RoutedEventArgs e)
        {
            if (!BuyLeatherClick)
            {
                if (getAccount() + 10 < 101)
                {
                    BuyLeatherClick = true;
                    LeatherBought = true;
                    BGBuyLeather.Source = new BitmapImage(new Uri(@"Stuff/ButtonDisabled.png", UriKind.Relative));
                    BGUseLeather.Source = new BitmapImage(new Uri(@"Stuff/ChatButton.png", UriKind.Relative));
                    addYearsShop(10);
                    ChangeYears();
                }
                else
                {
                    MessageBox.Show("You cannot afford this!\nIt costs 10 Years\n You would be bound to the ship forever!\n\n \"I saved you, be gratefull!\"");
                }
            }
        }

        private void UseLeather_Click(object sender, RoutedEventArgs e)
        {
            if (!UseLeatherClick && LeatherBought)
            {
                DiceName = "Leather";
                RefreshUseButtonsDice();
                UseLeatherClick = true;
                BGUseLeather.Source = new BitmapImage(new Uri(@"Stuff/ChoosenButton.png", UriKind.Relative));
            }
        }

        private void BuyRainbow_Click(object sender, RoutedEventArgs e)
        {
            if (!BuyRainbowClick)
            {
                if (getAccount() + 20 < 101)
                {
                    BuyRainbowClick = true;
                    RainbowBought = true;
                    BGBuyRainbow.Source = new BitmapImage(new Uri(@"Stuff/ButtonDisabled.png", UriKind.Relative));
                    BGUseRainbow.Source = new BitmapImage(new Uri(@"Stuff/ChatButton.png", UriKind.Relative));
                    addYearsShop(20);
                    ChangeYears();
                }
                else
                {
                    MessageBox.Show("You cannot afford this!\nIt costs 20 Years\n You would be bound to the ship forever!\n\n \"I saved you, be gratefull!\"");
                }
            }
        }

        private void UseRainbow_Click(object sender, RoutedEventArgs e)
        {
            if (!UseRainbowClick && RainbowBought)
            {
                DiceName = "Rainbow";
                RefreshUseButtonsDice();
                UseRainbowClick = true;
                BGUseRainbow.Source = new BitmapImage(new Uri(@"Stuff/ChoosenButton.png", UriKind.Relative));
            }
        }

        private void BuyJack_Click(object sender, RoutedEventArgs e)
        {
            if (!BuyJackClick)
            {
                if (getAccount() + 40 < 101)
                {
                    BuyJackClick = true;
                    JackBought = true;
                    BGBuyJack.Source = new BitmapImage(new Uri(@"Stuff/ButtonDisabled.png", UriKind.Relative));
                    BGUseJack.Source = new BitmapImage(new Uri(@"Stuff/ChatButton.png", UriKind.Relative));
                    addYearsShop(40);
                    ChangeYears();
                }
                else
                {
                    MessageBox.Show("You cannot afford this!\nIt costs 40 Years\n You would be bound to the ship forever!\n\n \"I saved you, be gratefull!\"");
                }
            }
        }

        private void UseJack_Click(object sender, RoutedEventArgs e)
        {
            if (!UseJackClick && JackBought)
            {
                DiceName = "Jacks";
                RefreshUseButtonsDice();
                UseJackClick = true;
                BGUseJack.Source = new BitmapImage(new Uri(@"Stuff/ChoosenButton.png", UriKind.Relative));
            }

        }

        private void UseDeafult_Click(object sender, RoutedEventArgs e)
        {
            if (!UseDefaultBGClick)
            {
                BGName = "PlaygroundBG";
                RefreshUseButtonsBG();
                UseDefaultBGClick = true;
                BGUseDefault.Source = new BitmapImage(new Uri(@"Stuff/ChoosenButton.png", UriKind.Relative));
            }
        }

        private void BuyBar_Click(object sender, RoutedEventArgs e)
        {
            if (!BuyBarBGClick)
            {
                if (getAccount() + 20 < 101)
                {
                    BuyBarBGClick = true;
                    BarBGBought = true;
                    BGBuyBar.Source = new BitmapImage(new Uri(@"Stuff/ButtonDisabled.png", UriKind.Relative));
                    BGUseBar.Source = new BitmapImage(new Uri(@"Stuff/ChatButton.png", UriKind.Relative));
                    addYearsShop(20);
                    ChangeYears();
                }
                else
                {
                    MessageBox.Show("You cannot afford this!\nIt costs 20 Years\n You would be bound to the ship forever!\n\n \"I saved you, be gratefull!\"");
                }
            }

        }

        private void UseBar_Click(object sender, RoutedEventArgs e)
        {
            if (!UseBarBGClick && BarBGBought)
            {
                BGName = "BarPlayground";
                RefreshUseButtonsBG();
                UseBarBGClick = true;
                BGUseBar.Source = new BitmapImage(new Uri(@"Stuff/ChoosenButton.png", UriKind.Relative));
            }

        }

        private void BuyKajute_Click(object sender, RoutedEventArgs e)
        {
            if (!BuyQuatersBGClick)
            {
                if (getAccount() + 50 < 101)
                {
                    BuyQuatersBGClick = true;
                    QuatersBGBought = true;
                    BGBuyKajute.Source = new BitmapImage(new Uri(@"Stuff/ButtonDisabled.png", UriKind.Relative));
                    BGUseKajute.Source = new BitmapImage(new Uri(@"Stuff/ChatButton.png", UriKind.Relative));
                    addYearsShop(50);
                    ChangeYears();
                }
                else
                {
                    MessageBox.Show("You cannot afford this!\nIt costs 50 Years\n You would be bound to the ship forever!\n\n \"I saved you, be gratefull!\"");
                }
            }

        }

        private void UseKajute_Click(object sender, RoutedEventArgs e)
        {
            if (!UseQuatersBGClick && QuatersBGBought)
            {
                BGName = "KajutePlayground";
                RefreshUseButtonsBG();
                UseQuatersBGClick = true;
                BGUseKajute.Source = new BitmapImage(new Uri(@"Stuff/ChoosenButton.png", UriKind.Relative));
            }

        }

        //===================================================================
    }
}
