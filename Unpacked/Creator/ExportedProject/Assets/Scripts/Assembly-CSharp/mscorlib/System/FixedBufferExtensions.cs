namespace System;

[Extension]
[Token(Token = "0x2000159")]
internal static class FixedBufferExtensions
{

	[Address(RVA = "0x14BA270", Offset = "0x14B9470", Length = "0xC7")]
	[CalledBy(Type = typeof(FileSystem), Member = "RemoveDirectoryRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WIN32_FIND_DATA&), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Extension]
	[Token(Token = "0x6000BF2")]
	internal static bool FixedBufferEqualsString(ReadOnlySpan<Char> span, string value) { }

	[Address(RVA = "0x14BA340", Offset = "0x14B9540", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MemoryExtensions), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlySpan`1<T>", "T"}, ReturnType = typeof(int))]
	[Extension]
	[Token(Token = "0x6000BF1")]
	internal static int GetFixedBufferStringLength(ReadOnlySpan<Char> span) { }

	[Address(RVA = "0x14BA3A0", Offset = "0x14B95A0", Length = "0xB7")]
	[CalledBy(Type = typeof(FileSystem), Member = "RemoveDirectoryRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WIN32_FIND_DATA&), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MemoryExtensions), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlySpan`1<T>", "T"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Extension]
	[Token(Token = "0x6000BF0")]
	internal static string GetStringFromFixedBuffer(ReadOnlySpan<Char> span) { }

}

