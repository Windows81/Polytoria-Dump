namespace UnityEngine.AI;

[NativeHeader("Modules/AI/Builder/NavMeshBuilder.bindings.h")]
[StaticAccessor("NavMeshBuilderBindings", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x2000002")]
public static class NavMeshBuilder
{

	[Address(RVA = "0x19003D0", Offset = "0x18FF5D0", Length = "0x2B0")]
	[CalledBy(Type = "Unity.AI.Navigation.NavMeshSurface", Member = "BuildNavMesh", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000004")]
	public static NavMeshData BuildNavMeshData(NavMeshBuildSettings buildSettings, List<NavMeshBuildSource> sources, Bounds localBounds, Vector3 position, Quaternion rotation) { }

	[Address(RVA = "0x1900AE0", Offset = "0x18FFCE0", Length = "0x23D")]
	[CalledBy(Type = "Unity.AI.Navigation.NavMeshSurface", Member = "CollectSources", ReturnType = "System.Collections.Generic.List`1<NavMeshBuildSource>")]
	[CalledBy(Type = "Unity.AI.Navigation.NavMeshSurface", Member = "CollectSourcesInVolume", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bounds), typeof(int), typeof(NavMeshCollectGeometry), typeof(int), typeof(bool), "System.Collections.Generic.List`1<NavMeshBuildMarkup>", typeof(bool), "System.Collections.Generic.List`1<NavMeshBuildSource>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(NavMeshBuilder), Member = "CollectSourcesInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Bounds), typeof(Transform), typeof(bool), typeof(NavMeshCollectGeometry), typeof(int), typeof(bool), typeof(NavMeshBuildMarkup[]), typeof(bool)}, ReturnType = typeof(NavMeshBuildSource[]))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.AI.NavMeshBuildSource>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.AI.NavMeshBuildSource>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000001")]
	public static void CollectSources(Bounds includedWorldBounds, int includedLayerMask, NavMeshCollectGeometry geometry, int defaultArea, bool generateLinksByDefault, List<NavMeshBuildMarkup> markups, bool includeOnlyMarkedObjects, List<NavMeshBuildSource> results) { }

	[Address(RVA = "0x1900920", Offset = "0x18FFB20", Length = "0x1BD")]
	[CalledBy(Type = "Unity.AI.Navigation.NavMeshSurface", Member = "CollectSources", ReturnType = "System.Collections.Generic.List`1<NavMeshBuildSource>")]
	[CalledBy(Type = "Unity.AI.Navigation.NavMeshSurface", Member = "CollectSourcesInHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(int), typeof(NavMeshCollectGeometry), typeof(int), typeof(bool), "System.Collections.Generic.List`1<NavMeshBuildMarkup>", typeof(bool), "System.Collections.Generic.List`1<NavMeshBuildSource>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(NavMeshBuilder), Member = "CollectSourcesInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Bounds), typeof(Transform), typeof(bool), typeof(NavMeshCollectGeometry), typeof(int), typeof(bool), typeof(NavMeshBuildMarkup[]), typeof(bool)}, ReturnType = typeof(NavMeshBuildSource[]))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.AI.NavMeshBuildSource>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.AI.NavMeshBuildSource>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000002")]
	public static void CollectSources(Transform root, int includedLayerMask, NavMeshCollectGeometry geometry, int defaultArea, bool generateLinksByDefault, List<NavMeshBuildMarkup> markups, bool includeOnlyMarkedObjects, List<NavMeshBuildSource> results) { }

	[Address(RVA = "0x1900710", Offset = "0x18FF910", Length = "0x201")]
	[CalledBy(Type = typeof(NavMeshBuilder), Member = "CollectSources", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bounds), typeof(int), typeof(NavMeshCollectGeometry), typeof(int), typeof(bool), typeof(System.Collections.Generic.List`1<UnityEngine.AI.NavMeshBuildMarkup>), typeof(bool), typeof(System.Collections.Generic.List`1<UnityEngine.AI.NavMeshBuildSource>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NavMeshBuilder), Member = "CollectSources", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(int), typeof(NavMeshCollectGeometry), typeof(int), typeof(bool), typeof(System.Collections.Generic.List`1<UnityEngine.AI.NavMeshBuildMarkup>), typeof(bool), typeof(System.Collections.Generic.List`1<UnityEngine.AI.NavMeshBuildSource>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1818FF640")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000003")]
	private static NavMeshBuildSource[] CollectSourcesInternal(int includedLayerMask, Bounds includedWorldBounds, Transform root, bool useBounds, NavMeshCollectGeometry geometry, int defaultArea, bool generateLinksByDefault, NavMeshBuildMarkup[] markups, bool includeOnlyMarkedObjects) { }

	[Address(RVA = "0x1900690", Offset = "0x18FF890", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000008")]
	private static void CollectSourcesInternal_Injected(int includedLayerMask, in Bounds includedWorldBounds, IntPtr root, bool useBounds, NavMeshCollectGeometry geometry, int defaultArea, bool generateLinksByDefault, ref ManagedSpanWrapper markups, bool includeOnlyMarkedObjects, out BlittableArrayWrapper ret) { }

	[Address(RVA = "0x1900E40", Offset = "0x1900040", Length = "0x1D7")]
	[CalledBy(Type = "Unity.AI.Navigation.NavMeshSurface", Member = "UpdateNavMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NavMeshData)}, ReturnType = typeof(AsyncOperation))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = "UnityEngine.AsyncOperation+BindingsMarshaller", Member = "ConvertToManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(AsyncOperation))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000006")]
	public static AsyncOperation UpdateNavMeshDataAsync(NavMeshData data, NavMeshBuildSettings buildSettings, List<NavMeshBuildSource> sources, Bounds localBounds) { }

	[Address(RVA = "0x1900D90", Offset = "0x18FFF90", Length = "0xAB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = "UnityEngine.AsyncOperation+BindingsMarshaller", Member = "ConvertToManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(AsyncOperation))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000007")]
	private static AsyncOperation UpdateNavMeshDataAsyncListInternal(NavMeshData data, NavMeshBuildSettings buildSettings, object sources, Bounds localBounds) { }

	[Address(RVA = "0x1900D20", Offset = "0x18FFF20", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600000A")]
	private static IntPtr UpdateNavMeshDataAsyncListInternal_Injected(IntPtr data, in NavMeshBuildSettings buildSettings, object sources, in Bounds localBounds) { }

	[Address(RVA = "0x1901090", Offset = "0x1900290", Length = "0x9A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000005")]
	private static bool UpdateNavMeshDataListInternal(NavMeshData data, NavMeshBuildSettings buildSettings, object sources, Bounds localBounds) { }

	[Address(RVA = "0x1901020", Offset = "0x1900220", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000009")]
	private static bool UpdateNavMeshDataListInternal_Injected(IntPtr data, in NavMeshBuildSettings buildSettings, object sources, in Bounds localBounds) { }

}

