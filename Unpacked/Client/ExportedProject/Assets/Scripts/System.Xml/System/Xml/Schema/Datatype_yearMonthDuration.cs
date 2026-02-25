namespace System.Xml.Schema;

[Token(Token = "0x20000F5")]
internal class Datatype_yearMonthDuration : Datatype_duration
{

	[Token(Token = "0x17000247")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x15A2980", Offset = "0x15A1B80", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600095C")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x16AA200", Offset = "0x16A9400", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Datatype_duration), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x600095D")]
	public Datatype_yearMonthDuration() { }

	[Address(RVA = "0x15A2980", Offset = "0x15A1B80", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600095C")]
	public virtual XmlTypeCode get_TypeCode() { }

	[Address(RVA = "0x16A9FF0", Offset = "0x16A91F0", Length = "0x205")]
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
	[Token(Token = "0x600095B")]
	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

