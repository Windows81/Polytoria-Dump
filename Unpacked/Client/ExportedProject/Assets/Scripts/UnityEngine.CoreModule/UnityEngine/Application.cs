namespace UnityEngine;

[NativeHeader("Runtime/Misc/SystemInfo.h")]
[NativeHeader("Runtime/Misc/BuildSettings.h")]
[NativeHeader("Runtime/Input/InputManager.h")]
[NativeHeader("Runtime/PreloadManager/PreloadManager.h")]
[NativeHeader("Runtime/Application/AdsIdHandler.h")]
[NativeHeader("Runtime/Export/Application/Application.bindings.h")]
[NativeHeader("Runtime/File/ApplicationSpecificPersistentDataPath.h")]
[NativeHeader("Runtime/Misc/PlayerSettings.h")]
[NativeHeader("Runtime/Utilities/Argv.h")]
[NativeHeader("Runtime/Utilities/URLUtility.h")]
[NativeHeader("Runtime/Misc/Player.h")]
[NativeHeader("Runtime/PreloadManager/LoadSceneOperation.h")]
[NativeHeader("Runtime/BaseClasses/IsPlaying.h")]
[NativeHeader("Runtime/Input/GetInput.h")]
[NativeHeader("Runtime/Application/ApplicationInfo.h")]
[NativeHeader("Runtime/Input/TargetFrameRate.h")]
[NativeHeader("Runtime/Network/NetworkUtility.h")]
[NativeHeader("Runtime/Logging/LogSystem.h")]
[Token(Token = "0x2000070")]
public class Application
{
	[Token(Token = "0x2000073")]
	internal sealed class LogCallback : MulticastDelegate
	{

		[Address(RVA = "0x192DFC0", Offset = "0x192D1C0", Length = "0xB5")]
		[CalledBy(Type = "Mirror.ThreadLog", Member = "Initialize", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.GUIConsole", Member = "Awake", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000198")]
		public LogCallback(object object, IntPtr method) { }

		[Address(RVA = "0x3354C0", Offset = "0x3346C0", Length = "0x14")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000199")]
		public override void Invoke(string condition, string stackTrace, LogType type) { }

	}

	[Token(Token = "0x2000071")]
	internal sealed class LowMemoryCallback : MulticastDelegate
	{

		[Address(RVA = "0x2D8810", Offset = "0x2D7A10", Length = "0xA5")]
		[CallerCount(Count = 285)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000194")]
		public LowMemoryCallback(object object, IntPtr method) { }

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
		[Token(Token = "0x6000195")]
		public override void Invoke() { }

	}

	[Token(Token = "0x2000072")]
	internal sealed class MemoryUsageChangedCallback : MulticastDelegate
	{

		[Address(RVA = "0x38E330", Offset = "0x38D530", Length = "0xB4")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000196")]
		public MemoryUsageChangedCallback(object object, IntPtr method) { }

		[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000197")]
		public override void Invoke(in ApplicationMemoryUsageChange usage) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x40000E3")]
	private static LowMemoryCallback lowMemory; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x40000E4")]
	private static MemoryUsageChangedCallback memoryUsageChanged; //Field offset: 0x8
	[Token(Token = "0x40000E5")]
	private static LogCallback s_LogCallbackHandler; //Field offset: 0x10
	[Token(Token = "0x40000E6")]
	private static LogCallback s_LogCallbackHandlerThreaded; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x40000E7")]
	private static Action<Boolean> focusChanged; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x40000E8")]
	private static Action<String> deepLinkActivated; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x40000E9")]
	private static Func<Boolean> wantsToQuit; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x40000EA")]
	private static Action quitting; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x40000EB")]
	private static Action unloading; //Field offset: 0x40
	[Token(Token = "0x40000EC")]
	private static CancellationTokenSource s_currentCancellationTokenSource; //Field offset: 0x48

	[Token(Token = "0x14000004")]
	public static event Action<String> deepLinkActivated
	{
		[Address(RVA = "0x191D6C0", Offset = "0x191C8C0", Length = "0x105")]
		[CalledBy(Type = "Polytoria.Controllers.LaunchController", Member = "Start", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600017F")]
		 add { } //Length: 261
		[Address(RVA = "0x191E370", Offset = "0x191D570", Length = "0x105")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000180")]
		 remove { } //Length: 261
	}

	[Token(Token = "0x14000003")]
	public static event Action<Boolean> focusChanged
	{
		[Address(RVA = "0x191D7D0", Offset = "0x191C9D0", Length = "0x105")]
		[CalledBy(Type = "UnityEngine.InputForUI.EventProvider", Member = "Initialize", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600017D")]
		 add { } //Length: 261
		[Address(RVA = "0x191E480", Offset = "0x191D680", Length = "0x105")]
		[CalledBy(Type = "UnityEngine.InputForUI.EventProvider", Member = "SetEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.InputForUI.EventProvider", Member = "Shutdown", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600017E")]
		 remove { } //Length: 261
	}

	[Token(Token = "0x14000001")]
	public static event LogCallback logMessageReceived
	{
		[Address(RVA = "0x191DA00", Offset = "0x191CC00", Length = "0x113")]
		[CalledBy(Type = "Mirror.GUIConsole", Member = "Awake", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000178")]
		 add { } //Length: 275
		[Address(RVA = "0x191E680", Offset = "0x191D880", Length = "0xEF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Token(Token = "0x6000179")]
		 remove { } //Length: 239
	}

	[Token(Token = "0x14000002")]
	public static event LogCallback logMessageReceivedThreaded
	{
		[Address(RVA = "0x191D8E0", Offset = "0x191CAE0", Length = "0x113")]
		[CalledBy(Type = "Mirror.ThreadLog", Member = "Initialize", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600017A")]
		 add { } //Length: 275
		[Address(RVA = "0x191E590", Offset = "0x191D790", Length = "0xEF")]
		[CalledBy(Type = "Mirror.ThreadLog", Member = "Initialize", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Token(Token = "0x600017B")]
		 remove { } //Length: 239
	}

	[Token(Token = "0x14000005")]
	public static event Func<Boolean> wantsToQuit
	{
		[Address(RVA = "0x191DB20", Offset = "0x191CD20", Length = "0x105")]
		[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "Awake", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000181")]
		 add { } //Length: 261
		[Address(RVA = "0x191E770", Offset = "0x191D970", Length = "0x105")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000182")]
		 remove { } //Length: 261
	}

	[Token(Token = "0x17000038")]
	public static string absoluteURL
	{
		[Address(RVA = "0x191DC70", Offset = "0x191CE70", Length = "0xDE")]
		[CalledBy(Type = "Polytoria.Controllers.LaunchController", Member = "OnDeepLinkActivated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(OutStringMarshaller), Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ManagedSpanWrapper)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsUnknownMethods(Count = 1)]
		[FreeFunction("GetPlayerSettings().GetAbsoluteURL")]
		[Token(Token = "0x600016D")]
		 get { } //Length: 222
	}

	[Token(Token = "0x17000035")]
	public static bool isBatchMode
	{
		[Address(RVA = "0x191DD50", Offset = "0x191CF50", Length = "0x2A")]
		[CalledBy(Type = "UnityEngine.UI.StencilMaterial", Member = "LogWarningWhenNotInBatchmode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[FreeFunction("::IsBatchmode")]
		[Token(Token = "0x600016A")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700003E")]
	public static bool isEditor
	{
		[Address(RVA = "0x191DD80", Offset = "0x191CF80", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x600018B")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000033")]
	public static bool isFocused
	{
		[Address(RVA = "0x191DD90", Offset = "0x191CF90", Length = "0x2A")]
		[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem", Member = "get_isAppFocused", ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.DefaultEventSystem+UpdateMode"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Camera", Member = "HandleCameraRotation", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[FreeFunction("IsPlayerFocused")]
		[Token(Token = "0x6000168")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700003D")]
	public static bool isMobilePlatform
	{
		[Address(RVA = "0x191DDC0", Offset = "0x191CFC0", Length = "0x92")]
		[CalledBy(Type = "Polytoria.Controllers.LaunchController", Member = "Start", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000175")]
		 get { } //Length: 146
	}

	[Token(Token = "0x17000032")]
	public static bool isPlaying
	{
		[Address(RVA = "0x191DE60", Offset = "0x191D060", Length = "0x2A")]
		[CallerCount(Count = 44)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[FreeFunction("IsWorldPlaying")]
		[Token(Token = "0x6000166")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700003C")]
	public static RuntimePlatform platform
	{
		[Address(RVA = "0x191DE90", Offset = "0x191D090", Length = "0x2A")]
		[CallerCount(Count = 49)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[FreeFunction("systeminfo::GetRuntimePlatform", IsThreadSafe = True)]
		[Token(Token = "0x6000174")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000034")]
	public static bool runInBackground
	{
		[Address(RVA = "0x191E880", Offset = "0x191DA80", Length = "0x33")]
		[CalledBy(Type = "Mirror.NetworkManager", Member = "SetupServer", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.NetworkManager", Member = "SetupClient", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[FreeFunction("SetPlayerSettingsRunInBackground")]
		[Token(Token = "0x6000169")]
		 set { } //Length: 51
	}

	[Token(Token = "0x17000036")]
	public static string streamingAssetsPath
	{
		[Address(RVA = "0x191DF00", Offset = "0x191D100", Length = "0xDE")]
		[CalledBy(Type = "GLTFast.GltfAsset+<Start>d__28", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "GLTFast.GltfAsset", Member = "get_FullUrl", ReturnType = typeof(string))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(OutStringMarshaller), Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ManagedSpanWrapper)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsUnknownMethods(Count = 1)]
		[FreeFunction("GetStreamingAssetsPath", IsThreadSafe = True)]
		[Token(Token = "0x600016B")]
		 get { } //Length: 222
	}

	[Token(Token = "0x1700003B")]
	public static int targetFrameRate
	{
		[Address(RVA = "0x191DFE0", Offset = "0x191D1E0", Length = "0x2A")]
		[CalledBy(Type = "GLTFast.TimeBudgetPerFrameDeferAgent", Member = "UpdateTimeBudget", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[FreeFunction("GetTargetFrameRate")]
		[Token(Token = "0x6000171")]
		 get { } //Length: 42
		[Address(RVA = "0x191E8C0", Offset = "0x191DAC0", Length = "0x31")]
		[CalledBy(Type = "Polytoria.Controllers.LaunchController", Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.NetworkManager", Member = "ConfigureHeadlessFrameRate", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[FreeFunction("SetTargetFrameRate")]
		[Token(Token = "0x6000172")]
		 set { } //Length: 49
	}

	[Token(Token = "0x17000037")]
	public static string temporaryCachePath
	{
		[Address(RVA = "0x191E050", Offset = "0x191D250", Length = "0xDE")]
		[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "TestGame", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(OutStringMarshaller), Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ManagedSpanWrapper)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsUnknownMethods(Count = 1)]
		[FreeFunction("GetTemporaryCachePathApplicationSpecific")]
		[Token(Token = "0x600016C")]
		 get { } //Length: 222
	}

	[Token(Token = "0x17000039")]
	public static string unityVersion
	{
		[Address(RVA = "0x191E170", Offset = "0x191D370", Length = "0xDE")]
		[CalledBy(Type = "Polytoria.Controllers.NetworkController+<StartClient>d__8", Member = "MoveNext", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(OutStringMarshaller), Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ManagedSpanWrapper)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsUnknownMethods(Count = 1)]
		[FreeFunction("Application_Bindings::GetUnityVersion", IsThreadSafe = True)]
		[Token(Token = "0x600016E")]
		 get { } //Length: 222
	}

	[Token(Token = "0x1700003A")]
	public static string version
	{
		[Address(RVA = "0x191E290", Offset = "0x191D490", Length = "0xDE")]
		[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "SaveToFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.MeshPartLoadController+<GetMeshUrlAsync>d__17", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.NetworkController+<StartClient>d__8", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = "Polytoria.Controllers.ScriptingAPIDumper", Member = "DumpAPI", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "Start", ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(OutStringMarshaller), Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ManagedSpanWrapper)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsUnknownMethods(Count = 1)]
		[FreeFunction("GetApplicationInfo().GetVersion")]
		[Token(Token = "0x600016F")]
		 get { } //Length: 222
	}

	[Address(RVA = "0x191D640", Offset = "0x191C840", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CancellationTokenSource), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600018C")]
	private static Application() { }

	[Address(RVA = "0x191D6C0", Offset = "0x191C8C0", Length = "0x105")]
	[CalledBy(Type = "Polytoria.Controllers.LaunchController", Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600017F")]
	public static void add_deepLinkActivated(Action<String> value) { }

	[Address(RVA = "0x191D7D0", Offset = "0x191C9D0", Length = "0x105")]
	[CalledBy(Type = "UnityEngine.InputForUI.EventProvider", Member = "Initialize", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600017D")]
	public static void add_focusChanged(Action<Boolean> value) { }

	[Address(RVA = "0x191DA00", Offset = "0x191CC00", Length = "0x113")]
	[CalledBy(Type = "Mirror.GUIConsole", Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000178")]
	public static void add_logMessageReceived(LogCallback value) { }

	[Address(RVA = "0x191D8E0", Offset = "0x191CAE0", Length = "0x113")]
	[CalledBy(Type = "Mirror.ThreadLog", Member = "Initialize", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600017A")]
	public static void add_logMessageReceivedThreaded(LogCallback value) { }

	[Address(RVA = "0x191DB20", Offset = "0x191CD20", Length = "0x105")]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000181")]
	public static void add_wantsToQuit(Func<Boolean> value) { }

	[Address(RVA = "0x191CA40", Offset = "0x191BC40", Length = "0xE8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsUnknownMethods(Count = 2)]
	[RequiredByNativeCode]
	[Token(Token = "0x600017C")]
	private static void CallLogCallback(string logString, string stackTrace, LogType type, bool invokedOnMainThread) { }

	[Address(RVA = "0x191CB30", Offset = "0x191BD30", Length = "0x13B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 2)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000176")]
	internal static void CallLowMemory(ApplicationMemoryUsage usage) { }

	[Address(RVA = "0x191DC70", Offset = "0x191CE70", Length = "0xDE")]
	[CalledBy(Type = "Polytoria.Controllers.LaunchController", Member = "OnDeepLinkActivated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(OutStringMarshaller), Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ManagedSpanWrapper)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("GetPlayerSettings().GetAbsoluteURL")]
	[Token(Token = "0x600016D")]
	public static string get_absoluteURL() { }

	[Address(RVA = "0x191DC30", Offset = "0x191CE30", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000190")]
	private static void get_absoluteURL_Injected(out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x191DD50", Offset = "0x191CF50", Length = "0x2A")]
	[CalledBy(Type = "UnityEngine.UI.StencilMaterial", Member = "LogWarningWhenNotInBatchmode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("::IsBatchmode")]
	[Token(Token = "0x600016A")]
	public static bool get_isBatchMode() { }

	[Address(RVA = "0x191DD80", Offset = "0x191CF80", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x600018B")]
	public static bool get_isEditor() { }

	[Address(RVA = "0x191DD90", Offset = "0x191CF90", Length = "0x2A")]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem", Member = "get_isAppFocused", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.DefaultEventSystem+UpdateMode"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Camera", Member = "HandleCameraRotation", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("IsPlayerFocused")]
	[Token(Token = "0x6000168")]
	public static bool get_isFocused() { }

	[Address(RVA = "0x191DDC0", Offset = "0x191CFC0", Length = "0x92")]
	[CalledBy(Type = "Polytoria.Controllers.LaunchController", Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000175")]
	public static bool get_isMobilePlatform() { }

	[Address(RVA = "0x191DE60", Offset = "0x191D060", Length = "0x2A")]
	[CallerCount(Count = 44)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("IsWorldPlaying")]
	[Token(Token = "0x6000166")]
	public static bool get_isPlaying() { }

	[Address(RVA = "0x191DE90", Offset = "0x191D090", Length = "0x2A")]
	[CallerCount(Count = 49)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("systeminfo::GetRuntimePlatform", IsThreadSafe = True)]
	[Token(Token = "0x6000174")]
	public static RuntimePlatform get_platform() { }

	[Address(RVA = "0x191DF00", Offset = "0x191D100", Length = "0xDE")]
	[CalledBy(Type = "GLTFast.GltfAsset+<Start>d__28", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.GltfAsset", Member = "get_FullUrl", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(OutStringMarshaller), Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ManagedSpanWrapper)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("GetStreamingAssetsPath", IsThreadSafe = True)]
	[Token(Token = "0x600016B")]
	public static string get_streamingAssetsPath() { }

	[Address(RVA = "0x191DEC0", Offset = "0x191D0C0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600018E")]
	private static void get_streamingAssetsPath_Injected(out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x191DFE0", Offset = "0x191D1E0", Length = "0x2A")]
	[CalledBy(Type = "GLTFast.TimeBudgetPerFrameDeferAgent", Member = "UpdateTimeBudget", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("GetTargetFrameRate")]
	[Token(Token = "0x6000171")]
	public static int get_targetFrameRate() { }

	[Address(RVA = "0x191E050", Offset = "0x191D250", Length = "0xDE")]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "TestGame", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(OutStringMarshaller), Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ManagedSpanWrapper)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("GetTemporaryCachePathApplicationSpecific")]
	[Token(Token = "0x600016C")]
	public static string get_temporaryCachePath() { }

	[Address(RVA = "0x191E010", Offset = "0x191D210", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600018F")]
	private static void get_temporaryCachePath_Injected(out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x191E170", Offset = "0x191D370", Length = "0xDE")]
	[CalledBy(Type = "Polytoria.Controllers.NetworkController+<StartClient>d__8", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(OutStringMarshaller), Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ManagedSpanWrapper)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("Application_Bindings::GetUnityVersion", IsThreadSafe = True)]
	[Token(Token = "0x600016E")]
	public static string get_unityVersion() { }

	[Address(RVA = "0x191E130", Offset = "0x191D330", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000191")]
	private static void get_unityVersion_Injected(out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x191E290", Offset = "0x191D490", Length = "0xDE")]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "SaveToFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.MeshPartLoadController+<GetMeshUrlAsync>d__17", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.NetworkController+<StartClient>d__8", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.ScriptingAPIDumper", Member = "DumpAPI", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(OutStringMarshaller), Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ManagedSpanWrapper)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("GetApplicationInfo().GetVersion")]
	[Token(Token = "0x600016F")]
	public static string get_version() { }

	[Address(RVA = "0x191E250", Offset = "0x191D450", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000192")]
	private static void get_version_Injected(out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x191CC70", Offset = "0x191BE70", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[RequiredByNativeCode]
	[Token(Token = "0x6000177")]
	internal static bool HasLogCallback() { }

	[Address(RVA = "0x191CCF0", Offset = "0x191BEF0", Length = "0x8C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000186")]
	private static void Internal_ApplicationQuit() { }

	[Address(RVA = "0x191CD80", Offset = "0x191BF80", Length = "0x8C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000187")]
	private static void Internal_ApplicationUnload() { }

	[Address(RVA = "0x191CE10", Offset = "0x191C010", Length = "0x197")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 2)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000183")]
	private static bool Internal_ApplicationWantsToQuit() { }

	[Address(RVA = "0x191CFB0", Offset = "0x191C1B0", Length = "0xFD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CancellationTokenSource), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CancellationTokenSource), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000184")]
	private static void Internal_InitializeExitCancellationToken() { }

	[Address(RVA = "0x191D0B0", Offset = "0x191C2B0", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CancellationTokenSource), Member = "Cancel", ReturnType = typeof(void))]
	[RequiredByNativeCode]
	[Token(Token = "0x6000185")]
	private static void Internal_RaiseExitCancellationToken() { }

	[Address(RVA = "0x191D110", Offset = "0x191C310", Length = "0x96")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x600018A")]
	internal static void InvokeDeepLinkActivated(string url) { }

	[Address(RVA = "0x191D1B0", Offset = "0x191C3B0", Length = "0x96")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000189")]
	internal static void InvokeFocusChanged(bool focus) { }

	[Address(RVA = "0x191D250", Offset = "0x191C450", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BeforeRenderHelper), Member = "Invoke", ReturnType = typeof(void))]
	[RequiredByNativeCode]
	[Token(Token = "0x6000188")]
	internal static void InvokeOnBeforeRender() { }

	[Address(RVA = "0x191D2D0", Offset = "0x191C4D0", Length = "0xBC")]
	[CalledBy(Type = "Mirror.NetworkTeam", Member = "set_teamId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction]
	[Token(Token = "0x6000167")]
	public static bool IsPlaying(object obj) { }

	[Address(RVA = "0x191D290", Offset = "0x191C490", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600018D")]
	private static bool IsPlaying_Injected(IntPtr obj) { }

	[Address(RVA = "0x191D3D0", Offset = "0x191C5D0", Length = "0x18B")]
	[CalledBy(Type = "Polytoria.Controllers.UIController+<>c__DisplayClass121_0", Member = "<LoadLeaderboardThumbnail>b__1", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "TestGame", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "EditScript", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.BaseScript"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "RelaunchCreator", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController+<PublishLevelToID>d__81", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController+<DoPublishModel>d__62", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.UIController+<>c__DisplayClass121_0", Member = "<LoadLeaderboardThumbnail>b__3", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.UIController+<>c__DisplayClass121_0", Member = "<LoadLeaderboardThumbnail>b__2", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.UIController+<>c__DisplayClass120_0", Member = "<AddLeaderboardUser>b__2", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.UIController+<>c__DisplayClass120_0", Member = "<AddLeaderboardUser>b__1", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.UIController+<>c__DisplayClass121_0", Member = "<LoadLeaderboardThumbnail>b__0", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.ToolboxController+<>c__DisplayClass22_0", Member = "<DoReloadToolbox>b__2", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.ScreenshotController", Member = "OpenScreenshot", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.ScreenshotController+<DoPublishScreenshot>d__27", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.LaunchController", Member = "OnDeepLinkActivated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.LaunchController", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextEventHandler", Member = "ATagOnPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerUpEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.ATGTextEventHandler", Member = "HyperlinkOnPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerUpEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.UIController+<>c__DisplayClass120_0", Member = "<AddLeaderboardUser>b__0", ReturnType = typeof(void))]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("OpenURL")]
	[Token(Token = "0x6000170")]
	public static void OpenURL(string url) { }

	[Address(RVA = "0x191D390", Offset = "0x191C590", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000193")]
	private static void OpenURL_Injected(ref ManagedSpanWrapper url) { }

	[Address(RVA = "0x191D560", Offset = "0x191C760", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("GetInputManager().QuitApplication")]
	[Token(Token = "0x6000164")]
	public static void Quit(int exitCode) { }

	[Address(RVA = "0x191D5A0", Offset = "0x191C7A0", Length = "0x5D")]
	[CalledBy(Type = "Polytoria.Controllers.LaunchController", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.LaunchController", Member = "OnDeepLinkActivated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.NetworkController+<StartClient>d__8", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.UIController", Member = "ExitGame", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "DoExit", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "RelaunchCreator", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000165")]
	public static void Quit() { }

	[Address(RVA = "0x191E370", Offset = "0x191D570", Length = "0x105")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000180")]
	public static void remove_deepLinkActivated(Action<String> value) { }

	[Address(RVA = "0x191E480", Offset = "0x191D680", Length = "0x105")]
	[CalledBy(Type = "UnityEngine.InputForUI.EventProvider", Member = "SetEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputForUI.EventProvider", Member = "Shutdown", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600017E")]
	public static void remove_focusChanged(Action<Boolean> value) { }

	[Address(RVA = "0x191E680", Offset = "0x191D880", Length = "0xEF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6000179")]
	public static void remove_logMessageReceived(LogCallback value) { }

	[Address(RVA = "0x191E590", Offset = "0x191D790", Length = "0xEF")]
	[CalledBy(Type = "Mirror.ThreadLog", Member = "Initialize", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x600017B")]
	public static void remove_logMessageReceivedThreaded(LogCallback value) { }

	[Address(RVA = "0x191E770", Offset = "0x191D970", Length = "0x105")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000182")]
	public static void remove_wantsToQuit(Func<Boolean> value) { }

	[Address(RVA = "0x191E880", Offset = "0x191DA80", Length = "0x33")]
	[CalledBy(Type = "Mirror.NetworkManager", Member = "SetupServer", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkManager", Member = "SetupClient", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("SetPlayerSettingsRunInBackground")]
	[Token(Token = "0x6000169")]
	public static void set_runInBackground(bool value) { }

	[Address(RVA = "0x191E8C0", Offset = "0x191DAC0", Length = "0x31")]
	[CalledBy(Type = "Polytoria.Controllers.LaunchController", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkManager", Member = "ConfigureHeadlessFrameRate", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("SetTargetFrameRate")]
	[Token(Token = "0x6000172")]
	public static void set_targetFrameRate(int value) { }

	[Address(RVA = "0x191D600", Offset = "0x191C800", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("Application_Bindings::SetLogCallbackDefined")]
	[Token(Token = "0x6000173")]
	private static void SetLogCallbackDefined(bool defined) { }

}

