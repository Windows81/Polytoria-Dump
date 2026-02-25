namespace Mirror.BouncyCastle.Math.EC.Multiplier;

[Token(Token = "0x2000077")]
public class WTauNafPreCompInfo : PreCompInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400011F")]
	protected AbstractF2mPoint[] m_preComp; //Field offset: 0x10

	[Token(Token = "0x17000052")]
	public override AbstractF2mPoint[] PreComp
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000453")]
		 get { } //Length: 5
		[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000454")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000455")]
	public WTauNafPreCompInfo() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000453")]
	public override AbstractF2mPoint[] get_PreComp() { }

	[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000454")]
	public override void set_PreComp(AbstractF2mPoint[] value) { }

}

