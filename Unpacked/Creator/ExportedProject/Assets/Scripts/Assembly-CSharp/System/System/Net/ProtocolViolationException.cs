namespace System.Net;

[Token(Token = "0x2000238")]
public class ProtocolViolationException : InvalidOperationException, ISerializable
{

	[Address(RVA = "0x10E8B10", Offset = "0x10E7D10", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E2E")]
	public ProtocolViolationException() { }

	[Address(RVA = "0x10E8AF0", Offset = "0x10E7CF0", Length = "0x8")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E2F")]
	public ProtocolViolationException(string message) { }

	[Address(RVA = "0x10BD4F0", Offset = "0x10BC6F0", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E30")]
	protected ProtocolViolationException(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	[Address(RVA = "0x1747B40", Offset = "0x1746D40", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Exception), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E32")]
	public virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	[Address(RVA = "0x1747B40", Offset = "0x1746D40", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Exception), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E31")]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

}

