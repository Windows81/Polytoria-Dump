namespace System.Security.Cryptography;

[Token(Token = "0x200030F")]
internal class RSAPKCS1SHA1SignatureDescription : RSAPKCS1SignatureDescription
{

	[Address(RVA = "0x134D570", Offset = "0x134C770", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RSAPKCS1SignatureDescription), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60018A5")]
	public RSAPKCS1SHA1SignatureDescription() { }

}

