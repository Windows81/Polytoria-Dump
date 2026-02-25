namespace kcp2k;

[Token(Token = "0x2000014")]
public class Kcp
{
	[CompilerGenerated]
	[Token(Token = "0x2000015")]
	private sealed class <>c
	{
		[Token(Token = "0x400009A")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400009B")]
		public static Func<Segment> <>9__61_0; //Field offset: 0x8
		[Token(Token = "0x400009C")]
		public static Action<Segment> <>9__61_1; //Field offset: 0x10

		[Address(RVA = "0x10A3AE0", Offset = "0x10A2CE0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600007A")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600007B")]
		public <>c() { }

		[Address(RVA = "0x10A3610", Offset = "0x10A2810", Length = "0x98")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600007C")]
		internal Segment <.ctor>b__61_0() { }

		[Address(RVA = "0x10A36B0", Offset = "0x10A28B0", Length = "0x4A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600007D")]
		internal void <.ctor>b__61_1(Segment segment) { }

	}

	[Token(Token = "0x400005D")]
	public const int RTO_NDL = 30; //Field offset: 0x0
	[Token(Token = "0x4000073")]
	public const int FASTACK_LIMIT = 5; //Field offset: 0x0
	[Token(Token = "0x4000072")]
	public const int PROBE_LIMIT = 120000; //Field offset: 0x0
	[Token(Token = "0x4000071")]
	public const int PROBE_INIT = 7000; //Field offset: 0x0
	[Token(Token = "0x4000070")]
	public const int THRESH_MIN = 2; //Field offset: 0x0
	[Token(Token = "0x400006F")]
	public const int THRESH_INIT = 2; //Field offset: 0x0
	[Token(Token = "0x400006E")]
	public const int DEADLINK = 20; //Field offset: 0x0
	[Token(Token = "0x400006D")]
	public const int FRG_MAX = 255; //Field offset: 0x0
	[Token(Token = "0x400006C")]
	public const int OVERHEAD = 24; //Field offset: 0x0
	[Token(Token = "0x400006A")]
	public const int ACK_FAST = 3; //Field offset: 0x0
	[Token(Token = "0x4000069")]
	public const int MTU_DEF = 1200; //Field offset: 0x0
	[Token(Token = "0x400006B")]
	public const int INTERVAL = 100; //Field offset: 0x0
	[Token(Token = "0x4000067")]
	public const int WND_SND = 32; //Field offset: 0x0
	[Token(Token = "0x400005E")]
	public const int RTO_MIN = 100; //Field offset: 0x0
	[Token(Token = "0x400005F")]
	public const int RTO_DEF = 200; //Field offset: 0x0
	[Token(Token = "0x4000068")]
	public const int WND_RCV = 128; //Field offset: 0x0
	[Token(Token = "0x4000061")]
	public const int CMD_PUSH = 81; //Field offset: 0x0
	[Token(Token = "0x4000062")]
	public const int CMD_ACK = 82; //Field offset: 0x0
	[Token(Token = "0x4000060")]
	public const int RTO_MAX = 60000; //Field offset: 0x0
	[Token(Token = "0x4000064")]
	public const int CMD_WINS = 84; //Field offset: 0x0
	[Token(Token = "0x4000065")]
	public const int ASK_SEND = 1; //Field offset: 0x0
	[Token(Token = "0x4000066")]
	public const int ASK_TELL = 2; //Field offset: 0x0
	[Token(Token = "0x4000063")]
	public const int CMD_WASK = 83; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000074")]
	internal int state; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000075")]
	private readonly uint conv; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000076")]
	internal uint mtu; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000077")]
	internal uint mss; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000078")]
	internal uint snd_una; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000079")]
	internal uint snd_nxt; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400007A")]
	internal uint rcv_nxt; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400007B")]
	internal uint ssthresh; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400007C")]
	internal int rx_rttval; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400007D")]
	internal int rx_srtt; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400007E")]
	internal int rx_rto; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400007F")]
	internal int rx_minrto; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000080")]
	internal uint snd_wnd; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000081")]
	internal uint rcv_wnd; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000082")]
	internal uint rmt_wnd; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000083")]
	internal uint cwnd; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000084")]
	internal uint probe; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000085")]
	internal uint interval; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000086")]
	internal uint ts_flush; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000087")]
	internal uint xmit; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000088")]
	internal uint nodelay; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000089")]
	internal bool updated; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400008A")]
	internal uint ts_probe; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x400008B")]
	internal uint probe_wait; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400008C")]
	internal uint dead_link; //Field offset: 0x70
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x400008D")]
	internal uint incr; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400008E")]
	internal uint current; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x400008F")]
	internal int fastresend; //Field offset: 0x7C
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000090")]
	internal int fastlimit; //Field offset: 0x80
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x4000091")]
	internal bool nocwnd; //Field offset: 0x84
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000092")]
	internal readonly Queue<Segment> snd_queue; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000093")]
	internal readonly Queue<Segment> rcv_queue; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000094")]
	internal readonly List<Segment> snd_buf; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000095")]
	internal readonly List<Segment> rcv_buf; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000096")]
	internal readonly List<AckItem> acklist; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000097")]
	internal Byte[] buffer; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000098")]
	private readonly Action<Byte[], Int32> output; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000099")]
	private readonly Pool<Segment> SegmentPool; //Field offset: 0xC0

	[Token(Token = "0x17000009")]
	public int WaitSnd
	{
		[Address(RVA = "0x10A30D0", Offset = "0x10A22D0", Length = "0x5A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000062")]
		 get { } //Length: 90
	}

	[Address(RVA = "0x10A2CA0", Offset = "0x10A1EA0", Length = "0x42D")]
	[CalledBy(Type = typeof(KcpPeer), Member = "Reset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KcpConfig)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Pool`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>", "System.Action`1<T>", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x600005F")]
	public Kcp(uint conv, Action<Byte[], Int32> output) { }

	[Address(RVA = "0x10A0040", Offset = "0x109F240", Length = "0xBD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600006C")]
	private void AckPush(uint sn, uint ts) { }

	[Address(RVA = "0x10A0100", Offset = "0x109F300", Length = "0x1C7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000075")]
	public uint Check(uint current_) { }

	[Address(RVA = "0x10A0310", Offset = "0x109F510", Length = "0x9EB")]
	[CalledBy(Type = typeof(KcpPeer), Member = "TickOutgoing", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Kcp), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Pool`1), Member = "Return", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.Object>), Member = "Dequeue", ReturnType = typeof(object))]
	[Calls(Type = typeof(Segment), Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Pool`1), Member = "Take", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 10)]
	[Token(Token = "0x6000073")]
	public void Flush() { }

	[Address(RVA = "0x10A02D0", Offset = "0x109F4D0", Length = "0x3F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000072")]
	private void FlushBuffer(int size) { }

	[Address(RVA = "0x10A30D0", Offset = "0x10A22D0", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000062")]
	public int get_WaitSnd() { }

	[Address(RVA = "0x10A0D00", Offset = "0x109FF00", Length = "0x9D1")]
	[CalledBy(Type = typeof(KcpPeer), Member = "OnRawInputReliable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Pool`1), Member = "Return", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Kcp), Member = "MoveReceiveBufferReadySegmentsToQueue", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Kcp), Member = "SegmentDelete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Segment)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Kcp), Member = "ParseFastack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Kcp), Member = "ParseUna", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Pool`1), Member = "Take", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000070")]
	public int Input(Byte[] data, int offset, int size) { }

	[Address(RVA = "0x10A16E0", Offset = "0x10A08E0", Length = "0x131")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Pool`1), Member = "Return", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600006E")]
	internal void InsertSegmentInReceiveBuffer(Segment newseg) { }

	[Address(RVA = "0x10A1820", Offset = "0x10A0A20", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000071")]
	private void MakeSpace(ref int size, int space) { }

	[Address(RVA = "0x10A1880", Offset = "0x10A0A80", Length = "0x1B7")]
	[CalledBy(Type = typeof(Kcp), Member = "ParseData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Segment)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Kcp), Member = "Input", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.Object>), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "RemoveRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600006F")]
	private void MoveReceiveBufferReadySegmentsToQueue() { }

	[Address(RVA = "0x10A1A40", Offset = "0x10A0C40", Length = "0xF2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Kcp), Member = "SegmentDelete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Segment)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000069")]
	internal void ParseAck(uint sn) { }

	[Address(RVA = "0x10A1B40", Offset = "0x10A0D40", Length = "0x18F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Kcp), Member = "MoveReceiveBufferReadySegmentsToQueue", ReturnType = typeof(void))]
	[Calls(Type = typeof(Pool`1), Member = "Return", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600006D")]
	private void ParseData(Segment newseg) { }

	[Address(RVA = "0x10A1CD0", Offset = "0x10A0ED0", Length = "0x134")]
	[CalledBy(Type = typeof(Kcp), Member = "Input", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x600006B")]
	internal void ParseFastack(uint sn, uint ts) { }

	[Address(RVA = "0x10A1E10", Offset = "0x10A1010", Length = "0x16C")]
	[CalledBy(Type = typeof(Kcp), Member = "Input", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Kcp), Member = "SegmentDelete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Segment)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "RemoveRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600006A")]
	internal void ParseUna(uint una) { }

	[Address(RVA = "0x10A1F80", Offset = "0x10A1180", Length = "0x214")]
	[CalledBy(Type = typeof(KcpPeer), Member = "ReceiveNextReliable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KcpHeaderReliable&), typeof(ArraySegment`1<Byte>&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Kcp), Member = "Receive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.Object>), Member = "Peek", ReturnType = typeof(object))]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.Object>), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.Queue`1+Enumerator<System.Object>))]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1+Enumerator<System.Object>), Member = "get_Current", ReturnType = typeof(object))]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1+Enumerator<System.Object>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000065")]
	public int PeekSize() { }

	[Address(RVA = "0x10A21A0", Offset = "0x10A13A0", Length = "0x43A")]
	[CalledBy(Type = typeof(KcpPeer), Member = "ReceiveNextReliable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KcpHeaderReliable&), typeof(ArraySegment`1<Byte>&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(List`1), Member = "RemoveRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.Object>), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Pool`1), Member = "Return", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.Object>), Member = "Dequeue", ReturnType = typeof(object))]
	[Calls(Type = typeof(Kcp), Member = "PeekSize", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000064")]
	public int Receive(Byte[] buffer, int len) { }

	[Address(RVA = "0x10A25E0", Offset = "0x10A17E0", Length = "0x56")]
	[CalledBy(Type = typeof(Kcp), Member = "ParseAck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Kcp), Member = "ParseUna", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Kcp), Member = "Input", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Pool`1), Member = "Return", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000061")]
	private void SegmentDelete(Segment seg) { }

	[Address(RVA = "0x10A2640", Offset = "0x10A1840", Length = "0x47")]
	[CalledBy(Type = typeof(Kcp), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Pool`1), Member = "Take", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000060")]
	private Segment SegmentNew() { }

	[Address(RVA = "0x10A2690", Offset = "0x10A1890", Length = "0x218")]
	[CalledBy(Type = typeof(KcpPeer), Member = "SendReliable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KcpHeaderReliable), typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Kcp), Member = "SegmentNew", ReturnType = typeof(Segment))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180003A10")]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.Object>), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000066")]
	public int Send(Byte[] buffer, int offset, int len) { }

	[Address(RVA = "0x10A28B0", Offset = "0x10A1AB0", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000077")]
	public void SetInterval(uint interval) { }

	[Address(RVA = "0x10A28E0", Offset = "0x10A1AE0", Length = "0xB4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000076")]
	public void SetMtu(uint mtu) { }

	[Address(RVA = "0x10A29A0", Offset = "0x10A1BA0", Length = "0x4D")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000078")]
	public void SetNoDelay(uint nodelay, uint interval = 100, int resend = 0, bool nocwnd = false) { }

	[Address(RVA = "0x10A29F0", Offset = "0x10A1BF0", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(uint))]
	[Token(Token = "0x6000079")]
	public void SetWindowSize(uint sendWindow, uint receiveWindow) { }

	[Address(RVA = "0x10A2A70", Offset = "0x10A1C70", Length = "0x7B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000068")]
	internal void ShrinkBuf() { }

	[Address(RVA = "0x10A2BE0", Offset = "0x10A1DE0", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Kcp), Member = "Flush", ReturnType = typeof(void))]
	[Token(Token = "0x6000074")]
	public void Update(uint currentTimeMilliSeconds) { }

	[Address(RVA = "0x10A2AF0", Offset = "0x10A1CF0", Length = "0xE5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Token(Token = "0x6000067")]
	private void UpdateAck(int rtt) { }

	[Address(RVA = "0x10A2C40", Offset = "0x10A1E40", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000063")]
	internal uint WndUnused() { }

}

