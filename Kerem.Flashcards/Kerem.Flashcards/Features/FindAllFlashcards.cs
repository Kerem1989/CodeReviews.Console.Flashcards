using Kerem.Flashcards.Domain.Interfaces;
using Kerem.Flashcards.Infrastructure.Repositories;

namespace Kerem.Flashcards.Features ;

    public class FindAllFlashcards
    {
        private readonly IFlashcardRepository _flashcardRepository;

        public FindAllFlashcards(IFlashcardRepository flashcardRepository)
        {
            _flashcardRepository = flashcardRepository;
        }

        public void FindAll()
        {
            var list = _flashcardRepository.FindAll();
            foreach (var flashcard in list)
            {
                Console.WriteLine(flashcard.Name);
            }
        }
    }