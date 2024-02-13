using JsonTestAPI.Core.Entities;
using JsonTestAPI.Core.Enum;
using JsonTestAPI.Core.Extensions;
using JsonTestAPI.Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace JsonTestAPI.Controllers
{
    public class JsonData1
    {
        public class Command : IRequest<IEnumerable<JsonDataTest1>>
        {
            public string Filter { get; set; }
            public List<string> MultipleFilter { get; set; }


            public FillerEnum? FilterEnum { get; set; }

            public List<FillerEnum> MultipleFilterEnum { get; set; }
        }

        public class Handler : IRequestHandler<Command, IEnumerable<JsonDataTest1>>
        {
            private readonly ApplicationDbContext _dbContext;

            public Handler(ApplicationDbContext dbContext)
            {
                _dbContext = dbContext;
            }

            public async Task<IEnumerable<JsonDataTest1>> Handle(Command request, CancellationToken cancellationToken)
            {
                var response = await _dbContext.JsonDataTest1
                    //.WhereIf(request.Filter, d => d.DataProperty.Any(e => e == request.Filter)) // works as intended
                    .WhereIf(request.Filter, d => d.DataProperty.Contains(request.Filter)) // 0 results if the string only partially matches

                    //.WhereIf(request.MultipleFilter, d => request.MultipleFilter.Any(e => d.DataProperty.Contains(e))) // 0 results if the string only partially matches
                    //.WhereIf(request.MultipleFilter, d => d.DataProperty.Any(e => request.MultipleFilter.Contains(e))) // 0 results if the string only partially matches
                    //.WhereIf(request.MultipleFilter, d => request.MultipleFilter.Any(e => d.DataProperty.Contains(e))) // 0 results if the string only partially matches
                    //.WhereIf(request.MultipleFilter, d => d.DataProperty.Any(e => request.MultipleFilter.Contains(e))) // 0 results if the string only partially matches

                    //.WhereIf(request.MultipleFilter, d => request.MultipleFilter.Any(e => d.DataProperty.Any(f => f == e))) // works as intended
                    //.WhereIf(request.MultipleFilter, d => d.DataProperty.Any(e => request.MultipleFilter.Any(f => f == e))) // works as intended

                    //.WhereIf(request.FilterEnum, d => d.DataEnumProperty.Any(e => e == request.FilterEnum)) // translation exception
                    //.WhereIf(request.FilterEnum, d => d.DataEnumProperty.Contains(request.FilterEnum)) // translation exception
                    .ToListAsync(cancellationToken);

                return response;
            }
        }
    }
}