using FontAwesome.Sharp;
using System.ComponentModel;
using System.Drawing.Drawing2D;
//upload the code\\

namespace MunicipalitySystem
{
    public partial class MainForm : Form
    {
        private Color primaryColor = Color.FromArgb(25, 55, 85);
        private Color accentGreen = Color.FromArgb(73, 135, 82);
        private Color accentBlue = Color.FromArgb(45, 95, 160);
        private Color accentOrange = Color.FromArgb(235, 130, 45);
        private Color accentPurple = Color.FromArgb(103, 65, 150);

        public MainForm()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
            
        }
        private void HeroPanel_Resize(object sender, EventArgs e)
        {
            if (heroPanel == null || btnNotifications == null || notificationIcon == null)
                return;

            btnNotifications.Location = new Point(
                heroPanel.ClientSize.Width - btnNotifications.Width - 25,
                25
            );

            notificationIcon.Location = new Point(
                btnNotifications.Left + 10,
                btnNotifications.Top + 15
            );
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            lblDate.Text = $"Today is {DateTime.Now:dddd, dd MMMM yyyy}";
            
        
        }

       
        private void btnIssueReports_Click(object sender, EventArgs e)
        {
            AddIssueForm addIssueForm = new AddIssueForm();

            addIssueForm.ShowDialog();
        }
        

        private void btnServiceRequests_Click(object sender, EventArgs e)
        {
            // Open Service Requests Form
            MessageBox.Show("Opening Service Requests...");
        }

        private void btnAnnouncements_Click(object sender, EventArgs e)
        {
            // Open Announcements Form
            MessageBox.Show("Opening Announcements...");
        }

        private void btnViewReports_Click(object sender, EventArgs e)
        {
            DisplayIssuesForm displayIssuesForm = new DisplayIssuesForm();
            displayIssuesForm.Show();
        }

        private void btnNotifications_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No new notifications.");
        }
    }


    // ============================================================
    // CUSTOM ROUNDED PANEL
    // ============================================================

    public class RoundedPanel : Panel
    {
        private int borderRadius = 20;
        private Color borderColor = Color.Transparent;
        private int borderSize = 0;

        [Category("Appearance")]
        [DefaultValue(20)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int BorderRadius
        {
            get => borderRadius;
            set
            {
                borderRadius = value;
                Invalidate();
            }
        }

        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color BorderColor
        {
            get => borderColor;
            set
            {
                borderColor = value;
                Invalidate();
            }
        }

        [Category("Appearance")]
        [DefaultValue(0)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int BorderSize
        {
            get => borderSize;
            set
            {
                borderSize = value;
                Invalidate();
            }
        }

        public RoundedPanel()
        {
            DoubleBuffered = true;
            ResizeRedraw = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(
                0,
                0,
                Width - 1,
                Height - 1
            );

            using GraphicsPath path = GetRoundedPath(rect, BorderRadius);

            Region = new Region(path);

            if (BorderSize > 0)
            {
                using Pen pen = new Pen(BorderColor, BorderSize);
                e.Graphics.DrawPath(pen, path);
            }
        }

        private GraphicsPath GetRoundedPath(
            Rectangle rect,
            int radius)
        {
            GraphicsPath path = new GraphicsPath();

            int diameter = radius * 2;

            path.AddArc(
                rect.X,
                rect.Y,
                diameter,
                diameter,
                180,
                90
            );

            path.AddArc(
                rect.Right - diameter,
                rect.Y,
                diameter,
                diameter,
                270,
                90
            );

            path.AddArc(
                rect.Right - diameter,
                rect.Bottom - diameter,
                diameter,
                diameter,
                0,
                90
            );

            path.AddArc(
                rect.X,
                rect.Bottom - diameter,
                diameter,
                diameter,
                90,
                90
            );

            path.CloseFigure();

            return path;
        }
    }


    // ============================================================
    // CUSTOM ROUNDED BUTTON
    // ============================================================

    public class RoundedButton : Button
    {
        private int borderRadius = 12;

        [Category("Appearance")]
        [DefaultValue(12)]
        [DesignerSerializationVisibility(
            DesignerSerializationVisibility.Visible)]
        public int BorderRadius
        {
            get => borderRadius;
            set
            {
                borderRadius = value;
                Invalidate();
            }
        }

        public RoundedButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Cursor = Cursors.Hand;
            DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();

            Rectangle rect = new Rectangle(
                0,
                0,
                Width - 1,
                Height - 1
            );

            int diameter = BorderRadius * 2;

            path.AddArc(
                rect.X,
                rect.Y,
                diameter,
                diameter,
                180,
                90
            );

            path.AddArc(
                rect.Right - diameter,
                rect.Y,
                diameter,
                diameter,
                270,
                90
            );

            path.AddArc(
                rect.Right - diameter,
                rect.Bottom - diameter,
                diameter,
                diameter,
                0,
                90
            );

            path.AddArc(
                rect.X,
                rect.Bottom - diameter,
                diameter,
                diameter,
                90,
                90
            );

            path.CloseFigure();

            Region = new Region(path);

            base.OnPaint(e);
        }
    }
}