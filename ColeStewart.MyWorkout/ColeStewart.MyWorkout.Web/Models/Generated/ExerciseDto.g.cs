using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace ColeStewart.MyWorkout.Web.Models
{
    public partial class ExerciseDtoGen : GeneratedDto<ColeStewart.MyWorkout.Data.Models.Exercise>
    {
        public ExerciseDtoGen() { }

        private int? _ExerciseId;
        private string _Name;
        private string _Description;
        private int? _Difficulty;

        public int? ExerciseId
        {
            get => _ExerciseId;
            set { _ExerciseId = value; Changed(nameof(ExerciseId)); }
        }
        public string Name
        {
            get => _Name;
            set { _Name = value; Changed(nameof(Name)); }
        }
        public string Description
        {
            get => _Description;
            set { _Description = value; Changed(nameof(Description)); }
        }
        public int? Difficulty
        {
            get => _Difficulty;
            set { _Difficulty = value; Changed(nameof(Difficulty)); }
        }

        /// <summary>
        /// Map from the domain object to the properties of the current DTO instance.
        /// </summary>
        public override void MapFrom(ColeStewart.MyWorkout.Data.Models.Exercise obj, IMappingContext context, IncludeTree tree = null)
        {
            if (obj == null) return;
            var includes = context.Includes;

            this.ExerciseId = obj.ExerciseId;
            this.Name = obj.Name;
            this.Description = obj.Description;
            this.Difficulty = obj.Difficulty;
        }

        /// <summary>
        /// Map from the current DTO instance to the domain object.
        /// </summary>
        public override void MapTo(ColeStewart.MyWorkout.Data.Models.Exercise entity, IMappingContext context)
        {
            var includes = context.Includes;

            if (OnUpdate(entity, context)) return;

            if (ShouldMapTo(nameof(ExerciseId))) entity.ExerciseId = (ExerciseId ?? entity.ExerciseId);
            if (ShouldMapTo(nameof(Name))) entity.Name = Name;
            if (ShouldMapTo(nameof(Description))) entity.Description = Description;
            if (ShouldMapTo(nameof(Difficulty))) entity.Difficulty = (Difficulty ?? entity.Difficulty);
        }

        /// <summary>
        /// Map from the current DTO instance to a new instance of the domain object.
        /// </summary>
        public override ColeStewart.MyWorkout.Data.Models.Exercise MapToNew(IMappingContext context)
        {
            var includes = context.Includes;

            var entity = new ColeStewart.MyWorkout.Data.Models.Exercise()
            {
                Name = Name,
                Description = Description,
            };

            if (OnUpdate(entity, context)) return entity;
            if (ShouldMapTo(nameof(ExerciseId))) entity.ExerciseId = (ExerciseId ?? entity.ExerciseId);
            if (ShouldMapTo(nameof(Difficulty))) entity.Difficulty = (Difficulty ?? entity.Difficulty);

            return entity;
        }
    }
}
