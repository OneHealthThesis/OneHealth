using System.ComponentModel.DataAnnotations;

namespace dotnetapp.Models;

public class Service
{
    [Key] public long IdService { get; set; }
}