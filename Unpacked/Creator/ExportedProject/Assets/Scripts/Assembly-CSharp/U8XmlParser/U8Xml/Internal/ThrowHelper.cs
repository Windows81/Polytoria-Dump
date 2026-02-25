namespace U8Xml.Internal;

[Nullable(0)]
[NullableContext(2)]
[Token(Token = "0x2000031")]
internal static class ThrowHelper
{

	[Address(RVA = "0x180AEB0", Offset = "0x180A0B0", Length = "0x49")]
	[CalledBy(Type = typeof(RawStringTable), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RawString&), typeof(RawString&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60000EB")]
	public static void ThrowArg(string message = null) { }

	[Address(RVA = "0x180AE60", Offset = "0x180A060", Length = "0x49")]
	[CalledBy(Type = typeof(RawString), Member = "Slice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(RawString))]
	[CalledBy(Type = typeof(RawString), Member = "At", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Byte&))]
	[CalledBy(Type = typeof(XmlParser), Member = "ParseDtdInternalSubset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RawString), typeof(Int32&), typeof(RawStringTable&), typeof(RawString&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlParser), Member = "TryParseDocType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RawString), typeof(Int32&), typeof(bool), typeof(OptionalNodeList), typeof(RawStringTable&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlParser), Member = "GetInnerText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RawString), typeof(Int32&), typeof(RawString&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlParser), Member = "GetNodeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RawString), typeof(Int32&), typeof(RawString&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlParser), Member = "GetAttr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RawString), typeof(Int32&), typeof(XmlNode_*)}, ReturnType = typeof(XmlAttribute_))]
	[CalledBy(Type = typeof(DataOffsetHelper), Member = "GetLinePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Byte*)}, ReturnType = typeof(System.Nullable`1<U8Xml.DataLinePosition>))]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60000EA")]
	public static void ThrowArgOutOfRange(string message = null) { }

	[Address(RVA = "0x180AF00", Offset = "0x180A100", Length = "0x49")]
	[CalledBy(Type = typeof(XmlParser), Member = "TryParseCDATA", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RawString), typeof(Int32&), typeof(NodeStack&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Datamodel.Proxies.Vector3ValueProxy", Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Vector3"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RawString), Member = "ToFloat32", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(RawString), Member = "ToInt32", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlAttributeEnumerableExtension), Member = "Find", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAttributes"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAttributes", typeof(string)}, ReturnType = typeof(XmlAttribute))]
	[CalledBy(Type = typeof(XmlNode), Member = "FindChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlNode), Member = "FindChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlParser), Member = "StartStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RawString), typeof(NodeStore&), typeof(OptionalNodeList), typeof(RawStringTable&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CustomList`1), Member = "GetPointerToAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = "T*")]
	[CalledBy(Type = typeof(NodeStack), Member = "Pop", ReturnType = typeof(XmlNode_*))]
	[CalledBy(Type = typeof(NodeStack), Member = "Peek", ReturnType = typeof(XmlNode_*))]
	[CalledBy(Type = typeof(RawStringTable), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RawString&), typeof(RawString&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Token(Token = "0x60000EC")]
	public static void ThrowInvalidOperation(string message = null) { }

	[Address(RVA = "0x180AF50", Offset = "0x180A150", Length = "0x49")]
	[CalledBy(Type = typeof(FileHelper), Member = "ReadFileToUnmanaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.ValueTuple`2<U8Xml.Internal.UnmanagedBuffer, System.Int32>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[NullableContext(1)]
	[Token(Token = "0x60000E8")]
	public static void ThrowNotSupported(string message) { }

	[Address(RVA = "0x180AFA0", Offset = "0x180A1A0", Length = "0x49")]
	[CalledBy(Type = typeof(XmlParser), Member = "ParseFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlObject))]
	[CalledBy(Type = typeof(XmlParser), Member = "ParseFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Encoding)}, ReturnType = typeof(XmlObject))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[NullableContext(1)]
	[Token(Token = "0x60000E9")]
	public static void ThrowNullArg(string message) { }

}

