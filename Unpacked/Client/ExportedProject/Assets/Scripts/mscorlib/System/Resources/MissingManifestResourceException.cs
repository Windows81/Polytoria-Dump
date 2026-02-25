namespace System.Resources;

[Token(Token = "0x20004A6")]
public class MissingManifestResourceException : SystemException
{

	[Address(RVA = "0x13BE900", Offset = "0x13BDB00", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60020DD")]
	public MissingManifestResourceException() { }

	[Address(RVA = "0x13225B0", Offset = "0x13217B0", Length = "0x1F")]
	[CallerCount(Count = 15)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60020DE")]
	protected MissingManifestResourceException(SerializationInfo info, StreamingContext context) { }

}

