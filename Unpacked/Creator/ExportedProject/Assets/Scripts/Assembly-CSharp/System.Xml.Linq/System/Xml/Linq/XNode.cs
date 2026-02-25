namespace System.Xml.Linq;

[Token(Token = "0x2000015")]
public abstract class XNode : XObject
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000033")]
	internal XNode next; //Field offset: 0x20

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600007D")]
	internal XNode() { }

	[Token(Token = "0x6000080")]
	internal abstract XNode CloneNode() { }

	[Address(RVA = "0x1641FB0", Offset = "0x16411B0", Length = "0x2EF")]
	[CalledBy(Type = typeof(XNode), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlWriterSettings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XContainer), Member = "WriteContentTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlWriter), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(XmlWriterSettings)}, ReturnType = typeof(XmlWriter))]
	[Calls(Type = typeof(XmlWriterSettings), Member = "set_ConformanceLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConformanceLevel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlWriterSettings), Member = "set_NamespaceHandling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NamespaceHandling)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlWriterSettings), Member = "set_Indent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlWriterSettings), Member = "set_OmitXmlDeclaration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000082")]
	private string GetXmlString(SaveOptions o) { }

	[Address(RVA = "0x16422A0", Offset = "0x16414A0", Length = "0x88")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlWriterSettings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlWriterSettings), Member = "set_Indent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlWriterSettings), Member = "set_NamespaceHandling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NamespaceHandling)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000081")]
	internal static XmlWriterSettings GetXmlWriterSettings(SaveOptions o) { }

	[Address(RVA = "0x1642330", Offset = "0x1641530", Length = "0x22")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XObject), Member = "GetSaveOptionsFromAnnotations", ReturnType = typeof(SaveOptions))]
	[Calls(Type = typeof(XNode), Member = "GetXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SaveOptions)}, ReturnType = typeof(string))]
	[Token(Token = "0x600007E")]
	public virtual string ToString() { }

	[Token(Token = "0x600007F")]
	public abstract void WriteTo(XmlWriter writer) { }

}

