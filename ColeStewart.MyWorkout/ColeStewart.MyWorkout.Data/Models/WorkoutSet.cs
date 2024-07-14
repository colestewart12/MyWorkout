using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeStewart.MyWorkout.Data.Models;
public class WorkoutSet
{
    public int WorkoutSetId { get; set; }
    public string? WorkoutName { get; set; }
    [Required]
    public int WorkoutId { get; set; }
    public ICollection<SetExercise> Exercise { get; set; } = new List<SetExercise>();
}
