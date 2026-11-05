using Kerem.Flashcards.Domain.Interfaces;

namespace Kerem.Flashcards.Features ;

    public class CreateFlashcard
    {
        private readonly IFlashcardRepository _flashcardRepository;

        public CreateFlashcard(IFlashcardRepository flashcardRepository)
        {
            _flashcardRepository = flashcardRepository;
        }

        void Create()
        {
        }
    }