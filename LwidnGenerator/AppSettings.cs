using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DypGenerator
{
	public class AppSettings
	{
		public static string Title => ConfigurationManager.AppSettings["SiteTitle"];
		public static string Description => ConfigurationManager.AppSettings["SiteDescription"];
	}
}
