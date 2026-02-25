namespace System.Xml;

[Token(Token = "0x20000A7")]
internal class UTF16Decoder : Decoder
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400040C")]
	private bool bigEndian; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400040D")]
	private int lastByte; //Field offset: 0x24

	[Address(RVA = "0x16B3ED0", Offset = "0x16B30D0", Length = "0x2D")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "SetupEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60007BD")]
	public UTF16Decoder(bool bigEndian) { }

	[Address(RVA = "0x16B3930", Offset = "0x16B2B30", Length = "0x280")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60007C1")]
	public virtual void Convert(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	[Address(RVA = "0x1325010", Offset = "0x1324210", Length = "0x27")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007BE")]
	public virtual int GetCharCount(Byte[] bytes, int index, int count) { }

	[Address(RVA = "0x16B3BC0", Offset = "0x16B2DC0", Length = "0xEC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60007BF")]
	public virtual int GetCharCount(Byte[] bytes, int index, int count, bool flush) { }

	[Address(RVA = "0x16B3CB0", Offset = "0x16B2EB0", Length = "0x219")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60007C0")]
	public virtual int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

}

