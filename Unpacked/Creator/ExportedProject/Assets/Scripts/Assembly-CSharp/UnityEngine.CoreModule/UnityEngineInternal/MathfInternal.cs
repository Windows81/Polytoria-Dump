namespace UnityEngineInternal;

[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x2000005")]
public struct MathfInternal
{
	[Token(Token = "0x4000001")]
	public static float FloatMinNormal; //Field offset: 0x0
	[Token(Token = "0x4000002")]
	public static float FloatMinDenormal; //Field offset: 0x4
	[Token(Token = "0x4000003")]
	public static bool IsFlushToZeroEnabled; //Field offset: 0x8

	[Address(RVA = "0x1932F80", Offset = "0x1932180", Length = "0xE1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000004")]
	private static MathfInternal() { }

}

