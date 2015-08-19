using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Runmono
{
    partial class RunFormDesign
    {
        private void Init()
        {
            this.SuspendLayout();
            
            this.Text = "Run";
            this.HelpButton = true;
            this.ShowIcon = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.Size = new System.Drawing.Size (360, 170);
            this.StartPosition = FormStartPosition.Manual;
            this.Location =
                new System.Drawing.Point(10,
                    Screen.PrimaryScreen.WorkingArea.Height -
                    (this.Size.Height + 10));

            this.txt = new TextBox();
            this.txt.KeyDown += txt_KeyDown;
            this.txt.Location = new System.Drawing.Point(50, 60);
            this.txt.Size = new System.Drawing.Size(290, 20);

            this.browse = new Button();
            this.browse.Text = "Browse...";
            this.browse.Location = new System.Drawing.Point(this.Width - (browse.Size.Width + 20),
                this.Height - (browse.Size.Height + 40));

            this.can = new Button();
            this.can.Text = "Cancel";
            this.can.Location = new System.Drawing.Point(this.Width - (can.Size.Width + browse.Size.Width + 30),
                this.Height - (can.Size.Height + 40));
            this.can.Click += can_Click;

            this.run = new Button ();
            this.run.Text = "Run";
            this.run.Location = new System.Drawing.Point(this.Width - (can.Size.Width + browse.Size.Width + run.Size.Width + 40),
                this.Height - (can.Size.Height + 40));
            this.run.Click += run_Click;

            this.type = new Label();
            this.type.Text = "Type the name of a program, folder, document, or Internet ressource, and Windows will open it for you.";
            this.type.Location = new System.Drawing.Point(50, 15);
            this.type.Size = new System.Drawing.Size(280, 40);

            this.open = new Label();
            this.open.Text = "Open:";
            this.open.Location = new System.Drawing.Point(8, 63);
            this.open.Size = new System.Drawing.Size(150, 20);

            this.pic = new PictureBox();
            this.pic.Location = new Point(10, 20);
            this.pic.Size = new Size(32, 32);
            this.pic.Image = Image.FromStream(
                Assembly.GetExecutingAssembly().GetManifestResourceStream("Runmono.serveimage.png")
           );

            this.Controls.Add(txt);
            this.Controls.Add(run);
            this.Controls.Add(can);
            this.Controls.Add(browse);
            this.Controls.Add(type);
            this.Controls.Add(open);
            this.Controls.Add(pic);
            
            this.ResumeLayout(false);
        }

        private Button browse;
        private Button can;
        private Button run;
        private TextBox txt;
        private Label type;
        private Label open;
        private PictureBox pic;
    }
}

