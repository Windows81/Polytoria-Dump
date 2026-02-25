namespace UnityEngine.TerrainUtils;

[Token(Token = "0x200000A")]
public class TerrainMap
{
	[CompilerGenerated]
	[Token(Token = "0x200000B")]
	private sealed class <>c__DisplayClass3_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400001F")]
		public int groupID; //Field offset: 0x10

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000027")]
		public <>c__DisplayClass3_0() { }

		[Address(RVA = "0x1A1DBE0", Offset = "0x1A1CDE0", Length = "0xD8")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsInvalidInstructions]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000028")]
		internal bool <CreateFromPlacement>b__0(Terrain x) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400001C")]
	private Vector3 m_patchSize; //Field offset: 0x10
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400001D")]
	private TerrainMapStatusCode m_errorCode; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400001E")]
	private Dictionary<TerrainTileCoord, Terrain> m_terrainTiles; //Field offset: 0x20

	[Token(Token = "0x17000009")]
	public Dictionary<TerrainTileCoord, Terrain> terrainTiles
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000021")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1A1C7C0", Offset = "0x1A1B9C0", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.TerrainUtils.TerrainTileCoord, System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000022")]
	public TerrainMap() { }

	[Address(RVA = "0x1A1B3B0", Offset = "0x1A1A5B0", Length = "0x267")]
	[CalledBy(Type = typeof(TerrainMap), Member = "TryToAddTerrain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Terrain)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(Terrain), Member = "get_terrainData", ReturnType = typeof(TerrainData))]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.TerrainUtils.TerrainTileCoord, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TerrainTileCoord), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000023")]
	private void AddTerrainInternal(int x, int z, Terrain terrain) { }

	[Address(RVA = "0x1A1B990", Offset = "0x1A1AB90", Length = "0x3DF")]
	[CalledBy(Type = typeof(TerrainUtility), Member = "CollectTerrains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.Int32, UnityEngine.TerrainUtils.TerrainMap>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Terrain), Member = "get_terrainData", ReturnType = typeof(TerrainData))]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(TerrainMap), Member = "CreateFromPlacement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(System.Predicate`1<UnityEngine.Terrain>), typeof(bool)}, ReturnType = typeof(TerrainMap))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x600001F")]
	public static TerrainMap CreateFromPlacement(Terrain originTerrain, Predicate<Terrain> filter = null, bool fullValidation = true) { }

	[Address(RVA = "0x1A1B620", Offset = "0x1A1A820", Length = "0x36F")]
	[CalledBy(Type = typeof(TerrainMap), Member = "CreateFromPlacement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Terrain), typeof(System.Predicate`1<UnityEngine.Terrain>), typeof(bool)}, ReturnType = typeof(TerrainMap))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(TerrainMap), Member = "Validate", ReturnType = typeof(TerrainMapStatusCode))]
	[Calls(Type = typeof(TerrainMap), Member = "TryToAddTerrain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Terrain)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC070")]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Terrain), Member = "get_terrainData", ReturnType = typeof(TerrainData))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.TerrainUtils.TerrainTileCoord, System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000020")]
	public static TerrainMap CreateFromPlacement(Vector2 gridOrigin, Vector2 gridSize, Predicate<Terrain> filter = null, bool fullValidation = true) { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000021")]
	public Dictionary<TerrainTileCoord, Terrain> get_terrainTiles() { }

	[Address(RVA = "0x1A1BD70", Offset = "0x1A1AF70", Length = "0x7D")]
	[CalledBy(Type = typeof(TerrainMap), Member = "TryToAddTerrain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Terrain)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TerrainMap), Member = "ValidateTerrain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TerrainUtility), Member = "AutoConnect", ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.TerrainUtils.TerrainTileCoord, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TerrainTileCoord), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600001E")]
	public Terrain GetTerrain(int tileX, int tileZ) { }

	[Address(RVA = "0x1A1BDF0", Offset = "0x1A1AFF0", Length = "0x10B")]
	[CalledBy(Type = typeof(TerrainMap), Member = "CreateFromPlacement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(System.Predicate`1<UnityEngine.Terrain>), typeof(bool)}, ReturnType = typeof(TerrainMap))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TerrainMap), Member = "GetTerrain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(Terrain))]
	[Calls(Type = typeof(TerrainMap), Member = "AddTerrainInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Terrain)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000024")]
	private bool TryToAddTerrain(int tileX, int tileZ, Terrain terrain) { }

	[Address(RVA = "0x1A1C680", Offset = "0x1A1B880", Length = "0x139")]
	[CalledBy(Type = typeof(TerrainMap), Member = "CreateFromPlacement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(System.Predicate`1<UnityEngine.Terrain>), typeof(bool)}, ReturnType = typeof(TerrainMap))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TerrainMap), Member = "ValidateTerrain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6000026")]
	private TerrainMapStatusCode Validate() { }

	[Address(RVA = "0x1A1BF00", Offset = "0x1A1B100", Length = "0x774")]
	[CalledBy(Type = typeof(TerrainMap), Member = "Validate", ReturnType = typeof(TerrainMapStatusCode))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TerrainMap), Member = "GetTerrain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(Terrain))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Terrain), Member = "get_terrainData", ReturnType = typeof(TerrainData))]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000025")]
	private void ValidateTerrain(int tileX, int tileZ) { }

}

