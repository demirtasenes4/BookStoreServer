namespace StoreServerTraining.Dtos;

public class RequestBookDto
{
    public int PageNumber { get; set; }
    public int PageSize { get; set; } = 10;
    public string SearchBookTerm { get; set; }
    public int? CategoryId { get; set; }
}
