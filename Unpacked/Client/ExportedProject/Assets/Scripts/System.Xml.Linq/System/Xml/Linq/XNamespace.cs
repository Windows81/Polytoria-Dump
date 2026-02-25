namespace System.Xml.Linq;

[Token(Token = "0x2000014")]
public sealed class XNamespace
{
	[Token(Token = "0x400002C")]
	private static XHashtable<WeakReference> s_namespaces; //Field offset: 0x0
	[Token(Token = "0x400002D")]
	private static WeakReference s_refNone; //Field offset: 0x8
	[Token(Token = "0x400002E")]
	private static WeakReference s_refXml; //Field offset: 0x10
	[Token(Token = "0x400002F")]
	private static WeakReference s_refXmlns; //Field offset: 0x18
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000030")]
	private string _namespaceName; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000031")]
	private int _hashCode; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000032")]
	private XHashtable<XName> _names; //Field offset: 0x20

	[Token(Token = "0x1700000F")]
	public string NamespaceName
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x600006D")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000010")]
	public static XNamespace None
	{
		[Address(RVA = "0x1641EA0", Offset = "0x16410A0", Length = "0x4F")]
		[CalledBy(Type = typeof(XName), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XName))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(XNamespace), Member = "EnsureNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WeakReference&), typeof(string)}, ReturnType = typeof(XNamespace))]
		[Token(Token = "0x6000070")]
		 get { } //Length: 79
	}

	[Token(Token = "0x17000011")]
	public static XNamespace Xml
	{
		[Address(RVA = "0x1641EF0", Offset = "0x16410F0", Length = "0x51")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(XNamespace), Member = "EnsureNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WeakReference&), typeof(string)}, ReturnType = typeof(XNamespace))]
		[Token(Token = "0x6000071")]
		 get { } //Length: 81
	}

	[Token(Token = "0x17000012")]
	public static XNamespace Xmlns
	{
		[Address(RVA = "0x1641F50", Offset = "0x1641150", Length = "0x51")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(XNamespace), Member = "EnsureNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WeakReference&), typeof(string)}, ReturnType = typeof(XNamespace))]
		[Token(Token = "0x6000072")]
		 get { } //Length: 81
	}

	[Address(RVA = "0x1641DA0", Offset = "0x1640FA0", Length = "0xFF")]
	[CalledBy(Type = typeof(XNamespace), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(XNamespace))]
	[CalledBy(Type = typeof(XNamespace), Member = "EnsureNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WeakReference&), typeof(string)}, ReturnType = typeof(XNamespace))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XHashtable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Linq.XHashtable`1<TValue>+ExtractKeyDelegate<TValue>", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600006C")]
	internal XNamespace(string namespaceName) { }

	[Address(RVA = "0x16415A0", Offset = "0x16407A0", Length = "0x101")]
	[CalledBy(Type = typeof(XNamespace), Member = "get_None", ReturnType = typeof(XNamespace))]
	[CalledBy(Type = typeof(XNamespace), Member = "get_Xml", ReturnType = typeof(XNamespace))]
	[CalledBy(Type = typeof(XNamespace), Member = "get_Xmlns", ReturnType = typeof(XNamespace))]
	[CalledBy(Type = typeof(XNamespace), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(XNamespace))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XNamespace), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WeakReference), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600007C")]
	private static XNamespace EnsureNamespace(ref WeakReference refNmsp, string namespaceName) { }

	[Address(RVA = "0x2D8A50", Offset = "0x2D7C50", Length = "0x7")]
	[CallerCount(Count = 1453)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000074")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xE66C30", Offset = "0xE65E30", Length = "0x17")]
	[CallerCount(Count = 30)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600007A")]
	private static string ExtractLocalName(XName n) { }

	[Address(RVA = "0x16416B0", Offset = "0x16408B0", Length = "0x74")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600007B")]
	private static string ExtractNamespace(WeakReference r) { }

	[Address(RVA = "0x1641D30", Offset = "0x1640F30", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XNamespace), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(XNamespace))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000073")]
	public static XNamespace Get(string namespaceName) { }

	[Address(RVA = "0x1641950", Offset = "0x1640B50", Length = "0x3D9")]
	[CalledBy(Type = typeof(ElementWriter), Member = "PushAncestors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ElementWriter), Member = "PushElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XName), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XName))]
	[CalledBy(Type = typeof(XNamespace), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XNamespace))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(XNamespace), Member = "EnsureNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WeakReference&), typeof(string)}, ReturnType = typeof(XNamespace))]
	[Calls(Type = typeof(XHashtable`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = "TValue")]
	[Calls(Type = typeof(WeakReference), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XNamespace), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XHashtable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Linq.XHashtable`1<TValue>+ExtractKeyDelegate<TValue>", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XHashtable`1), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "CompareOrdinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000079")]
	internal static XNamespace Get(string namespaceName, int index, int count) { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x600006D")]
	public string get_NamespaceName() { }

	[Address(RVA = "0x1641EA0", Offset = "0x16410A0", Length = "0x4F")]
	[CalledBy(Type = typeof(XName), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XName))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XNamespace), Member = "EnsureNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WeakReference&), typeof(string)}, ReturnType = typeof(XNamespace))]
	[Token(Token = "0x6000070")]
	public static XNamespace get_None() { }

	[Address(RVA = "0x1641EF0", Offset = "0x16410F0", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XNamespace), Member = "EnsureNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WeakReference&), typeof(string)}, ReturnType = typeof(XNamespace))]
	[Token(Token = "0x6000071")]
	public static XNamespace get_Xml() { }

	[Address(RVA = "0x1641F50", Offset = "0x1641150", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XNamespace), Member = "EnsureNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WeakReference&), typeof(string)}, ReturnType = typeof(XNamespace))]
	[Token(Token = "0x6000072")]
	public static XNamespace get_Xmlns() { }

	[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000075")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x16418D0", Offset = "0x1640AD0", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XNamespace), Member = "GetName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(XName))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600006E")]
	public XName GetName(string localName) { }

	[Address(RVA = "0x1641730", Offset = "0x1640930", Length = "0x198")]
	[CalledBy(Type = typeof(XName), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XName))]
	[CalledBy(Type = typeof(XNamespace), Member = "GetName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XName))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XHashtable`1), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XmlConvert), Member = "VerifyNCName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XHashtable`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = "TValue")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000078")]
	internal XName GetName(string localName, int index, int count) { }

	[Address(RVA = "0x2D8A50", Offset = "0x2D7C50", Length = "0x7")]
	[CallerCount(Count = 1453)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000076")]
	public static bool op_Equality(XNamespace left, XNamespace right) { }

	[Address(RVA = "0x38DBD0", Offset = "0x38CDD0", Length = "0x7")]
	[CallerCount(Count = 330)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000077")]
	public static bool op_Inequality(XNamespace left, XNamespace right) { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x600006F")]
	public virtual string ToString() { }

}

