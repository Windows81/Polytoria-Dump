namespace RLD;

[Token(Token = "0x20001DE")]
public class RTObjectGroupDb : MonoSingleton<RTObjectGroupDb>
{
	[CompilerGenerated]
	[Token(Token = "0x20001DF")]
	private sealed class <>c
	{
		[Token(Token = "0x400075E")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400075F")]
		public static Predicate<GameObject> <>9__11_0; //Field offset: 0x8

		[Address(RVA = "0x58D790", Offset = "0x58C990", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600129F")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60012A0")]
		public <>c() { }

		[Address(RVA = "0x58D4E0", Offset = "0x58C6E0", Length = "0x4C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Token(Token = "0x60012A1")]
		internal bool <RemoveNullRefs>b__11_0(GameObject item) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20001E0")]
	private sealed class <>c__DisplayClass9_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000760")]
		public string name; //Field offset: 0x10

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60012A2")]
		public <>c__DisplayClass9_0() { }

		[Address(RVA = "0x58D670", Offset = "0x58C870", Length = "0x34")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60012A3")]
		internal bool <GetGroupByName>b__0(GameObject item) { }

	}

	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x400075D")]
	private List<GameObject> _objectGroups; //Field offset: 0x20

	[Token(Token = "0x170005E1")]
	public int NumGroups
	{
		[Address(RVA = "0x5825E0", Offset = "0x5817E0", Length = "0x3C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001294")]
		 get { } //Length: 60
	}

	[Address(RVA = "0x582530", Offset = "0x581730", Length = "0xA9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600129E")]
	public RTObjectGroupDb() { }

	[Address(RVA = "0x582000", Offset = "0x581200", Length = "0x8C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001295")]
	public void Add(GameObject gameObject) { }

	[Address(RVA = "0x582090", Offset = "0x581290", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001298")]
	public void Clear() { }

	[Address(RVA = "0x5825E0", Offset = "0x5817E0", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001294")]
	public int get_NumGroups() { }

	[Address(RVA = "0x5820F0", Offset = "0x5812F0", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Token(Token = "0x600129C")]
	public List<GameObject> GetAll() { }

	[Address(RVA = "0x582160", Offset = "0x581360", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600129A")]
	public GameObject GetGroupByIndex(int index) { }

	[Address(RVA = "0x5821C0", Offset = "0x5813C0", Length = "0x120")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "FindAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Predicate`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x600129B")]
	public GameObject GetGroupByName(string name) { }

	[Address(RVA = "0x5822F0", Offset = "0x5814F0", Length = "0x53")]
	[CalledBy(Type = typeof(ObjectSelectEntireHierarchy), Member = "OnPreSelectCustomize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectPreSelectCustomizeInfo), typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectSelectEntireHierarchy), Member = "OnPreDeselectCustomize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectPreDeselectCustomizeInfo), typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectSelectEntireHierarchy), Member = "GetFurthestParentNotGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(Transform))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001299")]
	public bool IsGroup(GameObject gameObject) { }

	[Address(RVA = "0x5824D0", Offset = "0x5816D0", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001296")]
	public void Remove(GameObject gameObject) { }

	[Address(RVA = "0x582350", Offset = "0x581550", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001297")]
	public void RemoveAt(int index) { }

	[Address(RVA = "0x5823B0", Offset = "0x5815B0", Length = "0x11B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Predicate`1<System.Object>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600129D")]
	public void RemoveNullRefs() { }

}

