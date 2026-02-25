namespace System.Dynamic.Utils;

[Token(Token = "0x2000240")]
internal static class EmptyReadOnlyCollection
{
	[Token(Token = "0x40003D1")]
	public static readonly ReadOnlyCollection<T> Instance; //Field offset: 0x0

	[Address(RVA = "0xAE0A40", Offset = "0xADFC40", Length = "0x17E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(TrueReadOnlyCollection`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A94")]
	private static EmptyReadOnlyCollection`1() { }

}

