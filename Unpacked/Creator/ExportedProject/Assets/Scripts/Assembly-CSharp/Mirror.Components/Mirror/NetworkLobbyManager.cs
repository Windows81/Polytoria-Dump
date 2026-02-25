namespace Mirror;

[AddComponentMenu("Network/Network Lobby Manager")]
[HelpURL("https://mirror-networking.gitbook.io/docs/components/network-room-manager")]
[Obsolete("Use / inherit from NetworkRoomManager instead")]
[Token(Token = "0x2000022")]
public class NetworkLobbyManager : NetworkRoomManager
{

	[Address(RVA = "0x1218870", Offset = "0x1217A70", Length = "0xFB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<Mirror.NetworkRoomManager+PendingPlayer>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkManager), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60000DA")]
	public NetworkLobbyManager() { }

}

