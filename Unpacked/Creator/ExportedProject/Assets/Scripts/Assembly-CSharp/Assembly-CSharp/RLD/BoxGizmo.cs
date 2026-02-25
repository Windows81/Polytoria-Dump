namespace RLD;

[Token(Token = "0x200009D")]
public class BoxGizmo : GizmoBehaviour
{
	[Token(Token = "0x200009E")]
	internal enum Usage
	{
		Generic = 0,
		ObjectScale = 1,
	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400022B")]
	private Usage _usage; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400022C")]
	private bool _isUsagePermanent; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400022D")]
	private Vector3 _boxSize; //Field offset: 0x28
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400022E")]
	private GameObject _targetHierarchy; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400022F")]
	private Transform _targetHierarchyTransform; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000230")]
	private LocalTransformSnapshot _dragBeginTargetTransformSnapshot; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000231")]
	private GizmoCap2D _rightTick; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000232")]
	private GizmoCap2D _topTick; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000233")]
	private GizmoCap2D _backTick; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000234")]
	private GizmoCap2D _leftTick; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000235")]
	private GizmoCap2D _bottomTick; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000236")]
	private GizmoCap2D _frontTick; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000237")]
	private GizmoCap2DCollection _ticks; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000238")]
	private bool _scaleFromCenter; //Field offset: 0x88
	[FieldOffset(Offset = "0x8C")]
	[Token(Token = "0x4000239")]
	private Vector3 _scalePivot; //Field offset: 0x8C
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400023A")]
	private WorkData _scaleDragWorkData; //Field offset: 0x98
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x400023B")]
	private GizmoSglAxisScaleDrag3D _scaleDrag; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	[Token(Token = "0x400023C")]
	private BoxGizmoSettings3D _settings3D; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x400023D")]
	private BoxGizmoSettings3D _sharedSettings3D; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	[Token(Token = "0x400023E")]
	private BoxGizmoLookAndFeel3D _lookAndFeel3D; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x400023F")]
	private BoxGizmoLookAndFeel3D _sharedLookAndFeel3D; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4000240")]
	private BoxGizmoHotkeys _hotkeys; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4000241")]
	private BoxGizmoHotkeys _sharedHotkeys; //Field offset: 0xF0

	[Token(Token = "0x170001C1")]
	public Vector3 BoxCenter
	{
		[Address(RVA = "0x3CBA90", Offset = "0x3CAC90", Length = "0x35")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60005A0")]
		 get { } //Length: 53
	}

	[Token(Token = "0x170001C5")]
	public Vector3 BoxLook
	{
		[Address(RVA = "0x3CBAD0", Offset = "0x3CACD0", Length = "0xA5")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60005A4")]
		 get { } //Length: 165
	}

	[Token(Token = "0x170001C3")]
	public Vector3 BoxRight
	{
		[Address(RVA = "0x3CBB80", Offset = "0x3CAD80", Length = "0xA5")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60005A2")]
		 get { } //Length: 165
	}

	[Token(Token = "0x170001C2")]
	public Quaternion BoxRotation
	{
		[Address(RVA = "0x3CBC30", Offset = "0x3CAE30", Length = "0x2D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60005A1")]
		 get { } //Length: 45
	}

	[Token(Token = "0x170001C4")]
	public Vector3 BoxUp
	{
		[Address(RVA = "0x3CBC60", Offset = "0x3CAE60", Length = "0xA5")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60005A3")]
		 get { } //Length: 165
	}

	[Token(Token = "0x170001BF")]
	public Usage BoxUsage
	{
		[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x600059E")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170001BD")]
	public BoxGizmoHotkeys Hotkeys
	{
		[Address(RVA = "0x3CBD10", Offset = "0x3CAF10", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600059B")]
		 get { } //Length: 26
	}

	[Token(Token = "0x170001C0")]
	public bool IsUsagePermanent
	{
		[Address(RVA = "0x387940", Offset = "0x386B40", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600059F")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001BB")]
	public BoxGizmoLookAndFeel3D LookAndFeel3D
	{
		[Address(RVA = "0x3CBD30", Offset = "0x3CAF30", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000598")]
		 get { } //Length: 26
	}

	[Token(Token = "0x170001B9")]
	public BoxGizmoSettings3D Settings3D
	{
		[Address(RVA = "0x3CBD50", Offset = "0x3CAF50", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000595")]
		 get { } //Length: 26
	}

	[Token(Token = "0x170001BE")]
	public BoxGizmoHotkeys SharedHotkeys
	{
		[Address(RVA = "0x3CBD70", Offset = "0x3CAF70", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600059C")]
		 get { } //Length: 8
		[Address(RVA = "0x3CBD80", Offset = "0x3CAF80", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x600059D")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170001BC")]
	public BoxGizmoLookAndFeel3D SharedLookAndFeel3D
	{
		[Address(RVA = "0x2DD1D0", Offset = "0x2DC3D0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000599")]
		 get { } //Length: 8
		[Address(RVA = "0x3CBDA0", Offset = "0x3CAFA0", Length = "0x2B")]
		[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "RegisterGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Gizmo)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(BoxGizmo), Member = "SetupSharedLookAndFeel", ReturnType = typeof(void))]
		[Token(Token = "0x600059A")]
		 set { } //Length: 43
	}

	[Token(Token = "0x170001BA")]
	public BoxGizmoSettings3D SharedSettings3D
	{
		[Address(RVA = "0x2DD1B0", Offset = "0x2DC3B0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000596")]
		 get { } //Length: 8
		[Address(RVA = "0x2DD470", Offset = "0x2DC670", Length = "0x13")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000597")]
		 set { } //Length: 19
	}

	[Address(RVA = "0x3CB900", Offset = "0x3CAB00", Length = "0x18D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GizmoCap2DCollection), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoSglAxisScaleDrag3D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BoxGizmoSettings3D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BoxGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BoxGizmoHotkeys), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoBehaviour), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60005C1")]
	public BoxGizmo() { }

	[Address(RVA = "0x3C8F30", Offset = "0x3C8130", Length = "0x9D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ObjectBounds), Member = "CalcHierarchyWorldOBB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(QueryConfig)}, ReturnType = typeof(OBB))]
	[Token(Token = "0x60005C0")]
	private OBB CalcTargetRootOBB(GameObject targetRoot) { }

	[Address(RVA = "0x3C8FD0", Offset = "0x3C81D0", Length = "0x239")]
	[CalledBy(Type = typeof(BoxGizmo), Member = "SetTargetHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BoxGizmo), Member = "OnGizmoDragUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoxGizmo), Member = "OnUndoRedoEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUndoRedoAction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "OnObjectSelectionRotated", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorController), Member = "PropertyGrid_ValueChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(PropertyInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(GizmoTransform), Member = "set_Position3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectBounds), Member = "CalcHierarchyWorldOBB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(QueryConfig)}, ReturnType = typeof(OBB))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GizmoTransform), Member = "set_Rotation3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60005B2")]
	public bool FitBoxToTargetHierarchy() { }

	[Address(RVA = "0x3CBA90", Offset = "0x3CAC90", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60005A0")]
	public Vector3 get_BoxCenter() { }

	[Address(RVA = "0x3CBAD0", Offset = "0x3CACD0", Length = "0xA5")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60005A4")]
	public Vector3 get_BoxLook() { }

	[Address(RVA = "0x3CBB80", Offset = "0x3CAD80", Length = "0xA5")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60005A2")]
	public Vector3 get_BoxRight() { }

	[Address(RVA = "0x3CBC30", Offset = "0x3CAE30", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60005A1")]
	public Quaternion get_BoxRotation() { }

	[Address(RVA = "0x3CBC60", Offset = "0x3CAE60", Length = "0xA5")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60005A3")]
	public Vector3 get_BoxUp() { }

	[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x600059E")]
	public Usage get_BoxUsage() { }

	[Address(RVA = "0x3CBD10", Offset = "0x3CAF10", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600059B")]
	public BoxGizmoHotkeys get_Hotkeys() { }

	[Address(RVA = "0x387940", Offset = "0x386B40", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600059F")]
	public bool get_IsUsagePermanent() { }

	[Address(RVA = "0x3CBD30", Offset = "0x3CAF30", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000598")]
	public BoxGizmoLookAndFeel3D get_LookAndFeel3D() { }

	[Address(RVA = "0x3CBD50", Offset = "0x3CAF50", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000595")]
	public BoxGizmoSettings3D get_Settings3D() { }

	[Address(RVA = "0x3CBD70", Offset = "0x3CAF70", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600059C")]
	public BoxGizmoHotkeys get_SharedHotkeys() { }

	[Address(RVA = "0x2DD1D0", Offset = "0x2DC3D0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000599")]
	public BoxGizmoLookAndFeel3D get_SharedLookAndFeel3D() { }

	[Address(RVA = "0x2DD1B0", Offset = "0x2DC3B0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000596")]
	public BoxGizmoSettings3D get_SharedSettings3D() { }

	[Address(RVA = "0x3C9210", Offset = "0x3C8410", Length = "0x55")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60005AB")]
	public bool IsXTick(int handleId) { }

	[Address(RVA = "0x3C9270", Offset = "0x3C8470", Length = "0x55")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60005AC")]
	public bool IsYTick(int handleId) { }

	[Address(RVA = "0x3C92D0", Offset = "0x3C84D0", Length = "0x55")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60005AD")]
	public bool IsZTick(int handleId) { }

	[Address(RVA = "0x3C9330", Offset = "0x3C8530", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60005A9")]
	public void MakeUsagePermanent() { }

	[Address(RVA = "0x3C9340", Offset = "0x3C8540", Length = "0x332")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RTUndoRedo), Member = "add_UndoEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UndoEndHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTUndoRedo), Member = "add_RedoEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RedoEndHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCap2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GizmoCap2DCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoCap2D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCap2DCollection), Member = "SetDragSession", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IGizmoDragSession)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BoxGizmo), Member = "SetupSharedLookAndFeel", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60005B3")]
	public virtual void OnAttached() { }

	[Address(RVA = "0x3C9680", Offset = "0x3C8880", Length = "0x17B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(GizmoTransform), Member = "remove_Changed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoEntityTransformChangedHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(RTUndoRedo), Member = "remove_UndoEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UndoEndHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTUndoRedo), Member = "remove_RedoEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RedoEndHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60005A5")]
	public virtual void OnDetached() { }

	[Address(RVA = "0x3C9800", Offset = "0x3C8A00", Length = "0x96")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(GizmoTransform), Member = "remove_Changed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoEntityTransformChangedHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60005A7")]
	public virtual void OnDisabled() { }

	[Address(RVA = "0x3C98A0", Offset = "0x3C8AA0", Length = "0x96")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(GizmoTransform), Member = "add_Changed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoEntityTransformChangedHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60005A6")]
	public virtual void OnEnabled() { }

	[Address(RVA = "0x3C9940", Offset = "0x3C8B40", Length = "0x8EC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GizmoCap2DCollection), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hotkeys), Member = "IsActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Transform), Member = "get_lossyScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BoxMath), Member = "CalcBoxFaceCenter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Quaternion), typeof(BoxFace)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(GizmoSglAxisScaleDrag3D), Member = "SetWorkData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WorkData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LocalTransformSnapshot), Member = "Snapshot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 12)]
	[Token(Token = "0x60005B7")]
	public virtual void OnGizmoAttemptHandleDragBegin(int handleId) { }

	[Address(RVA = "0x3CA230", Offset = "0x3C9430", Length = "0x126")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60005B4")]
	public virtual bool OnGizmoCanBeginDrag(int handleId) { }

	[Address(RVA = "0x3CA360", Offset = "0x3C9560", Length = "0x1AA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GizmoCap2DCollection), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(LocalTransformSnapshot), Member = "Snapshot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(PostObjectTransformsChangedAction), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<RLD.LocalTransformSnapshot>), typeof(System.Collections.Generic.List`1<RLD.LocalTransformSnapshot>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostObjectTransformsChangedAction), Member = "Execute", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60005B9")]
	public virtual void OnGizmoDragEnd(int handleId) { }

	[Address(RVA = "0x3CA510", Offset = "0x3C9710", Length = "0x524")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TransformEx), Member = "ScaleFromPivot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Vector3), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(BoxGizmo), Member = "FitBoxToTargetHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_localScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GizmoCap2DCollection), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BoxGizmo), Member = "ValidateBoxSize", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoTransform), Member = "set_Position3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BoxGizmo), Member = "UpdateTickPositions", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60005B8")]
	public virtual void OnGizmoDragUpdate(int handleId) { }

	[Address(RVA = "0x3CAA40", Offset = "0x3C9C40", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60005A8")]
	public virtual void OnGizmoEnabled() { }

	[Address(RVA = "0x3CAA60", Offset = "0x3C9C60", Length = "0x336")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GizmoLineMaterial), Member = "ResetValuesToSensibleDefaults", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineMaterial), Member = "get_Material", ReturnType = typeof(Material))]
	[Calls(Type = typeof(Material), Member = "SetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "SetPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(OBB), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GraphicsEx), Member = "DrawWireBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OBB)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(BoxGizmo), Member = "UpdateTickPositions", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x60005B6")]
	public virtual void OnGizmoRender(Camera camera) { }

	[Address(RVA = "0x3CADA0", Offset = "0x3C9FA0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BoxGizmo), Member = "UpdateTickPositions", ReturnType = typeof(void))]
	[Token(Token = "0x60005BF")]
	private void OnGizmoTransformChanged(GizmoTransform gizmoTransform, ChangeData changeData) { }

	[Address(RVA = "0x3CADB0", Offset = "0x3C9FB0", Length = "0xA0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hotkeys), Member = "IsActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BoxGizmo), Member = "UpdateTickPositions", ReturnType = typeof(void))]
	[Calls(Type = typeof(BoxGizmo), Member = "ValidateBoxSize", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60005B5")]
	public virtual void OnGizmoUpdateBegin() { }

	[Address(RVA = "0x3CAE60", Offset = "0x3CA060", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BoxGizmo), Member = "FitBoxToTargetHierarchy", ReturnType = typeof(bool))]
	[Token(Token = "0x60005BA")]
	private void OnUndoRedoEnd(IUndoRedoAction action) { }

	[Address(RVA = "0x3CAEE0", Offset = "0x3CA0E0", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap2DCollection), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60005AA")]
	public bool OwnsHandle(int handleId) { }

	[Address(RVA = "0x3CBD80", Offset = "0x3CAF80", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600059D")]
	public void set_SharedHotkeys(BoxGizmoHotkeys value) { }

	[Address(RVA = "0x3CBDA0", Offset = "0x3CAFA0", Length = "0x2B")]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "RegisterGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Gizmo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(BoxGizmo), Member = "SetupSharedLookAndFeel", ReturnType = typeof(void))]
	[Token(Token = "0x600059A")]
	public void set_SharedLookAndFeel3D(BoxGizmoLookAndFeel3D value) { }

	[Address(RVA = "0x2DD470", Offset = "0x2DC670", Length = "0x13")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000597")]
	public void set_SharedSettings3D(BoxGizmoSettings3D value) { }

	[Address(RVA = "0x3CAF10", Offset = "0x3CA110", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BoxGizmo), Member = "UpdateTickPositions", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60005AF")]
	public void SetSize(Vector3 size) { }

	[Address(RVA = "0x3CAF60", Offset = "0x3CA160", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60005AE")]
	public void SetSnapEnabled(bool isEnabled) { }

	[Address(RVA = "0x3CAF80", Offset = "0x3CA180", Length = "0x18A")]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "OnGizmoPostEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "OnTargetObjectGroupUpdated", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(BoxGizmo), Member = "FitBoxToTargetHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GizmoCap2DCollection), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCap2DCollection), Member = "SetHoverable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60005B1")]
	public bool SetTargetHierarchy(GameObject targetHierarchy) { }

	[Address(RVA = "0x3CB180", Offset = "0x3CA380", Length = "0x154")]
	[CalledBy(Type = typeof(BoxGizmo), Member = "set_SharedLookAndFeel3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BoxGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoxGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BoxGizmoLookAndFeel3D), Member = "ConnectTickLookAndFeel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoCap2D), typeof(int), typeof(AxisSign)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60005BD")]
	private void SetupSharedLookAndFeel() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60005BE")]
	private void SetupSharedSettings() { }

	[Address(RVA = "0x3CB110", Offset = "0x3CA310", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap2DCollection), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCap2DCollection), Member = "SetHoverable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60005B0")]
	public void SetUsage(Usage usage) { }

	[Address(RVA = "0x3CB2E0", Offset = "0x3CA4E0", Length = "0x4A9")]
	[CalledBy(Type = typeof(BoxGizmo), Member = "SetSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoxGizmo), Member = "OnGizmoUpdateBegin", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoxGizmo), Member = "OnGizmoRender", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoxGizmo), Member = "OnGizmoDragUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoxGizmo), Member = "OnGizmoTransformChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform), typeof(ChangeData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Gizmo), Member = "GetWorkCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BoxMath), Member = "CalcBoxFaceCenter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Quaternion), typeof(BoxFace)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Camera), Member = "WorldToScreenPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(GizmoCap2D), Member = "set_Position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60005BB")]
	private void UpdateTickPositions() { }

	[Address(RVA = "0x3CB790", Offset = "0x3CA990", Length = "0x162")]
	[CalledBy(Type = typeof(BoxGizmo), Member = "OnGizmoUpdateBegin", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoxGizmo), Member = "OnGizmoDragUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GizmoCap), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60005BC")]
	private void ValidateBoxSize() { }

}

