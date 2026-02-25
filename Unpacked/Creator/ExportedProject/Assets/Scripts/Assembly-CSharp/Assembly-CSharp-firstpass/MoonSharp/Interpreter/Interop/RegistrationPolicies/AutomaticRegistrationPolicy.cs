namespace MoonSharp.Interpreter.Interop.RegistrationPolicies;

[Token(Token = "0x200011E")]
public class AutomaticRegistrationPolicy : DefaultRegistrationPolicy
{

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AB1")]
	public AutomaticRegistrationPolicy() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AB0")]
	public virtual bool AllowTypeAutoRegistration(Type type) { }

}

