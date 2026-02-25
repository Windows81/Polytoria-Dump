namespace UnityEngine.Rendering;

[Token(Token = "0x20002DA")]
public struct BatchFilterSettings
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000873")]
	public uint renderingLayerMask; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000874")]
	public int rendererPriority; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000875")]
	private ulong m_sceneCullingMask; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000876")]
	public byte layer; //Field offset: 0x10
	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x4000877")]
	private byte m_batchLayer; //Field offset: 0x11
	[FieldOffset(Offset = "0x12")]
	[Token(Token = "0x4000878")]
	private byte m_motionMode; //Field offset: 0x12
	[FieldOffset(Offset = "0x13")]
	[Token(Token = "0x4000879")]
	private byte m_shadowMode; //Field offset: 0x13
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400087A")]
	private byte m_receiveShadows; //Field offset: 0x14
	[FieldOffset(Offset = "0x15")]
	[Token(Token = "0x400087B")]
	private byte m_staticShadowCaster; //Field offset: 0x15
	[FieldOffset(Offset = "0x16")]
	[Token(Token = "0x400087C")]
	private byte m_allDepthSorted; //Field offset: 0x16
	[FieldOffset(Offset = "0x17")]
	[Token(Token = "0x400087D")]
	private byte m_isSceneCullingMaskSet; //Field offset: 0x17

}

