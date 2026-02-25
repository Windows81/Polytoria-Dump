namespace Mirror.SimpleWeb;

[Token(Token = "0x2000025")]
public struct TcpConfig
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000073")]
	public readonly bool noDelay; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000074")]
	public readonly int sendTimeout; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000075")]
	public readonly int receiveTimeout; //Field offset: 0x8

	[Address(RVA = "0x155DDC0", Offset = "0x155CFC0", Length = "0xB")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000097")]
	public TcpConfig(bool noDelay, int sendTimeout, int receiveTimeout) { }

	[Address(RVA = "0x155DD70", Offset = "0x155CF70", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TcpClient), Member = "set_SendTimeout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TcpClient), Member = "set_ReceiveTimeout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TcpClient), Member = "set_NoDelay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000098")]
	public void ApplyTo(TcpClient client) { }

}

