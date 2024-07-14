using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeStewart.MyWorkout.Data.Models;
public class SetExercise
{
    public int SetExerciseId { get; set; }
    [Required]
    public int ExerciseId { get; set; }
    public Exercise? Exercise { get; set; }
    [Required]
    public int WorkoutSetId { get; set; }
    public int? Reps { get; set; }
    public int? Time { get; set; }
}