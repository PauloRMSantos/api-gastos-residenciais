using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using gastosResidenciais.ENUMs;

namespace gastosResidenciais.Models;

public class Category
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [Column(TypeName = "varchar(400)")]
    public string Description { get; set; }
    
    [Column]
    public TypeEnum Type { get; set; }

    public Category Create(
        string description,
        TypeEnum type)
    {
        Description = description;
        Type =  type;
        
        return this;
    }
}