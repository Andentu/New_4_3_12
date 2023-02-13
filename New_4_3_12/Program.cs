namespace New_4_3_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 5, 6, 2, 1 };
            int num;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    // если Значение элемента первого [0] (в данном случае 5) больше, чем значение второго [1] элемента (в данном случае, 2), то выполняется код:
                    {
                        num = arr[i];
                        Console.WriteLine("num = " + num);
                        arr[i] = arr[j];
                        Console.WriteLine("arr[i] = " + arr[i]);
                        arr[j] = num;
                        Console.WriteLine("arr[j] = " + arr[j]);
                        Console.WriteLine();

                    }
                }
            }
            foreach (var item in arr)
            {
                Console.Write(item);
            }
        }
    }
}