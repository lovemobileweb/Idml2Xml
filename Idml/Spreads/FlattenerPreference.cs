

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Xml;

namespace Spreads
{
	public class FlattenerPreference
	{

		public double LineArtAndTextResolution { get; set; }

		public double GradientAndMeshResolution { get; set; }

		public bool ClipComplexRegions { get; set; }

		public bool ConvertAllStrokesToOutlines { get; set; }

		public bool ConvertAllTextToOutlines { get; set; }

		private RasterVectorBalance RasterVectorBalance { get; set; }

		public static FlattenerPreference ReadXml(XmlReader reader)
		{
			FlattenerPreference fp = new FlattenerPreference();

			if (reader.HasAttributes) {
				fp.LineArtAndTextResolution = (double)Parser.ParseDouble(reader.GetAttribute("LineArtAndTextResolution"));
				fp.GradientAndMeshResolution = (double)Parser.ParseDouble(reader.GetAttribute("GradientAndMeshResolution"));
				fp.ClipComplexRegions = Convert.ToBoolean(reader.GetAttribute("ClipComplexRegions"));
				fp.ConvertAllStrokesToOutlines = Convert.ToBoolean(reader.GetAttribute("ConvertAllStrokesToOutlines"));
				fp.ConvertAllTextToOutlines = Convert.ToBoolean(reader.GetAttribute("ConvertAllTextToOutlines"));
			}

            if (reader.IsEmptyElement)
                return fp;

            if (!reader.IsEmptyElement) {
				while (reader.Read()) {
					switch (reader.Name) {
						case "Properties":
							while (reader.Read()) {
								switch (reader.Name) {
									case "RasterVectorBalance":
										fp.RasterVectorBalance = RasterVectorBalance.ReadXml(reader);
										break;
									default:
										if (reader.NodeType == XmlNodeType.Element) {
											Debug.WriteLine("Unrecognized element: {0} in element: {1}", reader.Name, "FlattenerPreference - Properties");
										}
										break;
								}
								if (reader.Name == "Properties" & reader.NodeType == XmlNodeType.EndElement)
									break;
							}
							break;
						default:
							if (reader.NodeType == XmlNodeType.Element) {
								Debug.WriteLine("Unrecognized element: {0} in element: {1}", reader.Name, "FlattenerPreference");
							}
							break;
					}
					if (reader.Name == "FlattenerPreference" & reader.NodeType == XmlNodeType.EndElement)
						break;
				}
			}

			return fp;
		}
	}
}
