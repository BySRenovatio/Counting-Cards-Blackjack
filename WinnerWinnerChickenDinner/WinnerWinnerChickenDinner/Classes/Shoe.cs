using System;

namespace WinnerWinnerChickenDinner.Classes
{
    public class Shoe
    {
        public int nrCardsInShoe;
        public int nrCardsDrawn;
        public int[] shoeCards;
        public int[] valueShoeCards;

        public Shoe()
        {
            nrCardsInShoe = 8 * 52;
            nrCardsDrawn = 0;
            shoeCards = new int[8 * 52 + 3];
            valueShoeCards = new int[14 + 3];
        }

        public void SetAddCardToShoe(int value)
        {
            nrCardsDrawn += 1;
            shoeCards[nrCardsDrawn] = value;
            valueShoeCards[value] += 1;
        }

        public void SetAddCardToShoeSIM(int value)
        {
            valueShoeCards[value] += 1;
        }

        public void SetDelCardFromShoe(int value)
        {
            /// save last card to replace the one shearched for
            int saveValue = shoeCards[nrCardsDrawn];

            for(int i=nrCardsDrawn; i>0; i--)
                if(shoeCards[i] == value)
                {
                    shoeCards[i] = saveValue;
                    nrCardsDrawn -= 1;
                    valueShoeCards[value] -= 1;
                    return;
                }
        }
        public int GetTheXCardFromShoe(int value)
        {
            return shoeCards[value];
        }

        public float GetCardsDrawnProcent()
        {
            return ((nrCardsDrawn * 100) / nrCardsInShoe);
        }

        public int GetNrCardsLeft()
        {
            return (nrCardsInShoe - nrCardsDrawn);
        }

        public int GetNrCardsDrawn()
        {
            return nrCardsDrawn;
        }

        public void SetCardsDrawn(int value)
        {
            nrCardsDrawn = value;
        }

        public int GetNrXDrawnCards(int value)
        {
            return valueShoeCards[value];
        }

        public string GetSNrXDrawnCards(int value)
        {
            if (valueShoeCards[value] < 10)
                return '0' + (valueShoeCards[value]).ToString();
            else
                return (valueShoeCards[value]).ToString();
        }

        public int GetNrXDrawnCardsLeft(int value)
        {
            return (8 * 4 - valueShoeCards[value]);
        }

        public string GetSNrXDrawnCardsLeft(int value)
        {
            if ((8 * 4 - valueShoeCards[value]) < 10)
                return '0' + (8 * 4 - valueShoeCards[value]).ToString();
            else
                return (8 * 4 - valueShoeCards[value]).ToString();
        }

        public string ConvertNrToSym(int value)
        {
            if (value == 11)
                return "A";
            else
                if (value == 12)
                return "J";
            else
                if (value == 13)
                return "Q";
            else
                if (value == 14)
                return "K";
            else
                return Convert.ToString(value);
        }

        public void GenerateShoe()
        { 
            Random r = new Random(DateTime.Now.Millisecond);
            int randy, randx, aux;

            while(nrCardsDrawn < 8*52)
            {
                randy = r.Next(2, 15);

                if(valueShoeCards[randy] < 32)
                {
                    nrCardsDrawn += 1;
                    shoeCards[nrCardsDrawn] = randy;
                }
            }

            for(int j = 1; j <= 8*52; j++)
                for(int i = 1; i <= 8*52; i++)
                {
                    randx = (2 * i) % 416 + 1;
                    randy = (3 * j) % 416 + 1;

                    aux = shoeCards[randx];
                    shoeCards[randx] = shoeCards[randy];
                    shoeCards[randy] = aux;
                }

            randy = r.Next(3 * 52, 5 * 52);
            nrCardsDrawn = randy;

            for(int i = 1; i <= randy; i++)
                valueShoeCards[shoeCards[i]] += 1;
        }

        public int GetFavCards(int value)
        {
            int favCards = 0;

            for(int i = 2; i <= 10; i++)
            {
                if (value + i <= 21)
                    favCards += GetNrXDrawnCardsLeft(i);
            }

            for (int i = 12; i <= 14; i++)
            {
                if (value + 10 <= 21)
                    favCards += GetNrXDrawnCardsLeft(i);
            }

            if ((value + 1 <= 21) || (value + 11 <= 21))
                favCards += GetNrXDrawnCardsLeft(11);

            return favCards;
        }

        public double GetTrueCount()
        {
            int thecount = 0;
            int hdecksrem = 0;

            for(int i = 2; i <= 6; i++)
            {
                thecount += GetNrXDrawnCards(i);
            }

            for (int i = 10; i <= 14; i++)
            {
                thecount -= GetNrXDrawnCards(i);
            }

            hdecksrem = GetNrCardsLeft() / 26;

            return thecount * 1.0 / hdecksrem;
        }

        public double GetBetterChances(int mySum, int dCard)
        {
            int[] vVect = new int[52 * 8 + 3];
            int cursor = 0;
            int pos = 0;
            int tot = 0;
            MyHand newhand;

            for(int i = 2; i <= 14; i++)
                for(int j = 1; j <= GetNrXDrawnCardsLeft(i); j++)
                {
                    cursor++;
                    vVect[cursor] = i;
                }

            for(int i = 1; i <= cursor - 1; i++)
                for(int j = i; j <= cursor; j++)
                {
                    newhand = new MyHand();

                    newhand.SetAddCardInHand(dCard);
                    newhand.SetAddCardInHand(vVect[i]);

                    if (i != j)
                        newhand.SetAddCardInHand(vVect[j]);

                    newhand.GetTheSumOfCardsInHand(out int sum1, out int sum2);

                    if ((mySum < sum1) && (sum1 <= 21))
                        pos++;

                    if ((mySum < sum2) && (sum2 <= 21) && (sum1 != sum2))
                        pos++;

                    tot++;
                }

            return (pos * 100.0 / tot);
        }
    }
}
