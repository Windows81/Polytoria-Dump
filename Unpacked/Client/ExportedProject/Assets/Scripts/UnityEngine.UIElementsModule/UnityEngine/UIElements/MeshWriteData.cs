namespace UnityEngine.UIElements;

[Token(Token = "0x20002C6")]
public class MeshWriteData
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B3C")]
	internal NativeSlice<Vertex> m_Vertices; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B3D")]
	internal NativeSlice<UInt16> m_Indices; //Field offset: 0x20
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000B3E")]
	internal int currentIndex; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000B3F")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal int currentVertex; //Field offset: 0x34

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600134F")]
	internal MeshWriteData() { }

}

