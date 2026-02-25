namespace UnityEngineInternal.Input;

[Token(Token = "0x2000003")]
internal struct NativeInputEventBuffer
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000001")]
	public Void* eventBuffer; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000002")]
	public int eventCount; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000003")]
	public int sizeInBytes; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000004")]
	public int capacityInBytes; //Field offset: 0x10

}

