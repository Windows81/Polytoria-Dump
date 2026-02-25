namespace SoftMasking;

[Token(Token = "0x2000005")]
public interface ISoftMask
{

	[Token(Token = "0x17000001")]
	public bool isAlive
	{
		[Token(Token = "0x6000005")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000002")]
	public bool isMaskingEnabled
	{
		[Token(Token = "0x6000006")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000005")]
	public bool get_isAlive() { }

	[Token(Token = "0x6000006")]
	public bool get_isMaskingEnabled() { }

	[Token(Token = "0x6000007")]
	public Material GetReplacement(Material original) { }

	[Token(Token = "0x6000008")]
	public void ReleaseReplacement(Material replacement) { }

	[Token(Token = "0x6000009")]
	public void UpdateTransformChildren(Transform transform) { }

}

