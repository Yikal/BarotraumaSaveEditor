﻿using System.Xml.Serialization;

namespace MultiplayerCharacterXmlParser.BarotraumaContent.CharacterTalents
{
	public class TalentSubTree
	{
		[XmlAttribute("identifier")]
		public string Id { get; set; }

		[XmlElement("TalentOptions")]
		public IReadOnlyList<TalentOptionArray> TalentTiers { get; set; }
	}
}
