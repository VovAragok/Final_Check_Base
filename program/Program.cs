// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
//  длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//  При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


void start()
{
    string[] arr = new string[0];
    arr = NewArray(arr);
    arr = FindArray(arr);
    
 
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


string [] FindArray(string [] arr)
{
    string[] newArray = new string[0];
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length < 4)
        {
            Array.Resize(ref newArray, newArray.Length + 1);
            newArray[count] = arr[i] ;
            count ++;
        }
    }
    Console.WriteLine("Ваш массив cо строками менее 3-ох символов");
    string joinArr = string.Join(", ", newArray);
    Console.WriteLine(joinArr);
    return newArray;
}


start();