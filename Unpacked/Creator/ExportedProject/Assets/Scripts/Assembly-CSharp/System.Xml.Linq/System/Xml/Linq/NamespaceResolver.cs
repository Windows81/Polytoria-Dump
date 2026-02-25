namespace System.Xml.Linq;

[Token(Token = "0x200000F")]
internal struct NamespaceResolver
{
	[Token(Token = "0x2000010")]
	private class NamespaceDeclaration
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400001C")]
		public string prefix; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400001D")]
		public XNamespace ns; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400001E")]
		public int scope; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400001F")]
		public NamespaceDeclaration prev; //Field offset: 0x28

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600005E")]
		public NamespaceDeclaration() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000019")]
	private int _scope; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400001A")]
	private NamespaceDeclaration _declaration; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400001B")]
	private NamespaceDeclaration _rover; //Field offset: 0x10

	[Address(RVA = "0x163C850", Offset = "0x163BA50", Length = "0xEE")]
	[CalledBy(Type = typeof(ElementWriter), Member = "PushElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600005B")]
	public void Add(string prefix, XNamespace ns) { }

	[Address(RVA = "0x163C750", Offset = "0x163B950", Length = "0xFA")]
	[CalledBy(Type = typeof(ElementWriter), Member = "PushAncestors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600005C")]
	public void AddFirst(string prefix, XNamespace ns) { }

	[Address(RVA = "0x163C940", Offset = "0x163BB40", Length = "0x100")]
	[CalledBy(Type = typeof(ElementWriter), Member = "GetPrefixOfNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XNamespace), typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600005D")]
	public string GetPrefixOfNamespace(XNamespace ns, bool allowDefaultNamespace) { }

	[Address(RVA = "0x163CA50", Offset = "0x163BC50", Length = "0x96")]
	[CalledBy(Type = typeof(ElementWriter), Member = "WriteElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ElementWriter), Member = "WriteEndElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ElementWriter), Member = "WriteFullEndElement", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600005A")]
	public void PopScope() { }

	[Address(RVA = "0x163CAF0", Offset = "0x163BCF0", Length = "0x3")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000059")]
	public void PushScope() { }

}

