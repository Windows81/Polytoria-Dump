namespace System.Net;

[Token(Token = "0x2000264")]
internal struct HeaderVariantInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009F4")]
	private string m_name; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40009F5")]
	private CookieVariant m_variant; //Field offset: 0x8

	[Token(Token = "0x1700031F")]
	internal string Name
	{
		[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
		[CallerCount(Count = 140)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F48")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x17000320")]
	internal CookieVariant Variant
	{
		[Address(RVA = "0x3B9430", Offset = "0x3B8630", Length = "0x4")]
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F49")]
		internal get { } //Length: 4
	}

	[Address(RVA = "0xC89AC0", Offset = "0xC88CC0", Length = "0x26")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F47")]
	internal HeaderVariantInfo(string name, CookieVariant variant) { }

	[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
	[CallerCount(Count = 140)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F48")]
	internal string get_Name() { }

	[Address(RVA = "0x3B9430", Offset = "0x3B8630", Length = "0x4")]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F49")]
	internal CookieVariant get_Variant() { }

}

