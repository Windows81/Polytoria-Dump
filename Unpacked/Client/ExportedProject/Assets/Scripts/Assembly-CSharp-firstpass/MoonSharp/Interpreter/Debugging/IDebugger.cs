namespace MoonSharp.Interpreter.Debugging;

[Token(Token = "0x2000163")]
public interface IDebugger
{

	[Token(Token = "0x6000D01")]
	public DebuggerAction GetAction(int ip, SourceRef sourceref) { }

	[Token(Token = "0x6000CFB")]
	public DebuggerCaps GetDebuggerCaps() { }

	[Token(Token = "0x6000D04")]
	public List<DynamicExpression> GetWatchItems() { }

	[Token(Token = "0x6000CFF")]
	public bool IsPauseRequested() { }

	[Token(Token = "0x6000D05")]
	public void RefreshBreakpoints(IEnumerable<SourceRef> refs) { }

	[Token(Token = "0x6000CFE")]
	public void SetByteCode(String[] byteCode) { }

	[Token(Token = "0x6000CFC")]
	public void SetDebugService(DebugService debugService) { }

	[Token(Token = "0x6000CFD")]
	public void SetSourceCode(SourceCode sourceCode) { }

	[Token(Token = "0x6000D02")]
	public void SignalExecutionEnded() { }

	[Token(Token = "0x6000D00")]
	public bool SignalRuntimeException(ScriptRuntimeException ex) { }

	[Token(Token = "0x6000D03")]
	public void Update(WatchType watchType, IEnumerable<WatchItem> items) { }

}

