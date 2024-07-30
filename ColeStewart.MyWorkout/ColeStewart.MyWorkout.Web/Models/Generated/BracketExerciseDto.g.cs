using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace ColeStewart.MyWorkout.Web.Models
{
    public partial class BracketExerciseDtoGen : GeneratedDto<ColeStewart.MyWorkout.Data.Models.BracketExercise>
    {
        public BracketExerciseDtoGen() { }

        private int? _BracketExerciseId;
        private int? _ExerciseId;
        private int? _BracketId;
        private int? _Weight;

        public int? BracketExerciseId
        {
            get => _BracketExerciseId;
            set { _BracketExerciseId = value; Changed(nameof(BracketExerciseId)); }
        }
        public int? ExerciseId
        {
            get => _ExerciseId;
            set { _ExerciseId = value; Changed(nameof(ExerciseId)); }
        }
        public int? BracketId
        {
            get => _BracketId;
            set { _BracketId = value; Changed(nameof(BracketId)); }
        }
        public int? Weight
        {
            get => _Weight;
            set { _Weight = value; Changed(nameof(Weight)); }
        }

        /// <summary>
        /// Map from the domain object to the properties of the current DTO instance.
        /// </summary>
        public override void MapFrom(ColeStewart.MyWorkout.Data.Models.BracketExercise obj, IMappingContext context, IncludeTree tree = null)
        {
            if (obj == null) return;
            var includes = context.Includes;

            this.BracketExerciseId = obj.BracketExerciseId;
            this.ExerciseId = obj.ExerciseId;
            this.BracketId = obj.BracketId;
            this.Weight = obj.Weight;
        }

        /// <summary>
        /// Map from the current DTO instance to the domain object.
        /// </summary>
        public override void MapTo(ColeStewart.MyWorkout.Data.Models.BracketExercise entity, IMappingContext context)
        {
            var includes = context.Includes;

            if (OnUpdate(entity, context)) return;

            if (ShouldMapTo(nameof(BracketExerciseId))) entity.BracketExerciseId = (BracketExerciseId ?? entity.BracketExerciseId);
            if (ShouldMapTo(nameof(ExerciseId))) entity.ExerciseId = (ExerciseId ?? entity.ExerciseId);
            if (ShouldMapTo(nameof(BracketId))) entity.BracketId = (BracketId ?? entity.BracketId);
            if (ShouldMapTo(nameof(Weight))) entity.Weight = Weight;
        }

        /// <summary>
        /// Map from the current DTO instance to a new instance of the domain object.
        /// </summary>
        public override ColeStewart.MyWorkout.Data.Models.BracketExercise MapToNew(IMappingContext context)
        {
            var entity = new ColeStewart.MyWorkout.Data.Models.BracketExercise();
            MapTo(entity, context);
            return entity;
        }
    }
}
