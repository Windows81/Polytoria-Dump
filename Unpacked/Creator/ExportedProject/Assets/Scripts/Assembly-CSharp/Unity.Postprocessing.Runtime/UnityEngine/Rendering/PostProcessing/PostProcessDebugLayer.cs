namespace UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x200005F")]
public sealed class PostProcessDebugLayer
{
	[Token(Token = "0x2000060")]
	internal class OverlaySettings
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000188")]
		public bool linearDepth; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Range(0, 16)]
		[Token(Token = "0x4000189")]
		public float motionColorIntensity; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Range(4, 128)]
		[Token(Token = "0x400018A")]
		public int motionGridSize; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x400018B")]
		public ColorBlindnessType colorBlindnessType; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Range(0, 1)]
		[Token(Token = "0x400018C")]
		public float colorBlindnessStrength; //Field offset: 0x20

		[Address(RVA = "0x18413D0", Offset = "0x18405D0", Length = "0x1C")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600010B")]
		public OverlaySettings() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400017D")]
	public LightMeterMonitor lightMeter; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400017E")]
	public HistogramMonitor histogram; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400017F")]
	public WaveformMonitor waveform; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000180")]
	public VectorscopeMonitor vectorscope; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000181")]
	private Dictionary<MonitorType, Monitor> m_Monitors; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000182")]
	private int frameWidth; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000183")]
	private int frameHeight; //Field offset: 0x3C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000184")]
	private RenderTexture <debugOverlayTarget>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000185")]
	private bool <debugOverlayActive>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000186")]
	private DebugOverlay <debugOverlay>k__BackingField; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000187")]
	public OverlaySettings overlaySettings; //Field offset: 0x50

	[Token(Token = "0x17000009")]
	public private DebugOverlay debugOverlay
	{
		[Address(RVA = "0x5B9B30", Offset = "0x5B8D30", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60000FD")]
		 get { } //Length: 4
		[Address(RVA = "0x5B9B40", Offset = "0x5B8D40", Length = "0x4")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60000FE")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000008")]
	public private bool debugOverlayActive
	{
		[Address(RVA = "0x347A30", Offset = "0x346C30", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60000FB")]
		 get { } //Length: 5
		[Address(RVA = "0x347A50", Offset = "0x346C50", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60000FC")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000007")]
	public private RenderTexture debugOverlayTarget
	{
		[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60000F9")]
		 get { } //Length: 5
		[Address(RVA = "0x309660", Offset = "0x308860", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60000FA")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600010A")]
	public PostProcessDebugLayer() { }

	[Address(RVA = "0x1841660", Offset = "0x1840860", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000101")]
	private void DestroyDebugOverlayTarget() { }

	[Address(RVA = "0x18416D0", Offset = "0x18408D0", Length = "0x1A2")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000109")]
	internal void EndFrame() { }

	[Address(RVA = "0x5B9B30", Offset = "0x5B8D30", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60000FD")]
	public DebugOverlay get_debugOverlay() { }

	[Address(RVA = "0x347A30", Offset = "0x346C30", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60000FB")]
	public bool get_debugOverlayActive() { }

	[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60000F9")]
	public RenderTexture get_debugOverlayTarget() { }

	[Address(RVA = "0x1841880", Offset = "0x1840A80", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000106")]
	internal DepthTextureMode GetCameraFlags() { }

	[Address(RVA = "0x18418B0", Offset = "0x1840AB0", Length = "0x1A0")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000100")]
	internal void OnDisable() { }

	[Address(RVA = "0x1841A60", Offset = "0x1840C60", Length = "0x2A2")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "CreateIfNull", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum", typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000FF")]
	internal void OnEnable() { }

	[Address(RVA = "0x1841D10", Offset = "0x1840F10", Length = "0x340")]
	[CalledBy(Type = typeof(PostProcessDebugLayer), Member = "RenderSpecialOverlays", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessRenderContext), Member = "PushDebugOverlay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(PropertySheet), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(RenderTextureFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTexture), Member = "Create", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HideFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture), Member = "set_wrapMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureWrapMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture), Member = "set_filterMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FilterMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture), Member = "set_anisoLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTexture), Member = "IsCreated", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier), typeof(PropertySheet), typeof(int), typeof(RenderBufferLoadAction), typeof(System.Nullable`1<UnityEngine.Rect>), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000105")]
	public void PushDebugOverlay(CommandBuffer cmd, RenderTargetIdentifier source, PropertySheet sheet, int pass) { }

	[Address(RVA = "0x1842060", Offset = "0x1841260", Length = "0x4E1")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CommandBuffer), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "ReleaseTemporaryRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "Blit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(CommandBuffer), Member = "GetTemporaryRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(FilterMode), typeof(RenderTextureFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Monitor), Member = "IsRequestedAndSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CommandBuffer), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000107")]
	internal void RenderMonitors(PostProcessRenderContext context) { }

	[Address(RVA = "0x1842550", Offset = "0x1841750", Length = "0x4A5")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader)}, ReturnType = typeof(PropertySheet))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessDebugLayer), Member = "PushDebugOverlay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(PropertySheet), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BuiltinRenderTextureType)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000108")]
	internal void RenderSpecialOverlays(PostProcessRenderContext context) { }

	[Address(RVA = "0x5B9B40", Offset = "0x5B8D40", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000103")]
	public void RequestDebugOverlay(DebugOverlay mode) { }

	[Address(RVA = "0x1842A00", Offset = "0x1841C00", Length = "0x5B")]
	[CalledBy(Type = typeof(PostProcessDebug), Member = "UpdateStates", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000102")]
	public void RequestMonitorPass(MonitorType monitor) { }

	[Address(RVA = "0x5B9B40", Offset = "0x5B8D40", Length = "0x4")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60000FE")]
	private void set_debugOverlay(DebugOverlay value) { }

	[Address(RVA = "0x347A50", Offset = "0x346C50", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60000FC")]
	private void set_debugOverlayActive(bool value) { }

	[Address(RVA = "0x309660", Offset = "0x308860", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60000FA")]
	private void set_debugOverlayTarget(RenderTexture value) { }

	[Address(RVA = "0x1842A60", Offset = "0x1841C60", Length = "0xC")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000104")]
	internal void SetFrameSize(int width, int height) { }

}

