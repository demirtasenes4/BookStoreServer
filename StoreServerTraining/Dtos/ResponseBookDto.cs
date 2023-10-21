namespace StoreServerTraining.Dtos;

public class ResponseBookDto<T>
{
    public T Data { get; set; }
    public int PageNumber { get; set; }
    public int PageSize { get; set; } = 10;
    public int TotalPageCount {  get; set; }
    public bool IsFirstPage {  get; set; }
    public bool IsLastPage { get; set; }
}
