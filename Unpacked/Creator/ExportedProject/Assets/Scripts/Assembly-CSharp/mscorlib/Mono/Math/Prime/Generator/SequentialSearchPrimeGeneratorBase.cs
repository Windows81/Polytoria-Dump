namespace Mono.Math.Prime.Generator;

[Token(Token = "0x2000077")]
internal class SequentialSearchPrimeGeneratorBase : PrimeGeneratorBase
{

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000219")]
	public SequentialSearchPrimeGeneratorBase() { }

	[Address(RVA = "0x12D3670", Offset = "0x12D2870", Length = "0x17")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000216")]
	public virtual BigInteger GenerateNewPrime(int bits) { }

	[Address(RVA = "0x12FD1D0", Offset = "0x12FC3D0", Length = "0x3D1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000217")]
	public override BigInteger GenerateNewPrime(int bits, object context) { }

	[Address(RVA = "0x12FD5B0", Offset = "0x12FC7B0", Length = "0xAD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BigInteger), Member = "get_Rng", ReturnType = typeof(RandomNumberGenerator))]
	[Calls(Type = typeof(BigInteger), Member = "GenerateRandom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RandomNumberGenerator)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000215")]
	protected override BigInteger GenerateSearchBase(int bits, object context) { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000218")]
	protected override bool IsPrimeAcceptable(BigInteger bi, object context) { }

}

