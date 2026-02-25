namespace System.IO;

[Token(Token = "0x200063E")]
public class DriveNotFoundException : IOException
{

	[Address(RVA = "0x1454830", Offset = "0x1453A30", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002DD5")]
	public DriveNotFoundException() { }

	[Address(RVA = "0x14533B0", Offset = "0x14525B0", Length = "0x1E")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002DD6")]
	public DriveNotFoundException(string message) { }

	[Address(RVA = "0x13225B0", Offset = "0x13217B0", Length = "0x1F")]
	[CallerCount(Count = 15)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002DD7")]
	protected DriveNotFoundException(SerializationInfo info, StreamingContext context) { }

}

