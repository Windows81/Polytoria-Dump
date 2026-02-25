namespace System.Runtime.Serialization;

[Token(Token = "0x20003CD")]
public interface ISurrogateSelector
{

	[Token(Token = "0x6001CE8")]
	public ISerializationSurrogate GetSurrogate(Type type, StreamingContext context, out ISurrogateSelector selector) { }

}

