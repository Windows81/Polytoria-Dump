namespace System.Runtime.Remoting.Services;

[ComVisible(True)]
[Token(Token = "0x2000354")]
public interface ITrackingHandler
{

	[Token(Token = "0x6001A96")]
	public void DisconnectedObject(object obj) { }

	[Token(Token = "0x6001A97")]
	public void MarshaledObject(object obj, ObjRef or) { }

	[Token(Token = "0x6001A98")]
	public void UnmarshaledObject(object obj, ObjRef or) { }

}

