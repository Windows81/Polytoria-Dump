namespace System;

[Token(Token = "0x20000C2")]
public class UriFormatException : FormatException, ISerializable
{

	[Address(RVA = "0x1747B60", Offset = "0x1746D60", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FormatException), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000410")]
	public UriFormatException() { }

	[Address(RVA = "0x1747B70", Offset = "0x1746D70", Length = "0x8")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000411")]
	public UriFormatException(string textString) { }

	[Address(RVA = "0x10BD4F0", Offset = "0x10BC6F0", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000412")]
	protected UriFormatException(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	[Address(RVA = "0x1747B40", Offset = "0x1746D40", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Exception), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000413")]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

}

