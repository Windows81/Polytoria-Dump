namespace UnityEngine.TextCore.Text;

[Token(Token = "0x2000027")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
internal struct MeshInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000C7")]
	public int vertexCount; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000C8")]
	public TextCoreVertex[] vertexData; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000C9")]
	public Material material; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Ignore]
	[Token(Token = "0x40000CA")]
	public int vertexBufferSize; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Ignore]
	[Token(Token = "0x40000CB")]
	public bool applySDF; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000CC")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal GlyphRenderMode glyphRenderMode; //Field offset: 0x20

	[Address(RVA = "0x1A35B30", Offset = "0x1A34D30", Length = "0xAE")]
	[CalledBy(Type = typeof(TextGenerator), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Token(Token = "0x6000066")]
	public MeshInfo(int size, bool isIMGUI) { }

	[Address(RVA = "0x1A35A70", Offset = "0x1A34C70", Length = "0x46")]
	[CalledBy(Type = typeof(TextGenerator), Member = "LayoutPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextInfo), Member = "ClearMeshInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000068")]
	internal void Clear(bool uploadChanges) { }

	[Address(RVA = "0x1A35A20", Offset = "0x1A34C20", Length = "0x46")]
	[CalledBy(Type = typeof(TextGenerator), Member = "GenerateTextMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000069")]
	internal void ClearUnusedVertices() { }

	[Address(RVA = "0x1A35AC0", Offset = "0x1A34CC0", Length = "0x6C")]
	[CalledBy(Type = typeof(TextGenerator), Member = "DrawUnderlineMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), typeof(float), typeof(float), typeof(float), typeof(Color32), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "DrawTextHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Color32), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextGeneratorUtilities), Member = "FillCharacterVertexBuffers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000067")]
	internal void ResizeMeshInfo(int size, bool isIMGUI) { }

}

