namespace Mirror.BouncyCastle.Asn1;

[Token(Token = "0x20001AE")]
internal abstract class Asn1Type
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000441")]
	internal readonly Type m_platformType; //Field offset: 0x10

	[Token(Token = "0x17000188")]
	internal Type PlatformType
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000FDF")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FDE")]
	internal Asn1Type(Type platformType) { }

	[Address(RVA = "0x2D8A50", Offset = "0x2D7C50", Length = "0x7")]
	[CallerCount(Count = 1453)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FE0")]
	public virtual bool Equals(object that) { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FDF")]
	internal Type get_PlatformType() { }

	[Address(RVA = "0x2D8E50", Offset = "0x2D8050", Length = "0x7")]
	[CallerCount(Count = 10)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FE1")]
	public virtual int GetHashCode() { }

}

