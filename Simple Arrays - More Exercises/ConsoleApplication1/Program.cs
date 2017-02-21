using System;
using System.Linq;

namespace _2._4.Phonee
{
    public class Program
    {
        public static void Main()
        {
            string[] phoneNumbers = Console.ReadLine().Split(' ').ToArray();
            string[] names = Console.ReadLine().Split(' ').ToArray();

            var line = Console.ReadLine().Split(' ');

            while (line[0] != "done")
            {
                if (line[0] == "call") // ако командата е call
                {
                    var splittedNameOrNumber = line[1].ToCharArray(); // сплитвам името/номера
                    bool isLetter = DigitOrLetter(splittedNameOrNumber); // проверявам дали започва с буква или цифра
                    if (isLetter) // ако е буква независимо дали е малка или голяма
                    {
                        CallingName(phoneNumbers, names, line); // викам метода за набиране по име
                    }
                    else if (!isLetter) // ако е цифра
                    {
                        CallingNumber(phoneNumbers, names, line); // викам метода за набиране по номер
                    }
                }
                else if (line[0] == "message") // аналогично на команда call
                {
                    var splittedNameOrNumber = line[1].ToCharArray();
                    bool isLetter = DigitOrLetter(splittedNameOrNumber);
                    if (isLetter)
                    {
                        MessagingName(phoneNumbers, names, line);
                    }
                    else if (!isLetter)
                    {
                        MessagingNumber(phoneNumbers, names, line);
                    }
                }
                line = Console.ReadLine().Split(' ');
            }
        }

        private static void MessagingNumber(string[] phoneNumbers, string[] names, string[] line)
        {
            for (int i = 0; i < phoneNumbers.Length; i++)
            {
                if (line[1] == phoneNumbers[i])
                {
                    phoneNumbers[i] = names[i];
                    Console.WriteLine($"sending sms to {phoneNumbers[i]}...");
                    var sumOfDigits = line[1].ToCharArray();
                    var sum = 0;
                    foreach (var x in sumOfDigits)
                    {
                        if (x > 48 && x <= 57)
                        {
                            sum += x - '0';
                        }
                    }
                    if (sum % 2 == 0)
                    {
                        Console.WriteLine($"meet me there");
                    }
                    else { Console.WriteLine("busy"); }
                    break;
                }
            }
        }

        private static void MessagingName(string[] phoneNumbers, string[] names, string[] line)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (line[1] == names[i])
                {
                    names[i] = phoneNumbers[i];
                    Console.WriteLine($"sending sms to {names[i]}...");
                    var sumOfDigits = phoneNumbers[i].ToCharArray();
                    var sum = 0;
                    foreach (var x in sumOfDigits)
                    {
                        if (x > 48 && x <= 57)
                        {
                            sum += x - '0';
                        }
                    }
                    if (sum % 2 == 0)
                    {
                        Console.WriteLine($"meet me there");
                    }
                    else { Console.WriteLine("busy"); }
                    break;
                }
            }
        }

        private static void CallingNumber(string[] phoneNumbers, string[] names, string[] line)
        {
            for (int i = 0; i < phoneNumbers.Length; i++) // проверявам всички номера които са въведени първоначално
            {
                if (line[1] == phoneNumbers[i]) //ако номерът въведен след команда "call" съвпада с номер от номерата въведени в началото
                {
                    phoneNumbers[i] = names[i]; // взимам името на съответстващия номер...
                    Console.WriteLine($"calling {phoneNumbers[i]}..."); // ... набирам го
                    var sumOfDigits = line[1].ToCharArray(); //превръщам номера на масив от знаци...
                    var sum = 0;
                    foreach (var x in sumOfDigits) // за всеки знак от масива със знаци.... 
                    {
                        if (x > 48 && x <= 57) //....проверявам дали е цифра....
                        {
                            sum += x - '0'; // ... ако е цифра събирам аски кода и изваждам аски кода на '0' за да получа реалната стойност на цифрата и я прибавям към сумата на останалите...
                        }
                    }
                    if (sum % 2 == 0)//... ако сумата е четна ...
                    {
                        var min = sum / 60;  //...деля на 60 за минути
                        var sec = sum % 60;  // ... деля процентно за секунди 
                        Console.WriteLine($"call ended. duration: 0{min}:{sec}"); // принтирам минутите и секундите
                    }
                    else { Console.WriteLine("no answer"); }
                    break; // защото вече съм намерил човека и номера му
                }
            }
        }

        private static void CallingName(string[] phoneNumbers, string[] names, string[] line)
        {
            for (int i = 0; i < names.Length; i++)//проверявам всички имена които са въведени първоначално
            {
                if (line[1] == names[i]) //ако името въведено след команда "call" съвпада с име от имената въведени в началото
                {
                    names[i] = phoneNumbers[i]; // взимам номера съответстващ на името...
                    Console.WriteLine($"calling {names[i]}..."); //... набирам го....
                    var sumOfDigits = phoneNumbers[i].ToCharArray(); //... превръщам номера на масив от знаци
                    var sum = 0;
                    foreach (var x in sumOfDigits) // за всеки знак от масива със знаци....
                    {
                        if (x > 48 && x <= 57) // .... проверявам дали е цифра ....
                        {
                            sum += x - '0'; // ... ако е цифра събирам аски кода и изваждам аски кода на '0' за да получа реалната стойност на цифрата и я прибавям към сумата на останалите...
                        }
                    }
                    if (sum % 2 == 0) //... ако сумата е четна ...
                    {
                        var min = sum / 60; //...деля на 60 за минути
                        var sec = sum % 60; // ... деля процентно за секунди 
                        Console.WriteLine($"call ended. duration: 0{min}:{sec}"); // принтирам минутите и секундите
                    }
                    else { Console.WriteLine("no answer"); }
                    break; // защото вече съм намерил човека и номера му
                }
            }
        }

        private static bool DigitOrLetter(char[] splittedNameOrNumber)
        {
            return (splittedNameOrNumber[0] >= 'A' && splittedNameOrNumber[0] <= 'Z') || (splittedNameOrNumber[0] >= 'a' && splittedNameOrNumber[0] <= 'z');
        }
    }
}