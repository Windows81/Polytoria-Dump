namespace UnityEngine.UI.CoroutineTween;

[Token(Token = "0x200008B")]
internal struct ColorTween : ITweenValue
{
	[Token(Token = "0x200008D")]
	internal class ColorTweenCallback : UnityEvent<Color>
	{

		[Address(RVA = "0x1CE0800", Offset = "0x1CDFA00", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000577")]
		public ColorTweenCallback() { }

	}

	[Token(Token = "0x200008C")]
	internal enum ColorTweenMode
	{
		All = 0,
		RGB = 1,
		Alpha = 2,
	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000278")]
	private ColorTweenCallback m_Target; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000279")]
	private Color m_StartColor; //Field offset: 0x8
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400027A")]
	private Color m_TargetColor; //Field offset: 0x18
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400027B")]
	private ColorTweenMode m_TweenMode; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400027C")]
	private float m_Duration; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400027D")]
	private bool m_IgnoreTimeScale; //Field offset: 0x30

	[Token(Token = "0x17000162")]
	public override float duration
	{
		[Address(RVA = "0x3B2150", Offset = "0x3B1350", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600056E")]
		 get { } //Length: 6
		[Address(RVA = "0x1888A50", Offset = "0x1887C50", Length = "0x6")]
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		[Token(Token = "0x600056F")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000163")]
	public override bool ignoreTimeScale
	{
		[Address(RVA = "0x3351B0", Offset = "0x3343B0", Length = "0x5")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000570")]
		 get { } //Length: 5
		[Address(RVA = "0x3351C0", Offset = "0x3343C0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000571")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700015F")]
	public Color startColor
	{
		[Address(RVA = "0xCE38B0", Offset = "0xCE2AB0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000568")]
		 get { } //Length: 11
		[Address(RVA = "0x1474EB0", Offset = "0x14740B0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000569")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000160")]
	public Color targetColor
	{
		[Address(RVA = "0x5131D0", Offset = "0x5123D0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600056A")]
		 get { } //Length: 11
		[Address(RVA = "0x5131E0", Offset = "0x5123E0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600056B")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000161")]
	public ColorTweenMode tweenMode
	{
		[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600056C")]
		 get { } //Length: 4
		[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x600056D")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x1CE0840", Offset = "0x1CDFA40", Length = "0xB7")]
	[CalledBy(Type = typeof(Graphic), Member = "CrossFadeColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(float), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000573")]
	public void AddOnChangedCallback(UnityAction<Color> callback) { }

	[Address(RVA = "0x3B2150", Offset = "0x3B1350", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600056E")]
	public override float get_duration() { }

	[Address(RVA = "0x3351B0", Offset = "0x3343B0", Length = "0x5")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000570")]
	public override bool get_ignoreTimeScale() { }

	[Address(RVA = "0xCE38B0", Offset = "0xCE2AB0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000568")]
	public Color get_startColor() { }

	[Address(RVA = "0x5131D0", Offset = "0x5123D0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600056A")]
	public Color get_targetColor() { }

	[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600056C")]
	public ColorTweenMode get_tweenMode() { }

	[Address(RVA = "0x3B2150", Offset = "0x3B1350", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000575")]
	public float GetDuration() { }

	[Address(RVA = "0x3351B0", Offset = "0x3343B0", Length = "0x5")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000574")]
	public bool GetIgnoreTimescale() { }

	[Address(RVA = "0x1888A50", Offset = "0x1887C50", Length = "0x6")]
	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	[Token(Token = "0x600056F")]
	public void set_duration(float value) { }

	[Address(RVA = "0x3351C0", Offset = "0x3343C0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000571")]
	public void set_ignoreTimeScale(bool value) { }

	[Address(RVA = "0x1474EB0", Offset = "0x14740B0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000569")]
	public void set_startColor(Color value) { }

	[Address(RVA = "0x5131E0", Offset = "0x5123E0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600056B")]
	public void set_targetColor(Color value) { }

	[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x600056D")]
	public void set_tweenMode(ColorTweenMode value) { }

	[Address(RVA = "0x1CE0900", Offset = "0x1CDFB00", Length = "0x121")]
	[CalledBy(Type = "UnityEngine.UI.CoroutineTween.TweenRunner`1+<Start>d__2", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TweenRunner`1), Member = "StartTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<UnityEngine.Color>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000572")]
	public override void TweenValue(float floatPercentage) { }

	[Address(RVA = "0x150B380", Offset = "0x150A580", Length = "0x8")]
	[CallerCount(Count = 6)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000576")]
	public override bool ValidTarget() { }

}

