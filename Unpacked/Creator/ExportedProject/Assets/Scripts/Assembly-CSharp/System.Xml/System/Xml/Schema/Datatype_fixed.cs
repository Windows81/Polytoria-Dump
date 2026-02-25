namespace System.Xml.Schema;

[Token(Token = "0x2000126")]
internal class Datatype_fixed : Datatype_decimal
{

	[Address(RVA = "0x16A6250", Offset = "0x16A5450", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Datatype_decimal), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000A35")]
	public Datatype_fixed() { }

	[Address(RVA = "0x16A5E40", Offset = "0x16A5040", Length = "0x265")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002FA0")]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(Numeric10FacetsChecker), Member = "CheckTotalAndFractionDigits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(XmlConvert), Member = "ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000A33")]
	public virtual object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	[Address(RVA = "0x16A60B0", Offset = "0x16A52B0", Length = "0x19C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XmlConvert), Member = "TryToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Decimal&)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Numeric10FacetsChecker), Member = "CheckTotalAndFractionDigits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000A34")]
	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

