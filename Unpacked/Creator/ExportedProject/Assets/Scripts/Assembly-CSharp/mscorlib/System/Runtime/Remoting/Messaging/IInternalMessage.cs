namespace System.Runtime.Remoting.Messaging;

[Token(Token = "0x20003A7")]
internal interface IInternalMessage
{

	[Token(Token = "0x1700034A")]
	public Identity TargetIdentity
	{
		[Token(Token = "0x6001C13")]
		 get { } //Length: 0
		[Token(Token = "0x6001C14")]
		 set { } //Length: 0
	}

	[Token(Token = "0x1700034B")]
	public string Uri
	{
		[Token(Token = "0x6001C15")]
		 get { } //Length: 0
		[Token(Token = "0x6001C16")]
		 set { } //Length: 0
	}

	[Token(Token = "0x6001C13")]
	public Identity get_TargetIdentity() { }

	[Token(Token = "0x6001C15")]
	public string get_Uri() { }

	[Token(Token = "0x6001C14")]
	public void set_TargetIdentity(Identity value) { }

	[Token(Token = "0x6001C16")]
	public void set_Uri(string value) { }

}

