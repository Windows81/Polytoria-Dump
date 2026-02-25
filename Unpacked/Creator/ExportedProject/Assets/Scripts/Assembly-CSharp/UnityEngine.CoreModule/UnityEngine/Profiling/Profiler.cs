namespace UnityEngine.Profiling;

[MovedFrom("UnityEngine")]
[NativeHeader("Runtime/Profiler/Profiler.h")]
[NativeHeader("Runtime/Utilities/MemoryUtilities.h")]
[NativeHeader("Runtime/ScriptingBackend/ScriptingApi.h")]
[NativeHeader("Runtime/Profiler/MemoryProfiler.h")]
[NativeHeader("Runtime/Profiler/ScriptBindings/Profiler.bindings.h")]
[NativeHeader("Runtime/Allocator/MemoryManager.h")]
[Token(Token = "0x2000192")]
[UsedByNativeCode]
public sealed class Profiler
{

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[NativeConditional("ENABLE_PROFILER")]
	[Token(Token = "0x6000BA2")]
	public static void EndThreadProfiling() { }

}

