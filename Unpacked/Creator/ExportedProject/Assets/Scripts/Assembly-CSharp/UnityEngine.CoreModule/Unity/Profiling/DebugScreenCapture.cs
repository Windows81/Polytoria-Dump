namespace Unity.Profiling;

[Token(Token = "0x2000023")]
public struct DebugScreenCapture
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400004D")]
	private NativeArray<Byte> <RawImageDataReference>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400004E")]
	private TextureFormat <ImageFormat>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400004F")]
	private int <Width>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000050")]
	private int <Height>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x1700000C")]
	public int Height
	{
		[Address(RVA = "0x2F79C0", Offset = "0x2F6BC0", Length = "0x4")]
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000064")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700000A")]
	public TextureFormat ImageFormat
	{
		[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000062")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000009")]
	public NativeArray<Byte> RawImageDataReference
	{
		[Address(RVA = "0x90E890", Offset = "0x90DA90", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000061")]
		 set { } //Length: 7
	}

	[Token(Token = "0x1700000B")]
	public int Width
	{
		[Address(RVA = "0x369380", Offset = "0x368580", Length = "0x4")]
		[CallerCount(Count = 5)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000063")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x2F79C0", Offset = "0x2F6BC0", Length = "0x4")]
	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000064")]
	public void set_Height(int value) { }

	[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000062")]
	public void set_ImageFormat(TextureFormat value) { }

	[Address(RVA = "0x90E890", Offset = "0x90DA90", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000061")]
	public void set_RawImageDataReference(NativeArray<Byte> value) { }

	[Address(RVA = "0x369380", Offset = "0x368580", Length = "0x4")]
	[CallerCount(Count = 5)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000063")]
	public void set_Width(int value) { }

}

