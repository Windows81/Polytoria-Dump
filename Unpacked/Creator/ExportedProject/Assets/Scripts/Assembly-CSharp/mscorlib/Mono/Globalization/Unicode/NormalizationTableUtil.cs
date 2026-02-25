namespace Mono.Globalization.Unicode;

[Token(Token = "0x2000057")]
internal class NormalizationTableUtil
{
	[Token(Token = "0x4000182")]
	public static readonly CodePointIndexer Prop; //Field offset: 0x0
	[Token(Token = "0x4000183")]
	public static readonly CodePointIndexer Map; //Field offset: 0x8
	[Token(Token = "0x4000184")]
	public static readonly CodePointIndexer Combining; //Field offset: 0x10
	[Token(Token = "0x4000185")]
	public static readonly CodePointIndexer Composite; //Field offset: 0x18
	[Token(Token = "0x4000186")]
	public static readonly CodePointIndexer Helper; //Field offset: 0x20

	[Address(RVA = "0x12DCDA0", Offset = "0x12DBFA0", Length = "0x419")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CodePointIndexer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60000DA")]
	private static NormalizationTableUtil() { }

	[Address(RVA = "0x12DCCC0", Offset = "0x12DBEC0", Length = "0x67")]
	[CalledBy(Type = typeof(Normalization), Member = "CharMapIdx", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Normalization), Member = "GetCanonical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CodePointIndexer), Member = "ToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000DC")]
	public static int MapIdx(int cp) { }

	[Address(RVA = "0x12DCD30", Offset = "0x12DBF30", Length = "0x66")]
	[CalledBy(Type = typeof(Normalization), Member = "PropValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(uint))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CodePointIndexer), Member = "ToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000DB")]
	public static int PropIdx(int cp) { }

}

