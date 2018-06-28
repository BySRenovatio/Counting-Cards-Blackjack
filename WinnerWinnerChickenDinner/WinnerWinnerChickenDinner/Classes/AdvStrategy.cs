using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinnerWinnerChickenDinner.Classes
{
    public class AdvStrategy
    {
        public int[,] gotPair;
        public int[,] gotSoft;
        public int[,] gotNormalHand;

        public AdvStrategy()
        {
            gotPair = new int[15, 15];
            gotSoft = new int[25, 15];
            gotNormalHand = new int[35, 15];

            #region gotPair

            /// 0 - STAND ///
            /// 1 - HIT ///
            /// 2 - DOUBLE ///
            /// 3 - SPLIT ///

            /// /// /// /// /// /// ///
            /// /// /// /// /// /// ///
            /// /// /// /// /// /// ///

            for (int i = 0; i <= 14; i++)
                for (int j = 0; j <= 14; j++)
                    gotPair[i, j] = -1;

            gotPair[2, 2] = 3;
            gotPair[2, 3] = 3;
            gotPair[2, 4] = 3;
            gotPair[2, 5] = 3;
            gotPair[2, 6] = 3;
            gotPair[2, 7] = 3;
            gotPair[2, 8] = 1;
            gotPair[2, 9] = 1;
            gotPair[2, 10] = 1;
            gotPair[2, 11] = 1;

            gotPair[3, 2] = 3;
            gotPair[3, 3] = 3;
            gotPair[3, 4] = 3;
            gotPair[3, 5] = 3;
            gotPair[3, 6] = 3;
            gotPair[3, 7] = 3;
            gotPair[3, 8] = 1;
            gotPair[3, 9] = 1;
            gotPair[3, 10] = 1;
            gotPair[3, 11] = 1;

            gotPair[4, 2] = 1;
            gotPair[4, 3] = 1;
            gotPair[4, 4] = 1;
            gotPair[4, 5] = 3;
            gotPair[4, 6] = 3;
            gotPair[4, 7] = 1;
            gotPair[4, 8] = 1;
            gotPair[4, 9] = 1;
            gotPair[4, 10] = 1;
            gotPair[4, 11] = 1;

            gotPair[5, 2] = 2;
            gotPair[5, 3] = 2;
            gotPair[5, 4] = 2;
            gotPair[5, 5] = 2;
            gotPair[5, 6] = 2;
            gotPair[5, 7] = 2;
            gotPair[5, 8] = 2;
            gotPair[5, 9] = 2;
            gotPair[5, 10] = 1;
            gotPair[5, 11] = 1;

            gotPair[6, 2] = 3;
            gotPair[6, 3] = 3;
            gotPair[6, 4] = 3;
            gotPair[6, 5] = 3;
            gotPair[6, 6] = 3;
            gotPair[6, 7] = 1;
            gotPair[6, 8] = 1;
            gotPair[6, 9] = 1;
            gotPair[6, 10] = 1;
            gotPair[6, 11] = 1;

            gotPair[7, 2] = 3;
            gotPair[7, 3] = 3;
            gotPair[7, 4] = 3;
            gotPair[7, 5] = 3;
            gotPair[7, 6] = 3;
            gotPair[7, 7] = 3;
            gotPair[7, 8] = 1;
            gotPair[7, 9] = 1;
            gotPair[7, 10] = 1;
            gotPair[7, 11] = 1;

            gotPair[8, 2] = 3;
            gotPair[8, 3] = 3;
            gotPair[8, 4] = 3;
            gotPair[8, 5] = 3;
            gotPair[8, 6] = 3;
            gotPair[8, 7] = 3;
            gotPair[8, 8] = 3;
            gotPair[8, 9] = 3;
            gotPair[8, 10] = 3;
            gotPair[8, 11] = 3;

            gotPair[9, 2] = 3;
            gotPair[9, 3] = 3;
            gotPair[9, 4] = 3;
            gotPair[9, 5] = 3;
            gotPair[9, 6] = 3;
            gotPair[9, 7] = 0;
            gotPair[9, 8] = 3;
            gotPair[9, 9] = 3;
            gotPair[9, 10] = 0;
            gotPair[9, 11] = 0;

            gotPair[10, 2] = 0;
            gotPair[10, 3] = 0;
            gotPair[10, 4] = 0;
            gotPair[10, 5] = 0;
            gotPair[10, 6] = 0;
            gotPair[10, 7] = 0;
            gotPair[10, 8] = 0;
            gotPair[10, 9] = 0;
            gotPair[10, 10] = 0;
            gotPair[10, 11] = 0;

            gotPair[1, 2] = 3;
            gotPair[1, 3] = 3;
            gotPair[1, 4] = 3;
            gotPair[1, 5] = 3;
            gotPair[1, 6] = 3;
            gotPair[1, 7] = 3;
            gotPair[1, 8] = 3;
            gotPair[1, 9] = 3;
            gotPair[1, 10] = 3;
            gotPair[1, 11] = 3;

            #endregion

            #region gotSoftHand

            /// 0 - STAND ///
            /// 1 - HIT ///
            /// 2 - DOUBLE ///
            /// 3 - SPLIT ///

            /// /// /// /// /// /// ///
            /// /// /// /// /// /// ///
            /// /// /// /// /// /// ///

            for (int i = 0; i <= 24; i++)
                for (int j = 0; j <= 14; j++)
                    gotSoft[i, j] = -1;

            gotSoft[13, 2] = 1;
            gotSoft[13, 3] = 1;
            gotSoft[13, 4] = 1;
            gotSoft[13, 5] = 2;
            gotSoft[13, 6] = 2;
            gotSoft[13, 7] = 1;
            gotSoft[13, 8] = 1;
            gotSoft[13, 9] = 1;
            gotSoft[13, 10] = 1;
            gotSoft[13, 11] = 1;

            gotSoft[14, 2] = 1;
            gotSoft[14, 3] = 1;
            gotSoft[14, 4] = 1;
            gotSoft[14, 5] = 2;
            gotSoft[14, 6] = 2;
            gotSoft[14, 7] = 1;
            gotSoft[14, 8] = 1;
            gotSoft[14, 9] = 1;
            gotSoft[14, 10] = 1;
            gotSoft[14, 11] = 1;

            gotSoft[15, 2] = 1;
            gotSoft[15, 3] = 1;
            gotSoft[15, 4] = 2;
            gotSoft[15, 5] = 2;
            gotSoft[15, 6] = 2;
            gotSoft[15, 7] = 1;
            gotSoft[15, 8] = 1;
            gotSoft[15, 9] = 1;
            gotSoft[15, 10] = 1;
            gotSoft[15, 11] = 1;

            gotSoft[16, 2] = 1;
            gotSoft[16, 3] = 1;
            gotSoft[16, 4] = 2;
            gotSoft[16, 5] = 2;
            gotSoft[16, 6] = 2;
            gotSoft[16, 7] = 1;
            gotSoft[16, 8] = 1;
            gotSoft[16, 9] = 1;
            gotSoft[16, 10] = 1;
            gotSoft[16, 11] = 1;

            gotSoft[17, 2] = 1;
            gotSoft[17, 3] = 2;
            gotSoft[17, 4] = 2;
            gotSoft[17, 5] = 2;
            gotSoft[17, 6] = 2;
            gotSoft[17, 7] = 1;
            gotSoft[17, 8] = 1;
            gotSoft[17, 9] = 1;
            gotSoft[17, 10] = 1;
            gotSoft[17, 11] = 1;

            gotSoft[18, 2] = 0;
            gotSoft[18, 3] = 2;
            gotSoft[18, 4] = 2;
            gotSoft[18, 5] = 2;
            gotSoft[18, 6] = 2;
            gotSoft[18, 7] = 0;
            gotSoft[18, 8] = 0;
            gotSoft[18, 9] = 1;
            gotSoft[18, 10] = 1;
            gotSoft[18, 11] = 1;

            gotSoft[19, 2] = 0;
            gotSoft[19, 3] = 0;
            gotSoft[19, 4] = 0;
            gotSoft[19, 5] = 0;
            gotSoft[19, 6] = 0;
            gotSoft[19, 7] = 0;
            gotSoft[19, 8] = 0;
            gotSoft[19, 9] = 0;
            gotSoft[19, 10] = 0;
            gotSoft[19, 11] = 0;

            gotSoft[20, 2] = 0;
            gotSoft[20, 3] = 0;
            gotSoft[20, 4] = 0;
            gotSoft[20, 5] = 0;
            gotSoft[20, 6] = 0;
            gotSoft[20, 7] = 0;
            gotSoft[20, 8] = 0;
            gotSoft[20, 9] = 0;
            gotSoft[20, 10] = 0;
            gotSoft[20, 11] = 0;

            gotSoft[21, 2] = 0;
            gotSoft[21, 3] = 0;
            gotSoft[21, 4] = 0;
            gotSoft[21, 5] = 0;
            gotSoft[21, 6] = 0;
            gotSoft[21, 7] = 0;
            gotSoft[21, 8] = 0;
            gotSoft[21, 9] = 0;
            gotSoft[21, 10] = 0;
            gotSoft[21, 11] = 0;

            #endregion

            #region gotNormalHand

            /// 0 - STAND ///
            /// 1 - HIT ///
            /// 2 - DOUBLE ///
            /// 3 - SPLIT ///

            /// /// /// /// /// /// ///
            /// /// /// /// /// /// ///
            /// /// /// /// /// /// ///

            for (int i = 0; i <= 34; i++)
                for (int j = 0; j <= 14; j++)
                    gotNormalHand[i, j] = -1;

            gotNormalHand[5, 2] = 1;
            gotNormalHand[5, 3] = 1;
            gotNormalHand[5, 4] = 1;
            gotNormalHand[5, 5] = 1;
            gotNormalHand[5, 6] = 1;
            gotNormalHand[5, 7] = 1;
            gotNormalHand[5, 8] = 1;
            gotNormalHand[5, 9] = 1;
            gotNormalHand[5, 10] = 1;
            gotNormalHand[5, 11] = 1;

            gotNormalHand[6, 2] = 1;
            gotNormalHand[6, 3] = 1;
            gotNormalHand[6, 4] = 1;
            gotNormalHand[6, 5] = 1;
            gotNormalHand[6, 6] = 1;
            gotNormalHand[6, 7] = 1;
            gotNormalHand[6, 8] = 1;
            gotNormalHand[6, 9] = 1;
            gotNormalHand[6, 10] = 1;
            gotNormalHand[6, 11] = 1;

            gotNormalHand[7, 2] = 1;
            gotNormalHand[7, 3] = 1;
            gotNormalHand[7, 4] = 1;
            gotNormalHand[7, 5] = 1;
            gotNormalHand[7, 6] = 1;
            gotNormalHand[7, 7] = 1;
            gotNormalHand[7, 8] = 1;
            gotNormalHand[7, 9] = 1;
            gotNormalHand[7, 10] = 1;
            gotNormalHand[7, 11] = 1;

            gotNormalHand[8, 2] = 1;
            gotNormalHand[8, 3] = 1;
            gotNormalHand[8, 4] = 1;
            gotNormalHand[8, 5] = 1;
            gotNormalHand[8, 6] = 1;
            gotNormalHand[8, 7] = 1;
            gotNormalHand[8, 8] = 1;
            gotNormalHand[8, 9] = 1;
            gotNormalHand[8, 10] = 1;
            gotNormalHand[8, 11] = 1;

            gotNormalHand[9, 2] = 1;
            gotNormalHand[9, 3] = 2;
            gotNormalHand[9, 4] = 2;
            gotNormalHand[9, 5] = 2;
            gotNormalHand[9, 6] = 2;
            gotNormalHand[9, 7] = 1;
            gotNormalHand[9, 8] = 1;
            gotNormalHand[9, 9] = 1;
            gotNormalHand[9, 10] = 1;
            gotNormalHand[9, 11] = 1;

            gotNormalHand[10, 2] = 2;
            gotNormalHand[10, 3] = 2;
            gotNormalHand[10, 4] = 2;
            gotNormalHand[10, 5] = 2;
            gotNormalHand[10, 6] = 2;
            gotNormalHand[10, 7] = 2;
            gotNormalHand[10, 8] = 2;
            gotNormalHand[10, 9] = 2;
            gotNormalHand[10, 10] = 1;
            gotNormalHand[10, 11] = 1;

            gotNormalHand[11, 2] = 2;
            gotNormalHand[11, 3] = 2;
            gotNormalHand[11, 4] = 2;
            gotNormalHand[11, 5] = 2;
            gotNormalHand[11, 6] = 2;
            gotNormalHand[11, 7] = 2;
            gotNormalHand[11, 8] = 2;
            gotNormalHand[11, 9] = 2;
            gotNormalHand[11, 10] = 2;
            gotNormalHand[11, 11] = 1;

            gotNormalHand[12, 2] = 1;
            gotNormalHand[12, 3] = 1;
            gotNormalHand[12, 4] = 0;
            gotNormalHand[12, 5] = 0;
            gotNormalHand[12, 6] = 0;
            gotNormalHand[12, 7] = 1;
            gotNormalHand[12, 8] = 1;
            gotNormalHand[12, 9] = 1;
            gotNormalHand[12, 10] = 1;
            gotNormalHand[12, 11] = 1;

            gotNormalHand[13, 2] = 0;
            gotNormalHand[13, 3] = 0;
            gotNormalHand[13, 4] = 0;
            gotNormalHand[13, 5] = 0;
            gotNormalHand[13, 6] = 0;
            gotNormalHand[13, 7] = 1;
            gotNormalHand[13, 8] = 1;
            gotNormalHand[13, 9] = 1;
            gotNormalHand[13, 10] = 1;
            gotNormalHand[13, 11] = 1;

            gotNormalHand[14, 2] = 0;
            gotNormalHand[14, 3] = 0;
            gotNormalHand[14, 4] = 0;
            gotNormalHand[14, 5] = 0;
            gotNormalHand[14, 6] = 0;
            gotNormalHand[14, 7] = 1;
            gotNormalHand[14, 8] = 1;
            gotNormalHand[14, 9] = 1;
            gotNormalHand[14, 10] = 1;
            gotNormalHand[14, 11] = 1;

            gotNormalHand[15, 2] = 0;
            gotNormalHand[15, 3] = 0;
            gotNormalHand[15, 4] = 0;
            gotNormalHand[15, 5] = 0;
            gotNormalHand[15, 6] = 0;
            gotNormalHand[15, 7] = 1;
            gotNormalHand[15, 8] = 1;
            gotNormalHand[15, 9] = 1;
            gotNormalHand[15, 10] = 1;
            gotNormalHand[15, 11] = 1;

            gotNormalHand[16, 2] = 0;
            gotNormalHand[16, 3] = 0;
            gotNormalHand[16, 4] = 0;
            gotNormalHand[16, 5] = 0;
            gotNormalHand[16, 6] = 0;
            gotNormalHand[16, 7] = 1;
            gotNormalHand[16, 8] = 1;
            gotNormalHand[16, 9] = 1;
            gotNormalHand[16, 10] = 1;
            gotNormalHand[16, 11] = 1;

            gotNormalHand[17, 2] = 0;
            gotNormalHand[17, 3] = 0;
            gotNormalHand[17, 4] = 0;
            gotNormalHand[17, 5] = 0;
            gotNormalHand[17, 6] = 0;
            gotNormalHand[17, 7] = 0;
            gotNormalHand[17, 8] = 0;
            gotNormalHand[17, 9] = 0;
            gotNormalHand[17, 10] = 0;
            gotNormalHand[17, 11] = 0;

            gotNormalHand[18, 2] = 0;
            gotNormalHand[18, 3] = 0;
            gotNormalHand[18, 4] = 0;
            gotNormalHand[18, 5] = 0;
            gotNormalHand[18, 6] = 0;
            gotNormalHand[18, 7] = 0;
            gotNormalHand[18, 8] = 0;
            gotNormalHand[18, 9] = 0;
            gotNormalHand[18, 10] = 0;
            gotNormalHand[18, 11] = 0;

            gotNormalHand[19, 2] = 0;
            gotNormalHand[19, 3] = 0;
            gotNormalHand[19, 4] = 0;
            gotNormalHand[19, 5] = 0;
            gotNormalHand[19, 6] = 0;
            gotNormalHand[19, 7] = 0;
            gotNormalHand[19, 8] = 0;
            gotNormalHand[19, 9] = 0;
            gotNormalHand[19, 10] = 0;
            gotNormalHand[19, 11] = 0;

            gotNormalHand[20, 2] = 0;
            gotNormalHand[20, 3] = 0;
            gotNormalHand[20, 4] = 0;
            gotNormalHand[20, 5] = 0;
            gotNormalHand[20, 6] = 0;
            gotNormalHand[20, 7] = 0;
            gotNormalHand[20, 8] = 0;
            gotNormalHand[20, 9] = 0;
            gotNormalHand[20, 10] = 0;
            gotNormalHand[20, 11] = 0;

            gotNormalHand[21, 2] = 0;
            gotNormalHand[21, 3] = 0;
            gotNormalHand[21, 4] = 0;
            gotNormalHand[21, 5] = 0;
            gotNormalHand[21, 6] = 0;
            gotNormalHand[21, 7] = 0;
            gotNormalHand[21, 8] = 0;
            gotNormalHand[21, 9] = 0;
            gotNormalHand[21, 10] = 0;
            gotNormalHand[21, 11] = 0;

            #endregion
        }

        public string ReturnAdvice(int value)
        {
            if (value == 0)
                return "STAND";
            else
                if (value == 1)
                return "HIT";
            else
                if (value == 2)
                return "DOUBLE";
            else
                if (value == 3)
                return "SPLIT";
            else
                return "ERROR - not 0, 1, 2, 3 type ";
        }

        public string ReturnPairAdvice(int mysum, int dealcard)
        {
            return ReturnAdvice(gotPair[mysum, dealcard]);
        }

        public string ReturnSoftAdvice(int mysum, int dealcard)
        {
            return ReturnAdvice(gotSoft[mysum, dealcard]);
        }

        public string ReturnNormalAdvice(int mysum, int dealcard)
        {
            return ReturnAdvice(gotNormalHand[mysum, dealcard]);
        }
    }
}
