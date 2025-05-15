using System;
using Microsoft.VisualBasic;

namespace PatientPortal.Models;

public class Patient
{
 public int uuid { get; set;}
 public required string FirstName { get; set; }

 public required string LastName { get; set; }


}

