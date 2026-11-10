using Kerem.Flashcards.Domain.Interfaces;
using Dapper;
using Kerem.Flashcards.Domain.Entities;
using Kerem.Flashcards.Infrastructure.Persistence;

namespace Kerem.Flashcards.Infrastructure.Repositories;

    public class FlashcardRepository: IFlashcardRepository
    {
        private readonly DapperDbContext _dapperDbContext;

        public FlashcardRepository(DapperDbContext dapperDbContext)
        {
            _dapperDbContext = dapperDbContext;
            
        }

        public void Create(Flashcard flashcard)
        {
            var connection = _dapperDbContext.GetConnection();
            var sql = "INSERT INTO Flashcard (name) VALUES (@Name)";
            connection.Execute(sql, flashcard);
        }

        public List<Flashcard> FindAll()
        {
            var connection = _dapperDbContext.GetConnection();
            var sql = "SELECT * FROM Flashcard";
            List<Flashcard> list = connection.Query<Flashcard>(sql).ToList();
            return list;
        }
    }