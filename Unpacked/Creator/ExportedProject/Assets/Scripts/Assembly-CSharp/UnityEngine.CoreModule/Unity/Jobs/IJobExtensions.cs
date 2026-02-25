namespace Unity.Jobs;

[Extension]
[Token(Token = "0x200000A")]
public static class IJobExtensions
{
	[Token(Token = "0x200000B")]
	public struct JobStruct
	{
		[Token(Token = "0x200000C")]
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
			public override void Invoke(ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }

		}

		[Token(Token = "0x400000A")]
		internal static readonly SharedStatic<IntPtr> jobReflectionData; //Field offset: 0x0

		[Address(RVA = "0xCC8880", Offset = "0xCC7A80", Length = "0x8F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(SharedStatic`1), Member = "GetOrCreate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContext"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = "Unity.Collections.LowLevel.Unsafe.BurstLike+SharedStatic`1<T>")]
		[DeduplicatedMethod]
		[Token(Token = "0x600000F")]
		private static JobStruct`1() { }

		[Address(RVA = "0xCC5600", Offset = "0xCC4800", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = "GLTFast.Jobs.MemCopyJob", Member = "Execute", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x600000E")]
		public static void Execute(ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }

		[Address(RVA = "0xCC8160", Offset = "0xCC7360", Length = "0x259")]
		[BurstDiscard]
		[CalledBy(Type = typeof(IJobExtensions), Member = "EarlyJobInit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(IJobExtensions), Member = "GetReflectionData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(IntPtr))]
		[CalledBy(Type = typeof(IJobExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
		[CallerCount(Count = 3)]
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


	[Address(RVA = "0x6D8DC0", Offset = "0x6D7FC0", Length = "0x50")]
	[CalledBy(Type = "__JobReflectionRegistrationOutput__1854482118041315048", Member = "CreateJobReflectionData", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(JobStruct`1), Member = "Initialize", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600000A")]
	public static void EarlyJobInit() { }

	[Address(RVA = "0x6D92D0", Offset = "0x6D84D0", Length = "0xA2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(JobStruct`1), Member = "Initialize", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600000B")]
	private static IntPtr GetReflectionData() { }

	[Address(RVA = "0x6D9450", Offset = "0x6D8650", Length = "0x140")]
	[CalledBy(Type = "GLTFast.GltfImportBase", Member = "CreateTexturesFromBuffers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IReadOnlyList`1<Image>", "System.Collections.Generic.IReadOnlyList`1<BufferViewBase>", "System.Collections.Generic.ICollection`1<ImageCreateContext>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.GltfImportBase", Member = "GetVector3Job", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"GLTFast.Schema.RootBase", typeof(int), "Unity.Collections.NativeArray`1<Vector3>&", "System.Nullable`1<JobHandle>&", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.VertexBufferColors", Member = "GetColors32Job", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Void*", "GLTFast.Schema.GltfComponentType", "GLTFast.Schema.GltfAccessorAttributeType", typeof(int), "Unity.Collections.NativeArray`1<float4>"}, ReturnType = "System.Nullable`1<JobHandle>")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(JobStruct`1), Member = "Initialize", ReturnType = typeof(void))]
	[Calls(Type = typeof(JobScheduleParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(IntPtr), typeof(JobHandle), typeof(ScheduleMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JobsUtility), Member = "Schedule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobScheduleParameters&)}, ReturnType = typeof(JobHandle))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x600000C")]
	public static JobHandle Schedule(T jobData, JobHandle dependsOn = null) { }

}

