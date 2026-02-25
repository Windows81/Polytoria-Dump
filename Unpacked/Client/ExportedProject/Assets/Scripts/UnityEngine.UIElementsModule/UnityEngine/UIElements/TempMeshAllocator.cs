namespace UnityEngine.UIElements;

[NativeContainer]
[NativeContainerIsReadOnly]
[Token(Token = "0x20002D3")]
public struct TempMeshAllocator
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B76")]
	private GCHandle m_Handle; //Field offset: 0x0

	[Address(RVA = "0x1C8E000", Offset = "0x1C8D200", Length = "0xF2")]
	[CalledBy(Type = typeof(ATGTextJobSystem), Member = "ConvertMeshInfoToUIRVertex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ATGMeshInfo[]), typeof(TempMeshAllocator), typeof(TextElement), typeof(System.Collections.Generic.List`1<UnityEngine.Texture2D>), typeof(System.Collections.Generic.List`1<Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>>), typeof(System.Collections.Generic.List`1<Unity.Collections.NativeSlice`1<System.UInt16>>), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.LowLevel.GlyphRenderMode>), typeof(System.Collections.Generic.List`1<System.Single>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITKTextJobSystem), Member = "ConvertMeshInfoToUIRVertex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshInfo[]), typeof(TempMeshAllocator), typeof(TextElement), typeof(List`1<Material>&), typeof(List`1<NativeSlice`1<Vertex>>&), typeof(List`1<NativeSlice`1<UInt16>>&), typeof(List`1<GlyphRenderMode>&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator+TessellationJob", Member = "DrawBorder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeMeshGenerationNode), typeof(BorderParams&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator+TessellationJob", Member = "DrawRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeMeshGenerationNode), typeof(NativeRectParams&), typeof(Texture)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator+TessellationJob", Member = "DrawSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeMeshGenerationNode), typeof(NativeRectParams&), typeof(Sprite)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator+TessellationJob", Member = "DrawVectorImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeMeshGenerationNode), typeof(NativeRectParams&), typeof(VectorImage)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18038DB40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TempMeshAllocatorImpl), Member = "AllocateTempMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60013B6")]
	public void AllocateTempMesh(int vertexCount, int indexCount, out NativeSlice<Vertex>& vertices, out NativeSlice<UInt16>& indices) { }

	[Address(RVA = "0x1C890F0", Offset = "0x1C882F0", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60013B5")]
	internal static void Create(GCHandle handle, out TempMeshAllocator allocator) { }

}

