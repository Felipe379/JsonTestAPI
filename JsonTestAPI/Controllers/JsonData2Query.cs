using JsonTestAPI.Core.Entities;
using JsonTestAPI.Core.Enum;
using JsonTestAPI.Core.Extensions;
using JsonTestAPI.Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace JsonTestAPI.Controllers
{
    public class JsonData2Query
    {
        public class Command : IRequest<IEnumerable<JsonDataTest2Query>>
        {
            public string Filter { get; set; }
            public List<string> MultipleFilter { get; set; }


            public FillerEnum? FilterEnum { get; set; }

            public List<FillerEnum> MultipleFilterEnum { get; set; }
        }

        public class Handler : IRequestHandler<Command, IEnumerable<JsonDataTest2Query>>
        {
            private readonly ApplicationDbContext _dbContext;

            public Handler(ApplicationDbContext dbContext)
            {
                _dbContext = dbContext;
            }

            public async Task<IEnumerable<JsonDataTest2Query>> Handle(Command request, CancellationToken cancellationToken)
            {
                var response = await _dbContext.JsonDataTest2Query
                    .WhereIf(request.Filter, d => d.ComplexSerializedData1.StringFillerProperty1.Contains(request.Filter)) // no query with json will ever work
                    .ToListAsync(cancellationToken);

                return response;
            }
        }
    }
}