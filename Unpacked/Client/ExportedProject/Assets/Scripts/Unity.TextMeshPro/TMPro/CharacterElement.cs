namespace TMPro;

[Token(Token = "0x20000AF")]
internal struct CharacterElement
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400065F")]
	private uint m_Unicode; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000660")]
	private TMP_TextElement m_TextElement; //Field offset: 0x8

	[Token(Token = "0x17000193")]
	public uint Unicode
	{
		[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
		[CallerCount(Count = 129)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006A6")]
		 get { } //Length: 3
		[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006A7")]
		 set { } //Length: 3
	}

	[Address(RVA = "0x18DDED0", Offset = "0x18DD0D0", Length = "0x24")]
	[CalledBy(Type = typeof(TextProcessingElement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_TextElement), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60006A8")]
	public CharacterElement(TMP_TextElement textElement) { }

	[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
	[CallerCount(Count = 129)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006A6")]
	public uint get_Unicode() { }

	[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006A7")]
	public void set_Unicode(uint value) { }

}

