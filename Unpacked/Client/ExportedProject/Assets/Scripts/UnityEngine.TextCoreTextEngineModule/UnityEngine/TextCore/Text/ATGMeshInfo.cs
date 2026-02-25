namespace UnityEngine.TextCore.Text;

[NativeHeader("Modules/TextCoreTextEngine/Native/ATGMeshInfo.h")]
[Token(Token = "0x2000016")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
internal struct ATGMeshInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000074")]
	public NativeTextElementInfo[] textElementInfos; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000075")]
	public int fontAssetId; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000076")]
	public int textElementCount; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Ignore]
	[Token(Token = "0x4000077")]
	public FontAsset fontAsset; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Ignore]
	[Token(Token = "0x4000078")]
	public List<List`1<Int32>> textElementInfoIndicesByAtlas; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Ignore]
	[Token(Token = "0x4000079")]
	public bool hasMultipleColors; //Field offset: 0x20

}

