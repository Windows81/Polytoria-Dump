namespace System.Numerics.Hashing;

[Token(Token = "0x200052E")]
internal static class HashHelpers
{
	[Token(Token = "0x40014EE")]
	public static readonly int RandomSeed; //Field offset: 0x0

	[Address(RVA = "0x13E2D70", Offset = "0x13E1F70", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Random), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002540")]
	private static HashHelpers() { }

	[Address(RVA = "0x13E2D50", Offset = "0x13E1F50", Length = "0x14")]
	[CalledBy(Type = typeof(ArraySegment`1), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ValueTuple), Member = "CombineHashCodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ValueTuple), Member = "CombineHashCodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ValueTuple), Member = "CombineHashCodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ValueTuple), Member = "CombineHashCodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ValueTuple), Member = "CombineHashCodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ValueTuple), Member = "CombineHashCodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ValueTuple), Member = "CombineHashCodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Vector`1), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 113)]
	[Token(Token = "0x600253F")]
	public static int Combine(int h1, int h2) { }

}

