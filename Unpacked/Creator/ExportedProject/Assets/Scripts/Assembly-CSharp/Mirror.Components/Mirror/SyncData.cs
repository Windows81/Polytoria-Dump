namespace Mirror;

[Token(Token = "0x2000030")]
public struct SyncData
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000F4")]
	public Changed changedDataByte; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40000F5")]
	public Vector3 position; //Field offset: 0x4
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000F6")]
	public Quaternion quatRotation; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000F7")]
	public Vector3 vecRotation; //Field offset: 0x20
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40000F8")]
	public Vector3 scale; //Field offset: 0x2C

	[Address(RVA = "0x1246160", Offset = "0x1245360", Length = "0xB2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "Internal_ToEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Quaternion), Member = "Internal_MakePositive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x600019E")]
	public SyncData(Changed _dataChangedByte, Vector3 _position, Quaternion _rotation, Vector3 _scale) { }

	[Address(RVA = "0x1246000", Offset = "0x1245200", Length = "0xBC")]
	[CalledBy(Type = typeof(NetworkTransformUnreliable), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkTransformUnreliable), Member = "UpdateServerBroadcast", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkTransformUnreliable), Member = "UpdateClientBroadcast", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Quaternion), Member = "Internal_ToEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Quaternion), Member = "Internal_MakePositive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x600019F")]
	public SyncData(Changed _dataChangedByte, TransformSnapshot _snapshot) { }

	[Address(RVA = "0x12460C0", Offset = "0x12452C0", Length = "0x99")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "Internal_FromEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Token(Token = "0x60001A0")]
	public SyncData(Changed _dataChangedByte, Vector3 _position, Vector3 _vecRotation, Vector3 _scale) { }

}

