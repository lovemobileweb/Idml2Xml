

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Xml;

namespace Stories
{
	class Content : Child
	{

		public Content(string text)
		{
			this.Text = text;
		}

		public override string ToString()
		{
			return this.Text;
		}

		public string Text { get; set; }

        internal void Save(XmlTextWriter textWriter)
        {
            
        }
    }
}
