namespace Mirror;

[AddComponentMenu("Network/ Interest Management/ Match/Network Match")]
[DisallowMultipleComponent]
[HelpURL("https://mirror-networking.gitbook.io/docs/guides/interest-management")]
[Token(Token = "0x2000009")]
public class NetworkMatch : NetworkBehaviour
{
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000018")]
	private Guid _matchId; //Field offset: 0x68
	[FieldOffset(Offset = "0x78")]
	[ReadOnly]
	[SerializeField]
	[Token(Token = "0x4000019")]
	[Tooltip("Match ID is shown here on server for debugging purposes.")]
	private string MatchID; //Field offset: 0x78

	[Token(Token = "0x17000002")]
	public Guid matchId
	{
		[Address(RVA = "0x3C1BC0", Offset = "0x3C0DC0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600001C")]
		 get { } //Length: 11
		[Address(RVA = "0x1218AA0", Offset = "0x1217CA0", Length = "0x1C2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Guid), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
		[Calls(Type = typeof(MatchInterestManagement), Member = "OnMatchChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkMatch), typeof(Guid)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600001D")]
		 set { } //Length: 450
	}

	[Address(RVA = "0x1218A60", Offset = "0x1217C60", Length = "0x36")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(NetworkBehaviour), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x600001E")]
	public NetworkMatch() { }

	[Address(RVA = "0x3C1BC0", Offset = "0x3C0DC0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600001C")]
	public Guid get_matchId() { }

	[Address(RVA = "0x1218AA0", Offset = "0x1217CA0", Length = "0x1C2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Guid), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(MatchInterestManagement), Member = "OnMatchChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkMatch), typeof(Guid)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600001D")]
	public void set_matchId(Guid value) { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x600001F")]
	public virtual bool Weaved() { }

}

