namespace Unity.Burst;

[Token(Token = "0x2000005")]
public static class BurstCompiler
{
	[CompilerGenerated]
	[Token(Token = "0x200000B")]
	private sealed class <>c
	{
		[Token(Token = "0x4000016")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000017")]
		public static Func<Attribute, Boolean> <>9__22_0; //Field offset: 0x8

		[Address(RVA = "0x181F380", Offset = "0x181E580", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600001A")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600001B")]
		public <>c() { }

		[Address(RVA = "0x181F310", Offset = "0x181E510", Length = "0x6C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600001C")]
		internal bool <Compile>b__22_0(Attribute s) { }

	}

	[BurstCompile]
	[Token(Token = "0x2000006")]
	public static class BurstCompilerHelper
	{
		[Token(Token = "0x2000009")]
		public static class IsBurstEnabled_00000145$BurstDirectCall
		{
			[Token(Token = "0x4000014")]
			private static IntPtr Pointer; //Field offset: 0x0

			[Address(RVA = "0x181EE60", Offset = "0x181E060", Length = "0x167")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[Token(Token = "0x6000017")]
			private static IntPtr GetFunctionPointer() { }

			[Address(RVA = "0x181ECE0", Offset = "0x181DEE0", Length = "0x174")]
			[BurstDiscard]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[Token(Token = "0x6000016")]
			private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

			[Address(RVA = "0x181EFD0", Offset = "0x181E1D0", Length = "0x287")]
			[CalledBy(Type = typeof(BurstCompilerHelper), Member = "IsBurstEnabled", ReturnType = typeof(bool))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[CallsUnknownMethods(Count = 1)]
			[Token(Token = "0x6000018")]
			public static bool Invoke() { }

		}

		[Token(Token = "0x2000008")]
		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		public sealed class IsBurstEnabled_00000145$PostfixBurstDelegate : MulticastDelegate
		{

			[Address(RVA = "0xC43320", Offset = "0xC42520", Length = "0xA5")]
			[CallerCount(Count = 16)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000014")]
			public IsBurstEnabled_00000145$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

			[Address(RVA = "0x2BC000", Offset = "0x2BB200", Length = "0x16A")]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802897E0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180288CC0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802891B0")]
			[CallsUnknownMethods(Count = 1)]
			[ContainsUnimplementedInstructions]
			[DeduplicatedMethod]
			[Token(Token = "0x6000015")]
			public override bool Invoke() { }

		}

		[Token(Token = "0x2000007")]
		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		private sealed class IsBurstEnabledDelegate : MulticastDelegate
		{

			[Address(RVA = "0xC43320", Offset = "0xC42520", Length = "0xA5")]
			[CallerCount(Count = 16)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000012")]
			public IsBurstEnabledDelegate(object object, IntPtr method) { }

			[Address(RVA = "0x2BC000", Offset = "0x2BB200", Length = "0x16A")]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802897E0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180288CC0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802891B0")]
			[CallsUnknownMethods(Count = 1)]
			[ContainsUnimplementedInstructions]
			[DeduplicatedMethod]
			[Token(Token = "0x6000013")]
			public override bool Invoke() { }

		}

		[Token(Token = "0x4000012")]
		private static readonly IsBurstEnabledDelegate IsBurstEnabledImpl; //Field offset: 0x0
		[Token(Token = "0x4000013")]
		public static readonly bool IsBurstGenerated; //Field offset: 0x8

		[Address(RVA = "0x18189A0", Offset = "0x1817BA0", Length = "0x152")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = "Unity.Burst.LowLevel.BurstCompilerService", Member = "CompileAsyncDelegateMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(int))]
		[Calls(Type = "Unity.Burst.LowLevel.BurstCompilerService", Member = "GetAsyncCompiledAsyncDelegateMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Void*))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000010")]
		private static BurstCompilerHelper() { }

		[Address(RVA = "0x1308B90", Offset = "0x1307D90", Length = "0x4")]
		[BurstDiscard]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600000E")]
		private static void DiscardedMethod(ref bool value) { }

		[Address(RVA = "0x1818950", Offset = "0x1817B50", Length = "0x7")]
		[BurstCompile]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(IsBurstEnabled_00000145$BurstDirectCall), Member = "Invoke", ReturnType = typeof(bool))]
		[MonoPInvokeCallback(typeof(IsBurstEnabledDelegate))]
		[Token(Token = "0x600000D")]
		private static bool IsBurstEnabled() { }

		[Address(RVA = "0x1818910", Offset = "0x1817B10", Length = "0x3C")]
		[BurstCompile]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[MonoPInvokeCallback(typeof(IsBurstEnabledDelegate))]
		[Token(Token = "0x6000011")]
		internal static bool IsBurstEnabled$BurstManaged() { }

		[Address(RVA = "0x1818960", Offset = "0x1817B60", Length = "0x31")]
		[CallerCount(Count = 0)]
		[Calls(Type = "Unity.Burst.LowLevel.BurstCompilerService", Member = "CompileAsyncDelegateMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(int))]
		[Calls(Type = "Unity.Burst.LowLevel.BurstCompilerService", Member = "GetAsyncCompiledAsyncDelegateMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Void*))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600000F")]
		private static bool IsCompiledByBurst(Delegate del) { }

	}

	[Token(Token = "0x200000A")]
	private class FakeDelegate
	{
		[CompilerGenerated]
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000015")]
		private readonly MethodInfo <Method>k__BackingField; //Field offset: 0x10

		[Preserve]
		[Token(Token = "0x17000006")]
		public MethodInfo Method
		{
			[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
			[CallerCount(Count = 50)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6000019")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000019")]
		public MethodInfo get_Method() { }

	}

	[Token(Token = "0x400000F")]
	internal static bool _IsEnabled; //Field offset: 0x0
	[Token(Token = "0x4000010")]
	public static readonly BurstCompilerOptions Options; //Field offset: 0x8
	[Token(Token = "0x4000011")]
	private static readonly MethodInfo DummyMethodInfo; //Field offset: 0x10

	[Token(Token = "0x17000005")]
	public static bool IsEnabled
	{
		[Address(RVA = "0x1819FE0", Offset = "0x18191E0", Length = "0x8D")]
		[CallerCount(Count = 23)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000007")]
		 get { } //Length: 141
	}

	[Address(RVA = "0x1819DD0", Offset = "0x1818FD0", Length = "0x20D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(JobsUtility), Member = "set_JobCompilerEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600000C")]
	private static BurstCompiler() { }

	[Address(RVA = "0x1819C60", Offset = "0x1818E60", Length = "0x165")]
	[CalledBy(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BurstCompiler), Member = "Compile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(MethodInfo), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000009")]
	private static Void* Compile(object delegateObj, bool isFunctionPointer, bool deterministicCompilation = false) { }

	[Address(RVA = "0x1819440", Offset = "0x1818640", Length = "0x814")]
	[CalledBy(Type = typeof(BurstCompiler), Member = "Compile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(Void*))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MemberInfo), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(MemberInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Marshal), Member = "GetFunctionPointerForDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = "Unity.Burst.LowLevel.BurstCompilerService", Member = "GetAsyncCompiledAsyncDelegateMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Void*))]
	[Calls(Type = "Unity.Burst.LowLevel.BurstCompilerService", Member = "CompileAsyncDelegateMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BurstCompilerOptions), Member = "GetBurstCompileAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = typeof(BurstCompileAttribute))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Enumerable), Member = "All", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Func`2<System.Object, System.Boolean>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CustomAttributeExtensions), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Attribute>))]
	[Calls(Type = typeof(MethodBase), Member = "get_IsStatic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x600000A")]
	private static Void* Compile(object delegateObj, MethodInfo methodInfo, bool isFunctionPointer, bool isILPostProcessing, bool deterministicCompilation = false) { }

	[Address(RVA = "0x685440", Offset = "0x684640", Length = "0x61")]
	[CallerCount(Count = 74)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BurstCompiler), Member = "Compile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(Void*))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000008")]
	public static FunctionPointer<T> CompileFunctionPointer(T delegateMethod) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600000B")]
	private static void DummyMethod() { }

	[Address(RVA = "0x1819FE0", Offset = "0x18191E0", Length = "0x8D")]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000007")]
	public static bool get_IsEnabled() { }

}

