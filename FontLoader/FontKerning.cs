using System;
using System.IO;
using System.Xml.Serialization;

namespace BlankGame
{
	[Serializable]
	public class FontKerning
	{
		[XmlAttribute ( "first" )]
		public Int32 First
		{
			get;
			set;
		}

		[XmlAttribute ( "second" )]
		public Int32 Second
		{
			get;
			set;
		}

		[XmlAttribute ( "amount" )]
		public Int32 Amount
		{
			get;
			set;
		}
	}
}

