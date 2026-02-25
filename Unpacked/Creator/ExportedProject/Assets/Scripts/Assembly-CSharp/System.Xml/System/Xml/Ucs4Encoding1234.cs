namespace System.Xml;

[Token(Token = "0x20000AA")]
internal class Ucs4Encoding1234 : Ucs4Encoding
{

	[Token(Token = "0x170001C8")]
	public virtual string EncodingName
	{
		[Address(RVA = "0x16B5150", Offset = "0x16B4350", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60007D7")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x16B50A0", Offset = "0x16B42A0", Length = "0xA3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Encoding), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60007D6")]
	public Ucs4Encoding1234() { }

	[Address(RVA = "0x16B5150", Offset = "0x16B4350", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60007D7")]
	public virtual string get_EncodingName() { }

	[Address(RVA = "0x16B5040", Offset = "0x16B4240", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60007D8")]
	public virtual Byte[] GetPreamble() { }

}

