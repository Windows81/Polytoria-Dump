namespace System.Text;

[Token(Token = "0x200028F")]
internal sealed class InternalDecoderBestFitFallback : DecoderFallback
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B6B")]
	internal Encoding _encoding; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B6C")]
	internal Char[] _arrayBestFit; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B6D")]
	internal char _cReplacement; //Field offset: 0x20

	[Token(Token = "0x17000207")]
	public virtual int MaxCharCount
	{
		[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x60014C2")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x152A790", Offset = "0x1529990", Length = "0x37")]
	[CalledBy(Type = typeof(Encoding), Member = "SetDefaultFallbacks", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60014C0")]
	internal InternalDecoderBestFitFallback(Encoding encoding) { }

	[Address(RVA = "0x152A670", Offset = "0x1529870", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InternalDecoderBestFitFallbackBuffer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalDecoderBestFitFallback)}, ReturnType = typeof(void))]
	[Token(Token = "0x60014C1")]
	public virtual DecoderFallbackBuffer CreateFallbackBuffer() { }

	[Address(RVA = "0x152A6D0", Offset = "0x15298D0", Length = "0xB2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60014C3")]
	public virtual bool Equals(object value) { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x60014C2")]
	public virtual int get_MaxCharCount() { }

	[Address(RVA = "0x1445000", Offset = "0x1444200", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60014C4")]
	public virtual int GetHashCode() { }

}

