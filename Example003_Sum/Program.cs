//int numberA = 31;
//int numberB = 5;
//Console.Write("numberA + numberB =");
//Console.WriteLine(numberA + numberB);
//int result = numberA + numberB;
//Console.Write("result = ");
//Console.WriteLine(result);



//int numberA = new Random().Next(1, 10);
// 1 2 3 … 9 случайное целое число из диапазона от 1 до 10
//int numberB = new Random().Next(1, 10);
// 1 2 3 … 9 случайное целое число из диапазона от 1 до 10
//int result = numberA + numberB;
//Console.WriteLine(result);


// Используем генератор случайных чисел
// int NumberX = new Random().Next(min,max-1); 
int numberA = new Random().Next(1, 10); // от 1 2 3 до 9 случайное целое число из диапазона от 1 до 10
Console.WriteLine(numberA); // WriteLine — вывод с переходом на новую строку
int numberB = new Random().Next(1, 10); // 1 2 3 … 9 случайное целое число из диапазона от 1 до 10
Console.WriteLine(numberB);
int result = numberA + numberB;
Console.Write(result);// Write — это вывод без перехода на новую строку. 
