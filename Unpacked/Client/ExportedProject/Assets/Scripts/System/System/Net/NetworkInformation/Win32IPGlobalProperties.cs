namespace System.Net.NetworkInformation;

[Token(Token = "0x20002CA")]
internal class Win32IPGlobalProperties : IPGlobalProperties
{

	[Token(Token = "0x170003D4")]
	public virtual string DomainName
	{
		[Address(RVA = "0x1715E40", Offset = "0x1715040", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Win32NetworkInterface), Member = "get_FixedInfo", ReturnType = typeof(Win32_FIXED_INFO))]
		[Token(Token = "0x6001206")]
		 get { } //Length: 31
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001207")]
	public Win32IPGlobalProperties() { }

	[Address(RVA = "0x1715E40", Offset = "0x1715040", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Win32NetworkInterface), Member = "get_FixedInfo", ReturnType = typeof(Win32_FIXED_INFO))]
	[Token(Token = "0x6001206")]
	public virtual string get_DomainName() { }

}

