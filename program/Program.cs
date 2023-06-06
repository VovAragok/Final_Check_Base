// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
//  длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//  При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


void start()
{
    string[] arr = new string[0];
    arr = NewArray(arr);
    
 
}


string [] NewArray(string [] arr)
{
    int count = 0;
    while(true)
    {
        Console.WriteLine("Чтобы ввести строку в массив нажмите 1");
        if (Console.ReadLine() == "1")
        {
            Array.Resize(ref arr, arr.Length + 1);
            Console.WriteLine("Введите строку в массив");
            arr[count] = Console.ReadLine();
            count ++;
        }
        else
        {
            Console.WriteLine("Ваш созданный массив строк");
            string joinArr = string.Join(", ", arr);
            Console.WriteLine(joinArr);
            return arr;
            
        }
    }
}


start();