namespace TMPro;

[DebuggerDisplay("{DebuggerDisplay()}")]
[Token(Token = "0x20000B2")]
internal struct TextProcessingElement
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000666")]
	private TextProcessingElementType m_ElementType; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000667")]
	private int m_StartIndex; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000668")]
	private int m_Length; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000669")]
	private CharacterElement m_CharacterElement; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400066A")]
	private MarkupElement m_MarkupElement; //Field offset: 0x20

	[Token(Token = "0x170001A0")]
	public CharacterElement CharacterElement
	{
		[Address(RVA = "0x3E81B0", Offset = "0x3E73B0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006C2")]
		 get { } //Length: 11
	}

	[Token(Token = "0x1700019D")]
	public TextProcessingElementType ElementType
	{
		[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
		[CallerCount(Count = 129)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006BC")]
		 get { } //Length: 3
		[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006BD")]
		 set { } //Length: 3
	}

	[Token(Token = "0x1700019F")]
	public int Length
	{
		[Address(RVA = "0x3B9430", Offset = "0x3B8630", Length = "0x4")]
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006C0")]
		 get { } //Length: 4
		[Address(RVA = "0x3B9460", Offset = "0x3B8660", Length = "0x4")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006C1")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170001A1")]
	public MarkupElement MarkupElement
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006C3")]
		 get { } //Length: 5
		[Address(RVA = "0x18FB040", Offset = "0x18FA240", Length = "0xF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x60006C4")]
		 set { } //Length: 15
	}

	[Token(Token = "0x1700019E")]
	public int StartIndex
	{
		[Address(RVA = "0x3B87A0", Offset = "0x3B79A0", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006BE")]
		 get { } //Length: 4
		[Address(RVA = "0x3B8830", Offset = "0x3B7A30", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006BF")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170001A2")]
	public static TextProcessingElement Undefined
	{
		[Address(RVA = "0x18FB020", Offset = "0x18FA220", Length = "0x14")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006C9")]
		 get { } //Length: 20
	}

	[Address(RVA = "0x18FB000", Offset = "0x18FA200", Length = "0x18")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60006C5")]
	public TextProcessingElement(TextProcessingElementType elementType, int startIndex, int length) { }

	[Address(RVA = "0x18FAFB0", Offset = "0x18FA1B0", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CharacterElement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_TextElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60006C6")]
	public TextProcessingElement(TMP_TextElement textElement, int startIndex, int length) { }

	[Address(RVA = "0x18FAF10", Offset = "0x18FA110", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60006C7")]
	public TextProcessingElement(CharacterElement characterElement, int startIndex, int length) { }

	[Address(RVA = "0x18FAF50", Offset = "0x18FA150", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MarkupElement), Member = "get_ValueStartIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(MarkupElement), Member = "get_ValueLength", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60006C8")]
	public TextProcessingElement(MarkupElement markupElement) { }

	[Address(RVA = "0x18FAE30", Offset = "0x18FA030", Length = "0xD4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(MarkupElement), Member = "get_NameHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Token(Token = "0x60006CA")]
	private string DebuggerDisplay() { }

	[Address(RVA = "0x3E81B0", Offset = "0x3E73B0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006C2")]
	public CharacterElement get_CharacterElement() { }

	[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
	[CallerCount(Count = 129)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006BC")]
	public TextProcessingElementType get_ElementType() { }

	[Address(RVA = "0x3B9430", Offset = "0x3B8630", Length = "0x4")]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006C0")]
	public int get_Length() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006C3")]
	public MarkupElement get_MarkupElement() { }

	[Address(RVA = "0x3B87A0", Offset = "0x3B79A0", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006BE")]
	public int get_StartIndex() { }

	[Address(RVA = "0x18FB020", Offset = "0x18FA220", Length = "0x14")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006C9")]
	public static TextProcessingElement get_Undefined() { }

	[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006BD")]
	public void set_ElementType(TextProcessingElementType value) { }

	[Address(RVA = "0x3B9460", Offset = "0x3B8660", Length = "0x4")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006C1")]
	public void set_Length(int value) { }

	[Address(RVA = "0x18FB040", Offset = "0x18FA240", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60006C4")]
	public void set_MarkupElement(MarkupElement value) { }

	[Address(RVA = "0x3B8830", Offset = "0x3B7A30", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006BF")]
	public void set_StartIndex(int value) { }

}

