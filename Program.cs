class File_I_O
{
    public static void Main(string[] args)
    {
        string fileName = "history.txt";

        while (true)
        {
            try
            {
                Console.WriteLine("\n1. View File");
                Console.WriteLine("2. Add Text");
                Console.WriteLine("3. Exit");
                Console.Write("Choose Option: ");

                string mainInput = Console.ReadLine() ?? "";
                int choice;

                if (!int.TryParse(mainInput, out choice))
                {
                    Console.WriteLine("Error: Please Enter Number Only!");
                    continue;
                }

                // VIEW FILE
                if (choice == 1)
                {
                    if (File.Exists(fileName))
                    {
                        string[] lines = File.ReadAllLines(fileName);

                        Console.WriteLine("\n===== FILE CONTENT =====\n");

                        foreach (string line in lines)
                        {
                            Console.WriteLine(line);
                        }
                    }
                    else
                    {
                        Console.WriteLine("File does not exist!");
                    }
                }

                // ADD TEXT
                else if (choice == 2)
                {
                    Console.Write("Enter Text: ");
                    string text = Console.ReadLine() ?? "";

                    List<string> data = new List<string>();
                    data.Add(text);

                    while (true)
                    {
                        Console.WriteLine("\n1. Replace Old Data");
                        Console.WriteLine("2. Add With Old Data");
                        Console.WriteLine("3. Exit");
                        Console.Write("Choose: ");

                        string input = Console.ReadLine() ?? "";
                        int option;

                        if (!int.TryParse(input, out option))
                        {
                            Console.WriteLine("Error: Please Enter Number Only!");
                            continue;
                        }

                        if (option == 1)
                        {
                            File.WriteAllLines(fileName, data);
                            Console.WriteLine("Old Data Replaced!");
                            break;
                        }
                        else if (option == 2)
                        {
                            File.AppendAllLines(fileName, data);
                            Console.WriteLine("New Data Added!");
                            break;
                        }
                        else if (option == 3)
                        {
                            Console.WriteLine("Exited Without Saving!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Option! Please Select 1, 2 or 3.");
                        }
                    }
                }

                // EXIT PROGRAM
                else if (choice == 3)
                {
                    Console.WriteLine("Program Closed!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Option! Please Select 1, 2 or 3.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
