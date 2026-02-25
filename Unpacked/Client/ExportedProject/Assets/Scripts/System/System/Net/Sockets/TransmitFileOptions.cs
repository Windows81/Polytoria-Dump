namespace System.Net.Sockets;

[Flags]
[Token(Token = "0x20002FE")]
public enum TransmitFileOptions
{
	UseDefaultWorkerThread = 0,
	Disconnect = 1,
	ReuseSocket = 2,
	WriteBehind = 4,
	UseSystemThread = 16,
	UseKernelApc = 32,
}

