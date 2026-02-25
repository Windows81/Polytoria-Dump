namespace UnityEngine.AI;

[MovedFrom("UnityEngine")]
[NativeHeader("Modules/AI/NavMeshManager.h")]
[NativeHeader("Modules/AI/NavMesh/NavMesh.bindings.h")]
[StaticAccessor("NavMeshBindings", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x200000A")]
public static class NavMesh
{
	[Token(Token = "0x200000B")]
	internal sealed class OnNavMeshPreUpdate : MulticastDelegate
	{

		[Address(RVA = "0x2D8810", Offset = "0x2D7A10", Length = "0xA5")]
		[CallerCount(Count = 285)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x600004F")]
		public OnNavMeshPreUpdate(object object, IntPtr method) { }

		[Address(RVA = "0x2BC000", Offset = "0x2BB200", Length = "0x16A")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802897E0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180288CC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802891B0")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000050")]
		public override void Invoke() { }

	}

	[Token(Token = "0x400000F")]
	public static OnNavMeshPreUpdate onPreUpdate; //Field offset: 0x0

	[Address(RVA = "0x1901670", Offset = "0x1900870", Length = "0x76")]
	[CalledBy(Type = "Unity.AI.Navigation.NavMeshLink", Member = "AddLink", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000040")]
	public static NavMeshLinkInstance AddLink(NavMeshLinkData link, Vector3 position, Quaternion rotation) { }

	[Address(RVA = "0x1901610", Offset = "0x1900810", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeName("AddLink")]
	[StaticAccessor("GetNavMeshManager()")]
	[Token(Token = "0x6000046")]
	internal static int AddLinkInternal(NavMeshLinkData link, Vector3 position, Quaternion rotation) { }

	[Address(RVA = "0x19015B0", Offset = "0x19007B0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600004D")]
	private static int AddLinkInternal_Injected(in NavMeshLinkData link, in Vector3 position, in Quaternion rotation) { }

	[Address(RVA = "0x19017E0", Offset = "0x19009E0", Length = "0x135")]
	[CalledBy(Type = "Unity.AI.Navigation.NavMeshSurface", Member = "AddData", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000039")]
	public static NavMeshDataInstance AddNavMeshData(NavMeshData navMeshData, Vector3 position, Quaternion rotation) { }

	[Address(RVA = "0x1901750", Offset = "0x1900950", Length = "0x8A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeName("LoadData")]
	[StaticAccessor("GetNavMeshManager()")]
	[Token(Token = "0x600003E")]
	internal static int AddNavMeshDataTransformedInternal(NavMeshData navMeshData, Vector3 position, Quaternion rotation) { }

	[Address(RVA = "0x19016F0", Offset = "0x19008F0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600004C")]
	private static int AddNavMeshDataTransformedInternal_Injected(IntPtr navMeshData, in Vector3 position, in Quaternion rotation) { }

	[Address(RVA = "0x1901920", Offset = "0x1900B20", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::BeforeSceneLoad (1))]
	[Token(Token = "0x6000036")]
	private static void ClearPreUpdateListeners() { }

	[Address(RVA = "0x19019B0", Offset = "0x1900BB0", Length = "0x55")]
	[CalledBy(Type = "Unity.AI.Navigation.NavMeshSurface", Member = "GetInflatedBounds", ReturnType = typeof(Bounds))]
	[CalledBy(Type = "Unity.AI.Navigation.NavMeshSurface", Member = "GetBuildSettings", ReturnType = typeof(NavMeshBuildSettings))]
	[CalledBy(Type = "Unity.AI.Navigation.NavMeshSurface", Member = "CollectSources", ReturnType = "System.Collections.Generic.List`1<NavMeshBuildSource>")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600004A")]
	public static NavMeshBuildSettings GetSettingsByID(int agentTypeID) { }

	[Address(RVA = "0x1901970", Offset = "0x1900B70", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600004E")]
	private static void GetSettingsByID_Injected(int agentTypeID, out NavMeshBuildSettings ret) { }

	[Address(RVA = "0x1901A90", Offset = "0x1900C90", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000037")]
	private static void Internal_CallOnNavMeshPreUpdate() { }

	[Address(RVA = "0x1901A10", Offset = "0x1900C10", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeName("SetLinkUserID")]
	[StaticAccessor("GetNavMeshManager()")]
	[Token(Token = "0x600003D")]
	internal static bool InternalSetLinkOwner(int linkID, int ownerID) { }

	[Address(RVA = "0x1901A50", Offset = "0x1900C50", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeName("SetSurfaceUserID")]
	[StaticAccessor("GetNavMeshManager()")]
	[Token(Token = "0x600003C")]
	internal static bool InternalSetOwner(int dataID, int ownerID) { }

	[Address(RVA = "0x1901AE0", Offset = "0x1900CE0", Length = "0x31")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000043")]
	public static bool IsLinkOccupied(NavMeshLinkInstance handle) { }

	[Address(RVA = "0x1901B20", Offset = "0x1900D20", Length = "0x31")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000044")]
	public static bool IsLinkValid(NavMeshLinkInstance handle) { }

	[Address(RVA = "0x1901AE0", Offset = "0x1900CE0", Length = "0x31")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[StaticAccessor("GetNavMeshManager()")]
	[Token(Token = "0x6000048")]
	internal static bool IsOffMeshConnectionOccupied(int handle) { }

	[Address(RVA = "0x1901B20", Offset = "0x1900D20", Length = "0x31")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[StaticAccessor("GetNavMeshManager()")]
	[Token(Token = "0x600003B")]
	internal static bool IsValidLinkHandle(int handle) { }

	[Address(RVA = "0x1901B60", Offset = "0x1900D60", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeName("IsValidSurfaceID")]
	[StaticAccessor("GetNavMeshManager()")]
	[Token(Token = "0x600003A")]
	internal static bool IsValidNavMeshDataHandle(int handle) { }

	[Address(RVA = "0x1901BA0", Offset = "0x1900DA0", Length = "0x31")]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000041")]
	public static void RemoveLink(NavMeshLinkInstance handle) { }

	[Address(RVA = "0x1901BA0", Offset = "0x1900DA0", Length = "0x31")]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[NativeName("RemoveLink")]
	[StaticAccessor("GetNavMeshManager()")]
	[Token(Token = "0x6000047")]
	internal static void RemoveLinkInternal(int handle) { }

	[Address(RVA = "0x1901BE0", Offset = "0x1900DE0", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeName("UnloadData")]
	[StaticAccessor("GetNavMeshManager()")]
	[Token(Token = "0x600003F")]
	internal static void RemoveNavMeshDataInternal(int handle) { }

	[Address(RVA = "0x1901C90", Offset = "0x1900E90", Length = "0x62")]
	[CalledBy(Type = "Polytoria.Datamodel.Environment", Member = "GetPointOnNavMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float)}, ReturnType = typeof(Vector3))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000038")]
	public static bool SamplePosition(Vector3 sourcePosition, out NavMeshHit hit, float maxDistance, int areaMask) { }

	[Address(RVA = "0x1901C20", Offset = "0x1900E20", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600004B")]
	private static bool SamplePosition_Injected(in Vector3 sourcePosition, out NavMeshHit hit, float maxDistance, int areaMask) { }

	[Address(RVA = "0x1901D00", Offset = "0x1900F00", Length = "0x41")]
	[CalledBy(Type = "Unity.AI.Navigation.NavMeshLink", Member = "set_activated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.AI.Navigation.NavMeshLink", Member = "AddLink", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000042")]
	public static void SetLinkActive(NavMeshLinkInstance handle, bool value) { }

	[Address(RVA = "0x1901D50", Offset = "0x1900F50", Length = "0xDA")]
	[CalledBy(Type = "Unity.AI.Navigation.NavMeshLink", Member = "AddLink", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000045")]
	public static void SetLinkOwner(NavMeshLinkInstance handle, object owner) { }

	[Address(RVA = "0x1901E30", Offset = "0x1901030", Length = "0x1C8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[CallsUnknownMethods(Count = 5)]
	[ContainsInvalidInstructions]
	[StaticAccessor("GetNavMeshManager()")]
	[Token(Token = "0x6000049")]
	internal static void SetOffMeshConnectionActive(int linkHandle, bool activated) { }

}

