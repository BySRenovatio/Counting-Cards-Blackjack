namespace WinnerWinnerChickenDinner.Classes
{
    public class MyHand
    {
        public int nrCardsInHand;
        public int[] cardsInHand;
        public int[] valueCardsInHand;

        public MyHand()
        {
            nrCardsInHand = 0;
            cardsInHand = new int[26 + 3];
            valueCardsInHand = new int[14 + 3];
        }

        public void SetAddCardInHand(int value)
        {
            nrCardsInHand += 1;
            cardsInHand[nrCardsInHand] = value;
            valueCardsInHand[value] += 1;
        }

        public void SetDelCardInHand(int value)
        {
            /// save last card to replace the one shearched for
            int saveValue = cardsInHand[nrCardsInHand];

            for (int i = nrCardsInHand; i > 0; i--)
                if (cardsInHand[i] == value)
                {
                    cardsInHand[i] = saveValue;
                    nrCardsInHand -= 1;
                    valueCardsInHand[value] -= 1;
                    return;
                }
        }

        public int GetNrCardsInHand()
        {
            return nrCardsInHand;
        }

        public int GetTheXCardInHand(int value)
        {
            return cardsInHand[value];
        }

        public int GetTheNrOfXCardInHand(int value)
        {
            return valueCardsInHand[value];
        }

        public int GotPair()
        {
            if (nrCardsInHand != 2)
                return 0;

            for (int i = 2; i <= 14; i++)
                if (valueCardsInHand[i] == 2)
                    return 1;

            return 0;
        }

        public int GotSoft()
        {
            GetTheSumOfCardsInHand(out int sum1, out int sum2);

            if (sum1 != sum2)
                return 1;
            else
                return 0;
        }

        public int GotNormal()
        {
            GetTheSumOfCardsInHand(out int sum1, out int sum2);

            if (sum1 == sum2)
                return 1;
            else
                return 0;
        }

        public void GetTheSumOfCardsInHand(out int sum1, out int sum2)
        {
            int sum = 0;
            int curCard;
            int howMany11 = valueCardsInHand[11];

            for (int i=1; i<=nrCardsInHand; i++)
            {
                curCard = cardsInHand[i];
                if (curCard > 11)
                    curCard = 10;
                if (curCard == 11)
                    curCard = 1;
                sum += curCard;
            }

            if ((howMany11 > 0) && (sum + 10 <= 21))
            {
                sum1 = sum;
                sum2 = sum + 10;
            }
            else
            {
                sum1 = sum;
                sum2 = sum;
            }
        }
    }
}
