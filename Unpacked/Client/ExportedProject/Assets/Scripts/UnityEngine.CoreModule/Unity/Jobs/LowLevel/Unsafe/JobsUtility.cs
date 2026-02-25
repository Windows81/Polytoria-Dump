namespace Unity.Jobs.LowLevel.Unsafe;

[NativeHeader("Runtime/Jobs/JobSystem.h")]
[NativeType(Header = "Runtime/Jobs/ScriptBindings/JobsBindings.h")]
[Token(Token = "0x2000015")]
public static class JobsUtility
{
	[Token(Token = "0x2000016")]
	internal struct JobScheduleParameters
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000019")]
		public JobHandle Dependency; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400001A")]
		public int ScheduleMode; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400001B")]
		public IntPtr ReflectionData; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400001C")]
		public IntPtr JobDataPtr; //Field offset: 0x20

		[Address(RVA = "0x192C900", Offset = "0x192BB00", Length = "0x3E")]
		[CalledBy(Type = typeof(IJobExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
		[CalledBy(Type = typeof(IJobParallelForExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
		[CalledBy(Type = "Unity.Jobs.IJobParallelForBatchExtensions", Member = "ScheduleParallel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
		[CalledBy(Type = "Unity.Jobs.IJobParallelForBatchExtensions", Member = "ScheduleBatch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000035")]
		public JobScheduleParameters(Void* i_jobData, IntPtr i_reflectionData, JobHandle i_dependency, ScheduleMode i_scheduleMode) { }

	}

	[Token(Token = "0x2000017")]
	public sealed class PanicFunction_ : MulticastDelegate
	{

		[Address(RVA = "0x2D8810", Offset = "0x2D7A10", Length = "0xA5")]
		[CallerCount(Count = 285)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000036")]
		public PanicFunction_(object object, IntPtr method) { }

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
		[Token(Token = "0x6000037")]
		public override void Invoke() { }

	}

	[Token(Token = "0x4000018")]
	internal static PanicFunction_ PanicFunction; //Field offset: 0x0

	[Token(Token = "0x17000002")]
	public static bool IsExecutingJob
	{
		[Address(RVA = "0x192CC40", Offset = "0x192BE40", Length = "0x2A")]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.TempMeshAllocatorImpl", Member = "AllocateTempMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), "Unity.Collections.NativeSlice`1<Vertex>&", "Unity.Collections.NativeSlice`1<UInt16>&"}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.MaterialManager", Member = "GetFallbackMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Material)}, ReturnType = typeof(Material))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.MaterialManager", Member = "GetFallbackMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.FontAsset", typeof(Material), typeof(int)}, ReturnType = typeof(Material))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextProcessingElement[]", "UnityEngine.TextCore.Text.TextGenerationSettings", "UnityEngine.TextCore.Text.TextInfo"}, ReturnType = typeof(int))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[NativeMethod(IsFreeFunction = True, IsThreadSafe = True)]
		[Token(Token = "0x600002E")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000003")]
	public static bool JobCompilerEnabled
	{
		[Address(RVA = "0x192CCD0", Offset = "0x192BED0", Length = "0x33")]
		[CalledBy(Type = "Unity.Burst.BurstCompiler", Member = ".cctor", ReturnType = typeof(void))]
		[CalledBy(Type = "Unity.Burst.BurstCompilerOptions", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Unity.Burst.BurstCompilerOptions", Member = "set_EnableBurstCompilation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[FreeFunction]
		[Token(Token = "0x600002F")]
		 set { } //Length: 51
	}

	[Token(Token = "0x17000004")]
	public static int ThreadIndex
	{
		[Address(RVA = "0x192CCA0", Offset = "0x192BEA0", Length = "0x2A")]
		[BurstAuthorizedExternalMethod]
		[CalledBy(Type = "UnityEngine.UIElements.UIRUtility", Member = "GetThreadIndex", ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.EntryPool", Member = "Get", ReturnType = "UnityEngine.UIElements.UIR.Entry")]
		[CalledBy(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_textInfoCommon", ReturnType = "UnityEngine.TextCore.Text.TextInfo")]
		[CalledBy(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_generator", ReturnType = "UnityEngine.TextCore.Text.TextGenerator")]
		[CalledBy(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_settings", ReturnType = "UnityEngine.TextCore.Text.TextGenerationSettings")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[FreeFunction("GetJobWorkerIndex", IsThreadSafe = True)]
		[Token(Token = "0x6000030")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000005")]
	public static int ThreadIndexCount
	{
		[Address(RVA = "0x192CC70", Offset = "0x192BE70", Length = "0x2A")]
		[BurstAuthorizedExternalMethod]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.EntryPool", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.TempMeshAllocatorImpl", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "InitArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", "System.Func`1<T>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Unity.Collections.AllocatorManager", Member = ".cctor", ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[FreeFunction("GetJobWorkerIndexCount", IsThreadSafe = True)]
		[Token(Token = "0x6000031")]
		 get { } //Length: 42
	}

	[Address(RVA = "0x192C9B0", Offset = "0x192BBB0", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(ThrowsException = True, IsThreadSafe = True)]
	[Token(Token = "0x600002C")]
	private static IntPtr CreateJobReflectionData(Type wrapperJobType, Type userJobType, object managedJobFunction0, object managedJobFunction1, object managedJobFunction2) { }

	[Address(RVA = "0x192C940", Offset = "0x192BB40", Length = "0x67")]
	[CalledBy(Type = typeof(JobStruct`1), Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ParallelForJobStruct`1), Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Jobs.IJobParallelForBatchExtensions+JobParallelForBatchProducer`1", Member = "Initialize", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600002D")]
	public static IntPtr CreateJobReflectionData(Type type, object managedJobFunction0, object managedJobFunction1 = null, object managedJobFunction2 = null) { }

	[Address(RVA = "0x192CC40", Offset = "0x192BE40", Length = "0x2A")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.TempMeshAllocatorImpl", Member = "AllocateTempMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), "Unity.Collections.NativeSlice`1<Vertex>&", "Unity.Collections.NativeSlice`1<UInt16>&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.MaterialManager", Member = "GetFallbackMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Material)}, ReturnType = typeof(Material))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.MaterialManager", Member = "GetFallbackMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.FontAsset", typeof(Material), typeof(int)}, ReturnType = typeof(Material))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextProcessingElement[]", "UnityEngine.TextCore.Text.TextGenerationSettings", "UnityEngine.TextCore.Text.TextInfo"}, ReturnType = typeof(int))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(IsFreeFunction = True, IsThreadSafe = True)]
	[Token(Token = "0x600002E")]
	public static bool get_IsExecutingJob() { }

	[Address(RVA = "0x192CCA0", Offset = "0x192BEA0", Length = "0x2A")]
	[BurstAuthorizedExternalMethod]
	[CalledBy(Type = "UnityEngine.UIElements.UIRUtility", Member = "GetThreadIndex", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.EntryPool", Member = "Get", ReturnType = "UnityEngine.UIElements.UIR.Entry")]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_textInfoCommon", ReturnType = "UnityEngine.TextCore.Text.TextInfo")]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_generator", ReturnType = "UnityEngine.TextCore.Text.TextGenerator")]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_settings", ReturnType = "UnityEngine.TextCore.Text.TextGenerationSettings")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("GetJobWorkerIndex", IsThreadSafe = True)]
	[Token(Token = "0x6000030")]
	public static int get_ThreadIndex() { }

	[Address(RVA = "0x192CC70", Offset = "0x192BE70", Length = "0x2A")]
	[BurstAuthorizedExternalMethod]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.EntryPool", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.TempMeshAllocatorImpl", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "InitArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", "System.Func`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Collections.AllocatorManager", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("GetJobWorkerIndexCount", IsThreadSafe = True)]
	[Token(Token = "0x6000031")]
	public static int get_ThreadIndexCount() { }

	[Address(RVA = "0x192CA20", Offset = "0x192BC20", Length = "0x60")]
	[CalledBy(Type = typeof(ParallelForJobStruct`1), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(IntPtr), typeof(IntPtr), typeof(JobRanges&), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Jobs.IJobParallelForBatchExtensions+JobParallelForBatchProducer`1", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(IntPtr), typeof(IntPtr), typeof(JobRanges&), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(IsFreeFunction = True, IsThreadSafe = True)]
	[Token(Token = "0x6000029")]
	public static bool GetWorkStealingRange(ref JobRanges ranges, int jobIndex, out int beginIndex, out int endIndex) { }

	[Address(RVA = "0x192CA80", Offset = "0x192BC80", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000032")]
	private static void InvokePanicFunction() { }

	[Address(RVA = "0x192CBF0", Offset = "0x192BDF0", Length = "0x4B")]
	[CalledBy(Type = typeof(IJobExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("ScheduleManagedJob", ThrowsException = True, IsThreadSafe = True)]
	[Token(Token = "0x600002A")]
	public static JobHandle Schedule(ref JobScheduleParameters parameters) { }

	[Address(RVA = "0x192CBA0", Offset = "0x192BDA0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000033")]
	private static void Schedule_Injected(ref JobScheduleParameters parameters, out JobHandle ret) { }

	[Address(RVA = "0x192CB30", Offset = "0x192BD30", Length = "0x6A")]
	[CalledBy(Type = typeof(IJobParallelForExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[CalledBy(Type = "Unity.Jobs.IJobParallelForBatchExtensions", Member = "ScheduleParallel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[CalledBy(Type = "Unity.Jobs.IJobParallelForBatchExtensions", Member = "ScheduleBatch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("ScheduleManagedJobParallelFor", ThrowsException = True, IsThreadSafe = True)]
	[Token(Token = "0x600002B")]
	public static JobHandle ScheduleParallelFor(ref JobScheduleParameters parameters, int arrayLength, int innerloopBatchCount) { }

	[Address(RVA = "0x192CAD0", Offset = "0x192BCD0", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000034")]
	private static void ScheduleParallelFor_Injected(ref JobScheduleParameters parameters, int arrayLength, int innerloopBatchCount, out JobHandle ret) { }

	[Address(RVA = "0x192CCD0", Offset = "0x192BED0", Length = "0x33")]
	[CalledBy(Type = "Unity.Burst.BurstCompiler", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Burst.BurstCompilerOptions", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Burst.BurstCompilerOptions", Member = "set_EnableBurstCompilation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction]
	[Token(Token = "0x600002F")]
	public static void set_JobCompilerEnabled(bool value) { }

}

