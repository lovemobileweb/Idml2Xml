

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Xml;

public class TextFramePreference
{

	private double _TextColumnFixedWidth;
	public double TextColumnFixedWidth {
		get { return _TextColumnFixedWidth; }
		set {
			if (value >= 0 & value <= 8640) {
				_TextColumnFixedWidth = value;
			} else {
				Debug.WriteLine("TextFramePreference.TextColumnFixedWidth cannot accept value: {0}. Value must be between 0 and 8640.", value);
			}
		}
	}

	private InsetSpacing InsetSpacing { get; set; }

	public static TextFramePreference ReadXml(XmlReader reader)
	{
		TextFramePreference tfp = new TextFramePreference();

		if (reader.HasAttributes) {
			tfp.TextColumnFixedWidth = (double)Parser.ParseDouble(reader.GetAttribute("TextColumnFixedWidth"));
		}

		if (!reader.IsEmptyElement) {
			while (reader.Read()) {
				switch (reader.Name) {
					case "Properties":
						while (reader.Read()) {
							switch (reader.Name) {
								case "InsetSpacing":
									tfp.InsetSpacing = InsetSpacing.ReadXml(reader);
									break;
								case "Properties":
									if (reader.NodeType == XmlNodeType.EndElement) {
                                        goto exit1;
                                    }
									break;
								default:
									if (reader.NodeType == XmlNodeType.Element) {
										Debug.WriteLine("Unrecognized element: {0} in element: {1}", reader.Name, "TextFramePreference - Properties");
									}
									break;
							}
						}
                        exit1:
						break;
					case "TextFramePreference":
                        if (reader.NodeType == XmlNodeType.EndElement)
                            goto exit2;

						break;
					default:
						if (reader.NodeType == XmlNodeType.Element) {
							Debug.WriteLine("Unrecognized element: {0} in element: {1}", reader.Name, "TextFramePreference");
						}
						break;
				}
			}
        }

        exit2:
        return tfp;
	}
}
