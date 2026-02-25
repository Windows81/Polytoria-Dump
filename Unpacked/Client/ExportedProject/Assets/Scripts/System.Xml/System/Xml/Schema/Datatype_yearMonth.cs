namespace System.Xml.Schema;

[Token(Token = "0x20000FF")]
internal class Datatype_yearMonth : Datatype_dateTimeBase
{

	[Token(Token = "0x17000250")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x3CE270", Offset = "0x3CD470", Length = "0x6")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000974")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x16AA250", Offset = "0x16A9450", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Datatype_dateTimeBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000975")]
	internal Datatype_yearMonth() { }

	[Address(RVA = "0x3CE270", Offset = "0x3CD470", Length = "0x6")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000974")]
	public virtual XmlTypeCode get_TypeCode() { }

}

