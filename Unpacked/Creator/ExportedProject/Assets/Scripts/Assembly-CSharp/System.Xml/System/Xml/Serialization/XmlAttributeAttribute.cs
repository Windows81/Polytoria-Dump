namespace System.Xml.Serialization;

[AttributeUsage(10624)]
[Token(Token = "0x20000C6")]
public class XmlAttributeAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400045D")]
	private string attributeName; //Field offset: 0x10

	[Address(RVA = "0x300C90", Offset = "0x2FFE90", Length = "0x31")]
	[CallerCount(Count = 55)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600086B")]
	public XmlAttributeAttribute(string attributeName) { }

}

