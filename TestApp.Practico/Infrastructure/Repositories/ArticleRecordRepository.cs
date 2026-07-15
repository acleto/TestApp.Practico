using TestApp.Practico.Application.DTOs;
using TestApp.Practico.Application.Interfaces;
using TestApp.Practico.Domain;
using TestApp.Practico.Infrastructure.Data;

namespace TestApp.Practico.Infrastructure.Repositories
{
    public class ArticleRecordRepository : IArticleRecordRepository
    {
        private readonly ApplicationDbContext _context;
        public ArticleRecordRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ArticleRecordDto> CreateAsync(ArticleRecord articleRecord,CancellationToken cancellationToken)
        {
            await _context.ArticleRecord.AddAsync(articleRecord ,  cancellationToken);

            await _context.SaveChangesAsync(cancellationToken);

            return new ArticleRecordDto();
        }
    }
}
