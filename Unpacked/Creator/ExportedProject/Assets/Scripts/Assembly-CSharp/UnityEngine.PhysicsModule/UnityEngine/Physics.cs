namespace UnityEngine;

[NativeHeader("Modules/Physics/PhysicsQuery.h")]
[NativeHeader("Modules/Physics/PhysicsManager.h")]
[StaticAccessor("GetPhysicsManager()", StaticAccessorType::Dot (0))]
[Token(Token = "0x2000017")]
public class Physics
{
	[Token(Token = "0x2000018")]
	internal sealed class ContactEventDelegate : MulticastDelegate
	{

		[Address(RVA = "0xA32C70", Offset = "0xA31E70", Length = "0xA6")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x600012B")]
		public ContactEventDelegate(object object, IntPtr method) { }

		[Address(RVA = "0xA30A40", Offset = "0xA2FC40", Length = "0x25")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600012C")]
		public override void Invoke(PhysicsScene scene, ReadOnly<ContactPairHeader> headerArray) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x400003D")]
	private static Action<PhysicsScene, NativeArray`1<ModifiableContactPair>> ContactModifyEvent; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x400003E")]
	private static Action<PhysicsScene, NativeArray`1<ModifiableContactPair>> ContactModifyEventCCD; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x400003F")]
	private static Action<PhysicsScene, IntPtr, Int32, Boolean> GenericContactModifyEvent; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000040")]
	private static ContactEventDelegate ContactEvent; //Field offset: 0x18
	[Token(Token = "0x4000041")]
	private static readonly Collision s_ReusableCollision; //Field offset: 0x20

	[Token(Token = "0x17000040")]
	public static PhysicsScene defaultPhysicsScene
	{
		[Address(RVA = "0x19ECC10", Offset = "0x19EBE10", Length = "0x16")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000E8")]
		 get { } //Length: 22
	}

	[Token(Token = "0x1700003E")]
	public static Vector3 gravity
	{
		[Address(RVA = "0x19F1790", Offset = "0x19F0990", Length = "0x6E")]
		[CalledBy(Type = "Polytoria.Datamodel.Environment", Member = "Awake", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[ThreadSafe]
		[Token(Token = "0x60000E5")]
		 get { } //Length: 110
		[Address(RVA = "0x19F18A0", Offset = "0x19F0AA0", Length = "0x64")]
		[CalledBy(Type = "Polytoria.Datamodel.Environment", Member = "set_Gravity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60000E6")]
		 set { } //Length: 100
	}

	[Token(Token = "0x1700003F")]
	public static bool invokeCollisionCallbacks
	{
		[Address(RVA = "0x19F1800", Offset = "0x19F0A00", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60000E7")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000041")]
	public static bool reuseCollisionCallbacks
	{
		[Address(RVA = "0x19F1830", Offset = "0x19F0A30", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000112")]
		 get { } //Length: 42
	}

	[Address(RVA = "0x19F1620", Offset = "0x19F0820", Length = "0x121")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Action`4<UnityEngine.PhysicsScene, System.IntPtr, System.Int32, System.Boolean>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600011F")]
	private static Physics() { }

	[Address(RVA = "0x19ECC10", Offset = "0x19EBE10", Length = "0x16")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000E8")]
	public static PhysicsScene get_defaultPhysicsScene() { }

	[Address(RVA = "0x19F1790", Offset = "0x19F0990", Length = "0x6E")]
	[CalledBy(Type = "Polytoria.Datamodel.Environment", Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x60000E5")]
	public static Vector3 get_gravity() { }

	[Address(RVA = "0x19F1750", Offset = "0x19F0950", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000120")]
	private static void get_gravity_Injected(out Vector3 ret) { }

	[Address(RVA = "0x19F1800", Offset = "0x19F0A00", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000E7")]
	public static bool get_invokeCollisionCallbacks() { }

	[Address(RVA = "0x19F1830", Offset = "0x19F0A30", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000112")]
	public static bool get_reuseCollisionCallbacks() { }

	[Address(RVA = "0x19ED520", Offset = "0x19EC720", Length = "0x7F")]
	[CalledBy(Type = typeof(Collision), Member = "get_body", ReturnType = typeof(Component))]
	[CalledBy(Type = typeof(Physics), Member = "ReportContacts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1+ReadOnly<UnityEngine.ContactPairHeader>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ContactPairHeader), Member = "get_body", ReturnType = typeof(Component))]
	[CalledBy(Type = typeof(ContactPairHeader), Member = "get_otherBody", ReturnType = typeof(Component))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = "UnityEngine.Bindings.Unmarshal", Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	[StaticAccessor("PhysicsManager", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x6000118")]
	internal static Component GetBodyByInstanceID(EntityId entityId) { }

	[Address(RVA = "0x19ED4E0", Offset = "0x19EC6E0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000127")]
	private static IntPtr GetBodyByInstanceID_Injected(in EntityId entityId) { }

	[Address(RVA = "0x19ED5E0", Offset = "0x19EC7E0", Length = "0x7F")]
	[CalledBy(Type = typeof(ContactPoint), Member = "get_otherCollider", ReturnType = typeof(Collider))]
	[CalledBy(Type = typeof(Collision), Member = "get_collider", ReturnType = typeof(Collider))]
	[CalledBy(Type = typeof(Collision), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[CalledBy(Type = typeof(ContactPair), Member = "get_collider", ReturnType = typeof(Collider))]
	[CalledBy(Type = typeof(ContactPair), Member = "get_otherCollider", ReturnType = typeof(Collider))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = "UnityEngine.Bindings.Unmarshal", Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	[StaticAccessor("PhysicsManager", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x6000117")]
	internal static Collider GetColliderByInstanceID(EntityId entityId) { }

	[Address(RVA = "0x19ED5A0", Offset = "0x19EC7A0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000126")]
	private static IntPtr GetColliderByInstanceID_Injected(in EntityId entityId) { }

	[Address(RVA = "0x19ED660", Offset = "0x19EC860", Length = "0x176")]
	[CalledBy(Type = typeof(Physics), Member = "ReportContacts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1+ReadOnly<UnityEngine.ContactPairHeader>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Collision), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContactPairHeader&), typeof(ContactPair&), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600011E")]
	private static Collision GetCollisionToReport(in ContactPairHeader header, in ContactPair pair, bool flipped) { }

	[Address(RVA = "0x19ED840", Offset = "0x19ECA40", Length = "0x128")]
	[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "Die", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "DropTool", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "DropTools", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "DoDropTools", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Tool", Member = "DoLinkTool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000E9")]
	public static void IgnoreCollision(Collider collider1, Collider collider2, bool ignore) { }

	[Address(RVA = "0x19ED970", Offset = "0x19ECB70", Length = "0x14A")]
	[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromDocs]
	[Token(Token = "0x60000EA")]
	public static void IgnoreCollision(Collider collider1, Collider collider2) { }

	[Address(RVA = "0x19ED7E0", Offset = "0x19EC9E0", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000122")]
	private static void IgnoreCollision_Injected(IntPtr collider1, IntPtr collider2, bool ignore) { }

	[Address(RVA = "0x19EDAC0", Offset = "0x19ECCC0", Length = "0x50")]
	[CalledBy(Type = "Polytoria.Datamodel.Players", Member = "set_PlayerCollisionEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeName("IgnoreCollision")]
	[Token(Token = "0x60000EB")]
	public static void IgnoreLayerCollision(int layer1, int layer2, bool ignore) { }

	[Address(RVA = "0x19EDB80", Offset = "0x19ECD80", Length = "0x122")]
	[CalledBy(Type = typeof(Physics), Member = "RaycastAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), typeof(int), typeof(QueryTriggerInteraction)}, ReturnType = typeof(RaycastHit[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1819E3280")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("Physics::RaycastAll")]
	[Token(Token = "0x60000FD")]
	private static RaycastHit[] Internal_RaycastAll(PhysicsScene physicsScene, Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	[Address(RVA = "0x19EDB10", Offset = "0x19ECD10", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000123")]
	private static void Internal_RaycastAll_Injected(in PhysicsScene physicsScene, in Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction, out BlittableArrayWrapper ret) { }

	[Address(RVA = "0x19EDCB0", Offset = "0x19ECEB0", Length = "0x13E")]
	[CalledBy(Type = "Polytoria.Datamodel.Camera", Member = "CalculateWallClipping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC4C0")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(RaycastHit&), typeof(float), typeof(int), typeof(QueryTriggerInteraction)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60000FC")]
	public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[Address(RVA = "0x19EDEA0", Offset = "0x19ED0A0", Length = "0x1A0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NativeArrayUnsafeUtility), Member = "ConvertExistingDataToNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(Allocator)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NativeArray`1), Member = "AsReadOnly", ReturnType = "Unity.Collections.NativeArray`1<T>+ReadOnly<T>")]
	[Calls(Type = typeof(Physics), Member = "ReportContacts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1+ReadOnly<UnityEngine.ContactPairHeader>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1819E3230")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x600011C")]
	private static void OnSceneContact(PhysicsScene scene, IntPtr buffer, int count) { }

	[Address(RVA = "0x19EDDF0", Offset = "0x19ECFF0", Length = "0xA3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x60000E3")]
	private static void OnSceneContactModify(PhysicsScene scene, IntPtr buffer, int count, bool isCCD) { }

	[Address(RVA = "0x19EE3E0", Offset = "0x19ED5E0", Length = "0x14F")]
	[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "IsGrounded", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "DoFootstep", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "IsGrounded", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromDocs]
	[Token(Token = "0x6000115")]
	public static Collider[] OverlapBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask) { }

	[Address(RVA = "0x19EE160", Offset = "0x19ED360", Length = "0x147")]
	[CalledBy(Type = "RLD.RTScene", Member = "OverlapBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"RLD.OBB", "System.Collections.Generic.List`1<GameObject>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Datamodel.Environment", Member = "OverlapBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3), "System.Collections.Generic.List`1<Instance>"}, ReturnType = "Polytoria.Datamodel.Instance[]")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromDocs]
	[Token(Token = "0x6000116")]
	public static Collider[] OverlapBox(Vector3 center, Vector3 halfExtents, Quaternion orientation) { }

	[Address(RVA = "0x19EE2B0", Offset = "0x19ED4B0", Length = "0x121")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000114")]
	public static Collider[] OverlapBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[Address(RVA = "0x19EE0C0", Offset = "0x19ED2C0", Length = "0x9D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("Physics::OverlapBox")]
	[Token(Token = "0x6000113")]
	private static Collider[] OverlapBox_Internal(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[Address(RVA = "0x19EE050", Offset = "0x19ED250", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000125")]
	private static Collider[] OverlapBox_Internal_Injected(in PhysicsScene physicsScene, in Vector3 center, in Vector3 halfExtents, in Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[Address(RVA = "0x19EE740", Offset = "0x19ED940", Length = "0x116")]
	[CalledBy(Type = "Polytoria.Datamodel.Environment", Member = "CreateExplosion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float), typeof(float), typeof(bool), "MoonSharp.Interpreter.DynValue", typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Environment", Member = "OverlapSphere", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float), "System.Collections.Generic.List`1<Instance>"}, ReturnType = "Polytoria.Datamodel.Instance[]")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromDocs]
	[Token(Token = "0x6000110")]
	public static Collider[] OverlapSphere(Vector3 position, float radius) { }

	[Address(RVA = "0x19EE640", Offset = "0x19ED840", Length = "0xF7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600010F")]
	public static Collider[] OverlapSphere(Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[Address(RVA = "0x19EE5A0", Offset = "0x19ED7A0", Length = "0x95")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("Physics::OverlapSphere")]
	[Token(Token = "0x600010E")]
	private static Collider[] OverlapSphere_Internal(PhysicsScene physicsScene, Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[Address(RVA = "0x19EE530", Offset = "0x19ED730", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000124")]
	private static Collider[] OverlapSphere_Internal_Injected(in PhysicsScene physicsScene, in Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[Address(RVA = "0x19EE860", Offset = "0x19EDA60", Length = "0xF9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NativeArrayUnsafeUtility), Member = "ConvertExistingDataToNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(Allocator)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000E4")]
	private static void PhysXOnSceneContactModify(PhysicsScene scene, IntPtr buffer, int count, bool isCCD) { }

	[Address(RVA = "0x19EFF40", Offset = "0x19EF140", Length = "0x1A4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC4C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC5B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000EC")]
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[Address(RVA = "0x19EFBB0", Offset = "0x19EEDB0", Length = "0x1A1")]
	[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "IsGrounded", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "IsGrounded", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC4C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC5B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromDocs]
	[Token(Token = "0x60000ED")]
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask) { }

	[Address(RVA = "0x19F0BE0", Offset = "0x19EFDE0", Length = "0x19B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC4C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC5B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromDocs]
	[Token(Token = "0x60000EE")]
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance) { }

	[Address(RVA = "0x19F0890", Offset = "0x19EFA90", Length = "0x199")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC4C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC5B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromDocs]
	[Token(Token = "0x60000EF")]
	public static bool Raycast(Vector3 origin, Vector3 direction) { }

	[Address(RVA = "0x19F07A0", Offset = "0x19EF9A0", Length = "0xE9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(RaycastHit&), typeof(float), typeof(int), typeof(QueryTriggerInteraction)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60000F0")]
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[Address(RVA = "0x19EFD60", Offset = "0x19EEF60", Length = "0xCC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(RaycastHit&), typeof(float), typeof(int), typeof(QueryTriggerInteraction)}, ReturnType = typeof(bool))]
	[ExcludeFromDocs]
	[Token(Token = "0x60000F3")]
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo) { }

	[Address(RVA = "0x19F0A30", Offset = "0x19EFC30", Length = "0xBD")]
	[CalledBy(Type = "namudev.PropertyGridSelector", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Services.InputService", Member = "GetMouseWorldPosition", ReturnType = typeof(Vector3))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(RaycastHit&), typeof(float), typeof(int), typeof(QueryTriggerInteraction)}, ReturnType = typeof(bool))]
	[ExcludeFromDocs]
	[Token(Token = "0x60000FB")]
	public static bool Raycast(Ray ray, out RaycastHit hitInfo) { }

	[Address(RVA = "0x19F0600", Offset = "0x19EF800", Length = "0x19F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC4C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC5B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000F4")]
	public static bool Raycast(Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[Address(RVA = "0x19F01E0", Offset = "0x19EF3E0", Length = "0x19A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC4C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC5B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromDocs]
	[Token(Token = "0x60000F5")]
	public static bool Raycast(Ray ray, float maxDistance, int layerMask) { }

	[Address(RVA = "0x19F0380", Offset = "0x19EF580", Length = "0x19A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC4C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC5B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromDocs]
	[Token(Token = "0x60000F6")]
	public static bool Raycast(Ray ray, float maxDistance) { }

	[Address(RVA = "0x19F0D80", Offset = "0x19EFF80", Length = "0x184")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC4C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC5B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromDocs]
	[Token(Token = "0x60000F7")]
	public static bool Raycast(Ray ray) { }

	[Address(RVA = "0x19F0AF0", Offset = "0x19EFCF0", Length = "0xE3")]
	[CalledBy(Type = "UnityEngine.UIElements.WorldSpaceInput", Member = "PickDocument3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(float), typeof(int)}, ReturnType = "UnityEngine.UIElements.WorldSpaceInput+PickResult")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(RaycastHit&), typeof(float), typeof(int), typeof(QueryTriggerInteraction)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60000F8")]
	public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[Address(RVA = "0x19EFE30", Offset = "0x19EF030", Length = "0x10D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(RaycastHit&), typeof(float), typeof(int), typeof(QueryTriggerInteraction)}, ReturnType = typeof(bool))]
	[ExcludeFromDocs]
	[Token(Token = "0x60000F9")]
	public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	[Address(RVA = "0x19F00F0", Offset = "0x19EF2F0", Length = "0xE2")]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "Move", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.LagCompensator", Member = "RaycastCheck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkConnectionToClient", typeof(Vector3), typeof(Vector3), typeof(float), typeof(int), typeof(RaycastHit&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(RaycastHit&), typeof(float), typeof(int), typeof(QueryTriggerInteraction)}, ReturnType = typeof(bool))]
	[ExcludeFromDocs]
	[RequiredByNativeCode]
	[Token(Token = "0x60000F1")]
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	[Address(RVA = "0x19EFAD0", Offset = "0x19EECD0", Length = "0xDF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(RaycastHit&), typeof(float), typeof(int), typeof(QueryTriggerInteraction)}, ReturnType = typeof(bool))]
	[ExcludeFromDocs]
	[Token(Token = "0x60000F2")]
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance) { }

	[Address(RVA = "0x19F0520", Offset = "0x19EF720", Length = "0xD4")]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "AddInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "Polytoria.Datamodel.Instance", typeof(bool)}, ReturnType = "Polytoria.Datamodel.Instance")]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "AddPart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.PartShape", typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "AddSeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(RaycastHit&), typeof(float), typeof(int), typeof(QueryTriggerInteraction)}, ReturnType = typeof(bool))]
	[ExcludeFromDocs]
	[Token(Token = "0x60000FA")]
	public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance) { }

	[Address(RVA = "0x19EE960", Offset = "0x19EDB60", Length = "0x93")]
	[CalledBy(Type = "RLD.RTScene", Member = "RaycastAllObjects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), "RLD.SceneRaycastPrecision", "System.Collections.Generic.List`1<GameObjectRayHit>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.RTScene", Member = "RaycastAllObjectsSorted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), "RLD.SceneRaycastPrecision", "System.Collections.Generic.List`1<GameObjectRayHit>"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Physics), Member = "RaycastAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), typeof(int), typeof(QueryTriggerInteraction)}, ReturnType = typeof(RaycastHit[]))]
	[ExcludeFromDocs]
	[Token(Token = "0x6000104")]
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance) { }

	[Address(RVA = "0x19EEAA0", Offset = "0x19EDCA0", Length = "0xA8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Physics), Member = "RaycastAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), typeof(int), typeof(QueryTriggerInteraction)}, ReturnType = typeof(RaycastHit[]))]
	[ExcludeFromDocs]
	[Token(Token = "0x60000FF")]
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask) { }

	[Address(RVA = "0x19EED70", Offset = "0x19EDF70", Length = "0x9E")]
	[CalledBy(Type = "Polytoria.Datamodel.Environment", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), "System.Collections.Generic.List`1<Instance>"}, ReturnType = "System.Nullable`1<RayResult>")]
	[CalledBy(Type = "Polytoria.Datamodel.Environment", Member = "RaycastAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), "System.Collections.Generic.List`1<Instance>"}, ReturnType = "Polytoria.Datamodel.RayResult[]")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Physics), Member = "RaycastAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), typeof(int), typeof(QueryTriggerInteraction)}, ReturnType = typeof(RaycastHit[]))]
	[ExcludeFromDocs]
	[Token(Token = "0x6000100")]
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance) { }

	[Address(RVA = "0x19EEE10", Offset = "0x19EE010", Length = "0x96")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Physics), Member = "RaycastAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), typeof(int), typeof(QueryTriggerInteraction)}, ReturnType = typeof(RaycastHit[]))]
	[ExcludeFromDocs]
	[Token(Token = "0x6000101")]
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction) { }

	[Address(RVA = "0x19EECC0", Offset = "0x19EDEC0", Length = "0xAB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Physics), Member = "RaycastAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), typeof(int), typeof(QueryTriggerInteraction)}, ReturnType = typeof(RaycastHit[]))]
	[Token(Token = "0x6000102")]
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[Address(RVA = "0x19EEA00", Offset = "0x19EDC00", Length = "0x9C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Physics), Member = "RaycastAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), typeof(int), typeof(QueryTriggerInteraction)}, ReturnType = typeof(RaycastHit[]))]
	[ExcludeFromDocs]
	[RequiredByNativeCode]
	[Token(Token = "0x6000103")]
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask) { }

	[Address(RVA = "0x19EEB50", Offset = "0x19EDD50", Length = "0x166")]
	[CalledBy(Type = typeof(Physics), Member = "RaycastAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), typeof(int)}, ReturnType = typeof(RaycastHit[]))]
	[CalledBy(Type = typeof(Physics), Member = "RaycastAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float)}, ReturnType = typeof(RaycastHit[]))]
	[CalledBy(Type = typeof(Physics), Member = "RaycastAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(RaycastHit[]))]
	[CalledBy(Type = typeof(Physics), Member = "RaycastAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(float), typeof(int), typeof(QueryTriggerInteraction)}, ReturnType = typeof(RaycastHit[]))]
	[CalledBy(Type = typeof(Physics), Member = "RaycastAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(float), typeof(int)}, ReturnType = typeof(RaycastHit[]))]
	[CalledBy(Type = typeof(Physics), Member = "RaycastAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(float)}, ReturnType = typeof(RaycastHit[]))]
	[CalledBy(Type = typeof(Physics), Member = "RaycastAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray)}, ReturnType = typeof(RaycastHit[]))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC4C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC5B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Physics), Member = "Internal_RaycastAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PhysicsScene), typeof(Ray), typeof(float), typeof(int), typeof(QueryTriggerInteraction)}, ReturnType = typeof(RaycastHit[]))]
	[Token(Token = "0x60000FE")]
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[Address(RVA = "0x19EEEB0", Offset = "0x19EE0B0", Length = "0x8B")]
	[CalledBy(Type = "Polytoria.Datamodel.Services.InputService", Member = "ScreenPointToRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "System.Collections.Generic.List`1<Instance>"}, ReturnType = "System.Nullable`1<RayResult>")]
	[CalledBy(Type = "Polytoria.Datamodel.Services.InputService", Member = "ViewportPointToRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "System.Collections.Generic.List`1<Instance>"}, ReturnType = "System.Nullable`1<RayResult>")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Physics), Member = "RaycastAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), typeof(int), typeof(QueryTriggerInteraction)}, ReturnType = typeof(RaycastHit[]))]
	[ExcludeFromDocs]
	[Token(Token = "0x6000105")]
	public static RaycastHit[] RaycastAll(Ray ray) { }

	[Address(RVA = "0x19EF6F0", Offset = "0x19EE8F0", Length = "0xE3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(RaycastHit[]), typeof(float), typeof(int), typeof(QueryTriggerInteraction)}, ReturnType = typeof(int))]
	[Token(Token = "0x6000106")]
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[Address(RVA = "0x19EF7E0", Offset = "0x19EE9E0", Length = "0xE9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(RaycastHit[]), typeof(float), typeof(int), typeof(QueryTriggerInteraction)}, ReturnType = typeof(int))]
	[Token(Token = "0x600010A")]
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[Address(RVA = "0x19EF8D0", Offset = "0x19EEAD0", Length = "0x1F1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC4C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC5B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromDocs]
	[Token(Token = "0x600010D")]
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results) { }

	[Address(RVA = "0x19EF400", Offset = "0x19EE600", Length = "0x1F8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC4C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC5B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromDocs]
	[Token(Token = "0x600010C")]
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance) { }

	[Address(RVA = "0x19EF600", Offset = "0x19EE800", Length = "0xE2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(RaycastHit[]), typeof(float), typeof(int), typeof(QueryTriggerInteraction)}, ReturnType = typeof(int))]
	[ExcludeFromDocs]
	[Token(Token = "0x600010B")]
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask) { }

	[Address(RVA = "0x19EF320", Offset = "0x19EE520", Length = "0xDC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(RaycastHit[]), typeof(float), typeof(int), typeof(QueryTriggerInteraction)}, ReturnType = typeof(int))]
	[ExcludeFromDocs]
	[RequiredByNativeCode]
	[Token(Token = "0x6000107")]
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask) { }

	[Address(RVA = "0x19EF130", Offset = "0x19EE330", Length = "0x1E3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC4C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC5B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromDocs]
	[Token(Token = "0x6000109")]
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results) { }

	[Address(RVA = "0x19EEF40", Offset = "0x19EE140", Length = "0x1EA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC4C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC5B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromDocs]
	[Token(Token = "0x6000108")]
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance) { }

	[Address(RVA = "0x19F0F10", Offset = "0x19F0110", Length = "0x407")]
	[CalledBy(Type = typeof(Physics), Member = "OnSceneContact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PhysicsScene), typeof(IntPtr), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rigidbody2D", Member = "set_velocity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Physics), Member = "GetBodyByInstanceID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EntityId)}, ReturnType = typeof(Component))]
	[Calls(Type = typeof(Physics), Member = "SendOnCollisionEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Component), typeof(Collision)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Physics), Member = "GetCollisionToReport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContactPairHeader&), typeof(ContactPair&), typeof(bool)}, ReturnType = typeof(Collision))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ContactPair), Member = "get_otherCollider", ReturnType = typeof(Collider))]
	[Calls(Type = typeof(ContactPair), Member = "get_collider", ReturnType = typeof(Collider))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ContactPairHeader), Member = "GetContactPair_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ContactPair*))]
	[Calls(Type = typeof(Physics), Member = "SendOnCollisionStay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Component), typeof(Collision)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Physics), Member = "SendOnCollisionExit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Component), typeof(Collision)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600011D")]
	private static void ReportContacts(ReadOnly<ContactPairHeader> array) { }

	[Address(RVA = "0x19F1370", Offset = "0x19F0570", Length = "0x9B")]
	[CalledBy(Type = typeof(Physics), Member = "ReportContacts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1+ReadOnly<UnityEngine.ContactPairHeader>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[StaticAccessor("PhysicsManager", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x6000119")]
	private static void SendOnCollisionEnter(Component component, Collision collision) { }

	[Address(RVA = "0x19F1320", Offset = "0x19F0520", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000128")]
	private static void SendOnCollisionEnter_Injected(IntPtr component, Collision collision) { }

	[Address(RVA = "0x19F1460", Offset = "0x19F0660", Length = "0x9B")]
	[CalledBy(Type = typeof(Physics), Member = "ReportContacts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1+ReadOnly<UnityEngine.ContactPairHeader>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[StaticAccessor("PhysicsManager", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x600011B")]
	private static void SendOnCollisionExit(Component component, Collision collision) { }

	[Address(RVA = "0x19F1410", Offset = "0x19F0610", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600012A")]
	private static void SendOnCollisionExit_Injected(IntPtr component, Collision collision) { }

	[Address(RVA = "0x19F1550", Offset = "0x19F0750", Length = "0x9B")]
	[CalledBy(Type = typeof(Physics), Member = "ReportContacts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1+ReadOnly<UnityEngine.ContactPairHeader>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[StaticAccessor("PhysicsManager", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x600011A")]
	private static void SendOnCollisionStay(Component component, Collision collision) { }

	[Address(RVA = "0x19F1500", Offset = "0x19F0700", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000129")]
	private static void SendOnCollisionStay_Injected(IntPtr component, Collision collision) { }

	[Address(RVA = "0x19F18A0", Offset = "0x19F0AA0", Length = "0x64")]
	[CalledBy(Type = "Polytoria.Datamodel.Environment", Member = "set_Gravity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000E6")]
	public static void set_gravity(Vector3 value) { }

	[Address(RVA = "0x19F1860", Offset = "0x19F0A60", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000121")]
	private static void set_gravity_Injected(in Vector3 value) { }

	[Address(RVA = "0x19F15F0", Offset = "0x19F07F0", Length = "0x2A")]
	[CalledBy(Type = "Mirror.NetworkTransformHybrid", Member = "ResetState", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkTransformBase", Member = "ResetState", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkTransformReliable", Member = "ResetState", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000111")]
	public static void SyncTransforms() { }

}

