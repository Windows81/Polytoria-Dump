namespace System;

[Token(Token = "0x20000CF")]
internal class UncNameHelper
{

	[Address(RVA = "0x1764DB0", Offset = "0x1763FB0", Length = "0x20B")]
	[CalledBy(Type = typeof(Uri), Member = "CheckAuthorityHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(ushort), typeof(ushort), typeof(ParsingError&), typeof(Flags&), typeof(UriParser), typeof(String&)}, ReturnType = typeof(ushort))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(char), Member = "IsLetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000448")]
	internal static bool IsValid(Char* name, ushort start, ref int returnedEnd, bool notImplicitFile) { }

	[Address(RVA = "0x1764FC0", Offset = "0x17641C0", Length = "0x17D")]
	[CalledBy(Type = typeof(Uri), Member = "CreateHostStringHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(ushort), typeof(Flags&), typeof(String&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "ToLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000447")]
	internal static string ParseCanonicalName(string str, int start, int end, ref bool loopback) { }

}

