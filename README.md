# _SCRABBLE SCORE_

#### _Scrabble Score In-Class Exercise_, _Mar. 5, 2020_

#### By _**Drake Wilcox**_

## Description

_This is an in class exercise for Week 2 of the C# Unit at Epicodus. The goal of this project was to make an application that allows the user to input a word and then to see what the Scrabble Score is for the inputted word._

## Specifications:

| Specification | Example Input | Example Output |
| :-------------|:-------------:|:-------------:|
| When the user inputs a letter, the application returns with the scrabble score for that letter | "A" | Score: 1 |
| If the user inputs any vowels or the letters L, N, R, S, and T, the application returns with a score of 1 | "L" | Score: 1 |
| If user inputs the letters "D" or "G", the returned score is "2" | "D" | Score: 2 |
| If the user inputs the letters B, C, M, or P, the returned score is "3" | "M" | Score: 3 |
| If the user inputs the letters F, H, V, W, or Y the returned score is "4" | "Y" | Score: 4 |
| If the user inputs the letter K the reuturned score is 5 | "K" | Score: 5 |
| If the user inputs the letter J or X, the returned score is 8 | "X" | Score: 8 |
| If the user inputs the letter Q or Z, the returned score is 10 | "Z" | Score: 10|
| When the user inputs a full word, the apllication returns the score of all the letters included | "Crazy" | Score : 19 |
| Application returns the same score for words that include lowercase and capital letters | "CRAZY" | Score: 19 | 



## Setup/Installation Requirements

To use this application, follow the following instructions. 

#### Installing .NET core

##### For macOS: 

* Dowload [this .NET Core SDK](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) which will prompt a .pkg file download from Microsoft.

* Open the file. This will launch and walk you through installation steps. Use default settings. 

* Confirm the installation is successful by opening the terminal and running the command ``$ dotnet --version``. You should see something like ``2.2.105`` in response.

##### For Windows: 
* Visit the [Microsoft .NET Installation Guide](https://docs.microsoft.com/en-us/dotnet/framework/install/).

#### Installing donet script

* After installing .NET Core, run the command `` dotnet tool install -g dotnet-script `` in Terminal. 

#### Application Setup:
_Clone this repository via Terminal using the following commands:_
* ``$ cd desktop``
* ``$ git clone "repository link" ``
* ``$ cd ProjectName.Solution``

_To Run this Console Application, enter the following command in the Terminal:_

* ``$ dotnet run``

_To view the source code of this application, open the folder in the Text Editor of your choice. (Example: to open via Visual Code enter the command ``code . `` in Terminal.)_

## Technologies Used
* _Git_
* _C#_
* _.NET Core 2.2_
* _dotnet script_
* _VS Code_

### License

*This webpage is licensed under the MIT license.*

Copyright (c) 2020 **_Drake Wilcox_**