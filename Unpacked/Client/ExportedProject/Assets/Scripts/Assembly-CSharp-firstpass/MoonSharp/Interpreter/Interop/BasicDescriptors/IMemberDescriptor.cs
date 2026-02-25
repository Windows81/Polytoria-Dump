namespace MoonSharp.Interpreter.Interop.BasicDescriptors;

[Token(Token = "0x2000133")]
public interface IMemberDescriptor
{

	[Token(Token = "0x17000181")]
	public bool IsStatic
	{
		[Token(Token = "0x6000B9B")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000183")]
	public MemberDescriptorAccess MemberAccess
	{
		[Token(Token = "0x6000B9D")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000182")]
	public string Name
	{
		[Token(Token = "0x6000B9C")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000B9B")]
	public bool get_IsStatic() { }

	[Token(Token = "0x6000B9D")]
	public MemberDescriptorAccess get_MemberAccess() { }

	[Token(Token = "0x6000B9C")]
	public string get_Name() { }

	[Token(Token = "0x6000B9E")]
	public DynValue GetValue(Script script, object obj) { }

	[Token(Token = "0x6000B9F")]
	public void SetValue(Script script, object obj, DynValue value) { }

}

