namespace TMPro;

[Token(Token = "0x2000036")]
internal struct ColorTween : ITweenValue
{
	[Token(Token = "0x2000038")]
	internal class ColorTweenCallback : UnityEvent<Color>
	{

		[Address(RVA = "0x1888820", Offset = "0x1887A20", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600018E")]
		public ColorTweenCallback() { }

	}

	[Token(Token = "0x2000037")]
	internal enum ColorTweenMode
	{
		All = 0,
		RGB = 1,
		Alpha = 2,
	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000183")]
	private ColorTweenCallback m_Target; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000184")]
	private Color m_StartColor; //Field offset: 0x8
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000185")]
	private Color m_TargetColor; //Field offset: 0x18
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000186")]
	private ColorTweenMode m_TweenMode; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000187")]
	private float m_Duration; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000188")]
	private bool m_IgnoreTimeScale; //Field offset: 0x30

	[Token(Token = "0x17000046")]
	public override float duration
	{
		[Address(RVA = "0x3B2150", Offset = "0x3B1350", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000185")]
		 get { } //Length: 6
		[Address(RVA = "0x1888A50", Offset = "0x1887C50", Length = "0x6")]
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000186")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000047")]
	public override bool ignoreTimeScale
	{
		[Address(RVA = "0x3351B0", Offset = "0x3343B0", Length = "0x5")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000187")]
		 get { } //Length: 5
		[Address(RVA = "0x3351C0", Offset = "0x3343C0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000188")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000043")]
	public Color startColor
	{
		[Address(RVA = "0xCE38B0", Offset = "0xCE2AB0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600017F")]
		 get { } //Length: 11
		[Address(RVA = "0x1474EB0", Offset = "0x14740B0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000180")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000044")]
	public Color targetColor
	{
		[Address(RVA = "0x5131D0", Offset = "0x5123D0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000181")]
		 get { } //Length: 11
		[Address(RVA = "0x5131E0", Offset = "0x5123E0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000182")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000045")]
	public ColorTweenMode tweenMode
	{
		[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000183")]
		 get { } //Length: 4
		[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000184")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x1888860", Offset = "0x1887A60", Length = "0xB7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600018A")]
	public void AddOnChangedCallback(UnityAction<Color> callback) { }

	[Address(RVA = "0x3B2150", Offset = "0x3B1350", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000185")]
	public override float get_duration() { }

	[Address(RVA = "0x3351B0", Offset = "0x3343B0", Length = "0x5")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000187")]
	public override bool get_ignoreTimeScale() { }

	[Address(RVA = "0xCE38B0", Offset = "0xCE2AB0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600017F")]
	public Color get_startColor() { }

	[Address(RVA = "0x5131D0", Offset = "0x5123D0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000181")]
	public Color get_targetColor() { }

	[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000183")]
	public ColorTweenMode get_tweenMode() { }

	[Address(RVA = "0x3B2150", Offset = "0x3B1350", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600018C")]
	public float GetDuration() { }

	[Address(RVA = "0x3351B0", Offset = "0x3343B0", Length = "0x5")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600018B")]
	public bool GetIgnoreTimescale() { }

	[Address(RVA = "0x1888A50", Offset = "0x1887C50", Length = "0x6")]
	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000186")]
	public void set_duration(float value) { }

	[Address(RVA = "0x3351C0", Offset = "0x3343C0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000188")]
	public void set_ignoreTimeScale(bool value) { }

	[Address(RVA = "0x1474EB0", Offset = "0x14740B0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000180")]
	public void set_startColor(Color value) { }

	[Address(RVA = "0x5131E0", Offset = "0x5123E0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000182")]
	public void set_targetColor(Color value) { }

	[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000184")]
	public void set_tweenMode(ColorTweenMode value) { }

	[Address(RVA = "0x1888920", Offset = "0x1887B20", Length = "0x121")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<UnityEngine.Color>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000189")]
	public override void TweenValue(float floatPercentage) { }

	[Address(RVA = "0x150B380", Offset = "0x150A580", Length = "0x8")]
	[CallerCount(Count = 6)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600018D")]
	public override bool ValidTarget() { }

}

