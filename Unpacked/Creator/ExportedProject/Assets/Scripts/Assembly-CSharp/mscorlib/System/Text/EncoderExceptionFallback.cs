namespace System.Text;

[Token(Token = "0x200029C")]
public sealed class EncoderExceptionFallback : EncoderFallback
{

	[Token(Token = "0x1700021B")]
	public virtual int MaxCharCount
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001520")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600151E")]
	public EncoderExceptionFallback() { }

	[Address(RVA = "0x1527F10", Offset = "0x1527110", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600151F")]
	public virtual EncoderFallbackBuffer CreateFallbackBuffer() { }

	[Address(RVA = "0x1527F60", Offset = "0x1527160", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001521")]
	public virtual bool Equals(object value) { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001520")]
	public virtual int get_MaxCharCount() { }

	[Address(RVA = "0x1527FB0", Offset = "0x15271B0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001522")]
	public virtual int GetHashCode() { }

}

