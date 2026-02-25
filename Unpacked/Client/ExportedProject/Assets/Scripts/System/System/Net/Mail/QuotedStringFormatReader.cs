namespace System.Net.Mail;

[Token(Token = "0x200030C")]
internal static class QuotedStringFormatReader
{

	[Address(RVA = "0x171B9A0", Offset = "0x171ABA0", Length = "0xAB")]
	[CalledBy(Type = typeof(MailAddressParser), Member = "ParseDisplayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(QuotedStringFormatReader), Member = "ReadReverseQuoted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(QuotedStringFormatReader), Member = "ReadReverseUnQuoted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60013BA")]
	private static bool IsValidQtext(bool allowUnicode, char ch) { }

	[Address(RVA = "0x171BA50", Offset = "0x171AC50", Length = "0x225")]
	[CalledBy(Type = typeof(MailAddressParser), Member = "ParseLocalPart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(bool), typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(MailAddressParser), Member = "ParseDisplayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(QuotedStringFormatReader), Member = "IsValidQtext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_class_get_static_field_data")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(QuotedPairReader), Member = "CountQuotedChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(WhitespaceReader), Member = "ReadFwsReverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60013B8")]
	internal static int ReadReverseQuoted(string data, int index, bool permitUnicode) { }

	[Address(RVA = "0x171BC80", Offset = "0x171AE80", Length = "0x188")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QuotedStringFormatReader), Member = "IsValidQtext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(QuotedPairReader), Member = "CountQuotedChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(WhitespaceReader), Member = "ReadFwsReverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60013B9")]
	internal static int ReadReverseUnQuoted(string data, int index, bool permitUnicode, bool expectCommaDelimiter) { }

}

