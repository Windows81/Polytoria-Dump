namespace System.Xml.Linq;

[Token(Token = "0x2000007")]
public class XDocument : XContainer
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000008")]
	private XDeclaration _declaration; //Field offset: 0x30

	[Token(Token = "0x17000007")]
	public virtual XmlNodeType NodeType
	{
		[Address(RVA = "0x149FBE0", Offset = "0x149EDE0", Length = "0x6")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000023")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000008")]
	public XElement Root
	{
		[Address(RVA = "0x1640020", Offset = "0x163F220", Length = "0x39")]
		[CalledBy(Type = "Polytoria.Controllers.ScriptingAPIDumper", Member = "DumpAPI", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(XDocument), Member = "GetFirstNode", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Token(Token = "0x6000024")]
		 get { } //Length: 57
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000020")]
	public XDocument() { }

	[Address(RVA = "0x163FFF0", Offset = "0x163F1F0", Length = "0x2F")]
	[CalledBy(Type = "Polytoria.Controllers.ScriptingAPIDumper", Member = "DumpAPI", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XContainer), Member = "AddContentSkipNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000021")]
	public XDocument(Object[] content) { }

	[Address(RVA = "0x163FF20", Offset = "0x163F120", Length = "0xC0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XContainer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XContainer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000022")]
	public XDocument(XDocument other) { }

	[Address(RVA = "0x163F5C0", Offset = "0x163E7C0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000029")]
	internal virtual void AddAttribute(XAttribute a) { }

	[Address(RVA = "0x163F570", Offset = "0x163E770", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600002A")]
	internal virtual void AddAttributeSkipNotify(XAttribute a) { }

	[Address(RVA = "0x163F610", Offset = "0x163E810", Length = "0xEB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XContainer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XContainer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600002B")]
	internal virtual XNode CloneNode() { }

	[Address(RVA = "0x149FBE0", Offset = "0x149EDE0", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000023")]
	public virtual XmlNodeType get_NodeType() { }

	[Address(RVA = "0x1640020", Offset = "0x163F220", Length = "0x39")]
	[CalledBy(Type = "Polytoria.Controllers.ScriptingAPIDumper", Member = "DumpAPI", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XDocument), Member = "GetFirstNode", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Token(Token = "0x6000024")]
	public XElement get_Root() { }

	[Address(RVA = "0x7D2D80", Offset = "0x7D1F80", Length = "0xCE")]
	[CalledBy(Type = typeof(XDocument), Member = "get_Root", ReturnType = typeof(XElement))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600002C")]
	private T GetFirstNode() { }

	[Address(RVA = "0x163F700", Offset = "0x163E900", Length = "0x72")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600002D")]
	internal static bool IsWhitespace(string s) { }

	[Address(RVA = "0x163F780", Offset = "0x163E980", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000025")]
	public void Save(XmlWriter writer) { }

	[Address(RVA = "0x163F960", Offset = "0x163EB60", Length = "0x32")]
	[CalledBy(Type = "Polytoria.Controllers.ScriptingAPIDumper", Member = "DumpAPI", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XObject), Member = "GetSaveOptionsFromAnnotations", ReturnType = typeof(SaveOptions))]
	[Calls(Type = typeof(XDocument), Member = "Save", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SaveOptions)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000026")]
	public void Save(string fileName) { }

	[Address(RVA = "0x163F7A0", Offset = "0x163E9A0", Length = "0x1B3")]
	[CalledBy(Type = typeof(XDocument), Member = "Save", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlWriterSettings), Member = "set_NamespaceHandling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NamespaceHandling)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlWriterSettings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlWriterSettings), Member = "set_Indent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(XmlWriterSettings), Member = "set_Encoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlWriter), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlWriterSettings)}, ReturnType = typeof(XmlWriter))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000027")]
	public void Save(string fileName, SaveOptions options) { }

	[Address(RVA = "0x163F9A0", Offset = "0x163EBA0", Length = "0x139")]
	[CalledBy(Type = typeof(XDocument), Member = "ValidateNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XNode), typeof(XNode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600002F")]
	private void ValidateDocument(XNode previous, XmlNodeType allowBefore, XmlNodeType allowAfter) { }

	[Address(RVA = "0x163FAE0", Offset = "0x163ECE0", Length = "0x22A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XDocument), Member = "ValidateDocument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XNode), typeof(XmlNodeType), typeof(XmlNodeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600002E")]
	internal virtual void ValidateNode(XNode node, XNode previous) { }

	[Address(RVA = "0x163FD10", Offset = "0x163EF10", Length = "0xB2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000030")]
	internal virtual void ValidateString(string s) { }

	[Address(RVA = "0x163FDD0", Offset = "0x163EFD0", Length = "0x146")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XContainer), Member = "WriteContentTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000028")]
	public virtual void WriteTo(XmlWriter writer) { }

}

