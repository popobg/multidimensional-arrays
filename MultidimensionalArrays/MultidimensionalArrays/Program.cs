namespace MultidimensionalArrays
{
    internal class Program
    {
        static void Main()
        {
            // transform bidimensional array into a list of list that can be modified
            static List<List<int>> ConvertArrayToList(int[,] array)
            {
                var listOfList = new List<List<int>>();

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    listOfList.Add(new List<int>());
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        listOfList[i].Add(array[i, j]);
                    }
                }

                return listOfList;
            }

            static int[][] fillArray(List<List<int>> originalList)
            {
                var outputArray = new int[3][];
                var nestedListLength = originalList[0].Count();

                for (int i = 0; i < nestedListLength; i++)
                {
                    outputArray[i] = originalList[i].TakeLast(nestedListLength - i).ToArray();
                }

                return outputArray;
            }

            var bidimensionalArray = new int[,] { { 1, 2, 3 }, { 2, 3, 4 }, { 3, 4, 5 } };
            var jaggedArray = fillArray(ConvertArrayToList(bidimensionalArray));
        }
    }
}
