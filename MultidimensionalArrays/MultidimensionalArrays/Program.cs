namespace MultidimensionalArrays
{
    internal class Program
    {
        static void Main()
        {
            // transform bidimensional array into a list of list that can be modified
            // print the result to the terminal
            static List<List<int>> ConvertArrayToList(int[,] array)
            {
                Console.WriteLine("Tableau uniforme :");
                var listOfList = new List<List<int>>();

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    listOfList.Add(new List<int>());
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        listOfList[i].Add(array[i, j]);
                        Console.Write(array[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                return listOfList;
            }

            // fill the jagged array with the list obtained from the regular array
            static int[][] fillArray(List<List<int>> originalList)
            {
                var outputArray = new int[originalList.Count()][];
                var nestedListLength = originalList[0].Count();

                for (int i = 0; i < nestedListLength; i++)
                {
                    outputArray[i] = originalList[i].TakeLast(nestedListLength - i).ToArray();
                }

                return outputArray;
            }

            // display jagged array
            static void DisplayArray(int[][] arr)
            {
                Console.WriteLine("Tableau irrégulier :");
                
                for (int i = 0; i < arr[0].Count(); i++)
                {
                    foreach (var item in arr[i])
                    {
                        Console.Write(item);
                    }
                    Console.WriteLine();
                }
            }

            var bidimensionalArray = new int[,] { { 1, 2, 3 }, { 2, 3, 4 }, { 3, 4, 5 } };
            var jaggedArray = fillArray(ConvertArrayToList(bidimensionalArray));
            DisplayArray(jaggedArray);
        }
    }
}
