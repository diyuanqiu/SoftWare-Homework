using System;
namespace Eratosthenes{
    class EratosthenesTheme{
        static void Main(string[] args){
            bool[] num = new bool[101];
            for (int i = 0; i < 101;i++){
                num[i] = true;
            }
            screenNum(num);
            for (int i = 2; i < 101;i++){
                if(num[i]==true){
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
        public static void screenNum(bool[] data){
            for (int i = 2; i < 101;i++){
                if(data[i]==true){
                    for (int j = 2; i * j < 101;j++){
                        data[i * j] = false;
                    }
                }
            }
        }
    }
}