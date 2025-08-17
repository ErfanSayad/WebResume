namespace Resume.Domain.Entities.ContactUs;

public class ContactUs
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string PhoneNumber { get; set; }
    public string Message { get; set; }
    public DateTime CreateDate { get; set; }
    public bool IsSeenByAdmin { get; set; }

}
