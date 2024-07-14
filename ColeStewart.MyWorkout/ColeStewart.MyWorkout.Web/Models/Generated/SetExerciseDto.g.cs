using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace ColeStewart.MyWorkout.Web.Models
{
    public partial class SetExerciseDtoGen : GeneratedDto<ColeStewart.MyWorkout.Data.Models.SetExercise>
    {
        public SetExerciseDtoGen() { }

        private int? _SetExerciseId;
        private int? _ExerciseId;
        private ColeStewart.MyWorkout.Web.Models.ExerciseDtoGen _Exercise;
        private int? _WorkoutSetId;
        private int? _Reps;
        private int? _Time;

        public int? SetExerciseId
        {
            get => _SetExerciseId;
            set { _SetExerciseId = value; Changed(nameof(SetExerciseId)); }
        }
        public int? ExerciseId
        {
            get => _ExerciseId;
            set { _ExerciseId = value; Changed(nameof(ExerciseId)); }
        }
        public ColeStewart.MyWorkout.Web.Models.ExerciseDtoGen Exercise
        {
            get => _Exercise;
            set { _Exercise = value; Changed(nameof(Exercise)); }
        }
        public int? WorkoutSetId
        {
            get => _WorkoutSetId;
            set { _WorkoutSetId = value; Changed(nameof(WorkoutSetId)); }
        }
        public int? Reps
        {
            get => _Reps;
            set { _Reps = value; Changed(nameof(Reps)); }
        }
        public int? Time
        {
            get => _Time;
            set { _Time = value; Changed(nameof(Time)); }
        }

        /// <summary>
        /// Map from the domain object to the properties of the current DTO instance.
        /// </summary>
        public override void MapFrom(ColeStewart.MyWorkout.Data.Models.SetExercise obj, IMappingContext context, IncludeTree tree = null)
        {
            if (obj == null) return;
            var includes = context.Includes;

            this.SetExerciseId = obj.SetExerciseId;
            this.ExerciseId = obj.ExerciseId;
            this.WorkoutSetId = obj.WorkoutSetId;
            this.Reps = obj.Reps;
            this.Time = obj.Time;
            if (tree == null || tree[nameof(this.Exercise)] != null)
                this.Exercise = obj.Exercise.MapToDto<ColeStewart.MyWorkout.Data.Models.Exercise, ExerciseDtoGen>(context, tree?[nameof(this.Exercise)]);

        }

        /// <summary>
        /// Map from the current DTO instance to the domain object.
        /// </summary>
        public override void MapTo(ColeStewart.MyWorkout.Data.Models.SetExercise entity, IMappingContext context)
        {
            var includes = context.Includes;

            if (OnUpdate(entity, context)) return;

            if (ShouldMapTo(nameof(SetExerciseId))) entity.SetExerciseId = (SetExerciseId ?? entity.SetExerciseId);
            if (ShouldMapTo(nameof(ExerciseId))) entity.ExerciseId = (ExerciseId ?? entity.ExerciseId);
            if (ShouldMapTo(nameof(WorkoutSetId))) entity.WorkoutSetId = (WorkoutSetId ?? entity.WorkoutSetId);
            if (ShouldMapTo(nameof(Reps))) entity.Reps = Reps;
            if (ShouldMapTo(nameof(Time))) entity.Time = Time;
        }

        /// <summary>
        /// Map from the current DTO instance to a new instance of the domain object.
        /// </summary>
        public override ColeStewart.MyWorkout.Data.Models.SetExercise MapToNew(IMappingContext context)
        {
            var entity = new ColeStewart.MyWorkout.Data.Models.SetExercise();
            MapTo(entity, context);
            return entity;
        }
    }
}
