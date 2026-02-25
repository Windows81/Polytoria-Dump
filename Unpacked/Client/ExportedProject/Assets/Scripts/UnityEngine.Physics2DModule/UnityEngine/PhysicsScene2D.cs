namespace UnityEngine;

[NativeHeader("Modules/Physics2D/Public/PhysicsSceneHandle2D.h")]
[Token(Token = "0x2000002")]
public struct PhysicsScene2D : IEquatable<PhysicsScene2D>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000001")]
	private int m_Handle; //Field offset: 0x0

	[Address(RVA = "0x19E1790", Offset = "0x19E0990", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000003")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x192B3D0", Offset = "0x192A5D0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000004")]
	public override bool Equals(PhysicsScene2D other) { }

	[Address(RVA = "0xF6BA50", Offset = "0xF6AC50", Length = "0x5")]
	[CallerCount(Count = 230)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000002")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x19E19A0", Offset = "0x19E0BA0", Length = "0x140")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600000C")]
	public int GetRayIntersection(Ray ray, float distance, RaycastHit2D[] results, int layerMask = -5) { }

	[Address(RVA = "0x19E1880", Offset = "0x19E0A80", Length = "0x11D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod("GetRayIntersectionArray_Binding")]
	[StaticAccessor("PhysicsQuery2D", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x600000D")]
	private static int GetRayIntersectionArray_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask, RaycastHit2D[] results) { }

	[Address(RVA = "0x19E1810", Offset = "0x19E0A10", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000011")]
	private static int GetRayIntersectionArray_Internal_Injected(in PhysicsScene2D physicsScene, in Vector3 origin, in Vector3 direction, float distance, int layerMask, ref ManagedSpanWrapper results) { }

	[Address(RVA = "0x19E2190", Offset = "0x19E1390", Length = "0x170")]
	[CalledBy(Type = typeof(Physics2D), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(RaycastHit2D))]
	[CalledBy(Type = typeof(Physics2D), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(float)}, ReturnType = typeof(RaycastHit2D))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ContactFilter2D), Member = "CreateLegacyFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float), typeof(float)}, ReturnType = typeof(ContactFilter2D))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000005")]
	public RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask = -5) { }

	[Address(RVA = "0x19E2300", Offset = "0x19E1500", Length = "0xDA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000006")]
	public RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter) { }

	[Address(RVA = "0x19E1FE0", Offset = "0x19E11E0", Length = "0x14C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000007")]
	public int Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	[Address(RVA = "0x19E2130", Offset = "0x19E1330", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PhysicsScene2D), Member = "RaycastList_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PhysicsScene2D), typeof(Vector2), typeof(Vector2), typeof(float), typeof(ContactFilter2D), typeof(System.Collections.Generic.List`1<UnityEngine.RaycastHit2D>)}, ReturnType = typeof(int))]
	[Token(Token = "0x6000008")]
	public int Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results) { }

	[Address(RVA = "0x19E1F60", Offset = "0x19E1160", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod("Raycast_Binding")]
	[StaticAccessor("PhysicsQuery2D", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x6000009")]
	private static RaycastHit2D Raycast_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter) { }

	[Address(RVA = "0x19E1EF0", Offset = "0x19E10F0", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600000E")]
	private static void Raycast_Internal_Injected(in PhysicsScene2D physicsScene, in Vector2 origin, in Vector2 direction, float distance, in ContactFilter2D contactFilter, out RaycastHit2D ret) { }

	[Address(RVA = "0x19E1B50", Offset = "0x19E0D50", Length = "0x11E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod("RaycastArray_Binding")]
	[StaticAccessor("PhysicsQuery2D", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x600000A")]
	private static int RaycastArray_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	[Address(RVA = "0x19E1AE0", Offset = "0x19E0CE0", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600000F")]
	private static int RaycastArray_Internal_Injected(in PhysicsScene2D physicsScene, in Vector2 origin, in Vector2 direction, float distance, in ContactFilter2D contactFilter, ref ManagedSpanWrapper results) { }

	[Address(RVA = "0x19E1CE0", Offset = "0x19E0EE0", Length = "0x207")]
	[CalledBy(Type = typeof(PhysicsScene2D), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(float), typeof(ContactFilter2D), typeof(System.Collections.Generic.List`1<UnityEngine.RaycastHit2D>)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Physics2D), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(ContactFilter2D), typeof(System.Collections.Generic.List`1<UnityEngine.RaycastHit2D>), typeof(float)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = "UnityEngine.Bindings.BlittableListWrapper", Member = "Unmarshal", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod("RaycastList_Binding")]
	[StaticAccessor("PhysicsQuery2D", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x600000B")]
	private static int RaycastList_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results) { }

	[Address(RVA = "0x19E1C70", Offset = "0x19E0E70", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000010")]
	private static int RaycastList_Internal_Injected(in PhysicsScene2D physicsScene, in Vector2 origin, in Vector2 direction, float distance, in ContactFilter2D contactFilter, ref BlittableListWrapper results) { }

	[Address(RVA = "0x19E23E0", Offset = "0x19E15E0", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000001")]
	public virtual string ToString() { }

}

