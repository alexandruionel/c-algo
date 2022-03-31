﻿using System;

namespace MoveFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = ReadValuesList();
            int[] positionsToMove = ReadPositions();

            for (int i = 0; i < positionsToMove.Length; i++)
                MoveFirst(values, positionsToMove[i]);

            PrintValuesList(values);
            Console.WriteLine(CheckIfSortedAscending(values));
            Console.Read();
        }

        static bool CheckIfSortedAscending(int[] values)
        {
            // to do: remove the line below and implement this function
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i - 1] > values[i])
                {
                    return false;
                }
            }
            return true;
        }
   

        static void MoveFirst(int[] values, int index)
        {
            // to do: remove the line below and implement this function
            int temp = values[index];
            for (int i = index; i > 0; i--)
                values[i] = values[i - 1];
            values[0] = temp;
        }

        static int[] ReadPositions()
        {
            int positionsNumber = Convert.ToInt32(Console.ReadLine());
            int[] positions = new int[positionsNumber];

            for (int i = 0; i < positionsNumber; i++)
                positions[i] = Convert.ToInt32(Console.ReadLine());

            return positions;
        }

        static int[] ReadValuesList()
        {
            string[] inputValues = Console.ReadLine().Split(' ');
            int[] values = new int[inputValues.Length];

            for (int i = 0; i < values.Length; i++)
                values[i] = Convert.ToInt32(inputValues[i]);

            return values;
        }

        static void PrintValuesList(int[] valuesList)
        {
            for (int i = 0; i < valuesList.Length; i++)
                Console.Write(valuesList[i] + " ");
            Console.Write('\n');
        }

    }
}

