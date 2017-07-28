

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Xml;
using System.Text;
using Stories;
using System.IO;

public class StoryLoader
{
	public List<Story> LoadStories(string[] StoryFiles)
	{
		List<Story> Result = new List<Story>();

		foreach (string file in StoryFiles) {
			//Debug.WriteLine("Loading story: " & file)
			Result.Add(LoadStory(file));
		}

		return Result;
	}

	private Story LoadStory(string file)
	{
		StreamReader textreader = new StreamReader(file);
		XmlReader reader = default(XmlReader);
		Story result = default(Story);

		reader = XmlReader.Create(textreader, new XmlReaderSettings {
			CloseInput = true,
			ConformanceLevel = ConformanceLevel.Document,
			DtdProcessing = DtdProcessing.Ignore,
			IgnoreComments = true,
			IgnoreProcessingInstructions = false,
			IgnoreWhitespace = true,
			ValidationType = ValidationType.None
		});

		reader.ReadStartElement("idPkg:Story");

		result = Story.ReadXml(reader);

		reader.Close();

		return result;
	}


}
