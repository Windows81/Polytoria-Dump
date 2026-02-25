namespace UnityEngine.UIElements;

[Token(Token = "0x2000431")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal interface IStylePropertyAnimationSystem
{

	[Token(Token = "0x6001F98")]
	public void CancelAllAnimations(VisualElement owner) { }

	[Token(Token = "0x6001F97")]
	public void CancelAllAnimations() { }

	[Token(Token = "0x6001F99")]
	public void CancelAnimation(VisualElement owner, StylePropertyId id) { }

	[Token(Token = "0x6001F9B")]
	public void GetAllAnimations(VisualElement owner, List<StylePropertyId> propertyIds) { }

	[Token(Token = "0x6001F87")]
	public bool StartTransition(VisualElement owner, StylePropertyId prop, float startValue, float endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x6001F96")]
	public bool StartTransition(VisualElement owner, StylePropertyId prop, BackgroundSize startValue, BackgroundSize endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x6001F95")]
	public bool StartTransition(VisualElement owner, StylePropertyId prop, BackgroundRepeat startValue, BackgroundRepeat endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x6001F94")]
	public bool StartTransition(VisualElement owner, StylePropertyId prop, BackgroundPosition startValue, BackgroundPosition endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x6001F93")]
	public bool StartTransition(VisualElement owner, StylePropertyId prop, Rotate startValue, Rotate endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x6001F92")]
	public bool StartTransition(VisualElement owner, StylePropertyId prop, Translate startValue, Translate endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x6001F91")]
	public bool StartTransition(VisualElement owner, StylePropertyId prop, TransformOrigin startValue, TransformOrigin endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x6001F8F")]
	public bool StartTransition(VisualElement owner, StylePropertyId prop, TextShadow startValue, TextShadow endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x6001F8E")]
	public bool StartTransition(VisualElement owner, StylePropertyId prop, Font startValue, Font endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x6001F8D")]
	public bool StartTransition(VisualElement owner, StylePropertyId prop, FontDefinition startValue, FontDefinition endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x6001F8C")]
	public bool StartTransition(VisualElement owner, StylePropertyId prop, Background startValue, Background endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x6001F8A")]
	public bool StartTransition(VisualElement owner, StylePropertyId prop, Color startValue, Color endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x6001F89")]
	public bool StartTransition(VisualElement owner, StylePropertyId prop, Length startValue, Length endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x6001F88")]
	public bool StartTransition(VisualElement owner, StylePropertyId prop, int startValue, int endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x6001F90")]
	public bool StartTransition(VisualElement owner, StylePropertyId prop, Scale startValue, Scale endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x6001F8B")]
	public bool StartTransitionEnum(VisualElement owner, StylePropertyId prop, int startValue, int endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x6001F9C")]
	public void Update() { }

	[Token(Token = "0x6001F9A")]
	public void UpdateAnimation(VisualElement owner, StylePropertyId id) { }

}

