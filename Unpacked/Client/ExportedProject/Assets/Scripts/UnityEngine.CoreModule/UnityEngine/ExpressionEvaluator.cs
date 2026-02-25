namespace UnityEngine;

[MovedFrom(True, "UnityEditor", "UnityEditor", null)]
[Token(Token = "0x200008B")]
public class ExpressionEvaluator
{
	[CompilerGenerated]
	[Token(Token = "0x2000091")]
	private sealed class <>c
	{
		[Token(Token = "0x40001BA")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40001BB")]
		public static Func<String, Boolean> <>9__14_0; //Field offset: 0x8

		[Address(RVA = "0x1941A10", Offset = "0x1940C10", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000282")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000283")]
		public <>c() { }

		[Address(RVA = "0x1941910", Offset = "0x1940B10", Length = "0xF9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(ExpressionEvaluator), Member = "TokenToOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "UnityEngine.ExpressionEvaluator+Operator")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000284")]
		internal bool <ExpressionToTokens>b__14_0(string f) { }

	}

	[Token(Token = "0x200008F")]
	private enum Associativity
	{
		Left = 0,
		Right = 1,
	}

	[Token(Token = "0x200008C")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	public class Expression
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400019E")]
		internal readonly String[] rpnTokens; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400019F")]
		internal readonly bool hasVariables; //Field offset: 0x18

		[Address(RVA = "0x1929840", Offset = "0x1928A40", Length = "0x1EE")]
		[CalledBy(Type = typeof(ExpressionEvaluator), Member = "Evaluate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T&", typeof(Expression&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(ExpressionEvaluator), Member = "PreFormatExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ExpressionEvaluator), Member = "ExpressionToTokens", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Boolean&)}, ReturnType = typeof(String[]))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(ExpressionEvaluator), Member = "IsCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ExpressionEvaluator), Member = "InfixToRPN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(String[]))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 3)]
		[Token(Token = "0x6000277")]
		internal Expression(string expression) { }

		[Address(RVA = "0x1929760", Offset = "0x1928960", Length = "0x93")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Enumerable), Member = "SequenceEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(bool))]
		[Token(Token = "0x6000279")]
		public virtual bool Equals(object obj) { }

		[Address(RVA = "0x7CDF40", Offset = "0x7CD140", Length = "0x9E")]
		[CalledBy(Type = typeof(UINumericFieldsUtils), Member = "TryConvertStringToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Double&), typeof(Expression&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UINumericFieldsUtils), Member = "TryConvertStringToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Single&), typeof(Expression&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UINumericFieldsUtils), Member = "TryConvertStringToLong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Int64&), typeof(Expression&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UINumericFieldsUtils), Member = "TryConvertStringToULong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(UInt64&), typeof(Expression&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(ExpressionEvaluator), Member = "EvaluateTokens", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), "T&", typeof(int), typeof(int)}, ReturnType = typeof(bool))]
		[DeduplicatedMethod]
		[Token(Token = "0x6000278")]
		public bool Evaluate(ref T value, int index = 0, int count = 1) { }

		[Address(RVA = "0x300BF0", Offset = "0x2FFDF0", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600027A")]
		public virtual int GetHashCode() { }

		[Address(RVA = "0x1929800", Offset = "0x1928A00", Length = "0x3D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(string), Member = "Join", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
		[Token(Token = "0x600027B")]
		public virtual string ToString() { }

	}

	[Token(Token = "0x200008E")]
	private enum Op
	{
		Add = 0,
		Sub = 1,
		Mul = 2,
		Div = 3,
		Mod = 4,
		Neg = 5,
		Pow = 6,
		Sqrt = 7,
		Sin = 8,
		Cos = 9,
		Tan = 10,
		Floor = 11,
		Ceil = 12,
		Round = 13,
		Rand = 14,
		Linear = 15,
	}

	[Token(Token = "0x2000090")]
	private class Operator
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001B6")]
		public readonly Op op; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x40001B7")]
		public readonly int precedence; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40001B8")]
		public readonly Associativity associativity; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x40001B9")]
		public readonly int inputs; //Field offset: 0x1C

		[Address(RVA = "0x19393E0", Offset = "0x19385E0", Length = "0x4B")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000281")]
		public Operator(Op op, int precedence, int inputs, Associativity associativity) { }

	}

	[Token(Token = "0x200008D")]
	private struct PcgRandom
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001A0")]
		private readonly ulong increment; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40001A1")]
		private ulong state; //Field offset: 0x8

		[Address(RVA = "0x19394D0", Offset = "0x19386D0", Length = "0x24")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600027C")]
		public PcgRandom(ulong state = 0, ulong sequence = 0) { }

		[Address(RVA = "0x1939430", Offset = "0x1938630", Length = "0x45")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600027D")]
		public uint GetUInt() { }

		[Address(RVA = "0x10BD170", Offset = "0x10BC370", Length = "0x19")]
		[CallerCount(Count = 20)]
		[DeduplicatedMethod]
		[Token(Token = "0x600027E")]
		private static uint RotateRight(uint v, int rot) { }

		[Address(RVA = "0x1939480", Offset = "0x1938680", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000280")]
		private void Step() { }

		[Address(RVA = "0x19394A0", Offset = "0x19386A0", Length = "0x27")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600027F")]
		private static uint XshRr(ulong s) { }

	}

	[Token(Token = "0x400019C")]
	private static PcgRandom s_Random; //Field offset: 0x0
	[Token(Token = "0x400019D")]
	private static Dictionary<String, Operator> s_Operators; //Field offset: 0x10

	[Address(RVA = "0x1929120", Offset = "0x1928320", Length = "0x638")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 16)]
	[Token(Token = "0x6000276")]
	private static ExpressionEvaluator() { }

	[Address(RVA = "0x6AFB20", Offset = "0x6AED20", Length = "0x12F")]
	[CalledBy(Type = typeof(UINumericFieldsUtils), Member = "TryConvertStringToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Double&), typeof(Expression&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UINumericFieldsUtils), Member = "TryConvertStringToLong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int64&), typeof(Expression&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UINumericFieldsUtils), Member = "TryConvertStringToLong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Int64&), typeof(Expression&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UINumericFieldsUtils), Member = "TryConvertStringToULong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UInt64&), typeof(Expression&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UINumericFieldsUtils), Member = "TryConvertStringToULong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(UInt64&), typeof(Expression&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Expression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ExpressionEvaluator), Member = "TryParse", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ExpressionEvaluator), Member = "EvaluateTokens", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), "T&", typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000267")]
	internal static bool Evaluate(string expression, out T value, out Expression delayed) { }

	[Address(RVA = "0x1927960", Offset = "0x1926B60", Length = "0x4F4")]
	[CalledBy(Type = typeof(ExpressionEvaluator), Member = "EvaluateTokens", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), "T&", typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(double), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Double>), Member = "Reverse", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180030460")]
	[Calls(Type = typeof(ExpressionEvaluator), Member = "TryParse", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Pop", ReturnType = typeof(object))]
	[Calls(Type = typeof(ExpressionEvaluator), Member = "IsCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Stack`1), Member = "Peek", ReturnType = "T")]
	[Calls(Type = typeof(ExpressionEvaluator), Member = "TokenToOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Operator))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(ExpressionEvaluator), Member = "IsOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Stack`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(ExpressionEvaluator), Member = "EvaluateOp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Double[]), typeof(Op), typeof(int), typeof(int)}, ReturnType = typeof(double))]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000269")]
	private static bool EvaluateDouble(String[] tokens, ref double value, int index, int count) { }

	[Address(RVA = "0x1927E60", Offset = "0x1927060", Length = "0x34C")]
	[CalledBy(Type = typeof(ExpressionEvaluator), Member = "EvaluateDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(Double&), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AEB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028F9E0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Pow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028CBC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028BE30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028D560")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802897E0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802891B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F70")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000274")]
	private static double EvaluateOp(Double[] values, Op op, int index, int count) { }

	[Address(RVA = "0x6AEE80", Offset = "0x6AE080", Length = "0x3DA")]
	[CalledBy(Type = typeof(Expression), Member = "Evaluate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ExpressionEvaluator), Member = "Evaluate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T&", typeof(Expression&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ExpressionEvaluator), Member = "EvaluateDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(Double&), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180003B10")]
	[CallsDeduplicatedMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000268")]
	private static bool EvaluateTokens(String[] tokens, ref T value, int index, int count) { }

	[Address(RVA = "0x19281F0", Offset = "0x19273F0", Length = "0x3E3")]
	[CalledBy(Type = typeof(Expression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Func`2<System.Object, System.Boolean>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Func`2<System.Object, System.Boolean>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(ExpressionEvaluator), Member = "IsOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x600026C")]
	private static String[] ExpressionToTokens(string expression, out bool hasVariables) { }

	[Address(RVA = "0x19285E0", Offset = "0x19277E0", Length = "0x173")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ExpressionEvaluator), Member = "IsCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000273")]
	private static String[] FixUnaryOperators(String[] tokens) { }

	[Address(RVA = "0x1928760", Offset = "0x1927960", Length = "0x4BA")]
	[CalledBy(Type = typeof(Expression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExpressionEvaluator), Member = "IsDelayedFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Stack`1), Member = "Peek", ReturnType = "T")]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Pop", ReturnType = typeof(object))]
	[Calls(Type = typeof(ExpressionEvaluator), Member = "NeedToPop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.Stack`1<System.String>), typeof(Operator)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ExpressionEvaluator), Member = "TokenToOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Operator))]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.Object>), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExpressionEvaluator), Member = "IsOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.Object>), Member = "ToArray", ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Stack`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600026A")]
	private static String[] InfixToRPN(String[] tokens) { }

	[Address(RVA = "0x1928C20", Offset = "0x1927E20", Length = "0x7E")]
	[CalledBy(Type = typeof(Expression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExpressionEvaluator), Member = "EvaluateDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(Double&), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ExpressionEvaluator), Member = "FixUnaryOperators", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(String[]))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ExpressionEvaluator), Member = "IsOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600026D")]
	private static bool IsCommand(string token) { }

	[Address(RVA = "0x1928CA0", Offset = "0x1927EA0", Length = "0x65")]
	[CalledBy(Type = typeof(ExpressionEvaluator), Member = "InfixToRPN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(String[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ExpressionEvaluator), Member = "TokenToOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Operator))]
	[Token(Token = "0x600026F")]
	private static bool IsDelayedFunction(string token) { }

	[Address(RVA = "0x1928D10", Offset = "0x1927F10", Length = "0x79")]
	[CalledBy(Type = typeof(ExpressionEvaluator), Member = "EvaluateDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(Double&), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ExpressionEvaluator), Member = "InfixToRPN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(ExpressionEvaluator), Member = "ExpressionToTokens", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Boolean&)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(ExpressionEvaluator), Member = "IsCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ExpressionEvaluator), Member = "PreFormatExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000270")]
	private static bool IsOperator(string token) { }

	[Address(RVA = "0x1928D90", Offset = "0x1927F90", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600026E")]
	private static bool IsVariable(string token) { }

	[Address(RVA = "0x1928DF0", Offset = "0x1927FF0", Length = "0xD6")]
	[CalledBy(Type = typeof(ExpressionEvaluator), Member = "InfixToRPN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(String[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Stack`1), Member = "Peek", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ExpressionEvaluator), Member = "TokenToOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Operator))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600026B")]
	private static bool NeedToPop(Stack<String> operatorStack, Operator newOperator) { }

	[Address(RVA = "0x1928ED0", Offset = "0x19280D0", Length = "0x1A9")]
	[CalledBy(Type = typeof(Expression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ExpressionEvaluator), Member = "IsOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "TrimEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000272")]
	private static string PreFormatExpression(string expression) { }

	[Address(RVA = "0x1929080", Offset = "0x1928280", Length = "0x99")]
	[CalledBy(Type = typeof(<>c), Member = "<ExpressionToTokens>b__14_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ExpressionEvaluator), Member = "EvaluateDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(Double&), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ExpressionEvaluator), Member = "InfixToRPN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(ExpressionEvaluator), Member = "NeedToPop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.Stack`1<System.String>), typeof(Operator)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ExpressionEvaluator), Member = "IsDelayedFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000271")]
	private static Operator TokenToOperator(string token) { }

	[Address(RVA = "0x6AFEE0", Offset = "0x6AF0E0", Length = "0x7DD")]
	[CalledBy(Type = typeof(ExpressionEvaluator), Member = "Evaluate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T&", typeof(Expression&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ExpressionEvaluator), Member = "EvaluateDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(Double&), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(double), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(Double&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(long), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(Int64&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(ulong), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(UInt64&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "TrimEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(float), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(Single&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(char), Member = "IsDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "ToLowerInvariant", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000275")]
	private static bool TryParse(string expression, out T result) { }

}

