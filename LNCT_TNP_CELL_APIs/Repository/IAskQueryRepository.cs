using DemoApiUsingJWT.DbModels;

namespace DemoApiUsingJWT.Repository
{
    public interface IAskQueryRepository
    {
        string CreateQuery (AskQuery askQuery);

        List<AskQuery> GetAllQuery ();

        AskQuery GetQuery (int id);

        AskQuery DeleteQuery(int id);

        string UpdateQuery(AskQuery askQuery);
    }
}
