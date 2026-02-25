namespace Mirror.BouncyCastle.Crypto.Modes.Gcm;

[Obsolete("Will be removed")]
[Token(Token = "0x200014D")]
public class BasicGcmExponentiator : IGcmExponentiator
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002C1")]
	private FieldElement x; //Field offset: 0x10

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C6F")]
	public BasicGcmExponentiator() { }

	[Address(RVA = "0x11DDCB0", Offset = "0x11DCEB0", Length = "0x131")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GcmUtilities), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldElement&), typeof(FieldElement&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Interleave), Member = "Expand64To128Rev", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(UInt64&)}, ReturnType = typeof(ulong))]
	[Calls(Type = typeof(Pack), Member = "UInt64_To_BE", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000C6E")]
	public override void ExponentiateX(long pow, Byte[] output) { }

	[Address(RVA = "0x11DDDF0", Offset = "0x11DCFF0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Pack), Member = "BE_To_UInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(ulong))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C6D")]
	public override void Init(Byte[] x) { }

}

