namespace ClinicApp.Models;
public abstract class BaseModel
{
    public int Id { get; set; }
}
public class HealthCare
{

    public string Description { get; set; }
    public string Title { get; set; }
    public string Icon { get; set; }
}
