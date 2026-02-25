namespace UnityEngine.UIElements;

[Token(Token = "0x200008F")]
public interface IBindable
{

	[Token(Token = "0x170000DC")]
	public IBinding binding
	{
		[Token(Token = "0x6000578")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000DD")]
	public string bindingPath
	{
		[Token(Token = "0x6000579")]
		 set { } //Length: 0
	}

	[Token(Token = "0x6000578")]
	public IBinding get_binding() { }

	[Token(Token = "0x6000579")]
	public void set_bindingPath(string value) { }

}

