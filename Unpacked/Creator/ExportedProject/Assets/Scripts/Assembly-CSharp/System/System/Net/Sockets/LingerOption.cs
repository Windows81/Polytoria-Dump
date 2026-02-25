namespace System.Net.Sockets;

[Token(Token = "0x20002F0")]
public class LingerOption
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000D32")]
	private bool enabled; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000D33")]
	private int lingerTime; //Field offset: 0x14

	[Token(Token = "0x17000401")]
	public bool Enabled
	{
		[Address(RVA = "0x2FE920", Offset = "0x2FDB20", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001335")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000402")]
	public int LingerTime
	{
		[Address(RVA = "0x369380", Offset = "0x368580", Length = "0x4")]
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001336")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x1718D00", Offset = "0x1717F00", Length = "0x35")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001334")]
	public LingerOption(bool enable, int seconds) { }

	[Address(RVA = "0x2FE920", Offset = "0x2FDB20", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001335")]
	public void set_Enabled(bool value) { }

	[Address(RVA = "0x369380", Offset = "0x368580", Length = "0x4")]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001336")]
	public void set_LingerTime(int value) { }

}

