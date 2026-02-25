namespace Mirror.BouncyCastle.Math.EC;

[Token(Token = "0x200004A")]
public abstract class ECPointBase : ECPoint
{

	[Address(RVA = "0x113E0B0", Offset = "0x113D2B0", Length = "0xF9")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ECPoint), Member = "GetInitialZCoords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve)}, ReturnType = typeof(ECFieldElement[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000310")]
	protected private ECPointBase(ECCurve curve, ECFieldElement x, ECFieldElement y) { }

	[Address(RVA = "0x113E1B0", Offset = "0x113D3B0", Length = "0xB1")]
	[CalledBy(Type = typeof(FpPoint), Member = "TwiceJacobianModified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(FpPoint))]
	[CalledBy(Type = typeof(F2mPoint), Member = "Negate", ReturnType = typeof(ECPoint))]
	[CalledBy(Type = typeof(F2mPoint), Member = "TwicePlus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint)}, ReturnType = typeof(ECPoint))]
	[CalledBy(Type = typeof(F2mPoint), Member = "Twice", ReturnType = typeof(ECPoint))]
	[CalledBy(Type = typeof(F2mPoint), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint)}, ReturnType = typeof(ECPoint))]
	[CalledBy(Type = typeof(F2mPoint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(ECFieldElement), typeof(ECFieldElement), typeof(ECFieldElement[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AbstractF2mPoint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(ECFieldElement), typeof(ECFieldElement), typeof(ECFieldElement[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FpPoint), Member = "TimesPow2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ECPoint))]
	[CalledBy(Type = typeof(FpPoint), Member = "Negate", ReturnType = typeof(ECPoint))]
	[CalledBy(Type = typeof(FpPoint), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint)}, ReturnType = typeof(ECPoint))]
	[CalledBy(Type = typeof(FpPoint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(ECFieldElement), typeof(ECFieldElement), typeof(ECFieldElement[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AbstractFpPoint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(ECFieldElement), typeof(ECFieldElement), typeof(ECFieldElement[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(F2mCurve), Member = "CreateRawPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECFieldElement), typeof(ECFieldElement), typeof(ECFieldElement[])}, ReturnType = typeof(ECPoint))]
	[CalledBy(Type = typeof(FpCurve), Member = "ImportPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint)}, ReturnType = typeof(ECPoint))]
	[CalledBy(Type = typeof(FpCurve), Member = "CreateRawPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECFieldElement), typeof(ECFieldElement), typeof(ECFieldElement[])}, ReturnType = typeof(ECPoint))]
	[CalledBy(Type = typeof(FpPoint), Member = "Twice", ReturnType = typeof(ECPoint))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000311")]
	protected private ECPointBase(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs) { }

	[Address(RVA = "0x113DD90", Offset = "0x113CF90", Length = "0x21E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000312")]
	public virtual Byte[] GetEncoded(bool compressed) { }

	[Address(RVA = "0x113DFB0", Offset = "0x113D1B0", Length = "0xF6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000313")]
	public virtual ECPoint Multiply(BigInteger k) { }

}

