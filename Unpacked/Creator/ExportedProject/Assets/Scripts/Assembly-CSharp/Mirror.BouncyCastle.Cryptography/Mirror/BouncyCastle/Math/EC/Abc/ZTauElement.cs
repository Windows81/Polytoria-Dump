namespace Mirror.BouncyCastle.Math.EC.Abc;

[Token(Token = "0x200010B")]
internal class ZTauElement
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000232")]
	public readonly BigInteger u; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000233")]
	public readonly BigInteger v; //Field offset: 0x18

	[Address(RVA = "0x331270", Offset = "0x330470", Length = "0x4E")]
	[CallerCount(Count = 37)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B09")]
	public ZTauElement(BigInteger u, BigInteger v) { }

}

