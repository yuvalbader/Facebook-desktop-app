using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex02.App.Logic;

namespace Ex02.App.Interface
{

    class FetchAlbums : FetcherBase
    {
        protected override List<string> getList(LoggedUesr i_LoggedUesr)
        {
            return i_LoggedUesr.FetchAlbumsNames();
        }
    }

    class FetchFriends : FetcherBase
    {
        protected override List<string> getList(LoggedUesr i_LoggedUesr)
        {
            return i_LoggedUesr.FetchListFriendsNames();
        }
    }

    class FetchGroups : FetcherBase
    {
        protected override List<string> getList(LoggedUesr i_LoggedUesr)
        {
            return i_LoggedUesr.FetchGroupsNames();
        }
    }

    class FetchPosts : FetcherBase
    {
        protected override List<string> getList(LoggedUesr i_LoggedUesr)
        {
            return i_LoggedUesr.FetchPosts();
        }
    }

    class FetchEvents : FetcherBase
    {
        protected override List<string> getList(LoggedUesr i_LoggedUesr)
        {
            return i_LoggedUesr.FetchEvents();
        }
    }

    class FethchLikedPages: FetcherBase
    {
        protected override List<string> getList(LoggedUesr i_LoggedUesr)
        {
            return i_LoggedUesr.FetchLikePage();
        }
    }
}

    