using Kerem.Flashcards.Domain.Entities;
using Kerem.Flashcards.Domain.Interfaces;

namespace Kerem.Flashcards.Features ;

    public class CreateFlashcard
    {
        private readonly IFlashcardRepository _flashcardRepository;

        public CreateFlashcard(IFlashcardRepository flashcardRepository)
        {
            _flashcardRepository = flashcardRepository;
        }

        public void Create()
        {
            Flashcard flashcard = new Flashcard();
            flashcard.Name = "Testcard";
            _flashcardRepository.Create(flashcard);
        }
    }