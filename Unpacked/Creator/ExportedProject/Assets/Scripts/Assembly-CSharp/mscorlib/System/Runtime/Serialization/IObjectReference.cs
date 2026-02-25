namespace System.Runtime.Serialization;

[Token(Token = "0x20003C4")]
public interface IObjectReference
{

	[Token(Token = "0x6001CC8")]
	public object GetRealObject(StreamingContext context) { }

}

