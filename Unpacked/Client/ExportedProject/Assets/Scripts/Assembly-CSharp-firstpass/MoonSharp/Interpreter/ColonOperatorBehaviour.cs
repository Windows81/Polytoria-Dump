namespace MoonSharp.Interpreter;

[Token(Token = "0x2000079")]
public enum ColonOperatorBehaviour
{
	TreatAsDot = 0,
	TreatAsDotOnUserData = 1,
	TreatAsColon = 2,
}

