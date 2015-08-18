using System;
using System.Windows.Forms;

namespace Runmono
{
	static class Program
	{
		[STAThread]
		static void Main()
		{
            Application.Run (new RunFormDesign());
		}
	}
}