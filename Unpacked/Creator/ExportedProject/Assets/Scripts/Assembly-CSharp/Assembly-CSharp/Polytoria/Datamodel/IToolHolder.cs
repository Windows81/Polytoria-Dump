namespace Polytoria.Datamodel;

[Token(Token = "0x200032D")]
public interface IToolHolder
{

	[Token(Token = "0x1700097F")]
	public Transform ToolAttachmentPoint
	{
		[Token(Token = "0x6001E84")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6001E84")]
	public Transform get_ToolAttachmentPoint() { }

	[Token(Token = "0x6001E85")]
	public void PlayAnim(string animationName) { }

	[Token(Token = "0x6001E86")]
	public void PlayAnimTargetRpc(string animationName) { }

}

