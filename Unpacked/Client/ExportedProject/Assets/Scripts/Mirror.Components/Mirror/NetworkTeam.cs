namespace Mirror;

[AddComponentMenu("Network/ Interest Management/ Team/Network Team")]
[DisallowMultipleComponent]
[HelpURL("https://mirror-networking.gitbook.io/docs/guides/interest-management")]
[Token(Token = "0x200001B")]
public class NetworkTeam : NetworkBehaviour
{
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x400007D")]
	[Tooltip("Set teamId on Server at runtime to the same value on all networked objects that belong to a given team")]
	private string _teamId; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400007E")]
	[Tooltip("When enabled this object is visible to all clients. Typically this would be true for player objects")]
	public bool forceShown; //Field offset: 0x70

	[Token(Token = "0x17000005")]
	public string teamId
	{
		[Address(RVA = "0x369270", Offset = "0x368470", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000078")]
		 get { } //Length: 5
		[Address(RVA = "0x121EE30", Offset = "0x121E030", Length = "0x1D1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Application), Member = "IsPlaying", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
		[Calls(Type = typeof(TeamInterestManagement), Member = "OnTeamChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkTeam), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000079")]
		 set { } //Length: 465
	}

	[Address(RVA = "0x4848E0", Offset = "0x483AE0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600007A")]
	public NetworkTeam() { }

	[Address(RVA = "0x369270", Offset = "0x368470", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000078")]
	public string get_teamId() { }

	[Address(RVA = "0x121EE30", Offset = "0x121E030", Length = "0x1D1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Application), Member = "IsPlaying", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TeamInterestManagement), Member = "OnTeamChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkTeam), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000079")]
	public void set_teamId(string value) { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x600007B")]
	public virtual bool Weaved() { }

}

