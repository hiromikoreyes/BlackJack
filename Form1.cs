using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    //Miko Reyes
    //June 2022

    public partial class Form1 : Form
    {


        PictureBox[] picCard = new PictureBox[100];
        PictureBox backCard = new PictureBox();
        int[] cardValue = new int[53];
        HashSet<int> playerCards = new HashSet<int>();
        HashSet<int> dealerCards = new HashSet<int>();
        HashSet<int> usedCards = new HashSet<int>();
        int playerValue = 0;
        int dealerValue = 0;
        int count = 0;


        //location vars

        int xPlayerLocation = 50;
        int yPlayerLocation = 200;
        int xDealerLocation = 50;
        int yDealerLocation = 65;


        public Form1()
        {
            InitializeComponent();
        }




        private void btnReset_Click(object sender, EventArgs e)
        {

            //music for new game
            Console.Beep(300, 100);
            Console.Beep(450, 200);
            
           



            //reset buttons and stuff
            resetPosition();
            btnDeal.Enabled = true;
            count = 0;
            

            // create back of card

            backCard = new PictureBox();
            backCard.Location = new Point(-100, 100); // putting a negative value makes it invisible without having to Visible = false;
            backCard.SizeMode = PictureBoxSizeMode.AutoSize;
            backCard.Image = Image.FromFile("backofcard.bmp");
            this.Controls.Add(backCard);




            // create other cards

            for (int i = 1; i < 53; i++)
            {

                picCard[i] = new PictureBox();
                picCard[i].Location = new Point(-100, 100); // putting a negative value makes it invisible without having to Visible = false;
                picCard[i].SizeMode = PictureBoxSizeMode.AutoSize;
                picCard[i].Image = Image.FromFile("card" + i.ToString() + ".bmp");
                this.Controls.Add(picCard[i]);

               

            }


            //assigning original value to cards

            for (int i = 2; i < 11; i++)  // diamonds
            {
                cardValue[i] = i;

            }
            for (int i = 15; i < 24; i++) // clubs
            {
                cardValue[i] = i - 13;

            }
            for (int i = 28; i < 37; i++) //hearts
            {
                cardValue[i] = i - 26;

            }
            for (int i = 41; i < 50; i++) //spades
            {
                cardValue[i] = i - 39;

            }

            cardValue[1] = 11; //default
            cardValue[14] = 11;
            cardValue[27] = 11;
            cardValue[40] = 11;

            for (int i = 0; i < 4; i++)
            {

                cardValue[11 + i * 13] = 10;
                cardValue[12 + i * 13] = 10;
                cardValue[13 + i * 13] = 10;

            }

            //This function resets all the cards
            
            playerCards.Clear();
            dealerCards.Clear();
            usedCards.Clear();

            //update positions
            updateScore();
            updatePosition();
            



            btnReset.Enabled = false;
            backCard.Location = new Point(-100, 100);

        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            Console.Beep(300, 333);

            while (true)
            {
                Random rnd = new Random();
                int RandomCard = rnd.Next(1, 53);

                

                if (!usedCards.Contains(RandomCard))
                {
                    playerCards.Add(RandomCard);
                    usedCards.Add(RandomCard);
                }


                if (playerCards.Count() == 3 + count)
                {
                    count++;
                    break;
                }



            }
            updatePosition();
            updateScore();
            checkBust();

           

        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            Console.Beep(300, 333);

            while (true)
            {
                updateScore();

                if (dealerValue > 20 || dealerValue > playerValue)
                {
                    break;
                }

               
                Random rnd = new Random();
                int RandomCard = rnd.Next(1, 53);

                if (!usedCards.Contains(RandomCard))
                {
                    dealerCards.Add(RandomCard);
                    usedCards.Add(RandomCard);
                }

               


            }
            

            checkWin();

        }

        private void button1_Click(object sender, EventArgs e) { 

            
            
            
                Console.Beep(200, 333);
                Console.Beep(222, 200);
                Console.Beep(222, 150);



            btnDeal.Enabled = false;
            btnHit.Enabled = true;
            btnStand.Enabled = true;

            // DEAL PLAYER CARDS

            while (true)
            {

                Random rnd = new Random();
                int RandomCard = rnd.Next(1, 53);


                if (!usedCards.Contains(RandomCard))
                {
                    playerCards.Add(RandomCard);
                    usedCards.Add(RandomCard);
                }

                if (playerCards.Count() == 2)
                {
                   
                    break;
                }

            }

            // DEAL DEALER CARDS
            while (true)
            {
                Random rnd = new Random();
                int RandomCard = rnd.Next(1, 53);



                if (!usedCards.Contains(RandomCard))
                {
                    dealerCards.Add(RandomCard);
                    usedCards.Add(RandomCard);
                }


                if (dealerCards.Count() == 2)
                {
                    
                    break;
                }

            }

            updatePosition();
            updateScore();
            blackJack(); // checks if it's an instant win or not
        }

        // my methods


        void updateScore()
        {

            playerValue = 0;
            dealerValue = 0;
            int playerCountAce = 0;
            int dealerCountAce = 0;


           
            for (int i = 1; i < 53; i++)
            {
                if (playerCards.Contains(i))
                {
                    playerValue = playerValue + cardValue[i];
                }
            }


            //counts how many aces you have 

            if (playerCards.Contains(1))
            {
                playerCountAce++;
            }
            if (playerCards.Contains(14))
            {
                playerCountAce++;
            }

            if (playerCards.Contains(27))
            {
                playerCountAce++;
            }

            if (playerCards.Contains(40))
            {
                playerCountAce++; 
            }

 


            if (playerCountAce > 0 && playerValue > 21)
            {

                playerValue = playerValue - 10 * playerCountAce;

            }
            //////////////////
            for (int i = 1; i < 53; i++)
            {
                if (dealerCards.Contains(i))
                {
                    dealerValue = dealerValue + cardValue[i];
                }
            }


            //counts how many aces you have 

            if (dealerCards.Contains(1))
            {
                dealerCountAce++;
            }
            if (dealerCards.Contains(14))
            {
                dealerCountAce++;
            }

            if (dealerCards.Contains(27))
            {
                dealerCountAce++;
            }

            if (dealerCards.Contains(40))
            {
                dealerCountAce++;
            }


            //subtracts ace values if you're over 21

            if (dealerCountAce > 0 && dealerValue > 21)
            {

                dealerValue = dealerValue - 10 * dealerCountAce;

            }
            ////

           
            lblPlayerValue.Text = "Player Value: " + Convert.ToString(playerValue);
           

        }

        void resetPosition()
        {
            backCard.Visible = false;

            for (int i = 0; i < playerCards.Count(); i++)
            {

                picCard[playerCards.ElementAt(i)].Visible = false;




            }
            for (int i = 0; i < dealerCards.Count(); i++)
            {
                picCard[dealerCards.ElementAt(i)].Visible = false;
            }

        }

        void updatePosition()
        {

            for (int i = 0; i < playerCards.Count(); i++)
            {


                picCard[playerCards.ElementAt(i)].Location = new Point(xPlayerLocation + (i * 10), yPlayerLocation);
                picCard[playerCards.ElementAt(i)].BringToFront();




            }
            for (int i = 0; i < dealerCards.Count(); i++)
            {

                if(i == 0)
                {
                   backCard.Location = new Point(xDealerLocation + (i * 10), yDealerLocation);
                    backCard.BringToFront();

                }
                else
                {
                    picCard[dealerCards.ElementAt(i)].Location = new Point(xDealerLocation + (i * 10), yDealerLocation);
                    picCard[dealerCards.ElementAt(i)].BringToFront();
                }


                
            }


        }

        void finalPosition()
        {

            for (int i = 0; i < playerCards.Count(); i++)
            {


                picCard[playerCards.ElementAt(i)].Location = new Point(xPlayerLocation + (i * 10), yPlayerLocation);
                picCard[playerCards.ElementAt(i)].BringToFront();




            }
            for (int i = 0; i < dealerCards.Count(); i++)
            {

             
     
                    picCard[dealerCards.ElementAt(i)].Location = new Point(xDealerLocation + (i * 10), yDealerLocation);
                    picCard[dealerCards.ElementAt(i)].BringToFront();




            }

        }



        void checkBust()
        {

            if (playerValue > 21) // player bust
            {
                loseScreen();
               

            }

        }

        void checkWin()
        {

            if (dealerValue > 21) // dealer bust
            {
                winScreen();
              
            }

            if (playerValue > dealerValue) //player has a higher score than the dealer
            {
                winScreen();
                
            }


            if (playerValue < dealerValue && dealerValue <= 21) //player has a lower score than dealer && dealer has not busted
            {
                loseScreen();
                
            }

            if(dealerValue == playerValue)
            {

                MessageBox.Show("YOU TIED!!!");
                finalPosition();
                disableAllButtons();
                btnReset.Enabled = true;

            }

        }

        //// Change txt labels nd stuff
        ///

        void winScreen()
        {
            
            finalPosition();
            disableAllButtons();
            MessageBox.Show("YOU WIN!!!");
            btnReset.Enabled = true;
            
            //sound effect happy
            Console.Beep(261, 233);
            Console.Beep(329, 233);
            Console.Beep(392, 233);


        }
        void loseScreen()
        {
            
            finalPosition();
            disableAllButtons();
            MessageBox.Show("YOU LOSE!!!");
            btnReset.Enabled = true;

            //sad sound effect
            Console.Beep(392, 233);
            Console.Beep(311, 233);
            Console.Beep(261, 233);

        }

        void disableAllButtons()
        {
            btnDeal.Enabled = false;
            btnHit.Enabled = false;
            btnStand.Enabled = false;
        }
       
        void blackJack()
        {

            if (playerCards.Count == 2) {
               
                
                if (playerCards.Contains(1) && playerValue == 21 || playerCards.Contains(14) && playerValue == 21 
                    || playerCards.Contains(27) && playerValue == 21 || playerCards.Contains(40) && playerValue == 21
                    )
                {
           
                       
                  
                        winScreen();
                        

                
            }
            
            
            }




        }
        




    }
}
