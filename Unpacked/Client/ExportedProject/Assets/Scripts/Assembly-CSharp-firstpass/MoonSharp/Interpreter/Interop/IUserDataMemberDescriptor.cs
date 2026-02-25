namespace MoonSharp.Interpreter.Interop;

[Token(Token = "0x20000D3")]
public interface IUserDataMemberDescriptor
{

	[Token(Token = "0x17000122")]
	public bool IsStatic
	{
		[Token(Token = "0x60008B1")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000121")]
	public UserDataMemberType MemberType
	{
		[Token(Token = "0x60008AF")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700011F")]
	public string Name
	{
		[Token(Token = "0x60008AB")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000120")]
	public Type Type
	{
		[Token(Token = "0x60008AC")]
		 get { } //Length: 0
	}

	[Token(Token = "0x60008B1")]
	public bool get_IsStatic() { }

	[Token(Token = "0x60008AF")]
	public UserDataMemberType get_MemberType() { }

	[Token(Token = "0x60008AB")]
	public string get_Name() { }

	[Token(Token = "0x60008AC")]
	public Type get_Type() { }

	[Token(Token = "0x60008AD")]
	public DynValue GetValue(Script script, object obj) { }

	[Token(Token = "0x60008B0")]
	public void Optimize() { }

	[Token(Token = "0x60008AE")]
	public bool SetValue(Script script, object obj, DynValue value) { }

}

