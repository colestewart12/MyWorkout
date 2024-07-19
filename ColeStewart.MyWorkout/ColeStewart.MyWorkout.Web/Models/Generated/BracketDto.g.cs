using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace ColeStewart.MyWorkout.Web.Models
{
    public partial class BracketDtoGen : GeneratedDto<ColeStewart.MyWorkout.Data.Models.Bracket>
    {
        public BracketDtoGen() { }

        private int? _BracketId;
        private string _BracketName;
        private int? _WorkoutId;
        private System.Collections.Generic.ICollection<ColeStewart.MyWorkout.Web.Models.SetExerciseDtoGen> _Exercise;

        public int? BracketId
        {
            get => _BracketId;
            set { _BracketId = value; Changed(nameof(BracketId)); }
        }
        public string BracketName
        {
            get => _BracketName;
            set { _BracketName = value; Changed(nameof(BracketName)); }
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
        public override void MapFrom(ColeStewart.MyWorkout.Data.Models.Bracket obj, IMappingContext context, IncludeTree tree = null)
        {
            if (obj == null) return;
            var includes = context.Includes;

            this.BracketId = obj.BracketId;
            this.BracketName = obj.BracketName;
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
        public override void MapTo(ColeStewart.MyWorkout.Data.Models.Bracket entity, IMappingContext context)
        {
            var includes = context.Includes;

            if (OnUpdate(entity, context)) return;

            if (ShouldMapTo(nameof(BracketId))) entity.BracketId = (BracketId ?? entity.BracketId);
            if (ShouldMapTo(nameof(BracketName))) entity.BracketName = BracketName;
            if (ShouldMapTo(nameof(WorkoutId))) entity.WorkoutId = (WorkoutId ?? entity.WorkoutId);
        }

        /// <summary>
        /// Map from the current DTO instance to a new instance of the domain object.
        /// </summary>
        public override ColeStewart.MyWorkout.Data.Models.Bracket MapToNew(IMappingContext context)
        {
            var entity = new ColeStewart.MyWorkout.Data.Models.Bracket();
            MapTo(entity, context);
            return entity;
        }
    }
}
