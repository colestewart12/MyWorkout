using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeStewart.MyWorkout.Data.Models;
public class User
{
    public int UserId { get; set; }
    public string Name { get; set; }
    public DateTimeOffset? BirthDate { get; set; }
}
