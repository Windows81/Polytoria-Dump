namespace GLTFast;

[Token(Token = "0x200003B")]
public interface IDeferAgent
{

	[Token(Token = "0x6000105")]
	public Task BreakPoint() { }

	[Token(Token = "0x6000106")]
	public Task BreakPoint(float duration) { }

	[Token(Token = "0x6000104")]
	public bool ShouldDefer(float duration) { }

}

