namespace DemoApiUsingJWT.Request
{
    public class NewPostRequestModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Post { get; set; }
        public string PostFile { get; set; }
       
        public DateTime CreatedOn { get; set; }
    }
}
