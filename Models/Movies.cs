using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models;

public class Movie
{
    public int Id { get; set; }
    public string? Title { get; set; } // 뒤의 ?표시는 null 허용이 되는 옵션임.
    [DataType(DataType.Date)] //사용자가 날짜 필드에 시간정보를 입력할 필요없이 날짜만 표시됨.
    public DateTime ReleaseDate { get; set; }
    public string? Genre { get; set; }
    public decimal Price { get; set; }
}