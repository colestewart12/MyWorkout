using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeStewart.MyWorkout.Data.Models;
public class Exercise
{
    public int ExerciseId { get; set; }
    [Required]
    public required string Name { get; set; }
    [Required]
    public required string Description { get; set; }
    [Range(1, 5)]
    public int Difficulty { get; set; }

    [DefaultDataSource]
    public class ExerciseDataSource(CrudContext<AppDbContext> context) : StandardDataSource<Exercise, AppDbContext>(context)
    {
        [Coalesce]
        public int? ExerciseId { get; set; }
        public override IQueryable<Exercise> GetQuery(IDataSourceParameters parameters)
        {
            IQueryable<Exercise> query = base.GetQuery(parameters);
            if (ExerciseId != null)
            {
                query = query.Where(e => e.ExerciseId == ExerciseId);
            }
            return query;
        }
    }
}
