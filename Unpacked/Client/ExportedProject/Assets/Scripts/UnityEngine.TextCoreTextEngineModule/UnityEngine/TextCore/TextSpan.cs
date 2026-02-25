namespace UnityEngine.TextCore;

[Token(Token = "0x2000007")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
internal struct TextSpan
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400001B")]
	public int startIndex; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400001C")]
	public int length; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400001D")]
	public IntPtr fontAsset; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400001E")]
	public int fontSize; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400001F")]
	public Color32 color; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000020")]
	public FontStyles fontStyle; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000021")]
	public TextFontWeight fontWeight; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000022")]
	public int linkID; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000023")]
	public HorizontalAlignment alignment; //Field offset: 0x24

	[Address(RVA = "0x1A3B5C0", Offset = "0x1A3A7C0", Length = "0x357")]
	[CalledBy(Type = typeof(NativeTextGenerationSettings), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600000C")]
	public virtual string ToString() { }

}

