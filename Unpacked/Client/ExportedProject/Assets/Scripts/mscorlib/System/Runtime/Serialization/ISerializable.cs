namespace System.Runtime.Serialization;

[Token(Token = "0x20003C5")]
public interface ISerializable
{

	[Token(Token = "0x6001CC9")]
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

