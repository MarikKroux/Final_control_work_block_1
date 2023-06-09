# Итоговая контрольная работа по основному блоку
## Урок 1. Контрольная работа
Данная работа необходима для проверки ваших знаний и навыков по итогу прохождения первого блока обучения на программе Разработчик. Мы должны убедится, что базовое знакомство с IT прошло успешно.

Задача алгоритмически не самая сложная, однако для полноценного выполнения проверочной работы необходимо:

1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

## Задача: 
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

### Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]<br/>
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]<br/>
[“Russia”, “Denmark”, “Kazan”] → []

## Решение:
1. Необходимо ввести вручную количество элементов N исходного массива stringArray;
2. Необходимо ввести вручную элементы исходного массива stringArray, согласно количеству элементов из п.1;
3. Длину каждого введенного элемента сравнить с числом 3. Элементы, длина которых меньше или равна 3, записать в новый массив resultArray;
4. Т.к. массив resultArray может по длине отличаться от исходного массива stringArray (изначально массив resultArray создан согласно размеру массива stringArray), необходимо воспользоваться методом Array.Resize(ref resultArray, count) (уменьшить размер массива resultArray до длины count), где 
* resultArray - массив, содержащий в себе только элементы, длина которых меньше или равна 3;
* count - счетчик элементов, длина которых меньше или равна 3;
5. Вывести итоговый массив resultArray.

### Альтернативный вариант решения*
1. Необходимо ввести вручную количество элементов N исходного массива stringArray;
2. Необходимо ввести вручную элементы исходного массива stringArray, согласно количеству элементов из п.1;
3. Длину каждого введенного элемента сравнить с числом 3. Посчитать количество элементов, длина которых меньше или равна 3, результат записать во временную переменную (счетчик);
4. Создать новый массив resultArray с длиной, равной счетчику из п.3. Заполнить массив resultArray элементами, длина которых меньше или равна 3;
5. Вывести итоговый массив resultArray.

**В процессе выполнения итоговой контрольной работы решение сначало было выполнено по альтернативному варианту решения, в последствии решение было оптимизировано добавлением метода Array.Resize.* 

## Блок-схема
![Блок-схема](/block.png)

## Исходный код программы на C#
https://github.com/MarikKroux/Final_control_work_block_1/blob/main/Program.cs
