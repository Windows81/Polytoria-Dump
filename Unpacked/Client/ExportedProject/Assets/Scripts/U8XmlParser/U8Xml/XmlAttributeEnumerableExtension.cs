namespace U8Xml;

[Extension]
[Token(Token = "0x200000E")]
public static class XmlAttributeEnumerableExtension
{

	[Address(RVA = "0x7D40A0", Offset = "0x7D32A0", Length = "0x11F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(XmlAttributeEnumerableExtension), Member = "FindOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAttributes"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAttributes", typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(U8Xml.Option`1<U8Xml.XmlAttribute>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	[NullableContext(1)]
	[Token(Token = "0x600003F")]
	public static XmlAttribute Find(TAttributes source, string name) { }

	[Address(RVA = "0x7D3940", Offset = "0x7D2B40", Length = "0x1CD")]
	[CalledBy(Type = typeof(XmlAttributeEnumerableExtension), Member = "FindOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAttributes"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAttributes", typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(U8Xml.Option`1<U8Xml.XmlAttribute>))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(XmlAttributeList), Member = "System.Collections.Generic.IEnumerable<U8Xml.XmlAttribute>.GetEnumerator", ReturnType = typeof(System.Collections.Generic.IEnumerator`1<U8Xml.XmlAttribute>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(RawString), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RawString), typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Option`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = "U8Xml.Option`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x600003C")]
	public static Option<XmlAttribute> FindOrDefault(TAttributes source, ReadOnlySpan<Byte> name) { }

	[Address(RVA = "0x7D3B10", Offset = "0x7D2D10", Length = "0x3AF")]
	[CalledBy(Type = "Polytoria.Datamodel.Proxies.Vector3ValueProxy", Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Vector3"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlAttributeEnumerableExtension), Member = "FindOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAttributes"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAttributes", typeof(string)}, ReturnType = typeof(U8Xml.Option`1<U8Xml.XmlAttribute>))]
	[CalledBy(Type = typeof(XmlAttributeEnumerableExtension), Member = "Find", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAttributes"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAttributes", typeof(string)}, ReturnType = typeof(XmlAttribute))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800300C0")]
	[Calls(Type = typeof(XmlAttributeEnumerableExtension), Member = "FindOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAttributes"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAttributes", typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(U8Xml.Option`1<U8Xml.XmlAttribute>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1807CA4B0")]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[Extension]
	[SkipLocalsInit]
	[Token(Token = "0x600003D")]
	public static Option<XmlAttribute> FindOrDefault(TAttributes source, ReadOnlySpan<Char> name) { }

	[Address(RVA = "0x7D3EC0", Offset = "0x7D30C0", Length = "0x9B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(XmlAttributeEnumerableExtension), Member = "FindOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAttributes"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAttributes", typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(U8Xml.Option`1<U8Xml.XmlAttribute>))]
	[DeduplicatedMethod]
	[Extension]
	[NullableContext(1)]
	[Token(Token = "0x600003E")]
	public static Option<XmlAttribute> FindOrDefault(TAttributes source, string name) { }

}

