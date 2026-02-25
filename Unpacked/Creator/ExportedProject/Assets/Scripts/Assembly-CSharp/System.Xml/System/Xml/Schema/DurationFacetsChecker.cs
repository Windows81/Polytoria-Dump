namespace System.Xml.Schema;

[Token(Token = "0x200012D")]
internal class DurationFacetsChecker : FacetsChecker
{

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A67")]
	public DurationFacetsChecker() { }

	[Address(RVA = "0x16AB140", Offset = "0x16AA340", Length = "0x11B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000A63")]
	internal virtual Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	[Address(RVA = "0x16AAD90", Offset = "0x16A9F90", Length = "0x3A1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(TimeSpan), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(TimeSpan)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DurationFacetsChecker), Member = "MatchEnumeration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(ArrayList)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000A64")]
	internal virtual Exception CheckValueFacets(TimeSpan value, XmlSchemaDatatype datatype) { }

	[Address(RVA = "0x16AB260", Offset = "0x16AA460", Length = "0x83")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000A65")]
	internal virtual bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	[Address(RVA = "0x16AB2F0", Offset = "0x16AA4F0", Length = "0x104")]
	[CalledBy(Type = typeof(DurationFacetsChecker), Member = "CheckValueFacets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(XmlSchemaDatatype)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(TimeSpan), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(TimeSpan)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000A66")]
	private bool MatchEnumeration(TimeSpan value, ArrayList enumeration) { }

}

