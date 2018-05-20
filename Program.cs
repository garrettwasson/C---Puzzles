using System;
using System.Collections.Generic;

namespace Puzzles
{
    class Program
    {

        public static void Main(string[] args)
        {
            RandomArray();
            CoinFlip();
            MultipleCoinFlip(5);
            Names();
        }
        public static int[] RandomArray(){
            int[] arr = new int[10];
            Random rand = new Random();
            for (int idx = 0; idx < arr.Length; idx++){
                arr[idx] = rand.Next(5, 26);
            }
            int min = arr[0];
            int max = arr[0];
            int sum = 0;
            foreach (int num in arr){
                sum += num;
                if (num < min){
                    min = num;
                }
                else if (num > max){
                    max = num;
                }
            }
            Console.WriteLine("Min: {0}, Max: {1}, Sum: {2}", min, max, sum);
            return arr;
        }

        public static string CoinFlip(){
            Console.WriteLine("Flipping the coin...!");
            Random rand = new Random();
            int outcome = rand.Next(0,2);
            string result;
            if (outcome == 0){
                result = "Tails";
            }
            else {
                result = "Heads";
            }
            Console.WriteLine(result);
            return result;
        }

        public static double MultipleCoinFlip(int num = 1){
            if (num < 1){
                throw new ArgumentOutOfRangeException("num", "'Num' must be greater than or equal to 1!");
            }
            int Heads = 0;
            int Total = 0;
            for (int i = 1; i <= num; i++){
                Total += 1;
                string result = CoinFlip();
                if (result == "Heads"){
                    Heads += 1;
                }
            }
            double ratio = (double)Heads /  (double)Total;
            Console.WriteLine($"The ratio of HEADS to total tosses is: {ratio}");
            return ratio;
        }
        public static string[] Names(){
            string[] nameArr = new string[5] {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
            Random rand = new Random();
            for(int idx = 0; idx < nameArr.Length-1; idx++){
               int idxRan = rand.Next(idx+1, nameArr.Length - 1);
               string temp = nameArr[idx];
               nameArr[idx] = nameArr[idxRan];
               nameArr[idxRan] = temp;
               Console.WriteLine(nameArr[idx]);
            }
            Console.WriteLine(nameArr[nameArr.Length-1]);
            List<string> nameList = new List<string>();
                foreach (string name in nameArr){
                    nameList.Add(name);
                }
            return nameList.ToArray();

        }
    }
}
