using Kerem.Flashcards.Features;
using Spectre.Console;

namespace Kerem.Flashcards.UI;

    public class ConsoleMenu
    {
        private readonly CreateFlashcard _createFlashcard;
        private readonly FindAllFlashcards _findAllFlashcards;

        public ConsoleMenu(CreateFlashcard createFlashcard, FindAllFlashcards findAllFlashcards)
        {
            _createFlashcard = createFlashcard;
            _findAllFlashcards = findAllFlashcards;
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
                            "1. Create a flashcard",
                            "2. Display all flashcards",
                            "3. Exit"));

                switch (choice[0])
                {
                    case '1':
                        _createFlashcard.Create();
                        break;
                    case '2':
                        _findAllFlashcards.FindAll();
                        break;
                    case '3':
                        AnsiConsole.MarkupLine("[bold green]Goodbye![/]");
                        return;
                }
            }
        }
    }
    
