using System;

namespace HelloWorldCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] input =  new int[] {41,5,6,7,8,1,20,10};
            string inputStr = string.Empty;
            foreach(int i in input){
                inputStr += i.ToString() + ",";
            }
            int[] sorted = Sort(input);
            string sortedStr = string.Empty;
            foreach(int i in sorted){
                sortedStr += i.ToString() + ",";
            }
            Console.WriteLine(inputStr);
            Console.WriteLine(sortedStr);
        }

        public static int[] Sort(int[] array){
            for (int i=0; i<array.Length; i++){
                int cur = array[i];
                int j = i-1;
                while (j>=0 && array[j] > cur){
                    array[j+1] = array[j];
                    j--;
                }
                array[j+1]=cur;
            }
            return array;
        }
    }
}
