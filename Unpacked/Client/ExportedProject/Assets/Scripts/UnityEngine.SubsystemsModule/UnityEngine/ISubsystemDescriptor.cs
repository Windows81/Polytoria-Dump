namespace UnityEngine;

[Token(Token = "0x2000008")]
public interface ISubsystemDescriptor
{

	[Token(Token = "0x17000002")]
	public string id
	{
		[Token(Token = "0x600000B")]
		 get { } //Length: 0
	}

	[Token(Token = "0x600000B")]
	public string get_id() { }

}

