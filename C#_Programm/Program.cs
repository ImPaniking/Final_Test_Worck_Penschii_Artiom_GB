// Написать программу, которая из имеющегося массива строк формирует массв из строк, длина которых меньше либо равна 3 символа.

/*
1. Создать массив
2. Проверить кол-во эллеметнов удовлетворяющих условию
3. Создать новый массив - размером = кол-во эллементов из пунтка 2
    *Если таких эллементов нет - просто вывести [] не создавая массив
4. Внести в новый массив все эллементы из первого массива - удовлетворяющих условию
*5. Написать метод печати массива
*6. Написать вывод как в условии задачи
*/

string PrintArray(string[] array) // Метод , который создаёт печатную форму массива ( как в примере )
{
    string result = String.Empty;
    result += "[";
    for ( int i = 0 ; i < array.Length ; i++)
    {
        result += '"' + array[i] + '"';
        if ( i < array.Length-1 ) result += ',';
    }
    result += "]";
    return result;
}

System.Console.OutputEncoding = System.Text.Encoding.Unicode;// Не на всех компьютерах установлена Русская кодировка.
Console.Clear();

string[] argumentArray = new string[] {"hello","2","world",":-)"};//имеющийся массив
int lengthLookUp = 3;//кол-во символов для решения задания
int index = 0;//переменная, которая нужна будет для второго массива
int count = 0;//кол-во эллементов удовлетворяющих условию

for ( int i = 0 ; i < argumentArray.Length ; i++)//Счёт - какое количество эллементов удовлетворяют условию
{
    if (argumentArray[i].Length<=lengthLookUp) count++;
}

if (count == 0 )//Если эллементов нет - делает вывод []
{
    Console.WriteLine($"{PrintArray(argumentArray)} -> []");
}
else//Если эллементы есть - Создаёт новый массив - и делает итоговый вывод
{
    string[] newArray = new string[count];
    for ( int i = 0 ; i < argumentArray.Length ; i++)
    {
        if (argumentArray[i].Length<=lengthLookUp) 
        {
            newArray[index] = argumentArray[i];
            index++;
        }
    }
    Console.WriteLine($"{PrintArray(argumentArray)} -> {PrintArray(newArray)}");
}