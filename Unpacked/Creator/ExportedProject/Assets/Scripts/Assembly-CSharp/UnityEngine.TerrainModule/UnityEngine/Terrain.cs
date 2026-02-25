namespace UnityEngine;

[NativeHeader("Modules/Terrain/Public/Terrain.h")]
[NativeHeader("Runtime/Interfaces/ITerrainManager.h")]
[NativeHeader("TerrainScriptingClasses.h")]
[StaticAccessor("GetITerrainManager()", StaticAccessorType::Arrow (1))]
[Token(Token = "0x2000002")]
[UsedByNativeCode]
public sealed class Terrain : Behaviour
{

	[NativeProperty("ActiveTerrainsScriptingArray")]
	[Token(Token = "0x17000006")]
	public static Terrain[] activeTerrains
	{
		[Address(RVA = "0x1A1D470", Offset = "0x1A1C670", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000007")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000003")]
	public bool allowAutoConnect
	{
		[Address(RVA = "0x1A1D4E0", Offset = "0x1A1C6E0", Length = "0x76")]
		[CalledBy(Type = typeof(TerrainUtility), Member = "CollectTerrains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.Int32, UnityEngine.TerrainUtils.TerrainMap>))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000003")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000002")]
	public bool drawHeightmap
	{
		[Address(RVA = "0x1A1D7F0", Offset = "0x1A1C9F0", Length = "0x86")]
		[CalledBy(Type = "Mirror.InterestManagementBase", Member = "SetHostVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkIdentity", typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000002")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000005")]
	public bool drawTreesAndFoliage
	{
		[Address(RVA = "0x1A1D8D0", Offset = "0x1A1CAD0", Length = "0x86")]
		[CalledBy(Type = "Mirror.InterestManagementBase", Member = "SetHostVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkIdentity", typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000005")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000004")]
	public int groupingID
	{
		[Address(RVA = "0x1A1D5A0", Offset = "0x1A1C7A0", Length = "0x76")]
		[CalledBy(Type = typeof(TerrainUtility), Member = "CollectTerrains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.Int32, UnityEngine.TerrainUtils.TerrainMap>))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000004")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000001")]
	public TerrainData terrainData
	{
		[Address(RVA = "0x1A1D660", Offset = "0x1A1C860", Length = "0x135")]
		[CalledBy(Type = typeof(TerrainMap), Member = "CreateFromPlacement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Terrain), typeof(System.Predicate`1<UnityEngine.Terrain>), typeof(bool)}, ReturnType = typeof(TerrainMap))]
		[CalledBy(Type = typeof(TerrainMap), Member = "CreateFromPlacement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(System.Predicate`1<UnityEngine.Terrain>), typeof(bool)}, ReturnType = typeof(TerrainMap))]
		[CalledBy(Type = typeof(TerrainMap), Member = "AddTerrainInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Terrain)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TerrainMap), Member = "ValidateTerrain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000001")]
		 get { } //Length: 309
	}

	[Address(RVA = "0x2C7050", Offset = "0x2C6250", Length = "0x7")]
	[CallerCount(Count = 60)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000008")]
	public Terrain() { }

	[Address(RVA = "0x1A1D470", Offset = "0x1A1C670", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000007")]
	public static Terrain[] get_activeTerrains() { }

	[Address(RVA = "0x1A1D4E0", Offset = "0x1A1C6E0", Length = "0x76")]
	[CalledBy(Type = typeof(TerrainUtility), Member = "CollectTerrains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.Int32, UnityEngine.TerrainUtils.TerrainMap>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000003")]
	public bool get_allowAutoConnect() { }

	[Address(RVA = "0x1A1D4A0", Offset = "0x1A1C6A0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600000B")]
	private static bool get_allowAutoConnect_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1A1D5A0", Offset = "0x1A1C7A0", Length = "0x76")]
	[CalledBy(Type = typeof(TerrainUtility), Member = "CollectTerrains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.Int32, UnityEngine.TerrainUtils.TerrainMap>))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000004")]
	public int get_groupingID() { }

	[Address(RVA = "0x1A1D560", Offset = "0x1A1C760", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600000C")]
	private static int get_groupingID_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1A1D660", Offset = "0x1A1C860", Length = "0x135")]
	[CalledBy(Type = typeof(TerrainMap), Member = "CreateFromPlacement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Terrain), typeof(System.Predicate`1<UnityEngine.Terrain>), typeof(bool)}, ReturnType = typeof(TerrainMap))]
	[CalledBy(Type = typeof(TerrainMap), Member = "CreateFromPlacement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(System.Predicate`1<UnityEngine.Terrain>), typeof(bool)}, ReturnType = typeof(TerrainMap))]
	[CalledBy(Type = typeof(TerrainMap), Member = "AddTerrainInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Terrain)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TerrainMap), Member = "ValidateTerrain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000001")]
	public TerrainData get_terrainData() { }

	[Address(RVA = "0x1A1D620", Offset = "0x1A1C820", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000009")]
	private static IntPtr get_terrainData_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1A1D7F0", Offset = "0x1A1C9F0", Length = "0x86")]
	[CalledBy(Type = "Mirror.InterestManagementBase", Member = "SetHostVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkIdentity", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000002")]
	public void set_drawHeightmap(bool value) { }

	[Address(RVA = "0x1A1D7A0", Offset = "0x1A1C9A0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600000A")]
	private static void set_drawHeightmap_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x1A1D8D0", Offset = "0x1A1CAD0", Length = "0x86")]
	[CalledBy(Type = "Mirror.InterestManagementBase", Member = "SetHostVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkIdentity", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000005")]
	public void set_drawTreesAndFoliage(bool value) { }

	[Address(RVA = "0x1A1D880", Offset = "0x1A1CA80", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600000D")]
	private static void set_drawTreesAndFoliage_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x1A1D320", Offset = "0x1A1C520", Length = "0x145")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000006")]
	public void SetNeighbors(Terrain left, Terrain top, Terrain right, Terrain bottom) { }

	[Address(RVA = "0x1A1D2B0", Offset = "0x1A1C4B0", Length = "0x62")]
	[CalledBy(Type = typeof(TerrainUtility), Member = "ClearConnectivity", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TerrainUtility), Member = "AutoConnect", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600000E")]
	private static void SetNeighbors_Injected(IntPtr _unity_self, IntPtr left, IntPtr top, IntPtr right, IntPtr bottom) { }

}

