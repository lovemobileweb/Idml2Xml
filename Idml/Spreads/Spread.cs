using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using System.Linq;


namespace Spreads
{
    public class Spread
    {
        public Spread()
        {
            this.Children = new List<Child>();
        }

        public override string ToString()
        {
            return this.Self;
        }

        public string Self { get; set; }

        public FlattenerPreference FlattenerPreference { get; set; }

        public SpreadFlattenerLevel? FlattenerOverride { get; set; }

        public bool? AllowPageShuffle { get; set; }

        public string ItemTransform { get; set; }

        public bool? ShowMasterItems { get; set; }

        public int PageCount { get; set; }

        public int BindingLocation { get; set; }

        public PageTransitionTypeOptions? PageTransitionType { get; set; }

        public PageTransitionDirectionOptions PageTransitionDirection { get; set; }

        public PageTransitionDurationOptions PageTransitionDuration { get; set; }

        public List<Child> Children { get; set; }

        public static Spread ReadXml(XmlReader reader)
        {
            Spread result = new Spread();

            if (reader.HasAttributes)
            {
                result.Self = System.Convert.ToString(reader.GetAttribute("Self"));
                result.FlattenerOverride = (SpreadFlattenerLevel?)Parser.ParseEnum<SpreadFlattenerLevel>(reader.GetAttribute("FlattenerOverride"));
                result.AllowPageShuffle = Parser.ParseBoolean(reader.GetAttribute("AllowPageShuffle"));
                result.ItemTransform = System.Convert.ToString(reader.GetAttribute("ItemTransform"));
                result.ShowMasterItems = Parser.ParseBoolean(reader.GetAttribute("ShowMasterItems"));
                result.PageCount = System.Convert.ToInt32(reader.GetAttribute("PageCount"));
                result.BindingLocation = System.Convert.ToInt32(reader.GetAttribute("BindingLocation"));
                result.PageTransitionType = (PageTransitionTypeOptions?)Parser.ParseEnum<PageTransitionTypeOptions>(reader.GetAttribute("PageTransitionType"));
                result.PageTransitionDirection = (PageTransitionDirectionOptions)Parser.ParseEnum<PageTransitionDirectionOptions>(reader.GetAttribute("PageTransitionDirection"));
                result.PageTransitionDuration = (PageTransitionDurationOptions)Parser.ParseEnum<PageTransitionDurationOptions>(reader.GetAttribute("PageTransitionDuration"));
            }

            if (reader.IsEmptyElement)
                return result;

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    if ((string)reader.Name == "Properties")
                    {
                        while (reader.Read())
                        {
                            if ((string)reader.Name == "")
                            {
                            }
                            else if ((string)reader.Name == "Properties")
                            {
                                if (reader.NodeType == XmlNodeType.EndElement)
                                {
                                    break;
                                }
                            }
                            else
                            {
                                if (reader.NodeType == XmlNodeType.Element)
                                {
                                    Debug.WriteLine("Unrecognized element: {0} in element: {1}", reader.Name, "Spread - Properties");
                                }
                            }
                        }
                    }
                    else if ((string)reader.Name == "FlattenerPreference")
                    {
                        result.FlattenerPreference = FlattenerPreference.ReadXml(reader);
                    }
                    else if ((string)reader.Name == "Page")
                    {
                        result.Children.Add(Page.ReadXml(reader));
                    }
                    else if ((string)reader.Name == "TextFrame")
                    {
                        result.Children.Add(TextFrame.ReadXml(reader));
                    }
                    else if ((string)reader.Name == "Rectangle")
                    {
                        result.Children.Add(Rectangle.ReadXml(reader));
                    }
                    else
                    {
                        if (reader.NodeType == XmlNodeType.Element)
                        {
                            Debug.WriteLine("Unrecognized element: {0} in element: {1}", reader.Name, "Spread");
                        }
                    }
                }
            }

            return result;
        }

        internal void Save(XmlTextWriter textWriter, List<Stories.Story> stories, ref int nPage)
        {
            List<Child> pages = Children
                .Where(x => x.GetType() == typeof(Page))
                .OrderBy(x => Parser.ParseHexNumber(((Page)x).Self))
                .ToList();
            List<Child> textframes = Children
                .Where(x => x.GetType() == typeof(TextFrame))
                .OrderBy(x => Parser.ParseHexNumber(((TextFrame)x).Self))
                .ToList();
            List<TextFrameWithPage> frames = new List<TextFrameWithPage>();

            foreach (TextFrame textframe in textframes)
            {
                Page prevPage = null;
                foreach (Page page in pages)
                {
                    if (Parser.ParseHexNumber(page.Self) < Parser.ParseHexNumber(textframe.Self))
                        prevPage = page;
                    else if (Parser.ParseHexNumber(page.Self) > Parser.ParseHexNumber(textframe.Self))
                        break;
                }
                if (prevPage != null)
                {
                    TextFrameWithPage frame = new TextFrameWithPage();
                    frame.TextFrame = textframe;
                    frame.Page = prevPage;
                    frames.Add(frame);
                }
            }

            foreach (Page page in pages)
            {
                textWriter.WriteStartElement("page");
                {
                    textWriter.WriteStartElement("section-name");
                    textWriter.WriteEndElement();
                    textWriter.WriteStartElement("page-id");
                    {
                        textWriter.WriteString(page.Self);
                    }
                    textWriter.WriteEndElement();
                    textWriter.WriteStartElement("page-number");
                    {
                        textWriter.WriteString((++nPage).ToString());
                    }
                    textWriter.WriteEndElement();
                    string[] points = page.GeometricBounds.Split(new char[] { ' ' });
                    decimal pageHeight = Math.Round(Convert.ToDecimal(points.Length > 2 ? points[2] : "0"), 2);
                    decimal pageWidth = Math.Round(Convert.ToDecimal(points.Length > 3 ? points[3] : "0"), 2);
                    textWriter.WriteStartElement("page-height");
                    {
                        textWriter.WriteString(pageHeight.ToString());
                    }
                    textWriter.WriteEndElement();
                    textWriter.WriteStartElement("page-width");
                    {
                        textWriter.WriteString(pageWidth.ToString());
                    }
                    textWriter.WriteEndElement();
                    List<TextFrameWithPage> framesInThisPage = frames
                        .Where(x => x.Page == page)
                        .ToList();
                    foreach (var frame in framesInThisPage)
                    {
                        textWriter.WriteStartElement("frame");
                        {
                            textWriter.WriteStartElement("elements");
                            {
                                foreach (var story in stories.Where(x => x.Self == frame.TextFrame.ParentStory).ToList())
                                {
                                    story.Save(textWriter);
                                    break;
                                }
                            }
                            textWriter.WriteEndElement();
                        }
                        textWriter.WriteEndElement();
                    }
                }
                textWriter.WriteEndElement();
            }
        }
    }

    public class TextFrameWithPage
    {
        public Page Page { get; set; }
        public TextFrame TextFrame { get; set; }
    }
}
