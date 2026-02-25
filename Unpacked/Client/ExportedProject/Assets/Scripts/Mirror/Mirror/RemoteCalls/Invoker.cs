namespace Mirror.RemoteCalls;

[Token(Token = "0x20000A5")]
internal class Invoker
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000221")]
	public Type componentType; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000222")]
	public RemoteCallType callType; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000223")]
	public RemoteCallDelegate function; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000224")]
	public bool cmdRequiresAuthority; //Field offset: 0x28

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600051E")]
	public Invoker() { }

	[Address(RVA = "0x128E9A0", Offset = "0x128DBA0", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Delegate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600051D")]
	public bool AreEqual(Type componentType, RemoteCallType remoteCallType, RemoteCallDelegate invokeFunction) { }

}

