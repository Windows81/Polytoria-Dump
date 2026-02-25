namespace Unity.Jobs;

[Extension]
[Token(Token = "0x2000007")]
public static class IJobParallelForBatchExtensions
{
	[Token(Token = "0x2000008")]
	public struct JobParallelForBatchProducer
	{
		[Token(Token = "0x2000009")]
		public sealed class ExecuteJobFunction : MulticastDelegate
		{

			[Address(RVA = "0xC2FA50", Offset = "0xC2EC50", Length = "0xB5")]
			[CallerCount(Count = 3)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000010")]
			public ExecuteJobFunction(object object, IntPtr method) { }

			[Address(RVA = "0x335810", Offset = "0x334A10", Length = "0x14")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000011")]
			public override void Invoke(ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }

		}

		[Token(Token = "0x4000002")]
		internal static readonly SharedStatic<IntPtr> jobReflectionData; //Field offset: 0x0

		[Address(RVA = "0xCC4FF0", Offset = "0xCC41F0", Length = "0x8F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(SharedStatic`1), Member = "GetOrCreate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContext"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = "Unity.Burst.SharedStatic`1<T>")]
		[DeduplicatedMethod]
		[Token(Token = "0x600000F")]
		private static JobParallelForBatchProducer`1() { }

		[Address(RVA = "0xCC01B0", Offset = "0xCBF3B0", Length = "0xD6")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JobsUtility), Member = "GetWorkStealingRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobRanges&), typeof(int), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = "GLTFast.Jobs.ConvertBoneWeightsFloatToFloatInterleavedJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x600000E")]
		public static void Execute(ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }

		[Address(RVA = "0xCC2C50", Offset = "0xCC1E50", Length = "0x259")]
		[BurstDiscard]
		[CalledBy(Type = typeof(IJobParallelForBatchExtensions), Member = "EarlyJobInit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(IJobParallelForBatchExtensions), Member = "GetReflectionData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(IntPtr))]
		[CalledBy(Type = typeof(IJobParallelForBatchExtensions), Member = "ScheduleParallel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
		[CalledBy(Type = typeof(IJobParallelForBatchExtensions), Member = "ScheduleBatch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(JobsUtility), Member = "CreateJobReflectionData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(IntPtr))]
		[CallsDeduplicatedMethods(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x600000D")]
		internal static void Initialize() { }

	}


	[Address(RVA = "0x6D9590", Offset = "0x6D8790", Length = "0x50")]
	[CalledBy(Type = "__JobReflectionRegistrationOutput__1854482118041315048", Member = "CreateJobReflectionData", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(JobParallelForBatchProducer`1), Member = "Initialize", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000009")]
	public static void EarlyJobInit() { }

	[Address(RVA = "0x6D9DB0", Offset = "0x6D8FB0", Length = "0xA2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(JobParallelForBatchProducer`1), Member = "Initialize", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600000A")]
	private static IntPtr GetReflectionData() { }

	[Address(RVA = "0x6DB040", Offset = "0x6DA240", Length = "0x185")]
	[CalledBy(Type = "GLTFast.VertexBufferBones", Member = "GetWeightsJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Void*", typeof(int), "GLTFast.Schema.GltfComponentType", typeof(int), "Unity.Mathematics.float4*", typeof(int)}, ReturnType = "System.Nullable`1<JobHandle>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(JobParallelForBatchProducer`1), Member = "Initialize", ReturnType = typeof(void))]
	[Calls(Type = typeof(JobScheduleParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(IntPtr), typeof(JobHandle), typeof(ScheduleMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JobsUtility), Member = "ScheduleParallelFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobScheduleParameters&), typeof(int), typeof(int)}, ReturnType = typeof(JobHandle))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x600000C")]
	public static JobHandle ScheduleBatch(T jobData, int arrayLength, int indicesPerJobCount, JobHandle dependsOn = null) { }

	[Address(RVA = "0x6DD9E0", Offset = "0x6DCBE0", Length = "0x14F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(JobParallelForBatchProducer`1), Member = "Initialize", ReturnType = typeof(void))]
	[Calls(Type = typeof(JobScheduleParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(IntPtr), typeof(JobHandle), typeof(ScheduleMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JobsUtility), Member = "ScheduleParallelFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobScheduleParameters&), typeof(int), typeof(int)}, ReturnType = typeof(JobHandle))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x600000B")]
	public static JobHandle ScheduleParallel(T jobData, int arrayLength, int indicesPerJobCount, JobHandle dependsOn = null) { }

}

