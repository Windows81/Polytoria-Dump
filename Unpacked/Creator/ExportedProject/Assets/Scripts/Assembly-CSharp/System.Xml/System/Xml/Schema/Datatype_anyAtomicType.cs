namespace System.Xml.Schema;

[Token(Token = "0x20000ED")]
internal class Datatype_anyAtomicType : Datatype_anySimpleType
{

	[Token(Token = "0x17000226")]
	internal virtual XmlSchemaWhiteSpace BuiltInWhitespaceFacet
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x600091B")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x17000227")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x14CBAC0", Offset = "0x14CACC0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600091C")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x16A2900", Offset = "0x16A1B00", Length = "0x7A")]
	[CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_untypedAtomicType), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600091D")]
	public Datatype_anyAtomicType() { }

	[Address(RVA = "0x16A28B0", Offset = "0x16A1AB0", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600091A")]
	internal virtual XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x600091B")]
	internal virtual XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	[Address(RVA = "0x14CBAC0", Offset = "0x14CACC0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600091C")]
	public virtual XmlTypeCode get_TypeCode() { }

}

