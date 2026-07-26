using MediatR;
using TestApp.Practico.Application.DTOs;
using TestApp.Practico.Application.Interfaces;
using TestApp.Practico.Domain;
using TestApp.Practico.Infrastructure.commands;

namespace TestApp.Practico.Application.Handlers
{
    public class CreateArticleRecordHandler
        : IRequestHandler<CreateArticleRecordCommand, ArticleRecordDto>
    {

        private readonly IArticleRecordRepository _repository;

        public CreateArticleRecordHandler(IArticleRecordRepository repository)
        {
            _repository = repository;
        }
        public async Task<ArticleRecordDto> Handle(CreateArticleRecordCommand request, CancellationToken cancellationToken)
        {
            var articleRecord = new ArticleRecord
            {
                Category = request.Category,
                Name = request.Name,
                Price = request.Price,
            };

            var result = await _repository.CreateAsync(articleRecord,cancellationToken);

            return  new ArticleRecordDto { 

                Category= result.Category,
                Name = result.Name,
                Price = result.Price,
            };
        }
    }
}
