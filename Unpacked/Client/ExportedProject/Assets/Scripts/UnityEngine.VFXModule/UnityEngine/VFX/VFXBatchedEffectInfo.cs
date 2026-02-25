namespace UnityEngine.VFX;

[RequiredByNativeCode]
[Token(Token = "0x2000006")]
public struct VFXBatchedEffectInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000008")]
	public VisualEffectAsset vfxAsset; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000009")]
	public uint activeBatchCount; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400000A")]
	public uint inactiveBatchCount; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400000B")]
	public uint activeInstanceCount; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400000C")]
	public uint unbatchedInstanceCount; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400000D")]
	public uint totalInstanceCapacity; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400000E")]
	public uint maxInstancePerBatchCapacity; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400000F")]
	public ulong totalGPUSizeInBytes; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000010")]
	public ulong totalCPUSizeInBytes; //Field offset: 0x28

}

