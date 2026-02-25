namespace Mirror;

[AddComponentMenu("Network/Network Diagnostics Debugger")]
[Token(Token = "0x2000021")]
public class NetworkDiagnosticsDebugger : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400009F")]
	public bool logInMessages; //Field offset: 0x20
	[FieldOffset(Offset = "0x21")]
	[Token(Token = "0x40000A0")]
	public bool logOutMessages; //Field offset: 0x21

	[Address(RVA = "0x1218860", Offset = "0x1217A60", Length = "0xD")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000D9")]
	public NetworkDiagnosticsDebugger() { }

	[Address(RVA = "0x12185E0", Offset = "0x12177E0", Length = "0xA7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NetworkDiagnostics), Member = "remove_InMessageEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<Mirror.NetworkDiagnostics+MessageInfo>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkDiagnostics), Member = "remove_OutMessageEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<Mirror.NetworkDiagnostics+MessageInfo>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60000D8")]
	private void OnDisable() { }

	[Address(RVA = "0x1218690", Offset = "0x1217890", Length = "0xA7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NetworkDiagnostics), Member = "add_InMessageEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<Mirror.NetworkDiagnostics+MessageInfo>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkDiagnostics), Member = "add_OutMessageEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<Mirror.NetworkDiagnostics+MessageInfo>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60000D7")]
	private void OnEnable() { }

	[Address(RVA = "0x1218740", Offset = "0x1217940", Length = "0x8F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Token(Token = "0x60000D5")]
	private void OnInMessage(MessageInfo msgInfo) { }

	[Address(RVA = "0x12187D0", Offset = "0x12179D0", Length = "0x8F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Token(Token = "0x60000D6")]
	private void OnOutMessage(MessageInfo msgInfo) { }

}

