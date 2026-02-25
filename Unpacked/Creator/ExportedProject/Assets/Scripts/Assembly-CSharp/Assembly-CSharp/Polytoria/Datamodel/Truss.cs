namespace Polytoria.Datamodel;

[Instantiatable]
[Token(Token = "0x2000365")]
public class Truss : Climbable
{

	[Address(RVA = "0x48F440", Offset = "0x48E640", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Climbable), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x60023F1")]
	public Truss() { }

	[Address(RVA = "0x48F410", Offset = "0x48E610", Length = "0x25")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Part), Member = "Awake", ReturnType = typeof(void))]
	[Calls(Type = typeof(Part), Member = "set_Networkshape", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PartShape)}, ReturnType = typeof(void))]
	[Token(Token = "0x60023F0")]
	protected virtual void Awake() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x60023F2")]
	public virtual bool Weaved() { }

}

