using System;

namespace Lakes
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            char[] inputCharArr = s.ToCharArray();
            int inputLenght = inputCharArr.Length;
            double[] reverseAttitudes = new double[inputLenght + 1];
            double[] midVolumes = new double[inputLenght];
            double numberOfSquares = 0;
            double volumePerSquare = 1000;
            double totalVolume;

            for (int i = 0; i < inputLenght; i++)
            {
                if (inputCharArr[i] == 'd')
                {
                    reverseAttitudes[i+1] = reverseAttitudes[i] + 1;
                }
                if (inputCharArr[i] == 'h')
                {
                    reverseAttitudes[i+1] = reverseAttitudes[i];
                }
                if (inputCharArr[i] == 'u')
                {
                    reverseAttitudes[i+1] = reverseAttitudes[i] - 1;
                }
            }

            for (int i = 0; i < reverseAttitudes.Length; i++)
            {
                if (reverseAttitudes[i] < 0)
                {
                    reverseAttitudes[i] = 0;
                }
            }

            for (int i = 0; i < midVolumes.Length; i++)
            {
                midVolumes[i] = (reverseAttitudes[i + 1] + reverseAttitudes[i]) / 2;
                numberOfSquares = numberOfSquares + midVolumes[i];
            }

            totalVolume = numberOfSquares * volumePerSquare;

            Console.WriteLine(totalVolume);
            Console.ReadKey();

        }
    }
}
