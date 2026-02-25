namespace UnityEngine.Windows.Speech;

[Token(Token = "0x20001A2")]
public struct PhraseRecognizedEventArgs
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000622")]
	public readonly ConfidenceLevel confidence; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000623")]
	public readonly SemanticMeaning[] semanticMeanings; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000624")]
	public readonly string text; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000625")]
	public readonly DateTime phraseStartTime; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000626")]
	public readonly TimeSpan phraseDuration; //Field offset: 0x20

	[Address(RVA = "0x1969A00", Offset = "0x1968C00", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000BB9")]
	internal PhraseRecognizedEventArgs(string text, ConfidenceLevel confidence, SemanticMeaning[] semanticMeanings, DateTime phraseStartTime, TimeSpan phraseDuration) { }

}

