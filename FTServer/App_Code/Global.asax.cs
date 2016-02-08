using System.Net;
using CsQuery.Web;


namespace FTServer
{
	using System;
	using System.Collections;
	using System.ComponentModel;
	using System.Web;
	using System.Web.SessionState;

	public class Global : System.Web.HttpApplication
	{
		
		protected void Application_Start (Object sender, EventArgs e)
		{
			ServicePointManager.ServerCertificateValidationCallback
				+= (ssender, cert, chain, sslPolicyErrors) => true;
			ServerConfig.Default.TimeoutSeconds = 10.0;

			String path = System.Environment.GetFolderPath (Environment.SpecialFolder.Personal) + "/ftsdata/";
			System.IO.Directory.CreateDirectory (path);
			SDB.init(path);
		}

		protected void Session_Start (Object sender, EventArgs e)
		{
		}

		protected void Application_BeginRequest (Object sender, EventArgs e)
		{
		}

		protected void Application_EndRequest (Object sender, EventArgs e)
		{
		}

		protected void Application_AuthenticateRequest (Object sender, EventArgs e)
		{
		}

		protected void Application_Error (Object sender, EventArgs e)
		{
		}

		protected void Session_End (Object sender, EventArgs e)
		{
		}

		protected void Application_End (Object sender, EventArgs e)
		{
			SDB.close();
		}
	}
}
