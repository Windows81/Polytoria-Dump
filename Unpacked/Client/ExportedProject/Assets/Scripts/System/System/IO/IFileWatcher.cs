namespace System.IO;

[Token(Token = "0x20001EC")]
internal interface IFileWatcher
{

	[Token(Token = "0x6000C50")]
	public void Dispose(object fsw) { }

	[Token(Token = "0x6000C4E")]
	public void StartDispatching(object fsw) { }

	[Token(Token = "0x6000C4F")]
	public void StopDispatching(object fsw) { }

}

