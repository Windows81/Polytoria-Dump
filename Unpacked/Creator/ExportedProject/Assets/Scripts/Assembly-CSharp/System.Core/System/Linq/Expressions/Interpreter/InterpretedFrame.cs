namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x200014F")]
internal sealed class InterpretedFrame
{
	[CompilerGenerated]
	[Token(Token = "0x2000150")]
	private sealed class <GetStackTraceDebugInfo>d__29 : IEnumerable<InterpretedFrameInfo>, IEnumerable, IEnumerator<InterpretedFrameInfo>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000284")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000285")]
		private InterpretedFrameInfo <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000286")]
		private int <>l__initialThreadId; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000287")]
		public InterpretedFrame <>4__this; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000288")]
		private InterpretedFrame <frame>5__2; //Field offset: 0x38

		[Token(Token = "0x1700018A")]
		private override InterpretedFrameInfo System.Collections.Generic.IEnumerator<System.Linq.Expressions.Interpreter.InterpretedFrameInfo>.Current
		{
			[Address(RVA = "0x5131D0", Offset = "0x5123D0", Length = "0xB")]
			[CallerCount(Count = 0)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x600070A")]
			private get { } //Length: 11
		}

		[Token(Token = "0x1700018B")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x15CD470", Offset = "0x15CC670", Length = "0x45")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[DebuggerHidden]
			[Token(Token = "0x600070C")]
			private get { } //Length: 69
		}

		[Address(RVA = "0x5D7FB0", Offset = "0x5D71B0", Length = "0x2E")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000707")]
		public <GetStackTraceDebugInfo>d__29(int <>1__state) { }

		[Address(RVA = "0x15CD180", Offset = "0x15CC380", Length = "0x20A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Array), Member = "BinarySearch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", "T", "System.Collections.Generic.IComparer`1<T>"}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000709")]
		private override bool MoveNext() { }

		[Address(RVA = "0x15CD390", Offset = "0x15CC590", Length = "0x9C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x600070D")]
		private override IEnumerator<InterpretedFrameInfo> System.Collections.Generic.IEnumerable<System.Linq.Expressions.Interpreter.InterpretedFrameInfo>.GetEnumerator() { }

		[Address(RVA = "0x5131D0", Offset = "0x5123D0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x600070A")]
		private override InterpretedFrameInfo System.Collections.Generic.IEnumerator<System.Linq.Expressions.Interpreter.InterpretedFrameInfo>.get_Current() { }

		[Address(RVA = "0x15CD390", Offset = "0x15CC590", Length = "0x9C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x600070E")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x15CD470", Offset = "0x15CC670", Length = "0x45")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[DebuggerHidden]
		[Token(Token = "0x600070C")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x15CD430", Offset = "0x15CC630", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x600070B")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000708")]
		private override void System.IDisposable.Dispose() { }

	}

	[ThreadStatic]
	[Token(Token = "0x4000279")]
	private static InterpretedFrame s_currentFrame; //Field offset: 0x80000000
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400027A")]
	internal readonly Interpreter Interpreter; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400027B")]
	internal InterpretedFrame _parent; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400027C")]
	private readonly Int32[] _continuations; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400027D")]
	private int _continuationIndex; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400027E")]
	private int _pendingContinuation; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400027F")]
	private object _pendingValue; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000280")]
	public readonly Object[] Data; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000281")]
	public readonly IStrongBox[] Closure; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000282")]
	public int StackIndex; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000283")]
	public int InstructionIndex; //Field offset: 0x4C

	[Token(Token = "0x17000188")]
	public string Name
	{
		[Address(RVA = "0x15B72C0", Offset = "0x15B64C0", Length = "0x1B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60006EE")]
		 get { } //Length: 27
	}

	[Token(Token = "0x17000189")]
	public InterpretedFrame Parent
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006FA")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x15B71A0", Offset = "0x15B63A0", Length = "0x11F")]
	[CalledBy(Type = typeof(LightLambda), Member = "RunVoid0", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightLambda), Member = "MakeFrame", ReturnType = typeof(InterpretedFrame))]
	[CalledBy(Type = typeof(LightLambda), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(LightLambda), Member = "RunVoid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(object))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60006EC")]
	internal InterpretedFrame(Interpreter interpreter, IStrongBox[] closure) { }

	[Address(RVA = "0x15B6060", Offset = "0x15B5260", Length = "0x9B")]
	[CalledBy(Type = typeof(DupInstruction), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60006F9")]
	public void Dup() { }

	[Address(RVA = "0x15B6100", Offset = "0x15B5300", Length = "0x7C")]
	[CallerCount(Count = 35)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60006FD")]
	internal InterpretedFrame Enter() { }

	[Address(RVA = "0x15B72C0", Offset = "0x15B64C0", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60006EE")]
	public string get_Name() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006FA")]
	public InterpretedFrame get_Parent() { }

	[Address(RVA = "0x15B6180", Offset = "0x15B5380", Length = "0x12B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Array), Member = "BinarySearch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", "T", "System.Collections.Generic.IComparer`1<T>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60006ED")]
	public DebugInfo GetDebugInfo(int instructionIndex) { }

	[Address(RVA = "0x15B62B0", Offset = "0x15B54B0", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[IteratorStateMachine(typeof(<GetStackTraceDebugInfo>d__29))]
	[Token(Token = "0x60006FB")]
	public IEnumerable<InterpretedFrameInfo> GetStackTraceDebugInfo() { }

	[Address(RVA = "0x15B6330", Offset = "0x15B5530", Length = "0x1C3")]
	[CalledBy(Type = typeof(GotoInstruction), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(EnterTryCatchFinallyInstruction), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000706")]
	public int Goto(int labelIndex, object value, bool gotoExceptionHandler) { }

	[Address(RVA = "0x15B6500", Offset = "0x15B5700", Length = "0x9")]
	[CalledBy(Type = typeof(EnterFinallyInstruction), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LeaveFinallyInstruction), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x60006FF")]
	internal bool IsJumpHappened() { }

	[Address(RVA = "0x15B6510", Offset = "0x15B5710", Length = "0x50")]
	[CallerCount(Count = 65)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60006FE")]
	internal void Leave(InterpretedFrame prevFrame) { }

	[Address(RVA = "0x15B6560", Offset = "0x15B5760", Length = "0x2E")]
	[CalledBy(Type = typeof(CoalescingBranchInstruction), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(AssignLocalInstruction), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(AssignLocalBoxedInstruction), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(AssignLocalToClosureInstruction), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(NullCheckInstruction), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.NullableMethodCallInstruction+GetValue", Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.NullableMethodCallInstruction+GetValueOrDefault", Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60006F8")]
	public object Peek() { }

	[Address(RVA = "0x15B6630", Offset = "0x15B5830", Length = "0x36")]
	[CallerCount(Count = 257)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60006F6")]
	public object Pop() { }

	[Address(RVA = "0x15B6590", Offset = "0x15B5790", Length = "0x94")]
	[CalledBy(Type = typeof(LeaveFinallyInstruction), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LeaveFaultInstruction), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000705")]
	internal void PopPendingContinuation() { }

	[Address(RVA = "0x15B6840", Offset = "0x15B5A40", Length = "0x99")]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.OrInstruction+OrInt16", Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.AndInstruction+AndInt16", Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.DecrementInstruction+DecrementInt16", Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.ExclusiveOrInstruction+ExclusiveOrInt16", Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.LeftShiftInstruction+LeftShiftInt16", Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.NegateInstruction+NegateInt16", Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.NegateCheckedInstruction+NegateCheckedInt16", Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.NotInstruction+NotInt16", Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.RightShiftInstruction+RightShiftInt16", Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Token(Token = "0x60006F4")]
	public void Push(short value) { }

	[Address(RVA = "0x15B6980", Offset = "0x15B5B80", Length = "0x98")]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.AndInstruction+AndSByte", Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.ExclusiveOrInstruction+ExclusiveOrSByte", Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.NotInstruction+NotSByte", Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.OrInstruction+OrSByte", Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.RightShiftInstruction+RightShiftSByte", Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60006F3")]
	public void Push(sbyte value) { }

	[Address(RVA = "0x15B67B0", Offset = "0x15B59B0", Length = "0x82")]
	[CallerCount(Count = 108)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60006EF")]
	public void Push(object value) { }

	[Address(RVA = "0x15B68E0", Offset = "0x15B5AE0", Length = "0x98")]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.AndInstruction+AndByte", Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.ExclusiveOrInstruction+ExclusiveOrByte", Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.NotInstruction+NotByte", Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.OrInstruction+OrByte", Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.RightShiftInstruction+RightShiftByte", Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60006F2")]
	public void Push(byte value) { }

	[Address(RVA = "0x15B6BB0", Offset = "0x15B5DB0", Length = "0x99")]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.RightShiftInstruction+RightShiftUInt16", Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.AndInstruction+AndUInt16", Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.DecrementInstruction+DecrementUInt16", Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.ExclusiveOrInstruction+ExclusiveOrUInt16", Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.LeftShiftInstruction+LeftShiftUInt16", Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.NotInstruction+NotUInt16", Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.OrInstruction+OrUInt16", Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Token(Token = "0x60006F5")]
	public void Push(ushort value) { }

	[Address(RVA = "0x15B6AB0", Offset = "0x15B5CB0", Length = "0xFE")]
	[CallerCount(Count = 105)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60006F0")]
	public void Push(bool value) { }

	[Address(RVA = "0x15B6A20", Offset = "0x15B5C20", Length = "0x8F")]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.NotInstruction+NotInt32", Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.NullableMethodCallInstruction+GetHashCodeClass", Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.RightShiftInstruction+RightShiftInt32", Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.OrInstruction+OrInt32", Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.NegateCheckedInstruction+NegateCheckedInt32", Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.LeftShiftInstruction+LeftShiftInt32", Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.NegateInstruction+NegateInt32", Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.ExclusiveOrInstruction+ExclusiveOrInt32", Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.DecrementInstruction+DecrementInt32", Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ArrayLengthInstruction), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.AndInstruction+AndInt32", Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(InterpretedFrame), Member = "PushPendingContinuation", ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(ScriptingRuntimeHelpers), Member = "Int32ToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Token(Token = "0x60006F1")]
	public void Push(int value) { }

	[Address(RVA = "0x15B6670", Offset = "0x15B5870", Length = "0x33")]
	[CalledBy(Type = typeof(EnterTryCatchFinallyInstruction), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(EnterTryFaultInstruction), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000701")]
	public void PushContinuation(int continuation) { }

	[Address(RVA = "0x15B66B0", Offset = "0x15B58B0", Length = "0xFB")]
	[CalledBy(Type = typeof(EnterFinallyInstruction), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(EnterFaultInstruction), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000704")]
	internal void PushPendingContinuation() { }

	[Address(RVA = "0x1006C70", Offset = "0x1005E70", Length = "0x4")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000700")]
	public void RemoveContinuation() { }

	[Address(RVA = "0x15B6C50", Offset = "0x15B5E50", Length = "0x2BF")]
	[CalledBy(Type = typeof(TryCatchFinallyHandler), Member = "HasHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame), typeof(Exception), typeof(ExceptionHandler&), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Linq.Expressions.Interpreter.InterpretedFrameInfo>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Interpreter.InterpretedFrameInfo>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x60006FC")]
	internal void SaveTraceToException(Exception exception) { }

	[Address(RVA = "0x15B6F10", Offset = "0x15B6110", Length = "0x1D")]
	[CalledBy(Type = typeof(EnterFinallyInstruction), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(EnterFaultInstruction), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60006F7")]
	internal void SetStackDepth(int depth) { }

	[Address(RVA = "0x15B6F30", Offset = "0x15B6130", Length = "0x79")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000702")]
	public int YieldToCurrentContinuation() { }

	[Address(RVA = "0x15B6FB0", Offset = "0x15B61B0", Length = "0x1EC")]
	[CalledBy(Type = typeof(LeaveFinallyInstruction), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000703")]
	public int YieldToPendingContinuation() { }

}

