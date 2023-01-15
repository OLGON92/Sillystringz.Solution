using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace Factory.Models
{
  public class Engineer
  {
    [Required(ErrorMessage = "Engineer's name required!")]
    public string Name { get; set; }
    [Required(ErrorMessage = "Specialty required!")]
    public string Specialty { get; set; }
    public int EngineerId { get; set; }

    public List<EngineerMachine> JoinEntities { get; }
  }
}