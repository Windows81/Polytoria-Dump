namespace UnityEngine.TextCore.Text;

[NativeHeader("Modules/TextCoreTextEngine/Native/TextElementInfo.h")]
[Token(Token = "0x2000028")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule", "UnityEngine.IMGUIModule"})]
internal struct NativeTextElementInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000CD")]
	public int glyphID; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40000CE")]
	public TextCoreVertex bottomLeft; //Field offset: 0x4
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40000CF")]
	public TextCoreVertex topLeft; //Field offset: 0x24
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40000D0")]
	public TextCoreVertex topRight; //Field offset: 0x44
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x40000D1")]
	public TextCoreVertex bottomRight; //Field offset: 0x64

}

