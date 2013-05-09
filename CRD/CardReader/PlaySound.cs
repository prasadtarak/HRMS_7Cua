using System;
using System.Runtime.InteropServices;

namespace CardReader
{
	public class Sound
	{
		public static void Play(string strFileName, PlaySoundFlags soundFlags)
		{
			PlaySound(strFileName, IntPtr.Zero, soundFlags);
			// passes to Playsound the filename and a pointer
			// to the Flag
		}

		[DllImport("winmm.dll")] //inports the winmm.dll used for sound
			private static extern bool PlaySound(string szSound, IntPtr hMod, PlaySoundFlags flags);
	}

	[Flags] //enumeration treated as a bit field or set of flags
		public enum PlaySoundFlags : int
	{
		SND_SYNC = 0x0000, /* play synchronously (default) */
		SND_ASYNC = 0x0001, /* play asynchronously */
		SND_NODEFAULT = 0x0002, /* silence (!default) if sound notfound */
		SND_LOOP = 0x0008, /* loop the sound until nextsndPlaySound */
		SND_NOSTOP = 0x0010, /* don't stop any currently playingsound */
		SND_NOWAIT = 0x00002000, /* don't wait if the driver is busy */
		SND_FILENAME = 0x00020000, /* name is file name */
		SND_RESOURCE = 0x00040004 /* name is resource name or atom */
	}
}