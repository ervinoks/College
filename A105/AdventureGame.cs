﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace A105
{
    internal class AdventureGame
    {
        static void ASCIIArtOutputter(string msg)
        {
            using (StringReader reader = new StringReader(msg))
            {
                string line = string.Empty;
                do
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        Console.SetCursorPosition((200 - line.Length) / 2, Console.CursorTop);
                        Console.WriteLine(line);
                    }
                } while (line != null);
                Console.ResetColor();
            }
        }
        static void Title()
        {
            Console.ForegroundColor = ConsoleColor.White;
            string Title = @"
            \  X  / _   ) _  _   _ _   _    _)_ _                   
             \/ \/ )_) ( (_ (_) ) ) ) )_)   (_ (_)                  
                  (_                 (_                             
 __                                       ___           
 ) )     _   )    _ _(_   _)_ ( _   _     )_  o  _ ( _  
/_/ (_( )_) (    (_)  )   (_   ) ) )_)   (    ( (   ) ) 
       (_                         (_            _)     ";
            ASCIIArtOutputter(Title);
        }
        static int itemNum = -1;
        static double money = 0;
        static void House()
        {
            string House = @"
(')) ^v^  _           (`)_
(__)_) ,--j j-------, (__)_)
      /_.-.___.-.__/ \
    ,8| [_],-.[_] | oOo
,,,oO8|_o8_|_|_8o_|&888o,,,
";
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            ASCIIArtOutputter(House);
            string welcomeMessage = "You are in your cottage, it's small but cozy.";
            string provokeChoices = "There are 3 items you can bring with you along for your journey for the day.";
            Console.WriteLine(welcomeMessage.PadLeft(100 + welcomeMessage.Length / 2));
            Console.WriteLine(provokeChoices.PadLeft(100 + provokeChoices.Length / 2));
            string[] items = { "[ ] Fishing Rod", "[ ] Knife", "[ ] Wallet" };
            Choosing(items);
            Console.Clear();
            switch (userChoice)
            {
                case 0:
                    Console.WriteLine("You have chosen the fishing rod.");
                    itemNum = 0;
                    break;
                case 1:
                    Console.WriteLine("You have chosen the knife.");
                    itemNum = 1;
                    break;
                case 2:
                    Console.WriteLine("You have chosen the wallet.");
                    money = 20;
                    Thread.Sleep(2000);
                    Console.WriteLine("You have £" + String.Format("{0:0.00}", money) + " to spend.");
                    itemNum = 2;
                    break;
            }
            Thread.Sleep(2000);
        }
        static void Paths()
        {
            Console.Write("You are now at the crossroads outside the house, where do you want to go? Left or right? ");
            string choice = Console.ReadKey(true).Key.ToString();
            switch (choice)
            {
                case "LeftArrow":
                    Console.WriteLine("You went left.");
                    leftPath();
                    break;
                case "RightArrow":
                    Console.WriteLine("You went right.");
                    rightPath();
                    break;
            }
        }
        static int userChoice;
        static Random rand = new Random();
        static void leftPath()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            string lake = (@"
▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒
▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒
▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒
▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒
▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒
▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒
▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░▒▒▒▒▒▒▒▒▒▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒
▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒
▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░▒▒▒▒░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒▓▓░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░▒▒░░▒▒▒▒▒▒▒▒▒▒░░░░░░▒▒▒▒▒▒▒▒▒▒▓▓▓▓▒▒▒▒▒▒██▓▓░░▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒
      ▒▒▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  ▒▒▒▒▒▒▒▒░░░░░░▒▒▒▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░▒▒▒▒▓▓▒▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░▒▒▒▒▒▒▒▒▒▒░░▒▒▒▒
        ░░░░░░▓▓  ░░░░      ░░▒▒    ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░▒▒▒▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░▒▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░▒▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒
                            ░░          ░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██▓▓▒▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒▒░░▒▒
                                      ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░▒▒▒▒▒▒▒▒▓▓▒▒▒▒▒▒██▒▒░░▒▒▒▒▒▒▒▒  ▒▒▒▒▒▒░░▒▒▒▒▒▒▒▒░░░░░░░░      
              ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒  ▒▒▒▒▒▒▒▒  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░▒▒▒▒▓▓▒▒▒▒▓▓██████▓▓░░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░            
      ▒▒▒▒▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░  ▓▓▒▒▒▒▒▒▒▒▒▒▒▒░░  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒▒▒░░▓▓████▓▓▓▓░░        ░░░░            ░░            
  ▒▒▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▒▒▒▒▒▒▓▓██████▓▓░░        ░░░░    ░░░░░░                
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▒▒▓▓██▓▓██▓▓▒▒░░░░░░      ░░░░░░░░░░░░  ░░          
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓██▓▓▓▓▓▓░░░░░░░░░░░░░░░░░░░░░░  ░░░░░░░░▒▒▒▒    
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒▒▒▒▒▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓████▓▓██▓▓▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒▒▒▒▒▒▒▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓████████████▒▒░░░░▓▓▓▓░░░░░░░░░░░░░░▒▒▓▓▒▒▒▒▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓████████████▒▒▒▒░░▓▓▒▒░░░░░░░░░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓████████████▓▓▒▒▒▒▒▒▒▒░░░░░░░░▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓████▓▓▓▓▓▓▒▒▒▒▒▒▒▒░░░░░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒████▓▓▓▓▓▓████▓▓▓▓▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓▓▓▒▒▒▒▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒████████▓▓████████▒▒▒▒▒▒▓▓▓▓▓▓▓▓▒▒▒▒▓▓▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██████████▓▓████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░░░░░░░░░░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒
▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▓▓▓▓▓▓
▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▓▓▓▓▓▓▓▓
▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓▓▓▓▓▓▓▓▓
▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
▓▓▓▓▒▒▒▒▓▓▒▒▓▓▓▓▓▓▓▓▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒░░░░░░░░░░░░░░░░░░░░  ▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒░░▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
▓▓▓▓▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▓▓░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▓▓▓▓▓▓░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒▓▓▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒▒▒
████████████▓▓▓▓▓▓▓▓▒▒▒▒▒▒▓▓▓▓▓▓▒▒▓▓▓▓▓▓▓▓▓▓▒▒▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░  ▓▓▒▒▒▒░░░░░░░░░░▓▓░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒▒▒▒▒▒▒
██████████████████████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒██▓▓▒▒▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒▓▓▒▒▓▓▓▓
██████████████████████████████████████████▓▓▓▓▓▓▓▓▓▓██▓▓▒▒▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒▓▓▒▒▓▓▓▓▒▒
████▓▓██████████████████████████████████████████████░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒▓▓▓▓▓▓▒▒▒▒▓▓▓▓▓▓▓▓
████████▓▓██████████████████████████████████████▓▓▓▓░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒▒▒▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓▓████████████████████████████████████████▓▓▓▓▓▓▓▓▓▓▓▓██▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓
████████████████████████████████████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
██████████████████████████████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░░░░░░░░░░░░░░░▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▓▓▓▓▓▓▓▓▓▓▓▓▒▒▓▓▓▓▓▓▓▓▓▓
████████████████████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▓▓▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒
██████████████████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒
██████████████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▓▓▒▒▒▒
██████████████████████████▓▓▓▓▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▓▓▓▓▓▓▓▓▓▓▓▓████████████▓▓▓▓▓▓▓▓▓▓▓▓▒▒▓▓▓▓▓▓▓▓▓▓▒▒▒▒
██████████████████████████████████▓▓▓▓▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▓▓▓▓▓▓▓▓▓▓▓▓████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▓▓▓▓▓▓▓▓▓▓▓▓
████████████████▓▓████████████████████▓▓▓▓▓▓▓▓▓▓▓▓▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▓▓▓▓▓▓██▓▓▓▓
██████████▓▓████████▓▓██████▓▓▓▓▓▓▓▓▓▓▓▓▒▒▓▓▓▓▒▒▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓████▓▓▓▓▓▓
████████████████████████████▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓████████████████████
████████████████████████████▓▓██▓▓████▓▓▓▓▓▓▓▓▒▒▒▒▒▒▓▓▓▓▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓██████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓████▓▓▓▓▓▓██████████████████████
██████▓▓▓▓████████████████████████████████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓████████████████████████▓▓▓▓██████████████████████████████████████████████████▓▓▓▓▓▓
");
            ASCIIArtOutputter(lake);
            Thread.Sleep(4000);
            Console.ResetColor();
            Console.Clear();
            Console.WriteLine("You come across the lake.");
            Thread.Sleep(1000);
            switch (itemNum)
            {
                case 0:
                    Console.WriteLine("You pull out your fishing rod, and begin to fish.");
                    int bass = 0;
                    int trout = 0;
                    int pike = 0;
                    int carp = 0;
                    for (int i = 0; i < 5; i++)
                    {
                        bool fishLost = false;
                        int fish = rand.Next(1, 11);
                        switch (fish)
                        {
                            case 1:
                            case 2:
                            case 3:
                                Console.WriteLine("You caught a sturgeon bass!");
                                bass += 1;
                                break;
                            case 4:
                            case 5:
                            case 6:
                                Console.WriteLine("You caught a trout!");
                                trout += 1;
                                break;
                            case 7:
                            case 8:
                                Console.WriteLine("You caught a northern pike!");
                                pike += 1;
                                break;
                            case 9:
                                Console.WriteLine("You caught a crucian carp!");
                                carp += 1;
                                break;
                            case 10:
                                Console.WriteLine("The Loch Ness latches onto the hook. You feel a stong tug on your rod.");
                                int luck = rand.Next(1, 6);
                                if (luck == 5)
                                {
                                    Console.WriteLine("You manage to keep your balance, and you let go of the fishing rod, staying alive, but all your fish are taken.");
                                    fishLost = true;
                                    i = 3;
                                }
                                break;
                        }
                        if (fishLost == true)
                        { 
                            Thread.Sleep(1000);
                            Console.WriteLine("You head further from the lake, to sell the fish you've caught.");
                            Thread.Sleep(1000);
                            Console.WriteLine("You sell the fish!");
                            double total = bass * 5 + trout * 3 + pike * 7 + carp * 10;
                            Console.WriteLine("You got £" + String.Format("{0:0.00}", total) + "!");
                            Thread.Sleep(1000);
                            Console.WriteLine("You head back and collect your wallet, to head down the right path.");
                            money += total;
                            Thread.Sleep(1000);
                            Console.WriteLine("You now have £" + String.Format("{0:0.00}", money) + "!");
                            rightPath();
                        }

                    }
                    break;
                case 1:
                    Console.WriteLine("You walk past the lake, as you didn't bring the rod, and you follow the path until a hooded figure approaches.");
                    Thread.Sleep(3000);
                    Console.WriteLine("The figure pulls a baton out on you, attempting to rob you!");
                    Thread.Sleep(2000);
                    Console.WriteLine("You tell him that you have nothing on you. He insists.");
                    Thread.Sleep(1000);
                    Console.WriteLine("Do you run, fight or surrender your clothes?");
                    string[] choicesKnife = { "[ ] Run away", "[ ] Fight", "[ ] Surrender" };
                    Choosing(choicesKnife);
                    Console.Clear();
                    switch (userChoice)
                    {
                        case 0:
                            Console.WriteLine("You try to run, but you feel the baton plummet into the back of skull. You are concussed.");
                            Thread.Sleep(2000);
                            Console.WriteLine("While you are concussed, he proceeds to rob all your belongs, and drown you in the lake.");
                            Thread.Sleep(500);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("R.I.P. Better luck not dying.");
                            Console.ReadKey();
                            Environment.Exit(0);
                            break;
                        case 1:
                            Console.WriteLine("You stab the figure in the stomach, leaving him incapacitated on the ground.");
                            Thread.Sleep(1000);
                            Console.WriteLine("In fear of getting caught, you run back to the house to avoid murder.");
                            Thread.Sleep(500);
                            Console.WriteLine("Congratulations. You killed someone. You tell me if you won or lost.");
                            Thread.Sleep(500);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Game over, you got nothing done today. And you committed a crime.");
                            Console.ReadKey();
                            Environment.Exit(0);
                            break;
                        case 2:
                            Console.WriteLine("You strip to your undergarments, and hand them your rags.");
                            Thread.Sleep(500);
                            Console.WriteLine("You also surrender your knife.");
                            Thread.Sleep(500);
                            Console.WriteLine("You do the walk of shame and return home, with nothing left.");
                            Thread.Sleep(500);
                            Console.WriteLine("Game over, you got nothing done today. And you lost your clothes.");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.ReadKey();
                            Environment.Exit(0);
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("You walk past the lake, as you didn't bring the rod, and you follow the path until a hooded figure approaches.");
                    Thread.Sleep(3000);
                    Console.WriteLine("The figure pulls a baton out on you, attempting to rob you!");
                    Thread.Sleep(2000);
                    Console.WriteLine("Do you run away, tell him you have nothing, or surrender your wallet?");
                    string[] choicesWallet = { "[ ] Run away", "[ ] Lie", "[ ] Surrender" };
                    Choosing(choicesWallet);
                    Console.Clear();
                    switch (userChoice)
                    {
                        case 0:
                            Console.WriteLine("You try to run, but you feel the baton plummet into the back of skull. You are concussed.");
                            Thread.Sleep(2000);
                            Console.WriteLine("While you are concussed, he proceeds to rob all your belongs, including your wallet, and drown you in the lake.");
                            Thread.Sleep(500);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("R.I.P. Better luck not dying.");
                            Console.ReadKey();
                            Environment.Exit(0);
                            break;
                        case 1:
                            Console.WriteLine("You lie and tell them you have nothing to give.");
                            Thread.Sleep(1000);
                            Console.WriteLine("Luckily, they believe you. And proceed to escape.");
                            Thread.Sleep(500);
                            Console.WriteLine("You decide to head back to the house, and instead go right from the crossroads.");
                            rightPath();
                            break;
                        case 2:
                            Console.WriteLine("You hand over your wallet.");
                            Thread.Sleep(500);
                            Console.WriteLine("He proceeds to slowly back away from you, then sprint.");
                            Thread.Sleep(500);
                            Console.WriteLine("You do the walk of shame and return home, with nothing left.");
                            Thread.Sleep(500); 
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Game over, you got nothing done today. And you got robbed.");
                            Console.ReadKey();
                            Environment.Exit(0);
                            break;
                    }
                    break;
            }
        }
        static void rightPath()
        {
            Console.WriteLine("You approach the casino! A place to gamble your money.");
            switch (itemNum)
            {
                case 1:
                    Console.WriteLine("However, you decided not to bring your wallet with you, so you head back, and go down the left path.");
                    Thread.Sleep(4000);
                    leftPath();
                    break;
                case 0:
                case 2:
                    Console.WriteLine("You head into the casino, to play some blackjack.");
                    Thread.Sleep(1000);
                    Console.WriteLine("To play blackjack, you keep collecting cards until you reach 21, or higher than the dealer.");
                    Thread.Sleep(500);
                    Console.WriteLine("Bet however much you want, and bet 0 to go back home.");
                    double bet = -1;
                    do
                    {
                        bool split = false;
                        bet = double.Parse(Console.ReadLine());
                        List<int> house = new List<int>();
                        house.Add(rand.Next(1, 11));
                        house.Add(rand.Next(1, 11));
                        List<int> user = new List<int>();
                        user.Add(rand.Next(1, 11));
                        user.Add(rand.Next(1, 11));
                        int houseTotal = house[0] + house[1];
                        int userTotal = user[0] + user[1];
                        int user1Total = 0;
                        int user2Total = 0;
                        double bet1 = 0;
                        double bet2 = 0;
                        Console.WriteLine($"Your hand is {user[0]} and {user[1]}, totalling {userTotal}, and the house card is {house[0]}.");
                        string userOutput = $"Your hand is {user[0]}";
                        bool gameOver = false;
                        string dealerOutput = $"Dealer's hand is {house[0]}";
                        if (user[0] == user[1]) { Console.WriteLine("Do you wish to split or hit or stand?"); }
                        else { Console.WriteLine("Do you wish to hit or stand?"); }
                        do
                        {
                            for (int i = 2; i < 11; i++)
                            {
                                string input = Console.ReadLine().ToLower();
                                switch (input)
                                {
                                    case "hit":
                                        user.Add(rand.Next(1, 11));
                                        userTotal += user[i];
                                        userOutput += $", and {user[i]}";
                                        Console.WriteLine($"{userOutput}, totalling {userTotal}");
                                        Thread.Sleep(1000);
                                        if (userTotal > 21) { Console.WriteLine("You busted, and lost your bet."); }
                                        else if (userTotal == 21) { Console.WriteLine("You got blackjack, and won 1.5x your bet."); bet *= 1.5; }
                                        else { Console.WriteLine("Do you wish to hit or stand?"); }
                                        break;
                                    case "stand":
                                        userOutput += $", totalling {userTotal}";
                                        gameOver = true;
                                        break;
                                    case "split":
                                        split = true;
                                        Console.WriteLine("You've split your hands into 2, and doubled your bet.");
                                        List<int> user1 = new List<int>();
                                        user1Total = 0;
                                        string user1Output = $"Your hand is {user1[0]}";
                                        bool user1gameOver = false;
                                        bet1 = bet;
                                        List<int> user2 = new List<int>();
                                        user2.Add(user[1]);
                                        user2Total = 0;
                                        string user2Output = $"Your hand is {user2[0]}";
                                        bool user2gameOver = false;
                                        bet2 = bet;
                                        do
                                        {
                                            string split1Input = Console.ReadLine().ToLower();
                                            user1.Add(user[0]);
                                            switch (split1Input)
                                            {
                                                case "hit":
                                                    for (int j = 2; j < 11; j++)
                                                    {
                                                        user1.Add(rand.Next(1, 11));
                                                        user1Total += user[j];
                                                    }
                                                    user1Output += $", and {user1[i]}";
                                                    Console.WriteLine($"{user1Output}, totalling {user1Total}");
                                                    Thread.Sleep(1000);
                                                    if (user1Total > 21) { Console.WriteLine("You busted, and lost your bet."); }
                                                    else if (user1Total == 21) { Console.WriteLine("You got blackjack, and won 1.5x your bet."); bet1 *= 1.5; }
                                                    else { Console.WriteLine("Do you wish to hit or stand?"); }
                                                    break;
                                                case "stand":
                                                    user1Output += $", totalling {user1Total}";
                                                    user1gameOver = true;
                                                    break;
                                            }
                                        } while (user1gameOver == false);
                                        do
                                        {
                                            string split2Input = Console.ReadLine().ToLower();
                                            user1.Add(user[0]);
                                            switch (split2Input)
                                            {
                                                case "hit":
                                                    for (int j = 2; j < 11; j++)
                                                    {
                                                        user2.Add(rand.Next(1, 11));
                                                        user2Total += user[j];
                                                    }
                                                    user2Output += $", and {user2[i]}";
                                                    Console.WriteLine($"{user2Output}, totalling {user2Total}");
                                                    Thread.Sleep(1000);
                                                    if (user2Total > 21) { Console.WriteLine("You busted, and lost your bet."); }
                                                    else if (user2Total == 21) { Console.WriteLine("You got blackjack, and won 1.5x your bet."); bet2 *= 1.5; }
                                                    else { Console.WriteLine("Do you wish to hit or stand?"); }
                                                    break;
                                                case "stand":
                                                    user2Output += $", totalling {user2Total}";
                                                    user2gameOver = true;
                                                    gameOver = true;
                                                    break;
                                            }
                                        } while (user2gameOver == false);
                                        Console.WriteLine();
                                        break;
                                }
                            }
                                for (int j = 2; j < 11; j++)
                            {
                                house.Add(rand.Next(1, 11));
                                houseTotal += house[j];
                                if (houseTotal >= 17) { break; }
                            }
                        } while (gameOver == false);
                        if (split == true)
                        {
                            if (user1Total < houseTotal) { Console.WriteLine($"You lost your first hand, and lost £{bet1}."); money -= bet1; }
                            else if (user1Total > houseTotal) { Console.WriteLine($"You won your first hand, and won £{bet1}."); money += bet1; }
                            else { Console.WriteLine($"You tied your first hand, and kept your £{bet1}"); }
                            if (user2Total < houseTotal) { Console.WriteLine($"You lost your second hand, and lost £{bet2}."); money -= bet2; }
                            else if (user2Total > houseTotal) { Console.WriteLine($"You won your second hand, and won £{bet2}."); money += bet2; }
                            else { Console.WriteLine($"You tied your second hand, and kept your £{bet2}"); }
                        }
                        else
                        {
                            if (userTotal < houseTotal) { Console.WriteLine($"You lost your bet of £{bet}."); }
                            else if (userTotal > houseTotal) { Console.WriteLine($"You won your bet of £{bet}."); money += bet * 2; }
                            else { Console.WriteLine($"You tied with the dealer, and got your bet of £{bet} back."); money += bet; }
                        }
                        for (int j = 2; j < 11; j++) { dealerOutput += $", and {house[j]}"; }
                        dealerOutput += $", resulting in {houseTotal}";
                        Console.WriteLine(dealerOutput);
                    } while (bet != 0);
                    break;
            }
        }
        static void Choosing(string[] choices)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 16);
            Console.Write($"{choices[0].PadLeft(100 - choices[0].Length)} {choices[1].PadLeft(20)} {choices[2].PadLeft(20)}");
            int begin1 = 100 - choices[0].Length * 2;
            int end1 = begin1 + choices[0].Length;
            int end2 = 1 + end1 + 20;
            int begin2 = end2 - choices[1].Length;
            int end3 = 1 + end2 + 20;
            int begin3 = end3 - choices[2].Length;
            bool selected = false;
            int pos = 0;
            Console.SetCursorPosition(begin1, 16);
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write(choices[0]);
            do
            {
                string choice = Console.ReadKey(true).Key.ToString();
                switch (choice)
                {
                    case "LeftArrow":
                        if (pos != 0) { pos--; }
                        break;
                    case "RightArrow":
                        if (pos != 2) { pos++; }
                        break;
                    case "Enter":
                        selected = true;
                        break;
                }
                Console.SetCursorPosition(0, 16);
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"{choices[0].PadLeft(100 - choices[0].Length)} {choices[1].PadLeft(20)} {choices[2].PadLeft(20)}");
                switch (pos)
                {
                    case 0:
                        Console.SetCursorPosition(begin1, 16);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Write(choices[0]);
                        if (selected == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.SetCursorPosition(1 + begin1, 16);
                            Console.Write("x");
                            Thread.Sleep(200);
                            userChoice = 0;
                        }
                        break;
                    case 1:
                        Console.SetCursorPosition(begin2, 16);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Write(choices[1]);
                        if (selected == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.SetCursorPosition(1 + begin2, 16);
                            Console.Write("x");
                            Thread.Sleep(200);
                            userChoice = 1;
                        }
                        break;
                    case 2:
                        Console.SetCursorPosition(begin3, 16);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Write(choices[2]);
                        if (selected == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.SetCursorPosition(1 + begin3, 16);
                            Console.Write("x");
                            Thread.Sleep(200);
                            userChoice = 2;
                        }
                        break;
                }
                Console.SetCursorPosition(195, 50);
            } while (selected != true);
            Console.ResetColor();
        }
        static void Main(string[] args)
        {
            Console.SetWindowSize(200, 55);
            Title();
            House();
            Console.Clear();
            Paths();
            //string rows = "Row 1\r\nRow 2\r\nRow 3";
            //Console.WriteLine(rows);
            Console.ReadKey();
        }
    }
}                                                    