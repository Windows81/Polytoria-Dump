namespace System.Xml;

[Token(Token = "0x2000085")]
public class XmlNodeChangedEventArgs : EventArgs
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400034A")]
	private XmlNodeChangedAction action; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400034B")]
	private XmlNode node; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400034C")]
	private XmlNode oldParent; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400034D")]
	private XmlNode newParent; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400034E")]
	private string oldValue; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400034F")]
	private string newValue; //Field offset: 0x38

	[Token(Token = "0x17000190")]
	public XmlNodeChangedAction Action
	{
		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000668")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x167DBD0", Offset = "0x167CDD0", Length = "0xCA")]
	[CalledBy(Type = typeof(XmlDocument), Member = "GetEventArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlNode), typeof(XmlNode), typeof(string), typeof(string), typeof(XmlNodeChangedAction)}, ReturnType = typeof(XmlNodeChangedEventArgs))]
	[CalledBy(Type = typeof(XmlDocument), Member = "GetInsertEventArgsForLoad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlNode)}, ReturnType = typeof(XmlNodeChangedEventArgs))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000667")]
	public XmlNodeChangedEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action) { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000668")]
	public XmlNodeChangedAction get_Action() { }

}

