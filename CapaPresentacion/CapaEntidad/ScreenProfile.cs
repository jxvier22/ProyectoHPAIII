using System.Windows.Forms;
using System.Drawing;

namespace CapaEntidad.HPA_UI
{
    public partial class ScreenProfile : UserControl
    {
        public ScreenProfile()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            lbl = new Label();
            panel = new Panel();
            avatar = new Panel();
            name = new Label();
            email = new Label();
            left = new FlowLayoutPanel();
            info = new Panel();
            left.SuspendLayout();
            info.SuspendLayout();
            SuspendLayout();
            // 
            // lbl
            // 
            lbl.Location = new Point(0, 0);
            lbl.Name = "lbl";
            lbl.Size = new Size(100, 23);
            lbl.TabIndex = 1;
            // 
            // panel
            // 
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Size = new Size(200, 100);
            panel.TabIndex = 0;
            // 
            // avatar
            // 
            avatar.Location = new Point(3, 3);
            avatar.Name = "avatar";
            avatar.Size = new Size(200, 100);
            avatar.TabIndex = 0;
            // 
            // name
            // 
            name.Location = new Point(0, 0);
            name.Name = "name";
            name.Size = new Size(100, 23);
            name.TabIndex = 0;
            // 
            // email
            // 
            email.Location = new Point(0, 0);
            email.Name = "email";
            email.Size = new Size(100, 23);
            email.TabIndex = 1;
            // 
            // left
            // 
            left.Controls.Add(avatar);
            left.Controls.Add(info);
            left.Location = new Point(0, 0);
            left.Name = "left";
            left.Size = new Size(200, 100);
            left.TabIndex = 0;
            // 
            // info
            // 
            info.Controls.Add(name);
            info.Controls.Add(email);
            info.Location = new Point(3, 109);
            info.Name = "info";
            info.Size = new Size(200, 100);
            info.TabIndex = 1;
            // 
            // ScreenProfile
            // 
            BackColor = Color.FromArgb(40, 40, 40);
            Controls.Add(left);
            Controls.Add(lbl);
            Name = "ScreenProfile";
            Size = new Size(1134, 392);
            left.ResumeLayout(false);
            info.ResumeLayout(false);
            ResumeLayout(false);
        }
        private Label lbl;
        private Panel panel;
        private Panel avatar;
        private Label name;
        private Label email;
        private FlowLayoutPanel left;
        private Panel info;
    }
}
