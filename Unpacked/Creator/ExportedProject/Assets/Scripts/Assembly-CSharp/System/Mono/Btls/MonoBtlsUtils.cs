namespace Mono.Btls;

[Token(Token = "0x200008D")]
internal static class MonoBtlsUtils
{
	[Token(Token = "0x400016F")]
	private static Byte[] emailOid; //Field offset: 0x0

	[Address(RVA = "0x173C030", Offset = "0x173B230", Length = "0x8C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600028B")]
	private static MonoBtlsUtils() { }

	[Address(RVA = "0x173B800", Offset = "0x173AA00", Length = "0x608")]
	[CalledBy(Type = typeof(MonoBtlsUtils), Member = "FormatName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Name), typeof(bool), typeof(string), typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MonoBtlsX509Name), Member = "GetEntryOid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(Marshal), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(MonoBtlsX509Name), Member = "get_Handle", ReturnType = typeof(BoringX509NameHandle))]
	[Calls(Type = typeof(MonoBtlsX509Name), Member = "GetEntryCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(MonoBtlsX509Name), Member = "GetEntryValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32&)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000289")]
	private static bool AppendEntry(StringBuilder sb, MonoBtlsX509Name name, int index, string separator, bool quotes) { }

	[Address(RVA = "0x173BE50", Offset = "0x173B050", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000288")]
	public static bool Compare(Byte[] a, Byte[] b) { }

	[Address(RVA = "0x173BEC0", Offset = "0x173B0C0", Length = "0x162")]
	[CalledBy(Type = typeof(MonoBtlsSslCtx), Member = "CopyIssuers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IntPtr), typeof(IntPtr)}, ReturnType = typeof(String[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MonoBtlsX509Name), Member = "GetEntryCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoBtlsUtils), Member = "AppendEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(MonoBtlsX509Name), typeof(int), typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600028A")]
	public static string FormatName(MonoBtlsX509Name name, bool reversed, string separator, bool quotes) { }

}

