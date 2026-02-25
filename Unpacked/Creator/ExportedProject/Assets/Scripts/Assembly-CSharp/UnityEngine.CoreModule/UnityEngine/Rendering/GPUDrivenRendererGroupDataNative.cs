namespace UnityEngine.Rendering;

[Token(Token = "0x20002ED")]
[UsedByNativeCode]
internal struct GPUDrivenRendererGroupDataNative
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008C6")]
	public Int32* rendererGroupID; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40008C7")]
	public Bounds* localBounds; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40008C8")]
	public Vector4* lightmapScaleOffset; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40008C9")]
	public Int32* gameObjectLayer; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40008CA")]
	public UInt32* renderingLayerMask; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40008CB")]
	public Int32* lodGroupID; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40008CC")]
	public MotionVectorGenerationMode* motionVecGenMode; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40008CD")]
	public GPUDrivenPackedRendererData* packedRendererData; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40008CE")]
	public Int32* rendererPriority; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40008CF")]
	public Int32* meshIndex; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40008D0")]
	public Int16* subMeshStartIndex; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40008D1")]
	public Int32* materialsOffset; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40008D2")]
	public Int16* materialsCount; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40008D3")]
	public Int32* instancesOffset; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40008D4")]
	public Int32* instancesCount; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40008D5")]
	public GPUDrivenRendererEditorData* editorData; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40008D6")]
	public int rendererGroupCount; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40008D7")]
	public Int32* invalidRendererGroupID; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40008D8")]
	public int invalidRendererGroupIDCount; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40008D9")]
	public GPUDrivenRendererMeshLodData* meshLodData; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40008DA")]
	public Matrix4x4* localToWorldMatrix; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40008DB")]
	public Matrix4x4* prevLocalToWorldMatrix; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40008DC")]
	public Int32* rendererGroupIndex; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40008DD")]
	public int instanceCount; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40008DE")]
	public Int32* meshID; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x40008DF")]
	public GPUDrivenMeshLodInfo* meshLodInfo; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x40008E0")]
	public Int16* subMeshCount; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x40008E1")]
	public Int32* subMeshDescOffset; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x40008E2")]
	public int meshCount; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x40008E3")]
	public SubMeshDescriptor* subMeshDesc; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x40008E4")]
	public int subMeshDescCount; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x40008E5")]
	public Int32* materialIndex; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x40008E6")]
	public int materialIndexCount; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x40008E7")]
	public Int32* materialID; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x40008E8")]
	public GPUDrivenPackedMaterialData* packedMaterialData; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x40008E9")]
	public Int32* materialFilterFlags; //Field offset: 0x118
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x40008EA")]
	public int materialCount; //Field offset: 0x120

}

