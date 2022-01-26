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
    /// Interaction logic for Playground.xaml
    /// </summary>
    public partial class Playground : Window
    {
        //run code in a different window
        MainWindow wndMain = Application.Current.MainWindow as MainWindow;

        static UInt16[] PlayerDice = new UInt16[5];
        static UInt16[] EnemyDice = new UInt16[5];

        bool rollDiceBool = false;
        bool continueBool = false;
        bool bluffBool = false;

        UInt16 myCallAmount = 0;
        UInt16 myCallEyes = 0;

        UInt16 enemyCallAmount = 0;
        UInt16 enemyCallEyes = 0;

        UInt16 SupremeCallAmount = 0;
        UInt16 SupremeCallEyes = 0;

        string DiceName = "White";
        string BackgroundName = "PlaygroundBG";

        public Playground()
        {
            InitializeComponent();

            UseShopItems();
            PlaygroundBGDefault.Source = new BitmapImage(new Uri(@"Stuff/" + BackgroundName + ".jpg", UriKind.Relative));
            ChangeYears();
            Chat.Text = "";
            Chat.Text = "Round started..\n";
        }

        /// <summary>
        /// Get the DiceName and BackgroundName from the Lists in MainWindow
        /// </summary>
        private void UseShopItems()
        {
            List<string> myItems = new List<string>();

            if (wndMain != null)
            {
                myItems = wndMain.ReturnShopItem();
            }
            if(myItems.Count != 0)
            {
                DiceName = myItems.ElementAt(0);
                BackgroundName = myItems.ElementAt(1);
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
            if(wndMain != null)
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

        //***************************************************

        /// <summary>
        /// Reset all Values to play another round
        /// </summary>
        private void NewGame()
        {
            for(int index = 0; index < 5; index++)
            {
                PlayerDice[index] = 0;
                EnemyDice[index] = 0;
            }

            rollDiceBool = false;
            continueBool = false;
            bluffBool = false;

            myCallAmount = 0;
            myCallEyes = 0;

            enemyCallAmount = 0;
            enemyCallEyes = 0;

            SupremeCallAmount = 0;
            SupremeCallEyes = 0;

            BackgroundRollDice.Source = new BitmapImage(new Uri(@"Stuff/ChatButton.png", UriKind.Relative));
            BackgroundBluff.Source = new BitmapImage(new Uri(@"Stuff/ButtonDisabled.png", UriKind.Relative));
            BackgroundContinue.Source = new BitmapImage(new Uri(@"Stuff/ButtonDisabled.png", UriKind.Relative));

            My1Dice.Source = new BitmapImage(new Uri(@"Stuff/GoldQuestionmark.png", UriKind.Relative));
            My2Dice.Source = new BitmapImage(new Uri(@"Stuff/GoldQuestionmark.png", UriKind.Relative));
            My3Dice.Source = new BitmapImage(new Uri(@"Stuff/GoldQuestionmark.png", UriKind.Relative));
            My4Dice.Source = new BitmapImage(new Uri(@"Stuff/GoldQuestionmark.png", UriKind.Relative));
            My5Dice.Source = new BitmapImage(new Uri(@"Stuff/GoldQuestionmark.png", UriKind.Relative));

            Enemey1Dice.Source = new BitmapImage(new Uri(@"Stuff/GoldQuestionmark.png", UriKind.Relative));
            Enemey2Dice.Source = new BitmapImage(new Uri(@"Stuff/GoldQuestionmark.png", UriKind.Relative));
            Enemey3Dice.Source = new BitmapImage(new Uri(@"Stuff/GoldQuestionmark.png", UriKind.Relative));
            Enemey4Dice.Source = new BitmapImage(new Uri(@"Stuff/GoldQuestionmark.png", UriKind.Relative));
            Enemey5Dice.Source = new BitmapImage(new Uri(@"Stuff/GoldQuestionmark.png", UriKind.Relative));

            DisableAmoutButtons();
            DisableDiceEyeButtons();

            EnemyDiceAmount.Text = "";
            MyDiceAmount.Text = "";

            Chat.Text = "";
            Chat.Text = "--New Round--\n\n";

            ChangeYears();
        }

        private void EnableAmoutButtons()
        {
            Amount1.IsEnabled = true;
            Amount2.IsEnabled = true;
            Amount3.IsEnabled = true;
            Amount4.IsEnabled = true;
            Amount5.IsEnabled = true;
            Amount6.IsEnabled = true;
            Amount7.IsEnabled = true;
            Amount8.IsEnabled = true;
            Amount9.IsEnabled = true;
            Amount10.IsEnabled = true;
        }

        private void DisableAmoutButtons()
        {
            Amount1.IsEnabled = false;
            Amount2.IsEnabled = false;
            Amount3.IsEnabled = false;
            Amount4.IsEnabled = false;
            Amount5.IsEnabled = false;
            Amount6.IsEnabled = false;
            Amount7.IsEnabled = false;
            Amount8.IsEnabled = false;
            Amount9.IsEnabled = false;
            Amount10.IsEnabled = false;
        }

        private void EnableDiceEyeButtons()
        {
            DiceEye1.IsEnabled = true;
            DiceEye2.IsEnabled = true;
            DiceEye3.IsEnabled = true;
            DiceEye4.IsEnabled = true;
            DiceEye5.IsEnabled = true;
            DiceEye6.IsEnabled = true;
        }

        private void DisableDiceEyeButtons()
        {
            DiceEye1.IsEnabled = false;
            DiceEye2.IsEnabled = false;
            DiceEye3.IsEnabled = false;
            DiceEye4.IsEnabled = false;
            DiceEye5.IsEnabled = false;
            DiceEye6.IsEnabled = false;
        }

        private void ChangeMyCall()
        {
            MyDiceAmount.Text = "";
            MyDiceAmount.Text = myCallAmount + " x " + myCallEyes + "s";
        }

        private void ChangeEnemyCall()
        {
            EnemyDiceAmount.Text = "";
            EnemyDiceAmount.Text = SupremeCallAmount + " x " + SupremeCallEyes + "s";
        }

        private void ChangeYears()
        {
            MyYears.Text = "";
            MyYears.Text = Convert.ToString(getAccount());
        }


        //--------------------- Buttons for Dice-Input ---------------------------------------------
        private void Amount1_Click(object sender, RoutedEventArgs e)
        {
            EnableAmoutButtons();
            Amount1.IsEnabled = false;
            myCallAmount = 1;
            ChangeMyCall();
        }

        private void Amount2_Click(object sender, RoutedEventArgs e)
        {
            EnableAmoutButtons();
            Amount2.IsEnabled = false;
            myCallAmount = 2;
            ChangeMyCall();
        }

        private void Amount3_Click(object sender, RoutedEventArgs e)
        {
            EnableAmoutButtons();
            Amount3.IsEnabled = false;
            myCallAmount = 3;
            ChangeMyCall();
        }

        private void Amount4_Click(object sender, RoutedEventArgs e)
        {
            EnableAmoutButtons();
            Amount4.IsEnabled = false;
            myCallAmount = 4;
            ChangeMyCall();
        }

        private void Amount5_Click(object sender, RoutedEventArgs e)
        {
            EnableAmoutButtons();
            Amount5.IsEnabled = false;
            myCallAmount = 5;
            ChangeMyCall();
        }

        private void Amount6_Click(object sender, RoutedEventArgs e)
        {
            EnableAmoutButtons();
            Amount6.IsEnabled = false;
            myCallAmount = 6;
            ChangeMyCall();
        }

        private void Amount7_Click(object sender, RoutedEventArgs e)
        {
            EnableAmoutButtons();
            Amount7.IsEnabled = false;
            myCallAmount = 7;
            ChangeMyCall();
        }

        private void Amount8_Click(object sender, RoutedEventArgs e)
        {
            EnableAmoutButtons();
            Amount8.IsEnabled = false;
            myCallAmount = 8;
            ChangeMyCall();
        }

        private void Amount9_Click(object sender, RoutedEventArgs e)
        {
            EnableAmoutButtons();
            Amount9.IsEnabled = false;
            myCallAmount = 9;
            ChangeMyCall();
        }

        private void Amount10_Click(object sender, RoutedEventArgs e)
        {
            EnableAmoutButtons();
            Amount10.IsEnabled = false;
            myCallAmount = 10;
            ChangeMyCall();
        }


        private void DiceEye1_Click(object sender, RoutedEventArgs e)
        {
            EnableDiceEyeButtons();
            DiceEye1.IsEnabled = false;
            myCallEyes = 1;
            ChangeMyCall();
        }

        private void DiceEye2_Click(object sender, RoutedEventArgs e)
        {
            EnableDiceEyeButtons();
            DiceEye2.IsEnabled = false;
            myCallEyes = 2;
            ChangeMyCall();
        }

        private void DiceEye3_Click(object sender, RoutedEventArgs e)
        {
            EnableDiceEyeButtons();
            DiceEye3.IsEnabled = false;
            myCallEyes = 3;
            ChangeMyCall();
        }

        private void DiceEye4_Click(object sender, RoutedEventArgs e)
        {
            EnableDiceEyeButtons();
            DiceEye4.IsEnabled = false;
            myCallEyes = 4;
            ChangeMyCall();
        }

        private void DiceEye5_Click(object sender, RoutedEventArgs e)
        {
            EnableDiceEyeButtons();
            DiceEye5.IsEnabled = false;
            myCallEyes = 5;
            ChangeMyCall();
        }

        private void DiceEye6_Click(object sender, RoutedEventArgs e)
        {
            EnableDiceEyeButtons();
            DiceEye6.IsEnabled = false;
            myCallEyes = 6;
            ChangeMyCall();
        }

        //--------------------------------------------------------------------------------
        //___________ Player-Round _______________________________________________________

        private void RolltheDice_Click(object sender, RoutedEventArgs e)
        {
            if (!rollDiceBool)
            {
                Random rdm = new Random();
                rollDiceBool = true;
                UInt16 nextDice;
                
                //generates random dice rolls
                for (int index = 0; index < 5; index++)
                {
                    nextDice = Convert.ToUInt16(rdm.Next(1, 6));
                    PlayerDice[index] = nextDice;
                }

                for (int index = 0; index < 5; index++)
                {
                    nextDice = Convert.ToUInt16(rdm.Next(1, 6));
                    EnemyDice[index] = nextDice;
                }

                My1Dice.Source = new BitmapImage(new Uri(@"Stuff/Dice/" + DiceName + Convert.ToString(PlayerDice[0]) + ".png", UriKind.Relative));
                My2Dice.Source = new BitmapImage(new Uri(@"Stuff/Dice/" + DiceName + Convert.ToString(PlayerDice[1]) + ".png", UriKind.Relative));
                My3Dice.Source = new BitmapImage(new Uri(@"Stuff/Dice/" + DiceName + Convert.ToString(PlayerDice[2]) + ".png", UriKind.Relative));
                My4Dice.Source = new BitmapImage(new Uri(@"Stuff/Dice/" + DiceName + Convert.ToString(PlayerDice[3]) + ".png", UriKind.Relative));
                My5Dice.Source = new BitmapImage(new Uri(@"Stuff/Dice/" + DiceName + Convert.ToString(PlayerDice[4]) + ".png", UriKind.Relative));

                BackgroundRollDice.Source = new BitmapImage(new Uri(@"Stuff/ButtonDisabled.png", UriKind.Relative));
                BackgroundContinue.Source = new BitmapImage(new Uri(@"Stuff/ChatButton.png", UriKind.Relative));
                EnableDiceEyeButtons();
                EnableAmoutButtons();
                continueBool = true;
            }
        }

        private void Continue_Click(object sender, RoutedEventArgs e)
        {
            if(continueBool)
            {
                if (myCallAmount != 0 && myCallEyes != 0)
                {
                    //Definition of a correct dice call
                    if ((myCallAmount > SupremeCallAmount && myCallEyes >= SupremeCallEyes) || (myCallAmount >= SupremeCallAmount && myCallEyes > SupremeCallEyes))
                    {
                        SupremeCallAmount = myCallAmount;
                        SupremeCallEyes = myCallEyes;

                        continueBool = false;
                        BackgroundContinue.Source = new BitmapImage(new Uri(@"Stuff/ButtonDisabled.png", UriKind.Relative));
                        DisableAmoutButtons();
                        DisableDiceEyeButtons();
                        EnemyRound();
                    }
                    else
                    {
                        MessageBox.Show("Diceamout or Diceeyes are to low");
                    }
                }
                else
                {
                    MessageBox.Show("Please Insert Diceamount or Diceeyes");
                }
            }
        }

        private void Bluff_Click(object sender, RoutedEventArgs e)
        {
            int counter = 0;

            if (bluffBool)
            {
                //Show enemy dice
                Enemey1Dice.Source = new BitmapImage(new Uri(@"Stuff/Dice/Red" + Convert.ToString(EnemyDice[0]) + ".png", UriKind.Relative));
                Enemey2Dice.Source = new BitmapImage(new Uri(@"Stuff/Dice/Red" + Convert.ToString(EnemyDice[1]) + ".png", UriKind.Relative));
                Enemey3Dice.Source = new BitmapImage(new Uri(@"Stuff/Dice/Red" + Convert.ToString(EnemyDice[2]) + ".png", UriKind.Relative));
                Enemey4Dice.Source = new BitmapImage(new Uri(@"Stuff/Dice/Red" + Convert.ToString(EnemyDice[3]) + ".png", UriKind.Relative));
                Enemey5Dice.Source = new BitmapImage(new Uri(@"Stuff/Dice/Red" + Convert.ToString(EnemyDice[4]) + ".png", UriKind.Relative));

                //Calculate Result
                for (int index = 0; index < 5; index++)
                {
                    if (PlayerDice[index] == SupremeCallEyes)
                        counter++;

                    if (EnemyDice[index] == SupremeCallEyes)
                        counter++;
                }
                if (counter >= SupremeCallAmount)
                {
                    //Enemy won
                    addYears();
                    MessageBox.Show("You LOST!!!\n\n ××× Your Enemy did not lie! ×××\n How dare you to tell that I am a LIAR!!\n\n + 10 Years");
                }
                else
                {
                    //Player won
                    deductYears();
                    MessageBox.Show("You WON!!!\n\n *** Your Enemy is a LIAR! ***\n\n - 10 Years");
                }
                if(wndMain != null)
                {
                    if(wndMain.CheckAccountYears() == -1)
                    {
                        MessageBox.Show("\t\tGAME OVER\n\nYou lost your Soul to the SHIP!\n");
                        wndMain.Close();
                        this.Close();
                    }
                    if (wndMain.CheckAccountYears() == 1)
                    {
                        MessageBox.Show("\t\tYou beat the Game\n\n You are free to go!\n");
                    }
                }
                if (Convert.ToBoolean(ShouldWindowClose.IsChecked))
                {
                    ChangeYears();
                    NewGame();
                }
                else
                {
                    this.Close();
                }
            }
        }

        //______________________________________________________________________________

        //____________ KI-Round ________________________________________________________
        private bool BluffOrNoBluffCalculator()
        {
            int possibility = 95;
            int randomNumber;
            bool bluff = false;
            int counter = 0;
            Random rdm = new Random();

            //calculate if KI should play on or check the result
            randomNumber = rdm.Next(0, 100);
            if(SupremeCallAmount <= 4)
            {
                possibility = 60;
            }
            if (SupremeCallAmount >= 5)
            {
                possibility = 20;
            }


            if (randomNumber >= possibility)
            {
                //decision if KI could easily call more
                if (SupremeCallAmount == 1 || SupremeCallAmount == 2) //KI weak
                {
                    for (int index = 0; index < 5; index++)
                    {
                        if (EnemyDice[index] == SupremeCallEyes)
                        {
                            counter++;
                        }
                    }
                    if (counter < SupremeCallAmount)
                    {
                        randomNumber = rdm.Next(0, 100);
                        if (randomNumber < possibility)
                        {
                            // Player bluff
                            bluff = true;
                        }
                        else
                        {
                            // Player does not bluff
                            bluff = false;
                        }
                    }
                    else
                    {
                        // Player does not bluff
                        bluff = false;
                    }
                }
                else if (SupremeCallAmount == 3) //KI medium
                {
                    for (int index = 0; index < 5; index++)
                    {
                        if (EnemyDice[index] == SupremeCallEyes)
                        {
                            counter++;
                        }
                    }
                    if (counter < SupremeCallAmount)
                    {
                        if (counter == 0)
                        {
                            possibility = 85;
                        }
                        if (counter == 1)
                        {
                            possibility = 93;
                        }
                        if (counter == 2)
                        {
                            possibility = 98;
                        }


                        randomNumber = rdm.Next(0, 100);
                        if (randomNumber < possibility)
                        {
                            // Player bluff
                            bluff = true;
                        }
                        else
                        {
                            // Player does not bluff
                            bluff = false;
                        }
                    }
                    else
                    {
                        // Player does not bluff
                        bluff = false;
                    }

                }
                else if (SupremeCallAmount == 4) //KI strong
                {
                    for (int index = 0; index < 5; index++)
                    {
                        if (EnemyDice[index] == SupremeCallEyes)
                        {
                            counter++;
                        }
                    }
                    if (counter < SupremeCallAmount)
                    {
                        if (counter == 0)
                        {
                            possibility = 20;
                        }
                        if (counter == 1)
                        {
                            possibility = 38;
                        }
                        if (counter == 2)
                        {
                            possibility = 72;
                        }
                        if (counter == 3)
                        {
                            possibility = 85;
                        }

                        randomNumber = rdm.Next(0, 100);
                        if (randomNumber < possibility)
                        {
                            // Player bluff
                            bluff = true;
                        }
                        else
                        {
                            // Player does not bluff
                            bluff = false;
                        }
                    }
                    else
                    {
                        // Player does not bluff
                        bluff = false;
                    }

                }
                else if (SupremeCallAmount == 5) // KI xtream
                {
                    for (int index = 0; index < 5; index++)
                    {
                        if (EnemyDice[index] == SupremeCallEyes)
                        {
                            counter++;
                        }
                    }

                    if (counter < SupremeCallAmount)
                    {
                        if (counter == 0)
                        {
                            possibility = 2;
                        }
                        if (counter == 1)
                        {
                            possibility = 5;
                        }
                        if (counter == 2)
                        {
                            possibility = 9;
                        }
                        if (counter == 3)
                        {
                            possibility = 12;
                        }
                        if (counter == 4)
                        {
                            possibility = 15;
                        }

                        randomNumber = rdm.Next(0, 100);
                        if (randomNumber < possibility)
                        {
                            // Player bluff
                            bluff = true;
                        }
                        else
                        {
                            // Player does not bluff
                            bluff = false;
                        }
                    }
                    else
                    {
                        // Player does not bluff
                        bluff = false;
                    }

                }
                else if (SupremeCallAmount == 6 || SupremeCallAmount == 7) //KI xtream strong
                {
                    for (int index = 0; index < 5; index++)
                    {
                        if (EnemyDice[index] == SupremeCallEyes)
                        {
                            counter++;
                        }
                    }
                    if (counter > 0)
                    {
                        if (counter == 1)
                        {
                            possibility = 1;
                        }
                        if (counter == 2)
                        {
                            possibility = 2;
                        }
                        if (counter == 3)
                        {
                            possibility = 4;
                        }
                        if (counter == 4)
                        {
                            possibility = 10;
                        }
                        if (counter == 5)
                        {
                            possibility = 16;
                        }

                        randomNumber = rdm.Next(0, 100);
                        if (randomNumber < possibility)
                        {
                            // Player bluff
                            bluff = true;
                        }
                        else
                        {
                            // Player does not bluff
                            bluff = false;
                        }
                    }
                    else
                    {
                        // Player bluff
                        bluff = true;
                    }
                }
                else if (SupremeCallAmount > 7) //KI impossible
                {
                    for (int index = 0; index < 5; index++)
                    {
                        if (EnemyDice[index] == SupremeCallEyes)
                        {
                            counter++;
                        }
                    }
                    if (counter > 0)
                    {
                        if (counter == 1)
                        {
                            possibility = 1;
                        }
                        if (counter == 2)
                        {
                            possibility = 2;
                        }
                        if (counter == 3)
                        {
                            possibility = 3;
                        }
                        if (counter == 4)
                        {
                            possibility = 4;
                        }
                        if (counter == 5)
                        {
                            possibility = 7;
                        }

                        randomNumber = rdm.Next(0, 100);
                        if (randomNumber < possibility)
                        {
                            // Player bluff
                            bluff = true;
                        }
                        else
                        {
                            // Player does not bluff
                            bluff = false;
                        }
                    }
                    else
                    {
                        // Player bluff
                        bluff = true;
                    }
                }
            }
            return bluff;
        }

        private bool CreateEnemyCall()
        {
            bool correct = false;
            bool possible = false;
            UInt16 temp = 0;
            int counter = 0;
            int counter1 = 0;
            int counter2 = 0;
            int counter3 = 0;
            int counter4 = 0;
            int counter5 = 0;
            int counter6 = 0;
            int randomNumber;

            Random rdm = new Random();

            //calculating own dice
            for (int index = 0; index < 5; index++)
            {
                if (EnemyDice[index] == 1)
                {
                    counter1++;
                }
                else if (EnemyDice[index] == 2)
                {
                    counter2++;
                }
                else if (EnemyDice[index] == 3)
                {
                    counter3++;
                }
                else if (EnemyDice[index] == 4)
                {
                    counter4++;
                }
                else if (EnemyDice[index] == 5)
                {
                    counter5++;
                }
                else if (EnemyDice[index] == 6)
                {
                    counter6++;
                }
            }

            //sort dice
            List<int> CounterList = new List<int>();
            CounterList.Add(counter1);
            CounterList.Add(counter2);
            CounterList.Add(counter3);
            CounterList.Add(counter4);
            CounterList.Add(counter5);
            CounterList.Add(counter6);

            CounterList.Sort();
            counter = CounterList.Last();

            //set DiceEys
            if (counter1 == counter)
            {
                enemyCallEyes = 1;
            }
            if (counter2 == counter)
            {
                enemyCallEyes = 2;
            }
            if (counter3 == counter)
            {
                enemyCallEyes = 3;
            }
            if (counter4 == counter)
            {
                enemyCallEyes = 4;
            }
            if (counter5 == counter)
            {
                enemyCallEyes = 5;
            }
            if (counter6 == counter)
            {
                enemyCallEyes = 6;
            }

            //Should KI lie completly or tell nearly the truth
            randomNumber = rdm.Next(0, 100);
            if (randomNumber < 90)
            {
                //Truth
                //Set Amount
                if (counter == 1 || counter == 2)
                {
                    randomNumber = rdm.Next(0, 2);
                    enemyCallAmount = Convert.ToUInt16(counter + randomNumber);
                }
                else
                {
                    randomNumber = rdm.Next(0, 1);
                    enemyCallAmount = Convert.ToUInt16(counter + randomNumber);
                }
            }
            else
            {
                //Lie
                if (counter == 1 || counter == 2)
                {
                    randomNumber = rdm.Next(0, 4);
                    enemyCallAmount = Convert.ToUInt16(counter + randomNumber);
                    while (!possible)
                    {
                        randomNumber = rdm.Next(0, 4);
                        temp = Convert.ToUInt16(enemyCallEyes + randomNumber);
                        if (temp < 6)
                        {
                            possible = true;
                            enemyCallEyes = temp;
                        }
                    }
                }
                else
                {
                    randomNumber = rdm.Next(0, 3);
                    enemyCallAmount = Convert.ToUInt16(counter + randomNumber);
                    while (!possible)
                    {
                        randomNumber = rdm.Next(0, 2);
                        temp = Convert.ToUInt16(enemyCallEyes + randomNumber);
                        if (temp <= 6)
                        {
                            possible = true;
                            enemyCallEyes = temp;
                        }
                    }
                }
            }

            if ((enemyCallAmount > SupremeCallAmount && enemyCallEyes >= SupremeCallEyes) || (enemyCallAmount >= SupremeCallAmount && enemyCallEyes > SupremeCallEyes))
            {
                correct = true;
                SupremeCallAmount = enemyCallAmount;
                SupremeCallEyes = enemyCallEyes;
            }
            return correct;
        }

        private void EnemyRound()
        {
            Random rdm = new Random();
            int randomNumber;
            bool bluff = false;
            bool correct = false;
            int counter = 0;
            int stopTheLoop = 0;

            //Enemy decides if you bluff
            bluff = BluffOrNoBluffCalculator();

            if (!bluff)
            {
                //Enemy calculates own Dice Amound and Eyes
                while (!correct)
                {
                    correct = CreateEnemyCall();
                    stopTheLoop++;

                    if(stopTheLoop == 1000000) //stoping KI loop
                    {
                        correct = true;
                        bluff = true;
                    }

                }

                if (!bluff)
                {
                    randomNumber = rdm.Next(0, 4);
                    switch (randomNumber)
                    {
                        case 0:
                            ChatGoingDownEnemy();
                            break;
                        case 1:
                            ChatGoodMoveEnemy();
                            break;
                        case 2:
                            ChatThanksEnemy();
                            break;
                        case 3:
                            ChatWatchEnemy();
                            break;
                    }
                    

                    //End enemy round
                    ChangeEnemyCall();
                    MyDiceAmount.Text = "";
                    EnableAmoutButtons();
                    EnableDiceEyeButtons();
                    continueBool = true;
                    bluffBool = true;
                    BackgroundBluff.Source = new BitmapImage(new Uri(@"Stuff/ChatButton.png", UriKind.Relative));
                    BackgroundContinue.Source = new BitmapImage(new Uri(@"Stuff/ChatButton.png", UriKind.Relative));
                }
            }
            if(bluff)
            {
                counter = 0;

                //Show enemy dice
                Enemey1Dice.Source = new BitmapImage(new Uri(@"Stuff/Dice/Red" + Convert.ToString(EnemyDice[0]) + ".png", UriKind.Relative));
                Enemey2Dice.Source = new BitmapImage(new Uri(@"Stuff/Dice/Red" + Convert.ToString(EnemyDice[1]) + ".png", UriKind.Relative));
                Enemey3Dice.Source = new BitmapImage(new Uri(@"Stuff/Dice/Red" + Convert.ToString(EnemyDice[2]) + ".png", UriKind.Relative));
                Enemey4Dice.Source = new BitmapImage(new Uri(@"Stuff/Dice/Red" + Convert.ToString(EnemyDice[3]) + ".png", UriKind.Relative));
                Enemey5Dice.Source = new BitmapImage(new Uri(@"Stuff/Dice/Red" + Convert.ToString(EnemyDice[4]) + ".png", UriKind.Relative));


                for (int index = 0; index < 5; index++)
                {
                    if (PlayerDice[index] == SupremeCallEyes)
                        counter++;

                    if (EnemyDice[index] == SupremeCallEyes)
                        counter++;
                }
                if (counter >= SupremeCallAmount)
                {
                    //Player won
                    deductYears();
                    MessageBox.Show("*** Enemy calls BLUFF ***\n\n Are you a liar?");
                    MessageBox.Show("You WON!!!\n\n *** You are a Truth-teller!! ***\n\n - 10 Years");
                }
                else
                {
                    //Enemy won
                    addYears();
                    MessageBox.Show("*** Enemy calls BLUFF ***\n\n Are you a liar?");
                    MessageBox.Show("You LOST!!!\n\n ××× You are a filthy LIAR!! ×××\n\n + 10 Years");
                }
                if (wndMain != null)
                {
                    if (wndMain.CheckAccountYears() == -1)
                    {
                        MessageBox.Show("\t\tGAME OVER\n\nYou lost your Soul to the SHIP!\n");
                        wndMain.Close();
                        this.Close();
                    }
                    if (wndMain.CheckAccountYears() == 1)
                    {
                        MessageBox.Show("\t\tYou beat the Game\n\n You are free to go!\n");
                    }
                }
                if (Convert.ToBoolean(ShouldWindowClose.IsChecked))
                {
                    ChangeYears();
                    NewGame();
                }
                else
                {
                    this.Close();
                }
            }
        }


        //______________________________________________________________________________

        //=================== CHAT =====================================================

        private void ChatThanks_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int randomNumber;

            randomNumber = rnd.Next(0, 4);
            switch (randomNumber)
            {
                case 0:
                    Chat.Text = Chat.Text + "You: Thank you!\n";
                    break;
                case 1:
                    Chat.Text = Chat.Text + "You: HAHAHAHAHAH!\n";
                    break;
                case 2:
                    Chat.Text = Chat.Text + "You: Grazie!\n";
                    break;
                case 3:
                    Chat.Text = Chat.Text + "You: Thanks a LOT!\n";
                    break;
            }
            ChatThanksEnemy();
        }

        private void ChatGoingDown_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int randomNumber;

            randomNumber = rnd.Next(0, 4);
            switch (randomNumber)
            {
                case 0:
                    Chat.Text = Chat.Text + "You: You're going down!\n";
                    break;
                case 1:
                    Chat.Text = Chat.Text + "You: HAHAHAHAHAH!\n";
                    break;
                case 2:
                    Chat.Text = Chat.Text + "You: You have no chance!\n";
                    break;
                case 3:
                    Chat.Text = Chat.Text + "You: Not even in a million!\n";
                    break;
            }
            ChatGoingDownEnemy();
        }  

        private void ChatWatch_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int randomNumber;

            randomNumber = rnd.Next(0, 4);
            switch (randomNumber)
            {
                case 0:
                    Chat.Text = Chat.Text + "You: Watch it!\n";
                    break;
                case 1:
                    Chat.Text = Chat.Text + "You: You'll see!\n";
                    break;
                case 2:
                    Chat.Text = Chat.Text + "You: Have a LOOK!\n";
                    break;
                case 3:
                    Chat.Text = Chat.Text + "You: You better watch out!\n";
                    break;
            }
            ChatWatchEnemy();
        }

        private void ChatGoodMove_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int randomNumber;

            randomNumber = rnd.Next(0, 4);
            switch (randomNumber)
            {
                case 0:
                    Chat.Text = Chat.Text + "You: Good move!\n";
                    break;
                case 1:
                    Chat.Text = Chat.Text + "You: I am impressed!\n";
                    break;
                case 2:
                    Chat.Text = Chat.Text + "You: Impossible!\n";
                    break;
                case 3:
                    Chat.Text = Chat.Text + "You: gg!\n";
                    break;
            }
            ChatGoodMoveEnemy();
        }

        private void ChatThanksEnemy()
        {
            Random rnd = new Random();
            int randomNumber;
            randomNumber = rnd.Next(0, 100);
            if (randomNumber < 60)
            {
                randomNumber = rnd.Next(0, 4);
                switch (randomNumber)
                {
                    case 0:
                        Chat.Text = Chat.Text + "Enemy: Arrrgh!\n";
                        break;
                    case 1:
                        Chat.Text = Chat.Text + "Enemy: You will see!\n";
                        break;
                    case 2:
                        Chat.Text = Chat.Text + "Enemy: F*ck!\n";
                        break;
                    case 3:
                        Chat.Text = Chat.Text + "Enemy: *silence*\n";
                        break;
                }
            }
        }

        private void ChatGoingDownEnemy()
        {
            Random rnd = new Random();
            int randomNumber;
            randomNumber = rnd.Next(0, 100);
            if (randomNumber < 60)
            {
                randomNumber = rnd.Next(0, 4);
                switch (randomNumber)
                {
                    case 0:
                        Chat.Text = Chat.Text + "Enemy: Don't do it!\n";
                        break;
                    case 1:
                        Chat.Text = Chat.Text + "Enemy: You have no idea!\n";
                        break;
                    case 2:
                        Chat.Text = Chat.Text + "Enemy: You will see!\n";
                        break;
                    case 3:
                        Chat.Text = Chat.Text + "Enemy: Hrgnh!\n";
                        break;
                }
            }
        }

        private void ChatWatchEnemy()
        {
            Random rnd = new Random();
            int randomNumber;
            randomNumber = rnd.Next(0, 100);
            if (randomNumber < 60)
            {
                randomNumber = rnd.Next(0, 4);
                switch (randomNumber)
                {
                    case 0:
                        Chat.Text = Chat.Text + "Enemy: Im blind, WTF!\n";
                        break;
                    case 1:
                        Chat.Text = Chat.Text + "Enemy: I see no man!\n";
                        break;
                    case 2:
                        Chat.Text = Chat.Text + "Enemy: *stares intensely*\n";
                        break;
                    case 3:
                        Chat.Text = Chat.Text + "Enemy: *Eye pops out*\n";
                        break;
                }
            }
        }

        private void ChatGoodMoveEnemy()
        {
            Random rnd = new Random();
            int randomNumber;
            randomNumber = rnd.Next(0, 100);
            if (randomNumber < 60)
            {
                randomNumber = rnd.Next(0, 4);
                switch (randomNumber)
                {
                    case 0:
                        Chat.Text = Chat.Text + "Enemy: l2p!\n";
                        break;
                    case 1:
                        Chat.Text = Chat.Text + "Enemy: You shall not pass!\n";
                        break;
                    case 2:
                        Chat.Text = Chat.Text + "Enemy: You'v got no chance!\n";
                        break;
                    case 3:
                        Chat.Text = Chat.Text + "Enemy: Try me!\n";
                        break;
                }
            }
        }

        //==============================================================================

        private void Chat_TextChanged(object sender, TextChangedEventArgs e)
        {
            Chat.ScrollToEnd();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            BackgroundContinue.Source = new BitmapImage(new Uri(@"Stuff/ButtonDisabled.png", UriKind.Relative));
            BackgroundBluff.Source = new BitmapImage(new Uri(@"Stuff/ButtonDisabled.png", UriKind.Relative));
            DisableAmoutButtons();
            DisableDiceEyeButtons();
        }

    }
}
