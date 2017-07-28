

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Xml;

namespace Stories
{
	public class StoryPreference
	{

		public bool OpticalMarginAlignment { get; set; }

		public double OpticalMarginSize { get; set; }

		public StoryHorizontalOrVertical StoryOrientation { get; set; }

		public StoryDirectionOptions StoryDirection { get; set; }

		public FrameTypes FrameType { get; set; }

		public static StoryPreference ReadXml(XmlReader reader)
		{
			StoryPreference sp = new StoryPreference();

			sp.OpticalMarginAlignment = Convert.ToBoolean(reader.GetAttribute("OpticalMarginAlignment"));
			sp.OpticalMarginSize = (double)Parser.ParseDouble(reader.GetAttribute("OpticalMarginSize"));
			sp.FrameType = (FrameTypes)Enum.Parse(typeof(FrameTypes), reader.GetAttribute("FrameType"));
			sp.StoryOrientation = (StoryHorizontalOrVertical)Enum.Parse(typeof(StoryHorizontalOrVertical), reader.GetAttribute("StoryOrientation"));
			sp.StoryDirection = (StoryDirectionOptions)Enum.Parse(typeof(StoryDirectionOptions), reader.GetAttribute("StoryDirection"));

			return sp;
		}
	}
}
