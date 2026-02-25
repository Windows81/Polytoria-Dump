namespace System.Xml.Serialization;

[AttributeUsage(10624, AllowMultiple = True)]
[Token(Token = "0x20000C7")]
public class XmlElementAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400045E")]
	private string elementName; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400045F")]
	private Type type; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000460")]
	private int order; //Field offset: 0x20

	[Address(RVA = "0x16B7610", Offset = "0x16B6810", Length = "0x55")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600086C")]
	public XmlElementAttribute(string elementName, Type type) { }

}

