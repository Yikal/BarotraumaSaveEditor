﻿using System.Xml.Serialization;

namespace MultiplayerCharacterXmlParser.BarotraumaContent.CharacterTalents
{
	public class TalentOptionArray
	{
		[XmlElement("TalentOption")]
		public IReadOnlyCollection<TalentOption> TalentOptions { get; set; }
	}
}