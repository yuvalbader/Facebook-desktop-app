using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper;

namespace Ex02.App.Logic
{
    internal class FacebookServiceFacade
    {
        private LoginResult m_LoginResult;
        
        private readonly string r_AppID = "414674306946371";
       
        public bool IsUserLoggedIn { get; private set; }

        private string[] m_Permissions = 
        {
            "email",
            "public_profile",
            "user_birthday",
            "user_events",
            "user_friends",
            "user_hometown",
            "user_likes",
            "user_photos", 
            "user_posts",
        };

        internal LoggedUesr LoginToFacebook()
        {
            {
                try
                {
                    if (!IsUserLoggedIn)
                    {
                        m_LoginResult = FacebookService.Login(r_AppID, m_Permissions);
                        IsUserLoggedIn = true;
                        return new LoggedUesr(m_LoginResult);
                    }
                    else
                    {
                        throw new Exception("You already logged in!");
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        internal LoggedUesr ConnectWithAT()
        {

                        m_LoginResult = FacebookService.Connect("EAAF5JOLDVUMBADqClNOfUYqe8gCFSDgSI3VlcRlEqAZA5Mf0ALXkghYWoFXyYxfItCAtNdsw9JWiZCAjPa3TGClcH4rZAghjJIUWJmMidwtqRwjtskOWZAoAugKNY7viUSzT4sKYEgCYqeWSB9arLlhmeIkUNo0eMQnDKwuLMZCASZBmDR6ih4");
                        IsUserLoggedIn = true;
                        return new LoggedUesr(m_LoginResult);
        }

        internal void LogoutFromFacebook()
        {
            if (IsUserLoggedIn)
            {
                FacebookService.Logout(() => IsUserLoggedIn = false);
            }
        }
    }
}
