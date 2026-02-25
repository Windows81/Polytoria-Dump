namespace System.Xml.Schema;

[Token(Token = "0x2000100")]
internal class Datatype_year : Datatype_dateTimeBase
{

	[Token(Token = "0x17000251")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x3CE290", Offset = "0x3CD490", Length = "0x6")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000976")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x16AA2A0", Offset = "0x16A94A0", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Datatype_dateTimeBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000977")]
	internal Datatype_year() { }

	[Address(RVA = "0x3CE290", Offset = "0x3CD490", Length = "0x6")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000976")]
	public virtual XmlTypeCode get_TypeCode() { }

}

