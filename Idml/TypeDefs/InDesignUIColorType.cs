

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
public class InDesignUIColorType
{
	public InDesignUIColorType()
	{
		RGBValues = new List<ListItemDouble>();
	}

	public UIColors UIColors { get; set; }

	public List<ListItemDouble> RGBValues { get; set; }
}
