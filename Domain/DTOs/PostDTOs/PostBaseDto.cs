

namespace Domain;

public class PostBaseDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int vote {  get; set; }
    public DateTime CreatedAt { get; set; }
}
