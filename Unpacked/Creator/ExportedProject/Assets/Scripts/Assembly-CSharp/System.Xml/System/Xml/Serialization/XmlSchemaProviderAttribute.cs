namespace System.Xml.Serialization;

[AttributeUsage(1036)]
[Token(Token = "0x20000CA")]
public sealed class XmlSchemaProviderAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000462")]
	private string _methodName; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000463")]
	private bool _isAny; //Field offset: 0x18

	[Token(Token = "0x170001F1")]
	public bool IsAny
	{
		[Address(RVA = "0x2FE4F0", Offset = "0x2FD6F0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000870")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x300C90", Offset = "0x2FFE90", Length = "0x31")]
	[CallerCount(Count = 55)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600086F")]
	public XmlSchemaProviderAttribute(string methodName) { }

	[Address(RVA = "0x2FE4F0", Offset = "0x2FD6F0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000870")]
	public void set_IsAny(bool value) { }

}

