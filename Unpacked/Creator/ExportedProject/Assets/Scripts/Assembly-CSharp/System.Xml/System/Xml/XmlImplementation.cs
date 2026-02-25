namespace System.Xml;

[Token(Token = "0x200007C")]
public class XmlImplementation
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000334")]
	private XmlNameTable nameTable; //Field offset: 0x10

	[Token(Token = "0x1700015F")]
	internal XmlNameTable NameTable
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005DE")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x16773F0", Offset = "0x16765F0", Length = "0x66")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NameTable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60005DB")]
	public XmlImplementation() { }

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60005DC")]
	public XmlImplementation(XmlNameTable nt) { }

	[Address(RVA = "0x1677390", Offset = "0x1676590", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlDocument), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlImplementation)}, ReturnType = typeof(void))]
	[Token(Token = "0x60005DD")]
	public override XmlDocument CreateDocument() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x60005DE")]
	internal XmlNameTable get_NameTable() { }

}

