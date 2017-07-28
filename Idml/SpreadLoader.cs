

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Xml;
using Spreads;
using System.IO;

public class SpreadLoader
{

	public List<Spread> LoadSpreads(string[] SpreadFiles)
	{
		List<Spread> Result = new List<Spread>();

		foreach (string file in SpreadFiles) {
			Result.Add(LoadSpread(file));
		}

		return Result;
	}

	private Spread LoadSpread(string file)
	{
		StreamReader textreader = new StreamReader(file);
		XmlReader reader = default(XmlReader);

		reader = XmlReader.Create(textreader, new XmlReaderSettings {
			CloseInput = true,
			ConformanceLevel = ConformanceLevel.Document,
			DtdProcessing = DtdProcessing.Ignore,
			IgnoreComments = true,
			IgnoreProcessingInstructions = false,
			IgnoreWhitespace = true,
			ValidationType = ValidationType.None
		});

		reader.ReadStartElement("idPkg:Spread");

		Spread spread = default(Spread);
		spread = Spread.ReadXml(reader);

		reader.Close();

		return spread;
	}

}

//=======================================================
//Service provided by Telerik (www.telerik.com)
//Conversion powered by NRefactory.
//Twitter: @telerik
//Facebook: facebook.com/telerik
//=======================================================
