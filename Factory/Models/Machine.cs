using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace Factory.Models
{
  public class Machine
  {
    public int MachineId { get; set; }
    [Required(ErrorMessage = "Machine's name required!")]
    public string Name { get; set; }
    [Required(ErrorMessage = "Machine's description required!")]
    public string Description { get; set; }

    public List<EngineerMachine> JoinEntities { get; }
  }
}