namespace System.Net.NetworkInformation;

[Token(Token = "0x20002D2")]
internal struct Win32_IP_ADDR_STRING
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000C6B")]
	public IntPtr Next; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000C6C")]
	public string IpAddress; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000C6D")]
	public string IpMask; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000C6E")]
	public uint Context; //Field offset: 0x18

}

