namespace Mirror.BouncyCastle.Math.EC.Multiplier;

[Token(Token = "0x2000069")]
public class FixedPointUtilities
{
	[Token(Token = "0x200006A")]
	private class FixedPointCallback : IPreCompCallback
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000102")]
		private readonly ECPoint m_p; //Field offset: 0x10

		[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
		[CallerCount(Count = 72)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000413")]
		internal FixedPointCallback(ECPoint p) { }

		[Address(RVA = "0x115A680", Offset = "0x1159880", Length = "0xEC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000415")]
		private bool CheckExisting(FixedPointPreCompInfo existingFP, int n) { }

		[Address(RVA = "0x115A770", Offset = "0x1159970", Length = "0xB9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000416")]
		private bool CheckTable(ECLookupTable table, int n) { }

		[Address(RVA = "0x115A830", Offset = "0x1159A30", Length = "0x663")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(BigInteger), Member = "get_BitLength", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 14)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000414")]
		public override PreCompInfo Precompute(PreCompInfo existing) { }

	}

	[Token(Token = "0x4000101")]
	public static readonly string PRECOMP_NAME; //Field offset: 0x0

	[Address(RVA = "0x115B440", Offset = "0x115A640", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000412")]
	private static FixedPointUtilities() { }

	[Address(RVA = "0x115B290", Offset = "0x115A490", Length = "0x58")]
	[CalledBy(Type = typeof(ECAlgorithms), Member = "ImplShamirsTrickWNaf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint), typeof(BigInteger), typeof(ECPoint), typeof(BigInteger)}, ReturnType = typeof(ECPoint))]
	[CalledBy(Type = typeof(ECAlgorithms), Member = "ImplShamirsTrickFixedPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint), typeof(BigInteger), typeof(ECPoint), typeof(BigInteger)}, ReturnType = typeof(ECPoint))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BigInteger), Member = "get_BitLength", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000410")]
	public static int GetCombSize(ECCurve c) { }

	[Address(RVA = "0x115B2F0", Offset = "0x115A4F0", Length = "0x140")]
	[CalledBy(Type = typeof(ECAlgorithms), Member = "ImplShamirsTrickFixedPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint), typeof(BigInteger), typeof(ECPoint), typeof(BigInteger)}, ReturnType = typeof(ECPoint))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000411")]
	public static FixedPointPreCompInfo Precompute(ECPoint p) { }

}

