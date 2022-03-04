using System;
using System.Collections;
namespace testClass{
    class Array{
        static void Main(string[] args){
            int displayNumber = 0;
            int[] cArray = { 2, 3, 5, 6, 7, 8, 1 };
            getMax(cArray,ref displayNumber);
            Console.WriteLine("The maximum of the array is {0}.",displayNumber);
            getMin(cArray, ref displayNumber);
            Console.WriteLine("The minimum of the array is {0}.",displayNumber);
            getAve(cArray, ref displayNumber);
            Console.WriteLine("The average of the array is {0}.",displayNumber);
            getSum(cArray, ref displayNumber);
            Console.WriteLine("The sum of the array is {0}", displayNumber);
            Console.ReadKey();
        }
        public static void getMax(int[] array,ref int max){
            int temp = array[0];
            for (int i = 0; i < array.Length;i++){
                if(array[i]>temp){
                    temp = array[i];
                }
                max = temp;
            }
        }
        public static void getMin(int[] array,ref int min){
            int temp = array[0];
            for (int i = 0; i < array.Length;i++){
                if(array[i]<temp){
                    temp = array[i];
                }
                min = temp;
            }
        }
        public static void getAve(int[] array,ref int average){
            int sum = 0;
            for (int i = 0; i < array.Length;i++){
                sum += array[i];
            }
            average = sum / array.Length;
        }
        public static void getSum(int[] array,ref int sum){
            int sum1 = 0;
            for (int i = 0; i < array.Length;i++){
                sum1 += array[i];
            }
            sum = sum1;
        }
    }
}
