namespace UnityEngine.UIElements;

[Token(Token = "0x2000210")]
internal static class PointerDeviceState
{
	[Flags]
	[Token(Token = "0x2000211")]
	public enum LocationFlag
	{
		None = 0,
		OutsidePanel = 1,
	}

	[Token(Token = "0x2000212")]
	private struct PointerLocation
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000879")]
		private Vector3 <Position>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400087A")]
		private IPanel <Panel>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400087B")]
		private LocationFlag <Flags>k__BackingField; //Field offset: 0x18

		[Token(Token = "0x17000288")]
		internal LocationFlag Flags
		{
			[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[IsReadOnly]
			[Token(Token = "0x6000E7C")]
			internal get { } //Length: 4
			[Address(RVA = "0x2F79C0", Offset = "0x2F6BC0", Length = "0x4")]
			[CallerCount(Count = 3)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6000E7D")]
			private set { } //Length: 4
		}

		[Token(Token = "0x17000287")]
		internal IPanel Panel
		{
			[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
			[CallerCount(Count = 50)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[IsReadOnly]
			[Token(Token = "0x6000E7A")]
			internal get { } //Length: 5
			[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6000E7B")]
			private set { } //Length: 13
		}

		[Token(Token = "0x17000286")]
		internal Vector3 Position
		{
			[Address(RVA = "0x43C320", Offset = "0x43B520", Length = "0x12")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[IsReadOnly]
			[Token(Token = "0x6000E78")]
			internal get { } //Length: 18
			[Address(RVA = "0x43C340", Offset = "0x43B540", Length = "0xF")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6000E79")]
			private set { } //Length: 15
		}

		[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x6000E7C")]
		internal LocationFlag get_Flags() { }

		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x6000E7A")]
		internal IPanel get_Panel() { }

		[Address(RVA = "0x43C320", Offset = "0x43B520", Length = "0x12")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x6000E78")]
		internal Vector3 get_Position() { }

		[Address(RVA = "0x2F79C0", Offset = "0x2F6BC0", Length = "0x4")]
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E7D")]
		private void set_Flags(LocationFlag value) { }

		[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E7B")]
		private void set_Panel(IPanel value) { }

		[Address(RVA = "0x43C340", Offset = "0x43B540", Length = "0xF")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E79")]
		private void set_Position(Vector3 value) { }

		[Address(RVA = "0x1C5BE60", Offset = "0x1C5B060", Length = "0x136")]
		[CalledBy(Type = typeof(PointerDeviceState), Member = "SavePointerPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector3), typeof(IPanel), typeof(ContextType)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000E7E")]
		internal void SetLocation(Vector3 position, IPanel panel) { }

	}

	[Token(Token = "0x2000213")]
	internal class RuntimePointerState
	{
		[Token(Token = "0x2000214")]
		internal struct RaycastHit
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400087E")]
			public float distance; //Field offset: 0x0
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x400087F")]
			public Collider collider; //Field offset: 0x8
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000880")]
			public UIDocument document; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000881")]
			public VisualElement element; //Field offset: 0x18

		}

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400087C")]
		public RaycastHit hit; //Field offset: 0x10
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400087D")]
		public int updateFrameCount; //Field offset: 0x30

		[Address(RVA = "0x1C5D6B0", Offset = "0x1C5C8B0", Length = "0xE")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E80")]
		public RuntimePointerState() { }

		[Address(RVA = "0x1C5D690", Offset = "0x1C5C890", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000E7F")]
		public override void Reset() { }

	}

	[Token(Token = "0x2000215")]
	internal class ScreenPointerState : RuntimePointerState
	{
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000882")]
		public Vector2 mousePosition; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000883")]
		public Nullable<Int32> targetDisplay; //Field offset: 0x40

		[Address(RVA = "0x1C5D6B0", Offset = "0x1C5C8B0", Length = "0xE")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E82")]
		public ScreenPointerState() { }

		[Address(RVA = "0x1C5D6C0", Offset = "0x1C5C8C0", Length = "0x64")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000E81")]
		public virtual void Reset() { }

	}

	[Token(Token = "0x2000216")]
	internal class TrackedPointerState : RuntimePointerState
	{
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000884")]
		public Vector3 worldPosition; //Field offset: 0x38
		[FieldOffset(Offset = "0x44")]
		[Token(Token = "0x4000885")]
		public Quaternion worldOrientation; //Field offset: 0x44
		[FieldOffset(Offset = "0x54")]
		[Token(Token = "0x4000886")]
		public float maxDistance; //Field offset: 0x54

		[Token(Token = "0x17000289")]
		public Ray worldRay
		{
			[Address(RVA = "0x1C5DCA0", Offset = "0x1C5CEA0", Length = "0x19F")]
			[CalledBy(Type = typeof(DefaultEventSystem), Member = "UpdateWorldSpacePointers", ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AEB0")]
			[ContainsUnimplementedInstructions]
			[Token(Token = "0x6000E83")]
			 get { } //Length: 415
		}

		[Address(RVA = "0x1C5DC10", Offset = "0x1C5CE10", Length = "0x90")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000E85")]
		public TrackedPointerState() { }

		[Address(RVA = "0x1C5DCA0", Offset = "0x1C5CEA0", Length = "0x19F")]
		[CalledBy(Type = typeof(DefaultEventSystem), Member = "UpdateWorldSpacePointers", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AEB0")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000E83")]
		public Ray get_worldRay() { }

		[Address(RVA = "0x1C5DB70", Offset = "0x1C5CD70", Length = "0x92")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000E84")]
		public virtual void Reset() { }

	}

	[Token(Token = "0x4000870")]
	private static RuntimePointerState[] s_RuntimePointerStates; //Field offset: 0x0
	[Token(Token = "0x4000871")]
	private static PointerLocation[] s_PlayerPointerLocations; //Field offset: 0x8
	[Token(Token = "0x4000872")]
	private static Int32[] s_PressedButtons; //Field offset: 0x10
	[Token(Token = "0x4000873")]
	private static readonly RuntimePanel[] s_PlayerPanelWithSoftPointerCapture; //Field offset: 0x18
	[Token(Token = "0x4000874")]
	private static readonly UIDocument[] s_WorldSpaceDocumentWithSoftPointerCapture; //Field offset: 0x20
	[Token(Token = "0x4000875")]
	private static readonly Camera[] s_CameraWithSoftPointerCapture; //Field offset: 0x28

	[Address(RVA = "0x1C5ADE0", Offset = "0x1C59FE0", Length = "0x23B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000E77")]
	private static PointerDeviceState() { }

	[Address(RVA = "0x1C598E0", Offset = "0x1C58AE0", Length = "0x6F")]
	[CalledBy(Type = typeof(CameraScreenRaycaster), Member = "MakeRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int), typeof(System.Nullable`1<System.Int32>)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.ValueTuple`3<UnityEngine.Ray, UnityEngine.Camera, System.Boolean>>))]
	[CalledBy(Type = "UnityEngine.UIElements.WorldDocumentRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000E72")]
	internal static Camera GetCameraWithSoftPointerCapture(int pointerId) { }

	[Address(RVA = "0x1C59950", Offset = "0x1C58B50", Length = "0x76")]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "SendPositionBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(int), typeof(System.Nullable`1<System.Int32>), "System.Func`3<Vector3, TArg, EventBase>", "TArg", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "SendRayBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(float), typeof(int), "System.Func`3<Vector3, TArg, EventBase>", "TArg", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "UpdateWorldSpacePointers", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseVisualElementPanel), Member = "RecomputeTopElementUnderPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector2), typeof(EventBase)}, ReturnType = typeof(VisualElement))]
	[CalledBy(Type = typeof(BaseVisualElementPanel), Member = "UpdateElementUnderPointers", ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000E6B")]
	public static IPanel GetPanel(int pointerId, ContextType contextType) { }

	[Address(RVA = "0x1C599D0", Offset = "0x1C58BD0", Length = "0x6F")]
	[CalledBy(Type = typeof(PhysicsDocumentPicker), Member = "GetCapturingDocument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UIDocument&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ScreenOverlayPanelPicker), Member = "TryPick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseRuntimePanel), typeof(int), typeof(Vector2), typeof(Vector2), typeof(System.Nullable`1<System.Int32>), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ScreenOverlayPanelPicker), Member = "GetCapturingPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BaseVisualElementPanel&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000E70")]
	internal static RuntimePanel GetPlayerPanelWithSoftPointerCapture(int pointerId) { }

	[Address(RVA = "0x1C59A40", Offset = "0x1C58C40", Length = "0x15E")]
	[CalledBy(Type = typeof(PointerEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.PointerEvent", typeof(Vector3), typeof(int), typeof(float)}, ReturnType = "T")]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler+PointerEvent", Member = "ComputeTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseRuntimePanel)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000E6A")]
	public static Vector3 GetPointerDeltaPosition(int pointerId, ContextType contextType, Vector3 newPosition) { }

	[Address(RVA = "0x1C59BA0", Offset = "0x1C58DA0", Length = "0x99")]
	[CalledBy(Type = typeof(ElementUnderPointer), Member = "CommitElementUnderPointers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventDispatcher), typeof(ContextType)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BaseVisualElementPanel), Member = "UpdateElementUnderPointers", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000E69")]
	public static Vector3 GetPointerPosition(int pointerId, ContextType contextType) { }

	[Address(RVA = "0x1C59C40", Offset = "0x1C58E40", Length = "0x6E")]
	[CalledBy(Type = typeof(MouseEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "T")]
	[CalledBy(Type = typeof(PointerEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "T")]
	[CalledBy(Type = typeof(PointerEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventType), typeof(Vector3), typeof(Vector2), typeof(int), typeof(int), typeof(EventModifiers), typeof(int)}, ReturnType = "T")]
	[CalledBy(Type = typeof(PointerEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touch), typeof(int), typeof(EventModifiers), typeof(int)}, ReturnType = "T")]
	[CalledBy(Type = typeof(PointerEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PenData), typeof(EventModifiers), typeof(int)}, ReturnType = "T")]
	[CalledBy(Type = typeof(PointerEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.PointerEvent", typeof(Vector3), typeof(int), typeof(float)}, ReturnType = "T")]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler+PointerEvent", Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PanelEventHandler", "UnityEngine.EventSystems.PointerEventData", "UnityEngine.UIElements.PanelEventHandler+PointerEventType"}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000E6E")]
	public static int GetPressedButtons(int pointerId) { }

	[Address(RVA = "0x1C59CB0", Offset = "0x1C58EB0", Length = "0x1DF")]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "FindTargetAtPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(int), typeof(System.Nullable`1<System.Int32>), typeof(VisualElement&), typeof(RuntimePanel&), typeof(Vector3&), typeof(VisualElement&), typeof(Camera&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "UpdateWorldSpacePointers", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000E76")]
	internal static ScreenPointerState GetScreenPointerState(int pointerId, bool createIfNull = false) { }

	[Address(RVA = "0x1C59E90", Offset = "0x1C59090", Length = "0x259")]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "FindTargetAtRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(float), typeof(int), typeof(VisualElement&), typeof(RuntimePanel&), typeof(Vector3&), typeof(VisualElement&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "UpdateWorldSpacePointers", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000E74")]
	internal static TrackedPointerState GetTrackedState(int pointerId, bool createIfNull = false) { }

	[Address(RVA = "0x1C5A0F0", Offset = "0x1C592F0", Length = "0x6F")]
	[CalledBy(Type = typeof(PhysicsDocumentPicker), Member = "GetCapturingDocument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UIDocument&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000E71")]
	internal static UIDocument GetWorldSpaceDocumentWithSoftPointerCapture(int pointerId) { }

	[Address(RVA = "0x1C5A160", Offset = "0x1C59360", Length = "0x84")]
	[CalledBy(Type = typeof(PointerEventHelper), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventType), typeof(Vector3), typeof(Vector2), typeof(int), typeof(int), typeof(EventModifiers), typeof(int)}, ReturnType = typeof(EventBase))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000E6F")]
	internal static bool HasAdditionalPressedButtons(int pointerId, int exceptButtonId) { }

	[Address(RVA = "0x1C5A1F0", Offset = "0x1C593F0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000E6C")]
	private static bool HasFlagFast(LocationFlag flagSet, LocationFlag flag) { }

	[Address(RVA = "0x1C5A200", Offset = "0x1C59400", Length = "0x88")]
	[CalledBy(Type = typeof(BaseVisualElementPanel), Member = "RecomputeTopElementUnderPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector2), typeof(EventBase)}, ReturnType = typeof(VisualElement))]
	[CalledBy(Type = typeof(BaseVisualElementPanel), Member = "UpdateElementUnderPointers", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000E6D")]
	public static bool HasLocationFlag(int pointerId, ContextType contextType, LocationFlag flag) { }

	[Address(RVA = "0x1C5A290", Offset = "0x1C59490", Length = "0xEB")]
	[CalledBy(Type = typeof(PointerEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "T")]
	[CalledBy(Type = typeof(PointerEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventType), typeof(Vector3), typeof(Vector2), typeof(int), typeof(int), typeof(EventModifiers), typeof(int)}, ReturnType = "T")]
	[CalledBy(Type = typeof(PointerEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touch), typeof(int), typeof(EventModifiers), typeof(int)}, ReturnType = "T")]
	[CalledBy(Type = typeof(PointerEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PenData), typeof(EventModifiers), typeof(int)}, ReturnType = "T")]
	[CalledBy(Type = typeof(PointerEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.PointerEvent", typeof(Vector3), typeof(int), typeof(float)}, ReturnType = "T")]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler+PointerEvent", Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PanelEventHandler", "UnityEngine.EventSystems.PointerEventData", "UnityEngine.UIElements.PanelEventHandler+PointerEventType"}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000E66")]
	public static void PressButton(int pointerId, int buttonId) { }

	[Address(RVA = "0x1C5A380", Offset = "0x1C59580", Length = "0x72")]
	[CalledBy(Type = typeof(ContextualMenuManager), Member = "DisplayMenu", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(IEventHandler), typeof(DropdownMenu)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ContextualMenuManager), Member = "ResetPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000E68")]
	public static void ReleaseAllButtons(int pointerId) { }

	[Address(RVA = "0x1C5A400", Offset = "0x1C59600", Length = "0xEB")]
	[CalledBy(Type = typeof(PointerEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "T")]
	[CalledBy(Type = typeof(PointerEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventType), typeof(Vector3), typeof(Vector2), typeof(int), typeof(int), typeof(EventModifiers), typeof(int)}, ReturnType = "T")]
	[CalledBy(Type = typeof(PointerEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touch), typeof(int), typeof(EventModifiers), typeof(int)}, ReturnType = "T")]
	[CalledBy(Type = typeof(PointerEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PenData), typeof(EventModifiers), typeof(int)}, ReturnType = "T")]
	[CalledBy(Type = typeof(PointerEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.PointerEvent", typeof(Vector3), typeof(int), typeof(float)}, ReturnType = "T")]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler+PointerEvent", Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PanelEventHandler", "UnityEngine.EventSystems.PointerEventData", "UnityEngine.UIElements.PanelEventHandler+PointerEventType"}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000E67")]
	public static void ReleaseButton(int pointerId, int buttonId) { }

	[Address(RVA = "0x1C5A4F0", Offset = "0x1C596F0", Length = "0x1A8")]
	[CalledBy(Type = typeof(UIDocument), Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000E64")]
	internal static void RemoveDocumentData(UIDocument document) { }

	[Address(RVA = "0x1C5A6A0", Offset = "0x1C598A0", Length = "0x32B")]
	[CalledBy(Type = typeof(BaseVisualElementPanel), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Panel), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000E63")]
	internal static void RemovePanelData(IPanel panel) { }

	[Address(RVA = "0x1C5A9D0", Offset = "0x1C59BD0", Length = "0xE1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000E75")]
	internal static void RemoveTrackedState(int pointerId) { }

	[Address(RVA = "0x1C5AAC0", Offset = "0x1C59CC0", Length = "0xAF")]
	[CalledBy(Type = typeof(MouseEventBase`1), Member = "PreDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerEventBase`1), Member = "PreDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseRuntimePanel), Member = "PointerLeavesPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseRuntimePanel), Member = "PointerEntersPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector3)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PointerLocation), Member = "SetLocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(IPanel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000E65")]
	public static void SavePointerPosition(int pointerId, Vector3 position, IPanel panel, ContextType contextType) { }

	[Address(RVA = "0x1C5AB70", Offset = "0x1C59D70", Length = "0x262")]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "SendPositionBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(int), typeof(System.Nullable`1<System.Int32>), "System.Func`3<Vector3, TArg, EventBase>", "TArg", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "SendRayBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(float), typeof(int), "System.Func`3<Vector3, TArg, EventBase>", "TArg", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnPointerExit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(UIDocument), Member = "FindRootUIDocument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(UIDocument))]
	[Calls(Type = typeof(BaseRuntimePanel), Member = "get_drawsInCameras", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000E73")]
	internal static void SetElementWithSoftPointerCapture(int pointerId, VisualElement element, Camera camera) { }

}

