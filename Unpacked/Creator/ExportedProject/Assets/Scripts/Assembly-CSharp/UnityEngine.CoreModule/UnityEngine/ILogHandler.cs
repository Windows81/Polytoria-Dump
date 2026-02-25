namespace UnityEngine;

[Token(Token = "0x20000F0")]
public interface ILogHandler
{

	[Token(Token = "0x60006C1")]
	public void LogException(Exception exception, object context) { }

	[Token(Token = "0x60006C0")]
	public void LogFormat(LogType logType, object context, string format, Object[] args) { }

}

