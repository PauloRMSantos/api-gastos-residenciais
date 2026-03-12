using gastosResidenciais.ENUMs;

namespace gastosResidenciais.DTOs;

public record CreateCategoryDTO
{
    public string Description { get; set; }
    public TypeEnum Type { get; set; }
}