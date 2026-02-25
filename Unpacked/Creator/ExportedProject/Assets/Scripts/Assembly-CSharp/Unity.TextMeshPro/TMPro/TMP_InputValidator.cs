namespace TMPro;

[Token(Token = "0x2000070")]
public abstract class TMP_InputValidator : ScriptableObject
{

	[Address(RVA = "0x40DB10", Offset = "0x40CD10", Length = "0x7")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000407")]
	protected TMP_InputValidator() { }

	[Token(Token = "0x6000406")]
	public abstract char Validate(ref string text, ref int pos, char ch) { }

}

