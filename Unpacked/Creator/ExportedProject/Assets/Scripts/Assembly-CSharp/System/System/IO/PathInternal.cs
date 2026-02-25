namespace System.IO;

[Token(Token = "0x20001DD")]
internal static class PathInternal
{
	[Token(Token = "0x400071B")]
	private static readonly bool s_isCaseSensitive; //Field offset: 0x0

	[Token(Token = "0x17000257")]
	internal static StringComparison StringComparison
	{
		[Address(RVA = "0x17CB2B0", Offset = "0x17CA4B0", Length = "0x55")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000C0E")]
		internal get { } //Length: 85
	}

	[Address(RVA = "0x17CB270", Offset = "0x17CA470", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PathInternal), Member = "GetIsCaseSensitive", ReturnType = typeof(bool))]
	[Token(Token = "0x6000C10")]
	private static PathInternal() { }

	[Address(RVA = "0x17CB2B0", Offset = "0x17CA4B0", Length = "0x55")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000C0E")]
	internal static StringComparison get_StringComparison() { }

	[Address(RVA = "0x17CB0B0", Offset = "0x17CA2B0", Length = "0x1B9")]
	[CalledBy(Type = typeof(PathInternal), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Guid), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(File), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "ToLowerInvariant", ReturnType = typeof(string))]
	[Calls(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FileMode), typeof(FileAccess), typeof(FileShare), typeof(int), typeof(FileOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Guid), Member = "NewGuid", ReturnType = typeof(Guid))]
	[Calls(Type = typeof(Path), Member = "GetTempPath", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000C0F")]
	private static bool GetIsCaseSensitive() { }

}

