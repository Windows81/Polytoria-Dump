namespace Mirror.BouncyCastle.Math.EC.Multiplier;

[Token(Token = "0x200006B")]
public class GlvMultiplier : AbstractECMultiplier
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000103")]
	protected readonly ECCurve curve; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000104")]
	protected readonly GlvEndomorphism glvEndomorphism; //Field offset: 0x18

	[Address(RVA = "0x115B8D0", Offset = "0x115AAD0", Length = "0xC8")]
	[CalledBy(Type = typeof(ECCurve), Member = "CreateDefaultMultiplier", ReturnType = typeof(ECMultiplier))]
	[CalledBy(Type = typeof(F2mCurve), Member = "CreateDefaultMultiplier", ReturnType = typeof(ECMultiplier))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000417")]
	public GlvMultiplier(ECCurve curve, GlvEndomorphism glvEndomorphism) { }

	[Address(RVA = "0x115B4B0", Offset = "0x115A6B0", Length = "0x414")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ECAlgorithms), Member = "ImplShamirsTrickWNaf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint), typeof(BigInteger), typeof(ECPoint), typeof(BigInteger)}, ReturnType = typeof(ECPoint))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ECAlgorithms), Member = "ImplShamirsTrickWNaf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECEndomorphism), typeof(ECPoint), typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(ECPoint))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(BigInteger), Member = "Mod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	[Token(Token = "0x6000418")]
	protected virtual ECPoint MultiplyPositive(ECPoint p, BigInteger k) { }

}

