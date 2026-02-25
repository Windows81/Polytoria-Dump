namespace System.Threading.Tasks;

[Token(Token = "0x200026E")]
internal interface ITaskCompletionAction
{

	[Token(Token = "0x170001F8")]
	public bool InvokeMayRunArbitraryCode
	{
		[Token(Token = "0x600142A")]
		 get { } //Length: 0
	}

	[Token(Token = "0x600142A")]
	public bool get_InvokeMayRunArbitraryCode() { }

	[Token(Token = "0x6001429")]
	public void Invoke(Task completingTask) { }

}

