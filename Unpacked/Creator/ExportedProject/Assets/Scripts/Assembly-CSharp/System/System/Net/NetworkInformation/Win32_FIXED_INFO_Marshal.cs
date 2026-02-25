namespace System.Net.NetworkInformation;

[Token(Token = "0x20002CE")]
internal struct Win32_FIXED_INFO_Marshal
{
	[CompilerGenerated]
	[Token(Token = "0x20002D0")]
	[UnsafeValueType]
	internal struct <DomainName>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C69")]
		public byte FixedElementField; //Field offset: 0x0

	}

	[CompilerGenerated]
	[Token(Token = "0x20002CF")]
	[UnsafeValueType]
	internal struct <HostName>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C68")]
		public byte FixedElementField; //Field offset: 0x0

	}

	[CompilerGenerated]
	[Token(Token = "0x20002D1")]
	[UnsafeValueType]
	internal struct <ScopeId>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C6A")]
		public byte FixedElementField; //Field offset: 0x0

	}

	[FieldOffset(Offset = "0x0")]
	[FixedBuffer(typeof(byte), 132)]
	[Token(Token = "0x4000C5F")]
	public <HostName>e__FixedBuffer HostName; //Field offset: 0x0
	[FieldOffset(Offset = "0x84")]
	[FixedBuffer(typeof(byte), 132)]
	[Token(Token = "0x4000C60")]
	public <DomainName>e__FixedBuffer DomainName; //Field offset: 0x84
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4000C61")]
	public IntPtr CurrentDnsServer; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4000C62")]
	public Win32_IP_ADDR_STRING DnsServerList; //Field offset: 0x110
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4000C63")]
	public NetBiosNodeType NodeType; //Field offset: 0x130
	[FieldOffset(Offset = "0x134")]
	[FixedBuffer(typeof(byte), 260)]
	[Token(Token = "0x4000C64")]
	public <ScopeId>e__FixedBuffer ScopeId; //Field offset: 0x134
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000C65")]
	public uint EnableRouting; //Field offset: 0x238
	[FieldOffset(Offset = "0x23C")]
	[Token(Token = "0x4000C66")]
	public uint EnableProxy; //Field offset: 0x23C
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000C67")]
	public uint EnableDns; //Field offset: 0x240

}

