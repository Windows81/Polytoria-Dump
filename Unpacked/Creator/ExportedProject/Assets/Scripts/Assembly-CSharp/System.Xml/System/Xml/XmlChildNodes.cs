namespace System.Xml;

[Token(Token = "0x2000071")]
internal class XmlChildNodes : XmlNodeList
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002EA")]
	private XmlNode container; //Field offset: 0x10

	[Token(Token = "0x17000105")]
	public virtual int Count
	{
		[Address(RVA = "0x166EA60", Offset = "0x166DC60", Length = "0x5B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000500")]
		 get { } //Length: 91
	}

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004FF")]
	public XmlChildNodes(XmlNode container) { }

	[Address(RVA = "0x166EA60", Offset = "0x166DC60", Length = "0x5B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000500")]
	public virtual int get_Count() { }

	[Address(RVA = "0x166E960", Offset = "0x166DB60", Length = "0xFF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000501")]
	public virtual IEnumerator GetEnumerator() { }

}

