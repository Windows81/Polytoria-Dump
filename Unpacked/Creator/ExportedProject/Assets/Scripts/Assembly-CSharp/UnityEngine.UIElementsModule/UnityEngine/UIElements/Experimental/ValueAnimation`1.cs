namespace UnityEngine.UIElements.Experimental;

[Token(Token = "0x200062D")]
public sealed class ValueAnimation : IValueAnimationUpdate
{
	[CompilerGenerated]
	[Token(Token = "0x200062E")]
	private sealed class <>c
	{
		[Token(Token = "0x40016FF")]
		public static readonly <>c<T> <>9; //Field offset: 0x0

		[Address(RVA = "0x7FC210", Offset = "0x7FB410", Length = "0xE9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B78")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B79")]
		public <>c() { }

		[Address(RVA = "0x7FA3F0", Offset = "0x7F95F0", Length = "0x5D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ValueAnimation`1), Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B7A")]
		internal ValueAnimation<T> <.cctor>b__67_0() { }

	}

	[Token(Token = "0x40016F7")]
	private static ObjectPool<ValueAnimation`1<T>> sObjectPool; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40016F0")]
	private long m_StartTimeMs; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40016F1")]
	private int m_DurationMs; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40016F2")]
	private Func<Single, Single> <easingCurve>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40016F3")]
	private bool <isRunning>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40016F4")]
	private Action <onAnimationCompleted>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40016F5")]
	private bool <autoRecycle>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40016F6")]
	private bool <recycled>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40016F8")]
	private VisualElement <owner>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40016F9")]
	private Action<VisualElement, T> <valueUpdated>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40016FA")]
	private Func<VisualElement, T> <initialValue>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40016FB")]
	private Func<T, T, Single, T> <interpolator>k__BackingField; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40016FC")]
	private T _from; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40016FD")]
	private bool fromValueSet; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40016FE")]
	private T <to>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x17000B1A")]
	public bool autoRecycle
	{
		[Address(RVA = "0x3408F0", Offset = "0x33FAF0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B5B")]
		 get { } //Length: 5
		[Address(RVA = "0x340A60", Offset = "0x33FC60", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B5C")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000B16")]
	public override int durationMs
	{
		[Address(RVA = "0x8520C0", Offset = "0x8512C0", Length = "0x6")]
		[CallerCount(Count = 44)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B53")]
		 get { } //Length: 6
		[Address(RVA = "0x852660", Offset = "0x851860", Length = "0x10")]
		[CalledBy(Type = typeof(VisualElement), Member = "StartAnimation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.Experimental.ValueAnimation`1<T>", "System.Func`2<VisualElement, T>", "T", typeof(int), "System.Action`2<VisualElement, T>"}, ReturnType = "UnityEngine.UIElements.Experimental.ValueAnimation`1<T>")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B54")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000B17")]
	public Func<Single, Single> easingCurve
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B55")]
		 get { } //Length: 5
		[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B56")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000B20")]
	public T from
	{
		[Address(RVA = "0x852100", Offset = "0x851300", Length = "0x53")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B67")]
		 get { } //Length: 83
		[Address(RVA = "0x8527F0", Offset = "0x8519F0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B68")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000B1E")]
	public Func<VisualElement, T> initialValue
	{
		[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
		[CallerCount(Count = 8)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B63")]
		 get { } //Length: 5
		[Address(RVA = "0x2DD610", Offset = "0x2DC810", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B64")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000B1F")]
	public Func<T, T, Single, T> interpolator
	{
		[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B65")]
		 get { } //Length: 5
		[Address(RVA = "0x324160", Offset = "0x323360", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B66")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000B18")]
	public private override bool isRunning
	{
		[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B57")]
		 get { } //Length: 5
		[Address(RVA = "0x309690", Offset = "0x308890", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B58")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000B19")]
	public Action onAnimationCompleted
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B59")]
		 get { } //Length: 95
		[Address(RVA = "0x2F8470", Offset = "0x2F7670", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B5A")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000B1C")]
	private VisualElement owner
	{
		[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B5F")]
		private get { } //Length: 5
		[Address(RVA = "0x309660", Offset = "0x308860", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B60")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000B1B")]
	private bool recycled
	{
		[Address(RVA = "0x53B940", Offset = "0x53AB40", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B5D")]
		private get { } //Length: 5
		[Address(RVA = "0x53B980", Offset = "0x53AB80", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B5E")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000B21")]
	public T to
	{
		[Address(RVA = "0x3F5890", Offset = "0x3F4A90", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B69")]
		 get { } //Length: 5
		[Address(RVA = "0x852B70", Offset = "0x851D70", Length = "0xF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B6A")]
		 set { } //Length: 15
	}

	[Token(Token = "0x17000B1D")]
	public Action<VisualElement, T> valueUpdated
	{
		[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
		[CallerCount(Count = 4)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B61")]
		 get { } //Length: 5
		[Address(RVA = "0x2DD5F0", Offset = "0x2DC7F0", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B62")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x851AC0", Offset = "0x850CC0", Length = "0x235")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ObjectPool`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B77")]
	private static ValueAnimation`1() { }

	[Address(RVA = "0x852020", Offset = "0x851220", Length = "0x3C")]
	[CalledBy(Type = typeof(<>c), Member = "<.cctor>b__67_0", ReturnType = "UnityEngine.UIElements.Experimental.ValueAnimation`1<T>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180035200")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B6B")]
	public ValueAnimation`1() { }

	[Address(RVA = "0x850300", Offset = "0x84F500", Length = "0x5B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B74")]
	private void CheckNotRecycled() { }

	[Address(RVA = "0x850360", Offset = "0x84F560", Length = "0x18F")]
	[CalledBy(Type = typeof(VisualElement), Member = "UnityEngine.UIElements.Experimental.ITransitionAnimations.Start", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValues), typeof(int)}, ReturnType = typeof(UnityEngine.UIElements.Experimental.ValueAnimation`1<UnityEngine.UIElements.Experimental.StyleValues>))]
	[CalledBy(Type = typeof(VisualElement), Member = "Start", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`2<UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.Experimental.StyleValues>), typeof(StyleValues), typeof(int)}, ReturnType = typeof(UnityEngine.UIElements.Experimental.ValueAnimation`1<UnityEngine.UIElements.Experimental.StyleValues>))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ObjectPool`1), Member = "Get", ReturnType = "T")]
	[Calls(Type = typeof(VisualElement), Member = "UnregisterAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IValueAnimationUpdate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(VisualElement), Member = "RegisterAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IValueAnimationUpdate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B75")]
	public static ValueAnimation<T> Create(VisualElement e, Func<T, T, Single, T> interpolator) { }

	[Address(RVA = "0x3408F0", Offset = "0x33FAF0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B5B")]
	public bool get_autoRecycle() { }

	[Address(RVA = "0x8520C0", Offset = "0x8512C0", Length = "0x6")]
	[CallerCount(Count = 44)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B53")]
	public override int get_durationMs() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B55")]
	public Func<Single, Single> get_easingCurve() { }

	[Address(RVA = "0x852100", Offset = "0x851300", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B67")]
	public T get_from() { }

	[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
	[CallerCount(Count = 8)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B63")]
	public Func<VisualElement, T> get_initialValue() { }

	[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B65")]
	public Func<T, T, Single, T> get_interpolator() { }

	[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B57")]
	public override bool get_isRunning() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B59")]
	public Action get_onAnimationCompleted() { }

	[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B5F")]
	private VisualElement get_owner() { }

	[Address(RVA = "0x53B940", Offset = "0x53AB40", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B5D")]
	private bool get_recycled() { }

	[Address(RVA = "0x3F5890", Offset = "0x3F4A90", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B69")]
	public T get_to() { }

	[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
	[CallerCount(Count = 4)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B61")]
	public Action<VisualElement, T> get_valueUpdated() { }

	[Address(RVA = "0x850750", Offset = "0x84F950", Length = "0x8")]
	[CalledBy(Type = typeof(ListViewDraggerAnimated), Member = "Animate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B76")]
	public ValueAnimation<T> KeepAlive() { }

	[Address(RVA = "0x850760", Offset = "0x84F960", Length = "0x147")]
	[CalledBy(Type = typeof(ListViewDraggerAnimated), Member = "Animate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ListViewDraggerAnimated), Member = "OnDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ValueAnimation`1), Member = "Stop", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180035200")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ObjectPool`1), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B6E")]
	public override void Recycle() { }

	[Address(RVA = "0x850A20", Offset = "0x84FC20", Length = "0x17")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "RegisterAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IValueAnimationUpdate)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B72")]
	private void Register() { }

	[Address(RVA = "0x340A60", Offset = "0x33FC60", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B5C")]
	public void set_autoRecycle(bool value) { }

	[Address(RVA = "0x852660", Offset = "0x851860", Length = "0x10")]
	[CalledBy(Type = typeof(VisualElement), Member = "StartAnimation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.Experimental.ValueAnimation`1<T>", "System.Func`2<VisualElement, T>", "T", typeof(int), "System.Action`2<VisualElement, T>"}, ReturnType = "UnityEngine.UIElements.Experimental.ValueAnimation`1<T>")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B54")]
	public override void set_durationMs(int value) { }

	[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B56")]
	public void set_easingCurve(Func<Single, Single> value) { }

	[Address(RVA = "0x8527F0", Offset = "0x8519F0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B68")]
	public void set_from(T value) { }

	[Address(RVA = "0x2DD610", Offset = "0x2DC810", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B64")]
	public void set_initialValue(Func<VisualElement, T> value) { }

	[Address(RVA = "0x324160", Offset = "0x323360", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B66")]
	public void set_interpolator(Func<T, T, Single, T> value) { }

	[Address(RVA = "0x309690", Offset = "0x308890", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B58")]
	private void set_isRunning(bool value) { }

	[Address(RVA = "0x2F8470", Offset = "0x2F7670", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B5A")]
	public void set_onAnimationCompleted(Action value) { }

	[Address(RVA = "0x309660", Offset = "0x308860", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B60")]
	private void set_owner(VisualElement value) { }

	[Address(RVA = "0x53B980", Offset = "0x53AB80", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B5E")]
	private void set_recycled(bool value) { }

	[Address(RVA = "0x852B70", Offset = "0x851D70", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B6A")]
	public void set_to(T value) { }

	[Address(RVA = "0x2DD5F0", Offset = "0x2DC7F0", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B62")]
	public void set_valueUpdated(Action<VisualElement, T> value) { }

	[Address(RVA = "0x850E20", Offset = "0x850020", Length = "0xF3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B70")]
	private void SetDefaultValues() { }

	[Address(RVA = "0x850F20", Offset = "0x850120", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "UnregisterAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IValueAnimationUpdate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(VisualElement), Member = "RegisterAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IValueAnimationUpdate)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B73")]
	internal void SetOwner(VisualElement e) { }

	[Address(RVA = "0x851040", Offset = "0x850240", Length = "0xC9")]
	[CalledBy(Type = typeof(VisualElement), Member = "StartAnimation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.Experimental.ValueAnimation`1<T>", "System.Func`2<VisualElement, T>", "T", typeof(int), "System.Action`2<VisualElement, T>"}, ReturnType = "UnityEngine.UIElements.Experimental.ValueAnimation`1<T>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Panel), Member = "TimeSinceStartupMs", ReturnType = typeof(long))]
	[Calls(Type = typeof(VisualElement), Member = "RegisterAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IValueAnimationUpdate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B6C")]
	public override void Start() { }

	[Address(RVA = "0x851340", Offset = "0x850540", Length = "0x192")]
	[CalledBy(Type = typeof(ListViewDraggerAnimated), Member = "Animate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ListViewDraggerAnimated), Member = "OnDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ValueAnimation`1), Member = "Recycle", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ValueAnimation`1), Member = "UnityEngine.UIElements.Experimental.IValueAnimationUpdate.Tick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180035200")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(VisualElement), Member = "UnregisterAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IValueAnimationUpdate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ObjectPool`1), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B6D")]
	public override void Stop() { }

	[Address(RVA = "0x8518A0", Offset = "0x850AA0", Length = "0x181")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ValueAnimation`1), Member = "Stop", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B6F")]
	private override void UnityEngine.UIElements.Experimental.IValueAnimationUpdate.Tick(long currentTimeMs) { }

	[Address(RVA = "0x851A30", Offset = "0x850C30", Length = "0x17")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "UnregisterAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IValueAnimationUpdate)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B71")]
	private void Unregister() { }

}

