﻿using System.Threading;
using WindowsInput;

namespace SimpleSpamBot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Start the program and click on the textbox in the application where you want to send the spam message
            StartSpam(1000, "Enter here your'e message");
        }

        private static void StartSpam(int count, string spamMessage)
        {
            InputSimulator input = new InputSimulator();
            Thread.Sleep(5000);

            for (int i = 0; i < count; i++) //Enter here how many times
            {
                input.Keyboard.TextEntry(spamMessage);
                input.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.RETURN);
                Thread.Sleep(400);
            }
        }
    }
}
