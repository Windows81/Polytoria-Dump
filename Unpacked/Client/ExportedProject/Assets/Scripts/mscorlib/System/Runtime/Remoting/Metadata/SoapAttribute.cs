namespace System.Runtime.Remoting.Metadata;

[ComVisible(True)]
[Token(Token = "0x200038A")]
public class SoapAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000E6F")]
	private bool _useAttribute; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000E70")]
	protected string ProtXmlNamespace; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000E71")]
	protected object ReflectInfo; //Field offset: 0x20

	[Token(Token = "0x17000316")]
	public override bool UseAttribute
	{
		[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001B7C")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000317")]
	public override string XmlNamespace
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001B7D")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001B7B")]
	public SoapAttribute() { }

	[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001B7C")]
	public override bool get_UseAttribute() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001B7D")]
	public override string get_XmlNamespace() { }

	[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001B7E")]
	internal override void SetReflectionObject(object reflectionObject) { }

}

