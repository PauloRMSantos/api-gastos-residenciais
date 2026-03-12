using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gastosResidenciais.Models;

public class Person
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [Column(TypeName = "varchar(200)")]
    [Required]
    public string Name { get; set; }
    
    [Column]
    public int Age { get; set; }
}