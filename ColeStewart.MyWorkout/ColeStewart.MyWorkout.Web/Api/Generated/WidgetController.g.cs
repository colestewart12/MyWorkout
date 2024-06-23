
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
    [Route("api/Widget")]
    [Authorize]
    [ServiceFilter(typeof(IApiActionFilter))]
    public partial class WidgetController
        : BaseApiController<ColeStewart.MyWorkout.Data.Models.Widget, WidgetDtoGen, ColeStewart.MyWorkout.Data.AppDbContext>
    {
        public WidgetController(CrudContext<ColeStewart.MyWorkout.Data.AppDbContext> context) : base(context)
        {
            GeneratedForClassViewModel = context.ReflectionRepository.GetClassViewModel<ColeStewart.MyWorkout.Data.Models.Widget>();
        }

        [HttpGet("get/{id}")]
        [Authorize]
        public virtual Task<ItemResult<WidgetDtoGen>> Get(
            int id,
            DataSourceParameters parameters,
            IDataSource<ColeStewart.MyWorkout.Data.Models.Widget> dataSource)
            => GetImplementation(id, parameters, dataSource);

        [HttpGet("list")]
        [Authorize]
        public virtual Task<ListResult<WidgetDtoGen>> List(
            ListParameters parameters,
            IDataSource<ColeStewart.MyWorkout.Data.Models.Widget> dataSource)
            => ListImplementation(parameters, dataSource);

        [HttpGet("count")]
        [Authorize]
        public virtual Task<ItemResult<int>> Count(
            FilterParameters parameters,
            IDataSource<ColeStewart.MyWorkout.Data.Models.Widget> dataSource)
            => CountImplementation(parameters, dataSource);

        [HttpPost("save")]
        [Authorize]
        public virtual Task<ItemResult<WidgetDtoGen>> Save(
            [FromForm] WidgetDtoGen dto,
            [FromQuery] DataSourceParameters parameters,
            IDataSource<ColeStewart.MyWorkout.Data.Models.Widget> dataSource,
            IBehaviors<ColeStewart.MyWorkout.Data.Models.Widget> behaviors)
            => SaveImplementation(dto, parameters, dataSource, behaviors);

        [HttpPost("bulkSave")]
        [Authorize]
        public virtual Task<ItemResult<WidgetDtoGen>> BulkSave(
            [FromBody] BulkSaveRequest dto,
            [FromQuery] DataSourceParameters parameters,
            [FromServices] IDataSourceFactory dataSourceFactory,
            [FromServices] IBehaviorsFactory behaviorsFactory)
            => BulkSaveImplementation(dto, parameters, dataSourceFactory, behaviorsFactory);

        [HttpPost("delete/{id}")]
        [Authorize]
        public virtual Task<ItemResult<WidgetDtoGen>> Delete(
            int id,
            IBehaviors<ColeStewart.MyWorkout.Data.Models.Widget> behaviors,
            IDataSource<ColeStewart.MyWorkout.Data.Models.Widget> dataSource)
            => DeleteImplementation(id, new DataSourceParameters(), dataSource, behaviors);
    }
}
