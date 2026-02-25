namespace UnityEngine.UIElements;

[Token(Token = "0x2000430")]
internal interface IStylePropertyAnimations
{

	[Token(Token = "0x170008A5")]
	public int completedAnimationCount
	{
		[Token(Token = "0x6001F85")]
		 get { } //Length: 0
		[Token(Token = "0x6001F86")]
		 set { } //Length: 0
	}

	[Token(Token = "0x170008A4")]
	public int runningAnimationCount
	{
		[Token(Token = "0x6001F83")]
		 get { } //Length: 0
		[Token(Token = "0x6001F84")]
		 set { } //Length: 0
	}

	[Token(Token = "0x6001F82")]
	public void CancelAllAnimations() { }

	[Token(Token = "0x6001F81")]
	public void CancelAnimation(StylePropertyId id) { }

	[Token(Token = "0x6001F85")]
	public int get_completedAnimationCount() { }

	[Token(Token = "0x6001F83")]
	public int get_runningAnimationCount() { }

	[Token(Token = "0x6001F80")]
	public void GetAllAnimations(List<StylePropertyId> outPropertyIds) { }

	[Token(Token = "0x6001F86")]
	public void set_completedAnimationCount(int value) { }

	[Token(Token = "0x6001F84")]
	public void set_runningAnimationCount(int value) { }

	[Token(Token = "0x6001F7E")]
	public bool Start(StylePropertyId id, BackgroundSize from, BackgroundSize to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x6001F7D")]
	public bool Start(StylePropertyId id, BackgroundRepeat from, BackgroundRepeat to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x6001F7C")]
	public bool Start(StylePropertyId id, BackgroundPosition from, BackgroundPosition to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x6001F7B")]
	public bool Start(StylePropertyId id, TransformOrigin from, TransformOrigin to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x6001F7A")]
	public bool Start(StylePropertyId id, Rotate from, Rotate to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x6001F78")]
	public bool Start(StylePropertyId id, Scale from, Scale to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x6001F77")]
	public bool Start(StylePropertyId id, TextShadow from, TextShadow to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x6001F76")]
	public bool Start(StylePropertyId id, Font from, Font to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x6001F75")]
	public bool Start(StylePropertyId id, FontDefinition from, FontDefinition to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x6001F74")]
	public bool Start(StylePropertyId id, Background from, Background to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x6001F72")]
	public bool Start(StylePropertyId id, Color from, Color to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x6001F71")]
	public bool Start(StylePropertyId id, Length from, Length to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x6001F70")]
	public bool Start(StylePropertyId id, int from, int to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x6001F79")]
	public bool Start(StylePropertyId id, Translate from, Translate to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x6001F6F")]
	public bool Start(StylePropertyId id, float from, float to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x6001F73")]
	public bool StartEnum(StylePropertyId id, int from, int to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x6001F7F")]
	public void UpdateAnimation(StylePropertyId id) { }

}

