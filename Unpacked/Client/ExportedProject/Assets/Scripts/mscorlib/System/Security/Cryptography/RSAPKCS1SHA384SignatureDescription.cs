namespace System.Security.Cryptography;

[Token(Token = "0x2000311")]
internal class RSAPKCS1SHA384SignatureDescription : RSAPKCS1SignatureDescription
{

	[Address(RVA = "0x134D610", Offset = "0x134C810", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RSAPKCS1SignatureDescription), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60018A7")]
	public RSAPKCS1SHA384SignatureDescription() { }

}

