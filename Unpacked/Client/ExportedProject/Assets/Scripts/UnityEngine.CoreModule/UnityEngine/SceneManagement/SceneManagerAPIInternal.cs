namespace UnityEngine.SceneManagement;

[NativeHeader("Runtime/Export/SceneManager/SceneManager.bindings.h")]
[NativeHeader("Runtime/SceneManager/SceneManager.h")]
[StaticAccessor("SceneManagerBindings", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x20001E2")]
internal static class SceneManagerAPIInternal
{

	[Address(RVA = "0x198C250", Offset = "0x198B450", Length = "0x215")]
	[CalledBy(Type = typeof(SceneManagerAPI), Member = "LoadSceneAsyncByNameOrIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(LoadSceneParameters), typeof(bool)}, ReturnType = typeof(AsyncOperation))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181979BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[NativeThrows]
	[Token(Token = "0x6000CA4")]
	public static AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame) { }

	[Address(RVA = "0x198C1E0", Offset = "0x198B3E0", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000CA6")]
	private static IntPtr LoadSceneAsyncNameIndexInternal_Injected(ref ManagedSpanWrapper sceneName, int sceneBuildIndex, in LoadSceneParameters parameters, bool mustCompleteNextFrame) { }

	[Address(RVA = "0x198C4E0", Offset = "0x198B6E0", Length = "0x231")]
	[CalledBy(Type = typeof(SceneManagerAPI), Member = "UnloadSceneAsyncByNameOrIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(bool), typeof(UnloadSceneOptions), typeof(Boolean&)}, ReturnType = typeof(AsyncOperation))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181979BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[NativeThrows]
	[Token(Token = "0x6000CA5")]
	public static AsyncOperation UnloadSceneNameIndexInternal(string sceneName, int sceneBuildIndex, bool immediately, UnloadSceneOptions options, out bool outSuccess) { }

	[Address(RVA = "0x198C470", Offset = "0x198B670", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000CA7")]
	private static IntPtr UnloadSceneNameIndexInternal_Injected(ref ManagedSpanWrapper sceneName, int sceneBuildIndex, bool immediately, UnloadSceneOptions options, out bool outSuccess) { }

}

