namespace UnityEngine.EventSystems;

[AddComponentMenu("Event/Physics 2D Raycaster")]
[RequireComponent(typeof(Camera))]
[Token(Token = "0x20000C9")]
public class Physics2DRaycaster : PhysicsRaycaster
{
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400036A")]
	private RaycastHit2D[] m_Hits; //Field offset: 0x48

	[Address(RVA = "0x1CE8950", Offset = "0x1CE7B50", Length = "0x27")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x600078C")]
	protected Physics2DRaycaster() { }

	[Address(RVA = "0x1CE8100", Offset = "0x1CE7300", Length = "0x847")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SortingGroup), Member = "get_sortingOrder", ReturnType = typeof(int))]
	[Calls(Type = typeof(SortingGroup), Member = "get_sortingLayerID", ReturnType = typeof(int))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(SortingGroup), Member = "GetSortingGroupByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(SortingGroup))]
	[Calls(Type = typeof(Renderer), Member = "get_sortingOrder", ReturnType = typeof(int))]
	[Calls(Type = typeof(Renderer), Member = "get_sortingLayerID", ReturnType = typeof(int))]
	[Calls(Type = typeof(Renderer), Member = "get_sortingGroupOrder", ReturnType = typeof(int))]
	[Calls(Type = typeof(SortingGroup), Member = "get_invalidSortingGroupID", ReturnType = typeof(int))]
	[Calls(Type = typeof(Renderer), Member = "get_sortingGroupID", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(RaycastHit2D), Member = "get_collider", ReturnType = typeof(Collider2D))]
	[Calls(Type = typeof(PhysicsRaycaster), Member = "get_finalEventMask", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(ReflectionMethodsCache), Member = "get_Singleton", ReturnType = typeof(ReflectionMethodsCache))]
	[Calls(Type = typeof(PhysicsRaycaster), Member = "ComputeRayAndDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(Ray&), typeof(Int32&), typeof(Single&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800D4600")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600078D")]
	public virtual void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) { }

}

