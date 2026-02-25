namespace TMPro;

[Token(Token = "0x20000B1")]
internal struct MarkupElement
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000665")]
	private MarkupAttribute[] m_Attributes; //Field offset: 0x0

	[Token(Token = "0x1700019C")]
	public MarkupAttribute[] Attributes
	{
		[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
		[CallerCount(Count = 140)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006B9")]
		 get { } //Length: 4
		[Address(RVA = "0x425A70", Offset = "0x424C70", Length = "0x8")]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60006BA")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000198")]
	public int NameHashCode
	{
		[Address(RVA = "0x18DDFF0", Offset = "0x18DD1F0", Length = "0x27")]
		[CalledBy(Type = typeof(TextProcessingElement), Member = "DebuggerDisplay", ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x60006B1")]
		 get { } //Length: 39
		[Address(RVA = "0x18DE0B0", Offset = "0x18DD2B0", Length = "0x77")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x60006B2")]
		 set { } //Length: 119
	}

	[Token(Token = "0x17000199")]
	public int ValueHashCode
	{
		[Address(RVA = "0x18DE020", Offset = "0x18DD220", Length = "0x27")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x60006B3")]
		 get { } //Length: 39
		[Address(RVA = "0x18DE130", Offset = "0x18DD330", Length = "0x25")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x60006B4")]
		 set { } //Length: 37
	}

	[Token(Token = "0x1700019B")]
	public int ValueLength
	{
		[Address(RVA = "0x18DE050", Offset = "0x18DD250", Length = "0x27")]
		[CalledBy(Type = typeof(TextProcessingElement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarkupElement)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x60006B7")]
		 get { } //Length: 39
		[Address(RVA = "0x18DE160", Offset = "0x18DD360", Length = "0x25")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x60006B8")]
		 set { } //Length: 37
	}

	[Token(Token = "0x1700019A")]
	public int ValueStartIndex
	{
		[Address(RVA = "0x18DE080", Offset = "0x18DD280", Length = "0x27")]
		[CalledBy(Type = typeof(TextProcessingElement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarkupElement)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x60006B5")]
		 get { } //Length: 39
		[Address(RVA = "0x18DE190", Offset = "0x18DD390", Length = "0x25")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x60006B6")]
		 set { } //Length: 37
	}

	[Address(RVA = "0x18DDF40", Offset = "0x18DD140", Length = "0xAD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60006BB")]
	public MarkupElement(int nameHashCode, int startIndex, int length) { }

	[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
	[CallerCount(Count = 140)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006B9")]
	public MarkupAttribute[] get_Attributes() { }

	[Address(RVA = "0x18DDFF0", Offset = "0x18DD1F0", Length = "0x27")]
	[CalledBy(Type = typeof(TextProcessingElement), Member = "DebuggerDisplay", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60006B1")]
	public int get_NameHashCode() { }

	[Address(RVA = "0x18DE020", Offset = "0x18DD220", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60006B3")]
	public int get_ValueHashCode() { }

	[Address(RVA = "0x18DE050", Offset = "0x18DD250", Length = "0x27")]
	[CalledBy(Type = typeof(TextProcessingElement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarkupElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60006B7")]
	public int get_ValueLength() { }

	[Address(RVA = "0x18DE080", Offset = "0x18DD280", Length = "0x27")]
	[CalledBy(Type = typeof(TextProcessingElement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarkupElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60006B5")]
	public int get_ValueStartIndex() { }

	[Address(RVA = "0x425A70", Offset = "0x424C70", Length = "0x8")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x60006BA")]
	public void set_Attributes(MarkupAttribute[] value) { }

	[Address(RVA = "0x18DE0B0", Offset = "0x18DD2B0", Length = "0x77")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60006B2")]
	public void set_NameHashCode(int value) { }

	[Address(RVA = "0x18DE130", Offset = "0x18DD330", Length = "0x25")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60006B4")]
	public void set_ValueHashCode(int value) { }

	[Address(RVA = "0x18DE160", Offset = "0x18DD360", Length = "0x25")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60006B8")]
	public void set_ValueLength(int value) { }

	[Address(RVA = "0x18DE190", Offset = "0x18DD390", Length = "0x25")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60006B6")]
	public void set_ValueStartIndex(int value) { }

}

