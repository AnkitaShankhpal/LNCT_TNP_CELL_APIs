using DemoApiUsingJWT.Request;

namespace DemoApiUsingJWT.Service
{
    public interface INewPostService
    {
        string createNewPost(NewPostRequestModel tblNewPost);

        string updateNewPost(NewPostRequestModel tblNewPost);

        NewPostRequestModel getNewPost(int id);
        List<NewPostRequestModel> GetPostList();

        NewPostRequestModel DeleteNewPost(int id);
    }
}
