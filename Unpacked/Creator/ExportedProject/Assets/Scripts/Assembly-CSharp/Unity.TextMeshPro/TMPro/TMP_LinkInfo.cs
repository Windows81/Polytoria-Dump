namespace TMPro;

[Token(Token = "0x2000023")]
public struct TMP_LinkInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000CD")]
	public TMP_Text textComponent; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000CE")]
	public int hashCode; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40000CF")]
	public int linkIdFirstCharacterIndex; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000D0")]
	public int linkIdLength; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40000D1")]
	public int linkTextfirstCharacterIndex; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000D2")]
	public int linkTextLength; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000D3")]
	internal Char[] linkID; //Field offset: 0x20

	[Address(RVA = "0x189DC40", Offset = "0x189CE40", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_LinkInfo), Member = "GetLinkID", ReturnType = typeof(string))]
	[Token(Token = "0x6000140")]
	public string GetLink() { }

	[Address(RVA = "0x189DAC0", Offset = "0x189CCC0", Length = "0x94")]
	[CalledBy(Type = typeof(TMP_LinkInfo), Member = "GetLink", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000141")]
	public string GetLinkID() { }

	[Address(RVA = "0x189DB60", Offset = "0x189CD60", Length = "0xD6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600013F")]
	public string GetLinkText() { }

	[Address(RVA = "0x189DC50", Offset = "0x189CE50", Length = "0xD6")]
	[CalledBy(Type = typeof(TMP_Text), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600013E")]
	internal void SetLinkID(Char[] text, int startIndex, int length) { }

}

