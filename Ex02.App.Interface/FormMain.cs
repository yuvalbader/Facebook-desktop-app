using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using CefSharp.DevTools.Overlay;
using Ex02.App.Interface;
using Ex02.App.Logic;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace Ex02.App.InterFace
{
    public partial class FormMain : Form
    {
        internal LoggedUesr m_LoggedInUser;

        private readonly TimeUseApp r_TimeUse;

        private Observer Obs= new Observer();

        private FetcherBase[] fetcher = new FetcherBase[] {new  FetchAlbums(), new FetchFriends(), new FetchGroups(), new FetchPosts(), new FetchEvents(), new FethchLikedPages()};

        public FormMain(LoggedUesr i_LoggedInUser)
        {
  
            r_TimeUse = new TimeUseApp(new XMLWrite());
            m_LoggedInUser = i_LoggedInUser;
            InitializeComponent();
            this.Text = string.Format("Logged in as {0}", m_LoggedInUser.Name);
            pictureBoxProfile.LoadAsync(m_LoggedInUser.PictureUrl);
            FacebookService.s_CollectionLimit = 100;
            fetchUserInfo();
        }

        private void fetchUserInfo()
        {
            userBindingSource.DataSource = m_LoggedInUser.FacebookUser;
        }

        private void buttonWellBeingTimeUse_Click(object i_Sender, EventArgs i_)
        {
            this.labelGanrel.Text = "Well Begin Time Use App ";
            this.listBoxMain.DataSource = null;
            panelFormMain.Visible = false;
            panelWellbeing.Visible = true;
            listBoxMain.Items.Clear();
        }
        
        private void buttonFetchAlbum_Click(object i_Sender, EventArgs i_)
        {
            panelWellbeing.Visible = false;
            panelFormMain.Visible = true;
            new Thread(() => fetcher[eFetcherType.Albums.GetHashCode()].Fetch(listBoxMain, m_LoggedInUser)).Start();
        }

        private void buttonListFriends_Click(object sender, EventArgs e)
        {
            panelWellbeing.Visible = false;
            panelFormMain.Visible = true;
            new Thread(() => fetcher[eFetcherType.Friend.GetHashCode()].Fetch(listBoxMain, m_LoggedInUser)).Start();
        }

        private void buttonFetchGroups_Click(object i_Sender, EventArgs i_)
        {
            panelWellbeing.Visible = false;
            panelFormMain.Visible = true;
            new Thread(() => fetcher[eFetcherType.Groups.GetHashCode()].Fetch(listBoxMain, m_LoggedInUser)).Start();
        }

        private void buttonFetchPosts_Click(object i_Sender, EventArgs i_)
        {
            panelWellbeing.Visible = false;
            panelFormMain.Visible = true;
            new Thread(() => fetcher[eFetcherType.Posts.GetHashCode()].Fetch(listBoxMain, m_LoggedInUser)).Start();
        }

        private void buttonFetchEvents_Click(object i_Sender, EventArgs i_)
        {
            panelWellbeing.Visible = false;
            panelFormMain.Visible = true;

            new Thread(()=> fetcher[eFetcherType.Events.GetHashCode()].Fetch(listBoxMain, m_LoggedInUser)).Start();
        }

        private void buttonFetchLikePage_Click(object i_Sender, EventArgs i_)
        {
            panelWellbeing.Visible = false;
            panelFormMain.Visible = true;
            new Thread(() => fetcher[eFetcherType.LikePages.GetHashCode()].Fetch(listBoxMain, m_LoggedInUser)).Start();
        }

        private void buttonMatchQuiz_Click(object i_Sender, EventArgs i_)
        {
            this.listBoxMain.DataSource = null;
            this.panelWellbeing.Visible = false;
            this.panelFormMain.Visible = true;
            SelectionMode selectionMode = this.listBoxMain.SelectionMode;
            this.listBoxMain.SelectionMode = SelectionMode.None;
            this.labelGanrel.Text = "Please Choose a friend for Match Quiz";


            try
            {
                List<User> friendsList = m_LoggedInUser.FetchListFriends();
                this.listBoxMain.DataSource = friendsList;
                this.listBoxMain.SelectionMode = selectionMode;
                this.listBoxMain.SelectedIndexChanged += new System.EventHandler(this.listBoxMain_SelectedIndexChanged);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (listBoxMain.Items.Count == 0)
            {
                MessageBox.Show("No Friends to retrieve :(");
            }

        }

        private void listBoxMain_SelectedIndexChanged(object i_Sender, EventArgs i_)
        {
            this.listBoxMain.SelectedIndexChanged -= new System.EventHandler(this.listBoxMain_SelectedIndexChanged);

            User friendForMatchQuiz = listBoxMain.SelectedItem as User;

            if (friendForMatchQuiz != null)
            {
                FormQuiz formQuiz = FactoryForm.CreateForm(eFormType.Quiz, m_LoggedInUser) as FormQuiz;
                formQuiz.StartFormQuiz(friendForMatchQuiz);
            }
            else
            {
                MessageBox.Show("Please choose a friend");
            }
        }

        private void buttonRet_Click(object sender, EventArgs e)
        {
            panelFormMain.Visible = true;
            panelWellbeing.Visible = false;
        }

        private void buttonFetchStatistic_Click(object sender, EventArgs e)
        {
            List<string> data = r_TimeUse.GetStatisticFromDataBase() as List<string>;
            int indexChart = 0;
            int indexListBox = 0;

            foreach (string str in data)
            {
                float timeUseInMin = 0;
                string[] split = str.Split(',');
                string timeToDis = string.Format("{0}) Date:{1} - UseTime:{2} Days, {3} Hours," + "{4} Minutes, {5} Seconds ", 
                    indexListBox, 
                    split[0], 
                    split[1],
                    split[2],
                    split[3], 
                    split[4]);
                listBoxTimeUse.Items.Add(timeToDis);
                indexListBox++;

                if (float.Parse(split[1]) > 0)
                {
                    timeUseInMin += float.Parse(split[1]) * 60;
                }


                timeUseInMin += float.Parse(split[2]) * 60;
                timeUseInMin += float.Parse(split[3]);
                timeUseInMin += float.Parse(split[4])*60;
                timeUseInMin /= 60;
                if (timeUseInMin > 0)
                {
                    this.chartWellBeingUse.Series["Well Begin"].Points.Add(timeUseInMin);
                    this.chartWellBeingUse.Series["Well Begin"].Points[indexChart].Color = Color.Blue;
                    this.chartWellBeingUse.Series["Well Begin"].Points[indexChart].AxisLabel = split[0];
                    this.chartWellBeingUse.Series["Well Begin"].Points[indexChart].LegendText = split[0];
                    indexChart++;
                }
            }

            this.buttonFetchStaistic.Enabled = false;
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            try
            {
                string post = string.Format("{0}, @{1}", textBoxStatus.Text, m_LoggedInUser.Name);
                Status postedStatus = m_LoggedInUser.PostStatus(post);
                MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonExitForm_Click(object sender, EventArgs e)
        {
            try
            {
                FormMain.ActiveForm.Close();
                r_TimeUse.WriteStatisticToDataBase();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonLogout_Click(object i_Sender, EventArgs i_)
        {
            try
            {
                FormMain.ActiveForm.Close();
                r_TimeUse.WriteStatisticToDataBase();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AppStatisticsButton_Click(object sender, EventArgs e)
        {
            List<string> ButtonsStatistics= new List<string>();

            foreach(KeyValuePair<string,int> pair in Obs.activityStatistics)
            {
               ButtonsStatistics.Add(string.Format("Button {0} was clicked {1} times", pair.Key, pair.Value));
            }

            this.listBoxMain.DataSource = ButtonsStatistics;
        }


    }
}