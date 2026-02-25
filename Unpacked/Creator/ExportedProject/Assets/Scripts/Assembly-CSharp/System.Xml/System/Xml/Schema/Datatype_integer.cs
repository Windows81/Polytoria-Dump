namespace System.Xml.Schema;

[Token(Token = "0x2000114")]
internal class Datatype_integer : Datatype_decimal
{

	[Token(Token = "0x17000281")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x3CE170", Offset = "0x3CD370", Length = "0x6")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x60009CD")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x16A7380", Offset = "0x16A6580", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Datatype_decimal), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60009CF")]
	public Datatype_integer() { }

	[Address(RVA = "0x3CE170", Offset = "0x3CD370", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009CD")]
	public virtual XmlTypeCode get_TypeCode() { }

	[Address(RVA = "0x16A7220", Offset = "0x16A6420", Length = "0x15D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XmlConvert), Member = "TryToInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Decimal&)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x60009CE")]
	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

