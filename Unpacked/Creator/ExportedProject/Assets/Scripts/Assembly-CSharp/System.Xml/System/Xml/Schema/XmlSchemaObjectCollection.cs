namespace System.Xml.Schema;

[DefaultMember("Item")]
[Token(Token = "0x2000157")]
public class XmlSchemaObjectCollection : CollectionBase
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40005F5")]
	private XmlSchemaObject parent; //Field offset: 0x18

	[Address(RVA = "0x12BA7A0", Offset = "0x12B99A0", Length = "0x7")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B6D")]
	public XmlSchemaObjectCollection() { }

	[Address(RVA = "0x16D98B0", Offset = "0x16D8AB0", Length = "0xC5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000B6E")]
	public int Add(XmlSchemaObject item) { }

	[Address(RVA = "0x16D9980", Offset = "0x16D8B80", Length = "0x23")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000B71")]
	protected virtual void OnClear() { }

	[Address(RVA = "0x16D99B0", Offset = "0x16D8BB0", Length = "0x23")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000B6F")]
	protected virtual void OnInsert(int index, object item) { }

	[Address(RVA = "0x16D99E0", Offset = "0x16D8BE0", Length = "0x23")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000B72")]
	protected virtual void OnRemove(int index, object item) { }

	[Address(RVA = "0x16D9A10", Offset = "0x16D8C10", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000B70")]
	protected virtual void OnSet(int index, object oldValue, object newValue) { }

}

