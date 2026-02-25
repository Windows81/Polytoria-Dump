namespace Mirror;

[AddComponentMenu("Network/Network Lobby Player")]
[DisallowMultipleComponent]
[HelpURL("https://mirror-networking.gitbook.io/docs/components/network-room-player")]
[Obsolete("Use / inherit from NetworkRoomPlayer instead")]
[Token(Token = "0x2000023")]
public class NetworkLobbyPlayer : NetworkRoomPlayer
{

	[Address(RVA = "0x1218970", Offset = "0x1217B70", Length = "0xEC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkBehaviour), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60000DB")]
	public NetworkLobbyPlayer() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000DC")]
	public virtual bool Weaved() { }

}

