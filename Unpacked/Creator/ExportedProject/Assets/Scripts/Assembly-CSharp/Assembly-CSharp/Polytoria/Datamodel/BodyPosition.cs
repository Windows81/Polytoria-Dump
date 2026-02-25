namespace Polytoria.Datamodel;

[Instantiatable]
[Token(Token = "0x200030F")]
public class BodyPosition : Instance
{
	[FieldOffset(Offset = "0xF8")]
	[SyncVar]
	[Token(Token = "0x4000BB5")]
	private Vector3 tPos; //Field offset: 0xF8
	[FieldOffset(Offset = "0x104")]
	[SyncVar]
	[Token(Token = "0x4000BB6")]
	private float force; //Field offset: 0x104
	[FieldOffset(Offset = "0x108")]
	[SyncVar]
	[Token(Token = "0x4000BB7")]
	private float accDist; //Field offset: 0x108

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x170008E4")]
	public float AcceptanceDistance
	{
		[Address(RVA = "0x402150", Offset = "0x401350", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C2D")]
		 get { } //Length: 9
		[Address(RVA = "0x402190", Offset = "0x401390", Length = "0x8")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(BodyPosition), Member = "set_Networkforce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C2E")]
		 set { } //Length: 8
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x170008E3")]
	public float Force
	{
		[Address(RVA = "0x402150", Offset = "0x401350", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C2B")]
		 get { } //Length: 9
		[Address(RVA = "0x402190", Offset = "0x401390", Length = "0x8")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(BodyPosition), Member = "set_Networkforce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C2C")]
		 set { } //Length: 8
	}

	[Token(Token = "0x170008E7")]
	public float NetworkaccDist
	{
		[Address(RVA = "0x402160", Offset = "0x401360", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C38")]
		 get { } //Length: 9
		[Address(RVA = "0x4021A0", Offset = "0x4013A0", Length = "0xB4")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&), typeof(ulong)}, ReturnType = typeof(void))]
		[Token(Token = "0x6001C39")]
		 set { } //Length: 180
	}

	[Token(Token = "0x170008E6")]
	public float Networkforce
	{
		[Address(RVA = "0x402150", Offset = "0x401350", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C36")]
		 get { } //Length: 9
		[Address(RVA = "0x402260", Offset = "0x401460", Length = "0xB4")]
		[CalledBy(Type = typeof(BodyPosition), Member = "set_Force", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BodyPosition), Member = "set_AcceptanceDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BodyPosition), Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BodyPosition), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&), typeof(ulong)}, ReturnType = typeof(void))]
		[Token(Token = "0x6001C37")]
		 set { } //Length: 180
	}

	[Token(Token = "0x170008E5")]
	public Vector3 NetworktPos
	{
		[Address(RVA = "0x402170", Offset = "0x401370", Length = "0x19")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C34")]
		 get { } //Length: 25
		[Address(RVA = "0x402320", Offset = "0x401520", Length = "0xDA")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3&), typeof(ulong)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C35")]
		 set { } //Length: 218
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x170008E2")]
	public Vector3 TargetPosition
	{
		[Address(RVA = "0x402170", Offset = "0x401370", Length = "0x19")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C29")]
		 get { } //Length: 25
		[Address(RVA = "0x402320", Offset = "0x401520", Length = "0xDA")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3&), typeof(ulong)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C2A")]
		 set { } //Length: 218
	}

	[Address(RVA = "0x402100", Offset = "0x401300", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Instance), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6001C32")]
	public BodyPosition() { }

	[Address(RVA = "0x4019D0", Offset = "0x400BD0", Length = "0xD0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Instance), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BodyPosition), Member = "set_Networkforce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001C31")]
	protected virtual void CopyProperties(Instance clone) { }

	[Address(RVA = "0x401AB0", Offset = "0x400CB0", Length = "0x198")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Instance), Member = "DeserializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadVector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3&), typeof(System.Action`2<UnityEngine.Vector3, UnityEngine.Vector3>), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(System.Action`2<System.Single, System.Single>), typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001C3B")]
	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	[Address(RVA = "0x401C50", Offset = "0x400E50", Length = "0x34E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Instance), Member = "get_Parent", ReturnType = typeof(Instance))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AEB0")]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Rigidbody), Member = "AddForce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(ForceMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001C30")]
	private void FixedUpdate() { }

	[Address(RVA = "0x402150", Offset = "0x401350", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001C2D")]
	public float get_AcceptanceDistance() { }

	[Address(RVA = "0x402150", Offset = "0x401350", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001C2B")]
	public float get_Force() { }

	[Address(RVA = "0x402160", Offset = "0x401360", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001C38")]
	public float get_NetworkaccDist() { }

	[Address(RVA = "0x402150", Offset = "0x401350", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001C36")]
	public float get_Networkforce() { }

	[Address(RVA = "0x402170", Offset = "0x401370", Length = "0x19")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001C34")]
	public Vector3 get_NetworktPos() { }

	[Address(RVA = "0x402170", Offset = "0x401370", Length = "0x19")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001C29")]
	public Vector3 get_TargetPosition() { }

	[Address(RVA = "0x401FA0", Offset = "0x4011A0", Length = "0xDB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Instance), Member = "SerializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVarULong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(float)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001C3A")]
	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	[Address(RVA = "0x402190", Offset = "0x401390", Length = "0x8")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BodyPosition), Member = "set_Networkforce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001C2E")]
	public void set_AcceptanceDistance(float value) { }

	[Address(RVA = "0x402190", Offset = "0x401390", Length = "0x8")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BodyPosition), Member = "set_Networkforce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001C2C")]
	public void set_Force(float value) { }

	[Address(RVA = "0x4021A0", Offset = "0x4013A0", Length = "0xB4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&), typeof(ulong)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001C39")]
	public void set_NetworkaccDist(in float value) { }

	[Address(RVA = "0x402260", Offset = "0x401460", Length = "0xB4")]
	[CalledBy(Type = typeof(BodyPosition), Member = "set_Force", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BodyPosition), Member = "set_AcceptanceDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BodyPosition), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BodyPosition), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&), typeof(ulong)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001C37")]
	public void set_Networkforce(in float value) { }

	[Address(RVA = "0x402320", Offset = "0x401520", Length = "0xDA")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3&), typeof(ulong)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001C35")]
	public void set_NetworktPos(in Vector3 value) { }

	[Address(RVA = "0x402320", Offset = "0x401520", Length = "0xDA")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3&), typeof(ulong)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001C2A")]
	public void set_TargetPosition(Vector3 value) { }

	[Address(RVA = "0x402080", Offset = "0x401280", Length = "0x77")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BodyPosition), Member = "set_Networkforce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001C2F")]
	protected virtual void Start() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001C33")]
	public virtual bool Weaved() { }

}

