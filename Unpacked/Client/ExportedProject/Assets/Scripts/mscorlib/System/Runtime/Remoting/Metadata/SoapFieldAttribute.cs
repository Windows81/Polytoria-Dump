namespace System.Runtime.Remoting.Metadata;

[AttributeUsage(AttributeTargets::Field (256))]
[ComVisible(True)]
[Token(Token = "0x200038B")]
public sealed class SoapFieldAttribute : SoapAttribute
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000E72")]
	private string _elementName; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000E73")]
	private bool _isElement; //Field offset: 0x30

	[Token(Token = "0x17000318")]
	public string XmlElementName
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001B80")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001B7F")]
	public SoapFieldAttribute() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001B80")]
	public string get_XmlElementName() { }

	[Address(RVA = "0x3351B0", Offset = "0x3343B0", Length = "0x5")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001B81")]
	public bool IsInteropXmlElement() { }

	[Address(RVA = "0x1396A50", Offset = "0x1395C50", Length = "0xA7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001B82")]
	internal virtual void SetReflectionObject(object reflectionObject) { }

}

