namespace System.Runtime.Remoting.Metadata;

[AttributeUsage(1052)]
[ComVisible(True)]
[Token(Token = "0x200038E")]
public sealed class SoapTypeAttribute : SoapAttribute
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000E7A")]
	private bool _useAttribute; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000E7B")]
	private string _xmlElementName; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000E7C")]
	private string _xmlNamespace; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000E7D")]
	private string _xmlTypeName; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000E7E")]
	private string _xmlTypeNamespace; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000E7F")]
	private bool _isType; //Field offset: 0x50
	[FieldOffset(Offset = "0x51")]
	[Token(Token = "0x4000E80")]
	private bool _isElement; //Field offset: 0x51

	[Token(Token = "0x17000320")]
	internal bool IsInteropXmlElement
	{
		[Address(RVA = "0x3EB940", Offset = "0x3EAB40", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001B8E")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000321")]
	internal bool IsInteropXmlType
	{
		[Address(RVA = "0x3EB920", Offset = "0x3EAB20", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001B8F")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x1700031B")]
	public virtual bool UseAttribute
	{
		[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001B89")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700031C")]
	public string XmlElementName
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001B8A")]
		 get { } //Length: 95
	}

	[Token(Token = "0x1700031D")]
	public virtual string XmlNamespace
	{
		[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001B8B")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700031E")]
	public string XmlTypeName
	{
		[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001B8C")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700031F")]
	public string XmlTypeNamespace
	{
		[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001B8D")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001B88")]
	public SoapTypeAttribute() { }

	[Address(RVA = "0x3EB940", Offset = "0x3EAB40", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001B8E")]
	internal bool get_IsInteropXmlElement() { }

	[Address(RVA = "0x3EB920", Offset = "0x3EAB20", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001B8F")]
	internal bool get_IsInteropXmlType() { }

	[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001B89")]
	public virtual bool get_UseAttribute() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001B8A")]
	public string get_XmlElementName() { }

	[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001B8B")]
	public virtual string get_XmlNamespace() { }

	[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001B8C")]
	public string get_XmlTypeName() { }

	[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001B8D")]
	public string get_XmlTypeNamespace() { }

	[Address(RVA = "0x1396D00", Offset = "0x1395F00", Length = "0x23D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Assembly), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly), typeof(Assembly)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SoapServices), Member = "CodeXmlNamespaceForClrTypeNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 7)]
	[Token(Token = "0x6001B90")]
	internal virtual void SetReflectionObject(object reflectionObject) { }

}

