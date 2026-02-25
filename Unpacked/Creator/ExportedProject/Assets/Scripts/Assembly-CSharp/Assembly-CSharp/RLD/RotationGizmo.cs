namespace RLD;

[Token(Token = "0x200010D")]
public class RotationGizmo : GizmoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000488")]
	private GizmoPlaneSlider3D _xSlider; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000489")]
	private GizmoPlaneSlider3D _ySlider; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400048A")]
	private GizmoPlaneSlider3D _zSlider; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400048B")]
	private GizmoPlaneSlider3DCollection _axesSliders; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400048C")]
	private GizmoCap3D _midCap; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400048D")]
	private GizmoDblAxisRotationDrag3D _camXYRotationDrag; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400048E")]
	private GizmoPlaneSlider2D _camLookSlider; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x400048F")]
	private RotationGizmoHotkeys _hotkeys; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x4000490")]
	private RotationGizmoSettings3D _settings3D; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x4000491")]
	private RotationGizmoLookAndFeel3D _lookAndFeel3D; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x4000492")]
	private bool _useSnapEnableHotkey; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000493")]
	private RotationGizmoHotkeys _sharedHotkeys; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000494")]
	private RotationGizmoSettings3D _sharedSettings3D; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000495")]
	private RotationGizmoLookAndFeel3D _sharedLookAndFeel3D; //Field offset: 0x88

	[Token(Token = "0x17000367")]
	public RotationGizmoHotkeys Hotkeys
	{
		[Address(RVA = "0x522950", Offset = "0x521B50", Length = "0x11")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000AA5")]
		 get { } //Length: 17
	}

	[Token(Token = "0x17000366")]
	public RotationGizmoLookAndFeel3D LookAndFeel3D
	{
		[Address(RVA = "0x522970", Offset = "0x521B70", Length = "0x17")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000AA4")]
		 get { } //Length: 23
	}

	[Token(Token = "0x17000365")]
	public RotationGizmoSettings3D Settings3D
	{
		[Address(RVA = "0x522990", Offset = "0x521B90", Length = "0x17")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000AA3")]
		 get { } //Length: 23
	}

	[Token(Token = "0x1700036A")]
	public RotationGizmoHotkeys SharedHotkeys
	{
		[Address(RVA = "0x2DD190", Offset = "0x2DC390", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AAA")]
		 get { } //Length: 5
		[Address(RVA = "0x2DD440", Offset = "0x2DC640", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AAB")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000369")]
	public RotationGizmoLookAndFeel3D SharedLookAndFeel3D
	{
		[Address(RVA = "0x2DD210", Offset = "0x2DC410", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AA8")]
		 get { } //Length: 8
		[Address(RVA = "0x5229B0", Offset = "0x521BB0", Length = "0x2B")]
		[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "RegisterGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Gizmo)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(RotationGizmo), Member = "SetupSharedLookAndFeel", ReturnType = typeof(void))]
		[Token(Token = "0x6000AA9")]
		 set { } //Length: 43
	}

	[Token(Token = "0x17000368")]
	public RotationGizmoSettings3D SharedSettings3D
	{
		[Address(RVA = "0x2DD220", Offset = "0x2DC420", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AA6")]
		 get { } //Length: 8
		[Address(RVA = "0x5229E0", Offset = "0x521BE0", Length = "0x28")]
		[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "RegisterGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Gizmo)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(RotationGizmo), Member = "SetupSharedSettings", ReturnType = typeof(void))]
		[Token(Token = "0x6000AA7")]
		 set { } //Length: 40
	}

	[Token(Token = "0x1700036B")]
	public bool UseSnapEnableHotkey
	{
		[Address(RVA = "0x521560", Offset = "0x520760", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AAC")]
		 get { } //Length: 5
		[Address(RVA = "0x522A10", Offset = "0x521C10", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AAD")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x522810", Offset = "0x521A10", Length = "0x13E")]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "CreateRotationGizmo", ReturnType = typeof(RotationGizmo))]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "CreateObjectRotationGizmo", ReturnType = typeof(ObjectTransformGizmo))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(GizmoPlaneSlider3DCollection), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(RotationGizmoHotkeys), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(RotationGizmoSettings3D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(RotationGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoBehaviour), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000ABF")]
	public RotationGizmo() { }

	[Address(RVA = "0x522950", Offset = "0x521B50", Length = "0x11")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000AA5")]
	public RotationGizmoHotkeys get_Hotkeys() { }

	[Address(RVA = "0x522970", Offset = "0x521B70", Length = "0x17")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000AA4")]
	public RotationGizmoLookAndFeel3D get_LookAndFeel3D() { }

	[Address(RVA = "0x522990", Offset = "0x521B90", Length = "0x17")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000AA3")]
	public RotationGizmoSettings3D get_Settings3D() { }

	[Address(RVA = "0x2DD190", Offset = "0x2DC390", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AAA")]
	public RotationGizmoHotkeys get_SharedHotkeys() { }

	[Address(RVA = "0x2DD210", Offset = "0x2DC410", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AA8")]
	public RotationGizmoLookAndFeel3D get_SharedLookAndFeel3D() { }

	[Address(RVA = "0x2DD220", Offset = "0x2DC420", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AA6")]
	public RotationGizmoSettings3D get_SharedSettings3D() { }

	[Address(RVA = "0x521560", Offset = "0x520760", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AAC")]
	public bool get_UseSnapEnableHotkey() { }

	[Address(RVA = "0x521730", Offset = "0x520930", Length = "0xC0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CameraEx), Member = "EstimateZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000AAF")]
	public float GetZoomFactor(Vector3 position, Camera camera) { }

	[Address(RVA = "0x521660", Offset = "0x520860", Length = "0xC1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Gizmo), Member = "GetWorkCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CameraEx), Member = "EstimateZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000AAE")]
	public float GetZoomFactor(Vector3 position) { }

	[Address(RVA = "0x521800", Offset = "0x520A00", Length = "0x409")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "Internal_FromEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(RotationGizmo), Member = "SetupSharedLookAndFeel", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoPlaneSlider2D), Member = "SetDragChannel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoDragChannel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoPlaneSlider2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoPlaneSlider3DCollection), Member = "Make3DHoverPriorityHigherThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Priority)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoPlaneSlider3DCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPlaneSlider3D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoPlaneSlider3D), Member = "set_LocalRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoPlaneSlider3D), Member = "SetDragChannel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoDragChannel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoPlaneSlider3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoDragSession), Member = "AddTargetTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GizmoCap3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RotationGizmo), Member = "SetupSharedSettings", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000AB7")]
	public virtual void OnAttached() { }

	[Address(RVA = "0x521C10", Offset = "0x520E10", Length = "0x96")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(GizmoTransform), Member = "remove_Changed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoEntityTransformChangedHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000AB4")]
	public virtual void OnDetached() { }

	[Address(RVA = "0x521CB0", Offset = "0x520EB0", Length = "0x96")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(GizmoTransform), Member = "remove_Changed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoEntityTransformChangedHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000AB6")]
	public virtual void OnDisabled() { }

	[Address(RVA = "0x521D50", Offset = "0x520F50", Length = "0x96")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(GizmoTransform), Member = "add_Changed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoEntityTransformChangedHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000AB5")]
	public virtual void OnEnabled() { }

	[Address(RVA = "0x521DF0", Offset = "0x520FF0", Length = "0x247")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Gizmo), Member = "get_FocusCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_up", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_right", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RotationGizmoSettings3D), Member = "get_SnapMode", ReturnType = typeof(GizmoSnapMode))]
	[Calls(Type = typeof(GizmoDblAxisRotationDrag3D), Member = "SetWorkData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WorkData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000ABA")]
	public virtual void OnGizmoAttemptHandleDragBegin(int handleId) { }

	[Address(RVA = "0x3CAA40", Offset = "0x3C9C40", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AB3")]
	public virtual void OnGizmoEnabled() { }

	[Address(RVA = "0x522040", Offset = "0x521240", Length = "0x171")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(RTGizmosEngine), Member = "get_NumRenderCameras", ReturnType = typeof(int))]
	[Calls(Type = typeof(GizmoCap3D), Member = "ApplyZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoPlaneSlider3DCollection), Member = "ApplyZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RotationGizmo), Member = "UpdateCamLookSlider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x6000AB9")]
	public virtual void OnGizmoRender(Camera camera) { }

	[Address(RVA = "0x5221C0", Offset = "0x5213C0", Length = "0x47")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Gizmo), Member = "GetWorkCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(RotationGizmo), Member = "UpdateCamLookSlider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000ABE")]
	private void OnGizmoTransformChanged(GizmoTransform gizmoTransform, ChangeData changeData) { }

	[Address(RVA = "0x522210", Offset = "0x521410", Length = "0x25C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hotkeys), Member = "IsActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GizmoPlaneSlider3DCollection), Member = "SetSnapEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCap), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RotationGizmoSettings3D), Member = "get_DragSensitivity", ReturnType = typeof(float))]
	[Calls(Type = typeof(GizmoPlaneSlider3D), Member = "SetBorderVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoPlaneSlider2D), Member = "SetBorderVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Gizmo), Member = "get_FocusCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(RotationGizmo), Member = "UpdateCamLookSlider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AB8")]
	public virtual void OnGizmoUpdateBegin() { }

	[Address(RVA = "0x522470", Offset = "0x521670", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoPlaneSlider3DCollection), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000AB0")]
	public bool OwnsHandle(int handleId) { }

	[Address(RVA = "0x2DD440", Offset = "0x2DC640", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AAB")]
	public void set_SharedHotkeys(RotationGizmoHotkeys value) { }

	[Address(RVA = "0x5229B0", Offset = "0x521BB0", Length = "0x2B")]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "RegisterGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Gizmo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(RotationGizmo), Member = "SetupSharedLookAndFeel", ReturnType = typeof(void))]
	[Token(Token = "0x6000AA9")]
	public void set_SharedLookAndFeel3D(RotationGizmoLookAndFeel3D value) { }

	[Address(RVA = "0x5229E0", Offset = "0x521BE0", Length = "0x28")]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "RegisterGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Gizmo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(RotationGizmo), Member = "SetupSharedSettings", ReturnType = typeof(void))]
	[Token(Token = "0x6000AA7")]
	public void set_SharedSettings3D(RotationGizmoSettings3D value) { }

	[Address(RVA = "0x522A10", Offset = "0x521C10", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AAD")]
	public void set_UseSnapEnableHotkey(bool value) { }

	[Address(RVA = "0x5224D0", Offset = "0x5216D0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap), Member = "SetHoverable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000AB1")]
	public void SetMidCapHoverable(bool hoverable) { }

	[Address(RVA = "0x5224F0", Offset = "0x5216F0", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoPlaneSlider3DCollection), Member = "SetSnapEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AB2")]
	public void SetSnapEnabled(bool isEnabled) { }

	[Address(RVA = "0x522550", Offset = "0x521750", Length = "0xEF")]
	[CalledBy(Type = typeof(RotationGizmo), Member = "set_SharedLookAndFeel3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RotationGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RotationGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RotationGizmoLookAndFeel3D), Member = "ConnectSliderLookAndFeel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPlaneSlider3D), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RotationGizmoLookAndFeel3D), Member = "ConnectCamLookSliderLookAndFeel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPlaneSlider2D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000ABC")]
	private void SetupSharedLookAndFeel() { }

	[Address(RVA = "0x522640", Offset = "0x521840", Length = "0xC9")]
	[CalledBy(Type = typeof(RotationGizmo), Member = "set_SharedSettings3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RotationGizmoSettings3D)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RotationGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RotationGizmoSettings3D), Member = "ConnectSliderSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPlaneSlider3D), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RotationGizmoSettings3D), Member = "ConnectCamLookSliderSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPlaneSlider2D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000ABD")]
	private void SetupSharedSettings() { }

	[Address(RVA = "0x522710", Offset = "0x521910", Length = "0xFE")]
	[CalledBy(Type = typeof(RotationGizmo), Member = "OnGizmoUpdateBegin", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RotationGizmo), Member = "OnGizmoRender", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RotationGizmo), Member = "OnGizmoTransformChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform), typeof(ChangeData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GizmoCap3D), Member = "GetZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(GizmoCap3D), Member = "GetRealSphereRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(GizmoPlaneSlider2D), Member = "MakePolySphereBorder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float), typeof(int), typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000ABB")]
	private void UpdateCamLookSlider(Camera camera) { }

}

