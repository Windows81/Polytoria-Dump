namespace System.IO;

[Token(Token = "0x20001EE")]
public sealed class InvalidDataException : SystemException
{

	[Address(RVA = "0x17C4660", Offset = "0x17C3860", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000C53")]
	public InvalidDataException() { }

	[Address(RVA = "0x17C4640", Offset = "0x17C3840", Length = "0x1E")]
	[CalledBy(Type = "Mirror.SimpleWeb.MessageProcessor", Member = "ValidateHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.MessageProcessor", Member = "ThrowIfMaskNotExpected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.MessageProcessor", Member = "ThrowIfBadOpCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.MessageProcessor", Member = "ThrowIfLengthZero", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.MessageProcessor", Member = "ThrowIfMsgLengthTooLong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.ReceiveLoop", Member = "ReadOneMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.SimpleWeb.ReceiveLoop+Config", "System.Byte[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.SslConfigLoader", Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string), typeof(SslProtocols)}, ReturnType = "Mirror.SimpleWeb.SslConfig")]
	[CalledBy(Type = "Mirror.SimpleWeb.SslConfigLoader", Member = "LoadCertJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "Mirror.SimpleWeb.SslConfigLoader+Cert")]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000C54")]
	public InvalidDataException(string message) { }

	[Address(RVA = "0x13225B0", Offset = "0x13217B0", Length = "0x1F")]
	[CallerCount(Count = 15)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C55")]
	private InvalidDataException(SerializationInfo info, StreamingContext context) { }

}

