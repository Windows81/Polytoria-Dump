namespace System.Xml;

[Token(Token = "0x20000A9")]
internal class Ucs4Encoding : Encoding
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400040E")]
	internal Ucs4Decoder ucs4Decoder; //Field offset: 0x38

	[Token(Token = "0x170001C3")]
	public virtual int CodePage
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x60007CF")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170001C6")]
	internal static Encoding UCS4_2143
	{
		[Address(RVA = "0x16B5630", Offset = "0x16B4830", Length = "0xCF")]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DetectEncoding", ReturnType = typeof(Encoding))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Encoding), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60007D3")]
		internal get { } //Length: 207
	}

	[Token(Token = "0x170001C7")]
	internal static Encoding UCS4_3412
	{
		[Address(RVA = "0x16B5700", Offset = "0x16B4900", Length = "0xCF")]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DetectEncoding", ReturnType = typeof(Encoding))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Encoding), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60007D4")]
		internal get { } //Length: 207
	}

	[Token(Token = "0x170001C5")]
	internal static Encoding UCS4_Bigendian
	{
		[Address(RVA = "0x16B57D0", Offset = "0x16B49D0", Length = "0xCF")]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DetectEncoding", ReturnType = typeof(Encoding))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Encoding), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60007D2")]
		internal get { } //Length: 207
	}

	[Token(Token = "0x170001C4")]
	internal static Encoding UCS4_Littleendian
	{
		[Address(RVA = "0x16B58A0", Offset = "0x16B4AA0", Length = "0xCF")]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DetectEncoding", ReturnType = typeof(Encoding))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Encoding), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60007D1")]
		internal get { } //Length: 207
	}

	[Token(Token = "0x170001C2")]
	public virtual string WebName
	{
		[Address(RVA = "0x14EC920", Offset = "0x14EBB20", Length = "0x14")]
		[CallerCount(Count = 43)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60007C6")]
		 get { } //Length: 20
	}

	[Address(RVA = "0x3910A0", Offset = "0x3902A0", Length = "0x7")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Encoding), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60007D5")]
	public Ucs4Encoding() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007CF")]
	public virtual int get_CodePage() { }

	[Address(RVA = "0x16B5630", Offset = "0x16B4830", Length = "0xCF")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DetectEncoding", ReturnType = typeof(Encoding))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Encoding), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60007D3")]
	internal static Encoding get_UCS4_2143() { }

	[Address(RVA = "0x16B5700", Offset = "0x16B4900", Length = "0xCF")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DetectEncoding", ReturnType = typeof(Encoding))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Encoding), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60007D4")]
	internal static Encoding get_UCS4_3412() { }

	[Address(RVA = "0x16B57D0", Offset = "0x16B49D0", Length = "0xCF")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DetectEncoding", ReturnType = typeof(Encoding))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Encoding), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60007D2")]
	internal static Encoding get_UCS4_Bigendian() { }

	[Address(RVA = "0x16B58A0", Offset = "0x16B4AA0", Length = "0xCF")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DetectEncoding", ReturnType = typeof(Encoding))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Encoding), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60007D1")]
	internal static Encoding get_UCS4_Littleendian() { }

	[Address(RVA = "0x14EC920", Offset = "0x14EBB20", Length = "0x14")]
	[CallerCount(Count = 43)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007C6")]
	public virtual string get_WebName() { }

	[Address(RVA = "0x16B5540", Offset = "0x16B4740", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE5F0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60007C8")]
	public virtual int GetByteCount(Char[] chars, int index, int count) { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007C9")]
	public virtual Byte[] GetBytes(string s) { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007CA")]
	public virtual int GetBytes(Char[] chars, int charIndex, int charCount, Byte[] bytes, int byteIndex) { }

	[Address(RVA = "0x16B55B0", Offset = "0x16B47B0", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60007CC")]
	public virtual int GetCharCount(Byte[] bytes, int index, int count) { }

	[Address(RVA = "0x16B55E0", Offset = "0x16B47E0", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60007CD")]
	public virtual int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007C7")]
	public virtual Decoder GetDecoder() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007D0")]
	public virtual Encoder GetEncoder() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007CB")]
	public virtual int GetMaxByteCount(int charCount) { }

	[Address(RVA = "0x16B5620", Offset = "0x16B4820", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60007CE")]
	public virtual int GetMaxCharCount(int byteCount) { }

}

