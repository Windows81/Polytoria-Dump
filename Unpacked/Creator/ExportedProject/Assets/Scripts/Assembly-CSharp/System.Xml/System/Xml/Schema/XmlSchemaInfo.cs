namespace System.Xml.Schema;

[Token(Token = "0x2000155")]
public class XmlSchemaInfo : IXmlSchemaInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005ED")]
	private bool isDefault; //Field offset: 0x10
	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x40005EE")]
	private bool isNil; //Field offset: 0x11
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40005EF")]
	private XmlSchemaElement schemaElement; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40005F0")]
	private XmlSchemaAttribute schemaAttribute; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40005F1")]
	private XmlSchemaType schemaType; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40005F2")]
	private XmlSchemaSimpleType memberType; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40005F3")]
	private XmlSchemaValidity validity; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40005F4")]
	private XmlSchemaContentType contentType; //Field offset: 0x3C

	[Token(Token = "0x17000326")]
	public override bool IsDefault
	{
		[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B62")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000327")]
	public override bool IsNil
	{
		[Address(RVA = "0x3CE370", Offset = "0x3CD570", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B63")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000328")]
	public override XmlSchemaSimpleType MemberType
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B64")]
		 get { } //Length: 95
	}

	[Token(Token = "0x1700032B")]
	public override XmlSchemaAttribute SchemaAttribute
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B67")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700032A")]
	public override XmlSchemaElement SchemaElement
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B66")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000329")]
	public override XmlSchemaType SchemaType
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B65")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000325")]
	public override XmlSchemaValidity Validity
	{
		[Address(RVA = "0x3212A0", Offset = "0x3204A0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B61")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x16D9840", Offset = "0x16D8A40", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B5F")]
	public XmlSchemaInfo() { }

	[Address(RVA = "0x16D97C0", Offset = "0x16D89C0", Length = "0x79")]
	[CalledBy(Type = typeof(XmlDocument), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B60")]
	internal XmlSchemaInfo(XmlSchemaValidity validity) { }

	[Address(RVA = "0x16D9750", Offset = "0x16D8950", Length = "0x66")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000B68")]
	internal void Clear() { }

	[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B62")]
	public override bool get_IsDefault() { }

	[Address(RVA = "0x3CE370", Offset = "0x3CD570", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B63")]
	public override bool get_IsNil() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B64")]
	public override XmlSchemaSimpleType get_MemberType() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B67")]
	public override XmlSchemaAttribute get_SchemaAttribute() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B66")]
	public override XmlSchemaElement get_SchemaElement() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B65")]
	public override XmlSchemaType get_SchemaType() { }

	[Address(RVA = "0x3212A0", Offset = "0x3204A0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B61")]
	public override XmlSchemaValidity get_Validity() { }

}

