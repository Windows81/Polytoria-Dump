namespace Unity.Collections;

[Extension]
[Token(Token = "0x2000045")]
public static class NativeSliceExtensions
{

	[Address(RVA = "0x706660", Offset = "0x705860", Length = "0x99")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.JobManager", Member = "CompleteCopyMeshJobs", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderTree", Member = "ProcessChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.ChainBuilderStats&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Painter2D", Member = "ScheduleJobs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.MeshGenerationContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.Page+DataSet`1", Member = "SendUpdates", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.Page+DataSet`1", Member = "SendFullRange", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.Page+DataSet`1", Member = "SendPartialRanges", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.JobManager", Member = "CompleteNudgeJobs", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.JobManager", Member = "CompleteConvertMeshJobs", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.OpacityIdAccelerator", Member = "CompleteJobs", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.JobMerger", Member = "MergeAndReset", ReturnType = typeof(JobHandle))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.NativeList`1", Member = "Expand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.NativeList`1", Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeSlice`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.NativeList`1", Member = "GetSlice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeSlice`1<T>")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.NativePagedList`1", Member = "GetPages", ReturnType = "System.Collections.Generic.List`1<NativeSlice`1<T>>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.UIR.ConvertMeshJobData>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.UIElements.UIR.ConvertMeshJobData>), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x60000AB")]
	public static NativeSlice<T> Slice(NativeArray<T> thisArray, int start, int length) { }

	[Address(RVA = "0x7067A0", Offset = "0x7059A0", Length = "0x99")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.EntryProcessor", Member = "ProcessMeshEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.Entry", "UnityEngine.UIElements.TextureId"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.EntryProcessor", Member = "DrawReverseMask", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator+TessellationJob", Member = "DrawRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UnsafeMeshGenerationNode", "NativeRectParams&", typeof(Texture)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(NativeSlice`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeSlice`1<T>", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x60000AC")]
	public static NativeSlice<T> Slice(NativeSlice<T> thisSlice, int start, int length) { }

}

