namespace System.Xml;

[Token(Token = "0x20000AE")]
internal abstract class Ucs4Decoder : Decoder
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400040F")]
	internal Byte[] lastBytes; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000410")]
	internal int lastBytesCount; //Field offset: 0x28

	[Address(RVA = "0x16B4220", Offset = "0x16B3420", Length = "0x55")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007E7")]
	protected Ucs4Decoder() { }

	[Address(RVA = "0x16B4BC0", Offset = "0x16B3DC0", Length = "0x233")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60007E5")]
	public virtual void Convert(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	[Address(RVA = "0x16B4E00", Offset = "0x16B4000", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60007E2")]
	public virtual int GetCharCount(Byte[] bytes, int index, int count) { }

	[Address(RVA = "0x16B4E10", Offset = "0x16B4010", Length = "0x1B6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60007E4")]
	public virtual int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	[Token(Token = "0x60007E3")]
	internal abstract int GetFullChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	[Address(RVA = "0x16B4FD0", Offset = "0x16B41D0", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60007E6")]
	internal void Ucs4ToUTF16(uint code, Char[] chars, int charIndex) { }

}

