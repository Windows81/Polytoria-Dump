namespace System.Collections;

[Token(Token = "0x2000592")]
public interface ICollection : IEnumerable
{

	[Token(Token = "0x1700061E")]
	public int Count
	{
		[Token(Token = "0x600287F")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700061F")]
	public object SyncRoot
	{
		[Token(Token = "0x6002880")]
		 get { } //Length: 0
	}

	[Token(Token = "0x600287E")]
	public void CopyTo(Array array, int index) { }

	[Token(Token = "0x600287F")]
	public int get_Count() { }

	[Token(Token = "0x6002880")]
	public object get_SyncRoot() { }

}

