using System.ComponentModel.DataAnnotations;
public class Student
{
    [Key]
    public int Roll {get; set;}
    public string? Name {get; set;}    
}