using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace Ex02.App.Logic
{
    public class Quiz
    {
        private readonly User r_UserForQuiz;
        private readonly LoggedUesr m_LoggedInUser;
        private int m_CorrectAnswers;
        private int m_CurrentQuastionNumber;
        private QuizQuastion m_CurrentQuastion;
        private  readonly List<QuizQuastion> r_QuastionsArray;

        public enum eZodiac
        {
            None,
            Goat,
            WaterBearer,
            Fish,
            Ram,
            Bull,
            Twins,
            Crab,
            Lion,
            Virgin,
            Balance,
            Scorpion,
            Archer
        }

        public enum eMonth
        {
            January = 1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }

        public Quiz(LoggedUesr i_LoggedInUser, User i_UserForQuiz)
        {
            r_UserForQuiz = i_UserForQuiz;
            m_LoggedInUser = i_LoggedInUser;
            m_CurrentQuastionNumber = 0;
            r_QuastionsArray = new List<QuizQuastion>();
        }

        public string UserForQuizName
        {
            get
            {
                return r_UserForQuiz.Name;
            }
        }

        public string Quastion
        {
            get
            {
                return r_QuastionsArray[m_CurrentQuastionNumber].Quastion;
            }
        }

        public int NumberQuastions
        {
            get
            {
                return r_QuastionsArray.Count;
            }
        }

        public void StartMatchQuiz()
        {
            setQuastions();
            m_CurrentQuastion = r_QuastionsArray[m_CurrentQuastionNumber];
        }

        private void setQuastions()
        {
            Random rnd = new Random();

            r_QuastionsArray.Add(
                new QuizQuastion(
                    $"Would you date with someone who lives in {FetchUserCityName()}?",
                    true));
            r_QuastionsArray.Add(
                new QuizQuastion(
                    $"Would you date with someone who fan of {FetchUserFavoriteTeams()[rnd.Next(0, FetchUserFavoriteTeams().Length)]}?",
                    true));
            r_QuastionsArray.Add(
                new QuizQuastion(
                    $"Would you date with someone who learned at {FetchUserEducations()[rnd.Next(0, FetchUserEducations().Length)]}?",
                    true));

            r_QuastionsArray.Add(
                new QuizQuastion(
                    $"Would you date with someone who may go to {FetchUserEventsMaybe()[rnd.Next(0, FetchUserEducations().Length)]}?",
                true));

            r_QuastionsArray.Add(
                new QuizQuastion(
                    $"Would you date with someone that his sign of the zodiac is {FetchUserSignOfTheZodiac()}?",
                    true));

            r_QuastionsArray.Add(
                new QuizQuastion(
                    $"Would you date with someone who used to CheckIn at {FetchUserCheckIns()[rnd.Next(0, FetchUserCheckIns().Count)]}?",
                    true));
        }

        public void CheckAnswer(bool i_Answer)
        {
            if (i_Answer && m_CurrentQuastion.RequiredAnswer == true)
            {
                m_CorrectAnswers++;
            }
            else if (i_Answer && m_CurrentQuastion.RequiredAnswer == false)
            {
                m_CorrectAnswers++;
            }
        }

        public bool IsQuizEnd()
        {
            bool res = false;
            if (m_CurrentQuastionNumber + 1 == r_QuastionsArray.Count)
            {
                res = true;
            }
            else if (m_CurrentQuastionNumber < r_QuastionsArray.Count)
            {
                m_CurrentQuastionNumber++;
                m_CurrentQuastion = r_QuastionsArray[m_CurrentQuastionNumber];
            }

            return res;
        }

        public float GetResulet()
        {
            return (float)(m_CorrectAnswers) / r_QuastionsArray.Count * 100;
        }

        public string FetchUserCityName()
        { 
            return r_UserForQuiz.Hometown.Name;
        }

        private Page[] FetchUserFavoriteTeams()
        {
            return r_UserForQuiz.FavofriteTeams;
        }

        private FacebookObjectCollection<Event> FetchUserEventsMaybe()
        {
            return r_UserForQuiz.EventsMaybe;
        }

        private Education[] FetchUserEducations()
        {
            return r_UserForQuiz.Educations;
        }

        private FacebookObjectCollection<Checkin> FetchUserCheckIns()
        {
            return r_UserForQuiz.Checkins;
        }

        private eZodiac FetchUserSignOfTheZodiac()
        {
            string[] birthDayArray = r_UserForQuiz.Birthday.Split('/');
            int birthDay = int.Parse(birthDayArray[1]);
            eMonth birthMonth = (eMonth)int.Parse(birthDayArray[0]);
            eZodiac userZodiac;

            switch (birthMonth)
            {
                case eMonth.January:
                    if (birthDay >= 1 & birthDay <= 19)
                    {
                        userZodiac = eZodiac.Goat;
                    }
                    else
                    {
                        userZodiac = eZodiac.WaterBearer;
                    }

                    break;
                case eMonth.February:
                    if (birthDay >= 1 & birthDay <= 18)
                    {
                        userZodiac = eZodiac.WaterBearer;
                    }
                    else
                    {
                        userZodiac = eZodiac.Fish;
                    }

                    break;
                case eMonth.March:
                    if (birthDay >= 21)
                    {
                        userZodiac = eZodiac.Ram;
                    }
                    else
                    {
                        userZodiac = eZodiac.Fish;
                    }

                    break;
                case eMonth.April:
                    if (birthDay >= 1 & birthDay <= 19)
                    {
                        userZodiac = eZodiac.Ram;
                    }
                    else
                    {
                        userZodiac = eZodiac.Bull;
                    }

                    break;
                case eMonth.May:
                    if (birthDay >= 1 & birthDay <= 20)
                    {
                        userZodiac = eZodiac.Bull;
                    }
                    else
                    {
                        userZodiac = eZodiac.Twins;
                    }

                    break;
                case eMonth.June:
                    if (birthDay >= 1 & birthDay <= 21)
                    {
                        userZodiac = eZodiac.Twins;
                    }
                    else
                    {
                        userZodiac = eZodiac.Crab;
                    }

                    break;
                case eMonth.July:
                    if (birthDay >= 1 & birthDay <= 22)
                    {
                        userZodiac = eZodiac.Crab;
                    }
                    else
                    {
                        userZodiac = eZodiac.Lion;
                    }

                    break;
                case eMonth.August:
                    if (birthDay >= 1 & birthDay <= 22)
                    {
                        userZodiac = eZodiac.Lion;
                    }
                    else
                    {
                        userZodiac = eZodiac.Virgin;
                    }

                    break;
                case eMonth.September:
                    if (birthDay >= 1 & birthDay <= 22)
                    {
                        userZodiac = eZodiac.Virgin;
                    }
                    else
                    {
                        userZodiac = eZodiac.Balance;
                    }

                    break;
                case eMonth.October:
                    if (birthDay >= 1 & birthDay <= 22)
                    {
                        userZodiac = eZodiac.Balance;
                    }
                    else
                    {
                        userZodiac = eZodiac.Scorpion;
                    }

                    break;
                case eMonth.November:
                    if (birthDay >= 1 & birthDay <= 21)
                    {
                        userZodiac = eZodiac.Scorpion;
                    }
                    else
                    {
                        userZodiac = eZodiac.Archer;
                    }

                    break;
                case eMonth.December:
                    if (birthDay >= 1 & birthDay <= 21)
                    {
                        userZodiac = eZodiac.Archer;
                    }
                    else
                    {
                        userZodiac = eZodiac.Goat;
                    }

                    break;
                default:
                    {
                        userZodiac = eZodiac.None;
                        break;
                    }
            }

            return userZodiac;
        }
    }
}
