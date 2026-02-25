namespace Mirror.BouncyCastle.Math.EC;

[Token(Token = "0x2000051")]
public class ScaleXPointMap : ECPointMap
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000B6")]
	protected readonly ECFieldElement scale; //Field offset: 0x10

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600036B")]
	public ScaleXPointMap(ECFieldElement scale) { }

	[Address(RVA = "0x11551D0", Offset = "0x11543D0", Length = "0x30")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600036C")]
	public override ECPoint Map(ECPoint p) { }

}

