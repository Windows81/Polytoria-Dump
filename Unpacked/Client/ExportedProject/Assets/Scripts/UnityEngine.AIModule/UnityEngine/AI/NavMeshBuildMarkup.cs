namespace UnityEngine.AI;

[NativeHeader("Modules/AI/Public/NavMeshBindingTypes.h")]
[Token(Token = "0x200000F")]
public struct NavMeshBuildMarkup
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000021")]
	private int m_OverrideArea; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000022")]
	private int m_Area; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000023")]
	private int m_InheritIgnoreFromBuild; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000024")]
	private int m_IgnoreFromBuild; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000025")]
	private int m_OverrideGenerateLinks; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000026")]
	private int m_GenerateLinks; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000027")]
	private int m_InstanceID; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000028")]
	private int m_IgnoreChildren; //Field offset: 0x1C

	[Token(Token = "0x17000022")]
	public bool applyToChildren
	{
		[Address(RVA = "0x1900030", Offset = "0x18FF230", Length = "0xC")]
		[CalledBy(Type = "Unity.AI.Navigation.NavMeshSurface", Member = "CollectSources", ReturnType = "System.Collections.Generic.List`1<NavMeshBuildSource>")]
		[CallerCount(Count = 1)]
		[Token(Token = "0x6000063")]
		 set { } //Length: 12
	}

	[Token(Token = "0x1700001E")]
	public int area
	{
		[Address(RVA = "0x3B8830", Offset = "0x3B7A30", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x600005F")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000021")]
	public bool generateLinks
	{
		[Address(RVA = "0x1900040", Offset = "0x18FF240", Length = "0x9")]
		[CalledBy(Type = "Unity.AI.Navigation.NavMeshSurface", Member = "CollectSources", ReturnType = "System.Collections.Generic.List`1<NavMeshBuildSource>")]
		[CallerCount(Count = 1)]
		[Token(Token = "0x6000062")]
		 set { } //Length: 9
	}

	[Token(Token = "0x1700001F")]
	public bool ignoreFromBuild
	{
		[Address(RVA = "0x1900050", Offset = "0x18FF250", Length = "0x9")]
		[CalledBy(Type = "Unity.AI.Navigation.NavMeshSurface", Member = "CollectSources", ReturnType = "System.Collections.Generic.List`1<NavMeshBuildSource>")]
		[CallerCount(Count = 1)]
		[Token(Token = "0x6000060")]
		 set { } //Length: 9
	}

	[Token(Token = "0x1700001D")]
	public bool overrideArea
	{
		[Address(RVA = "0x1900060", Offset = "0x18FF260", Length = "0x8")]
		[CalledBy(Type = "Unity.AI.Navigation.NavMeshSurface", Member = "CollectSources", ReturnType = "System.Collections.Generic.List`1<NavMeshBuildSource>")]
		[CallerCount(Count = 1)]
		[Token(Token = "0x600005E")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000020")]
	public bool overrideGenerateLinks
	{
		[Address(RVA = "0x1900070", Offset = "0x18FF270", Length = "0x9")]
		[CalledBy(Type = "Unity.AI.Navigation.NavMeshSurface", Member = "CollectSources", ReturnType = "System.Collections.Generic.List`1<NavMeshBuildSource>")]
		[CallerCount(Count = 1)]
		[Token(Token = "0x6000061")]
		 set { } //Length: 9
	}

	[Token(Token = "0x17000023")]
	public Transform root
	{
		[Address(RVA = "0x1900080", Offset = "0x18FF280", Length = "0x84")]
		[CalledBy(Type = "Unity.AI.Navigation.NavMeshSurface", Member = "CollectSources", ReturnType = "System.Collections.Generic.List`1<NavMeshBuildSource>")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000064")]
		 set { } //Length: 132
	}

	[Address(RVA = "0x1900030", Offset = "0x18FF230", Length = "0xC")]
	[CalledBy(Type = "Unity.AI.Navigation.NavMeshSurface", Member = "CollectSources", ReturnType = "System.Collections.Generic.List`1<NavMeshBuildSource>")]
	[CallerCount(Count = 1)]
	[Token(Token = "0x6000063")]
	public void set_applyToChildren(bool value) { }

	[Address(RVA = "0x3B8830", Offset = "0x3B7A30", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x600005F")]
	public void set_area(int value) { }

	[Address(RVA = "0x1900040", Offset = "0x18FF240", Length = "0x9")]
	[CalledBy(Type = "Unity.AI.Navigation.NavMeshSurface", Member = "CollectSources", ReturnType = "System.Collections.Generic.List`1<NavMeshBuildSource>")]
	[CallerCount(Count = 1)]
	[Token(Token = "0x6000062")]
	public void set_generateLinks(bool value) { }

	[Address(RVA = "0x1900050", Offset = "0x18FF250", Length = "0x9")]
	[CalledBy(Type = "Unity.AI.Navigation.NavMeshSurface", Member = "CollectSources", ReturnType = "System.Collections.Generic.List`1<NavMeshBuildSource>")]
	[CallerCount(Count = 1)]
	[Token(Token = "0x6000060")]
	public void set_ignoreFromBuild(bool value) { }

	[Address(RVA = "0x1900060", Offset = "0x18FF260", Length = "0x8")]
	[CalledBy(Type = "Unity.AI.Navigation.NavMeshSurface", Member = "CollectSources", ReturnType = "System.Collections.Generic.List`1<NavMeshBuildSource>")]
	[CallerCount(Count = 1)]
	[Token(Token = "0x600005E")]
	public void set_overrideArea(bool value) { }

	[Address(RVA = "0x1900070", Offset = "0x18FF270", Length = "0x9")]
	[CalledBy(Type = "Unity.AI.Navigation.NavMeshSurface", Member = "CollectSources", ReturnType = "System.Collections.Generic.List`1<NavMeshBuildSource>")]
	[CallerCount(Count = 1)]
	[Token(Token = "0x6000061")]
	public void set_overrideGenerateLinks(bool value) { }

	[Address(RVA = "0x1900080", Offset = "0x18FF280", Length = "0x84")]
	[CalledBy(Type = "Unity.AI.Navigation.NavMeshSurface", Member = "CollectSources", ReturnType = "System.Collections.Generic.List`1<NavMeshBuildSource>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000064")]
	public void set_root(Transform value) { }

}

