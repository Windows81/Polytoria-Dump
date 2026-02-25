namespace MoonSharp.Interpreter.Interop.RegistrationPolicies;

[Token(Token = "0x200011F")]
public class DefaultRegistrationPolicy : IRegistrationPolicy
{

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AB4")]
	public DefaultRegistrationPolicy() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AB3")]
	public override bool AllowTypeAutoRegistration(Type type) { }

	[Address(RVA = "0x353BA0", Offset = "0x352DA0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000AB2")]
	public override IUserDataDescriptor HandleRegistration(IUserDataDescriptor newDescriptor, IUserDataDescriptor oldDescriptor) { }

}

