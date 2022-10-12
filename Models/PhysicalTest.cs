using System.ComponentModel.DataAnnotations;

namespace dotnetapp.Models;

public class PhysicalTest
{
    [Key] public long IdPhysicalTest { get; set; }
    public string CardiovascularSystem { get; set; }
    public string OstioMyoArticularSystem { get; set; }
    public string RespiratorySystem { get; set; }
    public string NeurologicalSystem { get; set; }
    public string DigestiveSystem { get; set; }
    public string GenitourinarySystem { get; set; }
    public string HemolymphopoieticSystem { get; set; }
    public string Oral { get; set; }
    public string Ears { get; set; }
    public string Eyes { get; set; }

}