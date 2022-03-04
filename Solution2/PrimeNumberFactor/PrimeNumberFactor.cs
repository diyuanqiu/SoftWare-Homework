using System;
using System.Collections;
namespace testClass{
    class PrimeNumberFactor{
        static void Main(string[] args){
            Console.WriteLine("Please input the data you want to get the prime number factors:");
            int num = int.Parse(Console.ReadLine());
            ArrayList factor = new ArrayList();
            calculate(num,factor);
            foreach(int fac in factor){
                Console.WriteLine(fac);
            }
            Console.ReadKey();
        }
        public static void calculate(int data,ArrayList box){
            for (int i = 2; i <= data;i++){
                if(data%i==0){
                    data = data / i;
                    box.Add(i);
                    i = 2;
                }
                else
                    i++;
            }
        }
    }
}
