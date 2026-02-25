namespace Polytoria.Controllers;

[Token(Token = "0x2000408")]
public class LaunchController : MonoBehaviour
{
	[Token(Token = "0x40010E9")]
	public static LaunchController singleton; //Field offset: 0x0
	[Token(Token = "0x40010EA")]
	public static NetworkType launchType; //Field offset: 0x8
	[Token(Token = "0x40010EB")]
	public static string clientToken; //Field offset: 0x10
	[Token(Token = "0x40010EC")]
	public static string serverToken; //Field offset: 0x18
	[Token(Token = "0x40010ED")]
	public static bool isSolo; //Field offset: 0x20
	[Token(Token = "0x40010EE")]
	public static string soloMapPath; //Field offset: 0x28
	[Token(Token = "0x40010EF")]
	public static string soloUserName; //Field offset: 0x30
	[Token(Token = "0x40010F0")]
	public static int soloUserID; //Field offset: 0x38
	[Token(Token = "0x40010F1")]
	public static int soloID; //Field offset: 0x3C
	[Token(Token = "0x40010F2")]
	public static bool isLocal; //Field offset: 0x40
	[Token(Token = "0x40010F3")]
	public static int localGameId; //Field offset: 0x44
	[Token(Token = "0x40010F4")]
	public static int localUserId; //Field offset: 0x48
	[Token(Token = "0x40010F5")]
	public static string localMapPath; //Field offset: 0x50
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40010F6")]
	private NetworkType editorLaunchType; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40010F7")]
	private string testToken; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x40010F8")]
	private bool doPlaySolo; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x40010F9")]
	private string playSoloTestMap; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x40010FA")]
	private string playSoloTestUserName; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x40010FB")]
	private int playSoloTestUserID; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	[Token(Token = "0x40010FC")]
	private bool doLocal; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x40010FD")]
	private int testLocalUserId; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	[Token(Token = "0x40010FE")]
	private int testLocalGameId; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x40010FF")]
	private string testLocalMapPath; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x4001100")]
	private string testMobileLaunchURI; //Field offset: 0x60

	[Address(RVA = "0x4C3DF0", Offset = "0x4C2FF0", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6002B24")]
	private static LaunchController() { }

	[Address(RVA = "0x2C7050", Offset = "0x2C6250", Length = "0x7")]
	[CallerCount(Count = 60)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B23")]
	public LaunchController() { }

	[Address(RVA = "0x4C2CB0", Offset = "0x4C1EB0", Length = "0x190")]
	[CallerCount(Count = 36)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF6A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002B22")]
	public static string GetActiveToken() { }

	[Address(RVA = "0x4C2E50", Offset = "0x4C2050", Length = "0x144")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Environment), Member = "GetCommandLineArgs", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6002B20")]
	private Dictionary<String, String> GetCommandLineArgs() { }

	[Address(RVA = "0x4C2FA0", Offset = "0x4C21A0", Length = "0xF0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SceneManager), Member = "LoadScene", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002B1F")]
	public void LaunchAs(NetworkType netType, string token) { }

	[Address(RVA = "0x4C3090", Offset = "0x4C2290", Length = "0x1D3")]
	[CalledBy(Type = typeof(LaunchController), Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Application), Member = "OpenURL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Application), Member = "get_absoluteURL", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Application), Member = "Quit", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SceneManager), Member = "LoadScene", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002B21")]
	private void OnDeepLinkActivated(string uri) { }

	[Address(RVA = "0x4C3270", Offset = "0x4C2470", Length = "0xB77")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LaunchController), Member = "OnDeepLinkActivated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Application), Member = "add_deepLinkActivated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.String>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Application), Member = "OpenURL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(ScriptingAPIDumper), Member = "DumpAPI", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SceneManager), Member = "LoadScene", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Environment), Member = "GetCommandLineArgs", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Path), Member = "GetFullPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Application), Member = "Quit", ReturnType = typeof(void))]
	[Calls(Type = typeof(Application), Member = "get_isMobilePlatform", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Application), Member = "set_targetFrameRate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Token(Token = "0x6002B1E")]
	private void Start() { }

}

