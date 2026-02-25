namespace System.Xml.Linq;

[Token(Token = "0x2000003")]
public class XAttribute : XObject
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000001")]
	internal XAttribute next; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000002")]
	internal XName name; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000003")]
	internal string value; //Field offset: 0x30

	[Token(Token = "0x17000001")]
	public bool IsNamespaceDeclaration
	{
		[Address(RVA = "0x163D7B0", Offset = "0x163C9B0", Length = "0x83")]
		[CalledBy(Type = typeof(XElement), Member = "GetNamespaceOfPrefixInScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XElement)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000004")]
		 get { } //Length: 131
	}

	[Token(Token = "0x17000002")]
	public XName Name
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000005")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000003")]
	public virtual XmlNodeType NodeType
	{
		[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000006")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000004")]
	public string Value
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000007")]
		 get { } //Length: 95
	}

	[Address(RVA = "0x163D600", Offset = "0x163C800", Length = "0x108")]
	[CalledBy(Type = "Polytoria.Controllers.ScriptingAPIDumper", Member = "DumpAPI", ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(XContainer), Member = "GetStringValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XAttribute), Member = "ValidateAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XName), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000002")]
	public XAttribute(XName name, object value) { }

	[Address(RVA = "0x163D710", Offset = "0x163C910", Length = "0x90")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000003")]
	public XAttribute(XAttribute other) { }

	[Address(RVA = "0x163D7B0", Offset = "0x163C9B0", Length = "0x83")]
	[CalledBy(Type = typeof(XElement), Member = "GetNamespaceOfPrefixInScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XElement)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000004")]
	public bool get_IsNamespaceDeclaration() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000005")]
	public XName get_Name() { }

	[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000006")]
	public virtual XmlNodeType get_NodeType() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000007")]
	public string get_Value() { }

	[Address(RVA = "0x163CD90", Offset = "0x163BF90", Length = "0x12E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XElement), Member = "GetPrefixOfNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XNamespace)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6000009")]
	internal string GetPrefixOfNamespace(XNamespace ns) { }

	[Address(RVA = "0x163CEC0", Offset = "0x163C0C0", Length = "0x382")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlWriterSettings), Member = "set_ConformanceLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConformanceLevel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(XmlWriter), Member = "WriteAttributeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XElement), Member = "GetPrefixOfNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XNamespace)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlWriter), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(XmlWriterSettings)}, ReturnType = typeof(XmlWriter))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(XmlWriterSettings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000008")]
	public virtual string ToString() { }

	[Address(RVA = "0x163D250", Offset = "0x163C450", Length = "0x3A4")]
	[CalledBy(Type = typeof(XAttribute), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XName), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Token(Token = "0x600000A")]
	private static void ValidateAttribute(XName name, string value) { }

}

