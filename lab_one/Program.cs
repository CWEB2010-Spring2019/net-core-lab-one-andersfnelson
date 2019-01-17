using System;
using static System.Console;
using System.Collections.Generic;

namespace lab_one
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string[] CorrectAnswers;
            CorrectAnswers = new string[10] { "B", "B", "C", "A", "D", "A", "A", "C", "D", "A" };

            string[] UserSelection = new string[10];
           

            string[] QuizQuestions;
            QuizQuestions = new string[10] {
                                                "What is the current stable release of .NET Core?",
                                             "What year was .NET Core first released in?",
                                              "What is the name for API's that are common to all .NET implementations?",
                                                ".NET Core 3.0 will include which of these updates?",
                                               "Which languages does .NET Core support?",
                                                ".NET Core is an open-source version of the .NET Framework, which was initially developed by what company?",
                                                ".NET Core 3.0 was announced in what year?",
                                                ".NET Core supports UWP apps.  What does UWP stand for?",
                                                "What is ASP.net?",
                                                "What license does .NET Core use?"
                                                };

            string[,] QuizQuestionOptions;
            QuizQuestionOptions = new string[10, 4] {{"A) 3.0", "B) 2.2", "C) 1.8", "D) 6.0"},
                                                   { "A) 2015", "B) 2016", "C) 2017", "D) 2018"},
                                                    { "A) .NET Cross-platform ", "B) .NET Runtime ","C) .NET Standard ", "D) .NET Common " },
                                                     { "A) Will support desktop technologies like WPF and WinForms ", "B) Support for C++ ","C) Support for Python ", "D) It will run on Linux." },
                                                     { "A) C# ", "B) F# ","C) Visual Basic ", "D) All of the above. " },
                                                     { "A) Microsoft ", "B) Google","C) Apple", "D) Canonical" },
                                                       { "A) 2018", "B) 2017","C) 2019", "D) It hasn't been announced yet" },
                                                     { "A) University of Wisconsin-Parkside", "B) UnderWater Photography","C) Universal Windows Platform", "D) Under Windows Purgatory" },
                                                         { "A) A programming language ", "B) An IDE","C) An operating system", "D) A web framework" },
                                                         { "A) MIT License", "B) Dunwoody License","C) Harvard License", "D) Cornell License" }};

            string selection;
            int start;
            int exit = -1;

            List<string> correct = new List<string>();
            List<string> wrong = new List<string>();

           
            

            

            Console.WriteLine("Welcome, this program will assess your knowledge of .NET Core");
            //Figure out
            Console.WriteLine("To get started, please press the enter key.");
            //start = Convert.ToInt32.(Console.ReadLine());

            //while(start != exit)
            {
                for(int x = 0; x < QuizQuestions.Length; x++){
                    Console.WriteLine(QuizQuestions[x]);
                        for(int i = 0; i < QuizQuestionOptions.GetLength(1); i++){
                        Console.WriteLine(QuizQuestionOptions[x, i]);
                    }


                    Console.WriteLine("Please enter an option");
                    selection = Console.ReadLine();
                    UserSelection[x] = selection;

                    //Need to determine if the user's selection is the correct answer
                    if (selection == CorrectAnswers[x])
                    {
                        correct.Add(selection);
                    }

                    else
                    {
                        wrong.Add("Question" + (x + 1) + selection);
                    }
                    
                     
                }
                Console.WriteLine("You answered " + correct.Count + " out of " + QuizQuestions.Length);

                var Results = (correct.Count >= 1) ? "You passed the assessment " : "You didn't pass ";
                Console.WriteLine(Results);

                if(wrong.Count > 0)
                {
                    Console.WriteLine("Listed below are the questions you got wrong.");
                    wrong.ForEach(x => { Console.WriteLine(x); });
                }

                wrong.Clear();
                correct.Clear();

                Console.WriteLine("To take the quiz again, enter any value other than -1.  To exit enter -1.");
                Console.Read();

            }

           

        
            
        }
    }
}
