using System;
using System.Linq;

namespace ConsoleApp
{
    public class Problem1
    {
        private string s;
        private char c;
        private int[] result;

        public Problem1(string s, char c)
        {
            this.s = s;
            this.c = c;
        }

        public void Solve()
        {
            char[] charArr = s.ToArray();
            result = new int[charArr.Length];
            int lastFoundIndex = -1;
            for (int i = 0; i < charArr.Length; i++)
            {
                result[i] = 0;
                if (charArr[i].Equals(c))
                {
                    if (i - lastFoundIndex > 1)//skip the connected indexes
                    {
                        if (lastFoundIndex == -1)
                        {
                            for (int j = i - 1; j >= 0; j--)
                            {
                                result[j] = i - j;
                            }
                        }
                        else
                        {
                            int mid = lastFoundIndex + (i - lastFoundIndex) / 2;
                            for (int j = mid; j > lastFoundIndex; j--)
                            {
                                result[j] = j - lastFoundIndex;
                            }
                            for (int j = mid + 1; j < i; j++)
                            {
                                result[j] = i - j;
                            }
                        }
                    }
                    lastFoundIndex = i;
                }
                else if (i == charArr.Length - 1)
                {
                    for (int j = i; j > lastFoundIndex; j--)
                    {
                        result[j] = j - lastFoundIndex;
                    }
                }
            }
        }

        public void PrintResult()
        {
            string strToPrint = "[";
            for (int i = 0; i < result.Length; i++)
            {
                strToPrint += result[i].ToString() + (i == result.Length - 1 ? "" : ",");
            }
            strToPrint += "]";
            Console.Write(strToPrint);
        }
    }
}
