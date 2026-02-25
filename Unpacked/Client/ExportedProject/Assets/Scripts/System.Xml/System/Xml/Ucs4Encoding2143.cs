namespace System.Xml;

[Token(Token = "0x20000AC")]
internal class Ucs4Encoding2143 : Ucs4Encoding
{

	[Token(Token = "0x170001CA")]
	public virtual string EncodingName
	{
		[Address(RVA = "0x16B5290", Offset = "0x16B4490", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60007DD")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x16B51E0", Offset = "0x16B43E0", Length = "0xA3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Encoding), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60007DC")]
	public Ucs4Encoding2143() { }

	[Address(RVA = "0x16B5290", Offset = "0x16B4490", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60007DD")]
	public virtual string get_EncodingName() { }

	[Address(RVA = "0x16B5180", Offset = "0x16B4380", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60007DE")]
	public virtual Byte[] GetPreamble() { }

}

