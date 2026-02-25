namespace UnityEngine.Rendering;

[Token(Token = "0x20002F2")]
internal struct GPUDrivenRendererGroupData
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000900")]
	public NativeArray<Int32> rendererGroupID; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000901")]
	public NativeArray<Bounds> localBounds; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000902")]
	public NativeArray<Vector4> lightmapScaleOffset; //Field offset: 0x20
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000903")]
	public NativeArray<Int32> gameObjectLayer; //Field offset: 0x30
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000904")]
	public NativeArray<UInt32> renderingLayerMask; //Field offset: 0x40
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000905")]
	public NativeArray<Int32> lodGroupID; //Field offset: 0x50
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000906")]
	public NativeArray<Int32> lightmapIndex; //Field offset: 0x60
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000907")]
	public NativeArray<GPUDrivenPackedRendererData> packedRendererData; //Field offset: 0x70
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000908")]
	public NativeArray<Int32> rendererPriority; //Field offset: 0x80
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000909")]
	public NativeArray<Int32> meshIndex; //Field offset: 0x90
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400090A")]
	public NativeArray<Int16> subMeshStartIndex; //Field offset: 0xA0
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x400090B")]
	public NativeArray<Int32> materialsOffset; //Field offset: 0xB0
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x400090C")]
	public NativeArray<Int16> materialsCount; //Field offset: 0xC0
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x400090D")]
	public NativeArray<Int32> instancesOffset; //Field offset: 0xD0
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x400090E")]
	public NativeArray<Int32> instancesCount; //Field offset: 0xE0
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x400090F")]
	public NativeArray<GPUDrivenRendererEditorData> editorData; //Field offset: 0xF0
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4000910")]
	public NativeArray<GPUDrivenRendererMeshLodData> meshLodData; //Field offset: 0x100
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4000911")]
	public NativeArray<Int32> invalidRendererGroupID; //Field offset: 0x110
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4000912")]
	public NativeArray<Matrix4x4> localToWorldMatrix; //Field offset: 0x120
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4000913")]
	public NativeArray<Matrix4x4> prevLocalToWorldMatrix; //Field offset: 0x130
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x4000914")]
	public NativeArray<Int32> rendererGroupIndex; //Field offset: 0x140
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x4000915")]
	public NativeArray<Int32> meshID; //Field offset: 0x150
	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x4000916")]
	public NativeArray<GPUDrivenMeshLodInfo> meshLodInfo; //Field offset: 0x160
	[FieldOffset(Offset = "0x170")]
	[Token(Token = "0x4000917")]
	public NativeArray<Int16> subMeshCount; //Field offset: 0x170
	[FieldOffset(Offset = "0x180")]
	[Token(Token = "0x4000918")]
	public NativeArray<Int32> subMeshDescOffset; //Field offset: 0x180
	[FieldOffset(Offset = "0x190")]
	[Token(Token = "0x4000919")]
	public NativeArray<SubMeshDescriptor> subMeshDesc; //Field offset: 0x190
	[FieldOffset(Offset = "0x1A0")]
	[Token(Token = "0x400091A")]
	public NativeArray<Int32> materialIndex; //Field offset: 0x1A0
	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x400091B")]
	public NativeArray<Int32> materialID; //Field offset: 0x1B0
	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x400091C")]
	public NativeArray<GPUDrivenPackedMaterialData> packedMaterialData; //Field offset: 0x1C0
	[FieldOffset(Offset = "0x1D0")]
	[Token(Token = "0x400091D")]
	public NativeArray<Int32> materialFilterFlags; //Field offset: 0x1D0

}

