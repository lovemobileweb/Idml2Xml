

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Xml;

public class InCopyExportOption
{

	public bool IncludeGraphicProxies { get; set; }

	public bool IncludeAllResources { get; set; }


	public static InCopyExportOption ReadXml(XmlReader reader)
	{
		InCopyExportOption ieo = new InCopyExportOption();

		ieo.IncludeGraphicProxies = Convert.ToBoolean(reader.GetAttribute("IncludeGraphicProxies"));
		ieo.IncludeAllResources = Convert.ToBoolean(reader.GetAttribute("IncludeAllResources"));

		return ieo;
	}
}

//=======================================================
//Service provided by Telerik (www.telerik.com)
//Conversion powered by NRefactory.
//Twitter: @telerik
//Facebook: facebook.com/telerik
//=======================================================
