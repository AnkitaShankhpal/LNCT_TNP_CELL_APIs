using DemoApiUsingJWT.DbModels;

namespace DemoApiUsingJWT.Repository.Implementation
{
    public class NewPostRepository : INewPostRepository
    {
        private CoreDbContext DbContext;

        public NewPostRepository()
        {
            DbContext = new CoreDbContext();
        }
        public string createNewPost(TblNewPost tblNewPost)
        {

            var TNPExist = DbContext.TblTnpmemberRegisters.FirstOrDefault(x => x.Tnpid == tblNewPost.Id);
            var str = "You can not Post ";
            if (TNPExist != null)
            {
                DbContext.TblNewPosts.Add(tblNewPost);
                DbContext.SaveChanges();
                str = "Posted Successfully";
                return str;
            }
            return str;

        }

        public TblNewPost DeleteNewPost(int id)
        {
            var tblNewPost = DbContext.TblNewPosts.FirstOrDefault(x => x.Id == id);
            if (tblNewPost != null)
            {
                DbContext.TblNewPosts.Remove(tblNewPost);
                DbContext.SaveChanges();
                return tblNewPost;
            }
           
            return null;

        }

        public TblNewPost getNewPost(int id)
        {
            var post = DbContext.TblNewPosts.FirstOrDefault(x => x.Id == id);
            if (post != null)
            {
                return post;
            }
            return null;
        }

        
        public List<TblNewPost> GetPostList()
        {
          var result = new List<TblNewPost>();
            return result;
        }

        public string updateNewPost(TblNewPost tblNewPost)
        {
            var postUpdate = DbContext.TblNewPosts.FirstOrDefault(x => x.Id == tblNewPost.Id);
            var str = "not found";
            if (postUpdate != null)
            {
                postUpdate.PostFile = tblNewPost.PostFile;
                postUpdate.Title = tblNewPost.Title ;
                postUpdate.Post = tblNewPost.Post;
                postUpdate.Id=tblNewPost.Id;
                postUpdate.CreatedOn = DateTime.Now;
                DbContext.SaveChanges();
                str = "Updated Successfully";
                return str;
            }
            return str;
        }
    }
}
