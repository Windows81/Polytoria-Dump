namespace UnityEngine.UIElements;

[Token(Token = "0x2000477")]
internal class ATGTextJobSystem
{
	[CompilerGenerated]
	[Token(Token = "0x200047A")]
	private sealed class <>c
	{
		[Token(Token = "0x4000EF6")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x1B37480", Offset = "0x1B36680", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600217E")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600217F")]
		public <>c() { }

		[Address(RVA = "0x1B37320", Offset = "0x1B36520", Length = "0x44")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002180")]
		internal ManagedJobData <.cctor>b__21_0() { }

		[Address(RVA = "0x1B37370", Offset = "0x1B36570", Length = "0x25")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002181")]
		internal void <.cctor>b__21_1(ManagedJobData inst) { }

	}

	[Token(Token = "0x2000479")]
	private struct GenerateTextJobData : IJobParallelFor
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000EF5")]
		public GCHandle managedJobDataHandle; //Field offset: 0x0

		[Address(RVA = "0x1B26A80", Offset = "0x1B25C80", Length = "0x1B5")]
		[CalledBy(Type = typeof(ATGTextJobSystem), Member = "GenerateTextJobified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext), typeof(object)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ComputedStyle), Member = "get_unityFontDefinition", ReturnType = typeof(FontDefinition))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18038DB40")]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(UITKTextHandle), Member = "CacheTextGenerationInfo", ReturnType = typeof(void))]
		[Calls(Type = typeof(UITKTextHandle), Member = "UpdateNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(System.ValueTuple`2<UnityEngine.TextCore.Text.NativeTextInfo, System.Boolean>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600217D")]
		public override void Execute(int index) { }

	}

	[Token(Token = "0x2000478")]
	private class ManagedJobData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000EF1")]
		public TextElement textElement; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000EF2")]
		public MeshGenerationNode node; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000EF3")]
		public NativeTextInfo textInfo; //Field offset: 0x20
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000EF4")]
		public bool success; //Field offset: 0x38

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600217C")]
		public ManagedJobData() { }

		[Address(RVA = "0x1B26CB0", Offset = "0x1B25EB0", Length = "0x18C")]
		[CalledBy(Type = typeof(ATGTextJobSystem), Member = "AddDrawEntries", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext), typeof(object)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(ObjectPool`1), Member = "get_CountInactive", ReturnType = typeof(int))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x600217B")]
		public void Release() { }

	}

	[Token(Token = "0x4000EE6")]
	private static ObjectPool<ManagedJobData> s_JobDataPool; //Field offset: 0x0
	[Token(Token = "0x4000EE9")]
	private static readonly ProfilerMarker k_GenerateTextMarker; //Field offset: 0x8
	[Token(Token = "0x4000EEA")]
	private static readonly ProfilerMarker k_ATGTextJobMarker; //Field offset: 0x10
	[Token(Token = "0x4000EEB")]
	private static readonly bool k_IsMultiThreaded; //Field offset: 0x18
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000EE3")]
	private GCHandle textJobDatasHandle; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000EE4")]
	private List<ManagedJobData> textJobDatas; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000EE5")]
	private bool hasPendingTextWork; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000EE7")]
	internal MeshGenerationCallback m_GenerateTextJobifiedCallback; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000EE8")]
	internal MeshGenerationCallback m_AddDrawEntriesCallback; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000EEC")]
	private List<Texture2D> atlases; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000EED")]
	private List<Single> sdfScalesArray; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000EEE")]
	private List<NativeSlice`1<Vertex>> verticesArray; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000EEF")]
	private List<NativeSlice`1<UInt16>> indicesArray; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000EF0")]
	private List<GlyphRenderMode> renderModes; //Field offset: 0x58

	[Address(RVA = "0x1B26600", Offset = "0x1B25800", Length = "0x208")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ObjectPool`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>", "System.Action`1<T>", "System.Action`1<T>", "System.Action`1<T>", typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600217A")]
	private static ATGTextJobSystem() { }

	[Address(RVA = "0x1B26810", Offset = "0x1B25A10", Length = "0x265")]
	[CalledBy(Type = typeof(TextJobSystem), Member = "GenerateText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext), typeof(TextElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 9)]
	[Token(Token = "0x6002175")]
	public ATGTextJobSystem() { }

	[Address(RVA = "0x1B25170", Offset = "0x1B24370", Length = "0x4FB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GlyphsEnumerable), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextElement), typeof(System.Collections.Generic.List`1<Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>>), typeof(ATGMeshInfo[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(ManagedJobData), Member = "Release", ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshGenerationContext), Member = "End", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextElement), Member = "OnGenerateTextOverNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801D8DF0")]
	[Calls(Type = typeof(MeshGenerationContext), Member = "Begin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(VisualElement), typeof(RenderData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181B23730")]
	[Calls(Type = typeof(ATGTextJobSystem), Member = "ConvertMeshInfoToUIRVertex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ATGMeshInfo[]), typeof(TempMeshAllocator), typeof(TextElement), typeof(System.Collections.Generic.List`1<UnityEngine.Texture2D>), typeof(System.Collections.Generic.List`1<Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>>), typeof(System.Collections.Generic.List`1<Unity.Collections.NativeSlice`1<System.UInt16>>), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.LowLevel.GlyphRenderMode>), typeof(System.Collections.Generic.List`1<System.Single>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshGenerationContext), Member = "GetTempMeshAllocator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TempMeshAllocator&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "UpdateFontAssetsInUpdateQueue", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UITKTextHandle), Member = "UpdateATGTextEventHandler", ReturnType = typeof(void))]
	[Calls(Type = typeof(UITKTextHandle), Member = "ProcessMeshInfos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.NativeTextInfo"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002178")]
	private void AddDrawEntries(MeshGenerationContext mgc, object _) { }

	[Address(RVA = "0x1B25670", Offset = "0x1B24870", Length = "0x9BC")]
	[CalledBy(Type = typeof(ATGTextJobSystem), Member = "AddDrawEntries", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Texture2D), Member = "get_format", ReturnType = typeof(TextureFormat))]
	[Calls(Type = typeof(Unity.Collections.NativeSlice`1<System.UInt16>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ushort)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vertex)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshGenerator), Member = "ConvertTextVertexToUIRVertex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextCoreVertex&), typeof(Vector2), typeof(float), typeof(bool), typeof(bool)}, ReturnType = typeof(Vertex))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801D8C40")]
	[Calls(Type = typeof(VisualElement), Member = "get_contentRect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(TempMeshAllocator), Member = "AllocateTempMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderEvents), Member = "NeedsTextCoreSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderEvents), Member = "NeedsColorID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001F7C0")]
	[Calls(Type = "UnityEngine.TextCore.Text.TextGeneratorUtilities", Member = "IsBitmapRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphRenderMode)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009740")]
	[Calls(Type = typeof(FontAsset), Member = "get_atlasRenderMode", ReturnType = typeof(GlyphRenderMode))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "get_scaledPixelsPerPoint", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002179")]
	private static void ConvertMeshInfoToUIRVertex(ATGMeshInfo[] meshInfos, TempMeshAllocator alloc, TextElement visualElement, List<Texture2D> atlases, List<NativeSlice`1<Vertex>> verticesArray, List<NativeSlice`1<UInt16>> indicesArray, List<GlyphRenderMode> renderModes, List<Single> sdfScales) { }

	[Address(RVA = "0x1B26370", Offset = "0x1B25570", Length = "0x288")]
	[CalledBy(Type = typeof(TextJobSystem), Member = "GenerateText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext), typeof(TextElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MeshGenerationContext), Member = "InsertMeshGenerationNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationNode&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(MeshGenerationContext), Member = "AddMeshGenerationCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationCallback), typeof(object), typeof(MeshGenerationCallbackType), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6002176")]
	public void GenerateText(MeshGenerationContext mgc, TextElement textElement) { }

	[Address(RVA = "0x1B26030", Offset = "0x1B25230", Length = "0x33E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FontAsset), Member = "EnsureNativeFontAssetIsCreated", ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshGenerationContext), Member = "AddMeshGenerationCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationCallback), typeof(object), typeof(MeshGenerationCallbackType), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GenerateTextJobData), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UITKTextHandle), Member = "ConvertUssToNativeTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unityFontDefinition", ReturnType = typeof(FontDefinition))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(TextSettings), Member = "UpdateNativeTextSettings", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextUtilities), Member = "GetTextSettingsFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(TextSettings))]
	[Calls(Type = typeof(TextUtilities), Member = "GetFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(FontAsset))]
	[Calls(Type = typeof(FontAsset), Member = "CreateHbFaceIfNeeded", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UITKTextHandle), Member = "InitTextLib", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ManagedJobExtension), Member = "ScheduleOrRunJob", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GenerateTextJobData)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GenerateTextJobData), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(MeshGenerationContext), Member = "AddMeshGenerationJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobHandle)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6002177")]
	private void GenerateTextJobified(MeshGenerationContext mgc, object _) { }

}

