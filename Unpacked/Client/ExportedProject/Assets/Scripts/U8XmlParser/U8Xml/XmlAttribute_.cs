namespace U8Xml;

[DebuggerDisplay("{ToString(),nq}")]
[IsReadOnly]
[Token(Token = "0x200000D")]
internal struct XmlAttribute_
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000009")]
	public readonly RawString Name; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400000A")]
	public readonly RawString Value; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400000B")]
	public readonly Option<XmlNode> Node; //Field offset: 0x20

	[Address(RVA = "0x180C200", Offset = "0x180B400", Length = "0x83")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Option`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = "U8Xml.Option`1<T>")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600003A")]
	public XmlAttribute_(RawString name, RawString value, XmlNode_* node) { }

	[Address(RVA = "0x180C180", Offset = "0x180B380", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RawString), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[NullableContext(1)]
	[Token(Token = "0x600003B")]
	public virtual string ToString() { }

}

