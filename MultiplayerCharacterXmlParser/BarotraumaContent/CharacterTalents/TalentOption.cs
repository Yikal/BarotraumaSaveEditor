﻿using System.Xml.Serialization;

namespace MultiplayerCharacterXmlParser.BarotraumaContent.CharacterTalents
{
	public class TalentOption
	{
		[XmlAttribute("identifier")]
		public string Id { get; set; }
	}
}
