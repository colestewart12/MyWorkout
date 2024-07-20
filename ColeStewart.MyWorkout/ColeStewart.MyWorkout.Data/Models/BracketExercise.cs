﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeStewart.MyWorkout.Data.Models;
public class BracketExercise
{
    public int BracketExerciseId { get; set; }
    [Required]
    public int ExerciseId { get; set; }
    [Required]
    public int BracketId { get; set; }
    public int? Weight { get; set; }
}