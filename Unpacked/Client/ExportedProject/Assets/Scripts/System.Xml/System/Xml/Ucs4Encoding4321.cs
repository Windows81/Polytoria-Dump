namespace System.Xml;

[Token(Token = "0x20000AB")]
internal class Ucs4Encoding4321 : Ucs4Encoding
{

	[Token(Token = "0x170001C9")]
	public virtual string EncodingName
	{
		[Address(RVA = "0x16B5510", Offset = "0x16B4710", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60007DA")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x16B5460", Offset = "0x16B4660", Length = "0xA3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Encoding), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60007D9")]
	public Ucs4Encoding4321() { }

	[Address(RVA = "0x16B5510", Offset = "0x16B4710", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60007DA")]
	public virtual string get_EncodingName() { }

	[Address(RVA = "0x16B5400", Offset = "0x16B4600", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60007DB")]
	public virtual Byte[] GetPreamble() { }

}

