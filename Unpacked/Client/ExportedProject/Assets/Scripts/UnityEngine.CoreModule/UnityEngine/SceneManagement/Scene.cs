namespace UnityEngine.SceneManagement;

[NativeHeader("Runtime/Export/SceneManager/Scene.bindings.h")]
[Token(Token = "0x20001E1")]
public struct Scene
{
	[FieldOffset(Offset = "0x0")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000682")]
	private int m_Handle; //Field offset: 0x0

	[Token(Token = "0x17000207")]
	public int buildIndex
	{
		[Address(RVA = "0x198E220", Offset = "0x198D420", Length = "0x31")]
		[CalledBy(Type = "LeanTween", Member = "onLevelWasLoaded54", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Scene), typeof(LoadSceneMode)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000C9A")]
		 get { } //Length: 49
	}

	[Token(Token = "0x17000203")]
	public int handle
	{
		[Address(RVA = "0xF6BA50", Offset = "0xF6AC50", Length = "0x5")]
		[CallerCount(Count = 230)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C95")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000206")]
	public bool isLoaded
	{
		[Address(RVA = "0x198E260", Offset = "0x198D460", Length = "0x31")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000C99")]
		 get { } //Length: 49
	}

	[Token(Token = "0x17000205")]
	public string name
	{
		[Address(RVA = "0x198E2A0", Offset = "0x198D4A0", Length = "0xB")]
		[CalledBy(Type = "Mirror.NetworkManager", Member = "StopServer", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.NetworkManager", Member = "OnClientDisconnectInternal", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.Utils", Member = "IsSceneActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Scene), Member = "GetNameInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		[Token(Token = "0x6000C98")]
		 get { } //Length: 11
	}

	[Token(Token = "0x17000204")]
	public string path
	{
		[Address(RVA = "0x198E2B0", Offset = "0x198D4B0", Length = "0xB")]
		[CalledBy(Type = "Mirror.NetworkManager", Member = "StopServer", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.NetworkManager", Member = "OnClientDisconnectInternal", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.Utils", Member = "IsSceneActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Scene), Member = "GetPathInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		[Token(Token = "0x6000C97")]
		 get { } //Length: 11
	}

	[Token(Token = "0x17000208")]
	public int rootCount
	{
		[Address(RVA = "0x198E2C0", Offset = "0x198D4C0", Length = "0x31")]
		[CalledBy(Type = "RLD.RTScene", Member = "CalculateBounds", ReturnType = "RLD.AABB")]
		[CalledBy(Type = "RLD.RTScene", Member = "Update_SystemCall", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000C9B")]
		 get { } //Length: 49
	}

	[Address(RVA = "0x198DB40", Offset = "0x198CD40", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000CA1")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x198E220", Offset = "0x198D420", Length = "0x31")]
	[CalledBy(Type = "LeanTween", Member = "onLevelWasLoaded54", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Scene), typeof(LoadSceneMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000C9A")]
	public int get_buildIndex() { }

	[Address(RVA = "0xF6BA50", Offset = "0xF6AC50", Length = "0x5")]
	[CallerCount(Count = 230)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C95")]
	public int get_handle() { }

	[Address(RVA = "0x198E260", Offset = "0x198D460", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000C99")]
	public bool get_isLoaded() { }

	[Address(RVA = "0x198E2A0", Offset = "0x198D4A0", Length = "0xB")]
	[CalledBy(Type = "Mirror.NetworkManager", Member = "StopServer", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkManager", Member = "OnClientDisconnectInternal", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Utils", Member = "IsSceneActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Scene), Member = "GetNameInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000C98")]
	public string get_name() { }

	[Address(RVA = "0x198E2B0", Offset = "0x198D4B0", Length = "0xB")]
	[CalledBy(Type = "Mirror.NetworkManager", Member = "StopServer", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkManager", Member = "OnClientDisconnectInternal", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Utils", Member = "IsSceneActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Scene), Member = "GetPathInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000C97")]
	public string get_path() { }

	[Address(RVA = "0x198E2C0", Offset = "0x198D4C0", Length = "0x31")]
	[CalledBy(Type = "RLD.RTScene", Member = "CalculateBounds", ReturnType = "RLD.AABB")]
	[CalledBy(Type = "RLD.RTScene", Member = "Update_SystemCall", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000C9B")]
	public int get_rootCount() { }

	[Address(RVA = "0x198DBC0", Offset = "0x198CDC0", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[StaticAccessor("SceneBindings", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x6000C92")]
	private static int GetBuildIndexInternal(int sceneHandle) { }

	[Address(RVA = "0xF6BA50", Offset = "0xF6AC50", Length = "0x5")]
	[CallerCount(Count = 230)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CA0")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x198DC00", Offset = "0x198CE00", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[StaticAccessor("SceneBindings", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x6000C91")]
	private static bool GetIsLoadedInternal(int sceneHandle) { }

	[Address(RVA = "0x198DC80", Offset = "0x198CE80", Length = "0x89")]
	[CalledBy(Type = typeof(Scene), Member = "get_name", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181979C40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[StaticAccessor("SceneBindings", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x6000C90")]
	private static string GetNameInternal(int sceneHandle) { }

	[Address(RVA = "0x198DC40", Offset = "0x198CE40", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000CA3")]
	private static void GetNameInternal_Injected(int sceneHandle, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x198DD50", Offset = "0x198CF50", Length = "0x89")]
	[CalledBy(Type = typeof(Scene), Member = "get_path", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181979C40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[StaticAccessor("SceneBindings", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x6000C8F")]
	private static string GetPathInternal(int sceneHandle) { }

	[Address(RVA = "0x198DD10", Offset = "0x198CF10", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000CA2")]
	private static void GetPathInternal_Injected(int sceneHandle, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x198DDE0", Offset = "0x198CFE0", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[StaticAccessor("SceneBindings", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x6000C93")]
	private static int GetRootCountInternal(int sceneHandle) { }

	[Address(RVA = "0x198E0D0", Offset = "0x198D2D0", Length = "0xC3")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities+<GetAllSceneObjects>d__88`1", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Scene), Member = "GetRootGameObjects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000C9C")]
	public GameObject[] GetRootGameObjects() { }

	[Address(RVA = "0x198DE60", Offset = "0x198D060", Length = "0x267")]
	[CalledBy(Type = "RLD.RTScene", Member = "CalculateBounds", ReturnType = "RLD.AABB")]
	[CalledBy(Type = "RLD.RTScene", Member = "Update_SystemCall", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Scene), Member = "GetRootGameObjects", ReturnType = typeof(GameObject[]))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "set_Capacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x6000C9D")]
	public void GetRootGameObjects(List<GameObject> rootGameObjects) { }

	[Address(RVA = "0x198DE20", Offset = "0x198D020", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[StaticAccessor("SceneBindings", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x6000C94")]
	private static void GetRootGameObjectsInternal(int sceneHandle, object resultRootList) { }

	[Address(RVA = "0x198E1E0", Offset = "0x198D3E0", Length = "0x31")]
	[CalledBy(Type = "Mirror.NetworkManager", Member = "ClientChangeScene", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "Mirror.SceneOperation", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000C96")]
	public bool IsValid() { }

	[Address(RVA = "0x198E1A0", Offset = "0x198D3A0", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[StaticAccessor("SceneBindings", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x6000C8E")]
	private static bool IsValidInternal(int sceneHandle) { }

	[Address(RVA = "0x196BCA0", Offset = "0x196AEA0", Length = "0x8")]
	[CallerCount(Count = 4)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C9E")]
	public static bool op_Equality(Scene lhs, Scene rhs) { }

	[Address(RVA = "0x198E300", Offset = "0x198D500", Length = "0x8")]
	[CalledBy(Type = "Mirror.SceneDistanceInterestManagement", Member = "OnCheckObserver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkIdentity", "Mirror.NetworkConnectionToClient"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000C9F")]
	public static bool op_Inequality(Scene lhs, Scene rhs) { }

}

