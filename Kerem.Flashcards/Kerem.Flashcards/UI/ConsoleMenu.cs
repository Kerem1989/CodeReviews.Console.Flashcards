using System.Drawing;
using Kerem.Flashcards.Features;
using Spectre.Console;
using Color = System.Drawing.Color;

namespace Kerem.Flashcards.UI;

    public class ConsoleMenu
    {
        private readonly CreateFlashcard _createFlashcard;

        public ConsoleMenu(CreateFlashcard createFlashcard)
        {
            _createFlashcard = createFlashcard;
        }

        public void Menu()
        {
            AnsiConsole.Write(new FigletText("Flashcard App"));
            while (true)
            {
                string choice = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                        .Title("Please select an [bold steelblue]option[/]:")
                        .AddChoices(
                            "1. Create a coding session",
                            "2. Exit"));

                switch (choice[0])
                {
                    case '1':
                        _createFlashcard.Create();
                        break;
                    case '2':
                        AnsiConsole.MarkupLine("[bold green]Goodbye![/]");
                        return;
                }
            }
        }
    }
    
