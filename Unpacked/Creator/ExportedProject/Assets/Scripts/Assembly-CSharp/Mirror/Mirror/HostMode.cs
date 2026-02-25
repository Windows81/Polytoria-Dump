namespace Mirror;

[Token(Token = "0x2000018")]
public static class HostMode
{

	[Address(RVA = "0x124FA70", Offset = "0x124EC70", Length = "0x137")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkServer), Member = "OnConnected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x600008F")]
	public static void InvokeOnConnected() { }

	[Address(RVA = "0x124FBB0", Offset = "0x124EDB0", Length = "0xED")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Utils), Member = "CreateLocalConnections", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalConnectionToClient&), typeof(LocalConnectionToServer&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(NetworkServer), Member = "SetLocalConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalConnectionToClient)}, ReturnType = typeof(void))]
	[Token(Token = "0x600008E")]
	internal static void SetupConnections() { }

}

