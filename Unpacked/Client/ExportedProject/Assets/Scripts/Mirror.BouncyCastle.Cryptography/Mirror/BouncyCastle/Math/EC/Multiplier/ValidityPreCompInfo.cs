namespace Mirror.BouncyCastle.Math.EC.Multiplier;

[Token(Token = "0x200006E")]
internal class ValidityPreCompInfo : PreCompInfo
{
	[Token(Token = "0x4000105")]
	internal static readonly string PRECOMP_NAME; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000106")]
	private bool failed; //Field offset: 0x10
	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x4000107")]
	private bool curveEquationPassed; //Field offset: 0x11
	[FieldOffset(Offset = "0x12")]
	[Token(Token = "0x4000108")]
	private bool orderPassed; //Field offset: 0x12

	[Address(RVA = "0x11623F0", Offset = "0x11615F0", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000421")]
	private static ValidityPreCompInfo() { }

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000420")]
	public ValidityPreCompInfo() { }

	[Address(RVA = "0x3CE370", Offset = "0x3CD570", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600041C")]
	internal bool HasCurveEquationPassed() { }

	[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600041A")]
	internal bool HasFailed() { }

	[Address(RVA = "0x5E9D30", Offset = "0x5E8F30", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600041E")]
	internal bool HasOrderPassed() { }

	[Address(RVA = "0x551C00", Offset = "0x550E00", Length = "0x5")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x600041D")]
	internal void ReportCurveEquationPassed() { }

	[Address(RVA = "0x551C10", Offset = "0x550E10", Length = "0x5")]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x600041B")]
	internal void ReportFailed() { }

	[Address(RVA = "0x11623E0", Offset = "0x11615E0", Length = "0x5")]
	[CalledBy(Type = "Mirror.BouncyCastle.Math.EC.ECPoint+ValidityCallback", Member = "Precompute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PreCompInfo)}, ReturnType = typeof(PreCompInfo))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x600041F")]
	internal void ReportOrderPassed() { }

}

