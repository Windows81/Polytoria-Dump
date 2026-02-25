namespace MoonSharp.Interpreter.Interop.BasicDescriptors;

[Token(Token = "0x2000137")]
public interface IOverloadableMemberDescriptor : IMemberDescriptor
{

	[Token(Token = "0x17000184")]
	public Type ExtensionMethodType
	{
		[Token(Token = "0x6000BAB")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000185")]
	public ParameterDescriptor[] Parameters
	{
		[Token(Token = "0x6000BAC")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000188")]
	public string SortDiscriminant
	{
		[Token(Token = "0x6000BAF")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000186")]
	public Type VarArgsArrayType
	{
		[Token(Token = "0x6000BAD")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000187")]
	public Type VarArgsElementType
	{
		[Token(Token = "0x6000BAE")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000BAA")]
	public DynValue Execute(Script script, object obj, ScriptExecutionContext context, CallbackArguments args) { }

	[Token(Token = "0x6000BAB")]
	public Type get_ExtensionMethodType() { }

	[Token(Token = "0x6000BAC")]
	public ParameterDescriptor[] get_Parameters() { }

	[Token(Token = "0x6000BAF")]
	public string get_SortDiscriminant() { }

	[Token(Token = "0x6000BAD")]
	public Type get_VarArgsArrayType() { }

	[Token(Token = "0x6000BAE")]
	public Type get_VarArgsElementType() { }

}

