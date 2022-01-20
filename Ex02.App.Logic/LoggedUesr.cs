using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using Facebook;

namespace Ex02.App.Logic
{
    public class LoggedUesr
    {
        private readonly User r_LoggedInUser;

        public LoggedUesr(LoginResult i_LoginResult)
        {
            r_LoggedInUser = i_LoginResult.LoggedInUser;
        }

        public string Name
        {
            get
            {
                return r_LoggedInUser.Name;
            }
        }

        public string PictureUrl
        {
            get
            {
                return r_LoggedInUser.PictureSmallURL;
            }
        }

        public User FacebookUser
        {
            get
            {
                return r_LoggedInUser;
            }
        }

        public void LogOut()
        {
            FacebookService.Logout();
        }

        public List<string> FetchAlbumsNames()
        {
            List<string> albumsList = new List<string>();
            
            foreach (Album album in r_LoggedInUser.Albums)
            {
                albumsList.Add(album.Name);
            }

            return albumsList;
        }

        public List<string> FetchGroupsNames()
        {
            List<string> groupsList = new List<string>();

            foreach (Group group in r_LoggedInUser.Groups)
            {
                groupsList.Add(group.Name);
            }

            return groupsList;
        }

        public List<string> FetchPosts()
        {
            List<string> postsList = new List<string>();

            foreach (Post post in r_LoggedInUser.Posts)
            {
                if(post.Message != null)
                {
                    postsList.Add(post.Message);
                }
            }

            return postsList;
        }

        public List<string> FetchEvents()
        {
            List<string> eventsList = new List<string>();

            foreach (Event fbEvent in r_LoggedInUser.Events)
            {
                eventsList.Add(fbEvent.Name);
            }

            return eventsList;
        }

        public List<string> FetchLikePage()
        {
            List<string> likedPagesList = new List<string>();

            foreach (Page page in r_LoggedInUser.LikedPages)
            {
                likedPagesList.Add(page.Name);
            }

            return likedPagesList;
        }

        public List<User> FetchListFriends()
        {
            List<User> friendsList = new List<User>();

            foreach (User friend in r_LoggedInUser.Friends)
            {
                friendsList.Add(friend);
            }

            return friendsList;
        }

        public List<string> FetchListFriendsNames()
        {
            List<string> friendsList = new List<string>();

            foreach (User friend in r_LoggedInUser.Friends)
            {
                friendsList.Add(friend.Name);
            }

            return friendsList;
        }

        public Status PostStatus(string i_Topost)
        {
            Status status = r_LoggedInUser.PostStatus(i_Topost);
            return status;
        }
    }
}
