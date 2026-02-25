namespace System.Xml.Schema;

[Token(Token = "0x2000102")]
internal class Datatype_day : Datatype_dateTimeBase
{

	[Token(Token = "0x17000253")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x3CE1D0", Offset = "0x3CD3D0", Length = "0x6")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x600097A")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x16A4DA0", Offset = "0x16A3FA0", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Datatype_dateTimeBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Token(Token = "0x600097B")]
	internal Datatype_day() { }

	[Address(RVA = "0x3CE1D0", Offset = "0x3CD3D0", Length = "0x6")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x600097A")]
	public virtual XmlTypeCode get_TypeCode() { }

}

