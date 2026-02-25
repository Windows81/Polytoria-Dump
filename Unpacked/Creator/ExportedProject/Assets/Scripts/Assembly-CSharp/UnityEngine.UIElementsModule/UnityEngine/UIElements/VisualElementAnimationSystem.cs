namespace UnityEngine.UIElements;

[Token(Token = "0x2000527")]
internal class VisualElementAnimationSystem : BaseVisualTreeUpdater
{
	[Token(Token = "0x4001106")]
	private static readonly string s_Description; //Field offset: 0x0
	[Token(Token = "0x4001107")]
	private static readonly ProfilerMarker s_ProfilerMarker; //Field offset: 0x8
	[Token(Token = "0x4001108")]
	private static readonly string s_StylePropertyAnimationDescription; //Field offset: 0x10
	[Token(Token = "0x4001109")]
	private static readonly ProfilerMarker s_StylePropertyAnimationProfilerMarker; //Field offset: 0x18
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001102")]
	private HashSet<IValueAnimationUpdate> m_Animations; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001103")]
	private List<IValueAnimationUpdate> m_IterationList; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001104")]
	private bool m_HasNewAnimations; //Field offset: 0x38
	[FieldOffset(Offset = "0x39")]
	[Token(Token = "0x4001105")]
	private bool m_IterationListDirty; //Field offset: 0x39
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400110A")]
	private long lastUpdate; //Field offset: 0x40

	[Token(Token = "0x170009B4")]
	public virtual ProfilerMarker profilerMarker
	{
		[Address(RVA = "0x1B71890", Offset = "0x1B70A90", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x600255B")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170009B5")]
	private static ProfilerMarker stylePropertyAnimationProfilerMarker
	{
		[Address(RVA = "0x1B718E0", Offset = "0x1B70AE0", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x600255C")]
		private get { } //Length: 79
	}

	[Address(RVA = "0x1B716A0", Offset = "0x1B708A0", Length = "0x117")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	[Token(Token = "0x6002564")]
	private static VisualElementAnimationSystem() { }

	[Address(RVA = "0x1B717C0", Offset = "0x1B709C0", Length = "0xC3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6002563")]
	public VisualElementAnimationSystem() { }

	[Address(RVA = "0x1B71890", Offset = "0x1B70A90", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600255B")]
	public virtual ProfilerMarker get_profilerMarker() { }

	[Address(RVA = "0x1B718E0", Offset = "0x1B70AE0", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600255C")]
	private static ProfilerMarker get_stylePropertyAnimationProfilerMarker() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002562")]
	public virtual void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	[Address(RVA = "0x1B70FF0", Offset = "0x1B701F0", Length = "0x5A")]
	[CalledBy(Type = typeof(VisualElement), Member = "RegisterAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IValueAnimationUpdate)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600255F")]
	public void RegisterAnimation(IValueAnimationUpdate anim) { }

	[Address(RVA = "0x1B71050", Offset = "0x1B70250", Length = "0x134")]
	[CalledBy(Type = typeof(VisualElement), Member = "HasChangedPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "RegisterRunningAnimations", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6002560")]
	public void RegisterAnimations(List<IValueAnimationUpdate> anims) { }

	[Address(RVA = "0x1B71190", Offset = "0x1B70390", Length = "0x58")]
	[CalledBy(Type = typeof(VisualElement), Member = "UnregisterAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IValueAnimationUpdate)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600255D")]
	public void UnregisterAnimation(IValueAnimationUpdate anim) { }

	[Address(RVA = "0x1B711F0", Offset = "0x1B703F0", Length = "0x132")]
	[CalledBy(Type = typeof(VisualElement), Member = "UnregisterRunningAnimations", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600255E")]
	public void UnregisterAnimations(List<IValueAnimationUpdate> anims) { }

	[Address(RVA = "0x1B71330", Offset = "0x1B70530", Length = "0x36A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Panel), Member = "TimeSinceStartupMs", ReturnType = typeof(long))]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002561")]
	public virtual void Update() { }

}

