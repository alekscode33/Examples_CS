﻿/*
В предыдущем примере мы указывали значение массива вручную.
А сейчас перепишем этот код с использованием генератора 
псевдослучайных чисел с использованием методов. 
Мы потренируем то, каким образом можно взять, например,
метод, передать в него массив и заполнить массив нужным
количеством элементов.
На следующем этапе опишем метод, который будет выводить
все элементы по порядку. Затем превратим наш код поиска 
нужного индекса в метод.
*/

void FillArray(int[] collection)     // ключевое слово void
                                     // применим метод

{
    int length = collection.Length;  // посколько заранее неизвестно 
                                     // какое кол-во элементов в массиве
                                     // оно будет разным 
                                     // получаем длину массива  

    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        //index = index +1
        index++;
    }
}



int[] array = new int[10];
// Create an array named <array> with ten elements inside
// by default every elemnt will be equal zero - 0 