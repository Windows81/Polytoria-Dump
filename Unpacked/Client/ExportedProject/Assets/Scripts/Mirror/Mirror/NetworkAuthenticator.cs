namespace Mirror;

[HelpURL("https://mirror-networking.gitbook.io/docs/components/network-authenticators")]
[Token(Token = "0x2000035")]
public abstract class NetworkAuthenticator : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[Header("Event Listeners (optional)")]
	[Token(Token = "0x4000079")]
	[Tooltip("Mirror has an internal subscriber to this event. You can add your own here.")]
	public UnityEventNetworkConnection OnServerAuthenticated; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400007A")]
	[Tooltip("Mirror has an internal subscriber to this event. You can add your own here.")]
	public UnityEvent OnClientAuthenticated; //Field offset: 0x28

	[Address(RVA = "0x12520D0", Offset = "0x12512D0", Length = "0xBC")]
	[CalledBy(Type = "Polytoria.Networking.PTAuthenticator", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Authenticators.BasicAuthenticator", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Authenticators.DeviceAuthenticator", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Authenticators.TimeoutAuthenticator", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UnityEvent), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60000DA")]
	protected NetworkAuthenticator() { }

	[Address(RVA = "0x1251F60", Offset = "0x1251160", Length = "0x1D")]
	[CalledBy(Type = "Polytoria.Networking.PTAuthenticator", Member = "OnAuthResponseMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Networking.PTAuthenticator+AuthResponseMessage"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Authenticators.BasicAuthenticator", Member = "OnAuthResponseMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.Authenticators.BasicAuthenticator+AuthResponseMessage"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Authenticators.DeviceAuthenticator", Member = "OnAuthResponseMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.Authenticators.DeviceAuthenticator+AuthResponseMessage"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEvent), Member = "Invoke", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000D7")]
	protected void ClientAccept() { }

	[Address(RVA = "0x1251F80", Offset = "0x1251180", Length = "0xE9")]
	[CalledBy(Type = "Mirror.Authenticators.BasicAuthenticator", Member = "OnAuthResponseMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.Authenticators.BasicAuthenticator+AuthResponseMessage"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000D8")]
	protected void ClientReject() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000D6")]
	public override void OnClientAuthenticate() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000D1")]
	public override void OnServerAuthenticate(NetworkConnectionToClient conn) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000D4")]
	public override void OnStartClient() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000CF")]
	public override void OnStartServer() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000D5")]
	public override void OnStopClient() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000D0")]
	public override void OnStopServer() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000D9")]
	private void Reset() { }

	[Address(RVA = "0x1252070", Offset = "0x1251270", Length = "0x53")]
	[CalledBy(Type = "Polytoria.Networking.PTAuthenticator+<ValidateToken>d__5", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Mirror.Authenticators.BasicAuthenticator", Member = "OnAuthRequestMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient), "Mirror.Authenticators.BasicAuthenticator+AuthRequestMessage"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Authenticators.DeviceAuthenticator", Member = "OnAuthRequestMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient), "Mirror.Authenticators.DeviceAuthenticator+AuthRequestMessage"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.Object>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000D2")]
	protected void ServerAccept(NetworkConnectionToClient conn) { }

	[Address(RVA = "0x7FBEF0", Offset = "0x7FB0F0", Length = "0x2C")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000D3")]
	protected void ServerReject(NetworkConnectionToClient conn) { }

}

