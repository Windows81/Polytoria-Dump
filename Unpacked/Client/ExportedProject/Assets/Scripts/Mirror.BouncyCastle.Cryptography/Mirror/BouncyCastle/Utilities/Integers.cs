namespace Mirror.BouncyCastle.Utilities;

[Token(Token = "0x2000008")]
public static class Integers
{
	[Token(Token = "0x4000005")]
	private static readonly Byte[] DeBruijnTZ; //Field offset: 0x0

	[Address(RVA = "0x10BD190", Offset = "0x10BC390", Length = "0x8C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000030")]
	private static Integers() { }

	[Address(RVA = "0x10BCFE0", Offset = "0x10BC1E0", Length = "0x86")]
	[CalledBy(Type = typeof(Mod), Member = "ModOddInverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(Mod), Member = "ModOddInverseVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Mod), Member = "ModOddIsCoprimeVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Nat), Member = "GetBitLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UInt32[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(AbstractF2mFieldElement), Member = "HalfTrace", ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(AbstractF2mFieldElement), Member = "Trace", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(WNafL2RMultiplier), Member = "MultiplyPositive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint), typeof(BigInteger)}, ReturnType = typeof(ECPoint))]
	[CallerCount(Count = 9)]
	[Token(Token = "0x600002A")]
	public static int NumberOfLeadingZeros(int i) { }

	[Address(RVA = "0x10BD070", Offset = "0x10BC270", Length = "0x91")]
	[CalledBy(Type = typeof(Mod), Member = "Divsteps30Var", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(Int32[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DHPublicKeyParameters), Member = "Legendre", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600002B")]
	public static int NumberOfTrailingZeros(int i) { }

	[Address(RVA = "0x10BD110", Offset = "0x10BC310", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[CLSCompliant(False)]
	[Token(Token = "0x600002C")]
	public static int PopCount(uint u) { }

	[Address(RVA = "0x10BD150", Offset = "0x10BC350", Length = "0x19")]
	[CallerCount(Count = 115)]
	[DeduplicatedMethod]
	[Token(Token = "0x600002D")]
	public static int RotateLeft(int i, int distance) { }

	[Address(RVA = "0x10BD150", Offset = "0x10BC350", Length = "0x19")]
	[CallerCount(Count = 115)]
	[CLSCompliant(False)]
	[DeduplicatedMethod]
	[Token(Token = "0x600002E")]
	public static uint RotateLeft(uint i, int distance) { }

	[Address(RVA = "0x10BD170", Offset = "0x10BC370", Length = "0x19")]
	[CallerCount(Count = 20)]
	[CLSCompliant(False)]
	[DeduplicatedMethod]
	[Token(Token = "0x600002F")]
	public static uint RotateRight(uint i, int distance) { }

}

