namespace System.IO.Enumeration;

[Token(Token = "0x2000675")]
public static class FileSystemName
{
	[Token(Token = "0x4001A41")]
	private static readonly Char[] s_wildcardChars; //Field offset: 0x0
	[Token(Token = "0x4001A42")]
	private static readonly Char[] s_simpleWildcardChars; //Field offset: 0x8

	[Address(RVA = "0x14771F0", Offset = "0x14763F0", Length = "0xF1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6002FEF")]
	private static FileSystemName() { }

	[Address(RVA = "0x1476DB0", Offset = "0x1475FB0", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FileSystemName), Member = "MatchPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6002FED")]
	public static bool MatchesSimpleExpression(ReadOnlySpan<Char> expression, ReadOnlySpan<Char> name, bool ignoreCase = true) { }

	[Address(RVA = "0x1476E40", Offset = "0x1476040", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FileSystemName), Member = "MatchPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6002FEC")]
	public static bool MatchesWin32Expression(ReadOnlySpan<Char> expression, ReadOnlySpan<Char> name, bool ignoreCase = true) { }

	[Address(RVA = "0x1476480", Offset = "0x1475680", Length = "0x925")]
	[CalledBy(Type = typeof(FileSystemEnumerableFactory), Member = "MatchesPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.ReadOnlySpan`1<System.Char>), typeof(EnumerationOptions)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FileSystemName), Member = "MatchesWin32Expression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FileSystemName), Member = "MatchesSimpleExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MemoryExtensions), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SpanHelpers), Member = "IndexOfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(int), typeof(Byte&), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SpanHelpers), Member = "IndexOfAny", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int), "T&", typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(char), Member = "ToUpperInvariant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Span`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002FEE")]
	private static bool MatchPattern(ReadOnlySpan<Char> expression, ReadOnlySpan<Char> name, bool ignoreCase, bool useExtendedWildcards) { }

	[Address(RVA = "0x1476ED0", Offset = "0x14760D0", Length = "0x31D")]
	[CalledBy(Type = typeof(FileSystemEnumerableFactory), Member = "NormalizeInputs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String&), typeof(String&), typeof(EnumerationOptions)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(ValueStringBuilder), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Char&))]
	[Calls(Type = typeof(ValueStringBuilder), Member = "GrowAndAppend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ValueStringBuilder), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6002FEB")]
	public static string TranslateWin32Expression(string expression) { }

}

