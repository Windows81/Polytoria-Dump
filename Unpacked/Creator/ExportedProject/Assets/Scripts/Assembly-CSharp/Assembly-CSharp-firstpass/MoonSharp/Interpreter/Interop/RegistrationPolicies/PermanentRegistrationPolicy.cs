namespace MoonSharp.Interpreter.Interop.RegistrationPolicies;

[Token(Token = "0x2000121")]
public class PermanentRegistrationPolicy : IRegistrationPolicy
{

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AB9")]
	public PermanentRegistrationPolicy() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AB8")]
	public override bool AllowTypeAutoRegistration(Type type) { }

	[Address(RVA = "0x35C850", Offset = "0x35BA50", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000AB7")]
	public override IUserDataDescriptor HandleRegistration(IUserDataDescriptor newDescriptor, IUserDataDescriptor oldDescriptor) { }

}

