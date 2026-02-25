namespace System.Xml;

[Token(Token = "0x2000021")]
internal interface IValidationEventHandling
{

	[Token(Token = "0x60000B2")]
	public void SendEvent(Exception exception, XmlSeverityType severity) { }

}

