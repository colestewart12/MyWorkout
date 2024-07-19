
using ColeStewart.MyWorkout.Web.Models;
using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Api;
using IntelliTect.Coalesce.Api.Behaviors;
using IntelliTect.Coalesce.Api.Controllers;
using IntelliTect.Coalesce.Api.DataSources;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Mapping.IncludeTrees;
using IntelliTect.Coalesce.Models;
using IntelliTect.Coalesce.TypeDefinition;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ColeStewart.MyWorkout.Web.Api
{
    [Route("api/Bracket")]
    [Authorize]
    [ServiceFilter(typeof(IApiActionFilter))]
    public partial class BracketController
        : BaseApiController<ColeStewart.MyWorkout.Data.Models.Bracket, BracketDtoGen, ColeStewart.MyWorkout.Data.AppDbContext>
    {
        public BracketController(CrudContext<ColeStewart.MyWorkout.Data.AppDbContext> context) : base(context)
        {
            GeneratedForClassViewModel = context.ReflectionRepository.GetClassViewModel<ColeStewart.MyWorkout.Data.Models.Bracket>();
        }

        [HttpGet("get/{id}")]
        [Authorize]
        public virtual Task<ItemResult<BracketDtoGen>> Get(
            int id,
            DataSourceParameters parameters,
            IDataSource<ColeStewart.MyWorkout.Data.Models.Bracket> dataSource)
            => GetImplementation(id, parameters, dataSource);

        [HttpGet("list")]
        [Authorize]
        public virtual Task<ListResult<BracketDtoGen>> List(
            ListParameters parameters,
            IDataSource<ColeStewart.MyWorkout.Data.Models.Bracket> dataSource)
            => ListImplementation(parameters, dataSource);

        [HttpGet("count")]
        [Authorize]
        public virtual Task<ItemResult<int>> Count(
            FilterParameters parameters,
            IDataSource<ColeStewart.MyWorkout.Data.Models.Bracket> dataSource)
            => CountImplementation(parameters, dataSource);

        [HttpPost("save")]
        [Authorize]
        public virtual Task<ItemResult<BracketDtoGen>> Save(
            [FromForm] BracketDtoGen dto,
            [FromQuery] DataSourceParameters parameters,
            IDataSource<ColeStewart.MyWorkout.Data.Models.Bracket> dataSource,
            IBehaviors<ColeStewart.MyWorkout.Data.Models.Bracket> behaviors)
            => SaveImplementation(dto, parameters, dataSource, behaviors);

        [HttpPost("bulkSave")]
        [Authorize]
        public virtual Task<ItemResult<BracketDtoGen>> BulkSave(
            [FromBody] BulkSaveRequest dto,
            [FromQuery] DataSourceParameters parameters,
            [FromServices] IDataSourceFactory dataSourceFactory,
            [FromServices] IBehaviorsFactory behaviorsFactory)
            => BulkSaveImplementation(dto, parameters, dataSourceFactory, behaviorsFactory);

        [HttpPost("delete/{id}")]
        [Authorize]
        public virtual Task<ItemResult<BracketDtoGen>> Delete(
            int id,
            IBehaviors<ColeStewart.MyWorkout.Data.Models.Bracket> behaviors,
            IDataSource<ColeStewart.MyWorkout.Data.Models.Bracket> dataSource)
            => DeleteImplementation(id, new DataSourceParameters(), dataSource, behaviors);
    }
}
