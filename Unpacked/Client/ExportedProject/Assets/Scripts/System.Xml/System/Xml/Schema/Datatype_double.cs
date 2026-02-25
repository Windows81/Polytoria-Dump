namespace System.Xml.Schema;

[Token(Token = "0x20000F2")]
internal class Datatype_double : Datatype_anySimpleType
{
	[Token(Token = "0x400052C")]
	private static readonly Type atomicValueType; //Field offset: 0x0
	[Token(Token = "0x400052D")]
	private static readonly Type listValueType; //Field offset: 0x8

	[Token(Token = "0x1700023C")]
	internal virtual XmlSchemaWhiteSpace BuiltInWhitespaceFacet
	{
		[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000942")]
		internal get { } //Length: 6
	}

	[Token(Token = "0x17000238")]
	internal virtual FacetsChecker FacetsChecker
	{
		[Address(RVA = "0x16A5870", Offset = "0x16A4A70", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x600093E")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x1700023B")]
	internal virtual Type ListValueType
	{
		[Address(RVA = "0x16A58C0", Offset = "0x16A4AC0", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000941")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x17000239")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x7C8170", Offset = "0x7C7370", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600093F")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700023A")]
	public virtual Type ValueType
	{
		[Address(RVA = "0x16A5910", Offset = "0x16A4B10", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000940")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x16A5730", Offset = "0x16A4930", Length = "0xBB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000946")]
	private static Datatype_double() { }

	[Address(RVA = "0x16A57F0", Offset = "0x16A49F0", Length = "0x7A")]
	[CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_doubleXdr), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000945")]
	public Datatype_double() { }

	[Address(RVA = "0x16A5540", Offset = "0x16A4740", Length = "0x58")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(double), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6000943")]
	internal virtual int Compare(object value1, object value2) { }

	[Address(RVA = "0x16A55A0", Offset = "0x16A47A0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlNumeric2Converter), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType)}, ReturnType = typeof(XmlValueConverter))]
	[DeduplicatedMethod]
	[Token(Token = "0x600093D")]
	internal virtual XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000942")]
	internal virtual XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	[Address(RVA = "0x16A5870", Offset = "0x16A4A70", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600093E")]
	internal virtual FacetsChecker get_FacetsChecker() { }

	[Address(RVA = "0x16A58C0", Offset = "0x16A4AC0", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000941")]
	internal virtual Type get_ListValueType() { }

	[Address(RVA = "0x7C8170", Offset = "0x7C7370", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600093F")]
	public virtual XmlTypeCode get_TypeCode() { }

	[Address(RVA = "0x16A5910", Offset = "0x16A4B10", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000940")]
	public virtual Type get_ValueType() { }

	[Address(RVA = "0x16A55B0", Offset = "0x16A47B0", Length = "0x175")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XmlConvert), Member = "TryToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Double&)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000944")]
	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

