namespace System.Xml;

[Token(Token = "0x20000AD")]
internal class Ucs4Encoding3412 : Ucs4Encoding
{

	[Token(Token = "0x170001CB")]
	public virtual string EncodingName
	{
		[Address(RVA = "0x16B53D0", Offset = "0x16B45D0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60007E0")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x16B5320", Offset = "0x16B4520", Length = "0xA3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Encoding), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60007DF")]
	public Ucs4Encoding3412() { }

	[Address(RVA = "0x16B53D0", Offset = "0x16B45D0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60007E0")]
	public virtual string get_EncodingName() { }

	[Address(RVA = "0x16B52C0", Offset = "0x16B44C0", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60007E1")]
	public virtual Byte[] GetPreamble() { }

}

