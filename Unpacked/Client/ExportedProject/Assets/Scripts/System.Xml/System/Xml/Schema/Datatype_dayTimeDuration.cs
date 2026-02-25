namespace System.Xml.Schema;

[Token(Token = "0x20000F6")]
internal class Datatype_dayTimeDuration : Datatype_duration
{

	[Token(Token = "0x17000248")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x16A4D90", Offset = "0x16A3F90", Length = "0x6")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600095F")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x16A4D40", Offset = "0x16A3F40", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Datatype_duration), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000960")]
	public Datatype_dayTimeDuration() { }

	[Address(RVA = "0x16A4D90", Offset = "0x16A3F90", Length = "0x6")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600095F")]
	public virtual XmlTypeCode get_TypeCode() { }

	[Address(RVA = "0x16A4B30", Offset = "0x16A3D30", Length = "0x205")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XsdDuration), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DurationType), typeof(XsdDuration&)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(XsdDuration), Member = "TryToTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DurationType), typeof(TimeSpan&)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600095E")]
	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

