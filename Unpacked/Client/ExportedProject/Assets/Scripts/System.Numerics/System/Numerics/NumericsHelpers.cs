namespace System.Numerics;

[Token(Token = "0x2000006")]
internal static class NumericsHelpers
{

	[Address(RVA = "0x162A130", Offset = "0x1629330", Length = "0xC")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600002C")]
	public static uint Abs(int a) { }

	[Address(RVA = "0x162A140", Offset = "0x1629340", Length = "0xD")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600002D")]
	public static uint CombineHash(uint u1, uint u2) { }

	[Address(RVA = "0x162A140", Offset = "0x1629340", Length = "0xD")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600002E")]
	public static int CombineHash(int n1, int n2) { }

	[Address(RVA = "0x162A150", Offset = "0x1629350", Length = "0x91")]
	[CalledBy(Type = typeof(BigInteger), Member = "op_RightShift", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(int)}, ReturnType = typeof(BigInteger))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600002A")]
	public static void DangerousMakeTwosComplement(UInt32[] d) { }

	[Address(RVA = "0x162A1F0", Offset = "0x16293F0", Length = "0xC")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600002B")]
	public static ulong MakeUlong(uint uHi, uint uLo) { }

}

