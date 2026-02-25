namespace UnityEngine.Rendering;

[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
[Token(Token = "0x20002E0")]
[UsedByNativeCode]
internal struct BatchRendererCullingOutput
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008A9")]
	public JobHandle cullingJobsFence; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40008AA")]
	public Matrix4x4 localToWorldMatrix; //Field offset: 0x10
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40008AB")]
	public Plane* cullingPlanes; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40008AC")]
	public int cullingPlaneCount; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x40008AD")]
	public int receiverPlaneOffset; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40008AE")]
	public int receiverPlaneCount; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40008AF")]
	public CullingSplit* cullingSplits; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40008B0")]
	public int cullingSplitCount; //Field offset: 0x70
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x40008B1")]
	public BatchCullingViewType viewType; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40008B2")]
	public BatchCullingProjectionType projectionType; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x40008B3")]
	public BatchCullingFlags cullingFlags; //Field offset: 0x7C
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40008B4")]
	public ulong viewID; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40008B5")]
	public uint cullingLayerMask; //Field offset: 0x88
	[FieldOffset(Offset = "0x8C")]
	[Token(Token = "0x40008B6")]
	public byte splitExclusionMask; //Field offset: 0x8C
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40008B7")]
	public ulong sceneCullingMask; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40008B8")]
	public BatchCullingOutputDrawCommands* drawCommands; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40008B9")]
	public uint brgId; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40008BA")]
	public IntPtr occlusionBuffer; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40008BB")]
	public IntPtr customCullingResult; //Field offset: 0xB0

}

