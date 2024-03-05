/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

string [] Array(string [] Array) //Объявление функции заполнения нового массива
{
  int n = 0;
  for (int i = 0;i<Array.Length;i++)
  {
    if(Array[i].Length <=3) //Подсчет количества элементов, удовлетворяющих условию (не более 3 символов)
    n++;
  }
  string [] newArray = new string [n]; // Создание массива размером равным количеству удовлетворяющих условию
  int j = 0;
  for (int i = 0;i<Array.Length;i++)
  {
    if(Array[i].Length <=3)
    {
        newArray[j] = Array[i]; //Заполнение нового массива
        j++;
    }
  }
  return newArray;
}


void printArray(string [] Array) //Функция отображения массива
{
    Console.Write("[");
    for (int i = 0;i<Array.Length;i++)
    {
     if (i==Array.Length-1)
        {
            Console.Write($"'{Array[i]}'");
        }
        else
        Console.Write($"'{Array[i]}', ");
    }
    Console.Write("]");
}