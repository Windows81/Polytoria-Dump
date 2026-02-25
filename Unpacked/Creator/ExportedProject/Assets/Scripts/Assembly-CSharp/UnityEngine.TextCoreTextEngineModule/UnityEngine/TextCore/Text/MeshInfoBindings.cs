namespace UnityEngine.TextCore.Text;

[NativeHeader("Modules/TextCoreTextEngine/Native/IMGUI/MeshInfo.h")]
[Token(Token = "0x2000026")]
[UsedByNativeCode("MeshInfo")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule"})]
internal struct MeshInfoBindings
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000C4")]
	public TextCoreVertex[] vertexData; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000C5")]
	public Material material; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000C6")]
	public int vertexCount; //Field offset: 0x10

}

