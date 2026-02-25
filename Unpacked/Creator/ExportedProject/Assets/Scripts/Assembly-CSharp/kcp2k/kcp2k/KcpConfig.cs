namespace kcp2k;

[Token(Token = "0x2000009")]
public class KcpConfig
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400001D")]
	public bool DualMode; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400001E")]
	public int RecvBufferSize; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400001F")]
	public int SendBufferSize; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000020")]
	public int Mtu; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000021")]
	public bool NoDelay; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000022")]
	public uint Interval; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000023")]
	public int FastResend; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000024")]
	public bool CongestionWindow; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000025")]
	public uint SendWindowSize; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000026")]
	public uint ReceiveWindowSize; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000027")]
	public int Timeout; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000028")]
	public uint MaxRetransmits; //Field offset: 0x3C

	[Address(RVA = "0x109BA10", Offset = "0x109AC10", Length = "0x8F")]
	[CalledBy(Type = "kcp2k.KcpTransport", Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = "kcp2k.ThreadedKcpTransport", Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = "Edgegap.EdgegapKcpTransport", Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600001B")]
	public KcpConfig(bool DualMode = true, int RecvBufferSize = 7340032, int SendBufferSize = 7340032, int Mtu = 1200, bool NoDelay = true, uint Interval = 10, int FastResend = 0, bool CongestionWindow = false, uint SendWindowSize = 32, uint ReceiveWindowSize = 128, int Timeout = 10000, uint MaxRetransmits = 20) { }

}

