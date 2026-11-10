using Kerem.Flashcards.Domain.Entities;
using Kerem.Flashcards.Domain.Interfaces;
using Kerem.Flashcards.Infrastructure.Persistence;

namespace Kerem.Flashcards.Infrastructure.Repositories ;

    public class StackRepository: IStackRepository
    {

        private readonly DapperDbContext _dapperDbContext;

        public StackRepository(DapperDbContext dapperDbContext)
        {
            _dapperDbContext = dapperDbContext;
        }

        public void Create(Stack stack)
        {
            var connection = _dapperDbContext.GetConnection();
        }
    }