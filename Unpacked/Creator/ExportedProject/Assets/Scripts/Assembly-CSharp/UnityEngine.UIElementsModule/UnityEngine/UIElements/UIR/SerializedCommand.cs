namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000545")]
internal struct SerializedCommand
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001177")]
	public SerializedCommandType type; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4001178")]
	public IntPtr vertexBuffer; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001179")]
	public IntPtr indexBuffer; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400117A")]
	public int firstRange; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400117B")]
	public int rangeCount; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400117C")]
	public int textureName; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400117D")]
	public Texture texture; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400117E")]
	public int gpuDataOffset; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400117F")]
	public Vector4 gpuData0; //Field offset: 0x34
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4001180")]
	public Vector4 gpuData1; //Field offset: 0x44

}

