

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Xml;

namespace Spreads
{
	public class Page : Child
	{

		private PageColor PageColor { get; set; }

		private GridDataInformation GridDataInformation { get; set; }

		public override string ToString()
		{
			return "Page - " + this.Self;
		}

		public string Self { get; set; }

		public string GeometricBounds { get; set; }

		public string ItemTransform { get; set; }

		public string Name { get; set; }

		public string AppliedTrapPreset { get; set; }

		public string OverrideList { get; set; }

		public string AppliedMaster { get; set; }

		public string MasterPageTransform { get; set; }

		public string[] TabOrder { get; set; }

		public GridStartingPointOptions GridStartingPoint { get; set; }

		public bool UseMasterGrid { get; set; }

		public MarginPreference MarginPreference { get; set; }

		public Descriptor Descriptor { get; set; }

		public static Page ReadXml(XmlReader reader)
		{
			Page p = new Page();

			if (reader.HasAttributes) {
				p.Self = reader.GetAttribute("Self");
				p.GeometricBounds = reader.GetAttribute("GeometricBounds");
				p.ItemTransform = reader.GetAttribute("ItemTransform");
				p.Name = reader.GetAttribute("Name");
				p.AppliedTrapPreset = reader.GetAttribute("AppliedTrapPreset");
				p.OverrideList = reader.GetAttribute("OverrideList");
				p.AppliedMaster = reader.GetAttribute("AppliedMaster");
				p.MasterPageTransform = reader.GetAttribute("MasterPageTransform");
				p.TabOrder = reader.GetAttribute("TabOrder").Split(' ');
				p.GridStartingPoint = (GridStartingPointOptions)Enum.Parse(typeof(GridStartingPointOptions), reader.GetAttribute("GridStartingPoint"));
				p.UseMasterGrid = Convert.ToBoolean(reader.GetAttribute("UseMasterGrid"));
			}

            if (reader.IsEmptyElement)
                return p;

            while (reader.Read()) {
				switch (reader.Name) {
					case "Properties":
						while (reader.Read()) {
							switch (reader.Name) {
								case "PageColor":
									p.PageColor = PageColor.ReadXml(reader);
									break;
								case "Descriptor":
									p.Descriptor = Descriptor.ReadXml(reader);
									break;
								default:
									if (reader.NodeType == XmlNodeType.Element) {
										Debug.WriteLine("Unrecognized element: {0} in element: {1}", reader.Name, "Page - Properties");
									}
									break;
							}
							if (reader.Name == "Properties" & reader.NodeType == XmlNodeType.EndElement)
								break;
						}
						break;
					case "GridDataInformation":
						p.GridDataInformation = GridDataInformation.ReadXml(reader);
						break;
					case "MarginPreference":
						p.MarginPreference = MarginPreference.ReadXml(reader);
						break;
					case "Page":
                        if (reader.NodeType == XmlNodeType.EndElement)
                            goto exit1;

						break;
					default:
						if (reader.NodeType == XmlNodeType.Element) {
							Debug.WriteLine("Unrecognized element: {0} in element: {1}", reader.Name, "Page");
						}
						break;
				}
			}

            exit1:
            return p;
		}
	}
}

//=======================================================
//Service provided by Telerik (www.telerik.com)
//Conversion powered by NRefactory.
//Twitter: @telerik
//Facebook: facebook.com/telerik
//=======================================================
