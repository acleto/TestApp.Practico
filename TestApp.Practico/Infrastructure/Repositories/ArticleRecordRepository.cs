using Microsoft.EntityFrameworkCore;
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

        public async Task<ArticleRecordDto> CreateAsync(ArticleRecord articleRecord, CancellationToken cancellationToken)
        {

            try
            {

                await _context.Database.ExecuteSqlInterpolatedAsync(
                    $"EXEC sp_AddProductArticle {articleRecord.Category}, {articleRecord.Name}, {articleRecord.Price}",
                    cancellationToken
                );

                return new ArticleRecordDto
                {
                    Category = articleRecord.Category,
                    Name = articleRecord.Name,
                    Price = articleRecord.Price

                };


            }
            catch (Exception ex)
            {

                throw (new Exception(ex.Message));

            }

        }
    }
}
