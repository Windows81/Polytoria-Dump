namespace MoonSharp.Interpreter;

[Token(Token = "0x200004B")]
public interface IScriptPrivateResource
{

	[Token(Token = "0x170000A5")]
	public Script OwnerScript
	{
		[Token(Token = "0x6000526")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000526")]
	public Script get_OwnerScript() { }

}

