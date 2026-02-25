namespace Mirror;

[Extension]
[Token(Token = "0x2000032")]
public static class SyncDataReaderWriter
{

	[Address(RVA = "0x12459D0", Offset = "0x1244BD0", Length = "0x2FC")]
	[CalledBy(Type = typeof(NetworkTransformUnreliable), Member = "InvokeUserCode_CmdClientToServerSync__SyncData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkBehaviour), typeof(NetworkReader), typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkTransformUnreliable), Member = "InvokeUserCode_RpcServerToClientSync__SyncData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkBehaviour), typeof(NetworkReader), typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NetworkReader), Member = "ReadByte", ReturnType = typeof(byte))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(Compression), Member = "DecompressQuaternion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadVector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Quaternion), Member = "Internal_ToEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Quaternion), Member = "Internal_MakePositive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Quaternion), Member = "Internal_FromEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x60001A2")]
	public static SyncData ReadSyncData(NetworkReader reader) { }

	[Address(RVA = "0x1245CD0", Offset = "0x1244ED0", Length = "0x326")]
	[CalledBy(Type = typeof(NetworkTransformUnreliable), Member = "UpdateClientBroadcast", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkTransformUnreliable), Member = "CmdClientToServerSync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SyncData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkTransformUnreliable), Member = "RpcServerToClientSync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SyncData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NetworkWriter), Member = "WriteByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Quaternion), Member = "Internal_ToEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Quaternion), Member = "Internal_MakePositive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Compression), Member = "CompressQuaternion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x60001A1")]
	public static void WriteSyncData(NetworkWriter writer, SyncData syncData) { }

}

