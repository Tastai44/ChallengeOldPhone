## Old phone keypad C# Coding Challenge

Old phone keypad is use for typing letters by pressing a button multiple times will cycle through the letters on it allowing each button to represent more than one letter. 

## Built With

* C#

## Components and How it works

After you access the folder ChallengeOldPhone, you will find two main folders: OldPhoneButton and OldPhoneButton.Tests. Firstly, the code used to solve this challenge is located in the file Program.cs in the OldPhoneButton folder.
In the Program.cs file, there are 6 methods. The following is the order of how they work:
* Main -> Welcome -> MapInput -> DeleteNumber (if the input contain *) -> CheckLastNumber -> OldPhonePad
* Main: This method is where the program begins its execution.
* Welcome: This method is designed to display a welcome message, prompting the user to type numbers.
* MapInput: This method is used to return characters based on the given input string, following certain conditions and rules inside the method.
* DeleteNumber: This method is used to delete the letter located before * For example, 227* -> 22.
* CheckLastNumber: it is the method that is used for returning characters when processing the last character of the input.
* OldPhonePad: it is the method that is used for mapping sequences of numbers to corresponding characters based on an old phone keypad layout and return those characters and the end.

Secondly, in the folder OldPhoneButton.Tests, there are test cases for this program that include all the methods located in the Program file. The purpose is to test whether all methods behave as expected or not.

## License

[IRON](https://ironsoftware.com/)

## Contact

Tastai Khianjai - tastthai.654@gmail.com

