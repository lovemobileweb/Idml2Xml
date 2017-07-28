using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;


namespace Stories
{
    public class Note : Child
    {

        public Note()
        {
            this.Children = new List<Child>();
        }

        public bool? Collapsed { get; set; }

        public DateTime? CreationDate { get; set; }

        public DateTime? ModificationDate { get; set; }

        public string UserName { get; set; }

        public string AppliedDocumentUser { get; set; }

        public List<Child> Children { get; set; }

        public static Note ReadNote(XmlReader reader)
        {
            Note n = new Note();

            n.Collapsed = Parser.ParseBoolean(reader.GetAttribute("Collapsed"));
            n.CreationDate = Parser.ParseDate(reader.GetAttribute("CreationDate"));
            n.ModificationDate = Parser.ParseDate(reader.GetAttribute("ModificationDate"));
            n.UserName = System.Convert.ToString(reader.GetAttribute("UserName"));
            n.AppliedDocumentUser = System.Convert.ToString(reader.GetAttribute("AppliedDocumentUser"));

            while (reader.Read())
            {
                if ((string)reader.Name == "Footnote")
                {
                    n.Children.Add(Footnote.ReadXml(reader));
                }
                else if ((string)reader.Name == "GaijiOwnedItemObject")
                {
                    n.Children.Add(GaijiOwnedItemObject.ReadXml(reader));
                }
                else if ((string)reader.Name == "TextVariableInstance")
                {
                    n.Children.Add(TextVariableInstance.ReadXml(reader));
                }
                else if ((string)reader.Name == "Table")
                {
                    n.Children.Add(Table.ReadXml(reader));
                }
                else if ((string)reader.Name == "ParagraphStyleRange")
                {
                    n.Children.Add(ParagraphStyleRange.ReadXml(reader));
                }
                else if ((string)reader.Name == "CharacterStyleRange")
                {
                    n.Children.Add(CharacterStyleRange.ReadXml(reader));
                }
                else if ((string)reader.Name == "HiddenText")
                {
                    n.Children.Add(HiddenText.ReadXml(reader));
                }
                else if ((string)reader.Name == "Note")
                {
                    if (reader.NodeType == XmlNodeType.EndElement)
                    {
                        break;
                    }
                }
                else
                {
                    Debug.WriteLine("Unrecognized element: {0} in element: {1}", reader.Name, "Note");
                }
            }

            return n;
        }
    }
}