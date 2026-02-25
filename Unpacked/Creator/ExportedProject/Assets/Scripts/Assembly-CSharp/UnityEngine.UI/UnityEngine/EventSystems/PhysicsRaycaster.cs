namespace UnityEngine.EventSystems;

[AddComponentMenu("Event/Physics Raycaster")]
[RequireComponent(typeof(Camera))]
[Token(Token = "0x20000CA")]
public class PhysicsRaycaster : BaseRaycaster
{
	[Token(Token = "0x20000CB")]
	private class RaycastHitComparer : IComparer<RaycastHit>
	{
		[Token(Token = "0x4000371")]
		public static RaycastHitComparer instance; //Field offset: 0x0

		[Address(RVA = "0x1CECE90", Offset = "0x1CEC090", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600079A")]
		private static RaycastHitComparer() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000799")]
		public RaycastHitComparer() { }

		[Address(RVA = "0x1CECE50", Offset = "0x1CEC050", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(float), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x6000798")]
		public override int Compare(RaycastHit x, RaycastHit y) { }

	}

	[Token(Token = "0x400036B")]
	protected const int kNoEventMaskSet = -1; //Field offset: 0x0
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400036C")]
	protected Camera m_EventCamera; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x400036D")]
	protected LayerMask m_EventMask; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Token(Token = "0x400036E")]
	protected int m_MaxRayIntersections; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400036F")]
	protected int m_LastMaxRayIntersections; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000370")]
	private RaycastHit[] m_Hits; //Field offset: 0x40

	[Token(Token = "0x17000204")]
	public override int depth
	{
		[Address(RVA = "0x1CE9250", Offset = "0x1CE8450", Length = "0xB1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Camera), Member = "get_depth", ReturnType = typeof(float))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000790")]
		 get { } //Length: 177
	}

	[Token(Token = "0x17000203")]
	public virtual Camera eventCamera
	{
		[Address(RVA = "0x1CE9310", Offset = "0x1CE8510", Length = "0xC8")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Camera), Member = "get_main", ReturnType = typeof(Camera))]
		[Token(Token = "0x600078F")]
		 get { } //Length: 200
	}

	[Token(Token = "0x17000206")]
	public LayerMask eventMask
	{
		[Address(RVA = "0x2F5B20", Offset = "0x2F4D20", Length = "0xAE")]
		[CallerCount(Count = 23)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000792")]
		 get { } //Length: 174
		[Address(RVA = "0x388900", Offset = "0x387B00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000793")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000205")]
	public int finalEventMask
	{
		[Address(RVA = "0x1CE93E0", Offset = "0x1CE85E0", Length = "0xBB")]
		[CalledBy(Type = typeof(Physics2DRaycaster), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(System.Collections.Generic.List`1<UnityEngine.EventSystems.RaycastResult>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PhysicsRaycaster), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(System.Collections.Generic.List`1<UnityEngine.EventSystems.RaycastResult>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Camera), Member = "get_cullingMask", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000791")]
		 get { } //Length: 187
	}

	[Token(Token = "0x17000207")]
	public int maxRayIntersections
	{
		[Address(RVA = "0x3EAB00", Offset = "0x3E9D00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000794")]
		 get { } //Length: 4
		[Address(RVA = "0x3EAB30", Offset = "0x3E9D30", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000795")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x1CE8950", Offset = "0x1CE7B50", Length = "0x27")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x600078E")]
	protected PhysicsRaycaster() { }

	[Address(RVA = "0x1CE8980", Offset = "0x1CE7B80", Length = "0x388")]
	[CalledBy(Type = typeof(Physics2DRaycaster), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(System.Collections.Generic.List`1<UnityEngine.EventSystems.RaycastResult>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PhysicsRaycaster), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(System.Collections.Generic.List`1<UnityEngine.EventSystems.RaycastResult>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "get_nearClipPlane", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(MultipleDisplayUtilities), Member = "RelativeMouseAtScaled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Camera), Member = "get_targetDisplay", ReturnType = typeof(int))]
	[Calls(Type = typeof(Camera), Member = "get_pixelRect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Camera), Member = "ScreenPointToRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Ray))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
	[Calls(Type = typeof(Camera), Member = "get_farClipPlane", ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000796")]
	protected bool ComputeRayAndDistance(PointerEventData eventData, ref Ray ray, ref int eventDisplayIndex, ref float distanceToClipPlane) { }

	[Address(RVA = "0x1CE9250", Offset = "0x1CE8450", Length = "0xB1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "get_depth", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000790")]
	public override int get_depth() { }

	[Address(RVA = "0x1CE9310", Offset = "0x1CE8510", Length = "0xC8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Camera), Member = "get_main", ReturnType = typeof(Camera))]
	[Token(Token = "0x600078F")]
	public virtual Camera get_eventCamera() { }

	[Address(RVA = "0x2F5B20", Offset = "0x2F4D20", Length = "0xAE")]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000792")]
	public LayerMask get_eventMask() { }

	[Address(RVA = "0x1CE93E0", Offset = "0x1CE85E0", Length = "0xBB")]
	[CalledBy(Type = typeof(Physics2DRaycaster), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(System.Collections.Generic.List`1<UnityEngine.EventSystems.RaycastResult>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PhysicsRaycaster), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(System.Collections.Generic.List`1<UnityEngine.EventSystems.RaycastResult>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "get_cullingMask", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000791")]
	public int get_finalEventMask() { }

	[Address(RVA = "0x3EAB00", Offset = "0x3E9D00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000794")]
	public int get_maxRayIntersections() { }

	[Address(RVA = "0x1CE8D10", Offset = "0x1CE7F10", Length = "0x537")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PhysicsRaycaster), Member = "get_finalEventMask", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PhysicsRaycaster), Member = "ComputeRayAndDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(Ray&), typeof(Int32&), typeof(Single&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReflectionMethodsCache), Member = "get_Singleton", ReturnType = typeof(ReflectionMethodsCache))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Array), Member = "Sort", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RaycastHit)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RaycastHit[]), typeof(int), typeof(int), typeof(System.Collections.Generic.IComparer`1<UnityEngine.RaycastHit>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider", ReturnType = typeof(Collider))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.EventSystems.RaycastResult>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RaycastResult)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000797")]
	public virtual void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) { }

	[Address(RVA = "0x388900", Offset = "0x387B00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000793")]
	public void set_eventMask(LayerMask value) { }

	[Address(RVA = "0x3EAB30", Offset = "0x3E9D30", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000795")]
	public void set_maxRayIntersections(int value) { }

}

