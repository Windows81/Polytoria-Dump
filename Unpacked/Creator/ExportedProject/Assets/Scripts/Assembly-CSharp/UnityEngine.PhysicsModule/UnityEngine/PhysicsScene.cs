namespace UnityEngine;

[NativeHeader("Modules/Physics/Public/PhysicsSceneHandle.h")]
[NativeHeader("Modules/Physics/PhysicsQuery.h")]
[Token(Token = "0x2000027")]
public struct PhysicsScene : IEquatable<PhysicsScene>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000085")]
	private int m_index; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000086")]
	private int m_version; //Field offset: 0x4

	[Address(RVA = "0x19ECB60", Offset = "0x19EBD60", Length = "0xA6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001AF")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x19ECB40", Offset = "0x19EBD40", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001B0")]
	public override bool Equals(PhysicsScene other) { }

	[Address(RVA = "0x19ECC10", Offset = "0x19EBE10", Length = "0x16")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001B1")]
	internal static PhysicsScene GetDefaultScene() { }

	[Address(RVA = "0x19ECC30", Offset = "0x19EBE30", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(HashCode), Member = "Combine", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2"}, ReturnType = typeof(int))]
	[Token(Token = "0x60001AE")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x19ECF60", Offset = "0x19EC160", Length = "0x6C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("Physics::Raycast")]
	[Token(Token = "0x60001B5")]
	private static bool Internal_Raycast(PhysicsScene physicsScene, Ray ray, float maxDistance, ref RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[Address(RVA = "0x19ECEF0", Offset = "0x19EC0F0", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001B9")]
	private static bool Internal_Raycast_Injected(in PhysicsScene physicsScene, in Ray ray, float maxDistance, ref RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[Address(RVA = "0x19ECD10", Offset = "0x19EBF10", Length = "0xFB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("Physics::RaycastNonAlloc")]
	[Token(Token = "0x60001B7")]
	private static int Internal_RaycastNonAlloc(PhysicsScene physicsScene, Ray ray, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	[Address(RVA = "0x19ECCA0", Offset = "0x19EBEA0", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001BA")]
	private static int Internal_RaycastNonAlloc_Injected(in PhysicsScene physicsScene, in Ray ray, ref ManagedSpanWrapper raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	[Address(RVA = "0x19ECE80", Offset = "0x19EC080", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("Physics::RaycastTest")]
	[Token(Token = "0x60001B3")]
	private static bool Internal_RaycastTest(PhysicsScene physicsScene, Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[Address(RVA = "0x19ECE10", Offset = "0x19EC010", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001B8")]
	private static bool Internal_RaycastTest_Injected(in PhysicsScene physicsScene, in Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[Address(RVA = "0x19ED4C0", Offset = "0x19EC6C0", Length = "0x15")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001AD")]
	public static bool op_Equality(PhysicsScene lhs, PhysicsScene rhs) { }

	[Address(RVA = "0x19ED180", Offset = "0x19EC380", Length = "0x144")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC4C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC5B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001B2")]
	public bool Raycast(Vector3 origin, Vector3 direction, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[Address(RVA = "0x19ED2D0", Offset = "0x19EC4D0", Length = "0x168")]
	[CalledBy(Type = typeof(Physics), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(RaycastHit&), typeof(float), typeof(int), typeof(QueryTriggerInteraction)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Physics), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(RaycastHit&), typeof(float), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Physics), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(RaycastHit&), typeof(float)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Physics), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(RaycastHit&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Physics), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(RaycastHit&), typeof(float), typeof(int), typeof(QueryTriggerInteraction)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Physics), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(RaycastHit&), typeof(float), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Physics), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(RaycastHit&), typeof(float)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Physics), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(RaycastHit&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Physics), Member = "Linecast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(RaycastHit&), typeof(int), typeof(QueryTriggerInteraction)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC4C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC5B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001B4")]
	public bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[Address(RVA = "0x19ECFD0", Offset = "0x19EC1D0", Length = "0x1A8")]
	[CalledBy(Type = typeof(Physics), Member = "RaycastNonAlloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(RaycastHit[]), typeof(float), typeof(int), typeof(QueryTriggerInteraction)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Physics), Member = "RaycastNonAlloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(RaycastHit[]), typeof(float), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Physics), Member = "RaycastNonAlloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(RaycastHit[]), typeof(float), typeof(int), typeof(QueryTriggerInteraction)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Physics), Member = "RaycastNonAlloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(RaycastHit[]), typeof(float), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC4C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC5B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001B6")]
	public int Raycast(Vector3 origin, Vector3 direction, RaycastHit[] raycastHits, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[Address(RVA = "0x19ED440", Offset = "0x19EC640", Length = "0x7B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Token(Token = "0x60001AC")]
	public virtual string ToString() { }

}

