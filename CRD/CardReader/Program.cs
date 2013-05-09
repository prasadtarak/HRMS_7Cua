using System;
using System.Windows.Forms;

namespace CardReader
{
	/// <summary>
	/// Summary description for Main.
	/// </summary>
	public class Program
	{
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.DoEvents();
			Utils.initCardReader();
		}
	}
}
