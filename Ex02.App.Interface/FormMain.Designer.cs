using System;
using System.Collections;
using System.Security.Cryptography.X509Certificates;
using Ex02.App.Interface;

namespace Ex02.App.InterFace
{
    public partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button buttonExitForm;
            System.Windows.Forms.Label localeLabel;
            System.Windows.Forms.Label linkLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.panelManu = new System.Windows.Forms.Panel();
            this.buttomMatchQuiz = new System.Windows.Forms.Button();
            this.buttonWellBeingTimeUse = new System.Windows.Forms.Button();
            this.buttonEvents = new System.Windows.Forms.Button();
            this.buttonGroups = new System.Windows.Forms.Button();
            this.buttonFetchAlbum = new System.Windows.Forms.Button();
            this.buttonFetchLikePage = new System.Windows.Forms.Button();
            this.buttonListFriends = new System.Windows.Forms.Button();
            this.ButtonFertchPosts = new System.Windows.Forms.Button();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.panelFormMain = new System.Windows.Forms.Panel();
            this.panelUserInfo = new System.Windows.Forms.Panel();
            this.labelUserInfo = new System.Windows.Forms.Label();
            this.birthdayLabel1 = new System.Windows.Forms.Label();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emailLabel1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.Label();
            this.localeLabel1 = new System.Windows.Forms.Label();
            this.buttonPost = new System.Windows.Forms.Button();
            this.listBoxMain = new System.Windows.Forms.ListBox();
            this.labelGanrel = new System.Windows.Forms.Label();
            this.labelPostStatus = new System.Windows.Forms.Label();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.panelWellbeing = new System.Windows.Forms.Panel();
            this.listBoxTimeUse = new System.Windows.Forms.ListBox();
            this.chartWellBeingUse = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonRet = new System.Windows.Forms.Button();
            this.buttonFetchStaistic = new System.Windows.Forms.Button();
            this.panelBase = new System.Windows.Forms.Panel();
            this.AppStatisticsButton = new System.Windows.Forms.Button();
            buttonExitForm = new System.Windows.Forms.Button();
            localeLabel = new System.Windows.Forms.Label();
            linkLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
            this.panelManu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.panelFormMain.SuspendLayout();
            this.panelUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.panelWellbeing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartWellBeingUse)).BeginInit();
            this.panelBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonExitForm
            // 
            buttonExitForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            buttonExitForm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            buttonExitForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            buttonExitForm.Cursor = System.Windows.Forms.Cursors.Hand;
            buttonExitForm.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            buttonExitForm.FlatAppearance.BorderSize = 0;
            buttonExitForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonExitForm.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonExitForm.ForeColor = System.Drawing.SystemColors.Desktop;
            buttonExitForm.Location = new System.Drawing.Point(1352, 0);
            buttonExitForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            buttonExitForm.Name = "buttonExitForm";
            buttonExitForm.Size = new System.Drawing.Size(60, 62);
            buttonExitForm.TabIndex = 86;
            buttonExitForm.Text = "X";
            buttonExitForm.UseVisualStyleBackColor = false;
            buttonExitForm.Click += new System.EventHandler(this.buttonExitForm_Click);
            // 
            // localeLabel
            // 
            localeLabel.AutoSize = true;
            localeLabel.Location = new System.Drawing.Point(73, 137);
            localeLabel.Name = "localeLabel";
            localeLabel.Size = new System.Drawing.Size(60, 20);
            localeLabel.TabIndex = 108;
            localeLabel.Text = "Locale:";
            // 
            // linkLabel
            // 
            linkLabel.AutoSize = true;
            linkLabel.Location = new System.Drawing.Point(73, 109);
            linkLabel.Name = "linkLabel";
            linkLabel.Size = new System.Drawing.Size(42, 20);
            linkLabel.TabIndex = 106;
            linkLabel.Text = "Link:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(73, 81);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(52, 20);
            emailLabel.TabIndex = 104;
            emailLabel.Text = "Email:";
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new System.Drawing.Point(73, 53);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(71, 20);
            birthdayLabel.TabIndex = 102;
            birthdayLabel.Text = "Birthday:";
            // 
            // buttonLogout
            // 
            this.buttonLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.buttonLogout.Location = new System.Drawing.Point(0, 921);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(260, 82);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // panelManu
            // 
            this.panelManu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(127)))), ((int)(((byte)(185)))));
            this.panelManu.Controls.Add(this.AppStatisticsButton);
            this.panelManu.Controls.Add(this.buttomMatchQuiz);
            this.panelManu.Controls.Add(this.buttonWellBeingTimeUse);
            this.panelManu.Controls.Add(this.buttonEvents);
            this.panelManu.Controls.Add(this.buttonGroups);
            this.panelManu.Controls.Add(this.buttonFetchAlbum);
            this.panelManu.Controls.Add(this.buttonFetchLikePage);
            this.panelManu.Controls.Add(this.buttonListFriends);
            this.panelManu.Controls.Add(this.ButtonFertchPosts);
            this.panelManu.Controls.Add(this.buttonLogout);
            this.panelManu.Controls.Add(this.pictureBoxProfile);
            this.panelManu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelManu.Location = new System.Drawing.Point(0, 0);
            this.panelManu.Name = "panelManu";
            this.panelManu.Size = new System.Drawing.Size(260, 1003);
            this.panelManu.TabIndex = 77;
            // 
            // buttomMatchQuiz
            // 
            this.buttomMatchQuiz.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttomMatchQuiz.FlatAppearance.BorderSize = 0;
            this.buttomMatchQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttomMatchQuiz.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttomMatchQuiz.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttomMatchQuiz.Location = new System.Drawing.Point(0, 767);
            this.buttomMatchQuiz.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttomMatchQuiz.Name = "buttomMatchQuiz";
            this.buttomMatchQuiz.Size = new System.Drawing.Size(260, 83);
            this.buttomMatchQuiz.TabIndex = 79;
            this.buttomMatchQuiz.Text = "Match Quiz";
            this.buttomMatchQuiz.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttomMatchQuiz.UseVisualStyleBackColor = true;
            this.buttomMatchQuiz.Click += new System.EventHandler(this.buttonMatchQuiz_Click);
            // 
            // buttonWellBeingTimeUse
            // 
            this.buttonWellBeingTimeUse.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonWellBeingTimeUse.FlatAppearance.BorderSize = 0;
            this.buttonWellBeingTimeUse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWellBeingTimeUse.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWellBeingTimeUse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonWellBeingTimeUse.Location = new System.Drawing.Point(0, 684);
            this.buttonWellBeingTimeUse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonWellBeingTimeUse.Name = "buttonWellBeingTimeUse";
            this.buttonWellBeingTimeUse.Size = new System.Drawing.Size(260, 83);
            this.buttonWellBeingTimeUse.TabIndex = 78;
            this.buttonWellBeingTimeUse.Text = "Well Being";
            this.buttonWellBeingTimeUse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonWellBeingTimeUse.UseVisualStyleBackColor = true;
            this.buttonWellBeingTimeUse.Click += new System.EventHandler(this.buttonWellBeingTimeUse_Click);
            // 
            // buttonEvents
            // 
            this.buttonEvents.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEvents.FlatAppearance.BorderSize = 0;
            this.buttonEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEvents.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEvents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEvents.Location = new System.Drawing.Point(0, 601);
            this.buttonEvents.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEvents.Name = "buttonEvents";
            this.buttonEvents.Size = new System.Drawing.Size(260, 83);
            this.buttonEvents.TabIndex = 76;
            this.buttonEvents.Text = "Events List";
            this.buttonEvents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEvents.UseVisualStyleBackColor = true;
            this.buttonEvents.Click += new System.EventHandler(this.buttonFetchEvents_Click);
            // 
            // buttonGroups
            // 
            this.buttonGroups.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGroups.FlatAppearance.BorderSize = 0;
            this.buttonGroups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGroups.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGroups.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGroups.Location = new System.Drawing.Point(0, 518);
            this.buttonGroups.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonGroups.Name = "buttonGroups";
            this.buttonGroups.Size = new System.Drawing.Size(260, 83);
            this.buttonGroups.TabIndex = 56;
            this.buttonGroups.Text = "Groups List";
            this.buttonGroups.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonGroups.UseVisualStyleBackColor = true;
            this.buttonGroups.Click += new System.EventHandler(this.buttonFetchGroups_Click);
            // 
            // buttonFetchAlbum
            // 
            this.buttonFetchAlbum.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonFetchAlbum.FlatAppearance.BorderSize = 0;
            this.buttonFetchAlbum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFetchAlbum.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFetchAlbum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFetchAlbum.Location = new System.Drawing.Point(0, 435);
            this.buttonFetchAlbum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonFetchAlbum.Name = "buttonFetchAlbum";
            this.buttonFetchAlbum.Size = new System.Drawing.Size(260, 83);
            this.buttonFetchAlbum.TabIndex = 66;
            this.buttonFetchAlbum.Text = "Albums List";
            this.buttonFetchAlbum.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonFetchAlbum.UseVisualStyleBackColor = true;
            this.buttonFetchAlbum.Click += new System.EventHandler(this.buttonFetchAlbum_Click);
            // 
            // buttonFetchLikePage
            // 
            this.buttonFetchLikePage.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonFetchLikePage.FlatAppearance.BorderSize = 0;
            this.buttonFetchLikePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFetchLikePage.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFetchLikePage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFetchLikePage.Location = new System.Drawing.Point(0, 352);
            this.buttonFetchLikePage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonFetchLikePage.Name = "buttonFetchLikePage";
            this.buttonFetchLikePage.Size = new System.Drawing.Size(260, 83);
            this.buttonFetchLikePage.TabIndex = 75;
            this.buttonFetchLikePage.Text = "Pages List";
            this.buttonFetchLikePage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonFetchLikePage.UseVisualStyleBackColor = true;
            this.buttonFetchLikePage.Click += new System.EventHandler(this.buttonFetchLikePage_Click);
            // 
            // buttonListFriends
            // 
            this.buttonListFriends.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonListFriends.FlatAppearance.BorderSize = 0;
            this.buttonListFriends.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonListFriends.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListFriends.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonListFriends.Location = new System.Drawing.Point(0, 269);
            this.buttonListFriends.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonListFriends.Name = "buttonListFriends";
            this.buttonListFriends.Size = new System.Drawing.Size(260, 83);
            this.buttonListFriends.TabIndex = 68;
            this.buttonListFriends.Text = "Friends list";
            this.buttonListFriends.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonListFriends.UseVisualStyleBackColor = true;
            this.buttonListFriends.Click += new System.EventHandler(this.buttonListFriends_Click);
            // 
            // ButtonFertchPosts
            // 
            this.ButtonFertchPosts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonFertchPosts.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonFertchPosts.FlatAppearance.BorderSize = 0;
            this.ButtonFertchPosts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFertchPosts.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonFertchPosts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonFertchPosts.Location = new System.Drawing.Point(0, 186);
            this.ButtonFertchPosts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonFertchPosts.Name = "ButtonFertchPosts";
            this.ButtonFertchPosts.Size = new System.Drawing.Size(260, 83);
            this.ButtonFertchPosts.TabIndex = 58;
            this.ButtonFertchPosts.Text = "Posts list";
            this.ButtonFertchPosts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonFertchPosts.UseVisualStyleBackColor = true;
            this.ButtonFertchPosts.Click += new System.EventHandler(this.buttonFetchPosts_Click);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxProfile.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxProfile.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(260, 186);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProfile.TabIndex = 61;
            this.pictureBoxProfile.TabStop = false;
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(0, 0);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(75, 23);
            this.buttonReturn.TabIndex = 0;
            // 
            // panelFormMain
            // 
            this.panelFormMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelFormMain.Controls.Add(this.panelUserInfo);
            this.panelFormMain.Controls.Add(this.buttonPost);
            this.panelFormMain.Controls.Add(this.listBoxMain);
            this.panelFormMain.Controls.Add(this.labelGanrel);
            this.panelFormMain.Controls.Add(this.labelPostStatus);
            this.panelFormMain.Controls.Add(this.textBoxStatus);
            this.panelFormMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormMain.Location = new System.Drawing.Point(0, 0);
            this.panelFormMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelFormMain.Name = "panelFormMain";
            this.panelFormMain.Size = new System.Drawing.Size(1417, 1003);
            this.panelFormMain.TabIndex = 84;
            // 
            // panelUserInfo
            // 
            this.panelUserInfo.Controls.Add(this.labelUserInfo);
            this.panelUserInfo.Controls.Add(birthdayLabel);
            this.panelUserInfo.Controls.Add(this.birthdayLabel1);
            this.panelUserInfo.Controls.Add(emailLabel);
            this.panelUserInfo.Controls.Add(this.emailLabel1);
            this.panelUserInfo.Controls.Add(linkLabel);
            this.panelUserInfo.Controls.Add(this.linkLabel1);
            this.panelUserInfo.Controls.Add(localeLabel);
            this.panelUserInfo.Controls.Add(this.localeLabel1);
            this.panelUserInfo.Location = new System.Drawing.Point(11, 183);
            this.panelUserInfo.Name = "panelUserInfo";
            this.panelUserInfo.Size = new System.Drawing.Size(565, 786);
            this.panelUserInfo.TabIndex = 102;
            // 
            // labelUserInfo
            // 
            this.labelUserInfo.AutoSize = true;
            this.labelUserInfo.Location = new System.Drawing.Point(3, 17);
            this.labelUserInfo.Name = "labelUserInfo";
            this.labelUserInfo.Size = new System.Drawing.Size(79, 20);
            this.labelUserInfo.TabIndex = 114;
            this.labelUserInfo.Text = "User Info:";
            // 
            // birthdayLabel1
            // 
            this.birthdayLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Birthday", true));
            this.birthdayLabel1.Location = new System.Drawing.Point(172, 53);
            this.birthdayLabel1.Name = "birthdayLabel1";
            this.birthdayLabel1.Size = new System.Drawing.Size(187, 20);
            this.birthdayLabel1.TabIndex = 103;
            this.birthdayLabel1.Text = "label1";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // emailLabel1
            // 
            this.emailLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Email", true));
            this.emailLabel1.Location = new System.Drawing.Point(172, 81);
            this.emailLabel1.Name = "emailLabel1";
            this.emailLabel1.Size = new System.Drawing.Size(224, 23);
            this.emailLabel1.TabIndex = 105;
            this.emailLabel1.Text = "label1";
            // 
            // linkLabel1
            // 
            this.linkLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Link", true));
            this.linkLabel1.Location = new System.Drawing.Point(172, 109);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(371, 20);
            this.linkLabel1.TabIndex = 107;
            this.linkLabel1.Text = "label1";
            // 
            // localeLabel1
            // 
            this.localeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Locale", true));
            this.localeLabel1.Location = new System.Drawing.Point(172, 137);
            this.localeLabel1.Name = "localeLabel1";
            this.localeLabel1.Size = new System.Drawing.Size(173, 23);
            this.localeLabel1.TabIndex = 109;
            this.localeLabel1.Text = "label1";
            // 
            // buttonPost
            // 
            this.buttonPost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPost.FlatAppearance.BorderSize = 0;
            this.buttonPost.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPost.Location = new System.Drawing.Point(1108, 43);
            this.buttonPost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(175, 31);
            this.buttonPost.TabIndex = 86;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // listBoxMain
            // 
            this.listBoxMain.FormattingEnabled = true;
            this.listBoxMain.ItemHeight = 20;
            this.listBoxMain.Location = new System.Drawing.Point(618, 185);
            this.listBoxMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxMain.Name = "listBoxMain";
            this.listBoxMain.Size = new System.Drawing.Size(733, 784);
            this.listBoxMain.TabIndex = 84;
            // 
            // labelGanrel
            // 
            this.labelGanrel.AutoSize = true;
            this.labelGanrel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelGanrel.Location = new System.Drawing.Point(664, 151);
            this.labelGanrel.Name = "labelGanrel";
            this.labelGanrel.Size = new System.Drawing.Size(0, 20);
            this.labelGanrel.TabIndex = 83;
            // 
            // labelPostStatus
            // 
            this.labelPostStatus.AutoSize = true;
            this.labelPostStatus.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.labelPostStatus.Location = new System.Drawing.Point(170, 34);
            this.labelPostStatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPostStatus.Name = "labelPostStatus";
            this.labelPostStatus.Size = new System.Drawing.Size(186, 39);
            this.labelPostStatus.TabIndex = 62;
            this.labelPostStatus.Text = "Post Status:";
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStatus.Location = new System.Drawing.Point(363, 43);
            this.textBoxStatus.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(732, 26);
            this.textBoxStatus.TabIndex = 63;
            // 
            // panelWellbeing
            // 
            this.panelWellbeing.Controls.Add(this.listBoxTimeUse);
            this.panelWellbeing.Controls.Add(this.chartWellBeingUse);
            this.panelWellbeing.Controls.Add(this.buttonRet);
            this.panelWellbeing.Controls.Add(this.buttonFetchStaistic);
            this.panelWellbeing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWellbeing.Location = new System.Drawing.Point(0, 0);
            this.panelWellbeing.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelWellbeing.Name = "panelWellbeing";
            this.panelWellbeing.Size = new System.Drawing.Size(1417, 1003);
            this.panelWellbeing.TabIndex = 85;
            this.panelWellbeing.Visible = false;
            // 
            // listBoxTimeUse
            // 
            this.listBoxTimeUse.FormattingEnabled = true;
            this.listBoxTimeUse.ItemHeight = 20;
            this.listBoxTimeUse.Location = new System.Drawing.Point(147, 518);
            this.listBoxTimeUse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxTimeUse.Name = "listBoxTimeUse";
            this.listBoxTimeUse.Size = new System.Drawing.Size(1124, 224);
            this.listBoxTimeUse.TabIndex = 4;
            // 
            // chartWellBeingUse
            // 
            chartArea1.Name = "ChartArea1";
            this.chartWellBeingUse.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartWellBeingUse.Legends.Add(legend1);
            this.chartWellBeingUse.Location = new System.Drawing.Point(84, 88);
            this.chartWellBeingUse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chartWellBeingUse.Name = "chartWellBeingUse";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Well Begin";
            this.chartWellBeingUse.Series.Add(series1);
            this.chartWellBeingUse.Size = new System.Drawing.Size(1251, 391);
            this.chartWellBeingUse.TabIndex = 3;
            this.chartWellBeingUse.Text = "chartWellBeingUse";
            // 
            // buttonRet
            // 
            this.buttonRet.Location = new System.Drawing.Point(984, 768);
            this.buttonRet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRet.Name = "buttonRet";
            this.buttonRet.Size = new System.Drawing.Size(290, 112);
            this.buttonRet.TabIndex = 2;
            this.buttonRet.Text = "Return";
            this.buttonRet.UseVisualStyleBackColor = true;
            this.buttonRet.Click += new System.EventHandler(this.buttonRet_Click);
            // 
            // buttonFetchStaistic
            // 
            this.buttonFetchStaistic.Location = new System.Drawing.Point(147, 768);
            this.buttonFetchStaistic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonFetchStaistic.Name = "buttonFetchStaistic";
            this.buttonFetchStaistic.Size = new System.Drawing.Size(290, 112);
            this.buttonFetchStaistic.TabIndex = 1;
            this.buttonFetchStaistic.Text = "Fetch Staistic";
            this.buttonFetchStaistic.UseVisualStyleBackColor = true;
            this.buttonFetchStaistic.Click += new System.EventHandler(this.buttonFetchStatistic_Click);
            // 
            // panelBase
            // 
            this.panelBase.Controls.Add(buttonExitForm);
            this.panelBase.Controls.Add(this.panelFormMain);
            this.panelBase.Controls.Add(this.panelWellbeing);
            this.panelBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBase.Location = new System.Drawing.Point(260, 0);
            this.panelBase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelBase.Name = "panelBase";
            this.panelBase.Size = new System.Drawing.Size(1417, 1003);
            this.panelBase.TabIndex = 82;
            // 
            // AppStatisticsButton
            // 
            this.AppStatisticsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AppStatisticsButton.FlatAppearance.BorderSize = 0;
            this.AppStatisticsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AppStatisticsButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppStatisticsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AppStatisticsButton.Location = new System.Drawing.Point(0, 850);
            this.AppStatisticsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AppStatisticsButton.Name = "AppStatisticsButton";
            this.AppStatisticsButton.Size = new System.Drawing.Size(260, 83);
            this.AppStatisticsButton.TabIndex = 80;
            this.AppStatisticsButton.Text = "App statistics";
            this.AppStatisticsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AppStatisticsButton.UseVisualStyleBackColor = true;
            this.AppStatisticsButton.Click += new System.EventHandler(this.AppStatisticsButton_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1677, 1003);
            this.Controls.Add(this.panelBase);
            this.Controls.Add(this.panelManu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelManu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.panelFormMain.ResumeLayout(false);
            this.panelFormMain.PerformLayout();
            this.panelUserInfo.ResumeLayout(false);
            this.panelUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.panelWellbeing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartWellBeingUse)).EndInit();
            this.panelBase.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonGroups;
        private System.Windows.Forms.Button buttonFetchAlbum;
        private System.Windows.Forms.Button buttonListFriends;
        private System.Windows.Forms.Button buttonFetchLikePage;

        private System.Windows.Forms.Button buttonEvents;
        private System.Windows.Forms.Panel panelManu;
        private System.Windows.Forms.Button buttonWellBeingTimeUse;
        private System.Windows.Forms.Button buttomMatchQuiz;
        public System.Windows.Forms.Button ButtonFertchPosts;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Panel panelFormMain;
        private System.Windows.Forms.ListBox listBoxMain;
        private System.Windows.Forms.Label labelGanrel;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Label labelPostStatus;
        private System.Windows.Forms.Panel panelBase;
        private System.Windows.Forms.Panel panelWellbeing;
        private System.Windows.Forms.Button buttonRet;
        private System.Windows.Forms.Button buttonFetchStaistic;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartWellBeingUse;
        private System.Windows.Forms.ListBox listBoxTimeUse;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Panel panelUserInfo;
        private System.Windows.Forms.Label labelUserInfo;
        private System.Windows.Forms.Label birthdayLabel1;
        private System.Windows.Forms.Label emailLabel1;
        private System.Windows.Forms.Label linkLabel1;
        private System.Windows.Forms.Label localeLabel1;
        private System.Windows.Forms.Button AppStatisticsButton;
    }
}

