namespace Mirror.BouncyCastle.Math.EC.Multiplier;

[Token(Token = "0x2000068")]
public class FixedPointPreCompInfo : PreCompInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000FE")]
	protected ECPoint m_offset; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000FF")]
	protected ECLookupTable m_lookupTable; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000100")]
	protected int m_width; //Field offset: 0x20

	[Token(Token = "0x17000048")]
	public override ECLookupTable LookupTable
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000409")]
		 get { } //Length: 5
		[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x600040A")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000049")]
	public override ECPoint Offset
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x600040B")]
		 get { } //Length: 5
		[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x600040C")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700004A")]
	public override int Width
	{
		[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x600040D")]
		 get { } //Length: 4
		[Address(RVA = "0x331A20", Offset = "0x330C20", Length = "0x4")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x600040E")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x1079D50", Offset = "0x1078F50", Length = "0xE")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600040F")]
	public FixedPointPreCompInfo() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000409")]
	public override ECLookupTable get_LookupTable() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x600040B")]
	public override ECPoint get_Offset() { }

	[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x600040D")]
	public override int get_Width() { }

	[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600040A")]
	public override void set_LookupTable(ECLookupTable value) { }

	[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600040C")]
	public override void set_Offset(ECPoint value) { }

	[Address(RVA = "0x331A20", Offset = "0x330C20", Length = "0x4")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x600040E")]
	public override void set_Width(int value) { }

}

