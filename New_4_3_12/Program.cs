namespace New_4_3_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 5, 2, 1 };
            int num;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    // если Значение элемента первого [0] (в данном случае 5) больше, чем значение второго [1] элемента (в данном случае, 2), то выполняется код:
                    {
                        num = arr[i];
                        arr[i] = arr[j];                        
                        arr[j] = num;                        
                        Console.WriteLine();
                        // По сути, происходит перемена местами элементов массива
                                            }
                }
            }
            foreach (var item in arr) // Получает значение элемента массива из arr и записывает их в переменную var, после чего выводит на экран ее значение
                                      // Значение получаемого элемента меняется по мере работы цикла for с содержимым if
            {
                Console.Write(item);
            }
        }
    }
}