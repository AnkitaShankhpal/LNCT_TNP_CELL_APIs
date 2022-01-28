namespace DemoApiUsingJWT.Request
{
    public class StudentAcademicRequestModel
    {
        public int Id { get; set; }
        //public int StudentId { get; set; }
        public string SscPercentage { get; set; }
        public string SscSchoolName { get; set; }
        public string SscBoard { get; set; }
        public string SscYop { get; set; }
        public string HscPercentage { get; set; }
        public string HscSchoolName { get; set; }
        public string HscBoard { get; set; }
        public string HscYop { get; set; }
        public string DiplomaPercentage { get; set; }
        public string DiplomaYop { get; set; }
        public string UgPercentage { get; set; }
        public string UgYop { get; set; }
        public string UgBack { get; set; }
        public string UgYearGap { get; set; }
        public string PgPercentage { get; set; }
        public string PgYop { get; set; }
        public string PgBack { get; set; }
        public string PgYearGap { get; set; }
        public int DepartmentId { get; set; }
        public int CourseId { get; set; }
        public int BranchId { get; set; }

        public int StudentId { get; set; }
    }
}
