namespace RLD;

[Token(Token = "0x200011F")]
public class RLDApp : MonoSingleton<RLDApp>, IRLDApplication
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000530")]
	private RLDAppInitializedHandler Initialized; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000531")]
	private Camera _renderCamera; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000532")]
	private RenderPipelineId _renderPipelineId; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000533")]
	private DynamicConvertSettings _dynamicConvertSettings; //Field offset: 0x38

	[Token(Token = "0x14000016")]
	public event RLDAppInitializedHandler Initialized
	{
		[Address(RVA = "0x547200", Offset = "0x546400", Length = "0x9E")]
		[CalledBy(Type = typeof(PrefabSpawnSnap), Member = "Awake", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CreatorController), Member = "Awake", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000DC5")]
		 add { } //Length: 158
		[Address(RVA = "0x5472A0", Offset = "0x5464A0", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000DC6")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x170004A3")]
	public DynamicConvertSettings DynamicConvertSettings
	{
		[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000DC7")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170004A5")]
	public Camera RenderCamera
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000DC9")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170004A4")]
	public RenderPipelineId RenderPipelineId
	{
		[Address(RVA = "0x2F5B20", Offset = "0x2F4D20", Length = "0xAE")]
		[CallerCount(Count = 23)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000DC8")]
		 get { } //Length: 174
	}

	[Address(RVA = "0x547160", Offset = "0x546360", Length = "0x98")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DynamicConvertSettings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000DD9")]
	public RLDApp() { }

	[Address(RVA = "0x547200", Offset = "0x546400", Length = "0x9E")]
	[CalledBy(Type = typeof(PrefabSpawnSnap), Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorController), Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000DC5")]
	public void add_Initialized(RLDAppInitializedHandler value) { }

	[Address(RVA = "0x5454E0", Offset = "0x5446E0", Length = "0x15B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GraphicsSettings), Member = "get_currentRenderPipeline", ReturnType = typeof(RenderPipelineAsset))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "Break", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000DD3")]
	private void DetectRenderPipeline() { }

	[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DC7")]
	public DynamicConvertSettings get_DynamicConvertSettings() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DC9")]
	public Camera get_RenderCamera() { }

	[Address(RVA = "0x2F5B20", Offset = "0x2F4D20", Length = "0xAE")]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DC8")]
	public RenderPipelineId get_RenderPipelineId() { }

	[Address(RVA = "0x545640", Offset = "0x544840", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000DD7")]
	private void OnBeginCameraRendering(ScriptableRenderContext context, Camera camera) { }

	[Address(RVA = "0x545650", Offset = "0x544850", Length = "0x7C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000DCC")]
	private void OnCanCameraProcessInput(YesNoAnswer answer) { }

	[Address(RVA = "0x5456D0", Offset = "0x5448D0", Length = "0x83")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(RTScene), Member = "IsAnyUIElementHovered", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000DCB")]
	private void OnCanCameraUseScrollWheel(YesNoAnswer answer) { }

	[Address(RVA = "0x545760", Offset = "0x544960", Length = "0xEC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RTObjectSelection), Member = "get_IsMultiSelectShapeVisible", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000DCE")]
	private void OnCanDoGizmoHoverUpdate(YesNoAnswer answer) { }

	[Address(RVA = "0x545850", Offset = "0x544A50", Length = "0x95")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(Hotkeys), Member = "IsActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000DCF")]
	private void OnCanObjectSelectionClickAndMultiSelectDeselect(YesNoAnswer answer) { }

	[Address(RVA = "0x5458F0", Offset = "0x544AF0", Length = "0x10F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(RTObjectSelection), Member = "get_IsMultiSelectShapeVisible", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RTObjectSelection), Member = "get_IsManipSessionActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000DCD")]
	private void OnCanUndoRedo(UndoRedoOpType undoRedoOpType, YesNoAnswer answer) { }

	[Address(RVA = "0x545A00", Offset = "0x544C00", Length = "0x105")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GraphicsSettings), Member = "get_currentRenderPipeline", ReturnType = typeof(RenderPipelineAsset))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Action`2<UnityEngine.Rendering.ScriptableRenderContext, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderPipelineManager), Member = "remove_beginCameraRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.Rendering.ScriptableRenderContext, UnityEngine.Camera>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderPipelineManager), Member = "remove_endCameraRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.Rendering.ScriptableRenderContext, UnityEngine.Camera>)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000DD4")]
	private void OnDisable() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DD8")]
	private void OnEndCameraRendering(ScriptableRenderContext context, Camera camera) { }

	[Address(RVA = "0x545B10", Offset = "0x544D10", Length = "0x2BC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(RTGizmosEngine), Member = "IsSceneGizmoCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RTCameraBackground), Member = "Render_SystemCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTSceneGrid), Member = "Render_SystemCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTScene), Member = "Render_SystemCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTObjectSelection), Member = "Render_SystemCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTGizmosEngine), Member = "Render_SystemCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000DD6")]
	private void OnRenderObject() { }

	[Address(RVA = "0x545DD0", Offset = "0x544FD0", Length = "0x10C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RTGizmosEngine), Member = "IsSceneGizmoCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000DCA")]
	private void OnSceneCanRenderCameraIcon(Camera camera, YesNoAnswer answer) { }

	[Address(RVA = "0x545EE0", Offset = "0x5450E0", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(RTGizmosEngine), Member = "RemoveRenderCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000DD1")]
	private void OnViewportCameraRemoved(Camera camera) { }

	[Address(RVA = "0x545F50", Offset = "0x545150", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(RTGizmosEngine), Member = "AddRenderCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000DD0")]
	private void OnViewportsCameraAdded(Camera camera) { }

	[Address(RVA = "0x5472A0", Offset = "0x5464A0", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000DC6")]
	public void remove_Initialized(RLDAppInitializedHandler value) { }

	[Address(RVA = "0x545FC0", Offset = "0x5451C0", Length = "0xD03")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(RTGizmosEngine), Member = "add_CanDoHoverUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoEngineCanDoHoverUpdateHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTGizmosEngine), Member = "CreateSceneGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(SceneGizmo))]
	[Calls(Type = typeof(RTGizmosEngine), Member = "AddRenderCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectSelectEntireHierarchy), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTObjectSelection), Member = "add_CanClickSelectDeselect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectSelectionCanClickSelectDeselectHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTObjectSelection), Member = "add_CanMultiSelectDeselect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectSelectionCanMultiSelectDeselectHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTObjectSelection), Member = "AttachGizmoController", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IObjectCollectionGizmoController)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTSceneGrid), Member = "Initialize_SystemCall", ReturnType = typeof(void))]
	[Calls(Type = typeof(RTObjectSelectionGizmos), Member = "Initialize_SystemCall", ReturnType = typeof(void))]
	[Calls(Type = typeof(RTMeshCompiler), Member = "CompileEntireScene", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Action`2<UnityEngine.Rendering.ScriptableRenderContext, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderPipelineManager), Member = "add_beginCameraRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.Rendering.ScriptableRenderContext, UnityEngine.Camera>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderPipelineManager), Member = "add_endCameraRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.Rendering.ScriptableRenderContext, UnityEngine.Camera>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTObjectSelection), Member = "Initialize_SystemCall", ReturnType = typeof(void))]
	[Calls(Type = typeof(RTScene), Member = "RegisterHoverableSceneEntityContainer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IHoverableSceneEntityContainer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(Debug), Member = "Break", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GraphicsSettings), Member = "get_currentRenderPipeline", ReturnType = typeof(RenderPipelineAsset))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RTUndoRedo), Member = "add_CanUndoRedo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CanUndoRedoHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000DD2")]
	private void Start() { }

	[Address(RVA = "0x546CD0", Offset = "0x545ED0", Length = "0x48E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WorldTransformSnapshot), Member = "SameAs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RTObjectSelection), Member = "Update_SystemCall", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RTGizmosEngine), Member = "Update_SystemCall", ReturnType = typeof(void))]
	[Calls(Type = typeof(RTSceneGrid), Member = "Update_SystemCall", ReturnType = typeof(void))]
	[Calls(Type = typeof(RTScene), Member = "Update_SystemCall", ReturnType = typeof(void))]
	[Calls(Type = typeof(WorldTransformSnapshot), Member = "Snaphot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTFocusCamera), Member = "HandleMouseAndKeyboardInput", ReturnType = typeof(void))]
	[Calls(Type = typeof(RTInputDevice), Member = "get_DeviceType", ReturnType = typeof(InputDeviceType))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RTInputDevice), Member = "Update_SystemCall", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(RTObjectSelectionGizmos), Member = "Update_SystemCall", ReturnType = typeof(void))]
	[Calls(Type = typeof(RTUndoRedo), Member = "Update_SystemCall", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000DD5")]
	private void Update() { }

}

