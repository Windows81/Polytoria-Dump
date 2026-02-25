namespace RLD;

[Token(Token = "0x2000048")]
public class GizmoObjectVertexSnapDrag3D : GizmoDragSession
{
	[CompilerGenerated]
	[Token(Token = "0x2000049")]
	private sealed class <>c__DisplayClass22_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000135")]
		public List<GameObject> targetObjects; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000136")]
		public Camera focusCamera; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000137")]
		public QueryConfig boundsQConfig; //Field offset: 0x20
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000138")]
		public Vector2 inputDevicePos; //Field offset: 0x30

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000239")]
		public <>c__DisplayClass22_0() { }

		[Address(RVA = "0x3C8BF0", Offset = "0x3C7DF0", Length = "0x1EC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(ObjectBounds), Member = "CalcScreenRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Camera), typeof(QueryConfig)}, ReturnType = typeof(Rect))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "FindAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Predicate`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600023A")]
		internal bool <GatherDestinationObjects>b__0(GameObject a) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200004A")]
	private sealed class <>c__DisplayClass22_1
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000139")]
		public GameObject a; //Field offset: 0x10

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600023B")]
		public <>c__DisplayClass22_1() { }

		[Address(RVA = "0x3C8DE0", Offset = "0x3C7FE0", Length = "0x51")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(Transform), Member = "IsChildOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600023C")]
		internal bool <GatherDestinationObjects>b__1(GameObject b) { }

	}

	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400012F")]
	private IEnumerable<GameObject> _targetObjects; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000130")]
	private Vector3 _snapPivot; //Field offset: 0x70
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x4000131")]
	private bool _isActive; //Field offset: 0x7C
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000132")]
	private List<GameObject> _destinationObjects; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000133")]
	private GizmoObjectVertexSnapSettings _settings; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000134")]
	private List<GameObject> _visibleObjectBuffer; //Field offset: 0x90

	[Token(Token = "0x1700009B")]
	public virtual GizmoDragChannel DragChannel
	{
		[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x600022C")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700009A")]
	public virtual bool IsActive
	{
		[Address(RVA = "0x3BA910", Offset = "0x3B9B10", Length = "0x5")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600022B")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700009D")]
	public GizmoObjectVertexSnapSettings Settings
	{
		[Address(RVA = "0x3BA940", Offset = "0x3B9B40", Length = "0x19")]
		[CalledBy(Type = typeof(MoveGizmo), Member = "SetupSharedSettings", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmo), Member = "SetupSharedSettings", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600022E")]
		 set { } //Length: 25
	}

	[Token(Token = "0x1700009C")]
	public Vector3 SnapPivot
	{
		[Address(RVA = "0x3BA920", Offset = "0x3B9B20", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600022D")]
		 get { } //Length: 19
	}

	[Address(RVA = "0x3BA810", Offset = "0x3B9A10", Length = "0xF9")]
	[CalledBy(Type = typeof(MoveGizmo), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Settings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoDragSession), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000238")]
	public GizmoObjectVertexSnapDrag3D() { }

	[Address(RVA = "0x3B9480", Offset = "0x3B8680", Length = "0x3BD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(GizmoObjectVertexSnapDrag3D), Member = "GetWorldPointClosestToInputDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>), typeof(Vector3&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001AA10")]
	[Calls(Type = typeof(RTScene), Member = "RaycastSceneGridIfVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray)}, ReturnType = typeof(XZGridRayHit))]
	[Calls(Type = typeof(RTSceneGrid), Member = "CellFromWorldPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(XZGridCell))]
	[Calls(Type = typeof(XZGridCell), Member = "GetCenterAndCorners", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>))]
	[Calls(Type = typeof(Vector3Ex), Member = "GetPointClosestToPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>), typeof(Vector3)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000234")]
	protected virtual void CalculateDragValues() { }

	[Address(RVA = "0x3B9840", Offset = "0x3B8A40", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "get_layer", ReturnType = typeof(int))]
	[Calls(Type = typeof(LayerEx), Member = "IsLayerBitSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000236")]
	protected bool CanUseObjectAsSnapDestination(GameObject gameObject) { }

	[Address(RVA = "0x3B9880", Offset = "0x3B8A80", Length = "0x11")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000231")]
	protected virtual bool DoBeginSession() { }

	[Address(RVA = "0x3B98A0", Offset = "0x3B8AA0", Length = "0x66")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000233")]
	protected virtual void DoEndSession() { }

	[Address(RVA = "0x3B9910", Offset = "0x3B8B10", Length = "0x12")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoObjectVertexSnapDrag3D), Member = "GatherDestinationObjects", ReturnType = typeof(void))]
	[Token(Token = "0x6000232")]
	protected virtual bool DoUpdateSession() { }

	[Address(RVA = "0x3B9930", Offset = "0x3B8B30", Length = "0x4AC")]
	[CalledBy(Type = typeof(GizmoObjectVertexSnapDrag3D), Member = "DoUpdateSession", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001A950")]
	[Calls(Type = typeof(GameObjectEx), Member = "GetGameObjectType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(GameObjectType))]
	[Calls(Type = typeof(LayerEx), Member = "IsLayerBitSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "get_layer", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Predicate`1<System.Object>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTFocusCamera), Member = "GetVisibleObjects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x6000237")]
	private void GatherDestinationObjects() { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x600022C")]
	public virtual GizmoDragChannel get_DragChannel() { }

	[Address(RVA = "0x3BA910", Offset = "0x3B9B10", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600022B")]
	public virtual bool get_IsActive() { }

	[Address(RVA = "0x3BA920", Offset = "0x3B9B20", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600022D")]
	public Vector3 get_SnapPivot() { }

	[Address(RVA = "0x3B9DE0", Offset = "0x3B8FE0", Length = "0x958")]
	[CalledBy(Type = typeof(GizmoObjectVertexSnapDrag3D), Member = "SelectSnapPivotPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(GizmoObjectVertexSnapDrag3D), Member = "CalculateDragValues", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MeshVertexChunkCollection), Member = "GetWorldChunksHoveredByPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Matrix4x4), typeof(Camera)}, ReturnType = typeof(System.Collections.Generic.List`1<RLD.MeshVertexChunk>))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(MeshVertexChunk), Member = "GetWorldVertClosestToScreenPt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Matrix4x4), typeof(Camera)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Camera), Member = "WorldToScreenPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(ObjectBounds), Member = "CalcSpriteWorldOBB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(OBB))]
	[Calls(Type = typeof(CameraEx), Member = "ConvertWorldToScreenPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(Vector2Ex), Member = "GetPointClosestToPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>), typeof(Vector2)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(OBB), Member = "GetCenterAndCornerPoints", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>))]
	[Calls(Type = typeof(MeshVertexChunk), Member = "get_VertexCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Transform), Member = "get_localToWorldMatrix", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(MeshVertexChunkCollectionDb), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(MeshVertexChunkCollection))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObjectEx), Member = "GetMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001A950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MeshVertexChunkCollection), Member = "GetWorldVertChunkClosestToScreenPt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Matrix4x4), typeof(Camera)}, ReturnType = typeof(MeshVertexChunk))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000235")]
	protected bool GetWorldPointClosestToInputDevice(Camera focusCamera, IEnumerable<GameObject> gameObjects, out Vector3 point) { }

	[Address(RVA = "0x3BA740", Offset = "0x3B9940", Length = "0x76")]
	[CalledBy(Type = typeof(MoveGizmo), Member = "OnGizmoUpdateBegin", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "OnGizmoUpdateBegin", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Gizmo), Member = "get_FocusCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(GizmoObjectVertexSnapDrag3D), Member = "GetWorldPointClosestToInputDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>), typeof(Vector3&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000230")]
	public bool SelectSnapPivotPoint(Gizmo gizmo) { }

	[Address(RVA = "0x3BA940", Offset = "0x3B9B40", Length = "0x19")]
	[CalledBy(Type = typeof(MoveGizmo), Member = "SetupSharedSettings", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "SetupSharedSettings", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600022E")]
	public void set_Settings(GizmoObjectVertexSnapSettings value) { }

	[Address(RVA = "0x3BA7C0", Offset = "0x3B99C0", Length = "0x42")]
	[CalledBy(Type = typeof(MoveGizmo), Member = "SetVertexSnapTargetObjects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "SetMvVertexSnapTargetObjects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600022F")]
	public void SetTargetObjects(IEnumerable<GameObject> targetObjects) { }

}

