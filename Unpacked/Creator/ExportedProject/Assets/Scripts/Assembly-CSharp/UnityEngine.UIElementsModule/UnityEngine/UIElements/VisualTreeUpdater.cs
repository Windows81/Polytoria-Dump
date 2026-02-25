namespace UnityEngine.UIElements;

[Token(Token = "0x2000533")]
internal sealed class VisualTreeUpdater : IDisposable
{
	[DefaultMember("Item")]
	[Token(Token = "0x2000534")]
	private class UpdaterArray
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4001143")]
		private IVisualTreeUpdater[] m_VisualTreeUpdaters; //Field offset: 0x10

		[Token(Token = "0x170009BC")]
		public IVisualTreeUpdater Item
		{
			[Address(RVA = "0xC33EA0", Offset = "0xC330A0", Length = "0x2B")]
			[CallerCount(Count = 11)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
			[DeduplicatedMethod]
			[Token(Token = "0x60025AF")]
			 get { } //Length: 43
			[Address(RVA = "0x1B6FBA0", Offset = "0x1B6EDA0", Length = "0x7B")]
			[CalledBy(Type = typeof(VisualTreeUpdater), Member = "SetUpdater", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualTreeUpdatePhase)}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
			[Token(Token = "0x60025AE")]
			 set { } //Length: 123
		}

		[Token(Token = "0x170009BD")]
		public IVisualTreeUpdater Item
		{
			[Address(RVA = "0xC33EA0", Offset = "0xC330A0", Length = "0x2B")]
			[CallerCount(Count = 11)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
			[DeduplicatedMethod]
			[Token(Token = "0x60025B0")]
			 get { } //Length: 43
		}

		[Address(RVA = "0x1B6FB40", Offset = "0x1B6ED40", Length = "0x55")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60025AD")]
		public UpdaterArray() { }

		[Address(RVA = "0xC33EA0", Offset = "0xC330A0", Length = "0x2B")]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x60025AF")]
		public IVisualTreeUpdater get_Item(VisualTreeUpdatePhase phase) { }

		[Address(RVA = "0xC33EA0", Offset = "0xC330A0", Length = "0x2B")]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x60025B0")]
		public IVisualTreeUpdater get_Item(int index) { }

		[Address(RVA = "0x1B6FBA0", Offset = "0x1B6EDA0", Length = "0x7B")]
		[CalledBy(Type = typeof(VisualTreeUpdater), Member = "SetUpdater", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualTreeUpdatePhase)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x60025AE")]
		public void set_Item(VisualTreeUpdatePhase phase, IVisualTreeUpdater value) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001141")]
	private BaseVisualElementPanel m_Panel; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001142")]
	private UpdaterArray m_UpdaterArray; //Field offset: 0x18

	[Address(RVA = "0x1B797C0", Offset = "0x1B789C0", Length = "0x1A3")]
	[CalledBy(Type = typeof(Panel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableObject), typeof(ContextType), typeof(EventDispatcher)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(VisualTreeUpdater), Member = "SetUpdater", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualTreeUpdatePhase)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60025A5")]
	public VisualTreeUpdater(BaseVisualElementPanel panel) { }

	[Address(RVA = "0x1B79090", Offset = "0x1B78290", Length = "0x122")]
	[CalledBy(Type = typeof(Panel), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60025A6")]
	public override void Dispose() { }

	[Address(RVA = "0x1B791C0", Offset = "0x1B783C0", Length = "0x33")]
	[CalledBy(Type = typeof(Panel), Member = "GetUpdater", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualTreeUpdatePhase)}, ReturnType = typeof(IVisualTreeUpdater))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60025AB")]
	public IVisualTreeUpdater GetUpdater(VisualTreeUpdatePhase phase) { }

	[Address(RVA = "0x1B79200", Offset = "0x1B78400", Length = "0x134")]
	[CalledBy(Type = typeof(Panel), Member = "OnVersionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60025A8")]
	public void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	[Address(RVA = "0x1B79340", Offset = "0x1B78540", Length = "0xFB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualTreeUpdater), Member = "SetUpdater", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualTreeUpdatePhase)}, ReturnType = typeof(void))]
	[Token(Token = "0x60025AC")]
	private void SetDefaultUpdaters() { }

	[Address(RVA = "0x1B79440", Offset = "0x1B78640", Length = "0x175")]
	[CalledBy(Type = typeof(Panel), Member = "SetUpdater", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IVisualTreeUpdater), typeof(VisualTreeUpdatePhase)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60025A9")]
	public void SetUpdater(IVisualTreeUpdater updater, VisualTreeUpdatePhase phase) { }

	[Address(RVA = "0x7D2BF0", Offset = "0x7D1DF0", Length = "0x136")]
	[CalledBy(Type = typeof(VisualTreeUpdater), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeUpdater), Member = "SetDefaultUpdaters", ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(UpdaterArray), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualTreeUpdatePhase), typeof(IVisualTreeUpdater)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60025AA")]
	public void SetUpdater(VisualTreeUpdatePhase phase) { }

	[Address(RVA = "0x1B795C0", Offset = "0x1B787C0", Length = "0x1FC")]
	[CalledBy(Type = typeof(Panel), Member = "ValidateLayout", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Panel), Member = "UpdateAnimations", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Panel), Member = "UpdateBindings", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Panel), Member = "UpdateDataBinding", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Panel), Member = "ApplyStyles", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Panel), Member = "UpdateForRepaint", ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60025A7")]
	public void UpdateVisualTreePhase(VisualTreeUpdatePhase phase) { }

}

