namespace RLD;

[Token(Token = "0x2000108")]
public class ObjectTransformGizmo : GizmoBehaviour
{
	[Flags]
	[Token(Token = "0x200010A")]
	internal enum Channels
	{
		None = 0,
		Position = 1,
		Rotation = 2,
		Scale = 4,
		All = 7,
	}

	[Token(Token = "0x2000109")]
	internal class ObjectRestrictions
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400047A")]
		private Boolean[] _moveAxesMask; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400047B")]
		private Boolean[] _scaleAxesMask; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400047C")]
		private HashSet<Int32> _handleMask; //Field offset: 0x20

		[Address(RVA = "0x51DF40", Offset = "0x51D140", Length = "0xFB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Int32>), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000A9A")]
		public ObjectRestrictions() { }

		[Address(RVA = "0x51DC00", Offset = "0x51CE00", Length = "0x6C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000A98")]
		public Vector3 AdjustMoveVector(Vector3 moveVector) { }

		[Address(RVA = "0x51DC70", Offset = "0x51CE70", Length = "0x72")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000A99")]
		public Vector3 AdjustScaleVector(Vector3 scaleVector) { }

		[Address(RVA = "0x51DCF0", Offset = "0x51CEF0", Length = "0x49")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000A90")]
		public bool CanMoveAlongAllAxes() { }

		[Address(RVA = "0x51DD40", Offset = "0x51CF40", Length = "0x2F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000A92")]
		public bool CanMoveAlongAxis(int axisIndex) { }

		[Address(RVA = "0x51DD70", Offset = "0x51CF70", Length = "0x49")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000A91")]
		public bool CanScaleAlongAllAxes() { }

		[Address(RVA = "0x51DDC0", Offset = "0x51CFC0", Length = "0x2F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000A93")]
		public bool CanScaleAlongAxis(int axisIndex) { }

		[Address(RVA = "0x51DDF0", Offset = "0x51CFF0", Length = "0x54")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(HashSet`1), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000A96")]
		public bool IsAffectedByHandle(int handleId) { }

		[Address(RVA = "0x51DE50", Offset = "0x51D050", Length = "0x2B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000A94")]
		public void SetCanMoveAlongAxis(int axisIndex, bool canMove) { }

		[Address(RVA = "0x51DE80", Offset = "0x51D080", Length = "0x2B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000A95")]
		public void SetCanScaleAlongAxis(int axisIndex, bool canScale) { }

		[Address(RVA = "0x51DEB0", Offset = "0x51D0B0", Length = "0x8B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(HashSet`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000A97")]
		public void SetIsAffectedByHandle(int handleId, bool isAffected) { }

	}

	[Token(Token = "0x200010B")]
	private enum TargetObjectMode
	{
		Multiple = 0,
		Single = 1,
	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000468")]
	private TargetObjectMode _targetObjectMode; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000469")]
	private Channels _transformChannelFlags; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400046A")]
	private IEnumerable<GameObject> _targetObjects; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400046B")]
	private GameObject _targetPivotObject; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400046C")]
	private List<LocalTransformSnapshot> _preTransformSnapshots; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400046D")]
	private List<GameObject> _transformableParents; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400046E")]
	private AABB _targetGroupAABBOnDragBegin; //Field offset: 0x48
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x400046F")]
	private GizmoSpace _transformSpace; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000470")]
	private bool _isTransformSpacePermanent; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x4000471")]
	private GizmoObjectTransformPivot _transformPivot; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000472")]
	private bool _isTransformPivotPermanent; //Field offset: 0x70
	[FieldOffset(Offset = "0x71")]
	[Token(Token = "0x4000473")]
	private bool _scaleConstraintEnabled; //Field offset: 0x71
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x4000474")]
	private Vector3 _minPositiveScale; //Field offset: 0x74
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000475")]
	private Vector3 _customWorldPivot; //Field offset: 0x80
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000476")]
	private Dictionary<GameObject, Vector3> _objectToCustomLocalPivot; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000477")]
	private Dictionary<GameObject, ObjectRestrictions> _objectToRestrictions; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	[Token(Token = "0x4000478")]
	private ObjectTransformGizmoSettings _settings; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000479")]
	private ObjectTransformGizmoSettings _sharedSettings; //Field offset: 0xA8

	[Token(Token = "0x1700035C")]
	public bool CanAffectPosition
	{
		[Address(RVA = "0x521510", Offset = "0x520710", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000A5E")]
		 get { } //Length: 7
	}

	[Token(Token = "0x1700035D")]
	public bool CanAffectRotation
	{
		[Address(RVA = "0x521520", Offset = "0x520720", Length = "0x8")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000A5F")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700035E")]
	public bool CanAffectScale
	{
		[Address(RVA = "0x521530", Offset = "0x520730", Length = "0x8")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000A60")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700035F")]
	public Vector3 CustomWorldPivot
	{
		[Address(RVA = "0x521540", Offset = "0x520740", Length = "0x19")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000A61")]
		 get { } //Length: 25
	}

	[Token(Token = "0x17000358")]
	public bool IsTransformPivotPermanent
	{
		[Address(RVA = "0x521560", Offset = "0x520760", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A5A")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700035A")]
	public bool IsTransformSpacePermanent
	{
		[Address(RVA = "0x3BAA60", Offset = "0x3B9C60", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A5C")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000363")]
	public Vector3 MinPositiveScale
	{
		[Address(RVA = "0x521570", Offset = "0x520770", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A67")]
		 get { } //Length: 19
		[Address(RVA = "0x5215E0", Offset = "0x5207E0", Length = "0x63")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000A68")]
		 set { } //Length: 99
	}

	[Token(Token = "0x17000362")]
	public bool ScaleConstraintEnabled
	{
		[Address(RVA = "0x521590", Offset = "0x520790", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A65")]
		 get { } //Length: 5
		[Address(RVA = "0x521650", Offset = "0x520850", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A66")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000360")]
	public ObjectTransformGizmoSettings Settings
	{
		[Address(RVA = "0x5215A0", Offset = "0x5207A0", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000A62")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000361")]
	public ObjectTransformGizmoSettings SharedSettings
	{
		[Address(RVA = "0x2DD250", Offset = "0x2DC450", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A63")]
		 get { } //Length: 8
		[Address(RVA = "0x2DD5A0", Offset = "0x2DC7A0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A64")]
		 set { } //Length: 19
	}

	[Token(Token = "0x1700035B")]
	public Channels TransformChannelFlags
	{
		[Address(RVA = "0x309510", Offset = "0x308710", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A5D")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000357")]
	public GizmoObjectTransformPivot TransformPivot
	{
		[Address(RVA = "0x5215C0", Offset = "0x5207C0", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A59")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000359")]
	public GizmoSpace TransformSpace
	{
		[Address(RVA = "0x5215D0", Offset = "0x5207D0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A5B")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x521380", Offset = "0x520580", Length = "0x18F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Settings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoBehaviour), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000A8F")]
	public ObjectTransformGizmo() { }

	[Address(RVA = "0x51E3F0", Offset = "0x51D5F0", Length = "0x93")]
	[CalledBy(Type = typeof(ObjectTransformGizmo), Member = "RegisterObjectRestrictions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(ObjectRestrictions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectTransformGizmo), Member = "RegisterObjectRestrictions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(ObjectRestrictions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectTransformGizmo), Member = "UnregisterObjectRestrictions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectTransformGizmo), Member = "GetObjectRestrictions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(ObjectRestrictions))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000A6D")]
	public bool ContainsRestrictionsForObject(GameObject targetObject) { }

	[Address(RVA = "0x521510", Offset = "0x520710", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000A5E")]
	public bool get_CanAffectPosition() { }

	[Address(RVA = "0x521520", Offset = "0x520720", Length = "0x8")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000A5F")]
	public bool get_CanAffectRotation() { }

	[Address(RVA = "0x521530", Offset = "0x520730", Length = "0x8")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000A60")]
	public bool get_CanAffectScale() { }

	[Address(RVA = "0x521540", Offset = "0x520740", Length = "0x19")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000A61")]
	public Vector3 get_CustomWorldPivot() { }

	[Address(RVA = "0x521560", Offset = "0x520760", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A5A")]
	public bool get_IsTransformPivotPermanent() { }

	[Address(RVA = "0x3BAA60", Offset = "0x3B9C60", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A5C")]
	public bool get_IsTransformSpacePermanent() { }

	[Address(RVA = "0x521570", Offset = "0x520770", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A67")]
	public Vector3 get_MinPositiveScale() { }

	[Address(RVA = "0x521590", Offset = "0x520790", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A65")]
	public bool get_ScaleConstraintEnabled() { }

	[Address(RVA = "0x5215A0", Offset = "0x5207A0", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000A62")]
	public ObjectTransformGizmoSettings get_Settings() { }

	[Address(RVA = "0x2DD250", Offset = "0x2DC450", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A63")]
	public ObjectTransformGizmoSettings get_SharedSettings() { }

	[Address(RVA = "0x309510", Offset = "0x308710", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A5D")]
	public Channels get_TransformChannelFlags() { }

	[Address(RVA = "0x5215C0", Offset = "0x5207C0", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A59")]
	public GizmoObjectTransformPivot get_TransformPivot() { }

	[Address(RVA = "0x5215D0", Offset = "0x5207D0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A5B")]
	public GizmoSpace get_TransformSpace() { }

	[Address(RVA = "0x51E490", Offset = "0x51D690", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ObjectTransformGizmo), Member = "GetTransformableParentObjects", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000A7F")]
	public int GetNumTransformableParentObjects() { }

	[Address(RVA = "0x51E4E0", Offset = "0x51D6E0", Length = "0xB1")]
	[CalledBy(Type = typeof(ObjectTransformGizmo), Member = "GetTargetObjectGroupWorldAABB", ReturnType = typeof(AABB))]
	[CalledBy(Type = typeof(ObjectTransformGizmo), Member = "RefreshPosition", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectTransformGizmo), Member = "RotateObjects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectTransformGizmo), Member = "ScaleObjects", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000A8E")]
	private QueryConfig GetObjectBoundsQConfig() { }

	[Address(RVA = "0x51E5A0", Offset = "0x51D7A0", Length = "0x16C")]
	[CalledBy(Type = typeof(ObjectTransformGizmo), Member = "RefreshPosition", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectTransformGizmo), Member = "RotateObjects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectTransformGizmo), Member = "ScaleObjects", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "InverseTransformPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, UnityEngine.Vector3>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000A7C")]
	public Vector3 GetObjectCustomLocalPivot(GameObject gameObj) { }

	[Address(RVA = "0x51E710", Offset = "0x51D910", Length = "0x75")]
	[CalledBy(Type = typeof(ObjectTransformGizmo), Member = "MoveObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectTransformGizmo), Member = "RotateObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectTransformGizmo), Member = "ScaleObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Vector3)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ObjectTransformGizmo), Member = "ContainsRestrictionsForObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000A71")]
	public ObjectRestrictions GetObjectRestrictions(GameObject targetObject) { }

	[Address(RVA = "0x51E790", Offset = "0x51D990", Length = "0x3D3")]
	[CalledBy(Type = typeof(ObjectTransformGizmo), Member = "RefreshPosition", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectTransformGizmo), Member = "OnGizmoDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ObjectTransformGizmo), Member = "GetObjectBoundsQConfig", ReturnType = typeof(QueryConfig))]
	[Calls(Type = typeof(AABB), Member = "GetInvalid", ReturnType = typeof(AABB))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ObjectBounds), Member = "CalcWorldAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(QueryConfig)}, ReturnType = typeof(AABB))]
	[Calls(Type = typeof(AABB), Member = "Encapsulate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AABB)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000A7E")]
	public AABB GetTargetObjectGroupWorldAABB() { }

	[Address(RVA = "0x51EB70", Offset = "0x51DD70", Length = "0x291")]
	[CalledBy(Type = typeof(ObjectTransformGizmo), Member = "GetNumTransformableParentObjects", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ObjectTransformGizmo), Member = "OnGizmoDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(ObjectTransformGizmoSettings), Member = "IsObjectTransformable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LayerEx), Member = "IsLayerBitSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "get_layer", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(GameObjectEx), Member = "FilterParentsOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000A86")]
	private List<GameObject> GetTransformableParentObjects() { }

	[Address(RVA = "0x51EE10", Offset = "0x51E010", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000A6C")]
	public void MakeTransformPivotPermanent() { }

	[Address(RVA = "0x51EE20", Offset = "0x51E020", Length = "0x5")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A6B")]
	public void MakeTransformSpacePermanent() { }

	[Address(RVA = "0x51EE30", Offset = "0x51E030", Length = "0x204")]
	[CalledBy(Type = typeof(ObjectTransformGizmo), Member = "MoveObjects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ObjectTransformGizmo), Member = "GetObjectRestrictions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(ObjectRestrictions))]
	[Calls(Type = typeof(HashSet`1), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000A89")]
	private void MoveObject(GameObject gameObject, Vector3 moveVector) { }

	[Address(RVA = "0x51F040", Offset = "0x51E240", Length = "0x126")]
	[CalledBy(Type = typeof(ObjectTransformGizmo), Member = "OnGizmoDragUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ObjectTransformGizmo), Member = "MoveObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000A88")]
	private void MoveObjects(Vector3 moveVector) { }

	[Address(RVA = "0x51F170", Offset = "0x51E370", Length = "0x113")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RTUndoRedo), Member = "add_UndoEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UndoEndHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTUndoRedo), Member = "add_RedoEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RedoEndHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000A69")]
	public virtual void OnAttached() { }

	[Address(RVA = "0x51F290", Offset = "0x51E490", Length = "0x113")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RTUndoRedo), Member = "remove_UndoEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UndoEndHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTUndoRedo), Member = "remove_RedoEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RedoEndHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000A6A")]
	public virtual void OnDetached() { }

	[Address(RVA = "0x51F3B0", Offset = "0x51E5B0", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LocalTransformSnapshot), Member = "GetSnapshotCollection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>)}, ReturnType = typeof(System.Collections.Generic.List`1<RLD.LocalTransformSnapshot>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ObjectTransformGizmo), Member = "GetTransformableParentObjects", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>))]
	[Calls(Type = typeof(ObjectTransformGizmo), Member = "GetTargetObjectGroupWorldAABB", ReturnType = typeof(AABB))]
	[Token(Token = "0x6000A83")]
	public virtual void OnGizmoDragBegin(int handleId) { }

	[Address(RVA = "0x51F420", Offset = "0x51E620", Length = "0xBD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LocalTransformSnapshot), Member = "GetSnapshotCollection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>)}, ReturnType = typeof(System.Collections.Generic.List`1<RLD.LocalTransformSnapshot>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(PostObjectTransformsChangedAction), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<RLD.LocalTransformSnapshot>), typeof(System.Collections.Generic.List`1<RLD.LocalTransformSnapshot>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostObjectTransformsChangedAction), Member = "Execute", ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectTransformGizmo), Member = "RefreshPosition", ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectTransformGizmo), Member = "RefreshRotation", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000A85")]
	public virtual void OnGizmoDragEnd(int handleId) { }

	[Address(RVA = "0x51F4E0", Offset = "0x51E6E0", Length = "0xE1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Gizmo), Member = "get_RelativeDragOffset", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(ObjectTransformGizmo), Member = "MoveObjects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Gizmo), Member = "get_RelativeDragRotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(ObjectTransformGizmo), Member = "RotateObjects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectTransformGizmo), Member = "ScaleObjects", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000A84")]
	public virtual void OnGizmoDragUpdate(int handleId) { }

	[Address(RVA = "0x51F5D0", Offset = "0x51E7D0", Length = "0x7B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ObjectTransformGizmo), Member = "RefreshPosition", ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectTransformGizmo), Member = "RefreshRotation", ReturnType = typeof(void))]
	[Token(Token = "0x6000A87")]
	private void OnUndoRedoEnd(IUndoRedoAction action) { }

	[Address(RVA = "0x51F670", Offset = "0x51E870", Length = "0x347")]
	[CalledBy(Type = typeof(ObjectTransformGizmo), Member = "SetTargetPivotObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectTransformGizmo), Member = "SetTargetObjects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectTransformGizmo), Member = "SetTargetObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectTransformGizmo), Member = "SetTransformPivot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoObjectTransformPivot)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectTransformGizmo), Member = "SetCustomWorldPivot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectTransformGizmo), Member = "SetObjectCustomLocalPivot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectTransformGizmo), Member = "RefreshPositionAndRotation", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectTransformGizmo), Member = "OnGizmoDragEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectTransformGizmo), Member = "OnUndoRedoEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUndoRedoAction)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(GizmoTransform), Member = "set_Position3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectTransformGizmo), Member = "GetTargetObjectGroupWorldAABB", ReturnType = typeof(AABB))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(ObjectBounds), Member = "CalcWorldAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(QueryConfig)}, ReturnType = typeof(AABB))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ObjectTransformGizmo), Member = "GetObjectCustomLocalPivot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(ObjectTransformGizmo), Member = "GetObjectBoundsQConfig", ReturnType = typeof(QueryConfig))]
	[Calls(Type = typeof(Transform), Member = "TransformPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000A80")]
	public void RefreshPosition() { }

	[Address(RVA = "0x51F650", Offset = "0x51E850", Length = "0x1F")]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "OnGizmoPostEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "OnObjectSelectionRotated", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ObjectTransformGizmo), Member = "RefreshPosition", ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectTransformGizmo), Member = "RefreshRotation", ReturnType = typeof(void))]
	[Token(Token = "0x6000A82")]
	public void RefreshPositionAndRotation() { }

	[Address(RVA = "0x51F9C0", Offset = "0x51EBC0", Length = "0x125")]
	[CalledBy(Type = typeof(ObjectTransformGizmo), Member = "OnUndoRedoEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUndoRedoAction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectTransformGizmo), Member = "SetTargetPivotObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectTransformGizmo), Member = "SetTargetObjects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectTransformGizmo), Member = "SetTargetObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectTransformGizmo), Member = "SetTransformSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoSpace)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectTransformGizmo), Member = "RefreshPositionAndRotation", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectTransformGizmo), Member = "OnGizmoDragEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(GizmoTransform), Member = "set_Rotation3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000A81")]
	public void RefreshRotation() { }

	[Address(RVA = "0x51FB70", Offset = "0x51ED70", Length = "0x162")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ObjectTransformGizmo), Member = "ContainsRestrictionsForObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000A6F")]
	public void RegisterObjectRestrictions(List<GameObject> targetObjects, ObjectRestrictions restrictions) { }

	[Address(RVA = "0x51FAF0", Offset = "0x51ECF0", Length = "0x79")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ObjectTransformGizmo), Member = "ContainsRestrictionsForObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000A6E")]
	public void RegisterObjectRestrictions(GameObject targetObject, ObjectRestrictions restrictions) { }

	[Address(RVA = "0x51FCE0", Offset = "0x51EEE0", Length = "0x141")]
	[CalledBy(Type = typeof(ObjectTransformGizmo), Member = "RotateObjects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ObjectTransformGizmo), Member = "GetObjectRestrictions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(ObjectRestrictions))]
	[Calls(Type = typeof(HashSet`1), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(TransformEx), Member = "RotateAroundPivot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000A8B")]
	private void RotateObject(GameObject gameObject, Quaternion rotation, Vector3 rotationPivot) { }

	[Address(RVA = "0x51FE30", Offset = "0x51F030", Length = "0x698")]
	[CalledBy(Type = typeof(ObjectTransformGizmo), Member = "OnGizmoDragUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ObjectTransformGizmo), Member = "RotateObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(ObjectTransformGizmo), Member = "GetObjectBoundsQConfig", ReturnType = typeof(QueryConfig))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ObjectBounds), Member = "CalcWorldAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(QueryConfig)}, ReturnType = typeof(AABB))]
	[Calls(Type = typeof(ObjectTransformGizmo), Member = "GetObjectCustomLocalPivot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "TransformPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 10)]
	[Token(Token = "0x6000A8A")]
	private void RotateObjects(Quaternion rotation) { }

	[Address(RVA = "0x5204D0", Offset = "0x51F6D0", Length = "0x317")]
	[CalledBy(Type = typeof(ObjectTransformGizmo), Member = "ScaleObjects", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(HashSet`1), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Gizmo), Member = "get_RelativeDragScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(ObjectTransformGizmo), Member = "GetObjectRestrictions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(ObjectRestrictions))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(TransformEx), Member = "ScaleFromPivot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Gizmo), Member = "get_TotalDragScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_localScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000A8D")]
	private void ScaleObject(GameObject gameObject, Vector3 scalePivot) { }

	[Address(RVA = "0x5207F0", Offset = "0x51F9F0", Length = "0x5E1")]
	[CalledBy(Type = typeof(ObjectTransformGizmo), Member = "OnGizmoDragUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ObjectTransformGizmo), Member = "ScaleObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(ObjectTransformGizmo), Member = "GetObjectBoundsQConfig", ReturnType = typeof(QueryConfig))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ObjectBounds), Member = "CalcWorldAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(QueryConfig)}, ReturnType = typeof(AABB))]
	[Calls(Type = typeof(ObjectTransformGizmo), Member = "GetObjectCustomLocalPivot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "TransformPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 10)]
	[Token(Token = "0x6000A8C")]
	private void ScaleObjects() { }

	[Address(RVA = "0x5215E0", Offset = "0x5207E0", Length = "0x63")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000A68")]
	public void set_MinPositiveScale(Vector3 value) { }

	[Address(RVA = "0x521650", Offset = "0x520850", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A66")]
	public void set_ScaleConstraintEnabled(bool value) { }

	[Address(RVA = "0x2DD5A0", Offset = "0x2DC7A0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A64")]
	public void set_SharedSettings(ObjectTransformGizmoSettings value) { }

	[Address(RVA = "0x520DE0", Offset = "0x51FFE0", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000A73")]
	public void SetCanAffectPosition(bool affectPosition) { }

	[Address(RVA = "0x520E40", Offset = "0x520040", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000A74")]
	public void SetCanAffectRotation(bool affectRotation) { }

	[Address(RVA = "0x520EA0", Offset = "0x5200A0", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000A75")]
	public void SetCanAffectScale(bool affectScale) { }

	[Address(RVA = "0x520F00", Offset = "0x520100", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObjectTransformGizmo), Member = "RefreshPosition", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000A7A")]
	public void SetCustomWorldPivot(Vector3 pivot) { }

	[Address(RVA = "0x520F60", Offset = "0x520160", Length = "0x117")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, UnityEngine.Vector3>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, UnityEngine.Vector3>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectTransformGizmo), Member = "RefreshPosition", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000A7B")]
	public void SetObjectCustomLocalPivot(GameObject gameObj, Vector3 pivot) { }

	[Address(RVA = "0x521080", Offset = "0x520280", Length = "0xE6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ObjectTransformGizmo), Member = "RefreshPosition", ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectTransformGizmo), Member = "RefreshRotation", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000A78")]
	public void SetTargetObject(GameObject targetObject) { }

	[Address(RVA = "0x521170", Offset = "0x520370", Length = "0x5F")]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "RegisterGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Gizmo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ObjectTransformGizmo), Member = "RefreshPosition", ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectTransformGizmo), Member = "RefreshRotation", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000A77")]
	public void SetTargetObjects(IEnumerable<GameObject> targetObjects) { }

	[Address(RVA = "0x5211D0", Offset = "0x5203D0", Length = "0x5E")]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "OnTargetObjectGroupUpdated", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ObjectTransformGizmo), Member = "RefreshPosition", ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectTransformGizmo), Member = "RefreshRotation", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000A76")]
	public void SetTargetPivotObject(GameObject targetPivotObject) { }

	[Address(RVA = "0x521230", Offset = "0x520430", Length = "0x36")]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "CreateObjectMoveGizmo", ReturnType = typeof(ObjectTransformGizmo))]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "CreateObjectRotationGizmo", ReturnType = typeof(ObjectTransformGizmo))]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "CreateObjectScaleGizmo", ReturnType = typeof(ObjectTransformGizmo))]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "CreateObjectUniversalGizmo", ReturnType = typeof(ObjectTransformGizmo))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000A72")]
	public void SetTransformChannelFlags(Channels flags) { }

	[Address(RVA = "0x521270", Offset = "0x520470", Length = "0x45")]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "SetTransformPivot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoObjectTransformPivot)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ObjectTransformGizmo), Member = "RefreshPosition", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000A79")]
	public void SetTransformPivot(GizmoObjectTransformPivot transformPivot) { }

	[Address(RVA = "0x5212C0", Offset = "0x5204C0", Length = "0x45")]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "CreateObjectScaleGizmo", ReturnType = typeof(ObjectTransformGizmo))]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "SetTransformSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoSpace)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ObjectTransformGizmo), Member = "RefreshRotation", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000A7D")]
	public void SetTransformSpace(GizmoSpace transformSpace) { }

	[Address(RVA = "0x521310", Offset = "0x520510", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ObjectTransformGizmo), Member = "ContainsRestrictionsForObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000A70")]
	public void UnregisterObjectRestrictions(GameObject targetObject) { }

}

