namespace System.Xml.Schema;

[Token(Token = "0x2000153")]
public abstract class XmlSchemaGroupBase : XmlSchemaParticle
{

	[Token(Token = "0x17000324")]
	[XmlIgnore]
	public abstract XmlSchemaObjectCollection Items
	{
		[Token(Token = "0x6000B5D")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x16D9700", Offset = "0x16D8900", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XmlSchemaParticle), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000B5E")]
	protected XmlSchemaGroupBase() { }

	[Token(Token = "0x6000B5D")]
	public abstract XmlSchemaObjectCollection get_Items() { }

}

