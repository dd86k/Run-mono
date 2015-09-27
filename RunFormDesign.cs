using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Runmono
{
    partial class RunFormDesign
    {
        private void Init()
        {
            SuspendLayout();

            Text = "Run";
            HelpButton = true;
            ShowIcon = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Size = new Size(360, 170);
            StartPosition = FormStartPosition.Manual;
            Location =
                new Point(10,
                    Screen.PrimaryScreen.WorkingArea.Height -
                    (Size.Height + 10));

            txt = new TextBox();
            txt.KeyDown += txt_KeyDown;
            txt.Location = new Point(50, 60);
            txt.Size = new System.Drawing.Size(290, 20);

            browse = new Button();
            browse.Text = "Browse...";
            browse.Location = new Point(Width - (browse.Size.Width + 20),
                Height - (browse.Size.Height + 40));

            can = new Button();
            can.Text = "Cancel";
            can.Location = new Point(Width - (can.Size.Width + browse.Size.Width + 30),
                Height - (can.Size.Height + 40));
            can.Click += can_Click;

            run = new Button ();
            run.Text = "Run";
            run.Location =
                new Point(Width - (can.Size.Width + browse.Size.Width + run.Size.Width + 40),
                Height - (can.Size.Height + 40));
            run.Click += run_Click;

            type = new Label();
            type.Text =
                "Type the name of a program, folder, document, or Internet resource, and Windows will open it for you.";
            type.Location = new Point(50, 15);
            type.Size = new System.Drawing.Size(280, 40);

            open = new Label();
            open.Text = "Open:";
            open.Location = new Point(8, 63);
            open.Size = new System.Drawing.Size(150, 20);

            pic = new PictureBox();
            pic.Location = new Point(10, 20);
            pic.Size = new Size(32, 32);
            pic.Image = Image.FromStream(
                Assembly.GetExecutingAssembly()
                .GetManifestResourceStream("Runmono.serveimage.png")
            );

            Controls.Add(txt);
            Controls.Add(run);
            Controls.Add(can);
            Controls.Add(browse);
            Controls.Add(type);
            Controls.Add(open);
            Controls.Add(pic);

            ResumeLayout(false);
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

