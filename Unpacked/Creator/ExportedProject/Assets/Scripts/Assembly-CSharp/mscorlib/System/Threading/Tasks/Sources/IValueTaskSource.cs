namespace System.Threading.Tasks.Sources;

[Token(Token = "0x200028A")]
public interface IValueTaskSource
{

	[Token(Token = "0x6001497")]
	public void GetResult(short token) { }

	[Token(Token = "0x6001495")]
	public ValueTaskSourceStatus GetStatus(short token) { }

	[Token(Token = "0x6001496")]
	public void OnCompleted(Action<Object> continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags) { }

}

