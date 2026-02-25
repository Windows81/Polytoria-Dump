namespace Mirror.BouncyCastle.Crypto.Modes.Gcm;

[Obsolete("Will be removed")]
[Token(Token = "0x200014E")]
public class BasicGcmMultiplier : IGcmMultiplier
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002C2")]
	private FieldElement H; //Field offset: 0x10

	[Token(Token = "0x1700017F")]
	internal static bool IsHardwareAccelerated
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C70")]
		internal get { } //Length: 3
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C73")]
	public BasicGcmMultiplier() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C70")]
	internal static bool get_IsHardwareAccelerated() { }

	[Address(RVA = "0x11DDDF0", Offset = "0x11DCFF0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Pack), Member = "BE_To_UInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(ulong))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C71")]
	public override void Init(Byte[] H) { }

	[Address(RVA = "0x11DDE30", Offset = "0x11DD030", Length = "0x7B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Pack), Member = "BE_To_UInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(ulong))]
	[Calls(Type = typeof(GcmUtilities), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldElement&), typeof(FieldElement&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Pack), Member = "UInt64_To_BE", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000C72")]
	public override void MultiplyH(Byte[] x) { }

}

