namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000569")]
internal class EntryRecorder
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001294")]
	private EntryPool m_EntryPool; //Field offset: 0x10

	[Address(RVA = "0x1B81D90", Offset = "0x1B80F90", Length = "0x72")]
	[CalledBy(Type = typeof(RenderTreeManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60026C1")]
	public EntryRecorder(EntryPool entryPool) { }

	[Address(RVA = "0x1B814F0", Offset = "0x1B806F0", Length = "0xCA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60026D7")]
	private static void Append(Entry parentEntry, Entry entry) { }

	[Address(RVA = "0x1B81310", Offset = "0x1B80510", Length = "0x1D3")]
	[CalledBy(Type = typeof(EntryRecorder), Member = "DrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), typeof(Unity.Collections.NativeSlice`1<System.UInt16>), typeof(Texture), typeof(TextureOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EntryRecorder), Member = "DrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), typeof(Unity.Collections.NativeSlice`1<System.UInt16>), typeof(TextureId), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EntryRecorder), Member = "DrawRasterText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), typeof(Unity.Collections.NativeSlice`1<System.UInt16>), typeof(Texture), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EntryRecorder), Member = "DrawSdfText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), typeof(Unity.Collections.NativeSlice`1<System.UInt16>), typeof(Texture), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EntryRecorder), Member = "DrawGradients", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), typeof(Unity.Collections.NativeSlice`1<System.UInt16>), typeof(VectorImage)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MeshGenerator), Member = "MakeText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture), typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), typeof(Unity.Collections.NativeSlice`1<System.UInt16>), typeof(bool), typeof(float), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181B5C390")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x60026D6")]
	private static void AppendMeshEntry(Entry parentEntry, Entry entry) { }

	[Address(RVA = "0x1B815C0", Offset = "0x1B807C0", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EntryPool), Member = "Get", ReturnType = typeof(Entry))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181B5C390")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026C9")]
	public void BeginStencilMask(Entry parentEntry) { }

	[Address(RVA = "0x1B81600", Offset = "0x1B80800", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EntryPool), Member = "Get", ReturnType = typeof(Entry))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181B5C390")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026D4")]
	public void CutRenderChain(Entry parentEntry) { }

	[Address(RVA = "0x1B81640", Offset = "0x1B80840", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EntryPool), Member = "Get", ReturnType = typeof(Entry))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181B5C390")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026C8")]
	public void DrawChildren(Entry parentEntry) { }

	[Address(RVA = "0x1B81680", Offset = "0x1B80880", Length = "0x82")]
	[CalledBy(Type = typeof(UnsafeMeshGenerationNode), Member = "DrawGradientsInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), typeof(Unity.Collections.NativeSlice`1<System.UInt16>), typeof(VectorImage)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MeshGenerationNodeImpl), Member = "DrawGradients", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), typeof(Unity.Collections.NativeSlice`1<System.UInt16>), typeof(VectorImage)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(EntryPool), Member = "Get", ReturnType = typeof(Entry))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(EntryRecorder), Member = "AppendMeshEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(Entry)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026C6")]
	public void DrawGradients(Entry parentEntry, NativeSlice<Vertex> vertices, NativeSlice<UInt16> indices, VectorImage gradientsOwner) { }

	[Address(RVA = "0x1B81710", Offset = "0x1B80910", Length = "0x75")]
	[CalledBy(Type = typeof(IMGUIContainer), Member = "OnGenerateVisualContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EntryPool), Member = "Get", ReturnType = typeof(Entry))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181B5C390")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026C7")]
	public void DrawImmediate(Entry parentEntry, Action callback, bool cullingEnabled) { }

	[Address(RVA = "0x1B81850", Offset = "0x1B80A50", Length = "0xFC")]
	[CalledBy(Type = typeof(BaseElementBuilder), Member = "BuildRenderTreeQuadElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TextureId), Member = "IsValid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EntryPool), Member = "Get", ReturnType = typeof(Entry))]
	[Calls(Type = typeof(EntryRecorder), Member = "AppendMeshEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(Entry)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026C3")]
	public void DrawMesh(Entry parentEntry, NativeSlice<Vertex> vertices, NativeSlice<UInt16> indices, TextureId textureId, bool isPremultiplied = false) { }

	[Address(RVA = "0x1B81790", Offset = "0x1B80990", Length = "0xB2")]
	[CalledBy(Type = typeof(UnsafeMeshGenerationNode), Member = "DrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), typeof(Unity.Collections.NativeSlice`1<System.UInt16>), typeof(Texture)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnsafeMeshGenerationNode), Member = "DrawMeshInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), typeof(Unity.Collections.NativeSlice`1<System.UInt16>), typeof(Texture), typeof(TextureOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MeshGenerationNodeImpl), Member = "DrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), typeof(Unity.Collections.NativeSlice`1<System.UInt16>), typeof(Texture), typeof(TextureOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Painter2D+Painter2DJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(EntryPool), Member = "Get", ReturnType = typeof(Entry))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(EntryRecorder), Member = "AppendMeshEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(Entry)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026C2")]
	public void DrawMesh(Entry parentEntry, NativeSlice<Vertex> vertices, NativeSlice<UInt16> indices, Texture texture, TextureOptions textureOptions = 0) { }

	[Address(RVA = "0x1B81950", Offset = "0x1B80B50", Length = "0x9D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EntryPool), Member = "Get", ReturnType = typeof(Entry))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(EntryRecorder), Member = "AppendMeshEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(Entry)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026C4")]
	public void DrawRasterText(Entry parentEntry, NativeSlice<Vertex> vertices, NativeSlice<UInt16> indices, Texture texture, bool multiChannel) { }

	[Address(RVA = "0x1B819F0", Offset = "0x1B80BF0", Length = "0x99")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EntryPool), Member = "Get", ReturnType = typeof(Entry))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(EntryRecorder), Member = "AppendMeshEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(Entry)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026C5")]
	public void DrawSdfText(Entry parentEntry, NativeSlice<Vertex> vertices, NativeSlice<UInt16> indices, Texture texture, float scale, float sharpness) { }

	[Address(RVA = "0x1B81A90", Offset = "0x1B80C90", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EntryPool), Member = "Get", ReturnType = typeof(Entry))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181B5C390")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026CA")]
	public void EndStencilMask(Entry parentEntry) { }

	[Address(RVA = "0x1B81AD0", Offset = "0x1B80CD0", Length = "0x4C")]
	[CalledBy(Type = typeof(MeshGenerationContext), Member = "InsertMeshGenerationNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationNode&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MeshGenerationContext), Member = "InsertUnsafeMeshGenerationNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeMeshGenerationNode&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(EntryPool), Member = "Get", ReturnType = typeof(Entry))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181B5C390")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026D5")]
	public Entry InsertPlaceholder(Entry parentEntry) { }

	[Address(RVA = "0x1B81B20", Offset = "0x1B80D20", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EntryPool), Member = "Get", ReturnType = typeof(Entry))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181B5C390")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026CD")]
	public void PopClippingRect(Entry parentEntry) { }

	[Address(RVA = "0x1B81B60", Offset = "0x1B80D60", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EntryPool), Member = "Get", ReturnType = typeof(Entry))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181B5C390")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026D3")]
	public void PopDefaultMaterial(Entry parentEntry) { }

	[Address(RVA = "0x1B81BA0", Offset = "0x1B80DA0", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EntryPool), Member = "Get", ReturnType = typeof(Entry))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181B5C390")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026D1")]
	public void PopGroupMatrix(Entry parentEntry) { }

	[Address(RVA = "0x1B81BE0", Offset = "0x1B80DE0", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EntryPool), Member = "Get", ReturnType = typeof(Entry))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181B5C390")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026CF")]
	public void PopScissors(Entry parentEntry) { }

	[Address(RVA = "0x1B81C20", Offset = "0x1B80E20", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EntryPool), Member = "Get", ReturnType = typeof(Entry))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181B5C390")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026CB")]
	public void PopStencilMask(Entry parentEntry) { }

	[Address(RVA = "0x1B81C60", Offset = "0x1B80E60", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EntryPool), Member = "Get", ReturnType = typeof(Entry))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181B5C390")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026CC")]
	public void PushClippingRect(Entry parentEntry) { }

	[Address(RVA = "0x1B81CA0", Offset = "0x1B80EA0", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EntryPool), Member = "Get", ReturnType = typeof(Entry))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181B5C390")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026D2")]
	public void PushDefaultMaterial(Entry parentEntry, Material material) { }

	[Address(RVA = "0x1B81D10", Offset = "0x1B80F10", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EntryPool), Member = "Get", ReturnType = typeof(Entry))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181B5C390")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026D0")]
	public void PushGroupMatrix(Entry parentEntry) { }

	[Address(RVA = "0x1B81D50", Offset = "0x1B80F50", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EntryPool), Member = "Get", ReturnType = typeof(Entry))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181B5C390")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026CE")]
	public void PushScissors(Entry parentEntry) { }

}

