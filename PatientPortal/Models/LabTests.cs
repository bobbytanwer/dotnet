using System;

namespace PatientPortal.Models;


public class LabTests
{
    public required int LabTestId { get; set; }
    public  required string LabTestname { get; set; }
    public required String TestDate { get; set; }
    public required string LabResults { get; set; }


}