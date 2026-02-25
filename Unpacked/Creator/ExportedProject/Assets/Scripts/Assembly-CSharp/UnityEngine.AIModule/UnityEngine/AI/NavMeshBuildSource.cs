namespace UnityEngine.AI;

[NativeHeader("Modules/AI/Public/NavMeshBindingTypes.h")]
[Token(Token = "0x200000E")]
[UsedByNativeCode]
public struct NavMeshBuildSource
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400001A")]
	private Matrix4x4 m_Transform; //Field offset: 0x0
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400001B")]
	private Vector3 m_Size; //Field offset: 0x40
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x400001C")]
	private NavMeshBuildSourceShape m_Shape; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400001D")]
	private int m_Area; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x400001E")]
	private int m_InstanceID; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400001F")]
	private int m_ComponentID; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000020")]
	private int m_GenerateLinks; //Field offset: 0x5C

	[Token(Token = "0x1700001A")]
	public int area
	{
		[Address(RVA = "0x33C7F0", Offset = "0x33B9F0", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000057")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700001C")]
	public Component component
	{
		[Address(RVA = "0x1900290", Offset = "0x18FF490", Length = "0x5C")]
		[CalledBy(Type = "Unity.AI.Navigation.NavMeshSurface+<>c", Member = "<CollectSources>b__87_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NavMeshBuildSource)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "Unity.AI.Navigation.NavMeshSurface+<>c", Member = "<CollectSources>b__87_2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NavMeshBuildSource)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = "UnityEngine.Bindings.Unmarshal", Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000059")]
		 get { } //Length: 92
	}

	[Token(Token = "0x17000019")]
	public NavMeshBuildSourceShape shape
	{
		[Address(RVA = "0x19002F0", Offset = "0x18FF4F0", Length = "0x6")]
		[CalledBy(Type = "Unity.AI.Navigation.NavMeshSurface", Member = "CalculateWorldBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<NavMeshBuildSource>"}, ReturnType = typeof(Bounds))]
		[CallerCount(Count = 1)]
		[Token(Token = "0x6000055")]
		 get { } //Length: 6
		[Address(RVA = "0x5B9B40", Offset = "0x5B8D40", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000056")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000018")]
	public Vector3 size
	{
		[Address(RVA = "0x1900300", Offset = "0x18FF500", Length = "0x13")]
		[CalledBy(Type = "Unity.AI.Navigation.NavMeshSurface", Member = "CalculateWorldBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<NavMeshBuildSource>"}, ReturnType = typeof(Bounds))]
		[CallerCount(Count = 1)]
		[Token(Token = "0x6000053")]
		 get { } //Length: 19
		[Address(RVA = "0x5A8E70", Offset = "0x5A8070", Length = "0x10")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000054")]
		 set { } //Length: 16
	}

	[Token(Token = "0x1700001B")]
	public object sourceObject
	{
		[Address(RVA = "0x1900320", Offset = "0x18FF520", Length = "0x5C")]
		[CalledBy(Type = "Unity.AI.Navigation.NavMeshSurface", Member = "CalculateWorldBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<NavMeshBuildSource>"}, ReturnType = typeof(Bounds))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = "UnityEngine.Bindings.Unmarshal", Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000058")]
		 get { } //Length: 92
	}

	[Token(Token = "0x17000017")]
	public Matrix4x4 transform
	{
		[Address(RVA = "0x1900380", Offset = "0x18FF580", Length = "0x22")]
		[CalledBy(Type = "Unity.AI.Navigation.NavMeshSurface", Member = "CalculateWorldBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<NavMeshBuildSource>"}, ReturnType = typeof(Bounds))]
		[CallerCount(Count = 3)]
		[Token(Token = "0x6000051")]
		 get { } //Length: 34
		[Address(RVA = "0x19003B0", Offset = "0x18FF5B0", Length = "0x1F")]
		[CalledBy(Type = "Unity.AI.Navigation.NavMeshSurface", Member = "AppendModifierVolumes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<NavMeshBuildSource>&"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Token(Token = "0x6000052")]
		 set { } //Length: 31
	}

	[Address(RVA = "0x1900290", Offset = "0x18FF490", Length = "0x5C")]
	[CalledBy(Type = "Unity.AI.Navigation.NavMeshSurface+<>c", Member = "<CollectSources>b__87_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NavMeshBuildSource)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Unity.AI.Navigation.NavMeshSurface+<>c", Member = "<CollectSources>b__87_2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NavMeshBuildSource)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = "UnityEngine.Bindings.Unmarshal", Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000059")]
	public Component get_component() { }

	[Address(RVA = "0x19002F0", Offset = "0x18FF4F0", Length = "0x6")]
	[CalledBy(Type = "Unity.AI.Navigation.NavMeshSurface", Member = "CalculateWorldBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<NavMeshBuildSource>"}, ReturnType = typeof(Bounds))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x6000055")]
	public NavMeshBuildSourceShape get_shape() { }

	[Address(RVA = "0x1900300", Offset = "0x18FF500", Length = "0x13")]
	[CalledBy(Type = "Unity.AI.Navigation.NavMeshSurface", Member = "CalculateWorldBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<NavMeshBuildSource>"}, ReturnType = typeof(Bounds))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x6000053")]
	public Vector3 get_size() { }

	[Address(RVA = "0x1900320", Offset = "0x18FF520", Length = "0x5C")]
	[CalledBy(Type = "Unity.AI.Navigation.NavMeshSurface", Member = "CalculateWorldBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<NavMeshBuildSource>"}, ReturnType = typeof(Bounds))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = "UnityEngine.Bindings.Unmarshal", Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000058")]
	public object get_sourceObject() { }

	[Address(RVA = "0x1900380", Offset = "0x18FF580", Length = "0x22")]
	[CalledBy(Type = "Unity.AI.Navigation.NavMeshSurface", Member = "CalculateWorldBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<NavMeshBuildSource>"}, ReturnType = typeof(Bounds))]
	[CallerCount(Count = 3)]
	[Token(Token = "0x6000051")]
	public Matrix4x4 get_transform() { }

	[Address(RVA = "0x1900190", Offset = "0x18FF390", Length = "0x5B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = "UnityEngine.Bindings.Unmarshal", Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	[StaticAccessor("NavMeshBuildSource", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x600005A")]
	private static Component InternalGetComponent(int instanceID) { }

	[Address(RVA = "0x1900150", Offset = "0x18FF350", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600005C")]
	private static IntPtr InternalGetComponent_Injected(int instanceID) { }

	[Address(RVA = "0x1900230", Offset = "0x18FF430", Length = "0x5B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = "UnityEngine.Bindings.Unmarshal", Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	[StaticAccessor("NavMeshBuildSource", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x600005B")]
	private static object InternalGetObject(int instanceID) { }

	[Address(RVA = "0x19001F0", Offset = "0x18FF3F0", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600005D")]
	private static IntPtr InternalGetObject_Injected(int instanceID) { }

	[Address(RVA = "0x33C7F0", Offset = "0x33B9F0", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000057")]
	public void set_area(int value) { }

	[Address(RVA = "0x5B9B40", Offset = "0x5B8D40", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000056")]
	public void set_shape(NavMeshBuildSourceShape value) { }

	[Address(RVA = "0x5A8E70", Offset = "0x5A8070", Length = "0x10")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000054")]
	public void set_size(Vector3 value) { }

	[Address(RVA = "0x19003B0", Offset = "0x18FF5B0", Length = "0x1F")]
	[CalledBy(Type = "Unity.AI.Navigation.NavMeshSurface", Member = "AppendModifierVolumes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<NavMeshBuildSource>&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x6000052")]
	public void set_transform(Matrix4x4 value) { }

}

