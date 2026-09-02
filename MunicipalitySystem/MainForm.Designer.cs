using FontAwesome.Sharp;

namespace MunicipalitySystem
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel sidebarPanel;
        private Panel contentPanel;

        private RoundedPanel logoPanel;
        private Label lblMunicipality;
        private Label lblServices;
        private IconPictureBox picMunicipalityIcon;

        private RoundedButton btnHome;
        private IconPictureBox iconHome;

        private RoundedPanel userPanel;
        private IconPictureBox userIcon;
        private Label lblWelcomeUser;

        private Panel heroPanel;
        private Label lblWelcome;
        private Label lblMunicipalityServices;
        private Label lblDescription;

        private RoundedPanel datePanel;
        private IconPictureBox calendarIcon;
        private Label lblDate;
        private Label lblCommunity;

        private RoundedButton btnNotifications;
        private IconPictureBox notificationIcon;

        private TableLayoutPanel servicesLayout;

        private RoundedPanel issueCard;
        private RoundedPanel requestCard;
        private RoundedPanel announcementCard;
        private RoundedPanel reportCard;

        private IconPictureBox issueIcon;
        private IconPictureBox requestIcon;
        private IconPictureBox announcementIcon;
        private IconPictureBox reportIcon;

        private Label lblIssueTitle;
        private Label lblRequestTitle;
        private Label lblAnnouncementTitle;
        private Label lblReportTitle;

        private Label lblIssueDescription;
        private Label lblRequestDescription;
        private Label lblAnnouncementDescription;
        private Label lblReportDescription;

        private RoundedButton btnIssueReports;
        private RoundedButton btnServiceRequests;
        private RoundedButton btnAnnouncements;
        private RoundedButton btnViewReports;

        private Panel cardsContainer;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            sidebarPanel = new Panel();
            contentPanel = new Panel();

            logoPanel = new RoundedPanel();
            picMunicipalityIcon = new IconPictureBox();
            lblMunicipality = new Label();
            lblServices = new Label();

            btnHome = new RoundedButton();
            iconHome = new IconPictureBox();

            userPanel = new RoundedPanel();
            userIcon = new IconPictureBox();
            lblWelcomeUser = new Label();

            heroPanel = new Panel();
            lblWelcome = new Label();
            lblMunicipalityServices = new Label();
            lblDescription = new Label();

            datePanel = new RoundedPanel();
            calendarIcon = new IconPictureBox();
            lblDate = new Label();
            lblCommunity = new Label();

            btnNotifications = new RoundedButton();
            notificationIcon = new IconPictureBox();

            cardsContainer = new Panel();
            servicesLayout = new TableLayoutPanel();

            issueCard = new RoundedPanel();
            requestCard = new RoundedPanel();
            announcementCard = new RoundedPanel();
            reportCard = new RoundedPanel();

            issueIcon = new IconPictureBox();
            requestIcon = new IconPictureBox();
            announcementIcon = new IconPictureBox();
            reportIcon = new IconPictureBox();

            lblIssueTitle = new Label();
            lblRequestTitle = new Label();
            lblAnnouncementTitle = new Label();
            lblReportTitle = new Label();

            lblIssueDescription = new Label();
            lblRequestDescription = new Label();
            lblAnnouncementDescription = new Label();
            lblReportDescription = new Label();

            btnIssueReports = new RoundedButton();
            btnServiceRequests = new RoundedButton();
            btnAnnouncements = new RoundedButton();
            btnViewReports = new RoundedButton();

            SuspendLayout();


            // =====================================================
            // MAIN FORM
            // =====================================================

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;

            BackColor = Color.FromArgb(245, 247, 250);

            ClientSize = new Size(1500, 900);

            Font = new Font(
                "Segoe UI",
                10F,
                FontStyle.Regular,
                GraphicsUnit.Point
            );

            MinimumSize = new Size(1200, 750);

            Name = "MainForm";

            StartPosition = FormStartPosition.CenterScreen;

            Text = "Municipality Services";

            Load += MainForm_Load;


            // =====================================================
            // SIDEBAR
            // =====================================================

            sidebarPanel.BackColor = Color.FromArgb(22, 48, 76);

            sidebarPanel.Dock = DockStyle.Left;

            sidebarPanel.Width = 230;


            // =====================================================
            // LOGO PANEL
            // =====================================================

            logoPanel.BackColor = Color.FromArgb(22, 48, 76);

            logoPanel.Location = new Point(15, 25);

            logoPanel.Size = new Size(200, 180);

            logoPanel.Anchor = AnchorStyles.Top |
                               AnchorStyles.Left |
                               AnchorStyles.Right;


            // Municipality Icon

            picMunicipalityIcon.BackColor = Color.Transparent;

            picMunicipalityIcon.IconChar = IconChar.BuildingColumns;

            picMunicipalityIcon.IconColor = Color.White;

            picMunicipalityIcon.IconFont = IconFont.Auto;

            picMunicipalityIcon.IconSize = 70;

            picMunicipalityIcon.Location = new Point(65, 10);

            picMunicipalityIcon.Size = new Size(70, 70);

            picMunicipalityIcon.SizeMode = PictureBoxSizeMode.CenterImage;


            // Municipality Label

            lblMunicipality.AutoSize = false;

            lblMunicipality.BackColor = Color.Transparent;

            lblMunicipality.Font = new Font(
                "Segoe UI",
                18F,
                FontStyle.Bold
            );

            lblMunicipality.ForeColor = Color.White;

            lblMunicipality.Location = new Point(10, 90);

            lblMunicipality.Size = new Size(180, 40);

            lblMunicipality.Text = "Municipality";

            lblMunicipality.TextAlign = ContentAlignment.MiddleCenter;


            // Services Label

            lblServices.AutoSize = false;

            lblServices.BackColor = Color.Transparent;

            lblServices.Font = new Font(
                "Segoe UI",
                12F
            );

            lblServices.ForeColor = Color.FromArgb(210, 220, 230);

            lblServices.Location = new Point(10, 130);

            lblServices.Size = new Size(180, 30);

            lblServices.Text = "Services";

            lblServices.TextAlign = ContentAlignment.MiddleCenter;


            logoPanel.Controls.Add(picMunicipalityIcon);
            logoPanel.Controls.Add(lblMunicipality);
            logoPanel.Controls.Add(lblServices);


            // =====================================================
            // HOME BUTTON
            // =====================================================

            btnHome.BackColor = Color.FromArgb(45, 72, 102);

            btnHome.ForeColor = Color.White;

            btnHome.FlatAppearance.BorderSize = 0;

            btnHome.Font = new Font(
                "Segoe UI",
                11F,
                FontStyle.Bold
            );

            btnHome.Location = new Point(15, 250);

            btnHome.Size = new Size(200, 55);

            btnHome.Text = "     Home";

            btnHome.TextAlign = ContentAlignment.MiddleLeft;

            btnHome.BorderRadius = 12;


            // Home Icon

            iconHome.BackColor = Color.Transparent;

            iconHome.IconChar = IconChar.House;

            iconHome.IconColor = Color.White;

            iconHome.IconFont = IconFont.Auto;

            iconHome.IconSize = 25;

            iconHome.Location = new Point(30, 265);

            iconHome.Size = new Size(30, 30);

            iconHome.SizeMode = PictureBoxSizeMode.CenterImage;


            // =====================================================
            // USER PANEL
            // =====================================================

            userPanel.BackColor = Color.FromArgb(39, 67, 97);

            userPanel.BorderRadius = 15;

            userPanel.Dock = DockStyle.Bottom;

            userPanel.Height = 90;

            userPanel.Margin = new Padding(15);


            // User Icon

            userIcon.BackColor = Color.Transparent;

            userIcon.IconChar = IconChar.CircleUser;

            userIcon.IconColor = Color.White;

            userIcon.IconFont = IconFont.Auto;

            userIcon.IconSize = 55;

            userIcon.Location = new Point(15, 18);

            userIcon.Size = new Size(55, 55);


            // User Label

            lblWelcomeUser.AutoSize = false;

            lblWelcomeUser.BackColor = Color.Transparent;

            lblWelcomeUser.Font = new Font(
                "Segoe UI",
                10F
            );

            lblWelcomeUser.ForeColor = Color.White;

            lblWelcomeUser.Location = new Point(80, 22);

            lblWelcomeUser.Size = new Size(130, 50);

            lblWelcomeUser.Text = "Welcome,\nCitizen";

            lblWelcomeUser.TextAlign = ContentAlignment.MiddleLeft;


            userPanel.Controls.Add(userIcon);
            userPanel.Controls.Add(lblWelcomeUser);


            sidebarPanel.Controls.Add(userPanel);
            sidebarPanel.Controls.Add(iconHome);
            sidebarPanel.Controls.Add(btnHome);
            sidebarPanel.Controls.Add(logoPanel);


            // =====================================================
            // CONTENT PANEL
            // =====================================================

            contentPanel.BackColor = Color.FromArgb(245, 247, 250);

            contentPanel.Dock = DockStyle.Fill;

            contentPanel.Padding = new Padding(35, 25, 35, 30);


            // =====================================================
            // HERO PANEL
            // =====================================================

            heroPanel.BackColor = Color.White;

            heroPanel.Dock = DockStyle.Top;

            heroPanel.Height = 390;


            // Welcome Label

            lblWelcome.AutoSize = true;

            lblWelcome.Font = new Font(
                "Segoe UI",
                22F,
                FontStyle.Regular
            );

            lblWelcome.ForeColor = Color.FromArgb(60, 70, 80);

            lblWelcome.Location = new Point(30, 35);

            lblWelcome.Text = "Welcome to";


            // Main Title

            lblMunicipalityServices.AutoSize = true;

            lblMunicipalityServices.Font = new Font(
                "Segoe UI",
                40F,
                FontStyle.Bold
            );

            lblMunicipalityServices.ForeColor = Color.FromArgb(30, 58, 90);

            lblMunicipalityServices.Location = new Point(25, 80);

            lblMunicipalityServices.Text = "Municipality Services";


            // Description

            lblDescription.AutoSize = false;

            lblDescription.Font = new Font(
                "Segoe UI",
                14F
            );

            lblDescription.ForeColor = Color.FromArgb(85, 95, 105);

            lblDescription.Location = new Point(30, 180);

            lblDescription.Size = new Size(620, 80);

            lblDescription.Text =
                "We are here to serve you better. Access municipal services,\n" +
                "report issues, make requests and stay informed.";

            lblDescription.TextAlign = ContentAlignment.MiddleLeft;


            // =====================================================
            // DATE PANEL
            // =====================================================

            datePanel.BackColor = Color.FromArgb(250, 252, 253);

            datePanel.BorderColor = Color.FromArgb(225, 230, 235);

            datePanel.BorderSize = 1;

            datePanel.BorderRadius = 18;

            datePanel.Location = new Point(30, 285);

            datePanel.Size = new Size(440, 80);


            // Calendar Icon

            calendarIcon.BackColor = Color.FromArgb(75, 135, 85);

            calendarIcon.IconChar = IconChar.CalendarDays;

            calendarIcon.IconColor = Color.White;

            calendarIcon.IconFont = IconFont.Auto;

            calendarIcon.IconSize = 35;

            calendarIcon.Location = new Point(18, 20);

            calendarIcon.Size = new Size(40, 40);


            // Date Label

            lblDate.AutoSize = true;

            lblDate.Font = new Font(
                "Segoe UI",
                11F,
                FontStyle.Bold
            );

            lblDate.ForeColor = Color.FromArgb(70, 110, 75);

            lblDate.Location = new Point(75, 18);

            lblDate.Text = "Today is";


            // Community Label

            lblCommunity.AutoSize = true;

            lblCommunity.Font = new Font(
                "Segoe UI",
                10F
            );

            lblCommunity.ForeColor = Color.FromArgb(100, 105, 110);

            lblCommunity.Location = new Point(75, 45);

            lblCommunity.Text = "Working together for a better community.";


            datePanel.Controls.Add(calendarIcon);
            datePanel.Controls.Add(lblDate);
            datePanel.Controls.Add(lblCommunity);


            // =====================================================
            // NOTIFICATIONS BUTTON
            // =====================================================

            btnNotifications.BackColor = Color.White;

            btnNotifications.ForeColor = Color.FromArgb(55, 65, 75);

            btnNotifications.Font = new Font(
                "Segoe UI",
                10F,
                FontStyle.Regular
            );

            btnNotifications.Location = new Point(0, 0);

            btnNotifications.Size = new Size(150, 55);

            btnNotifications.Text = "Notifications";

            btnNotifications.Anchor =
                AnchorStyles.Top | AnchorStyles.Right;

            btnNotifications.Click += btnNotifications_Click;


            // Notification Icon

            notificationIcon.BackColor = Color.Transparent;

            notificationIcon.IconChar = IconChar.Bell;

            notificationIcon.IconColor = Color.FromArgb(50, 60, 70);

            notificationIcon.IconFont = IconFont.Auto;

            notificationIcon.IconSize = 23;

            notificationIcon.Location = new Point(12, 15);

            notificationIcon.Size = new Size(25, 25);

            notificationIcon.BringToFront();


            heroPanel.Controls.Add(lblWelcome);
            heroPanel.Controls.Add(lblMunicipalityServices);
            heroPanel.Controls.Add(lblDescription);
            heroPanel.Controls.Add(datePanel);
            heroPanel.Controls.Add(btnNotifications);
            heroPanel.Controls.Add(notificationIcon);


            // Notification Position Handler

            heroPanel.Resize += HeroPanel_Resize;


            // =====================================================
            // CARDS CONTAINER
            // =====================================================

            cardsContainer.Dock = DockStyle.Fill;

            cardsContainer.Padding = new Padding(0, 25, 0, 0);

            cardsContainer.BackColor = Color.FromArgb(245, 247, 250);


            // =====================================================
            // TABLE LAYOUT
            // =====================================================

            servicesLayout.Dock = DockStyle.Fill;

            servicesLayout.ColumnCount = 4;

            servicesLayout.RowCount = 1;

            servicesLayout.Padding = new Padding(0);

            servicesLayout.BackColor = Color.Transparent;

            servicesLayout.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 25F)
            );

            servicesLayout.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 25F)
            );

            servicesLayout.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 25F)
            );

            servicesLayout.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 25F)
            );


            // =====================================================
            // ISSUE REPORT CARD
            // =====================================================

            SetupServiceCard(
                issueCard,
                issueIcon,
                lblIssueTitle,
                lblIssueDescription,
                btnIssueReports,
                IconChar.FileCircleExclamation,
                "Issue Reports",
                "Report issues in your area such as potholes, broken lights, waste problems and more.",
                "Report an Issue",
                Color.FromArgb(72, 130, 80)
            );

            btnIssueReports.Click += btnIssueReports_Click;


            // =====================================================
            // SERVICE REQUEST CARD
            // =====================================================

            SetupServiceCard(
                requestCard,
                requestIcon,
                lblRequestTitle,
                lblRequestDescription,
                btnServiceRequests,
                IconChar.ScrewdriverWrench,
                "Service Requests",
                "Request municipal services including water, electricity, sanitation and more.",
                "Request a Service",
                Color.FromArgb(45, 90, 155)
            );

            btnServiceRequests.Click += btnServiceRequests_Click;


            // =====================================================
            // ANNOUNCEMENTS CARD
            // =====================================================

            SetupServiceCard(
                announcementCard,
                announcementIcon,
                lblAnnouncementTitle,
                lblAnnouncementDescription,
                btnAnnouncements,
                IconChar.Bullhorn,
                "Announcements",
                "Stay updated with the latest announcements, news and important information.",
                "View Announcements",
                Color.FromArgb(235, 125, 40)
            );

            btnAnnouncements.Click += btnAnnouncements_Click;


            // =====================================================
            // VIEW REPORTS CARD
            // =====================================================

            SetupServiceCard(
                reportCard,
                reportIcon,
                lblReportTitle,
                lblReportDescription,
                btnViewReports,
                IconChar.ChartColumn,
                "View Reports",
                "View and track your submitted reports and requests in one place.",
                "View My Reports",
                Color.FromArgb(100, 65, 150)
            );

            btnViewReports.Click += btnViewReports_Click;


            // =====================================================
            // ADD CARDS TO TABLE
            // =====================================================

            servicesLayout.Controls.Add(issueCard, 0, 0);
            servicesLayout.Controls.Add(requestCard, 1, 0);
            servicesLayout.Controls.Add(announcementCard, 2, 0);
            servicesLayout.Controls.Add(reportCard, 3, 0);


            cardsContainer.Controls.Add(servicesLayout);


            // =====================================================
            // ADD CONTENT
            // =====================================================

            contentPanel.Controls.Add(cardsContainer);
            contentPanel.Controls.Add(heroPanel);


            // =====================================================
            // ADD FORM CONTROLS
            // =====================================================

            Controls.Add(contentPanel);
            Controls.Add(sidebarPanel);

            ResumeLayout(false);
        }


        // ============================================================
        // REUSABLE SERVICE CARD METHOD
        // ============================================================

        private void SetupServiceCard(
            RoundedPanel card,
            IconPictureBox icon,
            Label title,
            Label description,
            RoundedButton button,
            IconChar iconType,
            string titleText,
            string descriptionText,
            string buttonText,
            Color accentColor)
        {
            card.BackColor = Color.White;

            card.BorderRadius = 20;

            card.BorderColor = Color.FromArgb(225, 228, 232);

            card.BorderSize = 1;

            card.Margin = new Padding(8);

            card.Dock = DockStyle.Fill;

            card.Padding = new Padding(20);


            // Icon

            icon.BackColor = Color.Transparent;

            icon.IconChar = iconType;

            icon.IconColor = accentColor;

            icon.IconFont = IconFont.Auto;

            icon.IconSize = 65;

            icon.Location = new Point(
                (card.Width - 65) / 2,
                30
            );

            icon.Size = new Size(65, 65);

            icon.Anchor = AnchorStyles.Top;


            // Title

            title.AutoSize = false;

            title.Font = new Font(
                "Segoe UI",
                16F,
                FontStyle.Bold
            );

            title.ForeColor = accentColor;

            title.Location = new Point(15, 115);

            title.Size = new Size(250, 40);

            title.Text = titleText;

            title.TextAlign = ContentAlignment.MiddleCenter;

            title.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Left |
                AnchorStyles.Right;


            // Description

            description.AutoSize = false;

            description.Font = new Font(
                "Segoe UI",
                10F
            );

            description.ForeColor =
                Color.FromArgb(90, 95, 105);

            description.Location = new Point(25, 165);

            description.Size = new Size(230, 100);

            description.Text = descriptionText;

            description.TextAlign = ContentAlignment.TopCenter;

            description.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Left |
                AnchorStyles.Right;


            // Button

            button.BackColor = accentColor;

            button.ForeColor = Color.White;

            button.Font = new Font(
                "Segoe UI",
                10F,
                FontStyle.Bold
            );

            button.Height = 50;

            button.Text = buttonText;

            button.TextAlign = ContentAlignment.MiddleCenter;

            button.BorderRadius = 12;

            button.Anchor =
                AnchorStyles.Bottom |
                AnchorStyles.Left |
                AnchorStyles.Right;


            card.Controls.Add(icon);
            card.Controls.Add(title);
            card.Controls.Add(description);
            card.Controls.Add(button);


            // Responsive positioning

            card.Resize += (s, e) =>
            {
                icon.Location =
                    new Point(
                        (card.Width - icon.Width) / 2,
                        30
                    );

                title.Width =
                    card.Width - 30;

                description.Width =
                    card.Width - 50;

                button.Width =
                    card.Width - 40;

                button.Location =
                    new Point(
                        20,
                        card.Height - 70
                    );
            };


            // Hover Effect

            card.MouseEnter += (s, e) =>
            {
                card.BackColor =
                    Color.FromArgb(250, 252, 255);
            };

            card.MouseLeave += (s, e) =>
            {
                card.BackColor = Color.White;
            };
        }

        #endregion
    }
}