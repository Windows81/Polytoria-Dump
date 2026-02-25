namespace System.Net.NetworkInformation;

[Token(Token = "0x20002CD")]
internal struct Win32_FIXED_INFO
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000C56")]
	public string HostName; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000C57")]
	public string DomainName; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000C58")]
	public IntPtr CurrentDnsServer; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000C59")]
	public Win32_IP_ADDR_STRING DnsServerList; //Field offset: 0x18
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000C5A")]
	public NetBiosNodeType NodeType; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000C5B")]
	public string ScopeId; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000C5C")]
	public uint EnableRouting; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000C5D")]
	public uint EnableProxy; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000C5E")]
	public uint EnableDns; //Field offset: 0x50

}

