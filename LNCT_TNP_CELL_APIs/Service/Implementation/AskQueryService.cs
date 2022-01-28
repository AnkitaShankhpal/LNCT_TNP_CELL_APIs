
using DemoApiUsingJWT.DbModels;
using DemoApiUsingJWT.Repository;
using DemoApiUsingJWT.Request;

namespace DemoApiUsingJWT.Service.Implementation
{
    public class AskQueryService : IAskQueryService
    {
        private IAskQueryRepository _askQueryRepository;

        public AskQueryService(IAskQueryRepository askQueryRepository)
        {
            _askQueryRepository = askQueryRepository;
        }
        public string CreateQuery(AskQueryRequestModel askQuery)
        {
            AskQuery asq = new AskQuery();
            asq.SubjectOfQuery = askQuery.SubjectOfQuery;
            asq.Problem= askQuery.Problem;
            asq.CreatedOn = DateTime.Now;
            asq.StudentId = askQuery.StudentId;
            return (_askQueryRepository.CreateQuery(asq));
        }

        public AskQueryRequestModel DeleteQuery(int id)
        {
           
            AskQueryRequestModel stdDelete = new AskQueryRequestModel();
            var result = _askQueryRepository.DeleteQuery(id);
            stdDelete.SubjectOfQuery = result.SubjectOfQuery;
            stdDelete.Problem = result.Problem;
         

            return stdDelete;
        }

        public List<AskQueryRequestModel> GetAllQuery()
        {
            List<AskQueryRequestModel> list = new List<AskQueryRequestModel>();
            var result = _askQueryRepository.GetAllQuery();
            foreach (var item in result)
            {
                AskQueryRequestModel str = new AskQueryRequestModel();
                str.Id = item.Id;
                str.SubjectOfQuery = item.SubjectOfQuery;
                str.Problem = item.Problem;
                //str.CreatedOn = item.CreatedOn;
                list.Add(str);
            }
            return list;
        }

        public AskQueryRequestModel GetQuery(int id)
        {
            AskQueryRequestModel str = new AskQueryRequestModel();
            var result = _askQueryRepository.GetQuery(id);
            str.Id = result.Id;
            str.SubjectOfQuery = result.SubjectOfQuery;
            str.Problem = result.Problem;
           // str.StudentId = result.StudentId;
           // str.CreatedOn = result.CreatedOn;

            return str;
        }

        public string UpdateQuery(AskQueryRequestModel askQuery)
        {
            AskQuery asq = new AskQuery();
            asq.Id = askQuery.Id;
            asq.SubjectOfQuery = askQuery.SubjectOfQuery;
            asq.Problem = askQuery.Problem;
            asq.CreatedOn = DateTime.Now;
            return (_askQueryRepository.UpdateQuery(asq));
        }
    }
}
