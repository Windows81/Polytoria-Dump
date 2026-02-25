namespace Mirror;

[Extension]
[Token(Token = "0x200003D")]
public static class PredictedSyncDataReadWrite
{

	[Address(RVA = "0x1240AA0", Offset = "0x123FCA0", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkReader), Member = "ReadBlittable", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PredictedSyncData)}, ReturnType = typeof(PredictedSyncData))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x600020D")]
	public static PredictedSyncData ReadPredictedSyncData(NetworkReader reader) { }

	[Address(RVA = "0x1240B20", Offset = "0x123FD20", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkWriter), Member = "WriteBlittable", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PredictedSyncData)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PredictedSyncData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x600020C")]
	public static void WritePredictedSyncData(NetworkWriter writer, PredictedSyncData data) { }

}

