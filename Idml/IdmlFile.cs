

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using Ionic.Zip;
using System.Xml;
using System.Linq;

namespace Idml
{
    public class IdmlFile
    {
        public List<Stories.Story> Stories { get; set; }

        private List<Spreads.Spread> Spreads { get; set; }

        public void Open(string path)
        {
            string tempExtractionPath = null;

            tempExtractionPath = ExtractZip(path);
            LoadData(tempExtractionPath);
            DeleteExtractionFolder(tempExtractionPath);
        }

        public void SaveAsArticle(string path)
        {
            XmlTextWriter textWriter = new XmlTextWriter(path, System.Text.Encoding.UTF8);
            textWriter.WriteStartDocument();
            {
                textWriter.WriteStartElement("edition");
                {
                    textWriter.WriteStartElement("pubdate");
                    {
                        textWriter.WriteString(DateTime.Now.ToString("yyyyMMdd"));
                    }
                    textWriter.WriteEndElement();
                    textWriter.WriteStartElement("pages");
                    {
                        int nPage = 0;
                        List<Spreads.Spread> spreads = Spreads
                            .OrderBy(x => Parser.ParseHexNumber(x.Self))
                            .ToList();
                        foreach (var spread in spreads)
                        {
                            spread.Save(textWriter, Stories, ref nPage);
                        }
                    }
                    textWriter.WriteEndElement();
                }
                textWriter.WriteEndElement();
            }
            textWriter.WriteEndDocument();
            textWriter.Close();
            Process.Start(path);
        }

        private string ExtractZip(string filePath)
        {
            string TempPath = null;
            string TargetDir = null;

            TempPath = System.Environment.GetEnvironmentVariable("tmp", EnvironmentVariableTarget.User);
            TargetDir = Path.Combine(TempPath, Path.GetRandomFileName());

            Debug.WriteLine("Extracting file: {0} to temporary extract path: {1}", filePath, TargetDir);

            using (ZipFile zip1 = ZipFile.Read(filePath))
            {
                foreach (ZipEntry e in zip1)
                {
                    e.Extract(TargetDir, ExtractExistingFileAction.OverwriteSilently);
                }
            }

            return TargetDir;
        }


        private void LoadData(string tempExtractionPath)
        {
            // Read which stories exist via designmap.xml

            // Quick & dirty way for now
            string[] StoryFiles = null;
            if (Directory.Exists(Path.Combine(tempExtractionPath, "Stories")))
            {
                StoryFiles = Directory.GetFiles(Path.Combine(tempExtractionPath, "Stories"));

                StoryLoader sl = new StoryLoader();
                this.Stories = sl.LoadStories(StoryFiles);
            }

            // Read which spreads exist via designmap.xml
            string[] SpreadFiles = null;
            if (Directory.Exists(Path.Combine(tempExtractionPath, "Spreads")))
            {
                SpreadFiles = Directory.GetFiles(Path.Combine(tempExtractionPath, "Spreads"));

                SpreadLoader spl = new SpreadLoader();
                this.Spreads = spl.LoadSpreads(SpreadFiles);
            }
        }

        private void DeleteExtractionFolder(string tempExtractionPath)
        {
            if (Directory.Exists(tempExtractionPath))
            {
                Directory.Delete(tempExtractionPath, true);
            }
        }

    }
}