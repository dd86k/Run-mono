Hello! Just is just an example for a UI application in C#, made with MonoDevelop.

Tip: Having experience with Windows.Forms and Visual Studio really helps in the first place.

Don't be shy to check the LICENSE file!

# Screenshots
## Linux and Windows

On Linux (Xfce4).

![On Xfce4](http://didi.wcantin.ca/p/run-mono-linux.png)

On Windows 8.1.

![On Windows 8](http://didi.wcantin.ca/p/run-mono-win32.png)

Note: Mono and .NET are using their own default fonts.

# Explanation
## How things run!

If you don't mark your project as an UI Application, it will launch a console whenever our program start (at least on Windows).

First, when the program is launched, the main entry point is in Program.cs (1.), which launches a new Windows.Forms object (2.).

```csharp
using System;
using System.Windows.Forms;

namespace Runmono
{
	static class Program
	{
		[STAThread]
        // 1. Main entry point of our program.
		static void Main()
		{
            // 2. Launch our form, RunFormDesign.
            // MSDN: "Begins running a standard 
            // application message loop on the current 
            // thread, and makes the specified form 
            // visible."
            Application.Run(new RunFormDesign());
		}
	}
}
```

Which then with our UI-cluster-free coding design, initializes the control objects on the form.

```csharp
namespace Runmono
{
    public partial class RunFormDesign : Form
    {
        public RunFormDesign()
        {
            // 3. While being constructed, we initialize
            // our controls.
            Init();
        }
```

And our `Init();` method is here, placing the controls.

Note how our main form devires from the Form class and it's partial. Why? Our other partial class in RunFormDesign.cs completes it. 

I really recommend putting a `this.SuspendLayout();` at the beginning and a `this.ResumeLayout(false);` at the end of our Init() method, especially if you have a lot of controls. It will only calculate the form logic once it's resumed, which can save execution time.

Note that our control objects already exists, but are not _created_ at start (p.s. they're null).

```csharp
partial class RunFormDesign
{
    // 4. Place stuff!
    private void Init()
    {
        this.Text = "Run";
        
        // [...]
        
        // * Don't forget the create the instances! *
        this.txt = new TextBox();
        
        // [...]
    } // Finished, returning to RunFormDesign()!
    
    private Button browse;
    private Button can;
    private Button run;
    private TextBox txt;
    private Label type;
    private Label open;
    private PictureBox pic;
}
```

For good organization, I recommend putting some comment for controls like
```csharp
//
// txt: The main textbox!
//
```
in between the controls.

Then when all of that magic is done, it shows the form.

Controls and events are placed in `Init()` so we can a cluster-free environment around our UI code.

Then the events can be handled in our `RunFormDesign : Form` form.

I think that's it, have fun!