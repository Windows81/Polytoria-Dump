namespace RLD;

[Token(Token = "0x2000083")]
public class ObjectExtrudeGizmo : GizmoBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x2000085")]
	private sealed class <>c
	{
		[Token(Token = "0x40001D8")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40001D9")]
		public static Predicate<GameObject> <>9__61_0; //Field offset: 0x8

		[Address(RVA = "0x3E56F0", Offset = "0x3E48F0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60004AF")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004B0")]
		public <>c() { }

		[Address(RVA = "0x3E4DF0", Offset = "0x3E3FF0", Length = "0x60")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(GameObjectEx), Member = "GetGameObjectType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(GameObjectType))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60004B1")]
		internal bool <SetExtrudeTargets>b__61_0(GameObject item) { }

	}

	[Token(Token = "0x2000084")]
	private struct HandleDragExtrudeData
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001D5")]
		public Vector3 ExtrudeDir; //Field offset: 0x0
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x40001D6")]
		public Vector3 ExtrudeCenter; //Field offset: 0xC
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40001D7")]
		public int AxisIndex; //Field offset: 0x18

	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001C0")]
	private ObjectExtrudeGizmoExtrudeUpdateHandler ExtrudeUpdate; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001C1")]
	private List<GameObject> _objectBuffer; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001C2")]
	private Vector3 _boxSize; //Field offset: 0x30
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40001C3")]
	private GizmoSpace _extrudeSpace; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40001C4")]
	private List<GameObject> _targetParents; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40001C5")]
	private HashSet<GameObject> _ignoredParentObjects; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40001C6")]
	private QueryConfig _boundsQConfig; //Field offset: 0x50
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40001C7")]
	private SceneOverlapFilter _sceneOverlapFilter; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40001C8")]
	private ObjectExtrudeGizmoDragEnd _dragEndAction; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40001C9")]
	private HandleDragExtrudeData _handleDragExtrData; //Field offset: 0x70
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40001CA")]
	private GizmoLineSlider3D _rightExtrude; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40001CB")]
	private GizmoLineSlider3D _upExtrude; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40001CC")]
	private GizmoLineSlider3D _frontExtrude; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40001CD")]
	private GizmoLineSlider3D _leftExtrude; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40001CE")]
	private GizmoLineSlider3D _bottomExtrude; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40001CF")]
	private GizmoLineSlider3D _backExtrude; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40001D0")]
	private GizmoLineSlider3DCollection _extrudeSliders; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	[Token(Token = "0x40001D1")]
	private ObjectExtrudeGizmoLookAndFeel3D _lookAndFeel3D; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x40001D2")]
	private ObjectExtrudeGizmoLookAndFeel3D _sharedLookAndFeel3D; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	[Token(Token = "0x40001D3")]
	private ObjectExtrudeGizmoHotkeys _hotkeys; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x40001D4")]
	private ObjectExtrudeGizmoHotkeys _sharedHotkeys; //Field offset: 0xE0

	[Token(Token = "0x14000014")]
	public event ObjectExtrudeGizmoExtrudeUpdateHandler ExtrudeUpdate
	{
		[Address(RVA = "0x3DC9B0", Offset = "0x3DBBB0", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000480")]
		 add { } //Length: 158
		[Address(RVA = "0x3DCB80", Offset = "0x3DBD80", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000481")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x1700015C")]
	public Vector3 BoxCenter
	{
		[Address(RVA = "0x3CBA90", Offset = "0x3CAC90", Length = "0x35")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000488")]
		 get { } //Length: 53
	}

	[Token(Token = "0x17000161")]
	public Vector3 BoxLook
	{
		[Address(RVA = "0x3CBAD0", Offset = "0x3CACD0", Length = "0xA5")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600048D")]
		 get { } //Length: 165
	}

	[Token(Token = "0x1700015F")]
	public Vector3 BoxRight
	{
		[Address(RVA = "0x3CBB80", Offset = "0x3CAD80", Length = "0xA5")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600048B")]
		 get { } //Length: 165
	}

	[Token(Token = "0x1700015D")]
	public Quaternion BoxRotation
	{
		[Address(RVA = "0x3CBC30", Offset = "0x3CAE30", Length = "0x2D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000489")]
		 get { } //Length: 45
	}

	[Token(Token = "0x1700015E")]
	public Vector3 BoxSize
	{
		[Address(RVA = "0x3DCA50", Offset = "0x3DBC50", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600048A")]
		 get { } //Length: 19
	}

	[Token(Token = "0x17000160")]
	public Vector3 BoxUp
	{
		[Address(RVA = "0x3CBC60", Offset = "0x3CAE60", Length = "0xA5")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600048C")]
		 get { } //Length: 165
	}

	[Token(Token = "0x17000163")]
	public GizmoSpace ExtrudeSpace
	{
		[Address(RVA = "0x3DCA70", Offset = "0x3DBC70", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600048F")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700015A")]
	public ObjectExtrudeGizmoHotkeys Hotkeys
	{
		[Address(RVA = "0x3CBD30", Offset = "0x3CAF30", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000485")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000158")]
	public ObjectExtrudeGizmoLookAndFeel3D LookAndFeel3D
	{
		[Address(RVA = "0x3DCA80", Offset = "0x3DBC80", Length = "0x1A")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000482")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000164")]
	public int NumTargetParents
	{
		[Address(RVA = "0x3DCAA0", Offset = "0x3DBCA0", Length = "0x3C")]
		[CalledBy(Type = typeof(ObjectExtrudeGizmo), Member = "FitBoxToTargets", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000490")]
		 get { } //Length: 60
	}

	[Token(Token = "0x17000162")]
	public OBB OBB
	{
		[Address(RVA = "0x3DCAE0", Offset = "0x3DBCE0", Length = "0x93")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(OBB), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Quaternion)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600048E")]
		 get { } //Length: 147
	}

	[Token(Token = "0x1700015B")]
	public ObjectExtrudeGizmoHotkeys SharedHotkeys
	{
		[Address(RVA = "0x2DD1D0", Offset = "0x2DC3D0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000486")]
		 get { } //Length: 8
		[Address(RVA = "0x2DD4B0", Offset = "0x2DC6B0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000487")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000159")]
	public ObjectExtrudeGizmoLookAndFeel3D SharedLookAndFeel3D
	{
		[Address(RVA = "0x2DD1B0", Offset = "0x2DC3B0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000483")]
		 get { } //Length: 8
		[Address(RVA = "0x3DCC20", Offset = "0x3DBE20", Length = "0x2B")]
		[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "RegisterGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Gizmo)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(ObjectExtrudeGizmo), Member = "SetupSharedLookAndFeel", ReturnType = typeof(void))]
		[Token(Token = "0x6000484")]
		 set { } //Length: 43
	}

	[Address(RVA = "0x3DC730", Offset = "0x3DB930", Length = "0x27D")]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "CreateObjectExtrudeGizmo", ReturnType = typeof(ObjectExtrudeGizmo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SceneOverlapFilter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(GizmoLineSlider3DCollection), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectExtrudeGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Hotkeys), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(HotkeysStaticData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hotkeys), Member = "set_Key", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyCode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Settings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoBehaviour), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60004AE")]
	public ObjectExtrudeGizmo() { }

	[Address(RVA = "0x3DC9B0", Offset = "0x3DBBB0", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000480")]
	public void add_ExtrudeUpdate(ObjectExtrudeGizmoExtrudeUpdateHandler value) { }

	[Address(RVA = "0x3D8890", Offset = "0x3D7A90", Length = "0x6D5")]
	[CalledBy(Type = typeof(ObjectExtrudeGizmo), Member = "SetExtrudeSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoSpace)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectExtrudeGizmo), Member = "SetExtrudeTargets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectExtrudeGizmo), Member = "OnUndoRedoEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUndoRedoAction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "OnObjectSelectionRotated", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(OBB), Member = "Encapsulate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OBB)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoTransform), Member = "set_Rotation3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AABB), Member = "Encapsulate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AABB)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectBounds), Member = "CalcHierarchyWorldAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(QueryConfig)}, ReturnType = typeof(AABB))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(AABB), Member = "GetInvalid", ReturnType = typeof(AABB))]
	[Calls(Type = typeof(ObjectExtrudeGizmo), Member = "UpdateSnapSteps", ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectBounds), Member = "CalcHierarchyWorldOBB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(QueryConfig)}, ReturnType = typeof(OBB))]
	[Calls(Type = typeof(OBB), Member = "GetInvalid", ReturnType = typeof(OBB))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(GizmoTransform), Member = "set_Position3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ObjectExtrudeGizmo), Member = "get_NumTargetParents", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ObjectExtrudeGizmo), Member = "SetOBB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OBB)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Token(Token = "0x600049B")]
	public void FitBoxToTargets() { }

	[Address(RVA = "0x3CBA90", Offset = "0x3CAC90", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000488")]
	public Vector3 get_BoxCenter() { }

	[Address(RVA = "0x3CBAD0", Offset = "0x3CACD0", Length = "0xA5")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600048D")]
	public Vector3 get_BoxLook() { }

	[Address(RVA = "0x3CBB80", Offset = "0x3CAD80", Length = "0xA5")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600048B")]
	public Vector3 get_BoxRight() { }

	[Address(RVA = "0x3CBC30", Offset = "0x3CAE30", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000489")]
	public Quaternion get_BoxRotation() { }

	[Address(RVA = "0x3DCA50", Offset = "0x3DBC50", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600048A")]
	public Vector3 get_BoxSize() { }

	[Address(RVA = "0x3CBC60", Offset = "0x3CAE60", Length = "0xA5")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600048C")]
	public Vector3 get_BoxUp() { }

	[Address(RVA = "0x3DCA70", Offset = "0x3DBC70", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600048F")]
	public GizmoSpace get_ExtrudeSpace() { }

	[Address(RVA = "0x3CBD30", Offset = "0x3CAF30", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000485")]
	public ObjectExtrudeGizmoHotkeys get_Hotkeys() { }

	[Address(RVA = "0x3DCA80", Offset = "0x3DBC80", Length = "0x1A")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000482")]
	public ObjectExtrudeGizmoLookAndFeel3D get_LookAndFeel3D() { }

	[Address(RVA = "0x3DCAA0", Offset = "0x3DBCA0", Length = "0x3C")]
	[CalledBy(Type = typeof(ObjectExtrudeGizmo), Member = "FitBoxToTargets", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000490")]
	public int get_NumTargetParents() { }

	[Address(RVA = "0x3DCAE0", Offset = "0x3DBCE0", Length = "0x93")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OBB), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600048E")]
	public OBB get_OBB() { }

	[Address(RVA = "0x2DD1D0", Offset = "0x2DC3D0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000486")]
	public ObjectExtrudeGizmoHotkeys get_SharedHotkeys() { }

	[Address(RVA = "0x2DD1B0", Offset = "0x2DC3B0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000483")]
	public ObjectExtrudeGizmoLookAndFeel3D get_SharedLookAndFeel3D() { }

	[Address(RVA = "0x3D8F70", Offset = "0x3D8170", Length = "0x5B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000497")]
	public bool IsBackExtrudeHandle(int handleId) { }

	[Address(RVA = "0x3D8FD0", Offset = "0x3D81D0", Length = "0x5B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000495")]
	public bool IsBottomExtrudeHandle(int handleId) { }

	[Address(RVA = "0x3D9030", Offset = "0x3D8230", Length = "0x5B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000496")]
	public bool IsFrontExtrudeHandle(int handleId) { }

	[Address(RVA = "0x3D9090", Offset = "0x3D8290", Length = "0x5B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000493")]
	public bool IsLeftExtrudeHandle(int handleId) { }

	[Address(RVA = "0x3D90F0", Offset = "0x3D82F0", Length = "0x5B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000492")]
	public bool IsRightExtrudeHandle(int handleId) { }

	[Address(RVA = "0x3D9150", Offset = "0x3D8350", Length = "0x5B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000494")]
	public bool IsTopExtrudeHandle(int handleId) { }

	[Address(RVA = "0x3D91B0", Offset = "0x3D83B0", Length = "0x588")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoLineSlider3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectExtrudeGizmo), Member = "ValidateBoxSize", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineSlider3DCollection), Member = "SetSnapEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineSlider3DCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoLineSlider3D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineSlider3D), Member = "SetDragChannel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoDragChannel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(RTUndoRedo), Member = "add_RedoEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RedoEndHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectExtrudeGizmo), Member = "SetupSharedLookAndFeel", ReturnType = typeof(void))]
	[Calls(Type = typeof(RTUndoRedo), Member = "add_UndoEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UndoEndHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60004A0")]
	public virtual void OnAttached() { }

	[Address(RVA = "0x3D9740", Offset = "0x3D8940", Length = "0x176")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RTUndoRedo), Member = "remove_UndoEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UndoEndHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTUndoRedo), Member = "remove_RedoEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RedoEndHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoTransform), Member = "remove_Changed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoEntityTransformChangedHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x600049C")]
	public virtual void OnDetached() { }

	[Address(RVA = "0x3D98C0", Offset = "0x3D8AC0", Length = "0x96")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(GizmoTransform), Member = "remove_Changed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoEntityTransformChangedHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600049E")]
	public virtual void OnDisabled() { }

	[Address(RVA = "0x3D9960", Offset = "0x3D8B60", Length = "0x96")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(GizmoTransform), Member = "add_Changed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoEntityTransformChangedHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600049D")]
	public virtual void OnEnabled() { }

	[Address(RVA = "0x3D9A00", Offset = "0x3D8C00", Length = "0x628")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObjectEx), Member = "GetAllChildrenAndSelf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>))]
	[Calls(Type = typeof(ObjectExtrudeGizmoDragEnd), Member = "TakeUndoTargetSnapshots", ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectExtrudeGizmoDragEnd), Member = "SetTargetParents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ObjectExtrudeGizmoDragEnd), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineSlider3DCollection), Member = "ContainsCapId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GizmoLineSlider3DCollection), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 18)]
	[Token(Token = "0x60004A3")]
	public virtual void OnGizmoDragBegin(int handleId) { }

	[Address(RVA = "0x3DA030", Offset = "0x3D9230", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoLineSlider3DCollection), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GizmoLineSlider3DCollection), Member = "ContainsCapId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ObjectExtrudeGizmoDragEnd), Member = "TakeRedoTargetSnapshots", ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectExtrudeGizmoDragEnd), Member = "Execute", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004A5")]
	public virtual void OnGizmoDragEnd(int handleId) { }

	[Address(RVA = "0x3DA0B0", Offset = "0x3D92B0", Length = "0xCAE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObjectBounds), Member = "CalcHierarchyWorldOBB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(QueryConfig)}, ReturnType = typeof(OBB))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(GameObjectEx), Member = "InheritHierarchyLayers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(ObjectExtrudeGizmoDragEnd), Member = "AddExtrudeClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObjectEx), Member = "GetAllChildrenAndSelf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ObjectCloning), Member = "CloneHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Config)}, ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(RTScene), Member = "OverlapBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OBB), typeof(SceneOverlapFilter), typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(Hotkeys), Member = "IsActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Vector3), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC4C0")]
	[Calls(Type = typeof(GizmoLineSlider3DCollection), Member = "ContainsCapId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GizmoLineSlider3DCollection), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60004A4")]
	public virtual void OnGizmoDragUpdate(int handleId) { }

	[Address(RVA = "0x3CAA40", Offset = "0x3C9C40", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600049F")]
	public virtual void OnGizmoEnabled() { }

	[Address(RVA = "0x3DAD60", Offset = "0x3D9F60", Length = "0x3CA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GraphicsEx), Member = "DrawWireBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OBB)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(GizmoLineSlider3DCollection), Member = "GetRenderSortedSliders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(System.Collections.Generic.List`1<RLD.GizmoLineSlider3D>))]
	[Calls(Type = typeof(ObjectExtrudeGizmo), Member = "UpdateExtrudeSliderTransforms", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineSlider3DCollection), Member = "ApplyZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(OBB), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "SetPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "SetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineMaterial), Member = "get_Material", ReturnType = typeof(Material))]
	[Calls(Type = typeof(GizmoLineMaterial), Member = "ResetValuesToSensibleDefaults", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004A2")]
	public virtual void OnGizmoRender(Camera camera) { }

	[Address(RVA = "0x3DB130", Offset = "0x3DA330", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObjectExtrudeGizmo), Member = "UpdateExtrudeSliderTransforms", ReturnType = typeof(void))]
	[Token(Token = "0x60004A7")]
	private void OnGizmoTransformChanged(GizmoTransform gizmoTransform, ChangeData changeData) { }

	[Address(RVA = "0x3DB140", Offset = "0x3DA340", Length = "0x215")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObjectExtrudeGizmo), Member = "ValidateBoxSize", ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectExtrudeGizmo), Member = "UpdateExtrudeSliderTransforms", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Token(Token = "0x60004A1")]
	public virtual void OnGizmoUpdateBegin() { }

	[Address(RVA = "0x3DB360", Offset = "0x3DA560", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ObjectExtrudeGizmo), Member = "FitBoxToTargets", ReturnType = typeof(void))]
	[Token(Token = "0x60004AD")]
	private void OnUndoRedoEnd(IUndoRedoAction action) { }

	[Address(RVA = "0x3DB3E0", Offset = "0x3DA5E0", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoLineSlider3DCollection), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GizmoLineSlider3DCollection), Member = "ContainsCapId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000491")]
	public bool OwnsHandle(int handleId) { }

	[Address(RVA = "0x3DCB80", Offset = "0x3DBD80", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000481")]
	public void remove_ExtrudeUpdate(ObjectExtrudeGizmoExtrudeUpdateHandler value) { }

	[Address(RVA = "0x2DD4B0", Offset = "0x2DC6B0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000487")]
	public void set_SharedHotkeys(ObjectExtrudeGizmoHotkeys value) { }

	[Address(RVA = "0x3DCC20", Offset = "0x3DBE20", Length = "0x2B")]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "RegisterGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Gizmo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ObjectExtrudeGizmo), Member = "SetupSharedLookAndFeel", ReturnType = typeof(void))]
	[Token(Token = "0x6000484")]
	public void set_SharedLookAndFeel3D(ObjectExtrudeGizmoLookAndFeel3D value) { }

	[Address(RVA = "0x3DB440", Offset = "0x3DA640", Length = "0x13D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GizmoTransform), Member = "set_Rotation3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoTransform), Member = "set_Position3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60004A8")]
	private void SetAABB(AABB aabb) { }

	[Address(RVA = "0x3DB580", Offset = "0x3DA780", Length = "0x33")]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "SetTransformSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoSpace)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ObjectExtrudeGizmo), Member = "FitBoxToTargets", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000499")]
	public void SetExtrudeSpace(GizmoSpace extrudeSpace) { }

	[Address(RVA = "0x3DB5C0", Offset = "0x3DA7C0", Length = "0x1EC")]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "OnGizmoPostEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "OnTargetObjectGroupUpdated", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "RegisterGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Gizmo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GameObjectEx), Member = "FilterParentsOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Predicate`1<System.Object>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ObjectExtrudeGizmo), Member = "FitBoxToTargets", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600049A")]
	public void SetExtrudeTargets(IEnumerable<GameObject> extrudeTargets) { }

	[Address(RVA = "0x3DB7B0", Offset = "0x3DA9B0", Length = "0x1FE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000498")]
	public void SetIgnoredParentObjects(IEnumerable<GameObject> ignoredParentObjects) { }

	[Address(RVA = "0x3DB9B0", Offset = "0x3DABB0", Length = "0x107")]
	[CalledBy(Type = typeof(ObjectExtrudeGizmo), Member = "FitBoxToTargets", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GizmoTransform), Member = "set_Rotation3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoTransform), Member = "set_Position3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60004A9")]
	private void SetOBB(OBB obb) { }

	[Address(RVA = "0x3DBAC0", Offset = "0x3DACC0", Length = "0x1E2")]
	[CalledBy(Type = typeof(ObjectExtrudeGizmo), Member = "set_SharedLookAndFeel3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectExtrudeGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectExtrudeGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GizmoLineSlider3D), Member = "set_SharedLookAndFeel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoLineSlider3DLookAndFeel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60004AC")]
	private void SetupSharedLookAndFeel() { }

	[Address(RVA = "0x3DBCB0", Offset = "0x3DAEB0", Length = "0x7DB")]
	[CalledBy(Type = typeof(ObjectExtrudeGizmo), Member = "OnGizmoUpdateBegin", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectExtrudeGizmo), Member = "OnGizmoRender", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectExtrudeGizmo), Member = "OnGizmoTransformChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform), typeof(ChangeData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BoxMath), Member = "CalcBoxFaceCenter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Quaternion), typeof(BoxFace)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(GizmoLineSlider3D), Member = "set_StartPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(GizmoLineSlider3D), Member = "SetDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004A6")]
	private void UpdateExtrudeSliderTransforms() { }

	[Address(RVA = "0x3DC490", Offset = "0x3DB690", Length = "0x11B")]
	[CalledBy(Type = typeof(ObjectExtrudeGizmo), Member = "FitBoxToTargets", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 12)]
	[Token(Token = "0x60004AA")]
	private void UpdateSnapSteps() { }

	[Address(RVA = "0x3DC5B0", Offset = "0x3DB7B0", Length = "0x17D")]
	[CalledBy(Type = typeof(ObjectExtrudeGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectExtrudeGizmo), Member = "OnGizmoUpdateBegin", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 9)]
	[Token(Token = "0x60004AB")]
	private void ValidateBoxSize() { }

}

