namespace System.Threading.Tasks.Sources;

[Token(Token = "0x200028B")]
public interface IValueTaskSource
{

	[Token(Token = "0x600149A")]
	public TResult GetResult(short token) { }

	[Token(Token = "0x6001498")]
	public ValueTaskSourceStatus GetStatus(short token) { }

	[Token(Token = "0x6001499")]
	public void OnCompleted(Action<Object> continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags) { }

}

