namespace Unity.Jobs;

[Extension]
[Token(Token = "0x200000E")]
public static class IJobParallelForExtensions
{
	[Token(Token = "0x200000F")]
	public struct ParallelForJobStruct
	{
		[Token(Token = "0x2000010")]
		internal sealed class ExecuteJobFunction : MulticastDelegate
		{

			[Address(RVA = "0xC2FA50", Offset = "0xC2EC50", Length = "0xB5")]
			[CallerCount(Count = 3)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000019")]
			public ExecuteJobFunction(object object, IntPtr method) { }

			[Address(RVA = "0x335810", Offset = "0x334A10", Length = "0x14")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x600001A")]
			public override void Invoke(ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }

		}

		[Token(Token = "0x400000B")]
		internal static readonly SharedStatic<IntPtr> jobReflectionData; //Field offset: 0x0

		[Address(RVA = "0xCC8880", Offset = "0xCC7A80", Length = "0x8F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(SharedStatic`1), Member = "GetOrCreate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContext"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = "Unity.Collections.LowLevel.Unsafe.BurstLike+SharedStatic`1<T>")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000018")]
		private static ParallelForJobStruct`1() { }

		[Address(RVA = "0xE5EE20", Offset = "0xE5E020", Length = "0xDC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JobsUtility), Member = "GetWorkStealingRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobRanges&), typeof(int), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = "GLTFast.Jobs.ConvertBoneJointsUInt16ToUInt32Job", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6000017")]
		public static void Execute(ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }

		[Address(RVA = "0xE644A0", Offset = "0xE636A0", Length = "0x259")]
		[BurstDiscard]
		[CalledBy(Type = typeof(IJobParallelForExtensions), Member = "EarlyJobInit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(IJobParallelForExtensions), Member = "GetReflectionData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(IntPtr))]
		[CalledBy(Type = typeof(IJobParallelForExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(JobsUtility), Member = "CreateJobReflectionData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(IntPtr))]
		[CallsDeduplicatedMethods(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000016")]
		internal static void Initialize() { }

	}


	[Address(RVA = "0x6DFCF0", Offset = "0x6DEEF0", Length = "0x50")]
	[CalledBy(Type = "__JobReflectionRegistrationOutput__1854482118041315048", Member = "CreateJobReflectionData", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ParallelForJobStruct`1), Member = "Initialize", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000013")]
	public static void EarlyJobInit() { }

	[Address(RVA = "0x6E0560", Offset = "0x6DF760", Length = "0xA2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ParallelForJobStruct`1), Member = "Initialize", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000014")]
	private static IntPtr GetReflectionData() { }

	[Address(RVA = "0x6E1C10", Offset = "0x6E0E10", Length = "0x152")]
	[CalledBy(Type = "GLTFast.VertexBufferBones", Member = "GetJointsJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Void*", typeof(int), "GLTFast.Schema.GltfComponentType", typeof(int), "Unity.Mathematics.uint4*", typeof(int), "GLTFast.Logging.ICodeLogger"}, ReturnType = "System.Nullable`1<JobHandle>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ParallelForJobStruct`1), Member = "Initialize", ReturnType = typeof(void))]
	[Calls(Type = typeof(JobScheduleParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(IntPtr), typeof(JobHandle), typeof(ScheduleMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JobsUtility), Member = "ScheduleParallelFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobScheduleParameters&), typeof(int), typeof(int)}, ReturnType = typeof(JobHandle))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x6000015")]
	public static JobHandle Schedule(T jobData, int arrayLength, int innerloopBatchCount, JobHandle dependsOn = null) { }

}

