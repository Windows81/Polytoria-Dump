namespace Mirror;

[AddComponentMenu("Network/Network Rigidbody (Unreliable)")]
[Token(Token = "0x2000027")]
public class NetworkRigidbodyUnreliable : NetworkTransformUnreliable
{
	[FieldOffset(Offset = "0x168")]
	[Token(Token = "0x40000A9")]
	private Rigidbody rb; //Field offset: 0x168
	[FieldOffset(Offset = "0x170")]
	[Token(Token = "0x40000AA")]
	private bool wasKinematic; //Field offset: 0x170

	[Token(Token = "0x1700000B")]
	private bool clientAuthority
	{
		[Address(RVA = "0x1219510", Offset = "0x1218710", Length = "0x8")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x60000F3")]
		private get { } //Length: 8
	}

	[Address(RVA = "0x121A460", Offset = "0x1219660", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkTransformUnreliable), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x60000FB")]
	public NetworkRigidbodyUnreliable() { }

	[Address(RVA = "0x1219F90", Offset = "0x1219190", Length = "0x15B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Rigidbody), Member = "get_isKinematic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000F5")]
	protected virtual void Awake() { }

	[Address(RVA = "0x121A0F0", Offset = "0x12192F0", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isClient", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkTransformBase), Member = "get_IsClientWithAuthority", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Rigidbody), Member = "set_isKinematic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000F8")]
	private void FixedUpdate() { }

	[Address(RVA = "0x1219510", Offset = "0x1218710", Length = "0x8")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60000F3")]
	private bool get_clientAuthority() { }

	[Address(RVA = "0x121A170", Offset = "0x1219370", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Rigidbody), Member = "set_isKinematic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000F7")]
	public virtual void OnStopClient() { }

	[Address(RVA = "0x121A170", Offset = "0x1219370", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Rigidbody), Member = "set_isKinematic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000F6")]
	public virtual void OnStopServer() { }

	[Address(RVA = "0x121A1A0", Offset = "0x12193A0", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkTransformBase), Member = "OnTeleport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Rigidbody), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000F9")]
	protected virtual void OnTeleport(Vector3 destination) { }

	[Address(RVA = "0x121A230", Offset = "0x1219430", Length = "0xDC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkTransformBase), Member = "OnTeleport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Rigidbody), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Rigidbody), Member = "set_rotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000FA")]
	protected virtual void OnTeleport(Vector3 destination, Quaternion rotation) { }

	[Address(RVA = "0x121A310", Offset = "0x1219510", Length = "0x14B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkTransformBase), Member = "OnValidate", ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000F4")]
	protected virtual void OnValidate() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000FC")]
	public virtual bool Weaved() { }

}

