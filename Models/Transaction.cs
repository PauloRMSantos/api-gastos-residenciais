using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gastosResidenciais.Models;

public class Transaction
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [Column(TypeName = "varchar(400)")]
    public string Description { get; set; }
    
    [Range(0.01, double.MaxValue)]
    public float Amount { get; set; }
    
    [Column]
    public int Type { get; set; }
    
    [ForeignKey("categoryId")]
    [InverseProperty("Transactions")]
    public int categoryId { get; set; }
    
    [ForeignKey("personId")]
    [InverseProperty("Person")]
    public int personId { get; set; }
}