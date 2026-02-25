namespace System.Xml.Schema;

[Token(Token = "0x2000152")]
public class XmlSchemaException : SystemException
{
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40005E6")]
	private string res; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40005E7")]
	private String[] args; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40005E8")]
	private string sourceUri; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40005E9")]
	private int lineNumber; //Field offset: 0xA8
	[FieldOffset(Offset = "0xAC")]
	[Token(Token = "0x40005EA")]
	private int linePosition; //Field offset: 0xAC
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40005EB")]
	private XmlSchemaObject sourceSchemaObject; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40005EC")]
	private string message; //Field offset: 0xB8

	[Token(Token = "0x17000323")]
	public virtual string Message
	{
		[Address(RVA = "0x16D96E0", Offset = "0x16D88E0", Length = "0x19")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Exception), Member = "get_Message", ReturnType = typeof(string))]
		[Token(Token = "0x6000B5C")]
		 get { } //Length: 25
	}

	[Address(RVA = "0x16D8EC0", Offset = "0x16D80C0", Length = "0x440")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(SerializationInfo), Member = "GetEnumerator", ReturnType = typeof(SerializationInfoEnumerator))]
	[Calls(Type = typeof(SerializationInfoEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SerializationInfoEnumerator), Member = "get_Current", ReturnType = typeof(SerializationEntry))]
	[Calls(Type = typeof(XmlSchemaException), Member = "CreateMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000B52")]
	protected XmlSchemaException(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x16D93E0", Offset = "0x16D85E0", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000B54")]
	public XmlSchemaException() { }

	[Address(RVA = "0x16D95C0", Offset = "0x16D87C0", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000B55")]
	public XmlSchemaException(string message) { }

	[Address(RVA = "0x16D9410", Offset = "0x16D8610", Length = "0x1C")]
	[CalledBy(Type = typeof(Datatype_doubleXdr), Member = "ParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(Datatype_floatXdr), Member = "ParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(Datatype_QNameXdr), Member = "ParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(Datatype_char), Member = "ParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(Datatype_fixed), Member = "ParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(Datatype_uuid), Member = "ParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000B56")]
	public XmlSchemaException(string message, Exception innerException) { }

	[Address(RVA = "0x16D95E0", Offset = "0x16D87E0", Length = "0xF1")]
	[CalledBy(Type = typeof(XmlSchemaException), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(string), typeof(int), typeof(int), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000B57")]
	public XmlSchemaException(string message, Exception innerException, int lineNumber, int linePosition) { }

	[Address(RVA = "0x16D9430", Offset = "0x16D8630", Length = "0xB2")]
	[CallerCount(Count = 33)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(string), typeof(int), typeof(int), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000B58")]
	internal XmlSchemaException(string res, string arg) { }

	[Address(RVA = "0x16D9310", Offset = "0x16D8510", Length = "0xCF")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSeverityType), typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef), typeof(SchemaElementDecl), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(XmlSeverityType), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSeverityType), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(string), typeof(int), typeof(int), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000B59")]
	internal XmlSchemaException(string res, string arg, string sourceUri, int lineNumber, int linePosition) { }

	[Address(RVA = "0x16D94F0", Offset = "0x16D86F0", Length = "0xCA")]
	[CalledBy(Type = typeof(DatatypeImplementation), Member = "ParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XmlSchemaException), Member = "CreateMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000B5A")]
	internal XmlSchemaException(string res, String[] args, Exception innerException, string sourceUri, int lineNumber, int linePosition, XmlSchemaObject source) { }

	[Address(RVA = "0x16D8D20", Offset = "0x16D7F20", Length = "0x49")]
	[CalledBy(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(string), typeof(int), typeof(int), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000B5B")]
	internal static string CreateMessage(string res, String[] args) { }

	[Address(RVA = "0x16D96E0", Offset = "0x16D88E0", Length = "0x19")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Exception), Member = "get_Message", ReturnType = typeof(string))]
	[Token(Token = "0x6000B5C")]
	public virtual string get_Message() { }

	[Address(RVA = "0x16D8D70", Offset = "0x16D7F70", Length = "0x14A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Exception), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B53")]
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

