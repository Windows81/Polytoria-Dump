namespace System.Security.Util;

[Token(Token = "0x20002C8")]
internal sealed class Parser
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000C25")]
	private SecurityDocument _doc; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000C26")]
	private Tokenizer _t; //Field offset: 0x18

	[Address(RVA = "0x132F6A0", Offset = "0x132E8A0", Length = "0x90")]
	[CalledBy(Type = typeof(DSA), Member = "FromXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Parser), Member = "ParseContents", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18131FD40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001725")]
	private Parser(Tokenizer t) { }

	[Address(RVA = "0x132F5A0", Offset = "0x132E7A0", Length = "0xF5")]
	[CalledBy(Type = typeof(RSA), Member = "FromXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SharedStatics), Member = "GetSharedStringMaker", ReturnType = typeof(StringMaker))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6001726")]
	internal Parser(string input) { }

	[Address(RVA = "0x132E630", Offset = "0x132D830", Length = "0x235")]
	[CalledBy(Type = typeof(Parser), Member = "ParseContents", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TokenizerStream), Member = "GetNextString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TokenizerStream), Member = "GetNextFullToken", ReturnType = typeof(short))]
	[Calls(Type = typeof(Tokenizer), Member = "GetTokens", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenizerStream), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(Tokenizer), Member = "ChangeFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001723")]
	private int DetermineFormat(TokenizerStream stream) { }

	[Address(RVA = "0x132E870", Offset = "0x132DA70", Length = "0x794")]
	[CalledBy(Type = typeof(Parser), Member = "ParseContents", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TokenizerStream), Member = "GetNextFullToken", ReturnType = typeof(short))]
	[Calls(Type = typeof(TokenizerStream), Member = "TagLastToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TokenizerStream), Member = "GetNextString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001722")]
	private void GetRequiredSizes(TokenizerStream stream, ref int index) { }

	[Address(RVA = "0x132F030", Offset = "0x132E230", Length = "0x2F")]
	[CalledBy(Type = typeof(RSA), Member = "FromXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SecurityDocument), Member = "InternalGetElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(bool)}, ReturnType = typeof(SecurityElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001721")]
	internal SecurityElement GetTopElement() { }

	[Address(RVA = "0x132F060", Offset = "0x132E260", Length = "0x539")]
	[CalledBy(Type = typeof(Parser), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tokenizer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TokenizerStream), Member = "GoToPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SecurityDocument), Member = "AddString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SecurityDocument), Member = "AppendString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TokenizerStream), Member = "GetNextString", ReturnType = typeof(string))]
	[Calls(Type = typeof(SecurityDocument), Member = "AddToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TokenizerStream), Member = "GetNextFullToken", ReturnType = typeof(short))]
	[Calls(Type = typeof(Parser), Member = "GetRequiredSizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenizerStream), typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Parser), Member = "DetermineFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenizerStream)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Tokenizer), Member = "GetTokens", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenizerStream), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x6001724")]
	private void ParseContents() { }

}

