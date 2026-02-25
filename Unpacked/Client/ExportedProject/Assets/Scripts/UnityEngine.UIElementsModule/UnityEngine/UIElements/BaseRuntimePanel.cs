namespace UnityEngine.UIElements;

[Token(Token = "0x20002B2")]
internal abstract class BaseRuntimePanel : Panel
{
	[CompilerGenerated]
	[Token(Token = "0x20002B3")]
	private sealed class <>c
	{
		[Token(Token = "0x4000AF6")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x1C8F300", Offset = "0x1C8E500", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60012E6")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60012E7")]
		public <>c() { }

		[Address(RVA = "0x1C8F1A0", Offset = "0x1C8E3A0", Length = "0x24")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60012E8")]
		internal Vector3 <.cctor>b__51_0(Vector2 p) { }

	}

	[Token(Token = "0x4000AEA")]
	private static int s_CurrentRuntimePanelCounter; //Field offset: 0x0
	[Token(Token = "0x4000AF4")]
	internal static readonly Func<Vector2, Vector3> DefaultScreenToPanelSpace; //Field offset: 0x8
	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x4000AE9")]
	private GameObject m_SelectableGameObject; //Field offset: 0x1B0
	[FieldOffset(Offset = "0x1B8")]
	[Token(Token = "0x4000AEB")]
	internal readonly int m_RuntimePanelCreationIndex; //Field offset: 0x1B8
	[FieldOffset(Offset = "0x1BC")]
	[Token(Token = "0x4000AEC")]
	private float m_SortingPriority; //Field offset: 0x1BC
	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x4000AED")]
	internal int resolvedSortingIndex; //Field offset: 0x1C0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x1C8")]
	[Token(Token = "0x4000AEE")]
	private Action destroyed; //Field offset: 0x1C8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x1D0")]
	[Token(Token = "0x4000AEF")]
	private Action drawsInCamerasChanged; //Field offset: 0x1D0
	[FieldOffset(Offset = "0x1D8")]
	[Token(Token = "0x4000AF0")]
	private bool m_DrawsInCameras; //Field offset: 0x1D8
	[FieldOffset(Offset = "0x1DC")]
	[Token(Token = "0x4000AF1")]
	private float m_PixelsPerUnit; //Field offset: 0x1DC
	[FieldOffset(Offset = "0x1E0")]
	[Token(Token = "0x4000AF2")]
	internal RenderTexture targetTexture; //Field offset: 0x1E0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x1E8")]
	[Token(Token = "0x4000AF3")]
	private int <targetDisplay>k__BackingField; //Field offset: 0x1E8
	[FieldOffset(Offset = "0x1F0")]
	[Token(Token = "0x4000AF5")]
	private Func<Vector2, Vector3> m_ScreenToPanelSpace; //Field offset: 0x1F0

	[Token(Token = "0x1400002B")]
	public event Action destroyed
	{
		[Address(RVA = "0x1C7E2A0", Offset = "0x1C7D4A0", Length = "0xA2")]
		[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "RegisterCallbacks", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.PanelRaycaster", Member = "set_panel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.PanelRaycaster", Member = "RegisterCallbacks", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.PanelRaycaster", Member = "OnPanelDestroyed", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.UIToolkitInteroperabilityBridge", Member = "CreatePanelGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseRuntimePanel)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60012CB")]
		 add { } //Length: 162
		[Address(RVA = "0x1C7E7B0", Offset = "0x1C7D9B0", Length = "0xA2")]
		[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "UnregisterCallbacks", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.PanelRaycaster", Member = "set_panel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.PanelRaycaster", Member = "UnregisterCallbacks", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.PanelRaycaster", Member = "OnPanelDestroyed", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.UIToolkitInteroperabilityBridge", Member = "DestroyPanelGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseRuntimePanel)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60012CC")]
		 remove { } //Length: 162
	}

	[Token(Token = "0x1400002C")]
	internal event Action drawsInCamerasChanged
	{
		[Address(RVA = "0x1C7E350", Offset = "0x1C7D550", Length = "0xA2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60012CF")]
		internal add { } //Length: 162
		[Address(RVA = "0x1C7E860", Offset = "0x1C7DA60", Length = "0xA2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60012D0")]
		internal remove { } //Length: 162
	}

	[Token(Token = "0x170003A2")]
	internal bool drawsInCameras
	{
		[Address(RVA = "0x1C7E580", Offset = "0x1C7D780", Length = "0xA")]
		[CalledBy(Type = typeof(PointerDeviceState), Member = "SetElementWithSoftPointerCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement), typeof(Camera)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DefaultEventSystem), Member = "SendFocusBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TArg, EventBase>", "TArg"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIDocument), Member = "UpdateRenderer", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "GetPlayerPanelsByRenderMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.BaseRuntimePanel>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.BaseRuntimePanel>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "RenderPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseRuntimePanel), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RenderTreeManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Token(Token = "0x60012D2")]
		internal get { } //Length: 10
		[Address(RVA = "0x1C7E910", Offset = "0x1C7DB10", Length = "0x7D")]
		[CalledBy(Type = typeof(PanelSettings), Member = "ApplyPanelSettings", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "SetPanelsDrawInCameraDirty", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60012D3")]
		internal set { } //Length: 125
	}

	[Token(Token = "0x170003A3")]
	internal float pixelsPerUnit
	{
		[Address(RVA = "0x1C7E590", Offset = "0x1C7D790", Length = "0xB")]
		[CalledBy(Type = typeof(UIDocument), Member = "UpdateRenderer", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIDocument), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(UIDocument), Member = "ScaleAndFlipMatrix", ReturnType = typeof(Matrix4x4))]
		[CallerCount(Count = 3)]
		[Token(Token = "0x60012D4")]
		internal get { } //Length: 11
		[Address(RVA = "0x1C7E990", Offset = "0x1C7DB90", Length = "0x9")]
		[CalledBy(Type = typeof(PanelSettings), Member = "ApplyPanelSettings", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Token(Token = "0x60012D5")]
		internal set { } //Length: 9
	}

	[Token(Token = "0x170003A6")]
	internal int screenRenderingHeight
	{
		[Address(RVA = "0x1C7E5A0", Offset = "0x1C7D7A0", Length = "0xE9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Display), Member = "get_renderingHeight", ReturnType = typeof(int))]
		[Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60012D9")]
		internal get { } //Length: 233
	}

	[Token(Token = "0x170003A5")]
	internal int screenRenderingWidth
	{
		[Address(RVA = "0x1C7E690", Offset = "0x1C7D890", Length = "0xE9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Display), Member = "get_renderingWidth", ReturnType = typeof(int))]
		[Calls(Type = typeof(Screen), Member = "get_width", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60012D8")]
		internal get { } //Length: 233
	}

	[Token(Token = "0x170003A7")]
	public Func<Vector2, Vector3> screenToPanelSpace
	{
		[Address(RVA = "0x1C7E780", Offset = "0x1C7D980", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60012DE")]
		 get { } //Length: 8
		[Address(RVA = "0x1C7E9A0", Offset = "0x1C7DBA0", Length = "0x84")]
		[CalledBy(Type = "UnityEngine.UIElements.PanelSettings+RuntimePanelAccess", Member = "get_panel", ReturnType = typeof(BaseRuntimePanel))]
		[CalledBy(Type = typeof(PanelSettings), Member = "SetScreenToPanelSpaceFunction3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`2<UnityEngine.Vector2, UnityEngine.Vector3>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PanelSettings), Member = "SetScreenToPanelSpaceFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`2<UnityEngine.Vector2, UnityEngine.Vector2>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60012DF")]
		 set { } //Length: 132
	}

	[Token(Token = "0x170003A0")]
	public override GameObject selectableGameObject
	{
		[Address(RVA = "0x497990", Offset = "0x496B90", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60012C7")]
		 get { } //Length: 8
		[Address(RVA = "0x1C7EA30", Offset = "0x1C7DC30", Length = "0xA0")]
		[CalledBy(Type = "UnityEngine.UIElements.UIToolkitInteroperabilityBridge", Member = "CreatePanelGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseRuntimePanel)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.UIToolkitInteroperabilityBridge", Member = "DestroyPanelGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseRuntimePanel)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(BaseRuntimePanel), Member = "AssignPanelToComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseRuntimePanel)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x60012C8")]
		 set { } //Length: 160
	}

	[Token(Token = "0x170003A1")]
	public float sortingPriority
	{
		[Address(RVA = "0x1C7E790", Offset = "0x1C7D990", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60012C9")]
		 get { } //Length: 9
		[Address(RVA = "0x1C7EAD0", Offset = "0x1C7DCD0", Length = "0x8C")]
		[CalledBy(Type = "UnityEngine.UIElements.PanelSettings+RuntimePanelAccess", Member = "get_panel", ReturnType = typeof(BaseRuntimePanel))]
		[CalledBy(Type = "UnityEngine.UIElements.PanelSettings+RuntimePanelAccess", Member = "SetSortingPriority", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PanelSettings), Member = "set_sortingOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PanelSettings), Member = "ApplySortingOrder", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "SetPanelOrderingDirty", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60012CA")]
		 set { } //Length: 140
	}

	[Token(Token = "0x170003A4")]
	internal int targetDisplay
	{
		[Address(RVA = "0x1C7E7A0", Offset = "0x1C7D9A0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x60012D6")]
		internal get { } //Length: 7
		[Address(RVA = "0x1C7EB60", Offset = "0x1C7DD60", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x60012D7")]
		internal set { } //Length: 7
	}

	[Address(RVA = "0x1C7E0A0", Offset = "0x1C7D2A0", Length = "0xE1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Func`2<UnityEngine.Vector2, UnityEngine.Vector3>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60012E5")]
	private static BaseRuntimePanel() { }

	[Address(RVA = "0x1C7E190", Offset = "0x1C7D390", Length = "0x106")]
	[CalledBy(Type = typeof(RuntimePanel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableObject)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Panel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableObject), typeof(ContextType), typeof(EventDispatcher)}, ReturnType = typeof(void))]
	[Token(Token = "0x60012CD")]
	protected BaseRuntimePanel(ScriptableObject ownerObject, EventDispatcher dispatcher = null) { }

	[Address(RVA = "0x1C7E2A0", Offset = "0x1C7D4A0", Length = "0xA2")]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "RegisterCallbacks", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelRaycaster", Member = "set_panel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelRaycaster", Member = "RegisterCallbacks", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelRaycaster", Member = "OnPanelDestroyed", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIToolkitInteroperabilityBridge", Member = "CreatePanelGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseRuntimePanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60012CB")]
	public void add_destroyed(Action value) { }

	[Address(RVA = "0x1C7E350", Offset = "0x1C7D550", Length = "0xA2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60012CF")]
	internal void add_drawsInCamerasChanged(Action value) { }

	[Address(RVA = "0x1C7D2B0", Offset = "0x1C7C4B0", Length = "0x2E5")]
	[CalledBy(Type = typeof(BaseRuntimePanel), Member = "set_selectableGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "GetComponents", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection&"}, ReturnType = "UnityEngine.Pool.PooledObject`1<TCollection>")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(PooledObject`1), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60012E2")]
	private void AssignPanelToComponents(BaseRuntimePanel panel) { }

	[Address(RVA = "0x1C7D5A0", Offset = "0x1C7C7A0", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60012CE")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x1C7E580", Offset = "0x1C7D780", Length = "0xA")]
	[CalledBy(Type = typeof(PointerDeviceState), Member = "SetElementWithSoftPointerCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement), typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "SendFocusBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TArg, EventBase>", "TArg"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIDocument), Member = "UpdateRenderer", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "GetPlayerPanelsByRenderMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.BaseRuntimePanel>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.BaseRuntimePanel>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "RenderPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseRuntimePanel), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Token(Token = "0x60012D2")]
	internal bool get_drawsInCameras() { }

	[Address(RVA = "0x1C7E590", Offset = "0x1C7D790", Length = "0xB")]
	[CalledBy(Type = typeof(UIDocument), Member = "UpdateRenderer", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIDocument), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(UIDocument), Member = "ScaleAndFlipMatrix", ReturnType = typeof(Matrix4x4))]
	[CallerCount(Count = 3)]
	[Token(Token = "0x60012D4")]
	internal float get_pixelsPerUnit() { }

	[Address(RVA = "0x1C7E5A0", Offset = "0x1C7D7A0", Length = "0xE9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Display), Member = "get_renderingHeight", ReturnType = typeof(int))]
	[Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60012D9")]
	internal int get_screenRenderingHeight() { }

	[Address(RVA = "0x1C7E690", Offset = "0x1C7D890", Length = "0xE9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Display), Member = "get_renderingWidth", ReturnType = typeof(int))]
	[Calls(Type = typeof(Screen), Member = "get_width", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60012D8")]
	internal int get_screenRenderingWidth() { }

	[Address(RVA = "0x1C7E780", Offset = "0x1C7D980", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60012DE")]
	public Func<Vector2, Vector3> get_screenToPanelSpace() { }

	[Address(RVA = "0x497990", Offset = "0x496B90", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60012C7")]
	public override GameObject get_selectableGameObject() { }

	[Address(RVA = "0x1C7E790", Offset = "0x1C7D990", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60012C9")]
	public float get_sortingPriority() { }

	[Address(RVA = "0x1C7E7A0", Offset = "0x1C7D9A0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x60012D6")]
	internal int get_targetDisplay() { }

	[Address(RVA = "0x1C7E400", Offset = "0x1C7D600", Length = "0xB1")]
	[CalledBy(Type = typeof(PanelSettings), Member = "ApplyPanelSettings", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelSettings), Member = "GetDisplayRect", ReturnType = typeof(Rect))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Display), Member = "get_renderingHeight", ReturnType = typeof(int))]
	[Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60012DB")]
	internal static int getScreenRenderingHeight(int display) { }

	[Address(RVA = "0x1C7E4C0", Offset = "0x1C7D6C0", Length = "0xB1")]
	[CalledBy(Type = typeof(PanelSettings), Member = "ApplyPanelSettings", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelSettings), Member = "GetDisplayRect", ReturnType = typeof(Rect))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Display), Member = "get_renderingWidth", ReturnType = typeof(int))]
	[Calls(Type = typeof(Screen), Member = "get_width", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60012DC")]
	internal static int getScreenRenderingWidth(int display) { }

	[Address(RVA = "0x1C7D600", Offset = "0x1C7C800", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60012D1")]
	private void InvokeDrawsInCamerasChanged() { }

	[Address(RVA = "0x1C7D620", Offset = "0x1C7C820", Length = "0xA6")]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "SendPositionBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(int), typeof(System.Nullable`1<System.Int32>), "System.Func`3<Vector3, TArg, EventBase>", "TArg", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "SendRayBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(float), typeof(int), "System.Func`3<Vector3, TArg, EventBase>", "TArg", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "UpdateWorldSpacePointers", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnPointerEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PointerDeviceState), Member = "SavePointerPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector3), typeof(IPanel), typeof(ContextType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60012E4")]
	internal void PointerEntersPanel(int pointerId, Vector3 position) { }

	[Address(RVA = "0x1C7D6D0", Offset = "0x1C7C8D0", Length = "0x125")]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "SendPositionBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(int), typeof(System.Nullable`1<System.Int32>), "System.Func`3<Vector3, TArg, EventBase>", "TArg", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "SendRayBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(float), typeof(int), "System.Func`3<Vector3, TArg, EventBase>", "TArg", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "UpdateWorldSpacePointers", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnPointerExit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ElementUnderPointer), Member = "SetTemporaryElementUnderPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int), typeof(EventBase)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "CommitElementUnderPointers", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PointerDeviceState), Member = "SavePointerPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector3), typeof(IPanel), typeof(ContextType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60012E3")]
	internal void PointerLeavesPanel(int pointerId) { }

	[Address(RVA = "0x1C7E7B0", Offset = "0x1C7D9B0", Length = "0xA2")]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "UnregisterCallbacks", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelRaycaster", Member = "set_panel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelRaycaster", Member = "UnregisterCallbacks", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelRaycaster", Member = "OnPanelDestroyed", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIToolkitInteroperabilityBridge", Member = "DestroyPanelGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseRuntimePanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60012CC")]
	public void remove_destroyed(Action value) { }

	[Address(RVA = "0x1C7E860", Offset = "0x1C7DA60", Length = "0xA2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60012D0")]
	internal void remove_drawsInCamerasChanged(Action value) { }

	[Address(RVA = "0x1C7D800", Offset = "0x1C7CA00", Length = "0x466")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[Calls(Type = typeof(Display), Member = "get_renderingHeight", ReturnType = typeof(int))]
	[Calls(Type = typeof(Screen), Member = "get_width", ReturnType = typeof(int))]
	[Calls(Type = typeof(Display), Member = "get_renderingWidth", ReturnType = typeof(int))]
	[Calls(Type = typeof(Panel), Member = "Render", ReturnType = typeof(void))]
	[Calls(Type = typeof(GL), Member = "Viewport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Camera), Member = "SetupCurrent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x60012DD")]
	public virtual void Render() { }

	[Address(RVA = "0x1C7DE60", Offset = "0x1C7D060", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60012E0")]
	internal Vector3 ScreenToPanel(Vector2 screen) { }

	[Address(RVA = "0x1C7DC70", Offset = "0x1C7CE70", Length = "0x1E8")]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "FindTargetAtPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(int), typeof(System.Nullable`1<System.Int32>), typeof(VisualElement&), typeof(RuntimePanel&), typeof(Vector3&), typeof(VisualElement&), typeof(Camera&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScreenOverlayPanelPicker), Member = "TryPick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseRuntimePanel), typeof(int), typeof(Vector2), typeof(Vector2), typeof(System.Nullable`1<System.Int32>), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler+PointerEvent", Member = "ComputeTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseRuntimePanel)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60012E1")]
	internal bool ScreenToPanel(Vector2 screenPosition, Vector2 screenDelta, out Vector3 panelPosition, bool allowOutside = false) { }

	[Address(RVA = "0x1C7E910", Offset = "0x1C7DB10", Length = "0x7D")]
	[CalledBy(Type = typeof(PanelSettings), Member = "ApplyPanelSettings", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "SetPanelsDrawInCameraDirty", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60012D3")]
	internal void set_drawsInCameras(bool value) { }

	[Address(RVA = "0x1C7E990", Offset = "0x1C7DB90", Length = "0x9")]
	[CalledBy(Type = typeof(PanelSettings), Member = "ApplyPanelSettings", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x60012D5")]
	internal void set_pixelsPerUnit(float value) { }

	[Address(RVA = "0x1C7E9A0", Offset = "0x1C7DBA0", Length = "0x84")]
	[CalledBy(Type = "UnityEngine.UIElements.PanelSettings+RuntimePanelAccess", Member = "get_panel", ReturnType = typeof(BaseRuntimePanel))]
	[CalledBy(Type = typeof(PanelSettings), Member = "SetScreenToPanelSpaceFunction3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`2<UnityEngine.Vector2, UnityEngine.Vector3>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelSettings), Member = "SetScreenToPanelSpaceFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`2<UnityEngine.Vector2, UnityEngine.Vector2>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60012DF")]
	public void set_screenToPanelSpace(Func<Vector2, Vector3> value) { }

	[Address(RVA = "0x1C7EA30", Offset = "0x1C7DC30", Length = "0xA0")]
	[CalledBy(Type = "UnityEngine.UIElements.UIToolkitInteroperabilityBridge", Member = "CreatePanelGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseRuntimePanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIToolkitInteroperabilityBridge", Member = "DestroyPanelGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseRuntimePanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseRuntimePanel), Member = "AssignPanelToComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseRuntimePanel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60012C8")]
	public override void set_selectableGameObject(GameObject value) { }

	[Address(RVA = "0x1C7EAD0", Offset = "0x1C7DCD0", Length = "0x8C")]
	[CalledBy(Type = "UnityEngine.UIElements.PanelSettings+RuntimePanelAccess", Member = "get_panel", ReturnType = typeof(BaseRuntimePanel))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelSettings+RuntimePanelAccess", Member = "SetSortingPriority", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelSettings), Member = "set_sortingOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelSettings), Member = "ApplySortingOrder", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "SetPanelOrderingDirty", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60012CA")]
	public void set_sortingPriority(float value) { }

	[Address(RVA = "0x1C7EB60", Offset = "0x1C7DD60", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x60012D7")]
	internal void set_targetDisplay(int value) { }

	[Address(RVA = "0x1C7DEE0", Offset = "0x1C7D0E0", Length = "0x1B7")]
	[CalledBy(Type = typeof(RuntimePanel), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(FocusController), Member = "SetFocusToLastFocusedElement", ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x60012DA")]
	internal override void Update() { }

}

