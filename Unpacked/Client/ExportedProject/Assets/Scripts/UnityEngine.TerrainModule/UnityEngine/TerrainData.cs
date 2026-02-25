namespace UnityEngine;

[NativeHeader("Modules/Terrain/Public/TerrainDataScriptingInterface.h")]
[NativeHeader("TerrainScriptingClasses.h")]
[Token(Token = "0x2000006")]
[UsedByNativeCode]
public sealed class TerrainData : object
{
	[Token(Token = "0x2000007")]
	private enum BoundaryValueType
	{
		MaxHeightmapRes = 0,
		MinDetailResPerPatch = 1,
		MaxDetailResPerPatch = 2,
		MaxDetailPatchCount = 3,
		MaxCoveragePerRes = 4,
		MinAlphamapRes = 5,
		MaxAlphamapRes = 6,
		MinBaseMapRes = 7,
		MaxBaseMapRes = 8,
	}

	[Token(Token = "0x4000003")]
	internal static readonly int k_MaximumResolution; //Field offset: 0x0
	[Token(Token = "0x4000004")]
	internal static readonly int k_MinimumDetailResolutionPerPatch; //Field offset: 0x4
	[Token(Token = "0x4000005")]
	internal static readonly int k_MaximumDetailResolutionPerPatch; //Field offset: 0x8
	[Token(Token = "0x4000006")]
	internal static readonly int k_MaximumDetailPatchCount; //Field offset: 0xC
	[Token(Token = "0x4000007")]
	internal static readonly int k_MinimumAlphamapResolution; //Field offset: 0x10
	[Token(Token = "0x4000008")]
	internal static readonly int k_MaximumAlphamapResolution; //Field offset: 0x14
	[Token(Token = "0x4000009")]
	internal static readonly int k_MinimumBaseMapResolution; //Field offset: 0x18
	[Token(Token = "0x400000A")]
	internal static readonly int k_MaximumBaseMapResolution; //Field offset: 0x1C

	[Token(Token = "0x17000007")]
	public Vector3 size
	{
		[Address(RVA = "0x1A1B210", Offset = "0x1A1A410", Length = "0xB1")]
		[CalledBy(Type = "Unity.AI.Navigation.NavMeshSurface", Member = "CalculateWorldBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<NavMeshBuildSource>"}, ReturnType = typeof(Bounds))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[NativeName("GetHeightmap().GetSize")]
		[Token(Token = "0x6000016")]
		 get { } //Length: 177
	}

	[Token(Token = "0x17000008")]
	internal Terrain[] users
	{
		[Address(RVA = "0x1A1B310", Offset = "0x1A1A510", Length = "0x97")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000018")]
		internal get { } //Length: 151
	}

	[Address(RVA = "0x1A1AFE0", Offset = "0x1A1A1E0", Length = "0x1DA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 8)]
	[Token(Token = "0x6000019")]
	private static TerrainData() { }

	[Address(RVA = "0x1A1B210", Offset = "0x1A1A410", Length = "0xB1")]
	[CalledBy(Type = "Unity.AI.Navigation.NavMeshSurface", Member = "CalculateWorldBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<NavMeshBuildSource>"}, ReturnType = typeof(Bounds))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeName("GetHeightmap().GetSize")]
	[Token(Token = "0x6000016")]
	public Vector3 get_size() { }

	[Address(RVA = "0x1A1B1C0", Offset = "0x1A1A3C0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600001A")]
	private static void get_size_Injected(IntPtr _unity_self, out Vector3 ret) { }

	[Address(RVA = "0x1A1B310", Offset = "0x1A1A510", Length = "0x97")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000018")]
	internal Terrain[] get_users() { }

	[Address(RVA = "0x1A1B2D0", Offset = "0x1A1A4D0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600001C")]
	private static Terrain[] get_users_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1A1AF00", Offset = "0x1A1A100", Length = "0x97")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeName("GetSplatDatabase().GetAlphamapResolution")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000017")]
	internal float GetAlphamapResolutionInternal() { }

	[Address(RVA = "0x1A1AEC0", Offset = "0x1A1A0C0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600001B")]
	private static float GetAlphamapResolutionInternal_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1A1AFA0", Offset = "0x1A1A1A0", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[StaticAccessor("TerrainDataScriptingInterface", StaticAccessorType::DoubleColon (2))]
	[ThreadSafe]
	[Token(Token = "0x6000015")]
	private static int GetBoundaryValue(BoundaryValueType type) { }

}

