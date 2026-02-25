namespace Mono.Math.Prime;

[Token(Token = "0x200005B")]
public sealed class PrimalityTests
{

	[Address(RVA = "0x12CF1A0", Offset = "0x12CE3A0", Length = "0xC8")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000221")]
	private static int GetSPPRounds(BigInteger bi, ConfidenceFactor confidence) { }

	[Address(RVA = "0x12CF360", Offset = "0x12CE560", Length = "0x14C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BigInteger), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsInvalidInstructions]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000222")]
	public static bool RabinMillerTest(BigInteger n, ConfidenceFactor confidence) { }

}

