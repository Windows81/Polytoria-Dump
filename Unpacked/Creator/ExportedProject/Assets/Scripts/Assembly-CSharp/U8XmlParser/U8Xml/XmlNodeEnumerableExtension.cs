namespace U8Xml;

[Extension]
[Token(Token = "0x2000017")]
public static class XmlNodeEnumerableExtension
{

	[Address(RVA = "0x7D8B10", Offset = "0x7D7D10", Length = "0x1E2")]
	[CalledBy(Type = typeof(XmlNodeEnumerableExtension), Member = "FindOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TNodes"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TNodes", typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(U8Xml.Option`1<U8Xml.XmlNode>))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(XmlNodeList), Member = "System.Collections.Generic.IEnumerable<U8Xml.XmlNode>.GetEnumerator", ReturnType = typeof(System.Collections.Generic.IEnumerator`1<U8Xml.XmlNode>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(XmlNode), Member = "get_Name", ReturnType = typeof(RawString))]
	[Calls(Type = typeof(RawString), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RawString), typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Option`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = "U8Xml.Option`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x6000069")]
	public static Option<XmlNode> FindOrDefault(TNodes source, ReadOnlySpan<Byte> name) { }

	[Address(RVA = "0x7D8710", Offset = "0x7D7910", Length = "0x3F7")]
	[CalledBy(Type = "Polytoria.Datamodel.Proxies.Vector3ValueProxy", Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Vector3"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlNode), Member = "FindChildOrDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(U8Xml.Option`1<U8Xml.XmlNode>))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800300C0")]
	[Calls(Type = typeof(XmlNodeEnumerableExtension), Member = "FindOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TNodes"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TNodes", typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(U8Xml.Option`1<U8Xml.XmlNode>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1807CA4B0")]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x600006A")]
	public static Option<XmlNode> FindOrDefault(TNodes source, ReadOnlySpan<Char> name) { }

}

