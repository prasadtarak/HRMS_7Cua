using System;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;

namespace EVSoft.HRMS.Common
{
	/// <summary>
	/// Summary description for Lang.
	/// </summary>
	public class LangManager
	{
		private const string strResourceName = "EVSoft.HRMS.Common.Lang.LangResource";
		private CultureInfo ci;
		private ResourceManager rm;

		public LangManager(string lang)
		{
			rm = new ResourceManager(strResourceName, Assembly.GetExecutingAssembly());
			Console.WriteLine("GetExecutingAssembly=" + Assembly.GetExecutingAssembly().FullName);
			ci = new CultureInfo(lang);
		}
		/// <summary>
		/// 
		/// Thay ðôÒi ngôn ngýÞ hiêÒn thiò hiêòn taòi
		/// </summary>
		/// <param name="lang"></param>
		public void ChangeLanguage(string lang)
		{
			ci = null;
			ci = new CultureInfo(lang);
		}
		/// <summary>
		/// Xoìa tâìt caÒ taÌi nguyên ðaÞ sýÒ duòng
		/// </summary>
		public void Dispose()
		{
			if (rm != null)
				rm.ReleaseAllResources();
		}
		/// <summary>
		/// Lâìy vêÌ ðoaòn text theo tên
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public string GetString(string name)
		{
			try
			{
				return rm.GetString(name, ci);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return "";
			}
		}
	}
}
