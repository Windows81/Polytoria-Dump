namespace UnityEngine.Rendering.PostProcessing;

[AddComponentMenu("Rendering/Post-process Layer", 1000)]
[DisallowMultipleComponent]
[ExecuteAlways]
[ImageEffectAllowedInSceneView]
[RequireComponent(typeof(Camera))]
[Token(Token = "0x2000067")]
public sealed class PostProcessLayer : MonoBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x200006A")]
	private sealed class <>c
	{
		[Token(Token = "0x40001C5")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40001C6")]
		public static Func<KeyValuePair`2<Type, PostProcessBundle>, PostProcessBundle> <>9__54_1; //Field offset: 0x8

		[Address(RVA = "0x1856040", Offset = "0x1855240", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000150")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000151")]
		public <>c() { }

		[Address(RVA = "0x1855D30", Offset = "0x1854F30", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000152")]
		internal PostProcessBundle <UpdateBundleSortList>b__54_1(KeyValuePair<Type, PostProcessBundle> kvp) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200006B")]
	private sealed class <>c__DisplayClass54_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001C7")]
		public PostProcessEvent evt; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40001C8")]
		public List<PostProcessBundle> effects; //Field offset: 0x18

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000153")]
		public <>c__DisplayClass54_0() { }

		[Address(RVA = "0x1855D70", Offset = "0x1854F70", Length = "0x72")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000154")]
		internal bool <UpdateBundleSortList>b__0(KeyValuePair<Type, PostProcessBundle> kvp) { }

		[Address(RVA = "0x1855DF0", Offset = "0x1854FF0", Length = "0xDF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(List`1), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Predicate`1<T>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x6000155")]
		internal bool <UpdateBundleSortList>b__2(SerializedBundleRef x) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200006C")]
	private sealed class <>c__DisplayClass54_1
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001C9")]
		public string searchStr; //Field offset: 0x10

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000156")]
		public <>c__DisplayClass54_1() { }

		[Address(RVA = "0x1855ED0", Offset = "0x18550D0", Length = "0x53")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000157")]
		internal bool <UpdateBundleSortList>b__3(PostProcessBundle b) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200006D")]
	private sealed class <>c__DisplayClass54_2
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001CA")]
		public string typeName; //Field offset: 0x10

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000158")]
		public <>c__DisplayClass54_2() { }

		[Address(RVA = "0x1855F30", Offset = "0x1855130", Length = "0x25")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000159")]
		internal bool <UpdateBundleSortList>b__4(SerializedBundleRef b) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200006E")]
	private sealed class <>c__DisplayClass54_3
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001CB")]
		public string typeName; //Field offset: 0x10

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600015A")]
		public <>c__DisplayClass54_3() { }

		[Address(RVA = "0x1855ED0", Offset = "0x18550D0", Length = "0x53")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600015B")]
		internal bool <UpdateBundleSortList>b__5(PostProcessBundle b) { }

	}

	[Token(Token = "0x2000068")]
	internal enum Antialiasing
	{
		None = 0,
		FastApproximateAntialiasing = 1,
		SubpixelMorphologicalAntialiasing = 2,
		TemporalAntialiasing = 3,
	}

	[Token(Token = "0x2000069")]
	internal sealed class SerializedBundleRef
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001C3")]
		public string assemblyQualifiedName; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40001C4")]
		public PostProcessBundle bundle; //Field offset: 0x18

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600014F")]
		public SerializedBundleRef() { }

	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000199")]
	public Transform volumeTrigger; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400019A")]
	public LayerMask volumeLayer; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400019B")]
	public bool stopNaNPropagation; //Field offset: 0x2C
	[FieldOffset(Offset = "0x2D")]
	[Token(Token = "0x400019C")]
	public bool finalBlitToCameraTarget; //Field offset: 0x2D
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400019D")]
	public Antialiasing antialiasingMode; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400019E")]
	public TemporalAntialiasing temporalAntialiasing; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400019F")]
	public SubpixelMorphologicalAntialiasing subpixelMorphologicalAntialiasing; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40001A0")]
	public FastApproximateAntialiasing fastApproximateAntialiasing; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40001A1")]
	public Fog fog; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40001A2")]
	private Dithering dithering; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40001A3")]
	public PostProcessDebugLayer debugLayer; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x40001A4")]
	private PostProcessResources m_Resources; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40001A5")]
	private PostProcessResources m_OldResources; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Preserve]
	[SerializeField]
	[Token(Token = "0x40001A6")]
	private bool m_ShowToolkit; //Field offset: 0x78
	[FieldOffset(Offset = "0x79")]
	[Preserve]
	[SerializeField]
	[Token(Token = "0x40001A7")]
	private bool m_ShowCustomSorter; //Field offset: 0x79
	[FieldOffset(Offset = "0x7A")]
	[Token(Token = "0x40001A8")]
	public bool breakBeforeColorGrading; //Field offset: 0x7A
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	[Token(Token = "0x40001A9")]
	private List<SerializedBundleRef> m_BeforeTransparentBundles; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	[Token(Token = "0x40001AA")]
	private List<SerializedBundleRef> m_BeforeStackBundles; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	[Token(Token = "0x40001AB")]
	private List<SerializedBundleRef> m_AfterStackBundles; //Field offset: 0x90
	[CompilerGenerated]
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40001AC")]
	private Dictionary<PostProcessEvent, List`1<SerializedBundleRef>> <sortedBundles>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40001AD")]
	private DepthTextureMode <cameraDepthFlags>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	[FieldOffset(Offset = "0xA4")]
	[Token(Token = "0x40001AE")]
	private bool <haveBundlesBeenInited>k__BackingField; //Field offset: 0xA4
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40001AF")]
	private Dictionary<Type, PostProcessBundle> m_Bundles; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40001B0")]
	private PropertySheetFactory m_PropertySheetFactory; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40001B1")]
	private CommandBuffer m_LegacyCmdBufferBeforeReflections; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40001B2")]
	private CommandBuffer m_LegacyCmdBufferBeforeLighting; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x40001B3")]
	private CommandBuffer m_LegacyCmdBufferOpaque; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x40001B4")]
	private CommandBuffer m_LegacyCmdBuffer; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x40001B5")]
	private Camera m_Camera; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x40001B6")]
	private PostProcessRenderContext m_CurrentContext; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x40001B7")]
	private LogHistogram m_LogHistogram; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x40001B8")]
	private bool m_SettingsUpdateNeeded; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF1")]
	[Token(Token = "0x40001B9")]
	private bool m_IsRenderingInSceneView; //Field offset: 0xF1
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x40001BA")]
	private TargetPool m_TargetPool; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x40001BB")]
	private bool m_NaNKilled; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x40001BC")]
	private readonly List<PostProcessEffectRenderer> m_ActiveEffects; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x40001BD")]
	private readonly List<RenderTargetIdentifier> m_Targets; //Field offset: 0x110

	[Token(Token = "0x1700000C")]
	public private DepthTextureMode cameraDepthFlags
	{
		[Address(RVA = "0x508E60", Offset = "0x508060", Length = "0x7")]
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000126")]
		 get { } //Length: 7
		[Address(RVA = "0x508F10", Offset = "0x508110", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000127")]
		private set { } //Length: 7
	}

	[Token(Token = "0x1700000D")]
	public private bool haveBundlesBeenInited
	{
		[Address(RVA = "0x508E70", Offset = "0x508070", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000128")]
		 get { } //Length: 8
		[Address(RVA = "0x508F20", Offset = "0x508120", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000129")]
		private set { } //Length: 7
	}

	[Token(Token = "0x1700000B")]
	public private Dictionary<PostProcessEvent, List`1<SerializedBundleRef>> sortedBundles
	{
		[Address(RVA = "0x2DD240", Offset = "0x2DC440", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000124")]
		 get { } //Length: 8
		[Address(RVA = "0x2DD580", Offset = "0x2DC780", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000125")]
		private set { } //Length: 19
	}

	[Address(RVA = "0x184A620", Offset = "0x1849820", Length = "0xD4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x600014E")]
	public PostProcessLayer() { }

	[Address(RVA = "0x1843E00", Offset = "0x1843000", Length = "0x9F")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderBuiltins", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext), typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000149")]
	private void ApplyDefaultFlip(MaterialPropertyBlock properties) { }

	[Address(RVA = "0x1843EA0", Offset = "0x18430A0", Length = "0x133")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderBuiltins", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext), typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderFinalPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000148")]
	private void ApplyFlip(PostProcessRenderContext context, MaterialPropertyBlock properties) { }

	[Address(RVA = "0x1843FE0", Offset = "0x18431E0", Length = "0x154")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PostProcessLayer), Member = "GetBundle", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(PostProcessBundle))]
	[Calls(Type = typeof(PostProcessBundle), Member = "CastRenderer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(AmbientOcclusionRenderer), Member = "GetMultiScaleVO", ReturnType = typeof(MultiScaleVO))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MultiScaleVO), Member = "GenerateAOMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Camera), typeof(RenderTargetIdentifier), typeof(System.Nullable`1<UnityEngine.Rendering.RenderTargetIdentifier>), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600013C")]
	public void BakeMSVOMap(CommandBuffer cmd, Camera camera, RenderTargetIdentifier destination, Nullable<RenderTargetIdentifier> depthMap, bool invert, bool isMSAA = false) { }

	[Address(RVA = "0x1844140", Offset = "0x1843340", Length = "0xE16")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "OnPreCull", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "OnPreRender", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AmbientOcclusionRenderer), Member = "Get", ReturnType = typeof(IAmbientOcclusionMethod))]
	[Calls(Type = typeof(PostProcessLayer), Member = "HasActiveEffects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessEvent), typeof(PostProcessRenderContext)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BuiltinRenderTextureType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessLayer), Member = "UpdateSrcDstForOpaqueOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(Int32&), typeof(PostProcessRenderContext), typeof(RenderTargetIdentifier), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_copyStdMaterial", ReturnType = typeof(Material))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BuiltinRenderTextureType)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(CommandBuffer), Member = "Blit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessEffectRendererExtensions), Member = "RenderOrLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessEffectRenderer), typeof(PostProcessRenderContext)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Fog), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_scriptableRenderPipelineActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(PostProcessLayer), Member = "RenderList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.PostProcessing.PostProcessLayer+SerializedBundleRef>), typeof(PostProcessRenderContext), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Fog), Member = "IsEnabledAndSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CommandBuffer), Member = "ReleaseTemporaryRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TargetPool), Member = "Get", ReturnType = typeof(int))]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite)}, ReturnType = typeof(RenderTextureDescriptor))]
	[Calls(Type = typeof(CommandBuffer), Member = "GetTemporaryRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTextureDescriptor), typeof(FilterMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(PostProcessLayer), Member = "DynamicResolutionAllowsFinalBlitToCameraTarget", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Display), Member = "get_main", ReturnType = typeof(Display))]
	[Calls(Type = typeof(Display), Member = "get_colorBuffer", ReturnType = typeof(RenderBuffer))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(PostProcessBundle), Member = "get_renderer", ReturnType = typeof(PostProcessEffectRenderer))]
	[Calls(Type = typeof(TemporalAntialiasing), Member = "IsSupported", ReturnType = typeof(bool))]
	[Calls(Type = typeof(PostProcessLayer), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Camera), Member = "get_targetTexture", ReturnType = typeof(RenderTexture))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTexture), Member = "get_format", ReturnType = typeof(RenderTextureFormat))]
	[Calls(Type = typeof(Camera), Member = "get_allowHDR", ReturnType = typeof(bool))]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Camera), Member = "get_pixelWidth", ReturnType = typeof(int))]
	[Calls(Type = typeof(Camera), Member = "get_pixelHeight", ReturnType = typeof(int))]
	[Calls(Type = typeof(CommandBuffer), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessLayer), Member = "SetupContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextureLerper), Member = "get_instance", ReturnType = typeof(TextureLerper))]
	[Calls(Type = typeof(TextureLerper), Member = "BeginFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessLayer), Member = "UpdateVolumeSystem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessLayer), Member = "GetBundle", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(PostProcessBundle))]
	[Calls(Type = typeof(PostProcessBundle), Member = "CastSettings", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(PostProcessBundle), Member = "CastRenderer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(AmbientOcclusionRenderer), Member = "IsAmbientOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTexture), Member = "get_colorBuffer", ReturnType = typeof(RenderBuffer))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderBuffer)}, ReturnType = typeof(RenderTargetIdentifier))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000137")]
	private void BuildCommandBuffers() { }

	[Address(RVA = "0x1844F60", Offset = "0x1844160", Length = "0x83")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "OnRenderImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture), typeof(RenderTexture)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "IsDynamicResolutionEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScalableBufferManager), Member = "get_heightScaleFactor", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScalableBufferManager), Member = "get_widthScaleFactor", ReturnType = typeof(float))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600012C")]
	private bool DynamicResolutionAllowsFinalBlitToCameraTarget() { }

	[Address(RVA = "0x508E60", Offset = "0x508060", Length = "0x7")]
	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000126")]
	public DepthTextureMode get_cameraDepthFlags() { }

	[Address(RVA = "0x508E70", Offset = "0x508070", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000128")]
	public bool get_haveBundlesBeenInited() { }

	[Address(RVA = "0x2DD240", Offset = "0x2DC440", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000124")]
	public Dictionary<PostProcessEvent, List`1<SerializedBundleRef>> get_sortedBundles() { }

	[Address(RVA = "0x72B2F0", Offset = "0x72A4F0", Length = "0x5D")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BakeMSVOMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Camera), typeof(RenderTargetIdentifier), typeof(System.Nullable`1<UnityEngine.Rendering.RenderTargetIdentifier>), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderBuiltins", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext), typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "ShouldGenerateLogHistogram", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(PostProcessLayer), Member = "GetBundle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(PostProcessBundle))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000139")]
	public PostProcessBundle GetBundle() { }

	[Address(RVA = "0x1844FF0", Offset = "0x18441F0", Length = "0x56")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "GetBundle", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(PostProcessBundle))]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "GetSettings", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "OverrideSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.PostProcessing.PostProcessEffectSettings>), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderEffect", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext), typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600013A")]
	public PostProcessBundle GetBundle(Type settingsType) { }

	[Address(RVA = "0x72B350", Offset = "0x72A550", Length = "0xE6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(PostProcessLayer), Member = "GetBundle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(PostProcessBundle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[DeduplicatedMethod]
	[Token(Token = "0x600013B")]
	public T GetSettings() { }

	[Address(RVA = "0x1845050", Offset = "0x1844250", Length = "0x1F6")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "HasOpaqueOnlyEffects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, ReturnType = typeof(object))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000141")]
	public bool HasActiveEffects(PostProcessEvent evt, PostProcessRenderContext context) { }

	[Address(RVA = "0x1845250", Offset = "0x1844450", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessLayer), Member = "HasActiveEffects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessEvent), typeof(PostProcessRenderContext)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000140")]
	public bool HasOpaqueOnlyEffects(PostProcessRenderContext context) { }

	[Address(RVA = "0x1845970", Offset = "0x1844B70", Length = "0x135")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "CreateIfNull", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(void))]
	[Token(Token = "0x600012E")]
	public void Init(PostProcessResources resources) { }

	[Address(RVA = "0x1845260", Offset = "0x1844460", Length = "0x482")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum", typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(PostProcessLayer), Member = "UpdateBundleSortList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.PostProcessing.PostProcessLayer+SerializedBundleRef>), typeof(PostProcessEvent)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeUtilities), Member = "GetAttribute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = "T")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(ScriptableObject), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(ScriptableObject))]
	[Calls(Type = typeof(PostProcessManager), Member = "get_instance", ReturnType = typeof(PostProcessManager))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "CreateIfNull", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x600012F")]
	public void InitBundles() { }

	[Address(RVA = "0x18456F0", Offset = "0x18448F0", Length = "0x278")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "OnPreCull", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CommandBuffer), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Camera), Member = "AddCommandBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CameraEvent), typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600012B")]
	private void InitLegacy() { }

	[Address(RVA = "0x1845AB0", Offset = "0x1844CB0", Length = "0x344")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextureLerper), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextureLerper), Member = "get_instance", ReturnType = typeof(TextureLerper))]
	[Calls(Type = typeof(PostProcessDebugLayer), Member = "OnDisable", ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Release", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(TemporalAntialiasing), Member = "Release", ReturnType = typeof(void))]
	[Calls(Type = typeof(Camera), Member = "RemoveCommandBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CameraEvent), typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000131")]
	private void OnDisable() { }

	[Address(RVA = "0x1845E00", Offset = "0x1845000", Length = "0x2B4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessLayer), Member = "InitBundles", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "CreateIfNull", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(TargetPool), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessDebugLayer), Member = "OnEnable", ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_scriptableRenderPipelineActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(PostProcessLayer), Member = "InitLegacy", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600012A")]
	private void OnEnable() { }

	[Address(RVA = "0x18460C0", Offset = "0x18452C0", Length = "0xC1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_scriptableRenderPipelineActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TemporalAntialiasing), Member = "IsSupported", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "ResetProjectionMatrix", ReturnType = typeof(void))]
	[Calls(Type = typeof(Camera), Member = "set_usePhysicalProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000138")]
	private void OnPostRender() { }

	[Address(RVA = "0x1846190", Offset = "0x1845390", Length = "0x2D0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Camera), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_scriptableRenderPipelineActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PostProcessLayer), Member = "InitLegacy", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TemporalAntialiasing), Member = "IsSupported", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "get_usePhysicalProperties", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "ResetProjectionMatrix", ReturnType = typeof(void))]
	[Calls(Type = typeof(Camera), Member = "get_projectionMatrix", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Camera), Member = "set_nonJitteredProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000133")]
	private void OnPreCull() { }

	[Address(RVA = "0x1846470", Offset = "0x1845670", Length = "0x77")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_scriptableRenderPipelineActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "get_stereoActiveEye", ReturnType = typeof(MonoOrStereoscopicEye))]
	[Calls(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000134")]
	private void OnPreRender() { }

	[Address(RVA = "0x18464F0", Offset = "0x18456F0", Length = "0xAD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PostProcessLayer), Member = "DynamicResolutionAllowsFinalBlitToCameraTarget", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Graphics), Member = "Blit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture), typeof(RenderTexture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ImageEffectUsesCommandBuffer]
	[Token(Token = "0x600012D")]
	private void OnRenderImage(RenderTexture src, RenderTexture dst) { }

	[Address(RVA = "0x18465A0", Offset = "0x18457A0", Length = "0x241")]
	[CalledBy(Type = typeof(PostProcessManager), Member = "UpdateSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessLayer), typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(PostProcessLayer), Member = "GetBundle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(PostProcessBundle))]
	[Calls(Type = typeof(ReadOnlyCollection`1), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801B0D80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x600013D")]
	internal void OverrideSettings(List<PostProcessEffectSettings> baseSettings, float interpFactor) { }

	[Address(RVA = "0x1848700", Offset = "0x1847900", Length = "0xCB1")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangleFromTexArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier), typeof(PropertySheet), typeof(int), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier), typeof(PropertySheet), typeof(int), typeof(RenderBufferLoadAction), typeof(System.Nullable`1<UnityEngine.Rect>), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "IsTemporalAntialiasingActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TemporalAntialiasing), Member = "ConfigureJitteredProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Camera), Member = "get_stereoActiveEye", ReturnType = typeof(MonoOrStereoscopicEye))]
	[Calls(Type = typeof(TemporalAntialiasing), Member = "ConfigureStereoJitteredProjectionMatrices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TemporalAntialiasing), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "ReleaseTemporaryRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SubpixelMorphologicalAntialiasing), Member = "IsSupported", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_copySheet", ReturnType = typeof(PropertySheet))]
	[Calls(Type = typeof(PostProcessLayer), Member = "RenderInjectionPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessEvent), typeof(PostProcessRenderContext), typeof(string), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(PostProcessLayer), Member = "RenderBuiltins", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext), typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(PostProcessLayer), Member = "RenderFinalPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "EnableShaderKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessDebugLayer), Member = "RenderSpecialOverlays", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessLayer), Member = "HasActiveEffects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessEvent), typeof(PostProcessRenderContext)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangleFromDoubleWide", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier), typeof(Material), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessDebugLayer), Member = "RenderMonitors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessDebugLayer), Member = "EndFrame", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_scriptableRenderPipelineActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(PostProcessLayer), Member = "SetupContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextureLerper), Member = "get_instance", ReturnType = typeof(TextureLerper))]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_copyFromTexArraySheet", ReturnType = typeof(PropertySheet))]
	[Calls(Type = typeof(TextureLerper), Member = "BeginFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "DisableShaderKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TargetPool), Member = "Get", ReturnType = typeof(int))]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite)}, ReturnType = typeof(RenderTextureDescriptor))]
	[Calls(Type = typeof(CommandBuffer), Member = "GetTemporaryRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTextureDescriptor), typeof(FilterMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_copyStdFromDoubleWideMaterial", ReturnType = typeof(Material))]
	[Calls(Type = typeof(PostProcessLayer), Member = "UpdateVolumeSystem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextureLerper), Member = "EndFrame", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000145")]
	public void Render(PostProcessRenderContext context) { }

	[Address(RVA = "0x18467F0", Offset = "0x18459F0", Length = "0xB4E")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite)}, ReturnType = typeof(RenderTextureDescriptor))]
	[Calls(Type = typeof(RuntimeUtilities), Member = "hasAlpha", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PostProcessLayer), Member = "RenderEffect", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(PostProcessLayer), Member = "GetBundle", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(PostProcessBundle))]
	[Calls(Type = typeof(Monitor), Member = "IsRequestedAndSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LogHistogram), Member = "Generate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessLayer), Member = "ApplyDefaultFlip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessLayer), Member = "ApplyFlip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangleToTexArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier), typeof(PropertySheet), typeof(int), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangleToDoubleWide", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier), typeof(PropertySheet), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier), typeof(PropertySheet), typeof(int), typeof(RenderBufferLoadAction), typeof(System.Nullable`1<UnityEngine.Rect>), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "ReleaseTemporaryRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dithering), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "GetTemporaryRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTextureDescriptor), typeof(FilterMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TargetPool), Member = "Get", ReturnType = typeof(int))]
	[Calls(Type = typeof(CommandBuffer), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "EnableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture2D), Member = "Apply", ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture2D), Member = "SetPixel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TextureFormat), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader)}, ReturnType = typeof(PropertySheet))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600014A")]
	private int RenderBuiltins(PostProcessRenderContext context, bool isFinalPass, int releaseTargetAfterUse = -1, int eye = -1) { }

	[Address(RVA = "0x72B440", Offset = "0x72A640", Length = "0x243")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderBuiltins", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext), typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(PostProcessEffectRendererExtensions), Member = "RenderOrLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessEffectRenderer), typeof(PostProcessRenderContext)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(PostProcessLayer), Member = "GetBundle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(PostProcessBundle))]
	[Calls(Type = typeof(TargetPool), Member = "Get", ReturnType = typeof(int))]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetScreenSpaceTemporaryRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(int), typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite), typeof(FilterMode), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(PostProcessBundle), Member = "get_renderer", ReturnType = typeof(PostProcessEffectRenderer))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600014C")]
	private int RenderEffect(PostProcessRenderContext context, bool useTempTarget = false) { }

	[Address(RVA = "0x1847340", Offset = "0x1846540", Length = "0xA31")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CommandBuffer), Member = "GetTemporaryRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTextureDescriptor), typeof(FilterMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier), typeof(PropertySheet), typeof(int), typeof(RenderBufferLoadAction), typeof(System.Nullable`1<UnityEngine.Rect>), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangleToDoubleWide", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier), typeof(PropertySheet), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangleToTexArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier), typeof(PropertySheet), typeof(int), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessLayer), Member = "ApplyFlip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dithering), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "HasAlphaChannel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetGraphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat), typeof(RenderTextureReadWrite)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(SubpixelMorphologicalAntialiasing), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite)}, ReturnType = typeof(RenderTextureDescriptor))]
	[Calls(Type = typeof(CommandBuffer), Member = "ReleaseTemporaryRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TargetPool), Member = "Get", ReturnType = typeof(int))]
	[Calls(Type = typeof(SubpixelMorphologicalAntialiasing), Member = "IsSupported", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "EnableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader)}, ReturnType = typeof(PropertySheet))]
	[Calls(Type = typeof(CommandBuffer), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CommandBuffer), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x600014B")]
	private void RenderFinalPass(PostProcessRenderContext context, int releaseTargetAfterUse = -1, int eye = -1) { }

	[Address(RVA = "0x1847D80", Offset = "0x1846F80", Length = "0x232")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TargetPool), Member = "Get", ReturnType = typeof(int))]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite)}, ReturnType = typeof(RenderTextureDescriptor))]
	[Calls(Type = typeof(CommandBuffer), Member = "GetTemporaryRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTextureDescriptor), typeof(FilterMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, ReturnType = typeof(object))]
	[Calls(Type = typeof(PostProcessLayer), Member = "RenderList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.PostProcessing.PostProcessLayer+SerializedBundleRef>), typeof(PostProcessRenderContext), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "ReleaseTemporaryRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000146")]
	private int RenderInjectionPoint(PostProcessEvent evt, PostProcessRenderContext context, string marker, int releaseTargetAfterUse = -1) { }

	[Address(RVA = "0x1847FC0", Offset = "0x18471C0", Length = "0x645")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderOpaqueOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderInjectionPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessEvent), typeof(PostProcessRenderContext), typeof(string), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TargetPool), Member = "Get", ReturnType = typeof(int))]
	[Calls(Type = typeof(CommandBuffer), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "ReleaseTemporaryRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessEffectRendererExtensions), Member = "RenderOrLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessEffectRenderer), typeof(PostProcessRenderContext)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CommandBuffer), Member = "GetTemporaryRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTextureDescriptor), typeof(FilterMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite)}, ReturnType = typeof(RenderTextureDescriptor))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800D4560")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.RenderTargetIdentifier>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(PostProcessBundle), Member = "get_renderer", ReturnType = typeof(PostProcessEffectRenderer))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000147")]
	private void RenderList(List<SerializedBundleRef> list, PostProcessRenderContext context, string marker) { }

	[Address(RVA = "0x1848610", Offset = "0x1847810", Length = "0xEC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_scriptableRenderPipelineActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(PostProcessLayer), Member = "SetupContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextureLerper), Member = "get_instance", ReturnType = typeof(TextureLerper))]
	[Calls(Type = typeof(TextureLerper), Member = "BeginFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessLayer), Member = "UpdateVolumeSystem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, ReturnType = typeof(object))]
	[Calls(Type = typeof(PostProcessLayer), Member = "RenderList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.PostProcessing.PostProcessLayer+SerializedBundleRef>), typeof(PostProcessRenderContext), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000144")]
	public void RenderOpaqueOnly(PostProcessRenderContext context) { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000135")]
	private static bool RequiresInitialBlit(Camera camera, PostProcessRenderContext context) { }

	[Address(RVA = "0x1849530", Offset = "0x1848730", Length = "0x25")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000132")]
	private void Reset() { }

	[Address(RVA = "0x18493C0", Offset = "0x18485C0", Length = "0x165")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2+Enumerator<System.Object, System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600013F")]
	public void ResetHistory() { }

	[Address(RVA = "0x508F10", Offset = "0x508110", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000127")]
	private void set_cameraDepthFlags(DepthTextureMode value) { }

	[Address(RVA = "0x508F20", Offset = "0x508120", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000129")]
	private void set_haveBundlesBeenInited(bool value) { }

	[Address(RVA = "0x2DD580", Offset = "0x2DC780", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000125")]
	private void set_sortedBundles(Dictionary<PostProcessEvent, List`1<SerializedBundleRef>> value) { }

	[Address(RVA = "0x1849560", Offset = "0x1848760", Length = "0x2D2")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "SetupContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PostProcessBundle), Member = "get_renderer", ReturnType = typeof(PostProcessEffectRenderer))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2+Enumerator<System.Object, System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TemporalAntialiasing), Member = "IsSupported", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Fog), Member = "IsEnabledAndSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "get_depthTextureMode", ReturnType = typeof(DepthTextureMode))]
	[Calls(Type = typeof(Camera), Member = "set_depthTextureMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DepthTextureMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600013E")]
	private void SetLegacyCameraFlags(PostProcessRenderContext context) { }

	[Address(RVA = "0x1849840", Offset = "0x1848A40", Length = "0x40F")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderOpaqueOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Camera), Member = "get_cameraType", ReturnType = typeof(CameraType))]
	[Calls(Type = typeof(Camera), Member = "get_usePhysicalProperties", ReturnType = typeof(bool))]
	[Calls(Type = typeof(PostProcessLayer), Member = "SetLegacyCameraFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000142")]
	private void SetupContext(PostProcessRenderContext context) { }

	[Address(RVA = "0x1849C50", Offset = "0x1848E50", Length = "0x9F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PostProcessLayer), Member = "GetBundle", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(PostProcessBundle))]
	[Calls(Type = typeof(Monitor), Member = "IsRequestedAndSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600014D")]
	private bool ShouldGenerateLogHistogram(PostProcessRenderContext context) { }

	[Address(RVA = "0x1849CF0", Offset = "0x1848EF0", Length = "0x638")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "InitBundles", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[Calls(Type = typeof(List`1), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Predicate`1<T>"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(List`1), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Predicate`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Predicate`1<System.Object>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000130")]
	private void UpdateBundleSortList(List<SerializedBundleRef> sortedList, PostProcessEvent evt) { }

	[Address(RVA = "0x184A330", Offset = "0x1849530", Length = "0x1B4")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CommandBuffer), Member = "ReleaseTemporaryRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TargetPool), Member = "Get", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite)}, ReturnType = typeof(RenderTextureDescriptor))]
	[Calls(Type = typeof(CommandBuffer), Member = "GetTemporaryRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTextureDescriptor), typeof(FilterMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000136")]
	private void UpdateSrcDstForOpaqueOnly(ref int src, ref int dst, PostProcessRenderContext context, RenderTargetIdentifier cameraTarget, int opaqueOnlyEffectsRemaining) { }

	[Address(RVA = "0x184A4F0", Offset = "0x18496F0", Length = "0x12F")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderOpaqueOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CommandBuffer), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessManager), Member = "get_instance", ReturnType = typeof(PostProcessManager))]
	[Calls(Type = typeof(PostProcessManager), Member = "UpdateSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessLayer), typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_scriptableRenderPipelineActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000143")]
	public void UpdateVolumeSystem(Camera cam, CommandBuffer cmd) { }

}

