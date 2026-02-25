namespace Mono.Math.Prime;

[Token(Token = "0x2000075")]
internal sealed class PrimalityTests
{

	[Address(RVA = "0x12F7600", Offset = "0x12F6800", Length = "0xC8")]
	[CalledBy(Type = typeof(PrimalityTests), Member = "RabinMillerTest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(ConfidenceFactor)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PrimalityTests), Member = "SmallPrimeSppTest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(ConfidenceFactor)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600020C")]
	private static int GetSPPRounds(BigInteger bi, ConfidenceFactor confidence) { }

	[Address(RVA = "0x12F77C0", Offset = "0x12F69C0", Length = "0x3BC")]
	[CalledBy(Type = typeof(BigInteger), Member = "IsProbablePrime", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PrimalityTests), Member = "Test", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(ConfidenceFactor)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BigInteger), Member = "GenerateRandom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ModulusRing), Member = "Pow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(ModulusRing), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(void))]
	[Calls(Type = "Mono.Math.BigInteger+Kernel", Member = "RightShift", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(int)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "LowestSetBit", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ModulusRing), Member = "Pow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(PrimalityTests), Member = "GetSPPRounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(ConfidenceFactor)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BigInteger), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BigInteger), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 6)]
	[Token(Token = "0x600020E")]
	public static bool RabinMillerTest(BigInteger n, ConfidenceFactor confidence) { }

	[Address(RVA = "0x12F7B80", Offset = "0x12F6D80", Length = "0x2CD")]
	[CalledBy(Type = typeof(BigInteger), Member = "IsProbablePrime", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PrimalityTests), Member = "Test", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(ConfidenceFactor)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = "Mono.Math.BigInteger+Kernel", Member = "multiByteDivide", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger[]))]
	[Calls(Type = typeof(BigInteger), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ModulusRing), Member = "Pow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(ModulusRing), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(void))]
	[Calls(Type = "Mono.Math.BigInteger+Kernel", Member = "RightShift", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(int)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(BigInteger), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PrimalityTests), Member = "GetSPPRounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(ConfidenceFactor)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BigInteger), Member = "LowestSetBit", ReturnType = typeof(int))]
	[Token(Token = "0x600020F")]
	public static bool SmallPrimeSppTest(BigInteger bi, ConfidenceFactor confidence) { }

	[Address(RVA = "0x12F7E50", Offset = "0x12F7050", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PrimalityTests), Member = "RabinMillerTest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(ConfidenceFactor)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PrimalityTests), Member = "SmallPrimeSppTest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(ConfidenceFactor)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600020D")]
	public static bool Test(BigInteger n, ConfidenceFactor confidence) { }

}

