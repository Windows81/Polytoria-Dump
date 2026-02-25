namespace GLTFast.Logging;

[Token(Token = "0x20000E1")]
public interface ICodeLogger
{

	[Token(Token = "0x60002A3")]
	public void Error(LogCode code, String[] messages) { }

	[Token(Token = "0x60002A5")]
	public void Info(LogCode code, String[] messages) { }

	[Token(Token = "0x60002A6")]
	public void Log(LogType logType, LogCode code, String[] messages) { }

	[Token(Token = "0x60002A4")]
	public void Warning(LogCode code, String[] messages) { }

}

