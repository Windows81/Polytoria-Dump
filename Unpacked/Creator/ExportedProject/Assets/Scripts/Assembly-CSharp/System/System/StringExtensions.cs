namespace System;

[Extension]
[Token(Token = "0x20000B7")]
internal static class StringExtensions
{

	[Address(RVA = "0x17464D0", Offset = "0x17456D0", Length = "0x145")]
	[CalledBy(Type = typeof(MailAddressParser), Member = "ParseDisplayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x6000376")]
	internal static string SubstringTrim(string value, int startIndex, int length) { }

}

