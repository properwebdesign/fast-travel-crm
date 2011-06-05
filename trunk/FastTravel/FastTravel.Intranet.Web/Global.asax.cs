using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using FastTravel.Intranet.BusinessLogic;

namespace FastTravel.Intranet.Web
{
	public class Global : System.Web.HttpApplication
	{

		protected void Application_Start(object sender, EventArgs e)
		{
			// Init general manager for realise UnitOfWork factory
			BusinessLogicManager.Initialize();
		}

		void Application_EndRequest(object sender, EventArgs e)
		{
			// Destroy gemeral manager
			BusinessLogicManager.Dispose();
		}

		protected void Session_Start(object sender, EventArgs e)
		{

		}

		protected void Application_BeginRequest(object sender, EventArgs e)
		{

		}

		protected void Application_AuthenticateRequest(object sender, EventArgs e)
		{
			string url = HttpContext.Current.Request.RawUrl.ToLower();
			if (url.Contains("ext.axd"))
			{
				HttpContext.Current.SkipAuthorization = true;
			}
			else if (url.Contains("returnurl=/default.aspx") || url.Contains("returnurl=%2fdefault.aspx"))
			{
				Response.Redirect(url.Replace("returnurl=/default.aspx", "r=/").Replace("returnurl=%2fdefault.aspx", "r=/"));
			}

		}

		protected void Application_Error(object sender, EventArgs e)
		{

		}

		protected void Session_End(object sender, EventArgs e)
		{

		}

		protected void Application_End(object sender, EventArgs e)
		{

		}
	}
}