namespace Polytoria.Datamodel;

[Instantiatable]
[Token(Token = "0x2000373")]
public class Vector3Value : ValueBase
{
	[FieldOffset(Offset = "0x100")]
	[SyncVar(hook = "OnValueChanged")]
	[Token(Token = "0x4000F0E")]
	private Vector3 val; //Field offset: 0x100
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4000F0F")]
	public Action<Vector3, Vector3> _Mirror_SyncVarHookDelegate_val; //Field offset: 0x110

	[Token(Token = "0x17000B2C")]
	public Vector3 Networkval
	{
		[Address(RVA = "0x49E3B0", Offset = "0x49D5B0", Length = "0x19")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002557")]
		 get { } //Length: 25
		[Address(RVA = "0x49E3D0", Offset = "0x49D5D0", Length = "0x19F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3&), typeof(ulong)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(NetworkServer), Member = "get_activeHost", ReturnType = typeof(bool))]
		[Calls(Type = typeof(NetworkBehaviour), Member = "GetSyncVarHookGuard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVarHookGuard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6002558")]
		 set { } //Length: 415
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000B2B")]
	public Vector3 Value
	{
		[Address(RVA = "0x49E3B0", Offset = "0x49D5B0", Length = "0x19")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002551")]
		 get { } //Length: 25
		[Address(RVA = "0x49E570", Offset = "0x49D770", Length = "0x333")]
		[CalledBy(Type = typeof(Vector3Value), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Vector3Value), Member = "OnValueChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Vector3ValueProxy), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(LuaEvent), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009B80")]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVarHookGuard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(NetworkBehaviour), Member = "GetSyncVarHookGuard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3&), typeof(ulong)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = "Polytoria.Controllers.AbuseReportController+<SubmitAbuseReport>d__6", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(NetworkServer), Member = "get_activeHost", ReturnType = typeof(bool))]
		[Calls(Type = "Polytoria.Controllers.AppearanceController+<ProcessPlayerAppearance>d__8", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6002552")]
		 set { } //Length: 819
	}

	[Address(RVA = "0x49E2C0", Offset = "0x49D4C0", Length = "0xEF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(LuaEvent), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Instance), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Action`2<UnityEngine.Vector3, UnityEngine.Vector3>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002555")]
	public Vector3Value() { }

	[Address(RVA = "0x49DFA0", Offset = "0x49D1A0", Length = "0xD5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Instance), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Vector3Value), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6002553")]
	protected virtual void CopyProperties(Instance clone) { }

	[Address(RVA = "0x49E080", Offset = "0x49D280", Length = "0xB4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Instance), Member = "DeserializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadVector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3&), typeof(System.Action`2<UnityEngine.Vector3, UnityEngine.Vector3>), typeof(Vector3)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600255A")]
	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	[Address(RVA = "0x49E3B0", Offset = "0x49D5B0", Length = "0x19")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002557")]
	public Vector3 get_Networkval() { }

	[Address(RVA = "0x49E3B0", Offset = "0x49D5B0", Length = "0x19")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002551")]
	public Vector3 get_Value() { }

	[Address(RVA = "0x49E140", Offset = "0x49D340", Length = "0xF7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Vector3Value), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009B80")]
	[Calls(Type = typeof(LuaEvent), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002554")]
	private void OnValueChanged(Vector3 oldValue, Vector3 newValue) { }

	[Address(RVA = "0x49E240", Offset = "0x49D440", Length = "0x72")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Instance), Member = "SerializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVarULong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(Vector3)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002559")]
	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	[Address(RVA = "0x49E3D0", Offset = "0x49D5D0", Length = "0x19F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3&), typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkServer), Member = "get_activeHost", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GetSyncVarHookGuard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVarHookGuard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002558")]
	public void set_Networkval(in Vector3 value) { }

	[Address(RVA = "0x49E570", Offset = "0x49D770", Length = "0x333")]
	[CalledBy(Type = typeof(Vector3Value), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Vector3Value), Member = "OnValueChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Vector3ValueProxy), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = "Polytoria.Controllers.AppearanceController+<ProcessPlayerAppearance>d__8", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkServer), Member = "get_activeHost", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3&)}, ReturnType = typeof(bool))]
	[Calls(Type = "Polytoria.Controllers.AbuseReportController+<SubmitAbuseReport>d__6", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GetSyncVarHookGuard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVarHookGuard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009B80")]
	[Calls(Type = typeof(LuaEvent), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3&), typeof(ulong)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002552")]
	public void set_Value(Vector3 value) { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002556")]
	public virtual bool Weaved() { }

}

