# Программа для нахождения элементов массива размером менее 3х символов и создания нового массива с этими элементами

## Методы которые используются:

- **CreateNewArray** - метод на вход принимает число которое задаёт размер строкового массива. После создания массива пользователь последовательно вводит значения для заполнения массива данными.
- **ConvertArray** - метод на вход принимает строковый массив. Внутри метода происходит вычисление количества элементов подходящих под условие (менее 3х символов) и их запись в новый массив.
- **ReadInt** - метод для ввода числа пользователем. Внутри метода происходит проверка на ввод числа, если введено не число, то пользователь получает сообщение с просьбой ввести число.

## Принцип работы программы:

1. Пользователь запускает программу вводом "1".
1. Пользователю предлагается выбрать вариант работы программы:
    1. Первый вариант - создать и заполнить массив самостоятельно.
        1. Пользователь вводит число тем самым задаёт размер массива.
	    1. Пользователь последовательно вводит значения, которые записываются в массив.
	    1. Программа печатает созданный пользователем массив (для наглядности).
	    1. Программа печатает преобразованный массив.
	1. Второй вариант - воспользоваться заранее созданным массивом.
		1. Программа печатает заранее подготовленный массив (для наглядности).
		1. Программа печатает преобразованный массив.

## Нюансы работы с программой:

Для создания массива происходят две проверки:
1. Проверка что пользователь вводит число (а не символ или букву, например).
1. Проверка что число больше "0" (иначе у массива не будет размера, а значит массива не существует).

## Блок-схема алгоритма ConvertArray
![block-scheme](/images/Final%20Work.png)