namespace Unity.Burst.LowLevel;

[NativeHeader("Runtime/Burst/BurstDelegateCache.h")]
[NativeHeader("Runtime/Burst/Burst.h")]
[StaticAccessor("BurstCompilerService::Get()", StaticAccessorType::Arrow (1))]
[Token(Token = "0x2000060")]
internal static class BurstCompilerService
{
	[Token(Token = "0x2000061")]
	internal enum BurstLogType
	{
		Info = 0,
		Warning = 1,
		Error = 2,
	}


	[Address(RVA = "0x191FE90", Offset = "0x191F090", Length = "0x18C")]
	[CalledBy(Type = "Unity.Burst.BurstCompiler+BurstCompilerHelper", Member = "IsCompiledByBurst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Unity.Burst.BurstCompiler+BurstCompilerHelper", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Burst.BurstCompiler", Member = "Compile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(MethodInfo), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = "System.Void*")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(IsThreadSafe = True)]
	[Token(Token = "0x60000F5")]
	public static int CompileAsyncDelegateMethod(object delegateMethod, string compilerOptions) { }

	[Address(RVA = "0x191FE40", Offset = "0x191F040", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000FA")]
	private static int CompileAsyncDelegateMethod_Injected(object delegateMethod, ref ManagedSpanWrapper compilerOptions) { }

	[Address(RVA = "0x1920020", Offset = "0x191F220", Length = "0x31")]
	[CalledBy(Type = "Unity.Burst.BurstCompiler+BurstCompilerHelper", Member = "IsCompiledByBurst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Unity.Burst.BurstCompiler+BurstCompilerHelper", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Burst.BurstCompiler", Member = "Compile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(MethodInfo), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = "System.Void*")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(IsThreadSafe = True)]
	[Token(Token = "0x60000F6")]
	public static Void* GetAsyncCompiledAsyncDelegateMethod(int userID) { }

	[Address(RVA = "0x1920060", Offset = "0x191F260", Length = "0x50")]
	[CalledBy(Type = "Unity.Burst.SharedStatic", Member = "GetOrCreateSharedStaticInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(long), typeof(uint), typeof(uint)}, ReturnType = "System.Void*")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x60000F7")]
	public static Void* GetOrCreateSharedMemory(ref Hash128 key, uint size_of, uint alignment) { }

	[Address(RVA = "0x19200B0", Offset = "0x191F2B0", Length = "0x60")]
	[CalledBy(Type = "Unity.Burst.BurstRuntime", Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte*", typeof(int), "System.Byte*", typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("DefaultBurstLogCallback", True)]
	[Token(Token = "0x60000F8")]
	public static void Log(Void* userData, BurstLogType logType, Byte* message, Byte* filename, int lineNumber) { }

	[Address(RVA = "0x1920110", Offset = "0x191F310", Length = "0x60")]
	[CalledBy(Type = "Unity.Burst.BurstRuntime", Member = "RuntimeLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte*", typeof(int), "System.Byte*", typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("DefaultBurstRuntimeLogCallback", True)]
	[Token(Token = "0x60000F9")]
	public static void RuntimeLog(Void* userData, BurstLogType logType, Byte* message, Byte* filename, int lineNumber) { }

}

