using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace ColeStewart.MyWorkout.Web.Models
{
    public partial class WorkoutSetDtoGen : GeneratedDto<ColeStewart.MyWorkout.Data.Models.WorkoutSet>
    {
        public WorkoutSetDtoGen() { }

        private int? _WorkoutSetId;
        private string _WorkoutName;
        private int? _WorkoutId;
        private System.Collections.Generic.ICollection<ColeStewart.MyWorkout.Web.Models.SetExerciseDtoGen> _Exercise;

        public int? WorkoutSetId
        {
            get => _WorkoutSetId;
            set { _WorkoutSetId = value; Changed(nameof(WorkoutSetId)); }
        }
        public string WorkoutName
        {
            get => _WorkoutName;
            set { _WorkoutName = value; Changed(nameof(WorkoutName)); }
        }
        public int? WorkoutId
        {
            get => _WorkoutId;
            set { _WorkoutId = value; Changed(nameof(WorkoutId)); }
        }
        public System.Collections.Generic.ICollection<ColeStewart.MyWorkout.Web.Models.SetExerciseDtoGen> Exercise
        {
            get => _Exercise;
            set { _Exercise = value; Changed(nameof(Exercise)); }
        }

        /// <summary>
        /// Map from the domain object to the properties of the current DTO instance.
        /// </summary>
        public override void MapFrom(ColeStewart.MyWorkout.Data.Models.WorkoutSet obj, IMappingContext context, IncludeTree tree = null)
        {
            if (obj == null) return;
            var includes = context.Includes;

            this.WorkoutSetId = obj.WorkoutSetId;
            this.WorkoutName = obj.WorkoutName;
            this.WorkoutId = obj.WorkoutId;
            var propValExercise = obj.Exercise;
            if (propValExercise != null && (tree == null || tree[nameof(this.Exercise)] != null))
            {
                this.Exercise = propValExercise
                    .OrderBy(f => f.SetExerciseId)
                    .Select(f => f.MapToDto<ColeStewart.MyWorkout.Data.Models.SetExercise, SetExerciseDtoGen>(context, tree?[nameof(this.Exercise)])).ToList();
            }
            else if (propValExercise == null && tree?[nameof(this.Exercise)] != null)
            {
                this.Exercise = new SetExerciseDtoGen[0];
            }

        }

        /// <summary>
        /// Map from the current DTO instance to the domain object.
        /// </summary>
        public override void MapTo(ColeStewart.MyWorkout.Data.Models.WorkoutSet entity, IMappingContext context)
        {
            var includes = context.Includes;

            if (OnUpdate(entity, context)) return;

            if (ShouldMapTo(nameof(WorkoutSetId))) entity.WorkoutSetId = (WorkoutSetId ?? entity.WorkoutSetId);
            if (ShouldMapTo(nameof(WorkoutName))) entity.WorkoutName = WorkoutName;
            if (ShouldMapTo(nameof(WorkoutId))) entity.WorkoutId = (WorkoutId ?? entity.WorkoutId);
        }

        /// <summary>
        /// Map from the current DTO instance to a new instance of the domain object.
        /// </summary>
        public override ColeStewart.MyWorkout.Data.Models.WorkoutSet MapToNew(IMappingContext context)
        {
            var entity = new ColeStewart.MyWorkout.Data.Models.WorkoutSet();
            MapTo(entity, context);
            return entity;
        }
    }
}
