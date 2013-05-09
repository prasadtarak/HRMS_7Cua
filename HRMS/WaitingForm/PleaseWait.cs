using System;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace WaitingForm
{
	/// <summary>
	/// Summary description for PleaseWait.
	/// </summary>
	public class PleaseWait
	{
		private static frmDataTransfer TransferForm = null;
		private static frmProcess ProcessForm = null;
//		private static IWaitingForm iWaiting = null;
		private static Thread waitingThread = null;
//		private static string strStatus = string.Empty;
		private static Type WFormType = null;



		#region Wait for Data Transfer
		public static void ShowDataTransfer()
		{
			if (waitingThread != null)
				return;
			WFormType = typeof(frmDataTransfer);
			waitingThread = new Thread(new ThreadStart(DataTransferStart));
			waitingThread.IsBackground = true;
			waitingThread.ApartmentState = ApartmentState.STA;
			waitingThread.Start();
		}
		public static void DataTransferStart()
		{
			CreateDataTransferInstance(WFormType);
			Application.Run(TransferForm);	
		}

		/// <summary>
		/// Colse the SplashForm
		/// </summary>
		public static void CloseDataTransfer()
		{
			if (waitingThread == null || TransferForm == null) return;
			try
			{
				TransferForm.Invoke(new MethodInvoker(TransferForm.Close));
			}
			catch (Exception)
			{
			}
			waitingThread = null;
			TransferForm = null;
		}

		private static void CreateDataTransferInstance(Type FormType)
		{

			object obj = FormType.InvokeMember(null,
				BindingFlags.DeclaredOnly |
				BindingFlags.Public | BindingFlags.NonPublic |
				BindingFlags.Instance | BindingFlags.CreateInstance, null, null, null);
			TransferForm = (frmDataTransfer)obj;
			if (TransferForm == null)
			{
				throw (new Exception("Waiting Form must inherit from System.Windows.Forms.Form"));
			}
		}
		#endregion
		
		#region Wait for Data Transfer
		public static void ShowProcess()
		{
			if (waitingThread != null)
				return;
			WFormType = typeof(frmProcess);
			waitingThread = new Thread(new ThreadStart(ProcessStart));
			waitingThread.IsBackground = true;
			waitingThread.ApartmentState = ApartmentState.STA;
			waitingThread.Start();
		}
		public static void ProcessStart()
		{
			CreateProcessInstance(WFormType);
			Application.Run(ProcessForm);	
		}

		/// <summary>
		/// Colse the SplashForm
		/// </summary>
		public static void CloseProcess()
		{
			if (waitingThread == null || ProcessForm == null) return;
			try
			{
				ProcessForm.Invoke(new MethodInvoker(ProcessForm.Close));
			}
			catch (Exception)
			{
			}
			waitingThread = null;
			ProcessForm = null;
		}

		private static void CreateProcessInstance(Type FormType)
		{
			object obj = FormType.InvokeMember(null,
				BindingFlags.DeclaredOnly |
				BindingFlags.Public | BindingFlags.NonPublic |
				BindingFlags.Instance | BindingFlags.CreateInstance, null, null, null);
			ProcessForm = (frmProcess)obj;
			if (ProcessForm == null)
			{
				throw (new Exception("Waiting Form must inherit from System.Windows.Forms.Form"));
			}
		}
		#endregion
		

	}
}

