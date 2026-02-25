namespace UnityEngine.UIElements;

[Token(Token = "0x200051C")]
internal class VisualElementFocusChangeTarget : FocusChangeDirection
{
	[CompilerGenerated]
	[Token(Token = "0x200051D")]
	private sealed class <>c
	{
		[Token(Token = "0x40010F0")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x1B67BD0", Offset = "0x1B66DD0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600252C")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600252D")]
		public <>c() { }

		[Address(RVA = "0x1B67980", Offset = "0x1B66B80", Length = "0xC1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(FocusChangeDirection), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FocusChangeDirection)}, ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600252E")]
		internal VisualElementFocusChangeTarget <.cctor>b__9_0() { }

	}

	[Token(Token = "0x40010EE")]
	private static readonly ObjectPool<VisualElementFocusChangeTarget> Pool; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40010EF")]
	private Focusable <target>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x170009AF")]
	public private Focusable target
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002529")]
		 get { } //Length: 5
		[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600252A")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x1B73A60", Offset = "0x1B72C60", Length = "0x107")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ObjectPool`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600252B")]
	private static VisualElementFocusChangeTarget() { }

	[Address(RVA = "0x1B73B70", Offset = "0x1B72D70", Length = "0x95")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FocusChangeDirection), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FocusChangeDirection)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002528")]
	public VisualElementFocusChangeTarget() { }

	[Address(RVA = "0x1B738E0", Offset = "0x1B72AE0", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FocusController), Member = "set_selectedTextElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002527")]
	internal virtual void ApplyTo(FocusController focusController, Focusable f) { }

	[Address(RVA = "0x1B73930", Offset = "0x1B72B30", Length = "0x8B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ObjectPool`1), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002526")]
	protected virtual void Dispose() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002529")]
	public Focusable get_target() { }

	[Address(RVA = "0x1B739C0", Offset = "0x1B72BC0", Length = "0x9B")]
	[CalledBy(Type = typeof(NavigateFocusRing), Member = "GetFocusChangeDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(EventBase)}, ReturnType = typeof(FocusChangeDirection))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ObjectPool`1), Member = "Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002525")]
	public static VisualElementFocusChangeTarget GetPooled(Focusable target) { }

	[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600252A")]
	private void set_target(Focusable value) { }

}

