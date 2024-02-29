// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Specialized;

string[,] sualVeCavablar = new string[10, 5];

sualVeCavablar[0, 0] = "Sual1";
sualVeCavablar[0, 1] = "Sual1_cavab1";
sualVeCavablar[0, 2] = "Sual1_cavab2";
sualVeCavablar[0, 3] = "Sual1_cavab3";
sualVeCavablar[0, 4] = "Sual1_cavab3";

sualVeCavablar[1, 0] = "Sual2";
sualVeCavablar[1, 1] = "Sual2_cavab1";
sualVeCavablar[1, 2] = "Sual2_cavab2";
sualVeCavablar[1, 3] = "Sual2_cavab3";
sualVeCavablar[1, 4] = "Sual2_cavab3";

sualVeCavablar[2, 0] = "Sual3";
sualVeCavablar[2, 1] = "Sual3_cavab1";
sualVeCavablar[2, 2] = "Sual3_cavab2";
sualVeCavablar[2, 3] = "Sual3_cavab3";
sualVeCavablar[2, 4] = "Sual3_cavab3";

sualVeCavablar[3, 0] = "Sual4";
sualVeCavablar[3, 1] = "Sual4_cavab1";
sualVeCavablar[3, 2] = "Sual4_cavab2";
sualVeCavablar[3, 3] = "Sual4_cavab3";
sualVeCavablar[3, 4] = "Sual4_cavab3";

sualVeCavablar[4, 0] = "Sual5";
sualVeCavablar[4, 1] = "Sual5_cavab1";
sualVeCavablar[4, 2] = "Sual5_cavab2";
sualVeCavablar[4, 3] = "Sual5_cavab3";
sualVeCavablar[4, 4] = "Sual5_cavab3";

sualVeCavablar[5, 0] = "Sual6";
sualVeCavablar[5, 1] = "Sual6_cavab1";
sualVeCavablar[5, 2] = "Sual6_cavab2";
sualVeCavablar[5, 3] = "Sual6_cavab3";
sualVeCavablar[5, 4] = "Sual6_cavab3";

sualVeCavablar[6, 0] = "Sual7";
sualVeCavablar[6, 1] = "Sual7_cavab1";
sualVeCavablar[6, 2] = "Sual7_cavab2";
sualVeCavablar[6, 3] = "Sual7_cavab3";
sualVeCavablar[6, 4] = "Sual7_cavab3";

sualVeCavablar[7, 0] = "Sual8";
sualVeCavablar[7, 1] = "Sual8_cavab1";
sualVeCavablar[7, 2] = "Sual8_cavab2";
sualVeCavablar[7, 3] = "Sual8_cavab3";
sualVeCavablar[7, 4] = "Sual8_cavab3";

sualVeCavablar[8, 0] = "Sual9";
sualVeCavablar[8, 1] = "Sual9_cavab1";
sualVeCavablar[8, 2] = "Sual9_cavab2";
sualVeCavablar[8, 3] = "Sual9_cavab3";
sualVeCavablar[8, 4] = "Sual9_cavab3";

sualVeCavablar[9, 0] = "Sual10";
sualVeCavablar[9, 1] = "Sual10_cavab1";
sualVeCavablar[9, 2] = "Sual10_cavab2";
sualVeCavablar[9, 3] = "Sual10_cavab3";
sualVeCavablar[9, 4] = "Sual10_cavab3";

//////////////////////////////////////////////////////////

string[,] deyisenSualVeCavablar = new string[10, 5];


void write_questions()
{
    int index = 0;
    Random rand = new Random();
    while (true)
    {
        bool checkQuestionIndex = true;
        int random_number = rand.Next(0, 10);
        for (int j = 0; j < 10; j++)
        {
            if (deyisenSualVeCavablar[j, 0] == sualVeCavablar[random_number, 0])
            {
                checkQuestionIndex = false; break;
            }
        }
        if (checkQuestionIndex == true)
        {
            deyisenSualVeCavablar[index, 0] = sualVeCavablar[random_number, 0];
            int indexQuestion = 1;
            while (true)
            {
                bool checkAnswerIndex = true;
                int random_number_question = rand.Next(1, 4);
                for (int i = 1; i < 4; i++)
                {
                    if (deyisenSualVeCavablar[index, random_number_question] == sualVeCavablar[random_number, i])
                    {
                        checkAnswerIndex = false; break;
                    }
                }
                if (checkAnswerIndex == true)
                {
                    deyisenSualVeCavablar[index, random_number_question] = sualVeCavablar[random_number, indexQuestion];
                    indexQuestion += 1;
                }
                if (indexQuestion == 4)
                {
                    deyisenSualVeCavablar[index, 4] = sualVeCavablar[random_number, 4];
                    break;
                }
            }
            index += 1;
        }
        if (index == 10)
        {
            break;
        }
    }
}

write_questions();

//for (int i = 0; i < 10; i++)
//{
//    for (int j = 0; j < 5; j++)
//    {
//        Console.WriteLine(deyisenSualVeCavablar[i, j]);
//    }
//}

bool[] trueORfalse_answers=new bool[10];

void Start()
{
    for (int i = 0; i < 10; i++)
    {
        ShowQuestion(deyisenSualVeCavablar, i);
    }
}

void ShowQuestion(string[,] arr,int index)
{
    Console.Clear();
    Console.WriteLine("\n\n\n\t\t\tMilyonchu\t\t\t\n\n\n");
    Console.WriteLine($"{index + 1}){arr[index, 0]}");
    Console.Write($"a){arr[index,1]}  ");
    Console.Write($"b){arr[index,2]}  ");
    Console.Write($"c){arr[index,3]}  ");
    Console.WriteLine();
    Console.Write("Cavab : ");
    string variant = Console.ReadLine();
    if (variant == "a" || variant == "A")
    {
        if (arr[index, 1] == arr[index,4])
        {
            Show_users_answer(arr, index, true);
            trueORfalse_answers[index] = true;
           
        }
        else 
        {
            Show_users_answer(arr, index, false);
            trueORfalse_answers[index] = false;
           
        }
    }
    else if (variant == "b" || variant == "B")
    {
        if (arr[index, 2] == arr[index, 4])
        {
            Show_users_answer(arr, index, true);
            trueORfalse_answers[index] = true;
            
        }
        else
        {
            Show_users_answer(arr, index, false);
            trueORfalse_answers[index] = false;
            
        }
    }
    else if (variant == "c" || variant == "C")
    {
        if (arr[index, 3] == arr[index, 4])
        {
            Show_users_answer(arr, index, true);
            trueORfalse_answers[index] = true;
        }
        else
        {
            Show_users_answer(arr, index, false);
            trueORfalse_answers[index] = false;
           
        }
    }
    else
    {
        Show_users_answer(arr, index, false);
        trueORfalse_answers[index] = false;
        
    }
}

void Show_users_answer(string[,] arr, int index,bool situation)
{
    Console.Clear();
    if (situation==true)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n\n\n\t\t\tMilyonchu\t\t\t\n\n\n");
        Console.WriteLine($"{index + 1}){arr[index, 0]}");
        Console.Write($"a){arr[index, 1]}  ");
        Console.Write($"b){arr[index, 2]}  ");
        Console.Write($"c){arr[index, 3]}  ");
        Console.WriteLine();
        Console.Write("Cavab : TRUE");
        Thread.Sleep(2000);
        Console.ForegroundColor = ConsoleColor.White;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\n\n\n\t\t\tMilyonchu\t\t\t\n\n\n");
        Console.WriteLine($"{index + 1}){arr[index, 0]}");
        Console.Write($"a){arr[index, 1]}  ");
        Console.Write($"b){arr[index, 2]}  ");
        Console.Write($"c){arr[index, 3]}  ");
        Console.WriteLine();
        Console.Write("Cavab : False");
        Thread.Sleep(2000);
        Console.ForegroundColor = ConsoleColor.White;
    }
}

Start();

int Final_point = 0;
for (int i = 0; i < 10; i++)
{
    if (trueORfalse_answers[i] == true)
    {
        Final_point+=10;
    }
    else
    {
        if (Final_point != 0)
        {
            Final_point -= 10;
        }
    }
}

Console.Clear();
Console.WriteLine("\n\n\n\t\t\tMilyoncu Bitdi\t\t\t\n\n\n");
Console.WriteLine($"Sizin Xaliniz : {Final_point}");
