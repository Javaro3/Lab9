using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{

    public class OperationsOnArrays
    {
        public double[] Array;

        public OperationsOnArrays()
        {
            Array = new double[] { };
        }
        public OperationsOnArrays(double[] array)
        {
            Array = array;
        }

        public static OperationsOnArrays operator +(OperationsOnArrays array1, OperationsOnArrays array2)
        {
            OperationsOnArrays tmp = new OperationsOnArrays(new double[] { });
            int kol = 0;
            tmp.Array = new double[array1.Array.Length + array2.Array.Length];
            for (int i = 0; i < array2.Array.Length; i++, kol++)
            {
                tmp.Array[kol] = array2.Array[i];
            }
            for (int i = 0; i < array1.Array.Length; i++, kol++)
            {
                tmp.Array[kol] = array1.Array[i];
            }
            return tmp;
        }

        public static OperationsOnArrays operator *(OperationsOnArrays array, double num)
        {
            for (int i = 0; i < array.Array.Length; i++)
            {
                array.Array[i] *= num;
            }
            return array;
        }

        public static OperationsOnArrays operator /(OperationsOnArrays array, double num)
        {
            if (num != 0)
            {
                for (int i = 0; i < array.Array.Length; i++)
                {
                    array.Array[i] /= num;
                }
            }
            return array;
        }
    }
}
