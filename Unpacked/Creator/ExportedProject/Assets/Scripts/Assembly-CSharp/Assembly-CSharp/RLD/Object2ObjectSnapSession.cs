namespace RLD;

[Token(Token = "0x2000220")]
public class Object2ObjectSnapSession
{
	[Token(Token = "0x2000223")]
	private struct SitSurface
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000843")]
		public SitSurfaceType SurfaceType; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000844")]
		public Vector3 SitPoint; //Field offset: 0x4
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000845")]
		public Plane SitPlane; //Field offset: 0x10

	}

	[Token(Token = "0x2000222")]
	private enum SitSurfaceType
	{
		Invalid = 0,
		Grid = 1,
		Object = 2,
	}

	[Token(Token = "0x2000221")]
	private enum State
	{
		Inactive = 0,
		Active = 1,
	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000831")]
	private Object2ObjectSnapSessionBeginHandler SessionBegin; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000832")]
	private Object2ObjectSnapSessionEndHandler SessionEnd; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000833")]
	private State _state; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000834")]
	private List<GameObject> _targetObjects; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000835")]
	private List<GameObject> _targetParents; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000836")]
	private AABB _targetAABB; //Field offset: 0x38
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000837")]
	private SitSurface _sitSurface; //Field offset: 0x54
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x4000838")]
	private bool _sitBelowSurface; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000839")]
	private Object2ObjectSnapSettings _sharedSettings; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400083A")]
	private Object2ObjectSnapHotkeys _sharedHotkeys; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400083B")]
	private List<LocalTransformSnapshot> _preTargetTransformSnapshots; //Field offset: 0x88

	[Token(Token = "0x1400002F")]
	public event Object2ObjectSnapSessionBeginHandler SessionBegin
	{
		[Address(RVA = "0x598790", Offset = "0x597990", Length = "0x9E")]
		[CalledBy(Type = typeof(RTObjectSelection), Member = "Initialize_SystemCall", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6001492")]
		 add { } //Length: 158
		[Address(RVA = "0x5988D0", Offset = "0x597AD0", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6001493")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x14000030")]
	public event Object2ObjectSnapSessionEndHandler SessionEnd
	{
		[Address(RVA = "0x598830", Offset = "0x597A30", Length = "0x9E")]
		[CalledBy(Type = typeof(RTObjectSelection), Member = "Initialize_SystemCall", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6001494")]
		 add { } //Length: 158
		[Address(RVA = "0x598970", Offset = "0x597B70", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6001495")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x1700068A")]
	public bool IsActive
	{
		[Address(RVA = "0x591DD0", Offset = "0x590FD0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x600149A")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000689")]
	public Object2ObjectSnapHotkeys SharedHotkeys
	{
		[Address(RVA = "0x2DD220", Offset = "0x2DC420", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001498")]
		 get { } //Length: 8
		[Address(RVA = "0x598A10", Offset = "0x597C10", Length = "0x16")]
		[CalledBy(Type = typeof(RTObjectSelection), Member = "Initialize_SystemCall", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6001499")]
		 set { } //Length: 22
	}

	[Token(Token = "0x17000688")]
	public Object2ObjectSnapSettings SharedSettings
	{
		[Address(RVA = "0x2DD190", Offset = "0x2DC390", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001496")]
		 get { } //Length: 5
		[Address(RVA = "0x598A30", Offset = "0x597C30", Length = "0x13")]
		[CalledBy(Type = typeof(RTObjectSelection), Member = "Initialize_SystemCall", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6001497")]
		 set { } //Length: 19
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60014A1")]
	public Object2ObjectSnapSession() { }

	[Address(RVA = "0x598790", Offset = "0x597990", Length = "0x9E")]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "Initialize_SystemCall", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6001492")]
	public void add_SessionBegin(Object2ObjectSnapSessionBeginHandler value) { }

	[Address(RVA = "0x598830", Offset = "0x597A30", Length = "0x9E")]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "Initialize_SystemCall", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6001494")]
	public void add_SessionEnd(Object2ObjectSnapSessionEndHandler value) { }

	[Address(RVA = "0x5977A0", Offset = "0x5969A0", Length = "0x1DB")]
	[CalledBy(Type = typeof(Object2ObjectSnapSession), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GameObjectEx), Member = "FilterParentsOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>))]
	[Calls(Type = typeof(Object2ObjectSnapSession), Member = "CalculateTargetAABB", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object2ObjectSnapSession), Member = "IdentifySitSurface", ReturnType = typeof(bool))]
	[Calls(Type = typeof(LocalTransformSnapshot), Member = "GetSnapshotCollection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>)}, ReturnType = typeof(System.Collections.Generic.List`1<RLD.LocalTransformSnapshot>))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600149D")]
	private bool Begin(IEnumerable<GameObject> targetObjects) { }

	[Address(RVA = "0x597980", Offset = "0x596B80", Length = "0x97")]
	[CalledBy(Type = typeof(Object2ObjectSnapSession), Member = "Begin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Object2ObjectSnapSession), Member = "SnapTargets", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ObjectBounds), Member = "CalcHierarchyCollectionWorldAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(QueryConfig)}, ReturnType = typeof(AABB))]
	[Token(Token = "0x600149F")]
	private bool CalculateTargetAABB() { }

	[Address(RVA = "0x597A20", Offset = "0x596C20", Length = "0x120")]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "SetEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "ForceDelete", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "Update_SystemCall", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LocalTransformSnapshot), Member = "GetSnapshotCollection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>)}, ReturnType = typeof(System.Collections.Generic.List`1<RLD.LocalTransformSnapshot>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(PostObjectTransformsChangedAction), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<RLD.LocalTransformSnapshot>), typeof(System.Collections.Generic.List`1<RLD.LocalTransformSnapshot>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostObjectTransformsChangedAction), Member = "Execute", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600149C")]
	public void End() { }

	[Address(RVA = "0x591DD0", Offset = "0x590FD0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600149A")]
	public bool get_IsActive() { }

	[Address(RVA = "0x2DD220", Offset = "0x2DC420", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001498")]
	public Object2ObjectSnapHotkeys get_SharedHotkeys() { }

	[Address(RVA = "0x2DD190", Offset = "0x2DC390", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001496")]
	public Object2ObjectSnapSettings get_SharedSettings() { }

	[Address(RVA = "0x597B50", Offset = "0x596D50", Length = "0x46C")]
	[CalledBy(Type = typeof(Object2ObjectSnapSession), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Object2ObjectSnapSession), Member = "Begin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RTScene), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(SceneRaycastPrecision), typeof(SceneRaycastFilter)}, ReturnType = typeof(SceneRaycastHit))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001AA10")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObjectEx), Member = "GetAllChildrenAndSelf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SceneRaycastFilter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60014A0")]
	private bool IdentifySitSurface() { }

	[Address(RVA = "0x5988D0", Offset = "0x597AD0", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6001493")]
	public void remove_SessionBegin(Object2ObjectSnapSessionBeginHandler value) { }

	[Address(RVA = "0x598970", Offset = "0x597B70", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6001495")]
	public void remove_SessionEnd(Object2ObjectSnapSessionEndHandler value) { }

	[Address(RVA = "0x598A10", Offset = "0x597C10", Length = "0x16")]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "Initialize_SystemCall", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001499")]
	public void set_SharedHotkeys(Object2ObjectSnapHotkeys value) { }

	[Address(RVA = "0x598A30", Offset = "0x597C30", Length = "0x13")]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "Initialize_SystemCall", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001497")]
	public void set_SharedSettings(Object2ObjectSnapSettings value) { }

	[Address(RVA = "0x597FC0", Offset = "0x5971C0", Length = "0x55A")]
	[CalledBy(Type = typeof(Object2ObjectSnapSession), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(GameObjectEx), Member = "GetAllChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Hotkeys), Member = "IsActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Object2ObjectSnap), Member = "Snap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(Config)}, ReturnType = typeof(SnapResult))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(ObjectSurfaceSnap), Member = "CalculateSitOnSurfaceOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AABB), typeof(Plane), typeof(float)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(PlaneEx), Member = "InvertNormal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Plane)}, ReturnType = typeof(Plane))]
	[Calls(Type = typeof(Object2ObjectSnapSession), Member = "CalculateTargetAABB", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Token(Token = "0x600149E")]
	private void SnapTargets() { }

	[Address(RVA = "0x598520", Offset = "0x597720", Length = "0x269")]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "Update_SystemCall", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object2ObjectSnapSession), Member = "Begin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PostObjectTransformsChangedAction), Member = "Execute", ReturnType = typeof(void))]
	[Calls(Type = typeof(PostObjectTransformsChangedAction), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<RLD.LocalTransformSnapshot>), typeof(System.Collections.Generic.List`1<RLD.LocalTransformSnapshot>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LocalTransformSnapshot), Member = "GetSnapshotCollection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>)}, ReturnType = typeof(System.Collections.Generic.List`1<RLD.LocalTransformSnapshot>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hotkeys), Member = "IsActiveInFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Object2ObjectSnapSession), Member = "SnapTargets", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Object2ObjectSnapSession), Member = "IdentifySitSurface", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600149B")]
	public void Update(IEnumerable<GameObject> targetObjects) { }

}

