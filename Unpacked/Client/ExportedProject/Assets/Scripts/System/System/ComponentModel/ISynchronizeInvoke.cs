namespace System.ComponentModel;

[Token(Token = "0x200014E")]
public interface ISynchronizeInvoke
{

	[Token(Token = "0x17000183")]
	public bool InvokeRequired
	{
		[Token(Token = "0x6000825")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000826")]
	public IAsyncResult BeginInvoke(Delegate method, Object[] args) { }

	[Token(Token = "0x6000825")]
	public bool get_InvokeRequired() { }

}

