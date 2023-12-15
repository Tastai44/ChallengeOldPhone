using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldPhoneButton
{
    public class Program
    {
        public static string OldPhonePad(string input)
        {
            string listCharacters = "";
            input = input.Replace("#", "");
            input = input.Replace("*", "");
            var listNumber = input.Split(' ');
            foreach (var number in listNumber)
            {
                switch (number)
                {
                    case "1":
                        listCharacters += "&";
                        break;
                    case "11":
                        listCharacters += "'";
                        break;
                    case "111":
                        listCharacters += "(";
                        break;
                    case "2":
                        listCharacters += "A";
                        break;
                    case "22":
                        listCharacters += "B";
                        break;
                    case "222":
                        listCharacters += "C";
                        break;
                    case "3":
                        listCharacters += "D";
                        break;
                    case "33":
                        listCharacters += "E";
                        break;
                    case "333":
                        listCharacters += "F";
                        break;
                    case "4":
                        listCharacters += "G";
                        break;
                    case "44":
                        listCharacters += "H";
                        break;
                    case "444":
                        listCharacters += "I";
                        break;
                    case "5":
                        listCharacters += "J";
                        break;
                    case "55":
                        listCharacters += "K";
                        break;
                    case "555":
                        listCharacters += "L";
                        break;
                    case "6":
                        listCharacters += "M";
                        break;
                    case "66":
                        listCharacters += "N";
                        break;
                    case "666":
                        listCharacters += "O";
                        break;
                    case "7":
                        listCharacters += "P";
                        break;
                    case "77":
                        listCharacters += "Q";
                        break;
                    case "777":
                        listCharacters += "R";
                        break;
                    case "7777":
                        listCharacters += "S";
                        break;
                    case "8":
                        listCharacters += "T";
                        break;
                    case "88":
                        listCharacters += "U";
                        break;
                    case "888":
                        listCharacters += "V";
                        break;
                    case "9":
                        listCharacters += "W";
                        break;
                    case "99":
                        listCharacters += "X";
                        break;
                    case "999":
                        listCharacters += "Y";
                        break;
                    case "9999":
                        listCharacters += "Z";
                        break;
                }
            }
            return listCharacters;
        }

        public static string CheckLastNumber(StringBuilder lastNumber, int i)
        {
            string characters = "";
            if (i == lastNumber.Length - 1 && lastNumber[lastNumber.Length - 1] != lastNumber[lastNumber.Length - 2])
            {
                characters += lastNumber[lastNumber.Length - 1].ToString() + " ";
            }
            else if (i == lastNumber.Length - 1 && lastNumber[lastNumber.Length - 1] == lastNumber[lastNumber.Length - 2] && lastNumber[lastNumber.Length - 2] != lastNumber[lastNumber.Length - 3])
            {
                characters += lastNumber[lastNumber.Length - 1].ToString() + lastNumber[lastNumber.Length - 2] + " ";
            }
            else if (i == lastNumber.Length - 1 && lastNumber[lastNumber.Length - 1] == lastNumber[lastNumber.Length - 2] && lastNumber[lastNumber.Length - 2] == lastNumber[lastNumber.Length - 3] && lastNumber[lastNumber.Length - 3] != lastNumber[lastNumber.Length - 4])
            {
                characters += lastNumber[lastNumber.Length - 1].ToString() + lastNumber[lastNumber.Length - 2] + lastNumber[lastNumber.Length - 3] + " ";
            }
            else if (i == lastNumber.Length - 1 && lastNumber[lastNumber.Length - 1] == lastNumber[lastNumber.Length - 2] && lastNumber[lastNumber.Length - 2] == lastNumber[lastNumber.Length - 3] && lastNumber[lastNumber.Length - 3] == lastNumber[lastNumber.Length - 4])
            {
                characters += lastNumber[lastNumber.Length - 1].ToString() + lastNumber[lastNumber.Length - 2] + lastNumber[lastNumber.Length - 3] + lastNumber[lastNumber.Length - 4] + " ";
            }
            return characters;
        }

        public static StringBuilder DeleteNumber(StringBuilder arrayNumber)
        {
            StringBuilder newArray = arrayNumber;
            for (int r = 0; r < arrayNumber.Length; r++)
            {
                if (r + 1 < arrayNumber.Length && arrayNumber[r + 1] == '*')
                {
                    arrayNumber.Remove(r, 2);
                }
            }
            return newArray;
        }

        public static string MapInput(string input)
        {
            string characters = "";
            StringBuilder newArray = new StringBuilder(input);
            if (newArray.ToString().Contains("*"))
            {
                newArray = DeleteNumber(newArray);
            }

            newArray = newArray.Replace("#", "");

            for (int i = 0; i < newArray.Length;)
            {

                if (newArray.Length < 3)
                {
                    if (newArray.Length == 1)
                    {
                        characters += newArray[i].ToString();
                        i++;
                    }
                    else if (newArray.Length > 1)
                    {
                        if (i + 1 < newArray.Length && newArray[i] != newArray[i + 1])
                        {
                            characters += newArray[i].ToString() + " ";
                            i++;
                        }
                        else if (i + 1 < newArray.Length && newArray[i] == newArray[i + 1])
                        {
                            characters += newArray[i].ToString() + newArray[i + 1] + " ";
                            i += 2;
                        }

                        if (i == newArray.Length - 1 && newArray[newArray.Length - 1] != newArray[newArray.Length - 2])
                        {
                            characters += newArray[newArray.Length - 1].ToString() + " ";
                            i++;
                        }
                    }
                }
                else
                {

                    if (i + 1 < newArray.Length && newArray[i] != newArray[i + 1])
                    {
                        characters += newArray[i].ToString() + " ";
                        i++;
                    }
                    else if (i + 2 < newArray.Length && newArray[i] == newArray[i + 1] && newArray[i + 1] != newArray[i + 2])
                    {
                        characters += newArray[i].ToString() + newArray[i + 1] + " ";
                        i += 2;
                    }
                    else if (i + 3 < newArray.Length && newArray[i] == newArray[i + 1] && newArray[i + 1] == newArray[i + 2] && newArray[i + 2] != newArray[i + 3])
                    {
                        characters += newArray[i].ToString() + newArray[i + 1] + newArray[i + 2] + " ";
                        i += 3;
                    }
                    else if (i + 4 < newArray.Length && newArray[i] == newArray[i + 1] && newArray[i + 1] == newArray[i + 2] && newArray[i + 2] == newArray[i + 3] && newArray[i + 3] == newArray[i + 4])
                    {
                        characters += newArray[i].ToString() + newArray[i + 1] + newArray[i + 2] + newArray[i + 3] + " ";
                        i += 4;
                    }
                    else
                    {
                        i++;
                    }

                    characters += CheckLastNumber(newArray, i);

                }
            }
            return characters;
        }

        static void Welcome()
        {
            Console.WriteLine("Welcome to old phone keypad.");
            Console.WriteLine("Please type numbers: ");
        }
        static void Main(string[] args)
        {
            Welcome();
            string input = Console.ReadLine();
            string result = "";

            if (input != null)
            {
                if (input[input.Length - 1] != '#')
                {
                    Console.WriteLine("Invalid input, please type # and the end.");
                    return;
                }
                else
                {
                    var listNumber = input.Split(' ');
                    foreach (var number in listNumber)
                    {
                        result += OldPhonePad(MapInput(number));
                    }
                }
            }
            if (result.Length == 0)
            {
                Console.WriteLine("Invalid input!");
            }
            else
            {
                Console.WriteLine("Output:" + result);
            }
            
        }
    }
}
