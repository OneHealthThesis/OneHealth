using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.ComponentModel.DataAnnotations;

namespace dotnetapp.Models;

public class Consumer : Person
{
    [Required] public bool IsOwner { get; set; }
    

}