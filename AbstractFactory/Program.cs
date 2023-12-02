// See https://aka.ms/new-console-template for more information
using AbstractFactory;
using System;


class Program
{
    static void Main(string[] args)
    {
        //to handle exceptions that might occure
        try
        {
            //the message that marks the game start
            Console.WriteLine("----------------------------------------- STARTING GAME ------------------------------------------------\n\n\n");
            //the message that announces the first level 
            Console.WriteLine("******************************** Loading Level 1 **********************************************\n");
            //creating an instance of the Level1_SnowWhite factory
            IDisneyFactory snowwhite = new Level1_SnowWhite();
            //creating CartoonLevel object for the first level 
            GameLevel level1 = new GameLevel(snowwhite);
            //the content display
            level1.CreateLevel();

            Console.WriteLine("\n******************************** Loading Level 2 **********************************************\n");
            IDisneyFactory anastasia = new Level2_Anastasia();
            GameLevel level2 = new GameLevel(anastasia);
            level2.CreateLevel();

            Console.WriteLine("\n******************************** Loading Level 3 **********************************************\n");
            IDisneyFactory walle = new Level3_WallE();
            GameLevel level3 = new GameLevel(walle);
            level3.CreateLevel();

            Console.WriteLine("\n******************************** Loading Level 4 **********************************************\n");
            IDisneyFactory peterpan = new Level4_PeterPan();
            GameLevel level4 = new GameLevel(peterpan);
            level4.CreateLevel();

            Console.WriteLine("\n******************************** Loading Level 5 **********************************************\n");
            IDisneyFactory mulan = new Level5_Mulan();
            GameLevel level5 = new GameLevel(mulan);
            level5.CreateLevel();
            Console.WriteLine("----------------------------------------- CONGRATULATION ------------------------------------------------");
        }
        catch (Exception ex)
        {
            //in case there is an error in the game the message is displayed
            //ex Message to retrive human readable error that occured
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
        finally
        {
            //user input before closing
            Console.ReadLine();
        }
    }
}
