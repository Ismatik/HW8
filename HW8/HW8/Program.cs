using System;

namespace HW8Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            // var arr1 = new string[] {"One" , "Two" , "Three"};
            // var arr1 = new string[] {"One"};
            // var arr1 = new string[] {};
            // string poped = ArrayHelper.Pop(ref arr1);
            // System.Console.WriteLine($"Deleted element is {poped}");            
            // var arr1 = new int[] {1,2,3};
            // var arr1 = new int[] {1};
            // var arr1 = new int[] {};
            // var arr1 = new double[] {1.0 , 2.1};
            // var arr1 = new double[] {};
            // var arr1 = new float[] {1f};
            // var arr1 = new float[] {};
            // string poped = ArrayHelper.Pop(ref arr1);
            // int poped = ArrayHelper.Pop(ref arr1);
            // double poped = ArrayHelper.Pop(ref arr1);
            // float poped = ArrayHelper.Pop(ref arr1);
            // Console.WriteLine($"Poped element is {poped}");
            // var arr1 = new string[] {"One" , "Two"};
            // var element = "Three";
            // var arr1 = new int[] {1,2,3};
            // var element = 4;
            // ArrayHelper.Push(ref arr1, element);
            // var arr1 = new string[] {"One"};
            // var arr1 = new string[] {};
            // var shifted = ArrayHelper.Shift(ref arr1);
            // var arr1 = new int[] {1 , 2 , 3};
            // var arr1 = new int[] {};
            // var shifted = ArrayHelper.Shift(ref arr1);
            // System.Console.WriteLine($"Deleted element is {shifted}");
            // var arr1 = new string[] {"Two"};
            // ArrayHelper.UnShift(ref arr1 , "One");
            // var arr1 = new string[] {};
            // ArrayHelper.UnShift(ref arr1 , "One");
            Console.Write("New array is [");
            for (int i = 0; i < arr1.Length; i++)
            {
                System.Console.Write(" " + arr1[i] + " ");
            }
            Console.Write("]");
        }
    }

    class ArrayHelper
    {

//      Pop Part starts -------------------------------------------------------------------------------------------------------
        public static string Pop(ref string[] arr)
        {   
            int size = arr.Length;
            string k = "emptiness";
            if(size == 0)
            {
                System.Console.WriteLine("Nothing to pop. Message we poped element is 0 or emptiness means empty array");
                return k;
            }
            else if(arr.Length >= 1)
            {  
                k = arr[arr.Length - 1];
            }
            var newarr = new string[size - 1];
            for (int i = 0; i < newarr.Length; i++)
            {
                newarr[i] = arr[i];
            }

            arr = newarr;
            
            return k;
        }

        public static int Pop(ref int[] arr)
        {   
            int size = arr.Length;
            int k = -1;
            if(size == 0)
            {
                System.Console.WriteLine("Nothing to pop. Message we poped element is 0 means empty array");
                return k;
            }
            else if(arr.Length >= 1)
            {  
                k = arr[arr.Length - 1];
            }
            var newarr = new int[size - 1];
            for (int i = 0; i < newarr.Length; i++)
            {
                newarr[i] = arr[i];
            }

            arr = newarr;
            
            return k;
        }

        public static double Pop(ref double[] arr)
        {   
            int size = arr.Length;
            double k = 0;
            if(size == 0)
            {
                System.Console.WriteLine("Nothing to pop. Message we poped element is 0 means empty array");
                return k;
            }
            else if(arr.Length >= 1)
            {  
                k = arr[arr.Length - 1];
            }
            var newarr = new double[size - 1];
            for (int i = 0; i < newarr.Length; i++)
            {
                newarr[i] = arr[i];
            }

            arr = newarr;
            
            return k;
        }

        public static float Pop(ref float[] arr)
        {   
            int size = arr.Length;
            float k = 0;
            if(size == 0)
            {
                System.Console.WriteLine("Nothing to pop. Message we poped element is 0 means empty array");
                return k;
            }
            else if(arr.Length >= 1)
            {  
                k = arr[arr.Length - 1];
            }
            var newarr = new float[size - 1];
            for (int i = 0; i < newarr.Length; i++)
            {
                newarr[i] = arr[i];
            }

            arr = newarr;
            
            return k;
        }
// --------------------------------------------Pop part finished

        public static void Push(ref string[] arr , string element)
        {
            int size = arr.Length;
            var newarr = new string[size + 1]; 
            for (int i = 0; i < size; i++)
            {
                newarr[i] = arr[i];
            }
            newarr[size] = element;
            arr = newarr;
        }

        public static void Push(ref int[] arr , int element)
        {
            int size = arr.Length;
            var newarr = new int[size + 1]; 
            for (int i = 0; i < size; i++)
            {
                newarr[i] = arr[i];
            }
            newarr[size] = element;
            arr = newarr;
        }

        public static void Push(ref double[] arr , double element)
        {
            int size = arr.Length;
            var newarr = new double[size + 1]; 
            for (int i = 0; i < size; i++)
            {
                newarr[i] = arr[i];
            }
            newarr[size] = element;
            arr = newarr;
        }

        public static void Push(ref float[] arr , float element)
        {
            int size = arr.Length;
            var newarr = new float[size + 1]; 
            for (int i = 0; i < size; i++)
            {
                newarr[i] = arr[i];
            }
            newarr[size] = element;
            arr = newarr;
        }
// -------------------------------Push part finished

        public static string Shift(ref string[] arr)
        {
            string k = "emptiness";
            int size = arr.Length;
            if(size > 0)
            {
                k = arr[0];
                var newarr = new string[size - 1];
                for (int i = 0; i < size - 1; i++)
                {
                    newarr[i] = arr[i+1];
                }
                arr = newarr;
            }
            return k;
        }

        public static int Shift(ref int[] arr)
        {
            int k = 0;
            int size = arr.Length;
            if(size > 0)
            {
                k = arr[0];
                var newarr = new int[size - 1];
                for (int i = 0; i < size - 1; i++)
                {
                    newarr[i] = arr[i+1];
                }
                arr = newarr;
            }
            return k;
        }

        public static double Shift(ref double[] arr)
        {
            double k = 0;
            int size = arr.Length;
            if(size > 0)
            {
                k = arr[0];
                var newarr = new double[size - 1];
                for (int i = 0; i < size - 1; i++)
                {
                    newarr[i] = arr[i+1];
                }
                arr = newarr;
            }
            return k;
        }

        public static float Shift(ref float[] arr)
        {
            float k = 0;
            int size = arr.Length;
            if(size > 0)
            {
                k = arr[0];
                var newarr = new float[size - 1];
                for (int i = 0; i < size - 1; i++)
                {
                    newarr[i] = arr[i+1];
                }
                arr = newarr;
            }
            return k;
        }
//           Shift part finished --------------------------------------------------------------
        public static void UnShift(ref string[] arr, string element)
        {
            int size = arr.Length;
            if(size > 0)
            {
                var newarr = new string[size + 1];
                newarr[0] = element;
                for (int i = 0; i < size; i++)
                {
                    newarr[i+1] = arr[i];
                }
                arr = newarr;
            }
            else{
                var newarr1 = new string[1];
                newarr1[0] = element;
                arr = newarr1;
            }
        }

        public static void UnShift(ref int[] arr, int element)
        {
            int size = arr.Length;
            if(size > 0)
            {
                var newarr = new int[size + 1];
                newarr[0] = element;
                for (int i = 0; i < size; i++)
                {
                    newarr[i+1] = arr[i];
                }
                arr = newarr;
            }
            else{
                var newarr1 = new int[1];
                newarr1[0] = element;
                arr = newarr1;
            }
        }

        public static void UnShift(ref double[] arr, double element)
        {
            int size = arr.Length;
            if(size > 0)
            {
                var newarr = new double[size + 1];
                newarr[0] = element;
                for (int i = 0; i < size; i++)
                {
                    newarr[i+1] = arr[i];
                }
                arr = newarr;
            }
            else{
                var newarr1 = new double[1];
                newarr1[0] = element;
                arr = newarr1;
            }
        }

        public static void UnShift(ref float[] arr, float element)
        {
            int size = arr.Length;
            if(size > 0)
            {
                var newarr = new float[size + 1];
                newarr[0] = element;
                for (int i = 0; i < size; i++)
                {
                    newarr[i+1] = arr[i];
                }
                arr = newarr;
            }
            else{
                var newarr1 = new float[1];
                newarr1[0] = element;
                arr = newarr1;
            }
        }
//      Unshift is finished ----------------------
    }
}
