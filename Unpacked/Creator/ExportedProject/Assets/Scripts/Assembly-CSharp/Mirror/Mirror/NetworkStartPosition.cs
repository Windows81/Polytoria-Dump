namespace Mirror;

[AddComponentMenu("Network/Network Start Position")]
[DisallowMultipleComponent]
[HelpURL("https://mirror-networking.gitbook.io/docs/components/network-start-position")]
[Token(Token = "0x2000069")]
public class NetworkStartPosition : MonoBehaviour
{

	[Address(RVA = "0x2C7050", Offset = "0x2C6250", Length = "0x7")]
	[CallerCount(Count = 60)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600035D")]
	public NetworkStartPosition() { }

	[Address(RVA = "0x129D640", Offset = "0x129C840", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkManager), Member = "RegisterStartPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(void))]
	[Token(Token = "0x600035B")]
	public void Awake() { }

	[Address(RVA = "0x129D6A0", Offset = "0x129C8A0", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkManager), Member = "UnRegisterStartPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(void))]
	[Token(Token = "0x600035C")]
	public void OnDestroy() { }

}

