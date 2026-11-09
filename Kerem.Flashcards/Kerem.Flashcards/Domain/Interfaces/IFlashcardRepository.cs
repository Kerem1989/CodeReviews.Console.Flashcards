using Kerem.Flashcards.Domain.Entities;

namespace Kerem.Flashcards.Domain.Interfaces ;

    public interface IFlashcardRepository
    {
        void Create(Flashcard flashcard);
    }