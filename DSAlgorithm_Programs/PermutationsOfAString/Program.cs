using System.Runtime.InteropServices;

namespace PermutationsOfAString
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] a = { 1, 2, 3 };
            printPermutation(a, 0);
        }

        public static void printArray(int[] a)
        {
            Console.WriteLine("");
            for(int i=0;i<a.Length;i++)
            {
                Console.Write(a[i]+" ");
            }
        }

        public static void swap(int[] a,int i,int j) 
        {
            int temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }
        public static void printPermutation(int[] a ,int cid)
        {
            if(cid==a.Length)
            {
                printArray(a);
                return;
            }
            for(int i=cid;i<a.Length; i++)
            {
                swap(a, i, cid);
                printPermutation(a, cid+1);
                swap(a, i, cid);
            }
        }
    }
}