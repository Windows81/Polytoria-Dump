namespace System.Runtime.CompilerServices;

[Token(Token = "0x20004A3")]
public static class RuntimeHelpers
{

	[Token(Token = "0x17000410")]
	public static int OffsetToStringData
	{
		[Address(RVA = "0x13C7A20", Offset = "0x13C6C20", Length = "0x5")]
		[CallerCount(Count = 273)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020D3F0")]
		[Token(Token = "0x60020C2")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x13C7940", Offset = "0x13C6B40", Length = "0x54")]
	[CalledBy(Type = "UnityEngine.TextCore.RichTextTagParser+TagTypeInfo", Member = "PrintMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.TextCore.RichTextTagParser+ParseError", Member = "PrintMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180083170")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InsufficientExecutionStackException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x60020C6")]
	public static void EnsureSufficientExecutionStack() { }

	[Address(RVA = "0x13C7A20", Offset = "0x13C6C20", Length = "0x5")]
	[CallerCount(Count = 273)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020D3F0")]
	[Token(Token = "0x60020C2")]
	public static int get_OffsetToStringData() { }

	[Address(RVA = "0x2D8E50", Offset = "0x2D8050", Length = "0x7")]
	[CallerCount(Count = 10)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60020C3")]
	public static int GetHashCode(object o) { }

	[Address(RVA = "0x13C79A0", Offset = "0x13C6BA0", Length = "0x5")]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.ValueTypeCopyInstruction", Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Interpreter.InterpretedFrame"}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020D2E0")]
	[Token(Token = "0x60020C4")]
	public static object GetObjectValue(object obj) { }

	[Address(RVA = "0x13C7A10", Offset = "0x13C6C10", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020D300")]
	[Token(Token = "0x60020C0")]
	private static void InitializeArray(Array array, IntPtr fldHandle) { }

	[Address(RVA = "0x13C79B0", Offset = "0x13C6BB0", Length = "0x59")]
	[CallerCount(Count = 485)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020D300")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60020C1")]
	public static void InitializeArray(Array array, RuntimeFieldHandle fldHandle) { }

	[Address(RVA = "0x758040", Offset = "0x757240", Length = "0xFD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = "HasReferences", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60020C9")]
	public static bool IsReferenceOrContainsReferences() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	[Token(Token = "0x60020C8")]
	public static void PrepareConstrainedRegions() { }

	[Address(RVA = "0x13B9D60", Offset = "0x13B8F60", Length = "0x5")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180083170")]
	[DeduplicatedMethod]
	[Token(Token = "0x60020C5")]
	private static bool SufficientExecutionStack() { }

	[Address(RVA = "0x13B9D60", Offset = "0x13B8F60", Length = "0x5")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180083170")]
	[DeduplicatedMethod]
	[Token(Token = "0x60020C7")]
	public static bool TryEnsureSufficientExecutionStack() { }

}

