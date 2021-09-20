using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExercise_09_20_2021
{
    class Game
    {
        bool gameOver = false;

        int[] arrayInt;


        int endNumber;
        private void Start()
        {
            arrayInt = new int[] { 1, 2, 3, 4, 5 };

            endNumber = 10;

        }
        private void Update()
        {
            arrayInt = AppendToArray(arrayInt, endNumber);


            Console.ReadKey();
            gameOver = true;

        }
        private void End()
        {
            for(int i = 0; i < arrayInt.Length; i++)
                Console.WriteLine(arrayInt[i]);
            Console.ReadKey();
        }

        private int[] AppendToArray(int[] arr, int num)
        {
            int totalSize = arr.Length ;
            int[] answer = new int[totalSize + 1 ];


            for (int i = 0; i < arr.Length; i++)
                answer[i] = arr[i];
            answer[totalSize] = num;

            return answer;

        }
        public void Run()
        {
            Start();

            while (!gameOver)
                Update();

            End();
        }
    }
}
