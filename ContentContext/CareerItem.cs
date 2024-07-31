namespace Murillo.ContentContext
{
  public class CareerItem
  {
    public CareerItem(int ordem, string title, string description, Course course)
    {
      if (course == null)
        throw new Exception("O curso não pode ser nulo");
        
      Order = ordem;
      Title = title;
      Description = description;
      Course = course;
    }

    public int Order { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public Course Course { get; set; }
  }
}