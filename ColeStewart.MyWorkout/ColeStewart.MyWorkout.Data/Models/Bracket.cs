using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeStewart.MyWorkout.Data.Models;
public class Bracket
{
    public int BracketId { get; set; }
    public string? BracketName { get; set; }
    [Required]
    public int WorkoutId { get; set; }
    public ICollection<BracketExercise>? Exercises { get; set; }
}
