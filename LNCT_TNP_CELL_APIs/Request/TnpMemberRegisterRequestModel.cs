namespace DemoApiUsingJWT.Request
{
    public class TnpMemberRegisterRequestModel
    {
        public int Tnpid { get; set; }
        
        public string Name { get; set; }
        
        public string EmailId { get; set; }
       
        public string Password { get; set; }

        public string Department { get; set; }

    }
}
