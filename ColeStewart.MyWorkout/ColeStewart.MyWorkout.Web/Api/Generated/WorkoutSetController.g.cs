
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
    [Route("api/WorkoutSet")]
    [Authorize]
    [ServiceFilter(typeof(IApiActionFilter))]
    public partial class WorkoutSetController
        : BaseApiController<ColeStewart.MyWorkout.Data.Models.WorkoutSet, WorkoutSetDtoGen, ColeStewart.MyWorkout.Data.AppDbContext>
    {
        public WorkoutSetController(CrudContext<ColeStewart.MyWorkout.Data.AppDbContext> context) : base(context)
        {
            GeneratedForClassViewModel = context.ReflectionRepository.GetClassViewModel<ColeStewart.MyWorkout.Data.Models.WorkoutSet>();
        }

        [HttpGet("get/{id}")]
        [Authorize]
        public virtual Task<ItemResult<WorkoutSetDtoGen>> Get(
            int id,
            DataSourceParameters parameters,
            IDataSource<ColeStewart.MyWorkout.Data.Models.WorkoutSet> dataSource)
            => GetImplementation(id, parameters, dataSource);

        [HttpGet("list")]
        [Authorize]
        public virtual Task<ListResult<WorkoutSetDtoGen>> List(
            ListParameters parameters,
            IDataSource<ColeStewart.MyWorkout.Data.Models.WorkoutSet> dataSource)
            => ListImplementation(parameters, dataSource);

        [HttpGet("count")]
        [Authorize]
        public virtual Task<ItemResult<int>> Count(
            FilterParameters parameters,
            IDataSource<ColeStewart.MyWorkout.Data.Models.WorkoutSet> dataSource)
            => CountImplementation(parameters, dataSource);

        [HttpPost("save")]
        [Authorize]
        public virtual Task<ItemResult<WorkoutSetDtoGen>> Save(
            [FromForm] WorkoutSetDtoGen dto,
            [FromQuery] DataSourceParameters parameters,
            IDataSource<ColeStewart.MyWorkout.Data.Models.WorkoutSet> dataSource,
            IBehaviors<ColeStewart.MyWorkout.Data.Models.WorkoutSet> behaviors)
            => SaveImplementation(dto, parameters, dataSource, behaviors);

        [HttpPost("bulkSave")]
        [Authorize]
        public virtual Task<ItemResult<WorkoutSetDtoGen>> BulkSave(
            [FromBody] BulkSaveRequest dto,
            [FromQuery] DataSourceParameters parameters,
            [FromServices] IDataSourceFactory dataSourceFactory,
            [FromServices] IBehaviorsFactory behaviorsFactory)
            => BulkSaveImplementation(dto, parameters, dataSourceFactory, behaviorsFactory);

        [HttpPost("delete/{id}")]
        [Authorize]
        public virtual Task<ItemResult<WorkoutSetDtoGen>> Delete(
            int id,
            IBehaviors<ColeStewart.MyWorkout.Data.Models.WorkoutSet> behaviors,
            IDataSource<ColeStewart.MyWorkout.Data.Models.WorkoutSet> dataSource)
            => DeleteImplementation(id, new DataSourceParameters(), dataSource, behaviors);
    }
}