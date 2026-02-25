namespace Polytoria.Datamodel.Proxies;

[Token(Token = "0x20003A0")]
public class EnvironmentProxy : InstanceProxy
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000FEA")]
	private readonly Environment environment; //Field offset: 0x18

	[Token(Token = "0x17000B89")]
	public bool AutoGenerateNavMesh
	{
		[Address(RVA = "0x4A3D20", Offset = "0x4A2F20", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600271B")]
		 get { } //Length: 30
		[Address(RVA = "0x4A3E40", Offset = "0x4A3040", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600271C")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000B87")]
	public Color FogColor
	{
		[Address(RVA = "0x4A3D40", Offset = "0x4A2F40", Length = "0x24")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002717")]
		 get { } //Length: 36
		[Address(RVA = "0x4A3E60", Offset = "0x4A3060", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Environment), Member = "set_FogColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002718")]
		 set { } //Length: 44
	}

	[Token(Token = "0x17000B84")]
	public bool FogEnabled
	{
		[Address(RVA = "0x4A3D70", Offset = "0x4A2F70", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002711")]
		 get { } //Length: 30
		[Address(RVA = "0x4A3E90", Offset = "0x4A3090", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Environment), Member = "set_FogEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002712")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000B86")]
	public float FogEndDistance
	{
		[Address(RVA = "0x4A3D90", Offset = "0x4A2F90", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002715")]
		 get { } //Length: 31
		[Address(RVA = "0x4A3EB0", Offset = "0x4A30B0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Environment), Member = "set_FogEndDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002716")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000B85")]
	public float FogStartDistance
	{
		[Address(RVA = "0x4A3DB0", Offset = "0x4A2FB0", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002713")]
		 get { } //Length: 31
		[Address(RVA = "0x4A3ED0", Offset = "0x4A30D0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Environment), Member = "set_FogStartDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002714")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000B83")]
	public Vector3 Gravity
	{
		[Address(RVA = "0x4A3DD0", Offset = "0x4A2FD0", Length = "0x2F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600270F")]
		 get { } //Length: 47
		[Address(RVA = "0x4A3EF0", Offset = "0x4A30F0", Length = "0x35")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Environment), Member = "set_Gravity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002710")]
		 set { } //Length: 53
	}

	[Token(Token = "0x17000B88")]
	public float PartDestroyHeight
	{
		[Address(RVA = "0x4A3E00", Offset = "0x4A3000", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002719")]
		 get { } //Length: 31
		[Address(RVA = "0x4A3F30", Offset = "0x4A3130", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600271A")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000B82")]
	public SkyboxPreset Skybox
	{
		[Address(RVA = "0x4A3E20", Offset = "0x4A3020", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600270D")]
		 get { } //Length: 29
		[Address(RVA = "0x4A3F50", Offset = "0x4A3150", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Environment), Member = "set_Skybox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkyboxPreset)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600270E")]
		 set { } //Length: 30
	}

	[Address(RVA = "0x4A1050", Offset = "0x4A0250", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[MoonSharpHidden]
	[Token(Token = "0x600270C")]
	public EnvironmentProxy(Environment target) { }

	[Address(RVA = "0x4A3A40", Offset = "0x4A2C40", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Environment), Member = "CreateExplosion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float), typeof(float), typeof(bool), typeof(DynValue), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[LuaCallbackParameter("callback", typeof(Instance), "hit", False)]
	[Token(Token = "0x600271D")]
	public void CreateExplosion(Vector3 position, float radius = 10, float force = 5000, bool affectKinematic = true, DynValue callback = null, float damage = 10000) { }

	[Address(RVA = "0x4A3D20", Offset = "0x4A2F20", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600271B")]
	public bool get_AutoGenerateNavMesh() { }

	[Address(RVA = "0x4A3D40", Offset = "0x4A2F40", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002717")]
	public Color get_FogColor() { }

	[Address(RVA = "0x4A3D70", Offset = "0x4A2F70", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002711")]
	public bool get_FogEnabled() { }

	[Address(RVA = "0x4A3D90", Offset = "0x4A2F90", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002715")]
	public float get_FogEndDistance() { }

	[Address(RVA = "0x4A3DB0", Offset = "0x4A2FB0", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002713")]
	public float get_FogStartDistance() { }

	[Address(RVA = "0x4A3DD0", Offset = "0x4A2FD0", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600270F")]
	public Vector3 get_Gravity() { }

	[Address(RVA = "0x4A3E00", Offset = "0x4A3000", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002719")]
	public float get_PartDestroyHeight() { }

	[Address(RVA = "0x4A3E20", Offset = "0x4A3020", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600270D")]
	public SkyboxPreset get_Skybox() { }

	[Address(RVA = "0x4A3AB0", Offset = "0x4A2CB0", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Environment), Member = "GetPointOnNavMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002723")]
	public Vector3 GetPointOnNavMesh(Vector3 position, float maxDistance = 100) { }

	[Address(RVA = "0x4A3B10", Offset = "0x4A2D10", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Environment), Member = "OverlapBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(System.Collections.Generic.List`1<Polytoria.Datamodel.Instance>)}, ReturnType = typeof(Instance[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002721")]
	public Instance[] OverlapBox(Vector3 center, Vector3 halfExtents, Vector3 rotation, List<Instance> ignoreList = null) { }

	[Address(RVA = "0x4A3B90", Offset = "0x4A2D90", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Environment), Member = "OverlapSphere", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float), typeof(System.Collections.Generic.List`1<Polytoria.Datamodel.Instance>)}, ReturnType = typeof(Instance[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002720")]
	public Instance[] OverlapSphere(Vector3 position, float radius, List<Instance> ignoreList = null) { }

	[Address(RVA = "0x4A3C40", Offset = "0x4A2E40", Length = "0xB1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Environment), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), typeof(System.Collections.Generic.List`1<Polytoria.Datamodel.Instance>)}, ReturnType = typeof(System.Nullable`1<Polytoria.Datamodel.RayResult>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600271E")]
	public Nullable<RayResult> Raycast(Vector3 origin, Vector3 direction, float maxDistance = ∞, List<Instance> ignoreList = null) { }

	[Address(RVA = "0x4A3BD0", Offset = "0x4A2DD0", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Environment), Member = "RaycastAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), typeof(System.Collections.Generic.List`1<Polytoria.Datamodel.Instance>)}, ReturnType = typeof(RayResult[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600271F")]
	public RayResult[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance = ∞, List<Instance> ignoreList = null) { }

	[Address(RVA = "0x4A3D00", Offset = "0x4A2F00", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Environment), Member = "RebuildNavMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002722")]
	public void RebuildNavMesh(Instance root) { }

	[Address(RVA = "0x4A3E40", Offset = "0x4A3040", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600271C")]
	public void set_AutoGenerateNavMesh(bool value) { }

	[Address(RVA = "0x4A3E60", Offset = "0x4A3060", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Environment), Member = "set_FogColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002718")]
	public void set_FogColor(Color value) { }

	[Address(RVA = "0x4A3E90", Offset = "0x4A3090", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Environment), Member = "set_FogEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002712")]
	public void set_FogEnabled(bool value) { }

	[Address(RVA = "0x4A3EB0", Offset = "0x4A30B0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Environment), Member = "set_FogEndDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002716")]
	public void set_FogEndDistance(float value) { }

	[Address(RVA = "0x4A3ED0", Offset = "0x4A30D0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Environment), Member = "set_FogStartDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002714")]
	public void set_FogStartDistance(float value) { }

	[Address(RVA = "0x4A3EF0", Offset = "0x4A30F0", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Environment), Member = "set_Gravity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002710")]
	public void set_Gravity(Vector3 value) { }

	[Address(RVA = "0x4A3F30", Offset = "0x4A3130", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600271A")]
	public void set_PartDestroyHeight(float value) { }

	[Address(RVA = "0x4A3F50", Offset = "0x4A3150", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Environment), Member = "set_Skybox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkyboxPreset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600270E")]
	public void set_Skybox(SkyboxPreset value) { }

}

