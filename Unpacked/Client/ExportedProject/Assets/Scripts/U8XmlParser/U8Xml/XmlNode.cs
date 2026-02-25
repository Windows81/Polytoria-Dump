namespace U8Xml;

[DebuggerDisplay("{DebugView(),nq}")]
[IsReadOnly]
[Token(Token = "0x2000014")]
public struct XmlNode : IEquatable<XmlNode>, IReference
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000014")]
	private readonly IntPtr _node; //Field offset: 0x0

	[Token(Token = "0x17000014")]
	public XmlAttributeList Attributes
	{
		[Address(RVA = "0x180CBB0", Offset = "0x180BDB0", Length = "0x1C")]
		[CalledBy(Type = "Polytoria.Datamodel.Proxies.Vector3ValueProxy", Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Vector3"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x6000055")]
		 get { } //Length: 28
	}

	[Token(Token = "0x17000015")]
	public XmlNodeList Children
	{
		[Address(RVA = "0x180CBD0", Offset = "0x180BDD0", Length = "0x73")]
		[CalledBy(Type = "Polytoria.Datamodel.Proxies.Vector3ValueProxy", Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Vector3"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "LoadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), "Polytoria.Datamodel.Instance"}, ReturnType = "Polytoria.Datamodel.Instance")]
		[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "HandleXmlNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeList), "Polytoria.Datamodel.Instance"}, ReturnType = "Polytoria.Datamodel.Instance")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000056")]
		 get { } //Length: 115
	}

	[Token(Token = "0x17000013")]
	public RawString InnerText
	{
		[Address(RVA = "0x180CC50", Offset = "0x180BE50", Length = "0x30")]
		[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "HandleXmlNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeList), "Polytoria.Datamodel.Instance"}, ReturnType = "Polytoria.Datamodel.Instance")]
		[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "XmlConvertVector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = "UnityEngine.Vector3")]
		[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "XmlConvertVector2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = "UnityEngine.Vector2")]
		[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "XmlConvertColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = "UnityEngine.Color")]
		[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "XmlConvertNumberRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = "Polytoria.Types.NumberRange")]
		[CallerCount(Count = 18)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000054")]
		 get { } //Length: 48
	}

	[Token(Token = "0x17000011")]
	public override bool IsNull
	{
		[Address(RVA = "0x9E2EA0", Offset = "0x9E20A0", Length = "0x8")]
		[CallerCount(Count = 8)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000052")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000012")]
	public RawString Name
	{
		[Address(RVA = "0x180CC90", Offset = "0x180BE90", Length = "0x30")]
		[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "HandleXmlNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeList), "Polytoria.Datamodel.Instance"}, ReturnType = "Polytoria.Datamodel.Instance")]
		[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "XmlConvertColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = "UnityEngine.Color")]
		[CalledBy(Type = typeof(XmlNodeEnumerableExtension), Member = "FindOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TNodes"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TNodes", typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(U8Xml.Option`1<U8Xml.XmlNode>))]
		[CallerCount(Count = 19)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000053")]
		 get { } //Length: 48
	}

	[Address(RVA = "0x9E2BC0", Offset = "0x9E1DC0", Length = "0x1F")]
	[CallerCount(Count = 11)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000057")]
	internal XmlNode(XmlNode_* node) { }

	[Address(RVA = "0x180C5D0", Offset = "0x180B7D0", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[NullableContext(2)]
	[Token(Token = "0x600005C")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x14A0AF0", Offset = "0x149FCF0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600005D")]
	public override bool Equals(XmlNode other) { }

	[Address(RVA = "0x180C660", Offset = "0x180B860", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001DF60")]
	[CallsDeduplicatedMethods(Count = 2)]
	[NullableContext(1)]
	[Token(Token = "0x600005B")]
	public XmlAttribute FindAttribute(string name) { }

	[Address(RVA = "0x180C810", Offset = "0x180BA10", Length = "0xDE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1804B6B90")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[NullableContext(1)]
	[Token(Token = "0x6000059")]
	public XmlNode FindChild(string name) { }

	[Address(RVA = "0x180C780", Offset = "0x180B980", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1804B6B90")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x600005A")]
	public XmlNode FindChild(ReadOnlySpan<Char> name) { }

	[Address(RVA = "0x180C6C0", Offset = "0x180B8C0", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlNodeEnumerableExtension), Member = "FindOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TNodes"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TNodes", typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(U8Xml.Option`1<U8Xml.XmlNode>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000058")]
	public Option<XmlNode> FindChildOrDefault(ReadOnlySpan<Char> name) { }

	[Address(RVA = "0x180CBB0", Offset = "0x180BDB0", Length = "0x1C")]
	[CalledBy(Type = "Polytoria.Datamodel.Proxies.Vector3ValueProxy", Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Vector3"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000055")]
	public XmlAttributeList get_Attributes() { }

	[Address(RVA = "0x180CBD0", Offset = "0x180BDD0", Length = "0x73")]
	[CalledBy(Type = "Polytoria.Datamodel.Proxies.Vector3ValueProxy", Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Vector3"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "LoadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), "Polytoria.Datamodel.Instance"}, ReturnType = "Polytoria.Datamodel.Instance")]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "HandleXmlNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeList), "Polytoria.Datamodel.Instance"}, ReturnType = "Polytoria.Datamodel.Instance")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000056")]
	public XmlNodeList get_Children() { }

	[Address(RVA = "0x180CC50", Offset = "0x180BE50", Length = "0x30")]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "HandleXmlNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeList), "Polytoria.Datamodel.Instance"}, ReturnType = "Polytoria.Datamodel.Instance")]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "XmlConvertVector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = "UnityEngine.Vector3")]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "XmlConvertVector2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = "UnityEngine.Vector2")]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "XmlConvertColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = "UnityEngine.Color")]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "XmlConvertNumberRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = "Polytoria.Types.NumberRange")]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000054")]
	public RawString get_InnerText() { }

	[Address(RVA = "0x9E2EA0", Offset = "0x9E20A0", Length = "0x8")]
	[CallerCount(Count = 8)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000052")]
	public override bool get_IsNull() { }

	[Address(RVA = "0x180CC90", Offset = "0x180BE90", Length = "0x30")]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "HandleXmlNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeList), "Polytoria.Datamodel.Instance"}, ReturnType = "Polytoria.Datamodel.Instance")]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "XmlConvertColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = "UnityEngine.Color")]
	[CalledBy(Type = typeof(XmlNodeEnumerableExtension), Member = "FindOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TNodes"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TNodes", typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(U8Xml.Option`1<U8Xml.XmlNode>))]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000053")]
	public RawString get_Name() { }

	[Address(RVA = "0x12DD960", Offset = "0x12DCB60", Length = "0x7")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600005E")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x180C8F0", Offset = "0x180BAF0", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RawString), Member = "ToString", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[NullableContext(1)]
	[Token(Token = "0x600005F")]
	public virtual string ToString() { }

}

