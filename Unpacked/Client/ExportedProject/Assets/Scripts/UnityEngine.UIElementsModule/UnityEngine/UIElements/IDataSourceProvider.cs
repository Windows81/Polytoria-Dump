namespace UnityEngine.UIElements;

[Token(Token = "0x2000042")]
public interface IDataSourceProvider
{

	[Token(Token = "0x1700003F")]
	public object dataSource
	{
		[Token(Token = "0x60001FF")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000040")]
	public PropertyPath dataSourcePath
	{
		[Token(Token = "0x6000200")]
		 get { } //Length: 0
	}

	[Token(Token = "0x60001FF")]
	public object get_dataSource() { }

	[Token(Token = "0x6000200")]
	public PropertyPath get_dataSourcePath() { }

}

