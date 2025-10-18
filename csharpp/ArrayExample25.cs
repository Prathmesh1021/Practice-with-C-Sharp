using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class ArrayExample25
    {
                
        
            static bool findSize(int[] arr, int x,
            int k, int n)
            {
                int i;
                for (i = 0; i < n; i = i + k)
                {


                    int j;
                    for (j = 0; j < k; j++)
                        if (arr[i + j] == x)
                            break;


                    if (j == k)
                        return false;
                }


                if (i == n)
                    return true;


                int l;
                for (l = i - k; l < n; l++)
                    if (arr[l] == x)
                        break;
                if (l == n)
                    return false;

                return true;
            }


            public static void Main()
            {
                int[] arr = new int[] {3, 5, 2, 4, 9, 3,
1, 7, 3, 11, 12, 3};
                int x = 3, k = 3;
                int n = arr.Length;
                if (findSize(arr, x, k, n))
                    Console.Write("Yes");
                else
                    Console.Write("No");
            }
        }
    }

