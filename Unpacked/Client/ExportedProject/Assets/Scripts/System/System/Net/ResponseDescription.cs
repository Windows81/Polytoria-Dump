namespace System.Net;

[Token(Token = "0x2000211")]
internal class ResponseDescription
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000818")]
	internal bool Multiline; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000819")]
	internal int Status; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400081A")]
	internal string StatusDescription; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400081B")]
	internal StringBuilder StatusBuffer; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400081C")]
	internal string StatusCodeString; //Field offset: 0x28

	[Token(Token = "0x17000283")]
	internal bool InvalidStatusCode
	{
		[Address(RVA = "0x17CB570", Offset = "0x17CA770", Length = "0x14")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000D46")]
		internal get { } //Length: 20
	}

	[Token(Token = "0x17000282")]
	internal bool PermanentFailure
	{
		[Address(RVA = "0x17CB590", Offset = "0x17CA790", Length = "0x17")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000D45")]
		internal get { } //Length: 23
	}

	[Token(Token = "0x17000280")]
	internal bool PositiveCompletion
	{
		[Address(RVA = "0x17CB5B0", Offset = "0x17CA7B0", Length = "0x17")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000D43")]
		internal get { } //Length: 23
	}

	[Token(Token = "0x1700027F")]
	internal bool PositiveIntermediate
	{
		[Address(RVA = "0x17CB5D0", Offset = "0x17CA7D0", Length = "0x14")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000D42")]
		internal get { } //Length: 20
	}

	[Token(Token = "0x17000281")]
	internal bool TransientFailure
	{
		[Address(RVA = "0x17CB5F0", Offset = "0x17CA7F0", Length = "0x17")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000D44")]
		internal get { } //Length: 23
	}

	[Address(RVA = "0x17CB500", Offset = "0x17CA700", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000D47")]
	public ResponseDescription() { }

	[Address(RVA = "0x17CB570", Offset = "0x17CA770", Length = "0x14")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D46")]
	internal bool get_InvalidStatusCode() { }

	[Address(RVA = "0x17CB590", Offset = "0x17CA790", Length = "0x17")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D45")]
	internal bool get_PermanentFailure() { }

	[Address(RVA = "0x17CB5B0", Offset = "0x17CA7B0", Length = "0x17")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D43")]
	internal bool get_PositiveCompletion() { }

	[Address(RVA = "0x17CB5D0", Offset = "0x17CA7D0", Length = "0x14")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D42")]
	internal bool get_PositiveIntermediate() { }

	[Address(RVA = "0x17CB5F0", Offset = "0x17CA7F0", Length = "0x17")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D44")]
	internal bool get_TransientFailure() { }

}

