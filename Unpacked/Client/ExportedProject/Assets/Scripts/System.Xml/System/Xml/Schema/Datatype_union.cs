namespace System.Xml.Schema;

[Token(Token = "0x20000EB")]
internal class Datatype_union : Datatype_anySimpleType
{
	[Token(Token = "0x4000523")]
	private static readonly Type atomicValueType; //Field offset: 0x0
	[Token(Token = "0x4000524")]
	private static readonly Type listValueType; //Field offset: 0x8
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000525")]
	private XmlSchemaSimpleType[] types; //Field offset: 0x38

	[Address(RVA = "0x16A8710", Offset = "0x16A7910", Length = "0xBB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600090E")]
	private static Datatype_union() { }

	[Address(RVA = "0x16A8660", Offset = "0x16A7860", Length = "0xA3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600090D")]
	internal bool HasAtomicMembers() { }

}

