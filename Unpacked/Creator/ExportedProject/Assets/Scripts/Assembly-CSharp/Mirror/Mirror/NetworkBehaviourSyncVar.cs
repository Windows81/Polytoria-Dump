namespace Mirror;

[Token(Token = "0x200003B")]
public struct NetworkBehaviourSyncVar : IEquatable<NetworkBehaviourSyncVar>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000096")]
	public uint netId; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000097")]
	public byte componentIndex; //Field offset: 0x4

	[Address(RVA = "0x1254E00", Offset = "0x1254000", Length = "0xC")]
	[CalledBy(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarSetter_NetworkBehaviour", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T&", typeof(ulong), "System.Action`2<T, T>", typeof(NetworkBehaviourSyncVar&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkBehaviour), Member = "SetSyncVarNetworkBehaviour", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T&", typeof(ulong), typeof(NetworkBehaviourSyncVar&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkReaderExtensions), Member = "ReadNetworkBehaviourSyncVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(NetworkBehaviourSyncVar))]
	[CallerCount(Count = 3)]
	[Token(Token = "0x6000147")]
	public NetworkBehaviourSyncVar(uint netId, int componentIndex) { }

	[Address(RVA = "0x1254D40", Offset = "0x1253F40", Length = "0x12")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000148")]
	public override bool Equals(NetworkBehaviourSyncVar other) { }

	[Address(RVA = "0x1254D60", Offset = "0x1253F60", Length = "0x12")]
	[CalledBy(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarSetter_NetworkBehaviour", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T&", typeof(ulong), "System.Action`2<T, T>", typeof(NetworkBehaviourSyncVar&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkBehaviour), Member = "SyncVarNetworkBehaviourEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(NetworkBehaviourSyncVar)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000149")]
	public bool Equals(uint netId, int componentIndex) { }

	[Address(RVA = "0x1254D80", Offset = "0x1253F80", Length = "0x7C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Token(Token = "0x600014A")]
	public virtual string ToString() { }

}

