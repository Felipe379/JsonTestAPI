using JsonTestAPI.Core.Entities;
using JsonTestAPI.Core.Enum;
using JsonTestAPI.Core.Extensions;
using JsonTestAPI.Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace JsonTestAPI.Controllers
{
    public class JsonData2
    {
        public class Command : IRequest<IEnumerable<ComplexSerializedData1Response>>
        {
            public string Filter { get; set; }
            public List<string> MultipleFilter { get; set; }


            public FillerEnum? FilterEnum { get; set; }

            public List<FillerEnum> MultipleFilterEnum { get; set; }


            public int? FilterInt { get; set; }

            public List<int> MultipleFilterInt { get; set; }
        }

        public class JsonDataTest2Response
        {
            public int Id { get; set; }

            public ComplexSerializedData1Response ComplexSerializedData1 { get; set; }
            public List<ComplexSerializedData1Response> MultipleComplexSerializedData1 { get; set; }
        }

        public class ComplexSerializedData1Response
        {
            public int Id { get; set; }

            public int IntFillerProperty { get; set; }
            public string StringFillerProperty1 { get; set; }
            public DateTimeOffset? DateTimeOffsetFillerProperty1 { get; set; }
            public DateTime? DateTimeFillerProperty1 { get; set; }
            public FillerEnum? FillerEnumString1 { get; set; }
            public FillerEnum? FillerEnumInt1 { get; set; }
            public List<int> FillerInt { get; set; } = new();
        }



        public class Handler : IRequestHandler<Command, IEnumerable<ComplexSerializedData1Response>>
        {
            private readonly ApplicationDbContext _dbContext;

            public Handler(ApplicationDbContext dbContext)
            {
                _dbContext = dbContext;
            }

            public async Task<IEnumerable<ComplexSerializedData1Response>> Handle(Command request, CancellationToken cancellationToken)
            {
                var response = await _dbContext.JsonDataTest2
                    .WhereIf(request.Filter, d => d.ComplexSerializedData1.StringFillerProperty1.Contains(request.Filter)) // works as intended
                    //.WhereIf(request.FilterInt, d => d.ComplexSerializedData1.FillerInt.Any(e => e == request.FilterInt)) // works as intended
                    //.WhereIf(request.FilterEnum, d => d.ComplexSerializedData1.FillerEnumString1 == request.FilterEnum.Value) // works as intended
                    //.WhereIf(request.FilterEnum, d => d.ComplexSerializedData1.FillerEnumInt1 == request.FilterEnum.Value) // works as intended
                    //.WhereIf(request.Filter, d => request.MultipleFilter.Any(e => d.ComplexSerializedData1.StringFillerProperty1.Contains(e))) // work as intended
                    //.WhereIf(request.Filter, d => request.MultipleFilterEnum.Any(e => d.ComplexSerializedData1.FillerEnumInt1 == e)) // work as intended
                    //.WhereIf(request.Filter, d => request.MultipleFilterEnum.Any(e => d.ComplexSerializedData1.FillerEnumString1 == e)) // work as intended
                    //.WhereIf(request.Filter, d => d.MultipleComplexSerializedData1.Any(e => e.StringFillerProperty1.Contains(request.Filter))) // work as intended
                    //.WhereIf(request.Filter, d => d.MultipleComplexSerializedData1.Any(e => e.StringFillerProperty1 == request.Filter)) // work as intended
                    .SelectMany(d => d.MultipleComplexSerializedData2.Select(e => new ComplexSerializedData1Response
                        {
                            Id = d.Id,
                            IntFillerProperty = e.IntFillerProperty,
                            StringFillerProperty1 = e.StringFillerProperty1,
                        }).ToList())
                    .ToListAsync(cancellationToken);

                return response;
            }
        }
    }
}