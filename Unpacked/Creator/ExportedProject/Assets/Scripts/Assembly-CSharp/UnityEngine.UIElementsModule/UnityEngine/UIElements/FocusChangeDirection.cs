namespace UnityEngine.UIElements;

[Token(Token = "0x200024E")]
public class FocusChangeDirection : IDisposable
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x40008F4")]
	private static readonly FocusChangeDirection <unspecified>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x40008F5")]
	private static readonly FocusChangeDirection <none>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x40008F6")]
	private static readonly FocusChangeDirection <lastValue>k__BackingField; //Field offset: 0x10
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40008F7")]
	private readonly int m_Value; //Field offset: 0x10

	[Token(Token = "0x170002EC")]
	protected static FocusChangeDirection lastValue
	{
		[Address(RVA = "0x1C66700", Offset = "0x1C65900", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[Token(Token = "0x6000FDD")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170002EB")]
	public static FocusChangeDirection none
	{
		[Address(RVA = "0x1C66750", Offset = "0x1C65950", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[Token(Token = "0x6000FDC")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170002EA")]
	public static FocusChangeDirection unspecified
	{
		[Address(RVA = "0x1C667A0", Offset = "0x1C659A0", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[Token(Token = "0x6000FDB")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x1C665E0", Offset = "0x1C657E0", Length = "0x118")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000FE3")]
	private static FocusChangeDirection() { }

	[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
	[CallerCount(Count = 68)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FDE")]
	protected FocusChangeDirection(int value) { }

	[Address(RVA = "0x1C665A0", Offset = "0x1C657A0", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FocusController), Member = "SwitchFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(FocusChangeDirection), typeof(bool), typeof(DispatchMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000FE2")]
	internal override void ApplyTo(FocusController focusController, Focusable f) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FE1")]
	protected override void Dispose() { }

	[Address(RVA = "0x1C66700", Offset = "0x1C65900", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[Token(Token = "0x6000FDD")]
	protected static FocusChangeDirection get_lastValue() { }

	[Address(RVA = "0x1C66750", Offset = "0x1C65950", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[Token(Token = "0x6000FDC")]
	public static FocusChangeDirection get_none() { }

	[Address(RVA = "0x1C667A0", Offset = "0x1C659A0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[Token(Token = "0x6000FDB")]
	public static FocusChangeDirection get_unspecified() { }

	[Address(RVA = "0x1C667F0", Offset = "0x1C659F0", Length = "0xC")]
	[CalledBy(Type = typeof(VisualElementFocusChangeDirection), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElementFocusChangeTarget+<>c", Member = "<.cctor>b__9_0", ReturnType = typeof(VisualElementFocusChangeTarget))]
	[CalledBy(Type = typeof(VisualElementFocusChangeTarget), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Token(Token = "0x6000FDF")]
	public static int op_Implicit(FocusChangeDirection fcd) { }

	[Address(RVA = "0x16B6350", Offset = "0x16B5550", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FE0")]
	private override void System.IDisposable.Dispose() { }

}

