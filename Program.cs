/*
    Написать программу, которая из имеющегося массива строк формирует массив из строк, 
    длина которых меньше либо равна 3 символа.
    Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
    При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

    Примеры:
    ["hello","2","world",":-)"] -> ["2",":-)"]
    ["1234","1567","-2","computer science"] -> ["-2"]
    ["Russia","Denmark","Kazan"] -> []
*/

/*Основной блок*/

int countWords = IsIntegerCheck("Укажите количество слов, которые надо проанализировать: ");
string [] inputWords = new string [countWords];
FillingArray(inputWords);
PrintArray(inputWords, "Список слов, которые были введены:\n");

int countSymbols = IsIntegerCheck("Выводим слова c определенным количеством букв (по условию меньше или равно), введите количество: ");
string [] outputWords = AnalizeWords(inputWords, countSymbols);
PrintArray(outputWords, "Итоговый список слов:\n");

/*Методы*/
int IsIntegerCheck(string textConsole){
    Console.WriteLine(textConsole);
    bool isInt = int.TryParse((Console.ReadLine()), out int count);
    if (!isInt || count <= 0){
        Console.WriteLine ("Неверное значение, повторите ввод!");
        return IsIntegerCheck(textConsole);
    } 
    else{
        return count;
    }
}

string [] FillingArray(string [] tempArray){
	for (int i = 0; i < countWords; i++){
		Console.Write($"Введите {i+1} слово: ");
		tempArray[i] = Console.ReadLine();
	}
	return tempArray;
}

string [] AnalizeWords(string [] inpArray, int limitSymbols){
	int lengthArray = 0;
	string tempValue = string.Empty;
	for (int i = 0; i < inpArray.Length; i++){
		tempValue = inpArray[i];
		if (tempValue.Length <= limitSymbols){
            lengthArray++;
        }
	}
	string [] outputArray = new string [lengthArray];
	int indexOutArray = 0;
	for (int i = 0; i < inpArray.Length; i++){
		tempValue = inpArray[i];
		if (tempValue.Length <= limitSymbols){
			outputArray[indexOutArray] = inpArray[i];
			indexOutArray++;
		}
	}
	return outputArray;
}

void PrintArray(string [] tempArray, string textConsole){
    if (tempArray.Length == 0){
        Console.WriteLine ("Итоговый список пуст!");
        return;
    }   
    Console.Write(textConsole);
    for(int i = 0; i < tempArray.Length; i++){        
        if (i == tempArray.Length -1){
            Console.Write($"{tempArray[i]}");
        }
        else {
            Console.Write($"{tempArray[i]}, ");
        }
    }
    Console.WriteLine();
}
