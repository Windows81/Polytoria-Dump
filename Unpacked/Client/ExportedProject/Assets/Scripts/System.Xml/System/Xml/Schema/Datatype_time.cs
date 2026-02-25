namespace System.Xml.Schema;

[Token(Token = "0x20000FD")]
internal class Datatype_time : Datatype_dateTimeBase
{

	[Token(Token = "0x1700024E")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x16A8650", Offset = "0x16A7850", Length = "0x6")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000970")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x16A8600", Offset = "0x16A7800", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Datatype_dateTimeBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000971")]
	internal Datatype_time() { }

	[Address(RVA = "0x16A8650", Offset = "0x16A7850", Length = "0x6")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000970")]
	public virtual XmlTypeCode get_TypeCode() { }

}

