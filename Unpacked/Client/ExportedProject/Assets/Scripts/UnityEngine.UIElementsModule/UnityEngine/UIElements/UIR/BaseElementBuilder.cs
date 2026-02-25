namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000549")]
internal abstract class BaseElementBuilder
{

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600262F")]
	protected BaseElementBuilder() { }

	[Address(RVA = "0x1B5E840", Offset = "0x1B5DA40", Length = "0x33")]
	[CalledBy(Type = typeof(VisualChangesProcessor), Member = "DepthFirstOnVisualsChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData), typeof(uint), typeof(bool), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseElementBuilder), Member = "BuildStandardElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseElementBuilder), Member = "BuildRenderTreeQuadElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002625")]
	public void Build(MeshGenerationContext mgc) { }

	[Address(RVA = "0x1B5DBA0", Offset = "0x1B5CDA0", Length = "0x78D")]
	[CalledBy(Type = typeof(BaseElementBuilder), Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181B5C390")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MeshGenerationContext), Member = "AllocateTempMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vertex)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeSlice`1<System.UInt16>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ushort)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EntryRecorder), Member = "DrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), typeof(Unity.Collections.NativeSlice`1<System.UInt16>), typeof(TextureId), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EntryPool), Member = "Get", ReturnType = typeof(Entry))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002626")]
	private void BuildRenderTreeQuadElement(MeshGenerationContext mgc) { }

	[Address(RVA = "0x1B5E330", Offset = "0x1B5D530", Length = "0x505")]
	[CalledBy(Type = typeof(BaseElementBuilder), Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EntryPool), Member = "Get", ReturnType = typeof(Entry))]
	[Calls(Type = typeof(VisualElement), Member = "InvokeGenerateVisualContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_areAncestorsAndSelfDisplayed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181B5C390")]
	[Calls(Type = typeof(VisualElement), Member = "get_defaultMaterial", ReturnType = typeof(Material))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(VisualElement), Member = "get_visible", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseElementBuilder), Member = "PushVisualElementClipping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002627")]
	private void BuildStandardElement(MeshGenerationContext mgc) { }

	[Token(Token = "0x6002628")]
	protected abstract void DrawVisualElementBackground(MeshGenerationContext mgc) { }

	[Token(Token = "0x6002629")]
	protected abstract void DrawVisualElementBorder(MeshGenerationContext mgc) { }

	[Token(Token = "0x600262A")]
	protected abstract void DrawVisualElementStencilMask(MeshGenerationContext mgc) { }

	[Address(RVA = "0x1B5E880", Offset = "0x1B5DA80", Length = "0xF6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "InvokeGenerateVisualContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600262E")]
	private static void InvokeGenerateVisualContent(MeshGenerationContext mgc) { }

	[Address(RVA = "0x1B5E980", Offset = "0x1B5DB80", Length = "0xF1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EntryPool), Member = "Get", ReturnType = typeof(Entry))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181B5C390")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600262D")]
	private static void PopVisualElementClipping(MeshGenerationContext mgc) { }

	[Address(RVA = "0x1B5EA80", Offset = "0x1B5DC80", Length = "0x156")]
	[CalledBy(Type = typeof(BaseElementBuilder), Member = "BuildStandardElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(EntryPool), Member = "Get", ReturnType = typeof(Entry))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181B5C390")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600262C")]
	private void PushVisualElementClipping(MeshGenerationContext mgc) { }

	[Token(Token = "0x6002624")]
	public abstract bool RequiresStencilMask(VisualElement ve) { }

	[Token(Token = "0x600262B")]
	public abstract void ScheduleMeshGenerationJobs(MeshGenerationContext mgc) { }

}

