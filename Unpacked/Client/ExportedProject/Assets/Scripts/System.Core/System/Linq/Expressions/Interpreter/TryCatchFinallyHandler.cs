namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x2000179")]
internal sealed class TryCatchFinallyHandler
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002E3")]
	internal readonly int TryStartIndex; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40002E4")]
	internal readonly int TryEndIndex; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002E5")]
	internal readonly int FinallyStartIndex; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40002E6")]
	internal readonly int FinallyEndIndex; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002E7")]
	internal readonly int GotoEndTargetIndex; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002E8")]
	private readonly ExceptionHandler[] _handlers; //Field offset: 0x28

	[Token(Token = "0x1700019E")]
	internal ExceptionHandler[] Handlers
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x600077C")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x1700019F")]
	internal bool IsCatchBlockExist
	{
		[Address(RVA = "0x3BD770", Offset = "0x3BC970", Length = "0x9")]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x600077D")]
		internal get { } //Length: 9
	}

	[Token(Token = "0x1700019D")]
	internal bool IsFinallyBlockExist
	{
		[Address(RVA = "0x15CD120", Offset = "0x15CC320", Length = "0xB")]
		[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController+<GetAllItemIds>d__23", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController+<GetChildrenIds>d__25", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController+<GetChildrenIdsByIndex>d__41", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Linq.Enumerable+<RangeIterator>d__115", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightLambda+DebugViewPrinter", Member = "Analyze", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.InputForUI.KeyEvent+ButtonsState+<GetAllPressed>d__8", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600077B")]
		internal get { } //Length: 11
	}

	[Address(RVA = "0x15CD0B0", Offset = "0x15CC2B0", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600077E")]
	internal TryCatchFinallyHandler(int tryStart, int tryEnd, int gotoEndTargetIndex, ExceptionHandler[] handlers) { }

	[Address(RVA = "0x15CD040", Offset = "0x15CC240", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600077F")]
	internal TryCatchFinallyHandler(int tryStart, int tryEnd, int gotoEndLabelIndex, int finallyStart, int finallyEnd, ExceptionHandler[] handlers) { }

	[Address(RVA = "0x15CCC60", Offset = "0x15CBE60", Length = "0x24B")]
	[CalledBy(Type = typeof(TryCatchFinallyHandler), Member = "HasHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame), typeof(Exception), typeof(ExceptionHandler&), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000781")]
	private static bool FilterPasses(InterpretedFrame frame, ref object exception, ExceptionFilter filter) { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x600077C")]
	internal ExceptionHandler[] get_Handlers() { }

	[Address(RVA = "0x3BD770", Offset = "0x3BC970", Length = "0x9")]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600077D")]
	internal bool get_IsCatchBlockExist() { }

	[Address(RVA = "0x15CD120", Offset = "0x15CC320", Length = "0xB")]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController+<GetAllItemIds>d__23", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController+<GetChildrenIds>d__25", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController+<GetChildrenIdsByIndex>d__41", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Linq.Enumerable+<RangeIterator>d__115", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightLambda+DebugViewPrinter", Member = "Analyze", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputForUI.KeyEvent+ButtonsState+<GetAllPressed>d__8", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600077B")]
	internal bool get_IsFinallyBlockExist() { }

	[Address(RVA = "0x15CCEB0", Offset = "0x15CC0B0", Length = "0x185")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(InterpretedFrame), Member = "SaveTraceToException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(TryCatchFinallyHandler), Member = "FilterPasses", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame), typeof(Object&), typeof(ExceptionFilter)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000780")]
	internal bool HasHandler(InterpretedFrame frame, Exception exception, out ExceptionHandler handler, out object unwrappedException) { }

}

