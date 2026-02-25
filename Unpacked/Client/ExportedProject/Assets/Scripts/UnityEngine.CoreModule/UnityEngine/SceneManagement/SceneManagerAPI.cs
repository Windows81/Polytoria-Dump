namespace UnityEngine.SceneManagement;

[Token(Token = "0x20001E3")]
public class SceneManagerAPI
{
	[Token(Token = "0x4000683")]
	private static SceneManagerAPI s_DefaultAPI; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000684")]
	private static SceneManagerAPI <overrideAPI>k__BackingField; //Field offset: 0x8

	[Token(Token = "0x17000209")]
	internal static SceneManagerAPI ActiveAPI
	{
		[Address(RVA = "0x198C800", Offset = "0x198BA00", Length = "0xA7")]
		[CalledBy(Type = typeof(SceneManager), Member = "LoadSceneAsyncNameIndexInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(LoadSceneParameters), typeof(bool)}, ReturnType = typeof(AsyncOperation))]
		[CalledBy(Type = typeof(SceneManager), Member = "UnloadSceneNameIndexInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(bool), typeof(UnloadSceneOptions), typeof(Boolean&)}, ReturnType = typeof(AsyncOperation))]
		[CalledBy(Type = typeof(SceneManager), Member = "LoadFirstScene_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(AsyncOperation))]
		[CalledBy(Type = typeof(SceneManager), Member = "UnloadSceneAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UnloadSceneOptions)}, ReturnType = typeof(AsyncOperation))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000CA8")]
		internal get { } //Length: 167
	}

	[Token(Token = "0x1700020A")]
	public static SceneManagerAPI overrideAPI
	{
		[Address(RVA = "0x198C8B0", Offset = "0x198BAB0", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[Token(Token = "0x6000CA9")]
		 get { } //Length: 79
	}

	[Address(RVA = "0x198C790", Offset = "0x198B990", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000CAE")]
	private static SceneManagerAPI() { }

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CAA")]
	protected private SceneManagerAPI() { }

	[Address(RVA = "0x198C800", Offset = "0x198BA00", Length = "0xA7")]
	[CalledBy(Type = typeof(SceneManager), Member = "LoadSceneAsyncNameIndexInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(LoadSceneParameters), typeof(bool)}, ReturnType = typeof(AsyncOperation))]
	[CalledBy(Type = typeof(SceneManager), Member = "UnloadSceneNameIndexInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(bool), typeof(UnloadSceneOptions), typeof(Boolean&)}, ReturnType = typeof(AsyncOperation))]
	[CalledBy(Type = typeof(SceneManager), Member = "LoadFirstScene_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(AsyncOperation))]
	[CalledBy(Type = typeof(SceneManager), Member = "UnloadSceneAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UnloadSceneOptions)}, ReturnType = typeof(AsyncOperation))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000CA8")]
	internal static SceneManagerAPI get_ActiveAPI() { }

	[Address(RVA = "0x198C8B0", Offset = "0x198BAB0", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[Token(Token = "0x6000CA9")]
	public static SceneManagerAPI get_overrideAPI() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CAD")]
	protected private override AsyncOperation LoadFirstScene(bool mustLoadAsync) { }

	[Address(RVA = "0x198C720", Offset = "0x198B920", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SceneManagerAPIInternal), Member = "LoadSceneAsyncNameIndexInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(LoadSceneParameters), typeof(bool)}, ReturnType = typeof(AsyncOperation))]
	[Token(Token = "0x6000CAB")]
	protected private override AsyncOperation LoadSceneAsyncByNameOrIndex(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame) { }

	[Address(RVA = "0x198C750", Offset = "0x198B950", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SceneManagerAPIInternal), Member = "UnloadSceneNameIndexInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(bool), typeof(UnloadSceneOptions), typeof(Boolean&)}, ReturnType = typeof(AsyncOperation))]
	[Token(Token = "0x6000CAC")]
	protected private override AsyncOperation UnloadSceneAsyncByNameOrIndex(string sceneName, int sceneBuildIndex, bool immediately, UnloadSceneOptions options, out bool outSuccess) { }

}

