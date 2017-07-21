using CommandApplication.Commands;
using CommandApplication.ControlledSystems;
using System;
using System.Collections.Generic;

namespace CommandApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var remote = new RemoteControl();
            string userInput = string.Empty;

            remote.SetCommandForButton(1, new LightsCommand(new Light()));
            remote.SetCommandForButton(2, new TvCommand(new Tv()));
            remote.SetCommandForButton(3, new MusicCommand(new Music()));
            remote.SetCommandForButton(4, new TeapotCommand(new Teapot()));

            var teapotCommand = new TeapotCommand(new Teapot());
            var tvCommand = new TvCommand(new Tv());
            var macroCommand = new MacroCommand(new List<ICommand> { teapotCommand, tvCommand });
            remote.SetCommandForButton(5, macroCommand);

            do
            {
                Console.WriteLine("Выберите вариант ниже:");
                Console.WriteLine(remote);

                Console.Write("Ваш выбор: ");
                int buttonId;
                var input = Console.ReadLine();
                int.TryParse(input, out buttonId);

                //remote.PushButton(buttonId);
                //remote.PushButton(buttonId);
                //remote.PushButton(buttonId);
                //remote.PushButton(buttonId);
                //remote.PushButton(buttonId);
                //remote.UndoButton(buttonId);
                //remote.UndoButton(buttonId);

                remote.PushButton(buttonId);
                remote.UndoButton(buttonId);

                Console.Write("Хотите продолжить (y/n)?: ");
                userInput = Console.ReadLine();
            } while (userInput == "y");
        }
    }
}
