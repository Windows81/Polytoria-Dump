namespace System.Text;

[Token(Token = "0x2000291")]
public sealed class DecoderExceptionFallback : DecoderFallback
{

	[Token(Token = "0x1700020A")]
	public virtual int MaxCharCount
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x60014CF")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60014CD")]
	public DecoderExceptionFallback() { }

	[Address(RVA = "0x1524F90", Offset = "0x1524190", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60014CE")]
	public virtual DecoderFallbackBuffer CreateFallbackBuffer() { }

	[Address(RVA = "0x1524FE0", Offset = "0x15241E0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60014D0")]
	public virtual bool Equals(object value) { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x60014CF")]
	public virtual int get_MaxCharCount() { }

	[Address(RVA = "0x1525030", Offset = "0x1524230", Length = "0x6")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60014D1")]
	public virtual int GetHashCode() { }

}

