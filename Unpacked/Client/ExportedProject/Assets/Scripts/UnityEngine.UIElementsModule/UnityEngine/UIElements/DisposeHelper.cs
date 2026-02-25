namespace UnityEngine.UIElements;

[Token(Token = "0x2000180")]
internal class DisposeHelper
{

	[Address(RVA = "0x1C321D0", Offset = "0x1C313D0", Length = "0xAD")]
	[CalledBy(Type = typeof(ShaderInfoStorage`1), Member = "UpdateTexture", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VectorImageManager), Member = "AddUser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VectorImage), typeof(VisualElement)}, ReturnType = typeof(GradientRemap))]
	[CalledBy(Type = typeof(VectorImageManager), Member = "Commit", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextureBlitter), Member = "Commit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextureBlitter), Member = "BlitOneNow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture), typeof(Texture), typeof(RectInt), typeof(Vector2Int), typeof(bool), typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextureBlitter), Member = "QueueBlit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture), typeof(RectInt), typeof(Vector2Int), typeof(bool), typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TempMeshAllocatorImpl), Member = "AllocateTempMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ShaderInfoStorage`1), Member = "AllocateRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(RectInt&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(GradientSettingsAtlas), Member = "Commit", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ShaderInfoStorage`1), Member = "SetTexel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GradientSettingsAtlas), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Alloc))]
	[CalledBy(Type = typeof(GradientSettingsAtlas), Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GradientSettingsAtlas), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MeshGenerationNodeManager), Member = "CreateImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(bool)}, ReturnType = typeof(MeshGenerationNodeImpl))]
	[CalledBy(Type = typeof(DynamicAtlasPage), Member = "Commit", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicAtlasPage), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Alloc2D)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicAtlasPage), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(RectInt)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicAtlasPage), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Alloc2D&), typeof(RectInt&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(GradientSettingsAtlas), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Alloc), typeof(GradientSettings[]), typeof(GradientRemap)}, ReturnType = typeof(void))]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000B6D")]
	public static void NotifyDisposedUsed(IDisposable disposable) { }

}

