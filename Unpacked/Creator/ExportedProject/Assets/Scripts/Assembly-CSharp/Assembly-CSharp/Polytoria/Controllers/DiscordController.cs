namespace Polytoria.Controllers;

[Token(Token = "0x20003F8")]
public class DiscordController : MonoBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x20003F9")]
	private sealed class <>c
	{
		[Token(Token = "0x40010AB")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40010AC")]
		public static UpdateActivityHandler <>9__11_0; //Field offset: 0x8

		[Address(RVA = "0x4CF400", Offset = "0x4CE600", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002ABD")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002ABE")]
		public <>c() { }

		[Address(RVA = "0x4CF320", Offset = "0x4CE520", Length = "0xA4")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Token(Token = "0x6002ABF")]
		internal void <UpdateActivity>b__11_0(Result res) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x40010A7")]
	private static DiscordController <Instance>k__BackingField; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40010A8")]
	private Discord discord; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40010A9")]
	private ActivityManager activityManager; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40010AA")]
	private Activity currentActivity; //Field offset: 0x30

	[Token(Token = "0x17000CD3")]
	public Activity Activity
	{
		[Address(RVA = "0x4B94B0", Offset = "0x4B86B0", Length = "0x5A")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6002AB6")]
		 get { } //Length: 90
	}

	[Token(Token = "0x17000CD2")]
	public private static DiscordController Instance
	{
		[Address(RVA = "0x4B9510", Offset = "0x4B8710", Length = "0x36")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CompilerGenerated]
		[Token(Token = "0x6002AB4")]
		 get { } //Length: 54
		[Address(RVA = "0x4B9550", Offset = "0x4B8750", Length = "0x51")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[Token(Token = "0x6002AB5")]
		private set { } //Length: 81
	}

	[Address(RVA = "0x2C7050", Offset = "0x2C6250", Length = "0x7")]
	[CallerCount(Count = 60)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002ABC")]
	public DiscordController() { }

	[Address(RVA = "0x4B9120", Offset = "0x4B8320", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6002AB7")]
	private void Awake() { }

	[Address(RVA = "0x4B94B0", Offset = "0x4B86B0", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6002AB6")]
	public Activity get_Activity() { }

	[Address(RVA = "0x4B9510", Offset = "0x4B8710", Length = "0x36")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CompilerGenerated]
	[Token(Token = "0x6002AB4")]
	public static DiscordController get_Instance() { }

	[Address(RVA = "0x4B9180", Offset = "0x4B8380", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Discord), Member = "Dispose", ReturnType = typeof(void))]
	[Token(Token = "0x6002ABB")]
	private void OnDestroy() { }

	[Address(RVA = "0x4B9550", Offset = "0x4B8750", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[Token(Token = "0x6002AB5")]
	private static void set_Instance(DiscordController value) { }

	[Address(RVA = "0x4B91A0", Offset = "0x4B83A0", Length = "0xD0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "DontDestroyOnLoad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Discord), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Discord), Member = "GetActivityManager", ReturnType = typeof(ActivityManager))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002AB8")]
	private void Start() { }

	[Address(RVA = "0x4B9490", Offset = "0x4B8690", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Discord), Member = "RunCallbacks", ReturnType = typeof(void))]
	[Token(Token = "0x6002ABA")]
	private void Update() { }

	[Address(RVA = "0x4B9280", Offset = "0x4B8480", Length = "0x20A")]
	[CalledBy(Type = typeof(CreatorController), Member = "DoLoadMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Player+<DiscordLoop>d__195", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Datamodel.Player+<PostPlayerLoad>d__194", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.NetworkController+<PlaySolo>d__9", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.NetworkController+<StartClient>d__8", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CreatorController), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorController), Member = "ClearWorkspace", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorController), Member = "DoSaveFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ActivityManager), Member = "UpdateActivity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Activity), typeof(UpdateActivityHandler)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002AB9")]
	public void UpdateActivity(Activity activity) { }

}

