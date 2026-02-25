namespace UnityEngine.TextCore.Text;

[NativeHeader("Modules/TextCoreTextEngine/Native/TextInfo.h")]
[Token(Token = "0x2000029")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule", "UnityEngine.IMGUIModule"})]
internal struct NativeTextInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000D2")]
	public ATGMeshInfo[] meshInfos; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000D3")]
	public int totalWidth; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40000D4")]
	public int totalHeight; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000D5")]
	public bool isElided; //Field offset: 0x10

}

