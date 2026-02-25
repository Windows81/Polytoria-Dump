namespace Mirror.BouncyCastle.Math.EC.Endo;

[Token(Token = "0x200007A")]
public abstract class EndoUtilities
{
	[Token(Token = "0x200007B")]
	private class MapPointCallback : IPreCompCallback
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000123")]
		private readonly ECEndomorphism m_endomorphism; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000124")]
		private readonly ECPoint m_point; //Field offset: 0x18

		[Address(RVA = "0x331270", Offset = "0x330470", Length = "0x4E")]
		[CallerCount(Count = 37)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000461")]
		internal MapPointCallback(ECEndomorphism endomorphism, ECPoint point) { }

		[Address(RVA = "0x115BAF0", Offset = "0x115ACF0", Length = "0x64")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000463")]
		private bool CheckExisting(EndoPreCompInfo existingEndo, ECEndomorphism endomorphism) { }

		[Address(RVA = "0x115BB60", Offset = "0x115AD60", Length = "0x1ED")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		[Token(Token = "0x6000462")]
		public override PreCompInfo Precompute(PreCompInfo existing) { }

	}

	[Token(Token = "0x4000122")]
	public static readonly string PRECOMP_NAME; //Field offset: 0x0

	[Address(RVA = "0x115A610", Offset = "0x1159810", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000460")]
	private static EndoUtilities() { }

	[Address(RVA = "0x115A140", Offset = "0x1159340", Length = "0x109")]
	[CalledBy(Type = typeof(EndoUtilities), Member = "DecomposeScalar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScalarSplitParameters), typeof(BigInteger)}, ReturnType = typeof(BigInteger[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BigInteger), Member = "Abs", ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "TestBit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BigInteger), Member = "ShiftRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BigInteger), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "Negate", ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600045F")]
	private static BigInteger CalculateB(BigInteger k, BigInteger g, int t) { }

	[Address(RVA = "0x115A250", Offset = "0x1159450", Length = "0x249")]
	[CalledBy(Type = typeof(GlvTypeBEndomorphism), Member = "DecomposeScalar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(BigInteger[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EndoUtilities), Member = "CalculateB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger), typeof(int)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "Subtract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "Negate", ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 7)]
	[Token(Token = "0x600045D")]
	public static BigInteger[] DecomposeScalar(ScalarSplitParameters p, BigInteger k) { }

	[Address(RVA = "0x115A4A0", Offset = "0x11596A0", Length = "0x16E")]
	[CalledBy(Type = typeof(ECAlgorithms), Member = "ImplShamirsTrickWNaf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECEndomorphism), typeof(ECPoint), typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(ECPoint))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600045E")]
	public static ECPoint MapPoint(ECEndomorphism endomorphism, ECPoint p) { }

}

