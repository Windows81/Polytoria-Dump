namespace U8Xml;

[DebuggerDisplay("{ToString(),nq}")]
[IsReadOnly]
[Token(Token = "0x200000C")]
public struct XmlAttribute : IEquatable<XmlAttribute>, IReference
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000008")]
	private readonly IntPtr _attr; //Field offset: 0x0

	[Token(Token = "0x17000008")]
	public override bool IsNull
	{
		[Address(RVA = "0x9E2EA0", Offset = "0x9E20A0", Length = "0x8")]
		[CallerCount(Count = 8)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000032")]
		 get { } //Length: 8
	}

	[IsReadOnly]
	[Token(Token = "0x17000009")]
	public RawString Name
	{
		[Address(RVA = "0x18084F0", Offset = "0x18076F0", Length = "0x1D")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000033")]
		 get { } //Length: 29
	}

	[IsReadOnly]
	[Token(Token = "0x1700000A")]
	public RawString Value
	{
		[Address(RVA = "0x180C290", Offset = "0x180B490", Length = "0x21")]
		[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "HandleXmlNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeList), "Polytoria.Datamodel.Instance"}, ReturnType = "Polytoria.Datamodel.Instance")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000034")]
		 get { } //Length: 33
	}

	[Address(RVA = "0x9E2BC0", Offset = "0x9E1DC0", Length = "0x1F")]
	[CallerCount(Count = 11)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000035")]
	internal XmlAttribute(XmlAttribute_* attr) { }

	[Address(RVA = "0x180C090", Offset = "0x180B290", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[NullableContext(2)]
	[Token(Token = "0x6000036")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x14A0AF0", Offset = "0x149FCF0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000037")]
	public override bool Equals(XmlAttribute other) { }

	[Address(RVA = "0x9E2EA0", Offset = "0x9E20A0", Length = "0x8")]
	[CallerCount(Count = 8)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000032")]
	public override bool get_IsNull() { }

	[Address(RVA = "0x18084F0", Offset = "0x18076F0", Length = "0x1D")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000033")]
	public RawString get_Name() { }

	[Address(RVA = "0x180C290", Offset = "0x180B490", Length = "0x21")]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "HandleXmlNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeList), "Polytoria.Datamodel.Instance"}, ReturnType = "Polytoria.Datamodel.Instance")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000034")]
	public RawString get_Value() { }

	[Address(RVA = "0x12DD960", Offset = "0x12DCB60", Length = "0x7")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000038")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x180C120", Offset = "0x180B320", Length = "0x51")]
	[CalledBy(Type = typeof(Option`1), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[NullableContext(1)]
	[Token(Token = "0x6000039")]
	public virtual string ToString() { }

}

