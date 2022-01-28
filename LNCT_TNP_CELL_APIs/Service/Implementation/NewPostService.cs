using DemoApiUsingJWT.DbModels;
using DemoApiUsingJWT.Repository;
using DemoApiUsingJWT.Request;

namespace DemoApiUsingJWT.Service.Implementation
{
    public class NewPostService : INewPostService
    {
        private INewPostRepository _newPostRepository;

        public NewPostService(INewPostRepository newPostRepository)
        {
            _newPostRepository = newPostRepository;
        }
        public string createNewPost(NewPostRequestModel tblNewPost)
        {
            TblNewPost tblpost = new TblNewPost();
            tblpost.Post = tblNewPost.Post;
            tblpost.PostFile = tblNewPost.PostFile;
            tblpost.CreatedOn = DateTime.Now;
            tblpost.Title = tblNewPost.Title;
            return (_newPostRepository.createNewPost(tblpost));
        }

        public NewPostRequestModel DeleteNewPost(int id)
        {
            NewPostRequestModel stdDelete = new NewPostRequestModel();
            var result = _newPostRepository.DeleteNewPost(id);
            stdDelete.Post = result.Post;
            stdDelete.PostFile = result.PostFile;
            stdDelete.Title= result.Title;
            stdDelete.CreatedOn = DateTime.Now;


            return stdDelete;
        }

        public NewPostRequestModel getNewPost(int id)
        {
            NewPostRequestModel str = new NewPostRequestModel();
            var result = _newPostRepository.getNewPost(id);
            str.Id = result.Id;
            str.Post = result.Post;
            str.PostFile = result.PostFile;
            str.Title=result.Title;
            str.CreatedOn = DateTime.Now;   
            // str.StudentId = result.StudentId;
            // str.CreatedOn = result.CreatedOn;

            return str;
        }

        public List<NewPostRequestModel> GetPostList()
        {
            List<NewPostRequestModel> list = new List<NewPostRequestModel>();
            var result = _newPostRepository.GetPostList();
            foreach (var item in result)
            {
                NewPostRequestModel str = new NewPostRequestModel();
                str.Id = item.Id;
                str.Title = item.Title;
                str.PostFile = item.PostFile;
                str.Post = item.Post;
                str.CreatedOn= DateTime.Now;
                //str.CreatedOn = item.CreatedOn;
                list.Add(str);
            }
            return list;
        }

        public string updateNewPost(NewPostRequestModel tblNewPost)
        {

            TblNewPost tblpost = new TblNewPost();
            tblpost.Id = tblNewPost.Id;
            tblpost.PostFile = tblNewPost.PostFile;
            tblpost.Post = tblNewPost.Post;
            tblpost.Title = tblNewPost.Title;
            tblpost.CreatedOn = DateTime.Now;
            return (_newPostRepository.updateNewPost(tblpost));
            
        }
    }
}
