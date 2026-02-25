namespace TMPro;

[Token(Token = "0x2000039")]
internal struct FloatTween : ITweenValue
{
	[Token(Token = "0x200003A")]
	internal class FloatTweenCallback : UnityEvent<Single>
	{

		[Address(RVA = "0x1888EC0", Offset = "0x18880C0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600019C")]
		public FloatTweenCallback() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400018D")]
	private FloatTweenCallback m_Target; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400018E")]
	private float m_StartValue; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400018F")]
	private float m_TargetValue; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000190")]
	private float m_Duration; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000191")]
	private bool m_IgnoreTimeScale; //Field offset: 0x14

	[Token(Token = "0x1700004A")]
	public override float duration
	{
		[Address(RVA = "0x4FCB00", Offset = "0x4FBD00", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000193")]
		 get { } //Length: 6
		[Address(RVA = "0x2C1230", Offset = "0x2C0430", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000194")]
		 set { } //Length: 6
	}

	[Token(Token = "0x1700004B")]
	public override bool ignoreTimeScale
	{
		[Address(RVA = "0x59B000", Offset = "0x59A200", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000195")]
		 get { } //Length: 5
		[Address(RVA = "0x59B020", Offset = "0x59A220", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000196")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000048")]
	public float startValue
	{
		[Address(RVA = "0x553AE0", Offset = "0x552CE0", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600018F")]
		 get { } //Length: 6
		[Address(RVA = "0x1889040", Offset = "0x1888240", Length = "0x6")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000190")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000049")]
	public float targetValue
	{
		[Address(RVA = "0x564B90", Offset = "0x563D90", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000191")]
		 get { } //Length: 6
		[Address(RVA = "0x1889050", Offset = "0x1888250", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000192")]
		 set { } //Length: 6
	}

	[Address(RVA = "0x1888F00", Offset = "0x1888100", Length = "0xB7")]
	[CalledBy(Type = typeof(TMP_Dropdown), Member = "AlphaFadeList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000198")]
	public void AddOnChangedCallback(UnityAction<Single> callback) { }

	[Address(RVA = "0x4FCB00", Offset = "0x4FBD00", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000193")]
	public override float get_duration() { }

	[Address(RVA = "0x59B000", Offset = "0x59A200", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000195")]
	public override bool get_ignoreTimeScale() { }

	[Address(RVA = "0x553AE0", Offset = "0x552CE0", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600018F")]
	public float get_startValue() { }

	[Address(RVA = "0x564B90", Offset = "0x563D90", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000191")]
	public float get_targetValue() { }

	[Address(RVA = "0x4FCB00", Offset = "0x4FBD00", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600019A")]
	public float GetDuration() { }

	[Address(RVA = "0x59B000", Offset = "0x59A200", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000199")]
	public bool GetIgnoreTimescale() { }

	[Address(RVA = "0x2C1230", Offset = "0x2C0430", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000194")]
	public void set_duration(float value) { }

	[Address(RVA = "0x59B020", Offset = "0x59A220", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000196")]
	public void set_ignoreTimeScale(bool value) { }

	[Address(RVA = "0x1889040", Offset = "0x1888240", Length = "0x6")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000190")]
	public void set_startValue(float value) { }

	[Address(RVA = "0x1889050", Offset = "0x1888250", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000192")]
	public void set_targetValue(float value) { }

	[Address(RVA = "0x1888FC0", Offset = "0x18881C0", Length = "0x80")]
	[CalledBy(Type = "TMPro.TweenRunner`1+<Start>d__2", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TweenRunner`1), Member = "StartTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.Single>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000197")]
	public override void TweenValue(float floatPercentage) { }

	[Address(RVA = "0x150B380", Offset = "0x150A580", Length = "0x8")]
	[CallerCount(Count = 6)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600019B")]
	public override bool ValidTarget() { }

}

