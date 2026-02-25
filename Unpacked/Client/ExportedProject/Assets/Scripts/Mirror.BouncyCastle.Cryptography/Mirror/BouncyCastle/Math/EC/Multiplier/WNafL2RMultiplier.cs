namespace Mirror.BouncyCastle.Math.EC.Multiplier;

[Token(Token = "0x200006F")]
public class WNafL2RMultiplier : AbstractECMultiplier
{

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000423")]
	public WNafL2RMultiplier() { }

	[Address(RVA = "0x1162460", Offset = "0x1161660", Length = "0x4EF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BigInteger), Member = "get_BitLength", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(WNafUtilities), Member = "GetWindowSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32[]), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(WNafUtilities), Member = "GenerateCompactWindowNaf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BigInteger)}, ReturnType = typeof(Int32[]))]
	[Calls(Type = typeof(Integers), Member = "NumberOfLeadingZeros", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000422")]
	protected virtual ECPoint MultiplyPositive(ECPoint p, BigInteger k) { }

}

