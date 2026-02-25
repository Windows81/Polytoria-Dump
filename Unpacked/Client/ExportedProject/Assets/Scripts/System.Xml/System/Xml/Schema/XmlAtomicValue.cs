namespace System.Xml.Schema;

[Token(Token = "0x2000143")]
public sealed class XmlAtomicValue : XPathItem, ICloneable
{
	[Token(Token = "0x2000145")]
	private class NamespacePrefixForQName : IXmlNamespaceResolver
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40005C2")]
		public string prefix; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40005C3")]
		public string ns; //Field offset: 0x18

		[Address(RVA = "0x16BBB30", Offset = "0x16BAD30", Length = "0x4E")]
		[CalledBy(Type = typeof(XmlAtomicValue), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType), typeof(string), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlAtomicValue), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType), typeof(object), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000B2C")]
		public NamespacePrefixForQName(string prefix, string ns) { }

		[Address(RVA = "0x16BBAC0", Offset = "0x16BACC0", Length = "0x31")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000B2D")]
		public override string LookupNamespace(string prefix) { }

		[Address(RVA = "0x16BBB00", Offset = "0x16BAD00", Length = "0x2B")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000B2E")]
		public override string LookupPrefix(string namespaceName) { }

	}

	[Token(Token = "0x2000144")]
	private struct Union
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005BD")]
		public bool boolVal; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005BE")]
		public double dblVal; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005BF")]
		public long i64Val; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005C0")]
		public int i32Val; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005C1")]
		public DateTime dtVal; //Field offset: 0x0

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005B8")]
	private XmlSchemaType xmlType; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40005B9")]
	private object objVal; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40005BA")]
	private TypeCode clrType; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40005BB")]
	private Union unionVal; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40005BC")]
	private NamespacePrefixForQName nsPrefix; //Field offset: 0x30

	[Token(Token = "0x1700030B")]
	public virtual object TypedValue
	{
		[Address(RVA = "0x16C3220", Offset = "0x16C2420", Length = "0x205")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 11)]
		[Token(Token = "0x6000B22")]
		 get { } //Length: 517
	}

	[Token(Token = "0x17000311")]
	public virtual string Value
	{
		[Address(RVA = "0x16C39C0", Offset = "0x16C2BC0", Length = "0x131")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 6)]
		[Token(Token = "0x6000B29")]
		 get { } //Length: 305
	}

	[Token(Token = "0x1700030C")]
	public virtual bool ValueAsBoolean
	{
		[Address(RVA = "0x16C3430", Offset = "0x16C2630", Length = "0x10D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 5)]
		[Token(Token = "0x6000B23")]
		 get { } //Length: 269
	}

	[Token(Token = "0x1700030D")]
	public virtual DateTime ValueAsDateTime
	{
		[Address(RVA = "0x16C3540", Offset = "0x16C2740", Length = "0x10D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 5)]
		[Token(Token = "0x6000B24")]
		 get { } //Length: 269
	}

	[Token(Token = "0x1700030E")]
	public virtual double ValueAsDouble
	{
		[Address(RVA = "0x16C3650", Offset = "0x16C2850", Length = "0x10D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 5)]
		[Token(Token = "0x6000B25")]
		 get { } //Length: 269
	}

	[Token(Token = "0x1700030F")]
	public virtual int ValueAsInt
	{
		[Address(RVA = "0x16C3760", Offset = "0x16C2960", Length = "0x10D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 5)]
		[Token(Token = "0x6000B26")]
		 get { } //Length: 269
	}

	[Token(Token = "0x17000310")]
	public virtual long ValueAsLong
	{
		[Address(RVA = "0x16C3870", Offset = "0x16C2A70", Length = "0x10D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 5)]
		[Token(Token = "0x6000B27")]
		 get { } //Length: 269
	}

	[Token(Token = "0x1700030A")]
	public virtual Type ValueType
	{
		[Address(RVA = "0x16C3980", Offset = "0x16C2B80", Length = "0x33")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000B21")]
		 get { } //Length: 51
	}

	[Token(Token = "0x17000309")]
	public virtual XmlSchemaType XmlType
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B20")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x16C28A0", Offset = "0x16C1AA0", Length = "0x98")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B16")]
	internal XmlAtomicValue(XmlSchemaType xmlType, bool value) { }

	[Address(RVA = "0x16C2940", Offset = "0x16C1B40", Length = "0xE9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B1D")]
	internal XmlAtomicValue(XmlSchemaType xmlType, object value) { }

	[Address(RVA = "0x16C2A30", Offset = "0x16C1C30", Length = "0x230")]
	[CalledBy(Type = typeof(XmlMiscConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlMiscConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ValidateNames), Member = "ParseQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(NamespacePrefixForQName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaType), Member = "get_TypeCode", ReturnType = typeof(XmlTypeCode))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B1C")]
	internal XmlAtomicValue(XmlSchemaType xmlType, string value, IXmlNamespaceResolver nsResolver) { }

	[Address(RVA = "0x16C2FF0", Offset = "0x16C21F0", Length = "0xE9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B1B")]
	internal XmlAtomicValue(XmlSchemaType xmlType, string value) { }

	[Address(RVA = "0x16C2DB0", Offset = "0x16C1FB0", Length = "0x23B")]
	[CalledBy(Type = typeof(Datatype_List), Member = "TryParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(IXmlNamespaceResolver), typeof(Object&)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(XmlMiscConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlAnyConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(XmlSchemaType), Member = "get_TypeCode", ReturnType = typeof(XmlTypeCode))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NamespacePrefixForQName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000B1E")]
	internal XmlAtomicValue(XmlSchemaType xmlType, object value, IXmlNamespaceResolver nsResolver) { }

	[Address(RVA = "0x16C2D10", Offset = "0x16C1F10", Length = "0x96")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B19")]
	internal XmlAtomicValue(XmlSchemaType xmlType, int value) { }

	[Address(RVA = "0x16C3180", Offset = "0x16C2380", Length = "0x98")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B18")]
	internal XmlAtomicValue(XmlSchemaType xmlType, double value) { }

	[Address(RVA = "0x16C30E0", Offset = "0x16C22E0", Length = "0x97")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B17")]
	internal XmlAtomicValue(XmlSchemaType xmlType, DateTime value) { }

	[Address(RVA = "0x16C2C70", Offset = "0x16C1E70", Length = "0x97")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B1A")]
	internal XmlAtomicValue(XmlSchemaType xmlType, long value) { }

	[Address(RVA = "0x16C3220", Offset = "0x16C2420", Length = "0x205")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 11)]
	[Token(Token = "0x6000B22")]
	public virtual object get_TypedValue() { }

	[Address(RVA = "0x16C39C0", Offset = "0x16C2BC0", Length = "0x131")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x6000B29")]
	public virtual string get_Value() { }

	[Address(RVA = "0x16C3430", Offset = "0x16C2630", Length = "0x10D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x6000B23")]
	public virtual bool get_ValueAsBoolean() { }

	[Address(RVA = "0x16C3540", Offset = "0x16C2740", Length = "0x10D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x6000B24")]
	public virtual DateTime get_ValueAsDateTime() { }

	[Address(RVA = "0x16C3650", Offset = "0x16C2850", Length = "0x10D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x6000B25")]
	public virtual double get_ValueAsDouble() { }

	[Address(RVA = "0x16C3760", Offset = "0x16C2960", Length = "0x10D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x6000B26")]
	public virtual int get_ValueAsInt() { }

	[Address(RVA = "0x16C3870", Offset = "0x16C2A70", Length = "0x10D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x6000B27")]
	public virtual long get_ValueAsLong() { }

	[Address(RVA = "0x16C3980", Offset = "0x16C2B80", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000B21")]
	public virtual Type get_ValueType() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B20")]
	public virtual XmlSchemaType get_XmlType() { }

	[Address(RVA = "0x16C25D0", Offset = "0x16C17D0", Length = "0xA3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ValidateNames), Member = "ParseQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B2B")]
	private string GetPrefixFromQName(string value) { }

	[Address(RVA = "0x30E8E0", Offset = "0x30DAE0", Length = "0x4")]
	[CallerCount(Count = 2057)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B1F")]
	private override object System.ICloneable.Clone() { }

	[Address(RVA = "0x16B6350", Offset = "0x16B5550", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B2A")]
	public virtual string ToString() { }

	[Address(RVA = "0x16C2680", Offset = "0x16C1880", Length = "0x21E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x6000B28")]
	public virtual object ValueAs(Type type, IXmlNamespaceResolver nsResolver) { }

}

