namespace System.Runtime.Serialization;

[Token(Token = "0x20003CC")]
public interface ISerializationSurrogate
{

	[Token(Token = "0x6001CE6")]
	public void GetObjectData(object obj, SerializationInfo info, StreamingContext context) { }

	[Token(Token = "0x6001CE7")]
	public object SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector) { }

}

