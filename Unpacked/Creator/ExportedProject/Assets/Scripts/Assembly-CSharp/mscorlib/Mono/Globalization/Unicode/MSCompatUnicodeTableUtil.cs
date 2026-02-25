namespace Mono.Globalization.Unicode;

[Token(Token = "0x2000056")]
internal class MSCompatUnicodeTableUtil
{
	[Token(Token = "0x400017B")]
	public static readonly CodePointIndexer Ignorable; //Field offset: 0x0
	[Token(Token = "0x400017C")]
	public static readonly CodePointIndexer Category; //Field offset: 0x8
	[Token(Token = "0x400017D")]
	public static readonly CodePointIndexer Level1; //Field offset: 0x10
	[Token(Token = "0x400017E")]
	public static readonly CodePointIndexer Level2; //Field offset: 0x18
	[Token(Token = "0x400017F")]
	public static readonly CodePointIndexer Level3; //Field offset: 0x20
	[Token(Token = "0x4000180")]
	public static readonly CodePointIndexer CjkCHS; //Field offset: 0x28
	[Token(Token = "0x4000181")]
	public static readonly CodePointIndexer Cjk; //Field offset: 0x30

	[Address(RVA = "0x12DA610", Offset = "0x12D9810", Length = "0x5EE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CodePointIndexer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60000D9")]
	private static MSCompatUnicodeTableUtil() { }

}

