using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
namespace EVSoft.HRMS.UI
{
	/// <summary>
	/// Summary description for frmBusyBar.
	/// </summary>
	public class frmBusyBar : System.Windows.Forms.Form
	{
		private Commons.PainterXP painterXP1;
		private System.Windows.Forms.Label label1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private Commons.PainterLine painterLine1;
		private System.Windows.Forms.ProgressBar _ProgressBar1;
		private Work _Work = null;

		public frmBusyBar()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		private class Work
		{
			private int _Interval = 10;
			private Thread _Thread = null;
			private volatile bool _Stop = false;

			public int Interval { get { return _Interval; } set { _Interval = value; } }
			public Thread Thread { get { return _Thread; } }

			public event EventHandler Step;

			public Work()
			{
			}

			public void Start()
			{
				_Thread = new Thread( new ThreadStart( DoWork ) );
				_Thread.Priority = ThreadPriority.Lowest;
				_Thread.IsBackground = true;
				_Thread.Name = "Worker";
				_Thread.Start();
			}

			public void Stop()
			{
				_Stop = true;
			}

			private void DoWork()
			{
				for(;;)
				{
					if ( Step != null ) Step( this, EventArgs.Empty );

					DateTime start = DateTime.Now;

					for(;;)
					{
						//						Thread.SpinWait( 1000000 );
						Thread.Sleep( 1 );

						TimeSpan interval = DateTime.Now - start;

						if ( interval.TotalMilliseconds >= _Interval ) break;
					}

					if ( _Stop ) break;
				}
			}
		}
		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.painterXP1 = new Commons.PainterXP();
			this.label1 = new System.Windows.Forms.Label();
			this.painterLine1 = new Commons.PainterLine();
			this._ProgressBar1 = new System.Windows.Forms.ProgressBar();
			this.SuspendLayout();
			// 
			// painterXP1
			// 
			this.painterXP1.BlockLineColor = System.Drawing.SystemColors.Control;
			this.painterXP1.ColorDark = System.Drawing.Color.FromArgb(((System.Byte)(131)), ((System.Byte)(174)), ((System.Byte)(119)));
			this.painterXP1.ColorLight = System.Drawing.Color.FromArgb(((System.Byte)(195)), ((System.Byte)(227)), ((System.Byte)(186)));
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(216, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Đang tổng hợp dữ liệu. Xin chờ giây lát ...";
			// 
			// painterLine1
			// 
			this.painterLine1.LineColor = System.Drawing.SystemColors.ControlText;
			// 
			// _ProgressBar1
			// 
			this._ProgressBar1.Location = new System.Drawing.Point(40, 40);
			this._ProgressBar1.Name = "_ProgressBar1";
			this._ProgressBar1.Size = new System.Drawing.Size(160, 23);
			this._ProgressBar1.Step = 1;
			this._ProgressBar1.TabIndex = 3;
			this._ProgressBar1.Value = 50;
			// 
			// frmBusyBar
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(242, 80);
			this.Controls.Add(this._ProgressBar1);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmBusyBar";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmBusyBar";
			this.Load += new System.EventHandler(this.frmBusyBar_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			StopBar();
			this.Close();
		}

		private void frmBusyBar_Load(object sender, System.EventArgs e)
		{
//			_BusyBar1.DrawBar;
//			_BusyBar1.PainterPreset;
//			_BusyBar1.PerformStep();
//			_BusyBar1.Pin;
//			_BusyBar1.Show();
//			_BusyBar1.Step = 20;
			showBar();
			
		}
		private void showBar()
		{
			if ( _Work == null )
			{
				_Work = new Work();
				_Work.Step += new EventHandler( _Work_Step );
				_Work.Start();
			}
		}
		private void StopBar()
		{
			if ( _Work != null )
			{
//				_Work = new Work();
//				_Work.Step += new EventHandler( _Work_Step );
				_Work.Stop();
			}
		}

		private void _Work_Step( object sender, EventArgs args )
		{
			BeginInvoke( _ProgressBarPerformStepDelegate, new object[] { new ProgressBarPerformStepArgs( _ProgressBar1   ) } );
		}
		private class ProgressBarPerformStepArgs
		{
			public ProgressBar ProgressBar;
			public ProgressBarPerformStepArgs( ProgressBar progressBar ) { ProgressBar = progressBar; }
		}

		private delegate void ProgressBarPerformStepDelegate( ProgressBarPerformStepArgs args );

		private ProgressBarPerformStepDelegate _ProgressBarPerformStepDelegate = new ProgressBarPerformStepDelegate( ProgressBarPerformStep );

		private static void ProgressBarPerformStep( ProgressBarPerformStepArgs args )
		{
			args.ProgressBar.PerformStep();
			if ( args.ProgressBar.Value >= 100 ) args.ProgressBar.Value = 0;
		}

		public void CloseBusyBar()
		{
			StopBar();
		}

			

	}
}
