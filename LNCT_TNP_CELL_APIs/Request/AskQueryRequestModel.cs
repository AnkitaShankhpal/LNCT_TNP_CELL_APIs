namespace DemoApiUsingJWT.Request
{
    public class AskQueryRequestModel
    {
        public int Id { get; set; }
      
        public string SubjectOfQuery { get; set; }
       
        public int StudentId { get; set; }
      
        public DateTime CreatedOn { get; set; }
        public string Problem { get; set; }
    }
}
