namespace System.Configuration;

[Token(Token = "0x2000004")]
public enum ConfigurationSaveMode
{
	Full = 2,
	Minimal = 1,
	Modified = 0,
}

