namespace Mirror;

[AttributeUsage(384)]
[Token(Token = "0x2000011")]
public class ReadOnlyAttribute : PropertyAttribute
{

	[Address(RVA = "0x40DF10", Offset = "0x40D110", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyAttribute), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600007D")]
	public ReadOnlyAttribute() { }

}

