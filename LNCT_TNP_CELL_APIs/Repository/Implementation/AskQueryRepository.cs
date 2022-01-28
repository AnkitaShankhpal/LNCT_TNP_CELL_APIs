using DemoApiUsingJWT.DbModels;

namespace DemoApiUsingJWT.Repository.Implementation
{
    public class AskQueryRepository : IAskQueryRepository
    {
        private CoreDbContext DbContext;

        public AskQueryRepository()
        {
            DbContext = new CoreDbContext();
        }
        public string CreateQuery(AskQuery askQuery)
        {

            var studentExist = DbContext.TblStudentRegisters.FirstOrDefault(x=>x.StudentId == askQuery.StudentId);
            var str = "Not Created";
            if (studentExist != null)
            {
                DbContext.AskQueries.Add(askQuery);
                DbContext.SaveChanges();
                str = "Created Successfully";
                return str;
            }
            return str;   
        }

        public AskQuery DeleteQuery(int id)
        {
            var queryDelt = DbContext.AskQueries.FirstOrDefault(x => x.Id == id);
            if (queryDelt != null)
            { 
                DbContext.AskQueries.Remove(queryDelt);
                DbContext.SaveChanges();
                return queryDelt;
            }
            return null;
        }

        public List<AskQuery> GetAllQuery()
        {
            var result= DbContext.AskQueries.ToList();
            return result;
        }

        public AskQuery GetQuery(int id)
        {
            var queryGet = DbContext.AskQueries.FirstOrDefault(x=>x.Id == id);
            if (queryGet != null)
            { 
                return queryGet;
            }
            return null;
        }

        public string UpdateQuery(AskQuery askQuery)
        {
            var queryUpdate = DbContext.AskQueries.FirstOrDefault(x=>x.Id == askQuery.Id);
            var str = "not found";
            if (queryUpdate != null)
            {
                queryUpdate.SubjectOfQuery = askQuery.SubjectOfQuery;
                queryUpdate.Problem=askQuery.Problem;
                DbContext.SaveChanges();
                str = "Updated Successfully";
                return str;
            }
            return str;
        }
    }
}
