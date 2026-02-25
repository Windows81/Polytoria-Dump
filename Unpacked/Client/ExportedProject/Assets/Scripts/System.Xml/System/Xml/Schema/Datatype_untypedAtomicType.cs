namespace System.Xml.Schema;

[Token(Token = "0x20000EE")]
internal class Datatype_untypedAtomicType : Datatype_anyAtomicType
{

	[Token(Token = "0x17000228")]
	internal virtual XmlSchemaWhiteSpace BuiltInWhitespaceFacet
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x600091F")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x17000229")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x14A0B70", Offset = "0x149FD70", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000920")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x16A9B30", Offset = "0x16A8D30", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Datatype_anyAtomicType), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000921")]
	public Datatype_untypedAtomicType() { }

	[Address(RVA = "0x16A9AE0", Offset = "0x16A8CE0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600091E")]
	internal virtual XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x600091F")]
	internal virtual XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	[Address(RVA = "0x14A0B70", Offset = "0x149FD70", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000920")]
	public virtual XmlTypeCode get_TypeCode() { }

}

