namespace UnityEngine.Events;

[Token(Token = "0x20001C3")]
internal class PersistentCall : ISerializationCallbackReceiver
{
	[FieldOffset(Offset = "0x10")]
	[FormerlySerializedAs("instance")]
	[SerializeField]
	[Token(Token = "0x4000656")]
	private object m_Target; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000657")]
	private string m_TargetAssemblyTypeName; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("methodName")]
	[SerializeField]
	[Token(Token = "0x4000658")]
	private string m_MethodName; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("mode")]
	[SerializeField]
	[Token(Token = "0x4000659")]
	private PersistentListenerMode m_Mode; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[FormerlySerializedAs("arguments")]
	[SerializeField]
	[Token(Token = "0x400065A")]
	private ArgumentCache m_Arguments; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[FormerlySerializedAs("enabled")]
	[FormerlySerializedAs("m_Enabled")]
	[SerializeField]
	[Token(Token = "0x400065B")]
	private UnityEventCallState m_CallState; //Field offset: 0x38

	[Token(Token = "0x17000202")]
	public ArgumentCache arguments
	{
		[Address(RVA = "0x19865B0", Offset = "0x19857B0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C31")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000200")]
	public string methodName
	{
		[Address(RVA = "0x19865C0", Offset = "0x19857C0", Length = "0x7")]
		[CallerCount(Count = 69)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C2F")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000201")]
	public PersistentListenerMode mode
	{
		[Address(RVA = "0xFE9850", Offset = "0xFE8A50", Length = "0x96C")]
		[CallerCount(Count = 33)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_custom_attrs_free")]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "System.Threading.ThreadLocal`1+IdManager", Member = "GetId", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED940")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE460")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_method_get_class")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C30")]
		 get { } //Length: 2412
	}

	[Token(Token = "0x170001FE")]
	public object target
	{
		[Address(RVA = "0xC4A010", Offset = "0xC49210", Length = "0x7")]
		[CallerCount(Count = 196)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C2D")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170001FF")]
	public string targetAssemblyTypeName
	{
		[Address(RVA = "0x19865D0", Offset = "0x19857D0", Length = "0xBD")]
		[CalledBy(Type = typeof(PersistentCall), Member = "IsValid", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(PersistentCallGroup), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InvokableCallList), typeof(UnityEventBase)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UnityEventBase), Member = "FindMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PersistentCall)}, ReturnType = typeof(MethodInfo))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[Calls(Type = typeof(UnityEventTools), Member = "TidyAssemblyTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000C2E")]
		 get { } //Length: 189
	}

	[Address(RVA = "0x1986530", Offset = "0x1985730", Length = "0x74")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000C37")]
	public PersistentCall() { }

	[Address(RVA = "0x19865B0", Offset = "0x19857B0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C31")]
	public ArgumentCache get_arguments() { }

	[Address(RVA = "0x19865C0", Offset = "0x19857C0", Length = "0x7")]
	[CallerCount(Count = 69)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C2F")]
	public string get_methodName() { }

	[Address(RVA = "0xFE9850", Offset = "0xFE8A50", Length = "0x96C")]
	[CallerCount(Count = 33)]
	[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE460")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED940")]
	[Calls(Type = "System.Threading.ThreadLocal`1+IdManager", Member = "GetId", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_custom_attrs_free")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_method_get_class")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C30")]
	public PersistentListenerMode get_mode() { }

	[Address(RVA = "0xC4A010", Offset = "0xC49210", Length = "0x7")]
	[CallerCount(Count = 196)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C2D")]
	public object get_target() { }

	[Address(RVA = "0x19865D0", Offset = "0x19857D0", Length = "0xBD")]
	[CalledBy(Type = typeof(PersistentCall), Member = "IsValid", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PersistentCallGroup), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InvokableCallList), typeof(UnityEventBase)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityEventBase), Member = "FindMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PersistentCall)}, ReturnType = typeof(MethodInfo))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(UnityEventTools), Member = "TidyAssemblyTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000C2E")]
	public string get_targetAssemblyTypeName() { }

	[Address(RVA = "0x1985CD0", Offset = "0x1984ED0", Length = "0x509")]
	[CalledBy(Type = typeof(PersistentCall), Member = "GetRuntimeCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEventBase)}, ReturnType = typeof(BaseInvokableCall))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(ConstructorInfo), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetConstructor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type[])}, ReturnType = typeof(ConstructorInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE760")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000C34")]
	private static BaseInvokableCall GetObjectCall(object target, MethodInfo method, ArgumentCache arguments) { }

	[Address(RVA = "0x19861E0", Offset = "0x19853E0", Length = "0x2EC")]
	[CalledBy(Type = typeof(PersistentCallGroup), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InvokableCallList), typeof(UnityEventBase)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UnityEngine.Events.CachedInvokableCall`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(MethodInfo), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.Events.CachedInvokableCall`1<System.Single>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(MethodInfo), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.Events.CachedInvokableCall`1<System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(MethodInfo), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PersistentCall), Member = "GetObjectCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(MethodInfo), typeof(ArgumentCache)}, ReturnType = typeof(BaseInvokableCall))]
	[Calls(Type = typeof(InvokableCall), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(MethodInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CachedInvokableCall`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(MethodInfo), "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MethodBase), Member = "get_IsStatic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnityEventBase), Member = "FindMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PersistentCall)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000C33")]
	public BaseInvokableCall GetRuntimeCall(UnityEventBase theEvent) { }

	[Address(RVA = "0x19864F0", Offset = "0x19856F0", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PersistentCall), Member = "get_targetAssemblyTypeName", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000C32")]
	public bool IsValid() { }

	[Address(RVA = "0x1979D60", Offset = "0x1978F60", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEventTools), Member = "TidyAssemblyTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C36")]
	public override void OnAfterDeserialize() { }

	[Address(RVA = "0x1979D60", Offset = "0x1978F60", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEventTools), Member = "TidyAssemblyTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C35")]
	public override void OnBeforeSerialize() { }

}

