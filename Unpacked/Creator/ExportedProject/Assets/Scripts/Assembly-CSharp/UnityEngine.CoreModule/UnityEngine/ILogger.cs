namespace UnityEngine;

[Token(Token = "0x20000EF")]
public interface ILogger : ILogHandler
{

	[Token(Token = "0x17000129")]
	public bool logEnabled
	{
		[Token(Token = "0x60006BA")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000128")]
	public ILogHandler logHandler
	{
		[Token(Token = "0x60006B9")]
		 get { } //Length: 0
	}

	[Token(Token = "0x60006BA")]
	public bool get_logEnabled() { }

	[Token(Token = "0x60006B9")]
	public ILogHandler get_logHandler() { }

	[Token(Token = "0x60006BB")]
	public bool IsLogTypeAllowed(LogType logType) { }

	[Token(Token = "0x60006BC")]
	public void Log(LogType logType, object message) { }

	[Token(Token = "0x60006BD")]
	public void Log(LogType logType, object message, object context) { }

	[Token(Token = "0x60006BE")]
	public void LogError(string tag, object message) { }

	[Token(Token = "0x60006BF")]
	public void LogFormat(LogType logType, string format, Object[] args) { }

}

