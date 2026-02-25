namespace System.Runtime.Remoting.Channels;

[ComVisible(True)]
[Token(Token = "0x2000380")]
public class SinkProviderData
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000E67")]
	private string sinkName; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000E68")]
	private ArrayList children; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000E69")]
	private Hashtable properties; //Field offset: 0x20

	[Token(Token = "0x17000309")]
	public IList Children
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001B5B")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700030A")]
	public IDictionary Properties
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001B5C")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1374CB0", Offset = "0x1373EB0", Length = "0xAE")]
	[CalledBy(Type = typeof(ConfigHandler), Member = "ReadCustomProviderData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IAttrList)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConfigHandler), Member = "ReadProvider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IAttrList), typeof(bool)}, ReturnType = typeof(ProviderData))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001B5A")]
	public SinkProviderData(string name) { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001B5B")]
	public IList get_Children() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001B5C")]
	public IDictionary get_Properties() { }

}

