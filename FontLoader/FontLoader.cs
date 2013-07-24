using System;
using System.IO;
using System.Xml.Serialization;

namespace BlankGame
{
	public class FontLoader
	{
		public static FontFile Load ( String filename )
		{
			XmlSerializer deserializer = new XmlSerializer ( typeof ( FontFile ) );
			TextReader textReader = new StreamReader ( filename );
			FontFile file = ( FontFile ) deserializer.Deserialize ( textReader );
			textReader.Close ( );
			return file;
		}
	}
}

