namespace UnityEngine.Experimental.Rendering;

[NativeHeader("Runtime/Camera/ScriptableRuntimeReflectionSystem.h")]
[RequiredByNativeCode]
[Token(Token = "0x200031B")]
public static class ScriptableRuntimeReflectionSystemSettings
{
	[Token(Token = "0x40009FA")]
	private static ScriptableRuntimeReflectionSystemWrapper s_Instance; //Field offset: 0x0

	[Token(Token = "0x17000264")]
	private static ScriptableRuntimeReflectionSystemWrapper Internal_ScriptableRuntimeReflectionSystemSettings_instance
	{
		[Address(RVA = "0x198E630", Offset = "0x198D830", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[RequiredByNativeCode]
		[Token(Token = "0x6000EE7")]
		private get { } //Length: 78
	}

	[Token(Token = "0x17000263")]
	private static IScriptableRuntimeReflectionSystem Internal_ScriptableRuntimeReflectionSystemSettings_system
	{
		[Address(RVA = "0x198E680", Offset = "0x198D880", Length = "0x115")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[RequiredByNativeCode]
		[Token(Token = "0x6000EE6")]
		private set { } //Length: 277
	}

	[Address(RVA = "0x198E5B0", Offset = "0x198D7B0", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000EE9")]
	private static ScriptableRuntimeReflectionSystemSettings() { }

	[Address(RVA = "0x198E630", Offset = "0x198D830", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000EE7")]
	private static ScriptableRuntimeReflectionSystemWrapper get_Internal_ScriptableRuntimeReflectionSystemSettings_instance() { }

	[Address(RVA = "0x198E580", Offset = "0x198D780", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::AfterSceneLoad (0))]
	[StaticAccessor("ScriptableRuntimeReflectionSystem", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x6000EE8")]
	private static void ScriptingDirtyReflectionSystemInstance() { }

	[Address(RVA = "0x198E680", Offset = "0x198D880", Length = "0x115")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000EE6")]
	private static void set_Internal_ScriptableRuntimeReflectionSystemSettings_system(IScriptableRuntimeReflectionSystem value) { }

}

