using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeStewart.MyWorkout.Data.Models;
public class Workout
{
    public int WorkoutId { get; set; }
    [Required]
    public required string Title { get; set; }
    public string? Description { get; set; }
    public ICollection<Bracket>? Brackets { get; set; }
}
