using System;
using System.Drawing;
using System.Windows.Forms;
using WinnerWinnerChickenDinner.Classes;

namespace WinnerWinnerChickenDinner
{
    public partial class MainForm : Form
    {
        public Shoe shoe;
        public DealerHand dealerHand;
        public MyHand myHand;
        public AdvStrategy advStrategy;

        public int[] tableCards = new int[52];

        public void CleanTable()
        {
            for (int i = 0; i <= 51; i++)
                tableCards[i] = 0;
        }

        public void AddToTable(int value)
        {
            tableCards[0]++;
            tableCards[tableCards[0]] = value;
        }

        public void ShowTable()
        {
            for (int i = 1; i <= tableCards[0]; i++)
            {
                if ((i % 11 == 1) && (i > 1))
                    richTextBoxSuggestions.AppendText(Environment.NewLine);

                richTextBoxSuggestions.SelectionFont = new Font(richTextBoxSuggestions.Font, FontStyle.Bold);
                richTextBoxSuggestions.AppendText(shoe.ConvertNrToSym(tableCards[i]) + " ");
                richTextBoxSuggestions.SelectionFont = new Font(richTextBoxSuggestions.Font, FontStyle.Regular);
            }
        }

        public MainForm()
        {
            InitializeComponent();
            InitMyData();
        }

        public void InitMyData()
        {
            shoe = new Shoe();
            dealerHand = new DealerHand();
            myHand = new MyHand();
            advStrategy = new AdvStrategy();

            this.Location = new Point(10, 100);

            UpdateBoxCards();
        }

        public void UpdateBoxCards()
        {
            richTextBoxCards.ResetText();
            richTextBoxCards.SelectionFont = new Font(richTextBoxCards.Font, FontStyle.Bold);
            richTextBoxCards.AppendText("Cards Drawn/Left");
            richTextBoxCards.AppendText(Environment.NewLine + shoe.GetCardsDrawnProcent().ToString() + "%" + "  -  " + shoe.GetNrCardsDrawn().ToString());
            richTextBoxCards.SelectionFont = new Font(richTextBoxCards.Font, FontStyle.Regular);

            for (int i = 2; i <= 9; i++)
                richTextBoxCards.AppendText(Environment.NewLine + "Drawn [" + shoe.ConvertNrToSym(i) + "]   - " + shoe.GetSNrXDrawnCards(i) + " / " + shoe.GetSNrXDrawnCardsLeft(i));
            richTextBoxCards.AppendText(Environment.NewLine + "Drawn [" + shoe.ConvertNrToSym(10) + "] - " + shoe.GetSNrXDrawnCards(10) + " / " + shoe.GetSNrXDrawnCardsLeft(10)    + "      X  -X");
            richTextBoxCards.AppendText(Environment.NewLine + "Drawn [" + shoe.ConvertNrToSym(11) + "]   - " + shoe.GetSNrXDrawnCards(11) + " / " + shoe.GetSNrXDrawnCardsLeft(11)  + "   mX dX");
            richTextBoxCards.AppendText(Environment.NewLine + "Drawn [" + shoe.ConvertNrToSym(12) + "]    - " + shoe.GetSNrXDrawnCards(12) + " / " + shoe.GetSNrXDrawnCardsLeft(12) + "            r");
            richTextBoxCards.AppendText(Environment.NewLine + "Drawn [" + shoe.ConvertNrToSym(13) + "]   - " + shoe.GetSNrXDrawnCards(13) + " / " + shoe.GetSNrXDrawnCardsLeft(13)  + "           xt");
            richTextBoxCards.AppendText(Environment.NewLine + "Drawn [" + shoe.ConvertNrToSym(14) + "]   - " + shoe.GetSNrXDrawnCards(14) + " / " + shoe.GetSNrXDrawnCardsLeft(14)  + "     xm xd");

            richTextBoxCards.SelectionFont = new Font(richTextBoxCards.Font, FontStyle.Bold);
            richTextBoxCards.AppendText(Environment.NewLine + Environment.NewLine + "Dealer Card: " + shoe.ConvertNrToSym(dealerHand.GetDealerCard()));
            myHand.GetTheSumOfCardsInHand(out int sum1, out int sum2);
            richTextBoxCards.AppendText(Environment.NewLine + Environment.NewLine + "My Cards: " + myHand.GetNrCardsInHand().ToString() + "  --  " + sum1.ToString() + "/" + sum2.ToString() +  Environment.NewLine);
            richTextBoxCards.SelectionFont = new Font(richTextBoxCards.Font, FontStyle.Regular);
            for (int i = 1; i <= myHand.GetNrCardsInHand(); i++)
                richTextBoxCards.AppendText(shoe.ConvertNrToSym(myHand.GetTheXCardInHand(i)) + " ");
        }

        public void ShowHelpMenu()
        {
            richTextBoxSuggestions.ResetText();
            richTextBoxSuggestions.SelectionFont = new Font(richTextBoxSuggestions.Font, FontStyle.Bold);
            richTextBoxSuggestions.AppendText("Help Menu");
            richTextBoxSuggestions.SelectionFont = new Font(richTextBoxSuggestions.Font, FontStyle.Regular);
            richTextBoxSuggestions.AppendText(Environment.NewLine);
            richTextBoxSuggestions.AppendText(Environment.NewLine);
            richTextBoxSuggestions.AppendText("X           for adding card to shoe");
            richTextBoxSuggestions.AppendText(Environment.NewLine);
            richTextBoxSuggestions.AppendText("mX        for adding card to my hand");
            richTextBoxSuggestions.AppendText(Environment.NewLine);
            richTextBoxSuggestions.AppendText("dX         for adding card to dealer hand");
            richTextBoxSuggestions.AppendText(Environment.NewLine);
            richTextBoxSuggestions.AppendText("-X          for deleting a card from shoe");
            richTextBoxSuggestions.AppendText(Environment.NewLine);
            richTextBoxSuggestions.AppendText("r            - clear for a new pack cards");
            richTextBoxSuggestions.AppendText(Environment.NewLine);
            richTextBoxSuggestions.AppendText("xt           - new table (my hand and dealers hand)");
            richTextBoxSuggestions.AppendText(Environment.NewLine);
            richTextBoxSuggestions.AppendText("xm         - clears my hand");
            richTextBoxSuggestions.AppendText(Environment.NewLine);
            richTextBoxSuggestions.AppendText("xd          - clears dealers hand");
            richTextBoxSuggestions.AppendText(Environment.NewLine);
            richTextBoxSuggestions.AppendText(Environment.NewLine);
            richTextBoxSuggestions.AppendText("trs (generate) // thc (hit) // tss (show)");
            richTextBoxSuggestions.AppendText(Environment.NewLine);
            richTextBoxSuggestions.AppendText("h (help menu)");
            richTextBoxSuggestions.AppendText(Environment.NewLine);
        }

        public void UpdateBoxSuggestionsTestShoe(int value)
        {
            richTextBoxSuggestions.ResetText();
            for (int i = 1; i <= 8 * 52; i++)
            {
                if ((i % 21 == 1) && (i > 1))
                    richTextBoxSuggestions.AppendText(Environment.NewLine);

                if (i == value)
                {
                    richTextBoxSuggestions.SelectionFont = new Font(richTextBoxSuggestions.Font, FontStyle.Bold);
                    richTextBoxSuggestions.AppendText(shoe.ConvertNrToSym(shoe.GetTheXCardFromShoe(i)) + " ");
                    richTextBoxSuggestions.SelectionFont = new Font(richTextBoxSuggestions.Font, FontStyle.Regular);
                }
                else
                    richTextBoxSuggestions.AppendText(shoe.ConvertNrToSym(shoe.GetTheXCardFromShoe(i)) + " ");
            }
        }

        public void ShowWhatToDo()
        {
            int dealerCard = 0;
            string advicetHand = "";
            string adviceOption = "";

            ///// print adv strategy advice /////
            richTextBoxSuggestions.ResetText();

            myHand.GetTheSumOfCardsInHand(out int sum1, out int sum2);
            dealerCard = dealerHand.GetDealerCard();

            if ((dealerCard == 0) || (sum1 == 0) || (sum1 > 21))
            {
                ShowHelpMenu();
                return;
            }

            if (dealerCard >= 12)
                dealerCard = 10;

            if (myHand.GotPair() == 1)
            {
                advicetHand = "PAIR ->   ";
                adviceOption = advStrategy.ReturnPairAdvice(sum1 / 2, dealerCard);
            }
            else
                if (myHand.GotSoft() == 1)
                {
                    advicetHand = "SOFT ->   ";
                    adviceOption = advStrategy.ReturnSoftAdvice(sum2, dealerCard);
                }
                else
                    if (myHand.GotNormal() == 1)
                    {
                        advicetHand = "NORM ->   ";
                        adviceOption = advStrategy.ReturnNormalAdvice(sum1, dealerCard);
                    }
                    else
                        advicetHand = "ERROR - fail to determine the type of hand";

            richTextBoxSuggestions.AppendText("True Count: ");
            richTextBoxSuggestions.SelectionFont = new Font(richTextBoxSuggestions.Font, FontStyle.Bold);
            richTextBoxSuggestions.AppendText(shoe.GetTrueCount().ToString("F"));
            richTextBoxSuggestions.SelectionFont = new Font(richTextBoxSuggestions.Font, FontStyle.Regular);
            richTextBoxSuggestions.AppendText(Environment.NewLine);
            richTextBoxSuggestions.AppendText(Environment.NewLine);
            richTextBoxSuggestions.AppendText("Advice from Advance Strategy Guide");
            richTextBoxSuggestions.AppendText(Environment.NewLine);
            richTextBoxSuggestions.AppendText(advicetHand);
            richTextBoxSuggestions.SelectionFont = new Font(richTextBoxSuggestions.Font, FontStyle.Bold);
            richTextBoxSuggestions.AppendText(adviceOption);
            richTextBoxSuggestions.SelectionFont = new Font(richTextBoxSuggestions.Font, FontStyle.Regular);
            richTextBoxSuggestions.AppendText(Environment.NewLine);
            richTextBoxSuggestions.AppendText(Environment.NewLine);
            richTextBoxSuggestions.AppendText("Favorable cards: " + (shoe.GetFavCards(sum2)).ToString() + "   Total cards left: " + shoe.GetNrCardsLeft().ToString());
            richTextBoxSuggestions.AppendText(Environment.NewLine);
            richTextBoxSuggestions.AppendText("Procent: ");
            richTextBoxSuggestions.SelectionFont = new Font(richTextBoxSuggestions.Font, FontStyle.Bold);
            richTextBoxSuggestions.AppendText(Math.Round((shoe.GetFavCards(sum2) * 100.0 / shoe.GetNrCardsLeft()), 2).ToString());
            richTextBoxSuggestions.SelectionFont = new Font(richTextBoxSuggestions.Font, FontStyle.Regular);
            richTextBoxSuggestions.AppendText(Environment.NewLine);
            richTextBoxSuggestions.AppendText(Environment.NewLine);
            richTextBoxSuggestions.AppendText("Cards on this table: ");
            richTextBoxSuggestions.AppendText(Environment.NewLine);
            ShowTable();
        }

        private void TextBoxInput_KeyDown(object sender, KeyEventArgs e)
        {
            int hMenu = 0;

            if (e.KeyCode == Keys.Enter)
            {
                string textBox = textBoxInput.Text;
                char[] delims = { ' ', '.', ',', '\n' };
                string[] words = textBox.Split(delims);

                foreach (string s in words)
                {
                    switch (s.ToLower())
                    {
                        #region Card To Shoe
                        case "2":
                            {
                                shoe.SetAddCardToShoe(2);
                                AddToTable(2);
                                break;
                            }
                        case "3":
                            {
                                shoe.SetAddCardToShoe(3);
                                AddToTable(3);
                                break;
                            }
                        case "4":
                            {
                                shoe.SetAddCardToShoe(4);
                                AddToTable(4);
                                break;
                            }
                        case "5":
                            {
                                shoe.SetAddCardToShoe(5);
                                AddToTable(5);
                                break;
                            }
                        case "6":
                            {
                                shoe.SetAddCardToShoe(6);
                                AddToTable(6);
                                break;
                            }
                        case "7":
                            {
                                shoe.SetAddCardToShoe(7);
                                AddToTable(7);
                                break;
                            }
                        case "8":
                            {
                                shoe.SetAddCardToShoe(8);
                                AddToTable(8);
                                break;
                            }
                        case "9":
                            {
                                shoe.SetAddCardToShoe(9);
                                AddToTable(9);
                                break;
                            }
                        case "10":
                            {
                                shoe.SetAddCardToShoe(10);
                                AddToTable(10);
                                break;
                            }
                        case "11":
                            {
                                shoe.SetAddCardToShoe(11);
                                AddToTable(11);
                                break;
                            }
                        case "12":
                            {
                                shoe.SetAddCardToShoe(12);
                                AddToTable(12);
                                break;
                            }
                        case "13":
                            {
                                shoe.SetAddCardToShoe(13);
                                AddToTable(13);
                                break;
                            }
                        case "14":
                            {
                                shoe.SetAddCardToShoe(14);
                                AddToTable(14);
                                break;
                            }
                        case "a":
                            {
                                shoe.SetAddCardToShoe(11);
                                AddToTable(11);
                                break;
                            }
                        case "j":
                            {
                                shoe.SetAddCardToShoe(12);
                                AddToTable(12);
                                break;
                            }
                        case "q":
                            {
                                shoe.SetAddCardToShoe(13);
                                AddToTable(13);
                                break;
                            }
                        case "k":
                            {
                                shoe.SetAddCardToShoe(14);
                                AddToTable(14);
                                break;
                            }
                        #endregion

                        #region Card To hand
                        case "m2":
                            {
                                myHand.SetAddCardInHand(2);
                                break;
                            }
                        case "m3":
                            {
                                myHand.SetAddCardInHand(3);
                                break;
                            }
                        case "m4":
                            {
                                myHand.SetAddCardInHand(4);
                                break;
                            }
                        case "m5":
                            {
                                myHand.SetAddCardInHand(5);
                                break;
                            }
                        case "m6":
                            {
                                myHand.SetAddCardInHand(6);
                                break;
                            }
                        case "m7":
                            {
                                myHand.SetAddCardInHand(7);
                                break;
                            }
                        case "m8":
                            {
                                myHand.SetAddCardInHand(8);
                                break;
                            }
                        case "m9":
                            {
                                myHand.SetAddCardInHand(9);
                                break;
                            }
                        case "m10":
                            {
                                myHand.SetAddCardInHand(10);
                                break;
                            }
                        case "m11":
                            {
                                myHand.SetAddCardInHand(11);
                                break;
                            }
                        case "m12":
                            {
                                myHand.SetAddCardInHand(12);
                                break;
                            }
                        case "m13":
                            {
                                myHand.SetAddCardInHand(13);
                                break;
                            }
                        case "m14":
                            {
                                myHand.SetAddCardInHand(14);
                                break;
                            }
                        case "ma":
                            {
                                myHand.SetAddCardInHand(11);
                                break;
                            }
                        case "mj":
                            {
                                myHand.SetAddCardInHand(12);
                                break;
                            }
                        case "mq":
                            {
                                myHand.SetAddCardInHand(13);
                                break;
                            }
                        case "mk":
                            {
                                myHand.SetAddCardInHand(14);
                                break;
                            }
                        #endregion

                        #region Dealer Hand
                        case "d2":
                            {
                                dealerHand.SetDealerCard(2);
                                break;
                            }
                        case "d3":
                            {
                                dealerHand.SetDealerCard(3);
                                break;
                            }
                        case "d4":
                            {
                                dealerHand.SetDealerCard(4);
                                break;
                            }
                        case "d5":
                            {
                                dealerHand.SetDealerCard(5);
                                break;
                            }
                        case "d6":
                            {
                                dealerHand.SetDealerCard(6);
                                break;
                            }
                        case "d7":
                            {
                                dealerHand.SetDealerCard(7);
                                break;
                            }
                        case "d8":
                            {
                                dealerHand.SetDealerCard(8);
                                break;
                            }
                        case "d9":
                            {
                                dealerHand.SetDealerCard(9);
                                break;
                            }
                        case "d10":
                            {
                                dealerHand.SetDealerCard(10);
                                break;
                            }
                        case "d11":
                            {
                                dealerHand.SetDealerCard(11);
                                break;
                            }
                        case "d12":
                            {
                                dealerHand.SetDealerCard(12);
                                break;
                            }
                        case "d13":
                            {
                                dealerHand.SetDealerCard(13);
                                break;
                            }
                        case "d14":
                            {
                                dealerHand.SetDealerCard(14);
                                break;
                            }
                        case "da":
                            {
                                dealerHand.SetDealerCard(11);
                                break;
                            }
                        case "dj":
                            {
                                dealerHand.SetDealerCard(12);
                                break;
                            }
                        case "dq":
                            {
                                dealerHand.SetDealerCard(13);
                                break;
                            }
                        case "dk":
                            {
                                dealerHand.SetDealerCard(14);
                                break;
                            }
                        #endregion

                        #region Remove Card Shoe
                        case "-2":
                            {
                                shoe.SetDelCardFromShoe(2);
                                break;
                            }
                        case "-3":
                            {
                                shoe.SetDelCardFromShoe(3);
                                break;
                            }
                        case "-4":
                            {
                                shoe.SetDelCardFromShoe(4);
                                break;
                            }
                        case "-5":
                            {
                                shoe.SetDelCardFromShoe(5);
                                break;
                            }
                        case "-6":
                            {
                                shoe.SetDelCardFromShoe(6);
                                break;
                            }
                        case "-7":
                            {
                                shoe.SetDelCardFromShoe(7);
                                break;
                            }
                        case "-8":
                            {
                                shoe.SetDelCardFromShoe(8);
                                break;
                            }
                        case "-9":
                            {
                                shoe.SetDelCardFromShoe(9);
                                break;
                            }
                        case "-10":
                            {
                                shoe.SetDelCardFromShoe(10);
                                break;
                            }
                        case "-11":
                            {
                                shoe.SetDelCardFromShoe(11);
                                break;
                            }
                        case "-12":
                            {
                                shoe.SetDelCardFromShoe(12);
                                break;
                            }
                        case "-13":
                            {
                                shoe.SetDelCardFromShoe(13);
                                break;
                            }
                        case "-14":
                            {
                                shoe.SetDelCardFromShoe(14);
                                break;
                            }
                        case "-a":
                            {
                                shoe.SetDelCardFromShoe(11);
                                break;
                            }
                        case "-j":
                            {
                                shoe.SetDelCardFromShoe(12);
                                break;
                            }
                        case "-q":
                            {
                                shoe.SetDelCardFromShoe(13);
                                break;
                            }
                        case "-k":
                            {
                                shoe.SetDelCardFromShoe(14);
                                break;
                            }
                        #endregion

                        //// new shoe
                        case "r":
                            {
                                shoe = new Shoe();
                                myHand = new MyHand();
                                dealerHand = new DealerHand();
                                CleanTable();
                                break;
                            }

                        //// new table 
                        case "xt":
                            {
                                myHand = new MyHand();
                                dealerHand = new DealerHand();
                                CleanTable();
                                break;
                            }

                        //// new dealer hand
                        case "xd":
                            {
                                dealerHand = new DealerHand();
                                break;
                            }

                        //// new my hand
                        case "xm":
                            {
                                myHand = new MyHand();
                                break;
                            }

                        //// help screen
                        case "h":
                            {
                                ShowHelpMenu();
                                hMenu = 1;
                                break;
                            }

                        #region tests_show
                        //// a random shoe + display
                        case "trs":
                            {
                                shoe = new Shoe();
                                myHand = new MyHand();
                                dealerHand = new DealerHand();
                                shoe.GenerateShoe();

                                dealerHand.SetDealerCard(shoe.GetTheXCardFromShoe(shoe.GetNrCardsDrawn() + 1));
                                myHand.SetAddCardInHand(shoe.GetTheXCardFromShoe(shoe.GetNrCardsDrawn() + 2));
                                myHand.SetAddCardInHand(shoe.GetTheXCardFromShoe(shoe.GetNrCardsDrawn() + 3));

                                shoe.SetAddCardToShoeSIM(shoe.GetTheXCardFromShoe(shoe.GetNrCardsDrawn() + 1));
                                shoe.SetAddCardToShoeSIM(shoe.GetTheXCardFromShoe(shoe.GetNrCardsDrawn() + 2));
                                shoe.SetAddCardToShoeSIM(shoe.GetTheXCardFromShoe(shoe.GetNrCardsDrawn() + 3));

                                shoe.SetCardsDrawn(shoe.GetNrCardsDrawn() + 3);

                                break;
                            }

                        //// show the shoe //// 
                        case "tss":
                            {
                                UpdateBoxSuggestionsTestShoe(shoe.GetNrCardsDrawn() + 1);
                                hMenu = 1;
                                break;
                            }

                        //// hit a card //// 
                        case "thc":
                            {
                                myHand.SetAddCardInHand(shoe.GetTheXCardFromShoe(shoe.GetNrCardsDrawn() + 1));
                                shoe.SetCardsDrawn(shoe.GetNrCardsDrawn() + 1);
                                break;
                            }
                        #endregion tests_show

                        //// nothing to do
                        default:
                            {
                                break;
                            }
                    }
                }

                if (hMenu == 0)
                    ShowWhatToDo();
                UpdateBoxCards();
                textBoxInput.Clear();
            }
        }
    }
}
