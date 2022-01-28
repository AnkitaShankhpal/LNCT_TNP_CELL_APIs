namespace DemoApiUsingJWT.Request
{
    public class StudentProfileRequestModel
    {
        public int Id { get; set; }
        public string EmailId { get; set; }
        public string MobileNo { get; set; }
        public string FatherName { get; set; }
        public string CurrentAddress { get; set; }
        
        public DateTime Dob { get; set; }
     
        public int StudentId { get; set; }
    
        public int BranchId { get; set; }
    
        public int DepartmentId { get; set; }
       
        public int CourseId { get; set; }
       
        public DateTime CreatedOn { get; set; }
      
        public DateTime ModifiedOn { get; set; }
    }
}
