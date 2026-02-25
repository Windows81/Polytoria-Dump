namespace RLD;

[Token(Token = "0x2000058")]
public class GizmoBehaviourCollection : IEnumerable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400016B")]
	private List<IGizmoBehaviour> _behaviours; //Field offset: 0x10

	[Token(Token = "0x170000BE")]
	public int Count
	{
		[Address(RVA = "0x3B0C50", Offset = "0x3AFE50", Length = "0x3C")]
		[CalledBy(Type = typeof(GizmoBehaviourCollection), Member = "GetBehavioursOfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Type"}, ReturnType = "System.Collections.Generic.List`1<Type>")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60002A4")]
		 get { } //Length: 60
	}

	[Address(RVA = "0x3B0BD0", Offset = "0x3AFDD0", Length = "0x7C")]
	[CalledBy(Type = typeof(Gizmo), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60002AE")]
	public GizmoBehaviourCollection() { }

	[Address(RVA = "0x3B06D0", Offset = "0x3AF8D0", Length = "0x9B")]
	[CalledBy(Type = typeof(Gizmo), Member = "AddBehaviour", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IGizmoBehaviour)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002A5")]
	public bool Add(IGizmoBehaviour behaviour) { }

	[Address(RVA = "0x3B0770", Offset = "0x3AF970", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002AB")]
	public bool Contains(IGizmoBehaviour behaviour) { }

	[Address(RVA = "0x3B0C50", Offset = "0x3AFE50", Length = "0x3C")]
	[CalledBy(Type = typeof(GizmoBehaviourCollection), Member = "GetBehavioursOfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Type"}, ReturnType = "System.Collections.Generic.List`1<Type>")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002A4")]
	public int get_Count() { }

	[Address(RVA = "0x6B5830", Offset = "0x6B4A30", Length = "0x2A0")]
	[CalledBy(Type = typeof(GizmoBehaviourCollection), Member = "GetFirstBehaviourOfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Type"}, ReturnType = "Type")]
	[CalledBy(Type = typeof(Gizmo), Member = "GetBehavioursOfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"BehaviourType"}, ReturnType = "System.Collections.Generic.List`1<BehaviourType>")]
	[CalledBy(Type = typeof(Gizmo), Member = "GetFirstBehaviourOfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"BehaviourType"}, ReturnType = "BehaviourType")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(GizmoBehaviourCollection), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002A9")]
	public List<Type> GetBehavioursOfType() { }

	[Address(RVA = "0x3B07D0", Offset = "0x3AF9D0", Length = "0x291")]
	[CalledBy(Type = typeof(GizmoBehaviourCollection), Member = "GetFirstBehaviourOfType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(IGizmoBehaviour))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002AA")]
	public List<IGizmoBehaviour> GetBehavioursOfType(Type behaviourType) { }

	[Address(RVA = "0x3B0A70", Offset = "0x3AFC70", Length = "0x7D")]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60002AC")]
	public IEnumerator<IGizmoBehaviour> GetEnumerator() { }

	[Address(RVA = "0x6B5AE0", Offset = "0x6B4CE0", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(GizmoBehaviourCollection), Member = "GetBehavioursOfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Type"}, ReturnType = "System.Collections.Generic.List`1<Type>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002A7")]
	public Type GetFirstBehaviourOfType() { }

	[Address(RVA = "0x3B0AF0", Offset = "0x3AFCF0", Length = "0x7E")]
	[CalledBy(Type = typeof(Gizmo), Member = "GetFirstBehaviourOfType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(IGizmoBehaviour))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GizmoBehaviourCollection), Member = "GetBehavioursOfType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(System.Collections.Generic.List`1<RLD.IGizmoBehaviour>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60002A8")]
	public IGizmoBehaviour GetFirstBehaviourOfType(Type behaviourType) { }

	[Address(RVA = "0x3B0B70", Offset = "0x3AFD70", Length = "0x53")]
	[CalledBy(Type = typeof(Gizmo), Member = "RemoveBehaviour", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IGizmoBehaviour)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002A6")]
	public bool Remove(IGizmoBehaviour behaviour) { }

	[Address(RVA = "0x3B0A70", Offset = "0x3AFC70", Length = "0x7D")]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60002AD")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

