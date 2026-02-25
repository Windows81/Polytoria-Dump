namespace System.Net;

[Token(Token = "0x2000268")]
public class CookieException : FormatException, ISerializable
{

	[Address(RVA = "0x1747B60", Offset = "0x1746D60", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FormatException), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F62")]
	public CookieException() { }

	[Address(RVA = "0x1747B70", Offset = "0x1746D70", Length = "0x8")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F63")]
	internal CookieException(string message) { }

	[Address(RVA = "0x17ED320", Offset = "0x17EC520", Length = "0x8")]
	[CalledBy(Type = typeof(CookieContainer), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cookie), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CookieContainer), Member = "CookieCutter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(CookieCollection))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000F64")]
	internal CookieException(string message, Exception inner) { }

	[Address(RVA = "0x10BD4F0", Offset = "0x10BC6F0", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F65")]
	protected CookieException(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	[Address(RVA = "0x1747B40", Offset = "0x1746D40", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Exception), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F67")]
	public virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	[Address(RVA = "0x1747B40", Offset = "0x1746D40", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Exception), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F66")]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

}

