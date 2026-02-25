namespace System.Linq.Expressions.Interpreter;

[DebuggerTypeProxy(typeof(DebugView))]
[IsReadOnly]
[Token(Token = "0x200014A")]
internal struct InstructionArray
{
	[Token(Token = "0x200014B")]
	public sealed class DebugView
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400025A")]
		private readonly InstructionArray _array; //Field offset: 0x10

		[Address(RVA = "0x15AD650", Offset = "0x15AC850", Length = "0xB0")]
		[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightLambda+DebugViewPrinter", Member = "ToString", ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000674")]
		public DebugView(InstructionArray array) { }

		[Address(RVA = "0x15AD620", Offset = "0x15AC820", Length = "0x2F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CompilerGenerated]
		[Token(Token = "0x6000676")]
		private int <GetInstructionViews>b__4_0(int index) { }

		[Address(RVA = "0x15AD560", Offset = "0x15AC760", Length = "0xB4")]
		[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightLambda+DebugViewPrinter", Member = "ToString", ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DebugView), Member = "GetInstructionViews", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IReadOnlyList`1<System.Linq.Expressions.Interpreter.Instruction>), typeof(System.Collections.Generic.IReadOnlyList`1<System.Object>), typeof(System.Func`2<System.Int32, System.Int32>), typeof(System.Collections.Generic.IReadOnlyList`1<System.Collections.Generic.KeyValuePair`2<System.Int32, System.Object>>)}, ReturnType = typeof(InstructionView[]))]
		[Token(Token = "0x6000675")]
		public InstructionView[] GetInstructionViews(bool includeDebugCookies = false) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000254")]
	internal readonly int MaxStackDepth; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000255")]
	internal readonly int MaxContinuationDepth; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000256")]
	internal readonly Instruction[] Instructions; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000257")]
	internal readonly Object[] Objects; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000258")]
	internal readonly RuntimeLabel[] Labels; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000259")]
	internal readonly List<KeyValuePair`2<Int32, Object>> DebugCookies; //Field offset: 0x20

	[Address(RVA = "0x15B1200", Offset = "0x15B0400", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000673")]
	internal InstructionArray(int maxStackDepth, int maxContinuationDepth, Instruction[] instructions, Object[] objects, RuntimeLabel[] labels, List<KeyValuePair`2<Int32, Object>> debugCookies) { }

}

