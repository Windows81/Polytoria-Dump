namespace System.Xml;

[Token(Token = "0x20000BD")]
internal static class BinaryCompatibility
{

	[Token(Token = "0x170001D6")]
	public static bool TargetsAtLeast_Desktop_V4_5_2
	{
		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000837")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000837")]
	public static bool get_TargetsAtLeast_Desktop_V4_5_2() { }

}

