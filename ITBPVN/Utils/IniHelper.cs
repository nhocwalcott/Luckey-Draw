using System.Runtime.InteropServices;
using System.Text;

namespace BPVN.LuckyDraw.Utils
{
	internal sealed class IniApi
	{
		[DllImport("kernel32", EntryPoint = "WritePrivateProfileString")]
		public static extern int WritePrivateProfileString(string section, string key, string val, string file);

		[DllImport("kernel32", EntryPoint = "GetPrivateProfileString")]
		public static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string file);
	}
}
