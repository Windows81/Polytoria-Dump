namespace UnityEngine;

[NativeHeader("Physics2DScriptingClasses.h")]
[NativeHeader("Modules/Physics2D/PhysicsManager2D.h")]
[NativeHeader("Physics2DScriptingClasses.h")]
[StaticAccessor("GetPhysicsManager2D()", StaticAccessorType::Arrow (1))]
[Token(Token = "0x2000003")]
public class Physics2D
{
	[Token(Token = "0x4000002")]
	private static List<Rigidbody2D> m_LastDisabledRigidbody2D; //Field offset: 0x0

	[Token(Token = "0x17000001")]
	public static PhysicsScene2D defaultPhysicsScene
	{
		[Address(RVA = "0xC8CAA0", Offset = "0xC8BCA0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000012")]
		 get { } //Length: 5
	}

	[StaticAccessor("GetPhysics2DSettings()")]
	[Token(Token = "0x17000002")]
	public static bool queriesHitTriggers
	{
		[Address(RVA = "0x19E1760", Offset = "0x19E0960", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000013")]
		 get { } //Length: 42
	}

	[Address(RVA = "0x19E16D0", Offset = "0x19E08D0", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000027")]
	private static Physics2D() { }

	[Address(RVA = "0xC8CAA0", Offset = "0xC8BCA0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000012")]
	public static PhysicsScene2D get_defaultPhysicsScene() { }

	[Address(RVA = "0x19E1760", Offset = "0x19E0960", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000013")]
	public static bool get_queriesHitTriggers() { }

	[Address(RVA = "0x19DFE00", Offset = "0x19DF000", Length = "0x9D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Physics2D), Member = "GetRayIntersectionAll_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PhysicsScene2D), typeof(Vector3), typeof(Vector3), typeof(float), typeof(int)}, ReturnType = typeof(RaycastHit2D[]))]
	[RequiredByNativeCode]
	[Token(Token = "0x600001E")]
	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray, float distance, int layerMask = -5) { }

	[Address(RVA = "0x19DFF40", Offset = "0x19DF140", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Physics2D), Member = "GetRayIntersectionAll_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PhysicsScene2D), typeof(Vector3), typeof(Vector3), typeof(float), typeof(int)}, ReturnType = typeof(RaycastHit2D[]))]
	[ExcludeFromDocs]
	[Token(Token = "0x600001C")]
	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray) { }

	[Address(RVA = "0x19DFEA0", Offset = "0x19DF0A0", Length = "0x95")]
	[CalledBy(Type = "RLD.RTScene", Member = "RaycastAllObjects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), "RLD.SceneRaycastPrecision", "System.Collections.Generic.List`1<GameObjectRayHit>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.RTScene", Member = "RaycastAllObjectsSorted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), "RLD.SceneRaycastPrecision", "System.Collections.Generic.List`1<GameObjectRayHit>"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Physics2D), Member = "GetRayIntersectionAll_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PhysicsScene2D), typeof(Vector3), typeof(Vector3), typeof(float), typeof(int)}, ReturnType = typeof(RaycastHit2D[]))]
	[ExcludeFromDocs]
	[Token(Token = "0x600001D")]
	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray, float distance) { }

	[Address(RVA = "0x19DFCD0", Offset = "0x19DEED0", Length = "0x121")]
	[CalledBy(Type = typeof(Physics2D), Member = "GetRayIntersectionAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray)}, ReturnType = typeof(RaycastHit2D[]))]
	[CalledBy(Type = typeof(Physics2D), Member = "GetRayIntersectionAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(float)}, ReturnType = typeof(RaycastHit2D[]))]
	[CalledBy(Type = typeof(Physics2D), Member = "GetRayIntersectionAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(float), typeof(int)}, ReturnType = typeof(RaycastHit2D[]))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1819DF830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod("GetRayIntersectionAll_Binding")]
	[StaticAccessor("PhysicsQuery2D", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x600001F")]
	private static RaycastHit2D[] GetRayIntersectionAll_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask) { }

	[Address(RVA = "0x19DFC60", Offset = "0x19DEE60", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000028")]
	private static void GetRayIntersectionAll_Internal_Injected(in PhysicsScene2D physicsScene, in Vector3 origin, in Vector3 direction, float distance, int layerMask, out BlittableArrayWrapper ret) { }

	[Address(RVA = "0x19E0170", Offset = "0x19DF370", Length = "0x199")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromDocs]
	[RequiredByNativeCode]
	[Token(Token = "0x6000020")]
	public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, float distance, int layerMask = -5) { }

	[Address(RVA = "0x19DFFD0", Offset = "0x19DF1D0", Length = "0x194")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[ExcludeFromDocs]
	[Obsolete("GetRayIntersectionNonAlloc is deprecated. Please use GetRayIntersection.", False)]
	[Token(Token = "0x6000026")]
	public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, float distance) { }

	[Address(RVA = "0x19E0310", Offset = "0x19DF510", Length = "0x186")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[ExcludeFromDocs]
	[Obsolete("GetRayIntersectionNonAlloc is deprecated. Please use GetRayIntersection.", False)]
	[Token(Token = "0x6000025")]
	public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results) { }

	[Address(RVA = "0x19E06E0", Offset = "0x19DF8E0", Length = "0x26C")]
	[CalledBy(Type = "RLD.RTScene", Member = "OverlapBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"RLD.OBB", "System.Collections.Generic.List`1<GameObject>"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ContactFilter2D), Member = "CreateLegacyFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float), typeof(float)}, ReturnType = typeof(ContactFilter2D))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromDocs]
	[Token(Token = "0x6000023")]
	public static Collider2D[] OverlapAreaAll(Vector2 pointA, Vector2 pointB) { }

	[Address(RVA = "0x19E04A0", Offset = "0x19DF6A0", Length = "0x233")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ContactFilter2D), Member = "CreateLegacyFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float), typeof(float)}, ReturnType = typeof(ContactFilter2D))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000024")]
	private static Collider2D[] OverlapAreaAllToBox_Internal(Vector2 pointA, Vector2 pointB, int layerMask, float minDepth, float maxDepth) { }

	[Address(RVA = "0x19E0A60", Offset = "0x19DFC60", Length = "0x179")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ContactFilter2D), Member = "CreateLegacyFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float), typeof(float)}, ReturnType = typeof(ContactFilter2D))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000021")]
	public static Collider2D[] OverlapBoxAll(Vector2 point, Vector2 size, float angle, int layerMask, float minDepth, float maxDepth) { }

	[Address(RVA = "0x19E09C0", Offset = "0x19DFBC0", Length = "0x95")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod("OverlapBoxAll_Binding")]
	[StaticAccessor("PhysicsQuery2D", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x6000022")]
	private static Collider2D[] OverlapBoxAll_Internal(PhysicsScene2D physicsScene, Vector2 point, Vector2 size, float angle, ContactFilter2D contactFilter) { }

	[Address(RVA = "0x19E0950", Offset = "0x19DFB50", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000029")]
	private static Collider2D[] OverlapBoxAll_Internal_Injected(in PhysicsScene2D physicsScene, in Vector2 point, in Vector2 size, float angle, in ContactFilter2D contactFilter) { }

	[Address(RVA = "0x19E12A0", Offset = "0x19E04A0", Length = "0xD5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PhysicsScene2D), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(float), typeof(int)}, ReturnType = typeof(RaycastHit2D))]
	[ExcludeFromDocs]
	[Token(Token = "0x6000015")]
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance) { }

	[Address(RVA = "0x19E0F40", Offset = "0x19E0140", Length = "0x1B4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ContactFilter2D), Member = "CreateLegacyFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float), typeof(float)}, ReturnType = typeof(ContactFilter2D))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromDocs]
	[RequiredByNativeCode]
	[Token(Token = "0x6000016")]
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask) { }

	[Address(RVA = "0x19E1380", Offset = "0x19E0580", Length = "0xBF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PhysicsScene2D), Member = "RaycastList_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PhysicsScene2D), typeof(Vector2), typeof(Vector2), typeof(float), typeof(ContactFilter2D), typeof(System.Collections.Generic.List`1<UnityEngine.RaycastHit2D>)}, ReturnType = typeof(int))]
	[Token(Token = "0x600001B")]
	public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, float distance = ∞) { }

	[Address(RVA = "0x19E1100", Offset = "0x19E0300", Length = "0x19B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600001A")]
	public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results, float distance) { }

	[Address(RVA = "0x19E0DA0", Offset = "0x19DFFA0", Length = "0x19A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromDocs]
	[Token(Token = "0x6000019")]
	public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	[Address(RVA = "0x19E1600", Offset = "0x19E0800", Length = "0xCF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PhysicsScene2D), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(float), typeof(int)}, ReturnType = typeof(RaycastHit2D))]
	[ExcludeFromDocs]
	[Token(Token = "0x6000014")]
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction) { }

	[Address(RVA = "0x19E1440", Offset = "0x19E0640", Length = "0x1B5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ContactFilter2D), Member = "CreateLegacyFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float), typeof(float)}, ReturnType = typeof(ContactFilter2D))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromDocs]
	[Token(Token = "0x6000017")]
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth) { }

	[Address(RVA = "0x19E0BE0", Offset = "0x19DFDE0", Length = "0x1B6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ContactFilter2D), Member = "CreateLegacyFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float), typeof(float)}, ReturnType = typeof(ContactFilter2D))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000018")]
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth) { }

}

