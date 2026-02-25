namespace MoonSharp.Interpreter.CoreLib;

[MoonSharpModule(Namespace = "math")]
[Token(Token = "0x200017D")]
public class MathModule
{
	[CompilerGenerated]
	[Token(Token = "0x200017E")]
	private sealed class <>c
	{
		[Token(Token = "0x40005EA")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40005EB")]
		public static Func<Double, Double> <>9__9_0; //Field offset: 0x8
		[Token(Token = "0x40005EC")]
		public static Func<Double, Double> <>9__10_0; //Field offset: 0x10
		[Token(Token = "0x40005ED")]
		public static Func<Double, Double> <>9__11_0; //Field offset: 0x18
		[Token(Token = "0x40005EE")]
		public static Func<Double, Double> <>9__12_0; //Field offset: 0x20
		[Token(Token = "0x40005EF")]
		public static Func<Double, Double, Double> <>9__13_0; //Field offset: 0x28
		[Token(Token = "0x40005F0")]
		public static Func<Double, Double> <>9__14_0; //Field offset: 0x30
		[Token(Token = "0x40005F1")]
		public static Func<Double, Double> <>9__15_0; //Field offset: 0x38
		[Token(Token = "0x40005F2")]
		public static Func<Double, Double> <>9__16_0; //Field offset: 0x40
		[Token(Token = "0x40005F3")]
		public static Func<Double, Double> <>9__17_0; //Field offset: 0x48
		[Token(Token = "0x40005F4")]
		public static Func<Double, Double> <>9__18_0; //Field offset: 0x50
		[Token(Token = "0x40005F5")]
		public static Func<Double, Double> <>9__19_0; //Field offset: 0x58
		[Token(Token = "0x40005F6")]
		public static Func<Double, Double, Double> <>9__20_0; //Field offset: 0x60
		[Token(Token = "0x40005F7")]
		public static Func<Double, Double, Double> <>9__22_0; //Field offset: 0x68
		[Token(Token = "0x40005F8")]
		public static Func<Double, Double, Double> <>9__23_0; //Field offset: 0x70
		[Token(Token = "0x40005F9")]
		public static Func<Double, Double, Double> <>9__24_0; //Field offset: 0x78
		[Token(Token = "0x40005FA")]
		public static Func<Double, Double, Double> <>9__25_0; //Field offset: 0x80
		[Token(Token = "0x40005FB")]
		public static Func<Double, Double, Double> <>9__27_0; //Field offset: 0x88
		[Token(Token = "0x40005FC")]
		public static Func<Double, Double> <>9__28_0; //Field offset: 0x90
		[Token(Token = "0x40005FD")]
		public static Func<Double, Double> <>9__31_0; //Field offset: 0x98
		[Token(Token = "0x40005FE")]
		public static Func<Double, Double> <>9__32_0; //Field offset: 0xA0
		[Token(Token = "0x40005FF")]
		public static Func<Double, Double> <>9__33_0; //Field offset: 0xA8
		[Token(Token = "0x4000600")]
		public static Func<Double, Double> <>9__34_0; //Field offset: 0xB0
		[Token(Token = "0x4000601")]
		public static Func<Double, Double> <>9__35_0; //Field offset: 0xB8

		[Address(RVA = "0x38D760", Offset = "0x38C960", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000E27")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E28")]
		public <>c() { }

		[Address(RVA = "0x38CDA0", Offset = "0x38BFA0", Length = "0x51")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000E29")]
		internal double <abs>b__9_0(double d) { }

		[Address(RVA = "0x38CE00", Offset = "0x38C000", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028B010")]
		[Token(Token = "0x6000E2A")]
		internal double <acos>b__10_0(double d) { }

		[Address(RVA = "0x38CE50", Offset = "0x38C050", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028B2D0")]
		[Token(Token = "0x6000E2B")]
		internal double <asin>b__11_0(double d) { }

		[Address(RVA = "0x38CF00", Offset = "0x38C100", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028B560")]
		[Token(Token = "0x6000E2C")]
		internal double <atan>b__12_0(double d) { }

		[Address(RVA = "0x38CEA0", Offset = "0x38C0A0", Length = "0x5E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028B7B0")]
		[Token(Token = "0x6000E2D")]
		internal double <atan2>b__13_0(double d1, double d2) { }

		[Address(RVA = "0x38CFA0", Offset = "0x38C1A0", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802891B0")]
		[Token(Token = "0x6000E2E")]
		internal double <ceil>b__14_0(double d) { }

		[Address(RVA = "0x38CFF0", Offset = "0x38C1F0", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028BE30")]
		[Token(Token = "0x6000E2F")]
		internal double <cos>b__15_0(double d) { }

		[Address(RVA = "0x38D040", Offset = "0x38C240", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028C3B0")]
		[Token(Token = "0x6000E30")]
		internal double <cosh>b__16_0(double d) { }

		[Address(RVA = "0x38D090", Offset = "0x38C290", Length = "0x14")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000E31")]
		internal double <deg>b__17_0(double d) { }

		[Address(RVA = "0x38D0B0", Offset = "0x38C2B0", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028C7A0")]
		[Token(Token = "0x6000E32")]
		internal double <exp>b__18_0(double d) { }

		[Address(RVA = "0x38D100", Offset = "0x38C300", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802897E0")]
		[Token(Token = "0x6000E33")]
		internal double <floor>b__19_0(double d) { }

		[Address(RVA = "0x38D150", Offset = "0x38C350", Length = "0x61")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Math), Member = "IEEERemainder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
		[Token(Token = "0x6000E34")]
		internal double <fmod>b__20_0(double d1, double d2) { }

		[Address(RVA = "0x38D1C0", Offset = "0x38C3C0", Length = "0x6B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Math), Member = "Pow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000E35")]
		internal double <ldexp>b__22_0(double d1, double d2) { }

		[Address(RVA = "0x38D230", Offset = "0x38C430", Length = "0x61")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Math), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
		[Token(Token = "0x6000E36")]
		internal double <log>b__23_0(double d1, double d2) { }

		[Address(RVA = "0x38D2A0", Offset = "0x38C4A0", Length = "0x61")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
		[Token(Token = "0x6000E37")]
		internal double <max>b__24_0(double d1, double d2) { }

		[Address(RVA = "0x38D310", Offset = "0x38C510", Length = "0x61")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
		[Token(Token = "0x6000E38")]
		internal double <min>b__25_0(double d1, double d2) { }

		[Address(RVA = "0x38D380", Offset = "0x38C580", Length = "0x61")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Math), Member = "Pow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
		[Token(Token = "0x6000E39")]
		internal double <pow>b__27_0(double d1, double d2) { }

		[Address(RVA = "0x38D3F0", Offset = "0x38C5F0", Length = "0x14")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000E3A")]
		internal double <rad>b__28_0(double d) { }

		[Address(RVA = "0x38D410", Offset = "0x38C610", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028CBC0")]
		[Token(Token = "0x6000E3B")]
		internal double <sin>b__31_0(double d) { }

		[Address(RVA = "0x38D460", Offset = "0x38C660", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028D130")]
		[Token(Token = "0x6000E3C")]
		internal double <sinh>b__32_0(double d) { }

		[Address(RVA = "0x38D4B0", Offset = "0x38C6B0", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AEB0")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000E3D")]
		internal double <sqrt>b__33_0(double d) { }

		[Address(RVA = "0x38D520", Offset = "0x38C720", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028D560")]
		[Token(Token = "0x6000E3E")]
		internal double <tan>b__34_0(double d) { }

		[Address(RVA = "0x38D570", Offset = "0x38C770", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028DD00")]
		[Token(Token = "0x6000E3F")]
		internal double <tanh>b__35_0(double d) { }

	}

	[MoonSharpModuleConstant]
	[Token(Token = "0x40005E8")]
	public const double pi = 3.141592653589793; //Field offset: 0x0
	[MoonSharpModuleConstant]
	[Token(Token = "0x40005E9")]
	public const double huge = 1.7976931348623157E+308; //Field offset: 0x0

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E26")]
	public MathModule() { }

	[Address(RVA = "0x381460", Offset = "0x380660", Length = "0x19C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CallbackArguments), Member = "AsType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(DataType), typeof(bool)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "NewNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[MoonSharpModuleMethod]
	[Token(Token = "0x6000E0B")]
	public static DynValue abs(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[Address(RVA = "0x381600", Offset = "0x380800", Length = "0x19C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CallbackArguments), Member = "AsType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(DataType), typeof(bool)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "NewNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[MoonSharpModuleMethod]
	[Token(Token = "0x6000E0C")]
	public static DynValue acos(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[Address(RVA = "0x3817A0", Offset = "0x3809A0", Length = "0x19C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CallbackArguments), Member = "AsType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(DataType), typeof(bool)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "NewNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[MoonSharpModuleMethod]
	[Token(Token = "0x6000E0D")]
	public static DynValue asin(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[Address(RVA = "0x381A60", Offset = "0x380C60", Length = "0x19C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CallbackArguments), Member = "AsType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(DataType), typeof(bool)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "NewNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[MoonSharpModuleMethod]
	[Token(Token = "0x6000E0E")]
	public static DynValue atan(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[Address(RVA = "0x381940", Offset = "0x380B40", Length = "0x11D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Func`3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MathModule), Member = "exec2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackArguments), typeof(string), typeof(System.Func`3<System.Double, System.Double, System.Double>)}, ReturnType = typeof(DynValue))]
	[MoonSharpModuleMethod]
	[Token(Token = "0x6000E0F")]
	public static DynValue atan2(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[Address(RVA = "0x381C00", Offset = "0x380E00", Length = "0x19C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CallbackArguments), Member = "AsType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(DataType), typeof(bool)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "NewNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[MoonSharpModuleMethod]
	[Token(Token = "0x6000E10")]
	public static DynValue ceil(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[Address(RVA = "0x381DA0", Offset = "0x380FA0", Length = "0x19C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CallbackArguments), Member = "AsType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(DataType), typeof(bool)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "NewNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[MoonSharpModuleMethod]
	[Token(Token = "0x6000E11")]
	public static DynValue cos(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[Address(RVA = "0x381F40", Offset = "0x381140", Length = "0x19C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CallbackArguments), Member = "AsType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(DataType), typeof(bool)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "NewNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[MoonSharpModuleMethod]
	[Token(Token = "0x6000E12")]
	public static DynValue cosh(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[Address(RVA = "0x3820E0", Offset = "0x3812E0", Length = "0x19C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CallbackArguments), Member = "AsType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(DataType), typeof(bool)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "NewNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[MoonSharpModuleMethod]
	[Token(Token = "0x6000E13")]
	public static DynValue deg(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[Address(RVA = "0x382280", Offset = "0x381480", Length = "0xB7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CallbackArguments), Member = "AsType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(DataType), typeof(bool)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DynValue), Member = "NewNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000E07")]
	private static DynValue exec1(CallbackArguments args, string funcName, Func<Double, Double> func) { }

	[Address(RVA = "0x382340", Offset = "0x381540", Length = "0xF6")]
	[CalledBy(Type = typeof(MathModule), Member = "atan2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(MathModule), Member = "fmod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(MathModule), Member = "ldexp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(MathModule), Member = "pow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CallbackArguments), Member = "AsType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(DataType), typeof(bool)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DynValue), Member = "NewNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000E08")]
	private static DynValue exec2(CallbackArguments args, string funcName, Func<Double, Double, Double> func) { }

	[Address(RVA = "0x382440", Offset = "0x381640", Length = "0x11A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CallbackArguments), Member = "AsType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(DataType), typeof(bool)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "IsNil", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DynValue), Member = "NewNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000E09")]
	private static DynValue exec2n(CallbackArguments args, string funcName, double defVal, Func<Double, Double, Double> func) { }

	[Address(RVA = "0x382560", Offset = "0x381760", Length = "0x196")]
	[CalledBy(Type = typeof(MathModule), Member = "max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(MathModule), Member = "min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(DynValue), Member = "NewNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackArguments), Member = "AsType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(DataType), typeof(bool)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000E0A")]
	private static DynValue execaccum(CallbackArguments args, string funcName, Func<Double, Double, Double> func) { }

	[Address(RVA = "0x382700", Offset = "0x381900", Length = "0x19C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CallbackArguments), Member = "AsType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(DataType), typeof(bool)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "NewNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[MoonSharpModuleMethod]
	[Token(Token = "0x6000E14")]
	public static DynValue exp(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[Address(RVA = "0x3828A0", Offset = "0x381AA0", Length = "0x19C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CallbackArguments), Member = "AsType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(DataType), typeof(bool)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "NewNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[MoonSharpModuleMethod]
	[Token(Token = "0x6000E15")]
	public static DynValue floor(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[Address(RVA = "0x382A40", Offset = "0x381C40", Length = "0x11D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Func`3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MathModule), Member = "exec2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackArguments), typeof(string), typeof(System.Func`3<System.Double, System.Double, System.Double>)}, ReturnType = typeof(DynValue))]
	[MoonSharpModuleMethod]
	[Token(Token = "0x6000E16")]
	public static DynValue fmod(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[Address(RVA = "0x382B60", Offset = "0x381D60", Length = "0x217")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CallbackArguments), Member = "AsType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(DataType), typeof(bool)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DynValue), Member = "NewNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(DynValue), Member = "NewTuple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue[])}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[MoonSharpModuleMethod]
	[Token(Token = "0x6000E17")]
	public static DynValue frexp(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[Address(RVA = "0x381230", Offset = "0x380430", Length = "0xE0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Table), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "get_UserData", ReturnType = typeof(UserData))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000E04")]
	private static Random GetRandom(Script s) { }

	[Address(RVA = "0x382D80", Offset = "0x381F80", Length = "0x11D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Func`3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MathModule), Member = "exec2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackArguments), typeof(string), typeof(System.Func`3<System.Double, System.Double, System.Double>)}, ReturnType = typeof(DynValue))]
	[MoonSharpModuleMethod]
	[Token(Token = "0x6000E18")]
	public static DynValue ldexp(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[Address(RVA = "0x382EA0", Offset = "0x3820A0", Length = "0x1F3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Func`3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CallbackArguments), Member = "AsType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(DataType), typeof(bool)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "IsNil", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DynValue), Member = "NewNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[MoonSharpModuleMethod]
	[Token(Token = "0x6000E19")]
	public static DynValue log(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[Address(RVA = "0x3830A0", Offset = "0x3822A0", Length = "0x11D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Func`3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MathModule), Member = "execaccum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackArguments), typeof(string), typeof(System.Func`3<System.Double, System.Double, System.Double>)}, ReturnType = typeof(DynValue))]
	[MoonSharpModuleMethod]
	[Token(Token = "0x6000E1A")]
	public static DynValue max(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[Address(RVA = "0x3831C0", Offset = "0x3823C0", Length = "0x123")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Func`3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MathModule), Member = "execaccum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackArguments), typeof(string), typeof(System.Func`3<System.Double, System.Double, System.Double>)}, ReturnType = typeof(DynValue))]
	[MoonSharpModuleMethod]
	[Token(Token = "0x6000E1B")]
	public static DynValue min(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[Address(RVA = "0x3832F0", Offset = "0x3824F0", Length = "0x157")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CallbackArguments), Member = "AsType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(DataType), typeof(bool)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802897E0")]
	[Calls(Type = typeof(DynValue), Member = "NewNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(DynValue), Member = "NewTuple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue[])}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[MoonSharpModuleMethod]
	[Token(Token = "0x6000E1C")]
	public static DynValue modf(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[Address(RVA = "0x381320", Offset = "0x380520", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Random), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000E06")]
	public static void MoonSharpInit(Table globalTable, Table ioTable) { }

	[Address(RVA = "0x383450", Offset = "0x382650", Length = "0x126")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Func`3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MathModule), Member = "exec2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackArguments), typeof(string), typeof(System.Func`3<System.Double, System.Double, System.Double>)}, ReturnType = typeof(DynValue))]
	[MoonSharpModuleMethod]
	[Token(Token = "0x6000E1D")]
	public static DynValue pow(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[Address(RVA = "0x383580", Offset = "0x382780", Length = "0x1A5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CallbackArguments), Member = "AsType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(DataType), typeof(bool)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "NewNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[MoonSharpModuleMethod]
	[Token(Token = "0x6000E1E")]
	public static DynValue rad(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[Address(RVA = "0x383730", Offset = "0x382930", Length = "0x285")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CallbackArguments), Member = "AsType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(DataType), typeof(bool)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(Table), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "get_UserData", ReturnType = typeof(UserData))]
	[Calls(Type = typeof(DynValue), Member = "IsNil", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DynValue), Member = "NewNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[MoonSharpModuleMethod]
	[Token(Token = "0x6000E1F")]
	public static DynValue random(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[Address(RVA = "0x3839C0", Offset = "0x382BC0", Length = "0x137")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CallbackArguments), Member = "AsType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(DataType), typeof(bool)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Random), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MathModule), Member = "SetRandom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(Random)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[MoonSharpModuleMethod]
	[Token(Token = "0x6000E20")]
	public static DynValue randomseed(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[Address(RVA = "0x381390", Offset = "0x380590", Length = "0xC9")]
	[CalledBy(Type = typeof(MathModule), Member = "randomseed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UserData), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(Table), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000E05")]
	private static void SetRandom(Script s, Random random) { }

	[Address(RVA = "0x383B00", Offset = "0x382D00", Length = "0x1A5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CallbackArguments), Member = "AsType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(DataType), typeof(bool)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "NewNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[MoonSharpModuleMethod]
	[Token(Token = "0x6000E21")]
	public static DynValue sin(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[Address(RVA = "0x383CB0", Offset = "0x382EB0", Length = "0x1A5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CallbackArguments), Member = "AsType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(DataType), typeof(bool)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "NewNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[MoonSharpModuleMethod]
	[Token(Token = "0x6000E22")]
	public static DynValue sinh(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[Address(RVA = "0x383E60", Offset = "0x383060", Length = "0x1A5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CallbackArguments), Member = "AsType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(DataType), typeof(bool)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "NewNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[MoonSharpModuleMethod]
	[Token(Token = "0x6000E23")]
	public static DynValue sqrt(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[Address(RVA = "0x384010", Offset = "0x383210", Length = "0x1A5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CallbackArguments), Member = "AsType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(DataType), typeof(bool)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "NewNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[MoonSharpModuleMethod]
	[Token(Token = "0x6000E24")]
	public static DynValue tan(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[Address(RVA = "0x3841C0", Offset = "0x3833C0", Length = "0x1A5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CallbackArguments), Member = "AsType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(DataType), typeof(bool)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "NewNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[MoonSharpModuleMethod]
	[Token(Token = "0x6000E25")]
	public static DynValue tanh(ScriptExecutionContext executionContext, CallbackArguments args) { }

}

