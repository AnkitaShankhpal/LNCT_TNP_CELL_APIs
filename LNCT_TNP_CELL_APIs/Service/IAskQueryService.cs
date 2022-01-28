using DemoApiUsingJWT.Request;

namespace DemoApiUsingJWT.Service
{
    public interface IAskQueryService 
    {
        string CreateQuery(AskQueryRequestModel askQuery);

        List<AskQueryRequestModel> GetAllQuery();

        AskQueryRequestModel GetQuery(int id);

        AskQueryRequestModel DeleteQuery(int id);

        string UpdateQuery(AskQueryRequestModel askQuery);
    }
}
