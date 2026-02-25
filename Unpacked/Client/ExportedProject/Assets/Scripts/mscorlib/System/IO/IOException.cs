namespace System.IO;

[Token(Token = "0x200062C")]
public class IOException : SystemException
{

	[Address(RVA = "0x145ACE0", Offset = "0x1459EE0", Length = "0x44")]
	[CalledBy(Type = typeof(ManualResetEventSlim), Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventWaitHandle), Member = "Reset", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FileStream), Member = "ReadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeHandle), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Net.WebResponseStream+<ReadAllAsyncInner>d__47", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.BouncyCastle.Asn1.Asn1Exception", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002CDE")]
	public IOException() { }

	[Address(RVA = "0x145ACC0", Offset = "0x1459EC0", Length = "0x1E")]
	[CallerCount(Count = 58)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002CDF")]
	public IOException(string message) { }

	[Address(RVA = "0x145AC90", Offset = "0x1459E90", Length = "0x26")]
	[CalledBy(Type = typeof(RegistryKey), Member = "Win32Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileSystem), Member = "MoveDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Directory), Member = "Move", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__Error), Member = "WinIOError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoIO), Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoIOError)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(MonoIO), Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoIOError)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002CE0")]
	public IOException(string message, int hresult) { }

	[Address(RVA = "0x145AD30", Offset = "0x1459F30", Length = "0x1E")]
	[CallerCount(Count = 22)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002CE1")]
	public IOException(string message, Exception innerException) { }

	[Address(RVA = "0x13225B0", Offset = "0x13217B0", Length = "0x1F")]
	[CallerCount(Count = 15)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002CE2")]
	protected IOException(SerializationInfo info, StreamingContext context) { }

}

