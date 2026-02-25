namespace Mirror;

[Token(Token = "0x200000F")]
public class SceneAttribute : PropertyAttribute
{

	[Address(RVA = "0x40DF10", Offset = "0x40D110", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyAttribute), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600007B")]
	public SceneAttribute() { }

}

