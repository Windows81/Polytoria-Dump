namespace TMPro;

[Token(Token = "0x2000024")]
public struct TMP_WordInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000D4")]
	public TMP_Text textComponent; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000D5")]
	public int firstCharacterIndex; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40000D6")]
	public int lastCharacterIndex; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000D7")]
	public int characterCount; //Field offset: 0x10

	[Address(RVA = "0x189E120", Offset = "0x189D320", Length = "0xD3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000142")]
	public string GetWord() { }

}

