namespace Polytoria.Datamodel;

[AttributeUsage(AttributeTargets::Property (128))]
[Token(Token = "0x2000329")]
public class Archivable : PropertyAttribute
{

	[Address(RVA = "0x40DF10", Offset = "0x40D110", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyAttribute), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E78")]
	public Archivable() { }

}

