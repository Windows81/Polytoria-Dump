namespace UnityEngine.Rendering;

[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
[Token(Token = "0x20002DE")]
[UsedByNativeCode]
public struct BatchCullingContext
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000898")]
	public readonly NativeArray<Plane> cullingPlanes; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000899")]
	public readonly NativeArray<CullingSplit> cullingSplits; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400089A")]
	public readonly LODParameters lodParameters; //Field offset: 0x20
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400089B")]
	public readonly Matrix4x4 localToWorldMatrix; //Field offset: 0x3C
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x400089C")]
	public readonly BatchCullingViewType viewType; //Field offset: 0x7C
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400089D")]
	public readonly BatchCullingProjectionType projectionType; //Field offset: 0x80
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x400089E")]
	public readonly BatchCullingFlags cullingFlags; //Field offset: 0x84
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400089F")]
	public readonly BatchPackedCullingViewID viewID; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40008A0")]
	public readonly uint cullingLayerMask; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40008A1")]
	public readonly ulong sceneCullingMask; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40008A2")]
	public readonly ushort splitExclusionMask; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA2")]
	[Obsolete("BatchCullingContext.isOrthographic is deprecated. Use BatchCullingContext.projectionType instead.")]
	[Token(Token = "0x40008A3")]
	public readonly byte isOrthographic; //Field offset: 0xA2
	[FieldOffset(Offset = "0xA4")]
	[Token(Token = "0x40008A4")]
	public readonly int receiverPlaneOffset; //Field offset: 0xA4
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40008A5")]
	public readonly int receiverPlaneCount; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40008A6")]
	internal readonly IntPtr occlusionBuffer; //Field offset: 0xB0

	[Address(RVA = "0x197AE60", Offset = "0x197A060", Length = "0xBD")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000E23")]
	internal BatchCullingContext(NativeArray<Plane> inCullingPlanes, NativeArray<CullingSplit> inCullingSplits, LODParameters inLodParameters, Matrix4x4 inLocalToWorldMatrix, BatchCullingViewType inViewType, BatchCullingProjectionType inProjectionType, BatchCullingFlags inBatchCullingFlags, ulong inViewID, uint inCullingLayerMask, ulong inSceneCullingMask, byte inExclusionSplitMask, int inReceiverPlaneOffset, int inReceiverPlaneCount, IntPtr inOcclusionBuffer) { }

}

