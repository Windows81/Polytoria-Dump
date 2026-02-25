namespace System.Runtime.Serialization;

[IsReadOnly]
[Token(Token = "0x20003C7")]
public struct SerializationEntry
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000F12")]
	private readonly string _name; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000F13")]
	private readonly object _value; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000F14")]
	private readonly Type _type; //Field offset: 0x10

	[Token(Token = "0x1700039C")]
	public string Name
	{
		[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
		[CallerCount(Count = 140)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001CD1")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700039B")]
	public object Value
	{
		[Address(RVA = "0x310530", Offset = "0x30F730", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001CD0")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x89C9E0", Offset = "0x89BBE0", Length = "0x4F")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001CCF")]
	internal SerializationEntry(string entryName, object entryValue, Type entryType) { }

	[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
	[CallerCount(Count = 140)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001CD1")]
	public string get_Name() { }

	[Address(RVA = "0x310530", Offset = "0x30F730", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001CD0")]
	public object get_Value() { }

}

