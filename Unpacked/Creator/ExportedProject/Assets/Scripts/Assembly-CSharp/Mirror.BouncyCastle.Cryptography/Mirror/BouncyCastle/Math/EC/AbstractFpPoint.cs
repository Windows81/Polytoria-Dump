namespace Mirror.BouncyCastle.Math.EC;

[Token(Token = "0x200004B")]
public abstract class AbstractFpPoint : ECPointBase
{

	[Token(Token = "0x17000045")]
	protected private virtual bool CompressionYTilde
	{
		[Address(RVA = "0x1139480", Offset = "0x1138680", Length = "0x3C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000316")]
		private get { } //Length: 60
	}

	[Address(RVA = "0x1138370", Offset = "0x1137570", Length = "0xE")]
	[CallerCount(Count = 155)]
	[Calls(Type = typeof(ECPointBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(ECFieldElement), typeof(ECFieldElement)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000314")]
	protected AbstractFpPoint(ECCurve curve, ECFieldElement x, ECFieldElement y) { }

	[Address(RVA = "0x1138380", Offset = "0x1137580", Length = "0xE")]
	[CallerCount(Count = 174)]
	[Calls(Type = typeof(ECPointBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(ECFieldElement), typeof(ECFieldElement), typeof(ECFieldElement[])}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000315")]
	protected AbstractFpPoint(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs) { }

	[Address(RVA = "0x1139480", Offset = "0x1138680", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000316")]
	protected private virtual bool get_CompressionYTilde() { }

	[Address(RVA = "0x11390A0", Offset = "0x11382A0", Length = "0x3D7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 23)]
	[Token(Token = "0x6000317")]
	protected virtual bool SatisfiesCurveEquation() { }

	[Address(RVA = "0x1137FB0", Offset = "0x11371B0", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000318")]
	public virtual ECPoint Subtract(ECPoint b) { }

}

