namespace MoonSharp.Interpreter.Interop.RegistrationPolicies;

[Token(Token = "0x2000120")]
public interface IRegistrationPolicy
{

	[Token(Token = "0x6000AB6")]
	public bool AllowTypeAutoRegistration(Type type) { }

	[Token(Token = "0x6000AB5")]
	public IUserDataDescriptor HandleRegistration(IUserDataDescriptor newDescriptor, IUserDataDescriptor oldDescriptor) { }

}

