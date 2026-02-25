namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x200056D")]
internal class JobManager : IDisposable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40012A8")]
	private NativePagedList<NudgeJobData> m_NudgeJobs; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40012A9")]
	private NativePagedList<ConvertMeshJobData> m_ConvertMeshJobs; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40012AA")]
	private NativePagedList<CopyMeshJobData> m_CopyMeshJobs; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40012AB")]
	private JobMerger m_JobMerger; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40012AC")]
	private bool <disposed>k__BackingField; //Field offset: 0x30

	[Token(Token = "0x170009E3")]
	protected private bool disposed
	{
		[Address(RVA = "0x3351B0", Offset = "0x3343B0", Length = "0x5")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60026F2")]
		 get { } //Length: 5
		[Address(RVA = "0x3351C0", Offset = "0x3343C0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60026F3")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x1B83A30", Offset = "0x1B82C30", Length = "0x1EC")]
	[CalledBy(Type = typeof(RenderTreeManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UnityEngine.UIElements.UIR.NativePagedList`1<UnityEngine.UIElements.UIR.NudgeJobData>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(Allocator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(NativePagedList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(Allocator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.UIR.NativePagedList`1<UnityEngine.UIElements.UIR.CopyMeshJobData>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(Allocator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60026F6")]
	public JobManager() { }

	[Address(RVA = "0x1B82F00", Offset = "0x1B82100", Length = "0x53")]
	[CalledBy(Type = typeof(RenderEvents), Member = "NudgeVerticesToNewSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData), typeof(RenderTreeManager), typeof(UIRenderDevice)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.UIElements.UIR.NativePagedList`1<UnityEngine.UIElements.UIR.NudgeJobData>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NudgeJobData&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026EC")]
	public void Add(ref NudgeJobData job) { }

	[Address(RVA = "0x1B82E40", Offset = "0x1B82040", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NativePagedList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026ED")]
	public void Add(ref ConvertMeshJobData job) { }

	[Address(RVA = "0x1B82EA0", Offset = "0x1B820A0", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.UIElements.UIR.NativePagedList`1<UnityEngine.UIElements.UIR.CopyMeshJobData>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CopyMeshJobData&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026EE")]
	public void Add(ref CopyMeshJobData job) { }

	[Address(RVA = "0x1B82F60", Offset = "0x1B82160", Length = "0x30C")]
	[CalledBy(Type = typeof(RenderTree), Member = "ProcessChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JobProcessor), Member = "ScheduleConvertMeshJobs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NativePagedList`1), Member = "GetPages", ReturnType = "System.Collections.Generic.List`1<NativeSlice`1<T>>")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(JobHandle), Member = "CombineDependencies", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<Unity.Jobs.JobHandle>)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(NativeSliceExtensions), Member = "Slice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>", typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeSlice`1<T>")]
	[Calls(Type = typeof(JobHandle), Member = "CombineDependencies", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeSlice`1<Unity.Jobs.JobHandle>)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(JobHandle), Member = "Complete", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativePagedList`1), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x60026F0")]
	public void CompleteConvertMeshJobs() { }

	[Address(RVA = "0x1B83270", Offset = "0x1B82470", Length = "0x30C")]
	[CalledBy(Type = typeof(RenderTree), Member = "ProcessChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JobProcessor), Member = "ScheduleCopyMeshJobs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NativePagedList`1), Member = "GetPages", ReturnType = "System.Collections.Generic.List`1<NativeSlice`1<T>>")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(JobHandle), Member = "CombineDependencies", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<Unity.Jobs.JobHandle>)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(NativeSliceExtensions), Member = "Slice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>", typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeSlice`1<T>")]
	[Calls(Type = typeof(JobHandle), Member = "CombineDependencies", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeSlice`1<Unity.Jobs.JobHandle>)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(JobHandle), Member = "Complete", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativePagedList`1), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x60026F1")]
	public void CompleteCopyMeshJobs() { }

	[Address(RVA = "0x1B83580", Offset = "0x1B82780", Length = "0x30C")]
	[CalledBy(Type = typeof(RenderTree), Member = "ProcessChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JobProcessor), Member = "ScheduleNudgeJobs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.UIElements.UIR.NativePagedList`1<UnityEngine.UIElements.UIR.NudgeJobData>), Member = "GetPages", ReturnType = typeof(System.Collections.Generic.List`1<Unity.Collections.NativeSlice`1<UnityEngine.UIElements.UIR.NudgeJobData>>))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(JobHandle), Member = "CombineDependencies", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<Unity.Jobs.JobHandle>)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(NativeSliceExtensions), Member = "Slice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>", typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeSlice`1<T>")]
	[Calls(Type = typeof(JobHandle), Member = "CombineDependencies", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeSlice`1<Unity.Jobs.JobHandle>)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(JobHandle), Member = "Complete", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativePagedList`1), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x60026EF")]
	public void CompleteNudgeJobs() { }

	[Address(RVA = "0x1B83950", Offset = "0x1B82B50", Length = "0xDB")]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.UIElements.UIR.NativePagedList`1<UnityEngine.UIElements.UIR.NudgeJobData>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativePagedList`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.UIR.NativePagedList`1<UnityEngine.UIElements.UIR.CopyMeshJobData>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(JobMerger), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026F4")]
	public override void Dispose() { }

	[Address(RVA = "0x1B83890", Offset = "0x1B82A90", Length = "0xB2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.UIElements.UIR.NativePagedList`1<UnityEngine.UIElements.UIR.NudgeJobData>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativePagedList`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.UIR.NativePagedList`1<UnityEngine.UIElements.UIR.CopyMeshJobData>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(JobMerger), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026F5")]
	protected void Dispose(bool disposing) { }

	[Address(RVA = "0x3351B0", Offset = "0x3343B0", Length = "0x5")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60026F2")]
	protected bool get_disposed() { }

	[Address(RVA = "0x3351C0", Offset = "0x3343C0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60026F3")]
	private void set_disposed(bool value) { }

}

