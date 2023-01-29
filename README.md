![GBlogo](GBlogo.png)
# **Базовое знакомство с IT. Итоговая проверочная работа.** 

БЛОК-СХЕМА сохранена в репозитории проекта отдельным файлом расширения drawio.

Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше, либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Реализованное решение позволяет пользвоателю самому ввести длину элементов новго массива, что делает данное решение более универсальным.

В работе в том числе используются методы, написанные во время прохождения семинаров курса "Введение в языки программирования". Описание работы методов дано в конце описания в разделе *"МЕТОДЫ"*

## Описание шагов программы.
1. Запрашиваем у пользователя ввод  исходного массива. Элементы массива просим вводить через запятую. Используем метод *ReadStringData*.
2. С помощью метода *GenArray* создаем исходный массив, т.е. преобразовываем строку текста в массив строковых элементов.
3. Выводим созданный массив в консоль.
4. Запрашиваем у пользователя длину элементов для новго массива.
5. С помощью метода *CheckInputData* проверяем, есть ли в исходном массиве элементы заданной длины.
6. Если проверка не пройдена, выводим соответсвующее сообщение. КОНЕЦ ПРОГРАММЫ.
7. Если проверка пройдена, формируем новый массив с помощью метода *GenNewArray*.
8. Выводим созданный массив в консоль. КОНЕЦ ПРОГРАММЫ.

## МЕТОДЫ
* ReadStringData - метод принимает на вход строку с текстом, который пользователь видит в консоли. Проверяет на null. Возвращает в формате строки ответ пользователя.
* ReadIntData - метод принимает на строку с текстом, который пользователь видит в консоли. Проверяет на null. Возвращает в формате целого числа ответ пользователя.
* GenArray - метод принимает на вход строку, содержащую запятые, разделяет строку на подстроки, используя запятую в качестве символа-разделителя. Результат записывается в строковый массив. Далее перебирает все элементы полученного массива, убирая лишние пробелы. Возвращает массив строковых элементов.  
* CheckInputDat - метод принимает на вход массив строковых элементов и целое число. Проверяет, есть ли в массиве элементы, длина которых меньше либо равна заданному целому числу. Если такие элементы есть, то возвращает значение ИСТИНА, иначе ЛОЖЬ.
* GenNewArray - метод принимает на вход массив строковых элементов и целое число. Перебирает элементы массива, если длина элемента меньше либо равно заданного целого числа, то элемент записываем в строковую переменную накопления результата через запятую. Вызывает метод GenArray, передавая накопленную строку. Возвращает полученный массив.
* PrintArray - метод пинимает на вход массив строковых элементов. При вызове данного метода в консоль выводится каждый элемент массива, обрамленный двойными кавычками, через запятую. 