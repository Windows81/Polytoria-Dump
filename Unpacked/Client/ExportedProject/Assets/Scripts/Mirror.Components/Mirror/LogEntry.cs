namespace Mirror;

[Token(Token = "0x2000004")]
internal struct LogEntry
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000006")]
	public string message; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000007")]
	public LogType type; //Field offset: 0x8

	[Address(RVA = "0xC89AC0", Offset = "0xC88CC0", Length = "0x26")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000003")]
	public LogEntry(string message, LogType type) { }

}

