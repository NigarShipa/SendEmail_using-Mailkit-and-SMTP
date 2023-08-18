namespace SendEmail_using_Mailkit___SMTP.Models
{
    public class EmailDto
    {
       
        public string To { get; set; }= string.Empty;
        public string Subject { get; set; } = string.Empty;
        public string Body { get; set; }=string.Empty;
    }
}
