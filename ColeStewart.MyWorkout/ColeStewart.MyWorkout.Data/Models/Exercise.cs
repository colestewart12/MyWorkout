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
}
