namespace UnityEngine.SceneManagement;

[NativeHeader("Runtime/Export/SceneManager/SceneManager.bindings.h")]
[RequiredByNativeCode]
[Token(Token = "0x20001E4")]
public class SceneManager
{
	[Token(Token = "0x4000685")]
	internal static bool s_AllowLoadScene; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000686")]
	private static UnityAction<Scene, LoadSceneMode> sceneLoaded; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000687")]
	private static UnityAction<Scene> sceneUnloaded; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000688")]
	private static UnityAction<Scene, Scene> activeSceneChanged; //Field offset: 0x18

	[Token(Token = "0x1400000C")]
	public static event UnityAction<Scene, LoadSceneMode> sceneLoaded
	{
		[Address(RVA = "0x198D8F0", Offset = "0x198CAF0", Length = "0x105")]
		[CalledBy(Type = "LeanTween", Member = "init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.NetworkManager", Member = "Awake", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000CB8")]
		 add { } //Length: 261
		[Address(RVA = "0x198DA30", Offset = "0x198CC30", Length = "0x105")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000CB9")]
		 remove { } //Length: 261
	}

	[Token(Token = "0x1700020B")]
	public static int sceneCount
	{
		[Address(RVA = "0x198DA00", Offset = "0x198CC00", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[NativeHeader("Runtime/SceneManager/SceneManager.h")]
		[NativeMethod("GetSceneCount")]
		[StaticAccessor("GetSceneManager()", StaticAccessorType::Dot (0))]
		[Token(Token = "0x6000CAF")]
		 get { } //Length: 42
	}

	[Address(RVA = "0x198D8B0", Offset = "0x198CAB0", Length = "0x36")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000CC3")]
	private static SceneManager() { }

	[Address(RVA = "0x198D8F0", Offset = "0x198CAF0", Length = "0x105")]
	[CalledBy(Type = "LeanTween", Member = "init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkManager", Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000CB8")]
	public static void add_sceneLoaded(UnityAction<Scene, LoadSceneMode> value) { }

	[Address(RVA = "0x198DA00", Offset = "0x198CC00", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeHeader("Runtime/SceneManager/SceneManager.h")]
	[NativeMethod("GetSceneCount")]
	[StaticAccessor("GetSceneManager()", StaticAccessorType::Dot (0))]
	[Token(Token = "0x6000CAF")]
	public static int get_sceneCount() { }

	[Address(RVA = "0x198C940", Offset = "0x198BB40", Length = "0x6C")]
	[CalledBy(Type = "RLD.RTScene", Member = "CalculateBounds", ReturnType = "RLD.AABB")]
	[CalledBy(Type = "RLD.RTScene", Member = "Update_SystemCall", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkManager", Member = "StopServer", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkManager", Member = "OnClientDisconnectInternal", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Utils", Member = "IsSceneActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities+<GetAllSceneObjects>d__88`1", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[StaticAccessor("SceneManagerBindings", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x6000CB0")]
	public static Scene GetActiveScene() { }

	[Address(RVA = "0x198C900", Offset = "0x198BB00", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000CC4")]
	private static void GetActiveScene_Injected(out Scene ret) { }

	[Address(RVA = "0x198C9F0", Offset = "0x198BBF0", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeThrows]
	[StaticAccessor("SceneManagerBindings", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x6000CB3")]
	public static Scene GetSceneAt(int index) { }

	[Address(RVA = "0x198C9B0", Offset = "0x198BBB0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000CC7")]
	private static void GetSceneAt_Injected(int index, out Scene ret) { }

	[Address(RVA = "0x198CAC0", Offset = "0x198BCC0", Length = "0x1B6")]
	[CalledBy(Type = "Mirror.NetworkManager", Member = "ClientChangeScene", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "Mirror.SceneOperation", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[StaticAccessor("SceneManagerBindings", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x6000CB2")]
	public static Scene GetSceneByName(string name) { }

	[Address(RVA = "0x198CA70", Offset = "0x198BC70", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000CC6")]
	private static void GetSceneByName_Injected(ref ManagedSpanWrapper name, out Scene ret) { }

	[Address(RVA = "0x198CCD0", Offset = "0x198BED0", Length = "0x1B6")]
	[CalledBy(Type = "Mirror.NetworkManager", Member = "ClientChangeScene", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "Mirror.SceneOperation", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[StaticAccessor("SceneManagerBindings", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x6000CB1")]
	public static Scene GetSceneByPath(string scenePath) { }

	[Address(RVA = "0x198CC80", Offset = "0x198BE80", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000CC5")]
	private static void GetSceneByPath_Injected(ref ManagedSpanWrapper scenePath, out Scene ret) { }

	[Address(RVA = "0x198CE90", Offset = "0x198C090", Length = "0x9C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000CC2")]
	private static void Internal_ActiveSceneChanged(Scene previousActiveScene, Scene newActiveScene) { }

	[Address(RVA = "0x198CF30", Offset = "0x198C130", Length = "0x9C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000CC0")]
	private static void Internal_SceneLoaded(Scene scene, LoadSceneMode mode) { }

	[Address(RVA = "0x198CFD0", Offset = "0x198C1D0", Length = "0x94")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000CC1")]
	private static void Internal_SceneUnloaded(Scene scene) { }

	[Address(RVA = "0x198D070", Offset = "0x198C270", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SceneManagerAPI), Member = "get_ActiveAPI", ReturnType = typeof(SceneManagerAPI))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000CB7")]
	internal static AsyncOperation LoadFirstScene_Internal(bool async) { }

	[Address(RVA = "0x198D370", Offset = "0x198C570", Length = "0xF1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SceneManager), Member = "LoadSceneAsyncNameIndexInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(LoadSceneParameters), typeof(bool)}, ReturnType = typeof(AsyncOperation))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000CBB")]
	public static Scene LoadScene(string sceneName, LoadSceneParameters parameters) { }

	[Address(RVA = "0x198D470", Offset = "0x198C670", Length = "0x119")]
	[CalledBy(Type = "Polytoria.Controllers.LaunchController", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.LaunchController", Member = "LaunchAs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Controllers.NetworkType", typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.LaunchController", Member = "OnDeepLinkActivated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SceneManager), Member = "LoadSceneAsyncNameIndexInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(LoadSceneParameters), typeof(bool)}, ReturnType = typeof(AsyncOperation))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 2)]
	[ExcludeFromDocs]
	[Token(Token = "0x6000CBA")]
	public static void LoadScene(string sceneName) { }

	[Address(RVA = "0x198D260", Offset = "0x198C460", Length = "0x98")]
	[CalledBy(Type = "Mirror.NetworkManager", Member = "ServerChangeScene", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkManager", Member = "ClientChangeScene", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "Mirror.SceneOperation", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SceneManager), Member = "LoadSceneAsyncNameIndexInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(LoadSceneParameters), typeof(bool)}, ReturnType = typeof(AsyncOperation))]
	[ExcludeFromDocs]
	[Token(Token = "0x6000CBD")]
	public static AsyncOperation LoadSceneAsync(string sceneName) { }

	[Address(RVA = "0x198D1C0", Offset = "0x198C3C0", Length = "0x9D")]
	[CalledBy(Type = "Mirror.NetworkManager", Member = "ClientChangeScene", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "Mirror.SceneOperation", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SceneManager), Member = "LoadSceneAsyncNameIndexInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(LoadSceneParameters), typeof(bool)}, ReturnType = typeof(AsyncOperation))]
	[Token(Token = "0x6000CBC")]
	public static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneMode mode) { }

	[Address(RVA = "0x198D300", Offset = "0x198C500", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SceneManager), Member = "LoadSceneAsyncNameIndexInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(LoadSceneParameters), typeof(bool)}, ReturnType = typeof(AsyncOperation))]
	[Token(Token = "0x6000CBE")]
	public static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneParameters parameters) { }

	[Address(RVA = "0x198D0E0", Offset = "0x198C2E0", Length = "0xDC")]
	[CalledBy(Type = typeof(SceneManager), Member = "LoadScene", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SceneManager), Member = "LoadScene", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(LoadSceneParameters)}, ReturnType = typeof(Scene))]
	[CalledBy(Type = typeof(SceneManager), Member = "LoadSceneAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(LoadSceneMode)}, ReturnType = typeof(AsyncOperation))]
	[CalledBy(Type = typeof(SceneManager), Member = "LoadSceneAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(AsyncOperation))]
	[CalledBy(Type = typeof(SceneManager), Member = "LoadSceneAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(LoadSceneParameters)}, ReturnType = typeof(AsyncOperation))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SceneManagerAPI), Member = "get_ActiveAPI", ReturnType = typeof(SceneManagerAPI))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000CB4")]
	private static AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame) { }

	[Address(RVA = "0x198D5E0", Offset = "0x198C7E0", Length = "0xC0")]
	[CalledBy(Type = "Mirror.NetworkManager", Member = "StopServer", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkManager", Member = "OnClientDisconnectInternal", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[NativeThrows]
	[StaticAccessor("SceneManagerBindings", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x6000CB6")]
	public static void MoveGameObjectToScene(GameObject go, Scene scene) { }

	[Address(RVA = "0x198D590", Offset = "0x198C790", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000CC8")]
	private static void MoveGameObjectToScene_Injected(IntPtr go, in Scene scene) { }

	[Address(RVA = "0x198DA30", Offset = "0x198CC30", Length = "0x105")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000CB9")]
	public static void remove_sceneLoaded(UnityAction<Scene, LoadSceneMode> value) { }

	[Address(RVA = "0x198D6B0", Offset = "0x198C8B0", Length = "0x109")]
	[CalledBy(Type = "Mirror.NetworkManager", Member = "ClientChangeScene", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "Mirror.SceneOperation", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SceneManagerAPI), Member = "get_ActiveAPI", ReturnType = typeof(SceneManagerAPI))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000CBF")]
	public static AsyncOperation UnloadSceneAsync(string sceneName, UnloadSceneOptions options) { }

	[Address(RVA = "0x198D7C0", Offset = "0x198C9C0", Length = "0xEE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SceneManagerAPI), Member = "get_ActiveAPI", ReturnType = typeof(SceneManagerAPI))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000CB5")]
	private static AsyncOperation UnloadSceneNameIndexInternal(string sceneName, int sceneBuildIndex, bool immediately, UnloadSceneOptions options, out bool outSuccess) { }

}

