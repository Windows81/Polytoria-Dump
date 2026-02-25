namespace RLD;

[Token(Token = "0x200015A")]
public class ColorTransition
{
	[Token(Token = "0x200015C")]
	internal sealed class ColorTransitionBeginHandler : MulticastDelegate
	{

		[Address(RVA = "0x3CD330", Offset = "0x3CC530", Length = "0x124")]
		[CallerCount(Count = 83)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9C0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000FB8")]
		public ColorTransitionBeginHandler(object object, IntPtr method) { }

		[Address(RVA = "0x309230", Offset = "0x308430", Length = "0x21")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000FBA")]
		public override IAsyncResult BeginInvoke(ColorTransition colorTransition, AsyncCallback callback, object object) { }

		[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000FBB")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000FB9")]
		public override void Invoke(ColorTransition colorTransition) { }

	}

	[Token(Token = "0x200015D")]
	internal sealed class ColorTransitionEndHandler : MulticastDelegate
	{

		[Address(RVA = "0x3CD330", Offset = "0x3CC530", Length = "0x124")]
		[CallerCount(Count = 83)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9C0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000FBC")]
		public ColorTransitionEndHandler(object object, IntPtr method) { }

		[Address(RVA = "0x309230", Offset = "0x308430", Length = "0x21")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000FBE")]
		public override IAsyncResult BeginInvoke(ColorTransition colorTransition, AsyncCallback callback, object object) { }

		[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000FBF")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000FBD")]
		public override void Invoke(ColorTransition colorTransition) { }

	}

	[Token(Token = "0x200015B")]
	internal enum State
	{
		CompleteFadeIn = 0,
		CompleteFadeOut = 1,
		FadingIn = 2,
		FadingOut = 3,
		Ready = 4,
	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000636")]
	private ColorTransitionBeginHandler TransitionBegin; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000637")]
	private ColorTransitionEndHandler TransitionEnd; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000638")]
	private ColorRef _colorRef; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000639")]
	private Color _fadeInColor; //Field offset: 0x28
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400063A")]
	private Color _fadeOutColor; //Field offset: 0x38
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400063B")]
	private State _state; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x400063C")]
	private float _durationInSeconds; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400063D")]
	private float _elapsedTimeInSeconds; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x400063E")]
	private bool _isActive; //Field offset: 0x54

	[Token(Token = "0x14000022")]
	public event ColorTransitionBeginHandler TransitionBegin
	{
		[Address(RVA = "0x53EF30", Offset = "0x53E130", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000FA7")]
		 add { } //Length: 158
		[Address(RVA = "0x53F070", Offset = "0x53E270", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000FA8")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x14000023")]
	public event ColorTransitionEndHandler TransitionEnd
	{
		[Address(RVA = "0x53EFD0", Offset = "0x53E1D0", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000FA9")]
		 add { } //Length: 158
		[Address(RVA = "0x53F110", Offset = "0x53E310", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000FAA")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x17000555")]
	public float DurationInSeconds
	{
		[Address(RVA = "0x3B43E0", Offset = "0x3B35E0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000FB0")]
		 get { } //Length: 6
		[Address(RVA = "0x53F1B0", Offset = "0x53E3B0", Length = "0xF")]
		[CalledBy(Type = typeof(SceneGizmoAxisCap), Member = "UpdateColor", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Token(Token = "0x6000FB1")]
		 set { } //Length: 15
	}

	[Token(Token = "0x17000553")]
	public Color FadeInColor
	{
		[Address(RVA = "0x3B0170", Offset = "0x3AF370", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000FAC")]
		 get { } //Length: 11
		[Address(RVA = "0x3B8870", Offset = "0x3B7A70", Length = "0x8")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000FAD")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000554")]
	public Color FadeOutColor
	{
		[Address(RVA = "0x3EAB10", Offset = "0x3E9D10", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000FAE")]
		 get { } //Length: 11
		[Address(RVA = "0x3EAB40", Offset = "0x3E9D40", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000FAF")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000556")]
	public bool IsActive
	{
		[Address(RVA = "0x33C7E0", Offset = "0x33B9E0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000FB2")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000552")]
	public State TransitionState
	{
		[Address(RVA = "0x309620", Offset = "0x308820", Length = "0x4")]
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000FAB")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x53EED0", Offset = "0x53E0D0", Length = "0x53")]
	[CalledBy(Type = typeof(SceneGizmoAxisCap), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SceneGizmo), typeof(int), typeof(AxisDescriptor)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000FB3")]
	public ColorTransition(ColorRef colorRef) { }

	[Address(RVA = "0x53EF30", Offset = "0x53E130", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000FA7")]
	public void add_TransitionBegin(ColorTransitionBeginHandler value) { }

	[Address(RVA = "0x53EFD0", Offset = "0x53E1D0", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000FA9")]
	public void add_TransitionEnd(ColorTransitionEndHandler value) { }

	[Address(RVA = "0x53EC40", Offset = "0x53DE40", Length = "0x59")]
	[CalledBy(Type = typeof(SceneGizmoAxisCap), Member = "UpdateColor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000FB4")]
	public void BeginFadeIn(bool startFromCurrentColor) { }

	[Address(RVA = "0x53ECA0", Offset = "0x53DEA0", Length = "0x59")]
	[CalledBy(Type = typeof(SceneGizmoAxisCap), Member = "UpdateColor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000FB5")]
	public void BeginFadeOut(bool startFromCurrentColor) { }

	[Address(RVA = "0x53ED00", Offset = "0x53DF00", Length = "0x44")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000FB7")]
	private void End() { }

	[Address(RVA = "0x3B43E0", Offset = "0x3B35E0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FB0")]
	public float get_DurationInSeconds() { }

	[Address(RVA = "0x3B0170", Offset = "0x3AF370", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FAC")]
	public Color get_FadeInColor() { }

	[Address(RVA = "0x3EAB10", Offset = "0x3E9D10", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FAE")]
	public Color get_FadeOutColor() { }

	[Address(RVA = "0x33C7E0", Offset = "0x33B9E0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FB2")]
	public bool get_IsActive() { }

	[Address(RVA = "0x309620", Offset = "0x308820", Length = "0x4")]
	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FAB")]
	public State get_TransitionState() { }

	[Address(RVA = "0x53F070", Offset = "0x53E270", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000FA8")]
	public void remove_TransitionBegin(ColorTransitionBeginHandler value) { }

	[Address(RVA = "0x53F110", Offset = "0x53E310", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000FAA")]
	public void remove_TransitionEnd(ColorTransitionEndHandler value) { }

	[Address(RVA = "0x53F1B0", Offset = "0x53E3B0", Length = "0xF")]
	[CalledBy(Type = typeof(SceneGizmoAxisCap), Member = "UpdateColor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x6000FB1")]
	public void set_DurationInSeconds(float value) { }

	[Address(RVA = "0x3B8870", Offset = "0x3B7A70", Length = "0x8")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FAD")]
	public void set_FadeInColor(Color value) { }

	[Address(RVA = "0x3EAB40", Offset = "0x3E9D40", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FAF")]
	public void set_FadeOutColor(Color value) { }

	[Address(RVA = "0x53ED50", Offset = "0x53DF50", Length = "0x172")]
	[CalledBy(Type = typeof(SceneGizmoAxisCap), Member = "UpdateColor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000FB6")]
	public void Update(float elapsedTime) { }

}

