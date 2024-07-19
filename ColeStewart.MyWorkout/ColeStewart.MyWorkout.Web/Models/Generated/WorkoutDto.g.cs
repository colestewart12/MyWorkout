using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace ColeStewart.MyWorkout.Web.Models
{
    public partial class WorkoutDtoGen : GeneratedDto<ColeStewart.MyWorkout.Data.Models.Workout>
    {
        public WorkoutDtoGen() { }

        private int? _WorkoutId;
        private string _Title;
        private string _Description;
        private System.Collections.Generic.ICollection<ColeStewart.MyWorkout.Web.Models.BracketDtoGen> _Brackets;

        public int? WorkoutId
        {
            get => _WorkoutId;
            set { _WorkoutId = value; Changed(nameof(WorkoutId)); }
        }
        public string Title
        {
            get => _Title;
            set { _Title = value; Changed(nameof(Title)); }
        }
        public string Description
        {
            get => _Description;
            set { _Description = value; Changed(nameof(Description)); }
        }
        public System.Collections.Generic.ICollection<ColeStewart.MyWorkout.Web.Models.BracketDtoGen> Brackets
        {
            get => _Brackets;
            set { _Brackets = value; Changed(nameof(Brackets)); }
        }

        /// <summary>
        /// Map from the domain object to the properties of the current DTO instance.
        /// </summary>
        public override void MapFrom(ColeStewart.MyWorkout.Data.Models.Workout obj, IMappingContext context, IncludeTree tree = null)
        {
            if (obj == null) return;
            var includes = context.Includes;

            this.WorkoutId = obj.WorkoutId;
            this.Title = obj.Title;
            this.Description = obj.Description;
            var propValBrackets = obj.Brackets;
            if (propValBrackets != null && (tree == null || tree[nameof(this.Brackets)] != null))
            {
                this.Brackets = propValBrackets
                    .OrderBy(f => f.BracketId)
                    .Select(f => f.MapToDto<ColeStewart.MyWorkout.Data.Models.Bracket, BracketDtoGen>(context, tree?[nameof(this.Brackets)])).ToList();
            }
            else if (propValBrackets == null && tree?[nameof(this.Brackets)] != null)
            {
                this.Brackets = new BracketDtoGen[0];
            }

        }

        /// <summary>
        /// Map from the current DTO instance to the domain object.
        /// </summary>
        public override void MapTo(ColeStewart.MyWorkout.Data.Models.Workout entity, IMappingContext context)
        {
            var includes = context.Includes;

            if (OnUpdate(entity, context)) return;

            if (ShouldMapTo(nameof(WorkoutId))) entity.WorkoutId = (WorkoutId ?? entity.WorkoutId);
            if (ShouldMapTo(nameof(Title))) entity.Title = Title;
            if (ShouldMapTo(nameof(Description))) entity.Description = Description;
        }

        /// <summary>
        /// Map from the current DTO instance to a new instance of the domain object.
        /// </summary>
        public override ColeStewart.MyWorkout.Data.Models.Workout MapToNew(IMappingContext context)
        {
            var includes = context.Includes;

            var entity = new ColeStewart.MyWorkout.Data.Models.Workout()
            {
                Title = Title,
            };

            if (OnUpdate(entity, context)) return entity;
            if (ShouldMapTo(nameof(WorkoutId))) entity.WorkoutId = (WorkoutId ?? entity.WorkoutId);
            if (ShouldMapTo(nameof(Description))) entity.Description = Description;

            return entity;
        }
    }
}
