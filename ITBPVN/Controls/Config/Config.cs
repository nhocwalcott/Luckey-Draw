using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using BPVN.LuckyDraw.Utils;

namespace BPVN.LuckyDraw
{
	public abstract class Config
	{
		private static readonly string ConfigFile = @".\config.ini";

		protected bool WriteString(string section, string key, string value)
		{
			return ( IniApi.WritePrivateProfileString(section, key, value, ConfigFile) != 0 );
		}

		protected string ReadString(string section, string key, string defaultValue)
		{
			StringBuilder buffer = new StringBuilder(1024);

			if ( IniApi.GetPrivateProfileString( section, key, defaultValue, buffer, 1024, ConfigFile ) != 0 ) {
				return buffer.ToString();
			}

			return defaultValue;
		}

		public virtual void Save()
		{ 
			throw new NotImplementedException();
		}
	}
}
