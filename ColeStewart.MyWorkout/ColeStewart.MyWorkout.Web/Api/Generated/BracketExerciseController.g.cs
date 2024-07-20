
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
    [Route("api/BracketExercise")]
    [Authorize]
    [ServiceFilter(typeof(IApiActionFilter))]
    public partial class BracketExerciseController
        : BaseApiController<ColeStewart.MyWorkout.Data.Models.BracketExercise, BracketExerciseDtoGen, ColeStewart.MyWorkout.Data.AppDbContext>
    {
        public BracketExerciseController(CrudContext<ColeStewart.MyWorkout.Data.AppDbContext> context) : base(context)
        {
            GeneratedForClassViewModel = context.ReflectionRepository.GetClassViewModel<ColeStewart.MyWorkout.Data.Models.BracketExercise>();
        }

        [HttpGet("get/{id}")]
        [Authorize]
        public virtual Task<ItemResult<BracketExerciseDtoGen>> Get(
            int id,
            DataSourceParameters parameters,
            IDataSource<ColeStewart.MyWorkout.Data.Models.BracketExercise> dataSource)
            => GetImplementation(id, parameters, dataSource);

        [HttpGet("list")]
        [Authorize]
        public virtual Task<ListResult<BracketExerciseDtoGen>> List(
            ListParameters parameters,
            IDataSource<ColeStewart.MyWorkout.Data.Models.BracketExercise> dataSource)
            => ListImplementation(parameters, dataSource);

        [HttpGet("count")]
        [Authorize]
        public virtual Task<ItemResult<int>> Count(
            FilterParameters parameters,
            IDataSource<ColeStewart.MyWorkout.Data.Models.BracketExercise> dataSource)
            => CountImplementation(parameters, dataSource);

        [HttpPost("save")]
        [Authorize]
        public virtual Task<ItemResult<BracketExerciseDtoGen>> Save(
            [FromForm] BracketExerciseDtoGen dto,
            [FromQuery] DataSourceParameters parameters,
            IDataSource<ColeStewart.MyWorkout.Data.Models.BracketExercise> dataSource,
            IBehaviors<ColeStewart.MyWorkout.Data.Models.BracketExercise> behaviors)
            => SaveImplementation(dto, parameters, dataSource, behaviors);

        [HttpPost("bulkSave")]
        [Authorize]
        public virtual Task<ItemResult<BracketExerciseDtoGen>> BulkSave(
            [FromBody] BulkSaveRequest dto,
            [FromQuery] DataSourceParameters parameters,
            [FromServices] IDataSourceFactory dataSourceFactory,
            [FromServices] IBehaviorsFactory behaviorsFactory)
            => BulkSaveImplementation(dto, parameters, dataSourceFactory, behaviorsFactory);

        [HttpPost("delete/{id}")]
        [Authorize]
        public virtual Task<ItemResult<BracketExerciseDtoGen>> Delete(
            int id,
            IBehaviors<ColeStewart.MyWorkout.Data.Models.BracketExercise> behaviors,
            IDataSource<ColeStewart.MyWorkout.Data.Models.BracketExercise> dataSource)
            => DeleteImplementation(id, new DataSourceParameters(), dataSource, behaviors);
    }
}
