namespace Mirror.BouncyCastle.Asn1.Anssi;

[Token(Token = "0x2000275")]
public sealed class AnssiObjectIdentifiers
{
	[Token(Token = "0x40007BC")]
	public static readonly DerObjectIdentifier FRP256v1; //Field offset: 0x0

	[Address(RVA = "0x11203C0", Offset = "0x111F5C0", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DerObjectIdentifier), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60013B7")]
	private static AnssiObjectIdentifiers() { }

}

