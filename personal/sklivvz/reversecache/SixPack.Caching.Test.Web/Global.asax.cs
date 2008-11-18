// Global.asax.cs
//
//  Copyright (C) 2008 Fullsix Marketing Interactivo LDA
//  Author: Marco Cecconi <marco.cecconi@gmail.com>
//
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
//
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
// Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA 02111-1307 USA 
//
//

using System;
using System.Collections;
using System.ComponentModel;
using System.Web;
using System.Web.SessionState;

namespace ReverseCachingTest
{
	
	
	public class Global : System.Web.HttpApplication
	{
		
		protected virtual void Application_Start(object sender, EventArgs e)
		{
		}
		
		protected virtual void Session_Start(object sender, EventArgs e)
		{
		}
		
		protected virtual void Application_BeginRequest(object sender, EventArgs e)
		{
		}
		
		protected virtual void Application_EndRequest(object sender, EventArgs e)
		{
		}
		
		protected virtual void Application_AuthenticateRequest(object sender, EventArgs e)
		{
		}
		
		protected virtual void Application_Error(object sender, EventArgs e)
		{
		}
		
		protected virtual void Session_End(object sender, EventArgs e)
		{
		}
		
		protected virtual void Application_End(object sender, EventArgs e)
		{
		}
	}
}
