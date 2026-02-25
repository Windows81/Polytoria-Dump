namespace U8Xml;

[DebuggerDisplay("{ToString(),nq}")]
[IsReadOnly]
[Token(Token = "0x2000008")]
public struct Option : IEquatable<Option`1<T>>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000005")]
	private readonly T _v; //Field offset: 0x0

	[Token(Token = "0x17000002")]
	public static Option<T> Null
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x600000D")]
		 get { } //Length: 3
	}

	[Address(RVA = "0xE5D070", Offset = "0xE5C270", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600000E")]
	public Option`1(in T v) { }

	[Address(RVA = "0xE5C400", Offset = "0xE5B600", Length = "0xFF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(Option`1), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"U8Xml.Option`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[DeduplicatedMethod]
	[NullableContext(2)]
	[Token(Token = "0x6000011")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xE5C700", Offset = "0xE5B900", Length = "0x168")]
	[CalledBy(Type = typeof(Option`1), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(System.Collections.Generic.EqualityComparer`1<U8Xml.XmlAttribute>), Member = "CreateComparer", ReturnType = typeof(System.Collections.Generic.EqualityComparer`1<U8Xml.XmlAttribute>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000012")]
	public override bool Equals(Option<T> other) { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x600000D")]
	public static Option<T> get_Null() { }

	[Address(RVA = "0xE5C870", Offset = "0xE5BA70", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000013")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0xE5D160", Offset = "0xE5C360", Length = "0x24")]
	[CalledBy(Type = typeof(XmlAttribute_), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RawString), typeof(RawString), typeof(XmlNode_*)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlAttributeEnumerableExtension), Member = "FindOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAttributes"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAttributes", typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(U8Xml.Option`1<U8Xml.XmlAttribute>))]
	[CalledBy(Type = typeof(XmlNodeEnumerableExtension), Member = "FindOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TNodes"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TNodes", typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(U8Xml.Option`1<U8Xml.XmlNode>))]
	[CalledBy(Type = typeof(XmlParser), Member = "GetAttr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RawString), typeof(Int32&), typeof(XmlNode_*)}, ReturnType = typeof(XmlAttribute_))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000014")]
	public static Option<T> op_Implicit(in T value) { }

	[Address(RVA = "0xE5CA80", Offset = "0xE5BC80", Length = "0xC9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(XmlAttribute), Member = "ToString", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[NullableContext(1)]
	[Token(Token = "0x6000010")]
	public virtual string ToString() { }

	[Address(RVA = "0xE5CF50", Offset = "0xE5C150", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600000F")]
	public bool TryGetValue(out T value) { }

}

