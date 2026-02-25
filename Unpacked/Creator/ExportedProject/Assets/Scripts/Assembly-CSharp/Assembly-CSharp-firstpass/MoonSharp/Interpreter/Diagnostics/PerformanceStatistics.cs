namespace MoonSharp.Interpreter.Diagnostics;

[Token(Token = "0x2000158")]
public class PerformanceStatistics
{
	[Token(Token = "0x4000585")]
	private static IPerformanceStopwatch[] m_GlobalStopwatches; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000584")]
	private IPerformanceStopwatch[] m_Stopwatches; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000586")]
	private bool m_Enabled; //Field offset: 0x18

	[Token(Token = "0x170001AC")]
	public bool Enabled
	{
		[Address(RVA = "0x2FBD80", Offset = "0x2FAF80", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CCF")]
		 get { } //Length: 5
		[Address(RVA = "0x387DF0", Offset = "0x386FF0", Length = "0x2CB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(PerformanceStopwatch), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PerformanceCounter)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000CD0")]
		 set { } //Length: 715
	}

	[Address(RVA = "0x387D20", Offset = "0x386F20", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000CD6")]
	private static PerformanceStatistics() { }

	[Address(RVA = "0x387D90", Offset = "0x386F90", Length = "0x55")]
	[CalledBy(Type = typeof(Script), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CoreModules)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000CD5")]
	public PerformanceStatistics() { }

	[Address(RVA = "0x2FBD80", Offset = "0x2FAF80", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CCF")]
	public bool get_Enabled() { }

	[Address(RVA = "0x387960", Offset = "0x386B60", Length = "0xE2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000CD1")]
	public PerformanceResult GetPerformanceCounterResult(PerformanceCounter pc) { }

	[Address(RVA = "0x387A50", Offset = "0x386C50", Length = "0x1A5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(StringBuilder), Member = "AppendLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000CD4")]
	public string GetPerformanceLog() { }

	[Address(RVA = "0x387DF0", Offset = "0x386FF0", Length = "0x2CB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(PerformanceStopwatch), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PerformanceCounter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000CD0")]
	public void set_Enabled(bool value) { }

	[Address(RVA = "0x387C00", Offset = "0x386E00", Length = "0x94")]
	[CalledBy(Type = typeof(FieldMemberDescriptor), Member = "OptimizeGetter", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MethodMemberDescriptor), Member = "MoonSharp.Interpreter.Interop.BasicDescriptors.IOptimizableDescriptor.Optimize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropertyMemberDescriptor), Member = "OptimizeGetter", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropertyMemberDescriptor), Member = "OptimizeSetter", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000CD3")]
	internal static IDisposable StartGlobalStopwatch(PerformanceCounter pc) { }

	[Address(RVA = "0x387CA0", Offset = "0x386EA0", Length = "0x74")]
	[CalledBy(Type = typeof(Loader_Fast), Member = "LoadDynamicExpr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(SourceCode)}, ReturnType = typeof(DynamicExprExpression))]
	[CalledBy(Type = typeof(Loader_Fast), Member = "LoadChunk", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(SourceCode), typeof(ByteCode)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Loader_Fast), Member = "LoadFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(SourceCode), typeof(ByteCode), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Processor), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(DynValue[])}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000CD2")]
	internal IDisposable StartStopwatch(PerformanceCounter pc) { }

}

