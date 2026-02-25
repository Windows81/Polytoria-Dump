namespace System.Xml.Schema;

[Token(Token = "0x200015B")]
public class XmlSchemaSequence : XmlSchemaGroupBase
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40005FE")]
	private XmlSchemaObjectCollection items; //Field offset: 0x38

	[Token(Token = "0x1700032E")]
	[XmlElement("element", typeof(XmlSchemaElement))]
	[XmlElement("choice", typeof(XmlSchemaChoice))]
	[XmlElement("sequence", typeof(XmlSchemaSequence))]
	[XmlElement("any", typeof(XmlSchemaAny))]
	[XmlElement("group", typeof(XmlSchemaGroupRef))]
	public virtual XmlSchemaObjectCollection Items
	{
		[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B78")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x16D9E90", Offset = "0x16D9090", Length = "0x97")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XmlSchemaParticle), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000B79")]
	public XmlSchemaSequence() { }

	[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B78")]
	public virtual XmlSchemaObjectCollection get_Items() { }

}

