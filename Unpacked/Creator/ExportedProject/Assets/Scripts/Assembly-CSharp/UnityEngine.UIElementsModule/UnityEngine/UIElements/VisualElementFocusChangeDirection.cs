namespace UnityEngine.UIElements;

[Token(Token = "0x200051B")]
public class VisualElementFocusChangeDirection : FocusChangeDirection
{
	[Token(Token = "0x40010EC")]
	private static readonly VisualElementFocusChangeDirection s_Left; //Field offset: 0x0
	[Token(Token = "0x40010ED")]
	private static readonly VisualElementFocusChangeDirection s_Right; //Field offset: 0x8

	[Token(Token = "0x170009AD")]
	public static FocusChangeDirection left
	{
		[Address(RVA = "0x1B73840", Offset = "0x1B72A40", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6002521")]
		 get { } //Length: 78
	}

	[Token(Token = "0x170009AE")]
	public static FocusChangeDirection right
	{
		[Address(RVA = "0x1B73890", Offset = "0x1B72A90", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6002522")]
		 get { } //Length: 79
	}

	[Address(RVA = "0x1B73600", Offset = "0x1B72800", Length = "0x1D8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FocusChangeDirection), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FocusChangeDirection)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6002524")]
	private static VisualElementFocusChangeDirection() { }

	[Address(RVA = "0x1B737E0", Offset = "0x1B729E0", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002523")]
	protected VisualElementFocusChangeDirection(int value) { }

	[Address(RVA = "0x1B73840", Offset = "0x1B72A40", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6002521")]
	public static FocusChangeDirection get_left() { }

	[Address(RVA = "0x1B73890", Offset = "0x1B72A90", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6002522")]
	public static FocusChangeDirection get_right() { }

}

