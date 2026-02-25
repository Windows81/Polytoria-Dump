namespace UnityEngine.Rendering;

[Token(Token = "0x20002FA")]
public static class RenderPipelineManager
{
	[Token(Token = "0x4000935")]
	private static bool s_CleanUpPipeline; //Field offset: 0x0
	[Token(Token = "0x4000936")]
	private static RenderPipelineAsset s_CurrentPipelineAsset; //Field offset: 0x8
	[Token(Token = "0x4000937")]
	private static RenderPipeline s_CurrentPipeline; //Field offset: 0x10
	[Token(Token = "0x4000938")]
	private static bool s_PendingRPAssignationToRaise; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000939")]
	private static Action<ScriptableRenderContext, Camera> beginCameraRendering; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x400093A")]
	private static Action<ScriptableRenderContext, Camera> endCameraRendering; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x400093B")]
	private static Action activeRenderPipelineTypeChanged; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x400093C")]
	private static Action<RenderPipelineAsset, RenderPipelineAsset> activeRenderPipelineAssetChanged; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x400093D")]
	private static Action activeRenderPipelineCreated; //Field offset: 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x400093E")]
	private static Action activeRenderPipelineDisposed; //Field offset: 0x48

	[Token(Token = "0x1400000D")]
	public static event Action<ScriptableRenderContext, Camera> beginCameraRendering
	{
		[Address(RVA = "0x198B150", Offset = "0x198A350", Length = "0xDF")]
		[CalledBy(Type = "RLD.RLDApp", Member = "Start", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000E72")]
		 add { } //Length: 223
		[Address(RVA = "0x198B3A0", Offset = "0x198A5A0", Length = "0xDF")]
		[CalledBy(Type = "RLD.RLDApp", Member = "OnDisable", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000E73")]
		 remove { } //Length: 223
	}

	[Token(Token = "0x1400000E")]
	public static event Action<ScriptableRenderContext, Camera> endCameraRendering
	{
		[Address(RVA = "0x198B230", Offset = "0x198A430", Length = "0xDF")]
		[CalledBy(Type = "RLD.RLDApp", Member = "Start", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000E74")]
		 add { } //Length: 223
		[Address(RVA = "0x198B480", Offset = "0x198A680", Length = "0xDF")]
		[CalledBy(Type = "RLD.RLDApp", Member = "OnDisable", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000E75")]
		 remove { } //Length: 223
	}

	[Token(Token = "0x17000248")]
	public private static RenderPipeline currentPipeline
	{
		[Address(RVA = "0x198B310", Offset = "0x198A510", Length = "0x37")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000E70")]
		 get { } //Length: 55
		[Address(RVA = "0x198B560", Offset = "0x198A760", Length = "0x94")]
		[CalledBy(Type = typeof(RenderPipelineManager), Member = "CleanupRenderPipeline", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RenderPipelineManager), Member = "TryPrepareRenderPipeline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderPipelineAsset)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000E71")]
		private set { } //Length: 148
	}

	[Token(Token = "0x17000249")]
	internal static bool isCurrentPipelineValid
	{
		[Address(RVA = "0x198B350", Offset = "0x198A550", Length = "0x44")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000E7C")]
		internal get { } //Length: 68
	}

	[Address(RVA = "0x198B150", Offset = "0x198A350", Length = "0xDF")]
	[CalledBy(Type = "RLD.RLDApp", Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000E72")]
	public static void add_beginCameraRendering(Action<ScriptableRenderContext, Camera> value) { }

	[Address(RVA = "0x198B230", Offset = "0x198A430", Length = "0xDF")]
	[CalledBy(Type = "RLD.RLDApp", Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000E74")]
	public static void add_endCameraRendering(Action<ScriptableRenderContext, Camera> value) { }

	[Address(RVA = "0x198A610", Offset = "0x1989810", Length = "0x262")]
	[CalledBy(Type = typeof(RenderPipelineAsset), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderPipelineManager), Member = "HandleRenderPipelineChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderPipelineAsset)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderPipelineManager), Member = "TryPrepareRenderPipeline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderPipelineAsset)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(GraphicsSettings), Member = "get_currentRenderPipeline", ReturnType = typeof(RenderPipelineAsset))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Shader), Member = "set_globalRenderPipeline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderPipelineManager), Member = "set_currentPipeline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderPipeline)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000E79")]
	internal static void CleanupRenderPipeline() { }

	[Address(RVA = "0x198A880", Offset = "0x1989A80", Length = "0x2CE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderPipeline), Member = "InternalProcessRenderRequests", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"RequestData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), "RequestData"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(PooledObject`1), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScriptableRenderContext), Member = "GetCameras", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Camera>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection&"}, ReturnType = "UnityEngine.Pool.PooledObject`1<TCollection>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RenderPipelineManager), Member = "TryPrepareRenderPipeline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderPipelineAsset)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000E7A")]
	private static void DoRenderLoop_Internal(RenderPipelineAsset pipelineAsset, IntPtr loopPtr, object renderRequest) { }

	[Address(RVA = "0x198B310", Offset = "0x198A510", Length = "0x37")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000E70")]
	public static RenderPipeline get_currentPipeline() { }

	[Address(RVA = "0x198B350", Offset = "0x198A550", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000E7C")]
	internal static bool get_isCurrentPipelineValid() { }

	[Address(RVA = "0x198AB50", Offset = "0x1989D50", Length = "0x7C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RenderPipelineManager), Member = "CleanupRenderPipeline", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[ContainsUnimplementedInstructions]
	[RequiredByNativeCode]
	[Token(Token = "0x6000E77")]
	internal static void HandleRenderPipelineChange(RenderPipelineAsset pipelineAsset) { }

	[Address(RVA = "0x198ABD0", Offset = "0x1989DD0", Length = "0xF9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000E7D")]
	private static bool IsPipelineRequireCreation() { }

	[Address(RVA = "0x198ACD0", Offset = "0x1989ED0", Length = "0x20C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000E76")]
	private static void OnActiveRenderPipelineAssetChanged(ScriptableObject from, ScriptableObject to, bool raiseTypeChanged) { }

	[Address(RVA = "0x1989E50", Offset = "0x1989050", Length = "0x8A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[RequiredByNativeCode]
	[Token(Token = "0x6000E78")]
	internal static void RecreateCurrentPipeline(RenderPipelineAsset pipelineAsset) { }

	[Address(RVA = "0x198B3A0", Offset = "0x198A5A0", Length = "0xDF")]
	[CalledBy(Type = "RLD.RLDApp", Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000E73")]
	public static void remove_beginCameraRendering(Action<ScriptableRenderContext, Camera> value) { }

	[Address(RVA = "0x198B480", Offset = "0x198A680", Length = "0xDF")]
	[CalledBy(Type = "RLD.RLDApp", Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000E75")]
	public static void remove_endCameraRendering(Action<ScriptableRenderContext, Camera> value) { }

	[Address(RVA = "0x198B560", Offset = "0x198A760", Length = "0x94")]
	[CalledBy(Type = typeof(RenderPipelineManager), Member = "CleanupRenderPipeline", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderPipelineManager), Member = "TryPrepareRenderPipeline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderPipelineAsset)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000E71")]
	private static void set_currentPipeline(RenderPipeline value) { }

	[Address(RVA = "0x198AEE0", Offset = "0x198A0E0", Length = "0x263")]
	[CalledBy(Type = typeof(RenderPipelineManager), Member = "DoRenderLoop_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderPipelineAsset), typeof(IntPtr), typeof(Object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RenderPipelineManager), Member = "CleanupRenderPipeline", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderPipelineAsset), Member = "InternalCreatePipeline", ReturnType = typeof(RenderPipeline))]
	[Calls(Type = typeof(RenderPipelineManager), Member = "set_currentPipeline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderPipeline)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Shader), Member = "set_globalRenderPipeline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000E7B")]
	internal static bool TryPrepareRenderPipeline(RenderPipelineAsset pipelineAsset) { }

}

