//Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше, либо равна 3 символа. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string inputString = ReadStringData("Введите набор данных через запятую. Это могут быть слова, символы, цифры или выражения");
string[] firstArray = GenArray(inputString);
Console.WriteLine();
Console.WriteLine("Набор данных, преобразованный в массив строк:");
PrintArray(firstArray);

Console.WriteLine();
int charQuantity = ReadIntData("Укажите число символов:");
if (CheckInputData(firstArray, charQuantity))
{
    string[] newArray = GenNewArray(firstArray, charQuantity);
    Console.WriteLine();
    Console.WriteLine("Массив строк, все элементы которого имеют заданную длину, сформированный из исходного массива:");
    PrintArray(newArray);
}
else
    Console.WriteLine("В исходном массиве нет ни одного элемента заданной длины");

//=========МЕТОДЫ============
string ReadStringData(string msg) //Считываем данные с консоли в формате строки
{
    Console.WriteLine(msg);
    return Console.ReadLine() ?? "0";
}

int ReadIntData(string msg) //Считываем данные с консоли в формате целого числа
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

string[] GenArray(string str) //Формируем массив строковых элементов из одной строки
{
    string[] array = str.Split(","); //используем системный метод разделения строки на подстроки по заданному символу-разделителю
    for (int i = 0; i < array.Length; i++) //перебираем элементы массива, убирая лишние пробелы, чтобы потом правильно посчиталось количество символов
    {
        array[i] = array[i].Trim();
    }
    return array;
}

void PrintArray(string[] arr) //метод для формирования строки отображения массива
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write("\"" + arr[i] + "\"" + ",");
    }
    Console.WriteLine("\"" + arr[arr.Length - 1] + "\"" + "]");
}

bool CheckInputData(string[] arr, int number)//проверка на то, есть ли в исходном массиве элементы заданной длины
{
    bool answer = false;
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= number)
        {
            count = count + 1;
        }
    }
    if (count != 0) answer = true;
    return answer;
}

string[] GenNewArray(string[] array, int number)//Формируем массив с элементами заданной длины
{
    string newInputData = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= number)
        {
            newInputData = newInputData + array[i] + ',';//накапливаем строку, состоящую из элементов нужной длины.
        }
    }
    newInputData = newInputData.TrimEnd(','); //убираем последюю запятую
    string[] newArr = GenArray(newInputData);
    return newArr;
}