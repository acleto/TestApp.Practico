using TestApp.Practico.Application.DTOs;
using TestApp.Practico.Domain;

namespace TestApp.Practico.Application.Interfaces
{
    public interface IArticleRecordRepository
    {
        Task<ArticleRecordDto> CreateAsync(ArticleRecord articleRecord, CancellationToken cancellationToken);
    }
}
