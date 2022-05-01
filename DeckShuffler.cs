using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IC20_KS_DeckShuffler
{
    public partial class DeckShuffler : Form
    {
        //define deck
        List<PlayingCard> deckList = new List<PlayingCard>();
        //not String!!! we defined a new class.

        public DeckShuffler()
        {
            InitializeComponent();
        }

        private void DeckShuffler_Load(object sender, EventArgs e)
        {
            //hearts
            deckList.Add(new PlayingCard("Ace", "Hearts", Properties.Resources.ace_of_hearts, 11));
            deckList.Add(new PlayingCard("2", "Hearts", Properties.Resources._2_of_hearts, 2));
            deckList.Add(new PlayingCard("3", "Hearts", Properties.Resources._3_of_hearts, 3));
            deckList.Add(new PlayingCard("4", "Hearts", Properties.Resources._4_of_hearts, 4));
            deckList.Add(new PlayingCard("5", "Hearts", Properties.Resources._5_of_hearts, 5));
            deckList.Add(new PlayingCard("6", "Hearts", Properties.Resources._6_of_hearts, 6));
            deckList.Add(new PlayingCard("7", "Hearts", Properties.Resources._7_of_hearts, 7));
            deckList.Add(new PlayingCard("8", "Hearts", Properties.Resources._8_of_hearts, 8));
            deckList.Add(new PlayingCard("9", "Hearts", Properties.Resources._9_of_hearts, 9));
            deckList.Add(new PlayingCard("10", "Hearts", Properties.Resources._10_of_hearts, 10));
            deckList.Add(new PlayingCard("Jack", "Hearts", Properties.Resources.jack_of_hearts, 10));
            deckList.Add(new PlayingCard("Queen", "Hearts", Properties.Resources.queen_of_hearts, 10));
            deckList.Add(new PlayingCard("King", "Hearts", Properties.Resources.king_of_hearts, 10));

            //clubs
            deckList.Add(new PlayingCard("Ace", "Clubs", Properties.Resources.ace_of_clubs, 11));
            deckList.Add(new PlayingCard("2", "Clubs", Properties.Resources._2_of_clubs, 2));
            deckList.Add(new PlayingCard("3", "Clubs", Properties.Resources._3_of_clubs, 3));
            deckList.Add(new PlayingCard("4", "Clubs", Properties.Resources._4_of_clubs, 4));
            deckList.Add(new PlayingCard("5", "Clubs", Properties.Resources._5_of_clubs, 5));
            deckList.Add(new PlayingCard("6", "Clubs", Properties.Resources._6_of_clubs, 6));
            deckList.Add(new PlayingCard("7", "Clubs", Properties.Resources._7_of_clubs, 7));
            deckList.Add(new PlayingCard("8", "Clubs", Properties.Resources._8_of_clubs, 8));
            deckList.Add(new PlayingCard("9", "Clubs", Properties.Resources._9_of_clubs, 9));
            deckList.Add(new PlayingCard("10", "Clubs", Properties.Resources._10_of_clubs, 10));
            deckList.Add(new PlayingCard("Jack", "Clubs", Properties.Resources.jack_of_clubs, 10));
            deckList.Add(new PlayingCard("Queen", "Clubs", Properties.Resources.queen_of_clubs, 10));
            deckList.Add(new PlayingCard("King", "Clubs", Properties.Resources.king_of_clubs, 10));

            //diamonds
            deckList.Add(new PlayingCard("Ace", "Diamonds", Properties.Resources.ace_of_diamonds, 11));
            deckList.Add(new PlayingCard("2", "Diamonds", Properties.Resources._2_of_diamonds, 2));
            deckList.Add(new PlayingCard("3", "Diamonds", Properties.Resources._3_of_diamonds, 3));
            deckList.Add(new PlayingCard("4", "Diamonds", Properties.Resources._4_of_diamonds, 4));
            deckList.Add(new PlayingCard("5", "Diamonds", Properties.Resources._5_of_diamonds, 5));
            deckList.Add(new PlayingCard("6", "Diamonds", Properties.Resources._6_of_diamonds, 6));
            deckList.Add(new PlayingCard("7", "Diamonds", Properties.Resources._7_of_diamonds, 7));
            deckList.Add(new PlayingCard("8", "Diamonds", Properties.Resources._8_of_diamonds, 8));
            deckList.Add(new PlayingCard("9", "Diamonds", Properties.Resources._9_of_diamonds, 9));
            deckList.Add(new PlayingCard("10", "Diamonds", Properties.Resources._10_of_diamonds, 10));
            deckList.Add(new PlayingCard("Jack", "Diamonds", Properties.Resources.jack_of_diamonds, 10));
            deckList.Add(new PlayingCard("Queen", "Diamonds", Properties.Resources.queen_of_diamonds, 10));
            deckList.Add(new PlayingCard("King", "Diamonds", Properties.Resources.king_of_diamonds, 10));

            //spades
            deckList.Add(new PlayingCard("Ace", "Spades", Properties.Resources.ace_of_spades, 11));
            deckList.Add(new PlayingCard("2", "Spades", Properties.Resources._2_of_spades, 2));
            deckList.Add(new PlayingCard("3", "Spades", Properties.Resources._3_of_spades, 3));
            deckList.Add(new PlayingCard("4", "Spades", Properties.Resources._4_of_spades, 4));
            deckList.Add(new PlayingCard("5", "Spades", Properties.Resources._5_of_spades, 5));
            deckList.Add(new PlayingCard("6", "Spades", Properties.Resources._6_of_spades, 6));
            deckList.Add(new PlayingCard("7", "Spades", Properties.Resources._7_of_spades, 7));
            deckList.Add(new PlayingCard("8", "Spades", Properties.Resources._8_of_spades, 8));
            deckList.Add(new PlayingCard("9", "Spades", Properties.Resources._9_of_spades, 9));
            deckList.Add(new PlayingCard("10", "Spades", Properties.Resources._10_of_spades, 10));
            deckList.Add(new PlayingCard("Jack", "Spades", Properties.Resources.jack_of_spades, 10));
            deckList.Add(new PlayingCard("Queen", "Spades", Properties.Resources.queen_of_spades, 10));
            deckList.Add(new PlayingCard("King", "Spades", Properties.Resources.king_of_spades, 10));

            card1PictureBox.Image = Properties.Resources.blank_red;
            card2PictureBox.Image = Properties.Resources.blank_red;
            card3PictureBox.Image = Properties.Resources.blank_red;
            card4PictureBox.Image = Properties.Resources.blank_red;
        }

        private void dealButton_Click(object sender, EventArgs e)
        {
            Random numberGenerator = new Random();
            PlayingCard card1 = deckList[numberGenerator.Next(0, deckList.Count)];
            PlayingCard card2 = deckList[numberGenerator.Next(0, deckList.Count)];
            PlayingCard card3 = deckList[numberGenerator.Next(0, deckList.Count)];
            PlayingCard card4 = deckList[numberGenerator.Next(0, deckList.Count)];
            //display in pictureBox
            card1PictureBox.Image = card1.CardFace;
            card2PictureBox.Image = card2.CardFace;
            card3PictureBox.Image = card3.CardFace;
            card4PictureBox.Image = card4.CardFace;
            //display in listBox
            //PlayingCard cardHand = new PlayingCard(card1, card2, card3, card4).ToString;
            //deckList.Add(cardHand);
            //studentInfoListBox.Items.Add(newStudent);
            //cardsDealtListBox.Items.Add(cardHand);
            cardsDealtListBox.Items.Add(card1.ToString());
            cardsDealtListBox.Items.Add(card2.ToString());
            cardsDealtListBox.Items.Add(card3.ToString());
            cardsDealtListBox.Items.Add(card4.ToString());

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            card1PictureBox.Image = Properties.Resources.blank_red;
            card2PictureBox.Image = Properties.Resources.blank_red;
            card3PictureBox.Image = Properties.Resources.blank_red;
            card4PictureBox.Image = Properties.Resources.blank_red;

            cardsDealtListBox.Items.Clear();
        }
    }
}
