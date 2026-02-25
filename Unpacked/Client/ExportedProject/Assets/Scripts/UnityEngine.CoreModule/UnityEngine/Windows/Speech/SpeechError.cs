namespace UnityEngine.Windows.Speech;

[Token(Token = "0x200019F")]
public enum SpeechError
{
	NoError = 0,
	TopicLanguageNotSupported = 1,
	GrammarLanguageMismatch = 2,
	GrammarCompilationFailure = 3,
	AudioQualityFailure = 4,
	PauseLimitExceeded = 5,
	TimeoutExceeded = 6,
	NetworkFailure = 7,
	MicrophoneUnavailable = 8,
	UnknownError = 9,
}

