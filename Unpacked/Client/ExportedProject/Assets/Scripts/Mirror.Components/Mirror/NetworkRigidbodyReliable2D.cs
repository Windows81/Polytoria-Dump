namespace Mirror;

[AddComponentMenu("Network/Network Rigidbody 2D (Reliable)")]
[Token(Token = "0x2000026")]
public class NetworkRigidbodyReliable2D : NetworkTransformReliable
{
	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x40000A7")]
	private Rigidbody2D rb; //Field offset: 0x1C0
	[FieldOffset(Offset = "0x1C8")]
	[Token(Token = "0x40000A8")]
	private bool wasKinematic; //Field offset: 0x1C8

	[Token(Token = "0x1700000A")]
	private bool clientAuthority
	{
		[Address(RVA = "0x1219510", Offset = "0x1218710", Length = "0x8")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x60000E9")]
		private get { } //Length: 8
	}

	[Address(RVA = "0x1219500", Offset = "0x1218700", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkTransformReliable), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60000F1")]
	public NetworkRigidbodyReliable2D() { }

	[Address(RVA = "0x1218FB0", Offset = "0x12181B0", Length = "0x15D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Rigidbody2D), Member = "get_bodyType", ReturnType = typeof(RigidbodyType2D))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000EB")]
	protected virtual void Awake() { }

	[Address(RVA = "0x1219110", Offset = "0x1218310", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isClient", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkTransformBase), Member = "get_IsClientWithAuthority", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Rigidbody2D), Member = "set_bodyType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RigidbodyType2D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000EE")]
	private void FixedUpdate() { }

	[Address(RVA = "0x1219510", Offset = "0x1218710", Length = "0x8")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60000E9")]
	private bool get_clientAuthority() { }

	[Address(RVA = "0x12191A0", Offset = "0x12183A0", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Rigidbody2D), Member = "set_bodyType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RigidbodyType2D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60000ED")]
	public virtual void OnStopClient() { }

	[Address(RVA = "0x12191A0", Offset = "0x12183A0", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Rigidbody2D), Member = "set_bodyType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RigidbodyType2D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60000EC")]
	public virtual void OnStopServer() { }

	[Address(RVA = "0x12191D0", Offset = "0x12183D0", Length = "0x83")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkTransformBase), Member = "OnTeleport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Rigidbody2D), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000EF")]
	protected virtual void OnTeleport(Vector3 destination) { }

	[Address(RVA = "0x1219260", Offset = "0x1218460", Length = "0x14D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkTransformBase), Member = "OnTeleport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Rigidbody2D), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Quaternion), Member = "Internal_ToEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Quaternion), Member = "Internal_MakePositive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Rigidbody2D), Member = "set_rotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000F0")]
	protected virtual void OnTeleport(Vector3 destination, Quaternion rotation) { }

	[Address(RVA = "0x12193B0", Offset = "0x12185B0", Length = "0x14B")]
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
	[Token(Token = "0x60000EA")]
	protected virtual void OnValidate() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000F2")]
	public virtual bool Weaved() { }

}

