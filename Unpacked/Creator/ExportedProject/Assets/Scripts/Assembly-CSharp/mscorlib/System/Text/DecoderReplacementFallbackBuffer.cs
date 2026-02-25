namespace System.Text;

[Token(Token = "0x2000298")]
public sealed class DecoderReplacementFallbackBuffer : DecoderFallbackBuffer
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B7E")]
	private string _strDefault; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000B7F")]
	private int _fallbackCount; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000B80")]
	private int _fallbackIndex; //Field offset: 0x2C

	[Token(Token = "0x17000214")]
	public virtual int Remaining
	{
		[Address(RVA = "0x15267A0", Offset = "0x15259A0", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001502")]
		 get { } //Length: 13
	}

	[Address(RVA = "0x1526750", Offset = "0x1525950", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60014FF")]
	public DecoderReplacementFallbackBuffer(DecoderReplacementFallback fallback) { }

	[Address(RVA = "0x1526690", Offset = "0x1525890", Length = "0x47")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DecoderFallbackBuffer), Member = "ThrowLastBytesRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001500")]
	public virtual bool Fallback(Byte[] bytesUnknown, int index) { }

	[Address(RVA = "0x15267A0", Offset = "0x15259A0", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001502")]
	public virtual int get_Remaining() { }

	[Address(RVA = "0x15266E0", Offset = "0x15258E0", Length = "0x4D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001501")]
	public virtual char GetNextChar() { }

	[Address(RVA = "0x3BD7A0", Offset = "0x3BC9A0", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001504")]
	internal virtual int InternalFallback(Byte[] bytes, Byte* pBytes) { }

	[Address(RVA = "0x1526730", Offset = "0x1525930", Length = "0x11")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001503")]
	public virtual void Reset() { }

}

