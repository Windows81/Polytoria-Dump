namespace Mirror.BouncyCastle.Math.EC.Endo;

[Token(Token = "0x200007D")]
public class GlvTypeBEndomorphism : GlvEndomorphism, ECEndomorphism
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000125")]
	protected readonly GlvTypeBParameters m_parameters; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000126")]
	protected readonly ECPointMap m_pointMap; //Field offset: 0x18

	[Token(Token = "0x17000058")]
	public override bool HasEfficientPointMap
	{
		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000468")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000057")]
	public override ECPointMap PointMap
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000467")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x115BA20", Offset = "0x115AC20", Length = "0xCC")]
	[CalledBy(Type = typeof(CustomNamedCurves), Member = "ConfigureCurveGlv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(GlvTypeBParameters)}, ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(SecNamedCurves), Member = "ConfigureCurveGlv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(GlvTypeBParameters)}, ReturnType = typeof(ECCurve))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000465")]
	public GlvTypeBEndomorphism(ECCurve curve, GlvTypeBParameters parameters) { }

	[Address(RVA = "0x115B9A0", Offset = "0x115ABA0", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EndoUtilities), Member = "DecomposeScalar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScalarSplitParameters), typeof(BigInteger)}, ReturnType = typeof(BigInteger[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000466")]
	public override BigInteger[] DecomposeScalar(BigInteger k) { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000468")]
	public override bool get_HasEfficientPointMap() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000467")]
	public override ECPointMap get_PointMap() { }

}

