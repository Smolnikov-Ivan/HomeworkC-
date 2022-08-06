Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
    if (number1 > number2)
    {
    Console.WriteLine("Первое число является бОльшим.");
    Console.WriteLine(number1);
    }
    else 
    {
    Console.WriteLine("Второе число является бОльшим.");    
    Console.WriteLine(number2);
    }

//алгоритм работает полностью, хоть и на Console подчёркивание красное, ошибок нет.

//string name = Console.RedLine();
//Console.ReadLine() ждём значение из терминала
//Convert.ToInt32() превращаем значение в число из терминала
//Создаём переменную и записываем значение туда 
// = присвоить
// == сравнить
// if() {}

