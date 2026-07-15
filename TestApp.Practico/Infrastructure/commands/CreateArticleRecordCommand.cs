using MediatR;
using TestApp.Practico.Application.DTOs;
using TestApp.Practico.Domain;

namespace TestApp.Practico.Infrastructure.commands
{
    public record CreateArticleRecordCommand(int Category, string Name, decimal Price) 
        : IRequest<ArticleRecordDto>;
    
    
}
