namespace System.Collections;

[Token(Token = "0x2000590")]
public struct DictionaryEntry
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40017A5")]
	private object _key; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40017A6")]
	private object _value; //Field offset: 0x8

	[Token(Token = "0x1700061B")]
	public object Key
	{
		[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
		[CallerCount(Count = 140)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002877")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700061C")]
	public object Value
	{
		[Address(RVA = "0x310530", Offset = "0x30F730", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002878")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x310490", Offset = "0x30F690", Length = "0x32")]
	[CallerCount(Count = 48)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002876")]
	public DictionaryEntry(object key, object value) { }

	[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
	[CallerCount(Count = 140)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002877")]
	public object get_Key() { }

	[Address(RVA = "0x310530", Offset = "0x30F730", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002878")]
	public object get_Value() { }

}

