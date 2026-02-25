namespace System.Xml.XPath;

[DebuggerDisplay("{debuggerDisplayProxy}")]
[Token(Token = "0x20000C2")]
public abstract class XPathNavigator : XPathItem, ICloneable, IXmlNamespaceResolver
{
	[Token(Token = "0x400044D")]
	internal static readonly XPathNavigatorKeyComparer comparer; //Field offset: 0x0
	[Token(Token = "0x400044E")]
	internal static readonly Char[] NodeTypeLetter; //Field offset: 0x8
	[Token(Token = "0x400044F")]
	internal static readonly Char[] UniqueIdTbl; //Field offset: 0x10
	[Token(Token = "0x4000450")]
	internal static readonly Int32[] ContentKindMasks; //Field offset: 0x18

	[Token(Token = "0x170001EB")]
	public abstract string LocalName
	{
		[Token(Token = "0x6000859")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170001EC")]
	public abstract string NamespaceURI
	{
		[Token(Token = "0x600085A")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170001E9")]
	public abstract XmlNameTable NameTable
	{
		[Token(Token = "0x6000854")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170001EA")]
	public abstract XPathNodeType NodeType
	{
		[Token(Token = "0x6000858")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170001ED")]
	public abstract string Prefix
	{
		[Token(Token = "0x600085B")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170001EF")]
	public override IXmlSchemaInfo SchemaInfo
	{
		[Address(RVA = "0x16B6750", Offset = "0x16B5950", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Token(Token = "0x6000862")]
		 get { } //Length: 57
	}

	[Token(Token = "0x170001E2")]
	public virtual object TypedValue
	{
		[Address(RVA = "0x16B6790", Offset = "0x16B5990", Length = "0x1ED")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009A30")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 7)]
		[Token(Token = "0x600084B")]
		 get { } //Length: 493
	}

	[Token(Token = "0x170001EE")]
	public override object UnderlyingObject
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x600085C")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170001E4")]
	public virtual bool ValueAsBoolean
	{
		[Address(RVA = "0x16B6980", Offset = "0x16B5B80", Length = "0x1E5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009A30")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 6)]
		[Token(Token = "0x600084D")]
		 get { } //Length: 485
	}

	[Token(Token = "0x170001E5")]
	public virtual DateTime ValueAsDateTime
	{
		[Address(RVA = "0x16B6B70", Offset = "0x16B5D70", Length = "0x1E5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009A30")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 6)]
		[Token(Token = "0x600084E")]
		 get { } //Length: 485
	}

	[Token(Token = "0x170001E6")]
	public virtual double ValueAsDouble
	{
		[Address(RVA = "0x16B6D60", Offset = "0x16B5F60", Length = "0x1E5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009A30")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 6)]
		[Token(Token = "0x600084F")]
		 get { } //Length: 485
	}

	[Token(Token = "0x170001E7")]
	public virtual int ValueAsInt
	{
		[Address(RVA = "0x16B6F50", Offset = "0x16B6150", Length = "0x1E5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009A30")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 6)]
		[Token(Token = "0x6000850")]
		 get { } //Length: 485
	}

	[Token(Token = "0x170001E8")]
	public virtual long ValueAsLong
	{
		[Address(RVA = "0x16B7140", Offset = "0x16B6340", Length = "0x1E5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009A30")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 6)]
		[Token(Token = "0x6000851")]
		 get { } //Length: 485
	}

	[Token(Token = "0x170001E3")]
	public virtual Type ValueType
	{
		[Address(RVA = "0x16B7330", Offset = "0x16B6530", Length = "0xDB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x600084C")]
		 get { } //Length: 219
	}

	[Token(Token = "0x170001E1")]
	public virtual XmlSchemaType XmlType
	{
		[Address(RVA = "0x16B7410", Offset = "0x16B6610", Length = "0x93")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600084A")]
		 get { } //Length: 147
	}

	[Address(RVA = "0x16B65A0", Offset = "0x16B57A0", Length = "0x1A5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000865")]
	private static XPathNavigator() { }

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000864")]
	protected XPathNavigator() { }

	[Token(Token = "0x6000857")]
	public abstract XPathNavigator Clone() { }

	[Token(Token = "0x6000859")]
	public abstract string get_LocalName() { }

	[Token(Token = "0x600085A")]
	public abstract string get_NamespaceURI() { }

	[Token(Token = "0x6000854")]
	public abstract XmlNameTable get_NameTable() { }

	[Token(Token = "0x6000858")]
	public abstract XPathNodeType get_NodeType() { }

	[Token(Token = "0x600085B")]
	public abstract string get_Prefix() { }

	[Address(RVA = "0x16B6750", Offset = "0x16B5950", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Token(Token = "0x6000862")]
	public override IXmlSchemaInfo get_SchemaInfo() { }

	[Address(RVA = "0x16B6790", Offset = "0x16B5990", Length = "0x1ED")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009A30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 7)]
	[Token(Token = "0x600084B")]
	public virtual object get_TypedValue() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x600085C")]
	public override object get_UnderlyingObject() { }

	[Address(RVA = "0x16B6980", Offset = "0x16B5B80", Length = "0x1E5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009A30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x600084D")]
	public virtual bool get_ValueAsBoolean() { }

	[Address(RVA = "0x16B6B70", Offset = "0x16B5D70", Length = "0x1E5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009A30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x600084E")]
	public virtual DateTime get_ValueAsDateTime() { }

	[Address(RVA = "0x16B6D60", Offset = "0x16B5F60", Length = "0x1E5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009A30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x600084F")]
	public virtual double get_ValueAsDouble() { }

	[Address(RVA = "0x16B6F50", Offset = "0x16B6150", Length = "0x1E5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009A30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x6000850")]
	public virtual int get_ValueAsInt() { }

	[Address(RVA = "0x16B7140", Offset = "0x16B6340", Length = "0x1E5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009A30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x6000851")]
	public virtual long get_ValueAsLong() { }

	[Address(RVA = "0x16B7330", Offset = "0x16B6530", Length = "0xDB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600084C")]
	public virtual Type get_ValueType() { }

	[Address(RVA = "0x16B7410", Offset = "0x16B6610", Length = "0x93")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600084A")]
	public virtual XmlSchemaType get_XmlType() { }

	[Token(Token = "0x6000861")]
	public abstract bool IsSamePosition(XPathNavigator other) { }

	[Address(RVA = "0x16B5E90", Offset = "0x16B5090", Length = "0xA")]
	[CalledBy(Type = typeof(XPathNode), Member = "get_IsText", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XPathNodeHelper), Member = "GetTextFollowing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNode[]&), typeof(Int32&), typeof(XPathNode[]), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000863")]
	internal static bool IsText(XPathNodeType type) { }

	[Address(RVA = "0x16B5EA0", Offset = "0x16B50A0", Length = "0x1B5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	[Token(Token = "0x6000855")]
	public override string LookupNamespace(string prefix) { }

	[Address(RVA = "0x16B6060", Offset = "0x16B5260", Length = "0x237")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 9)]
	[Token(Token = "0x6000856")]
	public override string LookupPrefix(string namespaceURI) { }

	[Token(Token = "0x600085E")]
	public abstract bool MoveToFirstNamespace(XPathNamespaceScope namespaceScope) { }

	[Address(RVA = "0x16B62A0", Offset = "0x16B54A0", Length = "0xA4")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x600085D")]
	public override bool MoveToNamespace(string name) { }

	[Token(Token = "0x600085F")]
	public abstract bool MoveToNextNamespace(XPathNamespaceScope namespaceScope) { }

	[Token(Token = "0x6000860")]
	public abstract bool MoveToParent() { }

	[Address(RVA = "0x123F830", Offset = "0x123EA30", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000853")]
	private override object System.ICloneable.Clone() { }

	[Address(RVA = "0x16B6350", Offset = "0x16B5550", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000849")]
	public virtual string ToString() { }

	[Address(RVA = "0x16B6370", Offset = "0x16B5570", Length = "0x225")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009A30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x6000852")]
	public virtual object ValueAs(Type returnType, IXmlNamespaceResolver nsResolver) { }

}

