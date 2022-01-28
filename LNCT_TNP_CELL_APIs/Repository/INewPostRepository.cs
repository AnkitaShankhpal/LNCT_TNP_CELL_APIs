using DemoApiUsingJWT.DbModels;

namespace DemoApiUsingJWT.Repository
{
    public interface INewPostRepository
    {
        string createNewPost(TblNewPost tblNewPost);

        string updateNewPost(TblNewPost tblNewPost);

      TblNewPost getNewPost(int id);
        List<TblNewPost> GetPostList();

        TblNewPost DeleteNewPost(int id);
    }
}
