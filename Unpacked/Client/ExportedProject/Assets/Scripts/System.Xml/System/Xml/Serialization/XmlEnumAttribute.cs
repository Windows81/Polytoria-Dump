namespace System.Xml.Serialization;

[AttributeUsage(AttributeTargets::Field (256))]
[Token(Token = "0x20000C8")]
public class XmlEnumAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000461")]
	private string name; //Field offset: 0x10

	[Address(RVA = "0x300C90", Offset = "0x2FFE90", Length = "0x31")]
	[CallerCount(Count = 55)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600086D")]
	public XmlEnumAttribute(string name) { }

}

