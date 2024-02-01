using System;

class Program
{
    static void Main(string[] args)
    {
        string text = "And now that my soul might have joy in you and that my heart might leave this world with gladness because of you that I might not be brought down with grief and sorrow to the grave arise from the dust my sons and be men and be determined in one mind and in one heart united in all things that ye may not come down into captivity";
        string book = "2 Nephi";
        int chapter = 1;
        int verse = 21;
        int ScriptureCount = 68;
        string UpdatedScripture;
        string option = "";

        Reference reference = new(book, chapter, verse);
        Scripture scripture = new(reference, text);
        
        Console.WriteLine($"Hello! Get ready to memorize a scripture! We will be working on memorizing {book} {chapter}:{verse}. Take some time to read the verse and then press enter to change a few words to blanks. Press enter again for a few more to be changed. You will be able to continue doing this until every word is blank or you may type quit to end the program.");
        
        while(option != "quit")        
        {
            switch(option)
            {
                case "":
                    Console.Clear();
                    UpdatedScripture = scripture.GetDisplayText();
                    Console.WriteLine(reference.GetDisplayText());
                    Console.WriteLine(UpdatedScripture);
                    Console.WriteLine("Press enter to erase more words or type 'quit' to exit.");
                    Console.ReadLine();
                    scripture.HideRandomWords(ScriptureCount);
                    break;
                default:
                    Console.WriteLine("Invalid Input.");
                    break;
            }
        }
        


        
        
        
    }
}