namespace GLTFast.Schema;

[Token(Token = "0x200008C")]
public abstract class BufferViewBase : NamedObject, IBufferView
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000237")]
	public int buffer; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000238")]
	public int byteOffset; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000239")]
	public int byteLength; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400023A")]
	public int byteStride; //Field offset: 0x24

	[Token(Token = "0x17000038")]
	public override int Buffer
	{
		[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001C9")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700003A")]
	public override int ByteLength
	{
		[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001CB")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000039")]
	public override int ByteOffset
	{
		[Address(RVA = "0x3893F0", Offset = "0x3885F0", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001CA")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x1073450", Offset = "0x1072650", Length = "0xE")]
	[CalledBy(Type = typeof(BufferViewBase`1), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60001CC")]
	protected BufferViewBase() { }

	[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001C9")]
	public override int get_Buffer() { }

	[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001CB")]
	public override int get_ByteLength() { }

	[Address(RVA = "0x3893F0", Offset = "0x3885F0", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001CA")]
	public override int get_ByteOffset() { }

}

