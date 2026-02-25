namespace Mirror;

[AttributeUsage(AttributeTargets::Field (256))]
[Token(Token = "0x2000007")]
public class SyncVarAttribute : PropertyAttribute
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400002A")]
	public string hook; //Field offset: 0x18

	[Address(RVA = "0x40DF10", Offset = "0x40D110", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyAttribute), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000073")]
	public SyncVarAttribute() { }

}

