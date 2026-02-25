namespace SoftMasking;

[Token(Token = "0x2000009")]
public interface IMaterialReplacer
{

	[Token(Token = "0x17000005")]
	public int order
	{
		[Token(Token = "0x6000017")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000017")]
	public int get_order() { }

	[Token(Token = "0x6000018")]
	public Material Replace(Material material) { }

}

