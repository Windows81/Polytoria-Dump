namespace UnityEngine.TerrainUtils;

[MovedFrom("UnityEngine.Experimental.TerrainAPI")]
[Token(Token = "0x200000C")]
public static class TerrainUtility
{
	[CompilerGenerated]
	[Token(Token = "0x200000D")]
	private sealed class <>c__DisplayClass2_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000020")]
		public bool onlyAutoConnectedTerrains; //Field offset: 0x10

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600002D")]
		public <>c__DisplayClass2_0() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200000E")]
	private sealed class <>c__DisplayClass2_1
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000021")]
		public Terrain t; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000022")]
		public <>c__DisplayClass2_0 CS$<>8__locals1; //Field offset: 0x18

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600002E")]
		public <>c__DisplayClass2_1() { }

		[Address(RVA = "0x1A1DA60", Offset = "0x1A1CC60", Length = "0x17C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600002F")]
		internal bool <CollectTerrains>b__0(Terrain x) { }

	}


	[Address(RVA = "0x1A1C840", Offset = "0x1A1BA40", Length = "0x590")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Terrain), Member = "SetNeighbors_Injected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(IntPtr), typeof(IntPtr), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TerrainUtility), Member = "ValidTerrainsExist", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(TerrainUtility), Member = "CollectTerrains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.Int32, UnityEngine.TerrainUtils.TerrainMap>))]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TerrainMap), Member = "GetTerrain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(Terrain))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[RequiredByNativeCode]
	[Token(Token = "0x600002C")]
	public static void AutoConnect() { }

	[Address(RVA = "0x1A1CDE0", Offset = "0x1A1BFE0", Length = "0x19E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(Terrain), Member = "SetNeighbors_Injected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(IntPtr), typeof(IntPtr), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600002A")]
	internal static void ClearConnectivity() { }

	[Address(RVA = "0x1A1CF80", Offset = "0x1A1C180", Length = "0x2B2")]
	[CalledBy(Type = typeof(TerrainUtility), Member = "AutoConnect", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TerrainMap), Member = "CreateFromPlacement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Terrain), typeof(System.Predicate`1<UnityEngine.Terrain>), typeof(bool)}, ReturnType = typeof(TerrainMap))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Terrain), Member = "get_groupingID", ReturnType = typeof(int))]
	[Calls(Type = typeof(Terrain), Member = "get_allowAutoConnect", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(TerrainUtility), Member = "ValidTerrainsExist", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600002B")]
	internal static Dictionary<Int32, TerrainMap> CollectTerrains(bool onlyAutoConnectedTerrains = true) { }

	[Address(RVA = "0x1A1D240", Offset = "0x1A1C440", Length = "0x6A")]
	[CalledBy(Type = typeof(TerrainUtility), Member = "CollectTerrains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.Int32, UnityEngine.TerrainUtils.TerrainMap>))]
	[CalledBy(Type = typeof(TerrainUtility), Member = "AutoConnect", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000029")]
	internal static bool ValidTerrainsExist() { }

}

