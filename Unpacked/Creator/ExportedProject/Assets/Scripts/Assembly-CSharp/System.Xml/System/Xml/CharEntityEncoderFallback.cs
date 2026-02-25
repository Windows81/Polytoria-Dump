namespace System.Xml;

[Token(Token = "0x200000D")]
internal class CharEntityEncoderFallback : EncoderFallback
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400001C")]
	private CharEntityEncoderFallbackBuffer fallbackBuffer; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400001D")]
	private Int32[] textContentMarks; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400001E")]
	private int endMarkPos; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400001F")]
	private int curMarkPos; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000020")]
	private int startOffset; //Field offset: 0x28

	[Token(Token = "0x17000002")]
	public virtual int MaxCharCount
	{
		[Address(RVA = "0x7C8160", Offset = "0x7C7360", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000021")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000003")]
	internal int StartOffset
	{
		[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000022")]
		internal set { } //Length: 4
	}

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600001F")]
	internal CharEntityEncoderFallback() { }

	[Address(RVA = "0x162D070", Offset = "0x162C270", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000024")]
	internal bool CanReplaceAt(int index) { }

	[Address(RVA = "0x162D0D0", Offset = "0x162C2D0", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000020")]
	public virtual EncoderFallbackBuffer CreateFallbackBuffer() { }

	[Address(RVA = "0x7C8160", Offset = "0x7C7360", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000021")]
	public virtual int get_MaxCharCount() { }

	[Address(RVA = "0x162D170", Offset = "0x162C370", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000023")]
	internal void Reset(Int32[] textContentMarks, int endMarkPos) { }

	[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000022")]
	internal void set_StartOffset(int value) { }

}

