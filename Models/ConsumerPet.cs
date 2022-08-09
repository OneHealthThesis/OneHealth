using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnetapp.Models;

public class ConsumerPet
{

    public long IdPet { get; set; }
    public long IdUser { get; set; }

    [ForeignKey("IdPet")] public Pet Pet { get; set; }

    [ForeignKey("IdUser")] public Consumer Consumer { get; set; }
}