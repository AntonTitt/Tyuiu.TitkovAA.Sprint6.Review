using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.TitkovAA.Sprint6.Review.V23.Lib
{
    public class DataService : ISprint6Task7V23
    {
        public int[,] GetMatrix(string path)
        {
            throw new NotImplementedException();
        }
        public int GetMatrix(int[,] array, int n1, int n2, int c, int k, int l)
        {
            int n = array.GetLength(0);
            int m = array.Length / n;
            

            if (n <= 1 || m <= 1 || n1 >= n2 || k >= l || c >= n)//|| c < n --неворкает(((
            {
                return 0;
            }


            int cunt = 1;

            for (int i = k; i <= l; i++)
            {
                if (i % 2 == 0)
                {
                    cunt *= array[c, i];
                }
            }



            return cunt;
        }

    }
}
